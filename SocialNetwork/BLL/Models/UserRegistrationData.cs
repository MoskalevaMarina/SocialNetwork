// <copyright file="UserRegistrationData.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.BLL.Models
{
    /// <summary>
    /// Класс UserRegistrationData
    /// </summary>
    public class UserRegistrationData
    {
        /// <summary>
        /// Gets or sets value indicating whether поле для имени
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether поле для фамилии
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether поле для пароля
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether поле для email
        /// </summary>
        public string Email { get; set; }

    }
}
