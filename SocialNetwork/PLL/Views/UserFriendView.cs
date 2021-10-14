// <copyright file="UserFriendView.cs" company="My Company Marina">
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
    /// Класс UserFriendView
    /// </summary>
    public class UserFriendView
    {
        public void Show(IEnumerable<UserFriends> friends)
        {
            Console.WriteLine("Список друзей");


            if (friends.Count() == 0)
            {
                Console.WriteLine("Друзей нет");
                return;
            }

            friends.ToList().ForEach(f =>
            {
                Console.WriteLine("Имя: {0}, email: {1}", f.Friend_id, f.Friend_email);
            });
        }
    }
}

