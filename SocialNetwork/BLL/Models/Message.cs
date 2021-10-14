// <copyright file="Message.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.BLL.Models
{
    /// <summary>
    /// Класс Message
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Message"/> class.
        /// </summary>
        /// <param name="id">Ввод ID</param>
        /// <param name="content">Ввод текста сообщения</param>
        /// <param name="senderEmail">Ввод email отправителя</param>
        /// <param name="recipientEmail">Ввод email получателя</param>
        public Message(int id, string content, string senderEmail, string recipientEmail)
        {
            this.Id = id;
            this.Content = content;
            this.SenderEmail = senderEmail;
            this.RecipientEmail = recipientEmail;
        }

        /// <summary>
        /// Gets a value indicating whether поле для хранения Id 
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Gets a value indicating whether поле для хранения текста сообщения
        /// </summary>
        public string Content { get; }

        /// <summary>
        /// Gets a value indicating whether поле для хранения email отправителя
        /// </summary>
        public string SenderEmail { get; }

        /// <summary>
        /// Gets a value indicating whether поле для хранения email получателя
        /// </summary>
        public string RecipientEmail { get; }
    }
}
