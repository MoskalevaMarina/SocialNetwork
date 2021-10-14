// <copyright file="UserOutcomingMessageView.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    /// <summary>
    /// Класс UserOutcomingMessageView
    /// </summary>
    public class UserOutcomingMessageView
    {
        /// <summary>
        /// Метод для вывода исходящих сообщений
        /// </summary>
        public void Show(IEnumerable<Message> outcomingMessages)
        {
            Console.WriteLine("Исходящие сообщения");

            if (outcomingMessages.Count() == 0)
            {
                Console.WriteLine("Исходящих сообщений нет");
                return;
            }

            outcomingMessages.ToList().ForEach(message =>
            {
                Console.WriteLine("Кому: {0}. Текст сообщения: {1}", message.RecipientEmail, message.Content);
            });
        }
    }
}
