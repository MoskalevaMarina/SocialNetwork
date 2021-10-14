// <copyright file="FriendAddData.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.BLL.Models
{
    /// <summary>
    /// Класс FriendAddData
    /// </summary>
    public class FriendAddData
    {
        /// <summary>
        /// Gets or sets value indicating whether поле для хранения Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether поле для хранения Id пользователя
        /// </summary>
        public int User_id { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether поле для хранения email друга
        /// </summary>
        public string FriendEmail { get; set; }
    }
}
