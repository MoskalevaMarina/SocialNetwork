// <copyright file="MessageSendingData.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.BLL.Models
{
    /// <summary>
    /// Класс MessageSendingData
    /// </summary>
    public class MessageSendingData
    {
        /// <summary>
        /// Gets or sets a value indicating whether поле для хранения Id отправителя
        /// </summary>
        public int SenderId { get; set; }
        
        /// <summary>
        /// Gets or sets a value indicating whether поле для хранения текста сообщения
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether поле для хранения email получателя
        /// </summary>
        public string RecipientEmail { get; set; }
    }
}
