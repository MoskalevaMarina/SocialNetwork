// <copyright file="UserFriends.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.BLL.Models
{
    /// <summary>
    /// Класс UserFriends
    /// </summary>
    public class UserFriends
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserFriends"/> class.
        /// </summary>
        /// <param name="id">Ввод ID</param>
        /// <param name="friend_firstname">Ввод имени</param>
        /// <param name="friend_email">Ввод email</param>
        public UserFriends(int id, string friend_firstname, string friend_email)
        {
            this.Friend_id = id;
            this.Friend_firstname = friend_firstname;
            this.Friend_email = friend_email;
        }

        /// <summary>
        /// Gets a value indicating whether поле для хранения Id друга
        /// </summary>
        public int Friend_id { get; }

        /// <summary>
        /// Gets a value indicating whether поле для хранения Id имени
        /// </summary>
        public string Friend_firstname { get; }

        /// <summary>
        /// Gets a value indicating whether поле для хранения Id email
        /// </summary>
        public string Friend_email { get;  }
     }
}
