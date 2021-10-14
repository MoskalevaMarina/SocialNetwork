// <copyright file="UserIncomingMessageView.cs" company="My Company Marina">
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
    /// Класс UserIncomingMessageView
    /// </summary>
    public class UserIncomingMessageView
    {
        public void Show(IEnumerable<Message> incomingMessages)
        {
            Console.WriteLine("Входящие сообщения");


            if (incomingMessages.Count() == 0)
            {
                Console.WriteLine("Входящих сообщения нет");
                return;
            }

            incomingMessages.ToList().ForEach(message =>
            {
                Console.WriteLine("От кого: {0}. Текст сообщения: {1}", message.SenderEmail, message.Content);
            });
        }
    }
}
