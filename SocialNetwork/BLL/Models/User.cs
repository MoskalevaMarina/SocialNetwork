// <copyright file="User.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.BLL.Models
{
    /// <summary>
    /// Класс User
    /// </summary>
    public class User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        /// <param name="id">Ввод ID</param>
        /// <param name="firstName">Ввод имени пользователя</param>
        /// <param name="lastName">Ввод фамилии</param>
        /// <param name="password">Ввод пароля</param>
        /// <param name="email">Ввод email</param>
        /// <param name="photo">Ввод фото</param>
        /// <param name="favoriteMovie">Ввод любимых видео</param>
        /// <param name="favoriteBook">Ввод любимых книг</param>
        /// <param name="incomingMessages">Ввод входящих сообщений</param>
        /// <param name="outgoingMessages">Ввод исходящих сообщений</param>
        /// <param name="userFriends">Ввод друзей пользователя</param>
        public User(
            int id,
            string firstName,
            string lastName,
            string password,
            string email,
            string photo,
            string favoriteMovie,
            string favoriteBook,
            IEnumerable<Message> incomingMessages,
            IEnumerable<Message> outgoingMessages,
            IEnumerable<UserFriends> userFriends)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.Email = email;
            this.Photo = photo;
            this.FavoriteMovie = favoriteMovie;
            this.FavoriteBook = favoriteBook;
            this.IncomingMessages = incomingMessages;
            this.OutgoingMessages = outgoingMessages;
            this.UserFriends = userFriends;
        }

        /// <summary>
        /// Gets a value indicating whether поле для хранения Id 
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Gets or sets value indicating whether поле для хранения имени
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether поле для хранения фамилии
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether поле для хранения пароля
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether поле для хранения email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether поле для хранения фото
        /// </summary>
        public string Photo { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether поле для хранения любимых видео
        /// </summary>
        public string FavoriteMovie { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether поле для хранения любимых книг
        /// </summary>
        public string FavoriteBook { get; set; }

        /// <summary>
        /// Gets a value indicating whether поле для хранения входящих сообщений
        /// </summary>
        public IEnumerable<Message> IncomingMessages { get; }

        /// <summary>
        /// Gets a value indicating whether поле для хранения исходящих сообщений
        /// </summary>
        public IEnumerable<Message> OutgoingMessages { get; }

        /// <summary>
        /// Gets a value indicating whether поле для хранения друзей пользователя
        /// </summary>
         public IEnumerable<UserFriends> UserFriends { get; }
    }
}
