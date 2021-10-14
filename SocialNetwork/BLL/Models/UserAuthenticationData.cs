// <copyright file="UserAuthenticationData.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.BLL.Models
{
    /// <summary>
    /// Класс UserAuthenticationData
    /// </summary>
    public class UserAuthenticationData
    {
        /// <summary>
        /// Gets or sets value indicating whether поле для email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether поле для пароля
        /// </summary>
        public string Password { get; set; }
    }
}
