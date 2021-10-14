// <copyright file="MessageEntity.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.DAL.Entities
{
    /// <summary>
    /// Класс MessageEntity
    /// </summary>
    public class MessageEntity
    {
        /// <summary>
        /// Gets or sets value indicating whether поле для хранения Id 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether поле для хранения текста сообщения
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether поле для хранения Id отправителя
        /// </summary>
        public int Sender_id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether поле для хранения Id получателя
        /// </summary>
        public int Recipient_id { get; set; }
    }
}
