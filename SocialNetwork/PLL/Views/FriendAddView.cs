// <copyright file="FriendAddView.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;

namespace SocialNetwork.PLL.Views
{
    /// <summary>
    /// Класс FriendAddView
    /// </summary>
    public class FriendAddView
    {
        UserService userService;
        FriendService friendService;
     
        public FriendAddView(FriendService friendService, UserService userService)
        {
            this.friendService = friendService;
            this.userService = userService;
        }

        public void Show(User user)
        {
            var friendAddData = new FriendAddData();

            Console.Write("Введите почтовый адрес пользователя, которого хотите добавить в друзья: ");
            friendAddData.FriendEmail = Console.ReadLine();

            friendAddData.User_id= user.Id;

            try
            {
                friendService.AddFriends(friendAddData);
               
                SuccessMessage.Show("Друг успешно добавлен!");

                user = userService.FindById(user.Id);
            }

            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь не найден!");
            }

            catch (ArgumentNullException)
            {
                AlertMessage.Show("Введите корректное значение!");
            }
        //    catch (WrongAddUserException)
        //    {
        //        AlertMessage.Show("Такой друг уже есть!");
        //    }
            catch (Exception)
            {
                AlertMessage.Show("Произошла ошибка при добавлении друга!");
            }

        }
    }
}
