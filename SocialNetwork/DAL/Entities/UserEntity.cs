// <copyright file="UserEntity.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.DAL.Entities
{
    /// <summary>
    /// Класс UserEntity
    /// </summary>
    public class UserEntity
    {
        /// <summary>
        /// Gets or sets value indicating whether поле для хранения Id 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether поле для хранения имени
        /// </summary>
        public string Firstname { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether поле для хранения фамилии
        /// </summary>
        public string Lastname { get; set; }

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
        public string Favorite_movie { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether поле для хранения любимых книг
        /// </summary>
        public string Favorite_book { get; set; }
    }
}
