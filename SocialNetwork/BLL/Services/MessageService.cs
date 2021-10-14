// <copyright file="MessageService.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;

namespace SocialNetwork.BLL.Services
{
    /// <summary>
    /// Класс MessageService
    /// </summary>
    public class MessageService
    {
        /// <summary>
        /// Поле IMessageRepository
        /// </summary>
        private readonly IMessageRepository messageRepository;

        /// <summary>
        /// Поле  IUserRepository
        /// </summary>
        private readonly IUserRepository userRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageService"/> class.
        /// </summary>
        public MessageService()
        {
            this.userRepository = new UserRepository();
            this.messageRepository = new MessageRepository();
        }

        /// <summary>
        /// Метод получения списка входящих сообщений
        /// </summary>
        /// <param name="recipientId">Ввод ID</param>
        /// <returns> список сообщений </returns>
        public IEnumerable<Message> GetIncomingMessagesByUserId(int recipientId)
        {
            var messages = new List<Message>();

            this.messageRepository.FindByRecipientId(recipientId).ToList().ForEach(m =>
            {
                var senderUserEntity = userRepository.FindById(m.Sender_id);
                var recipientUserEntity = userRepository.FindById(m.Recipient_id);

                messages.Add(new Message(m.Id, m.Content, senderUserEntity.Email, recipientUserEntity.Email));
            });

            return messages;
        }

        /// <summary>
        /// Метод получения списка исходящих сообщений
        /// </summary>
        /// <param name="senderId">Ввод ID</param>
        /// <returns> список сообщений </returns>
        public IEnumerable<Message> GetOutcomingMessagesByUserId(int senderId)
        {
            var messages = new List<Message>();

            this.messageRepository.FindBySenderId(senderId).ToList().ForEach(m =>
            {
                var senderUserEntity = userRepository.FindById(m.Sender_id);
                var recipientUserEntity = userRepository.FindById(m.Recipient_id);

                messages.Add(new Message(m.Id, m.Content, senderUserEntity.Email, recipientUserEntity.Email));
            });

            return messages;
        }

        /// <summary>
        /// Метод отправки сообщений
        /// </summary>
        /// <param name="messageSendingData">Ввод данных при отправлении</param>
        public void SendMessage(MessageSendingData messageSendingData)
        {
            if (string.IsNullOrEmpty(messageSendingData.Content))
            {
                throw new ArgumentNullException();
            }

            if (messageSendingData.Content.Length > 5000)
            {
                throw new ArgumentOutOfRangeException();
            }

            var findUserEntity = this.userRepository.FindByEmail(messageSendingData.RecipientEmail);
            if (findUserEntity is null)
            {
                throw new UserNotFoundException();
            }

            var messageEntity = new MessageEntity()
            {
                Content = messageSendingData.Content,
                Sender_id = messageSendingData.SenderId,
                Recipient_id = findUserEntity.Id
            };

            if (this.messageRepository.Create(messageEntity) == 0)
            {
                throw new Exception();
            }
        }
    }
}
