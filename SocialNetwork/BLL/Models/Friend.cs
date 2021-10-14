// <copyright file="Friend.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.BLL.Models
{
    /// <summary>
    /// Класс Friend
    /// </summary>
    public class Friend
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Friend"/> class.
        /// </summary>
        /// <param name="id">Ввод ID</param>
        /// <param name="user_id">Ввод Id пользователя</param>
        /// <param name="friend_id">Ввод Id друга</param>
        public Friend(int id, int user_id, int friend_id)
        {
            this.Id = id;
            this.User_id = user_id;
            this.Friend_id = friend_id;
        }

        /// <summary>
        /// Gets a value indicating whether поле для хранения Id 
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Gets a value indicating whether поле для хранения Id пользователя
        /// </summary>
        public int User_id { get; }

        /// <summary>
        /// Gets a value indicating whether поле для хранения Id друга
        /// </summary>
        public int Friend_id { get;  }
     }
}
