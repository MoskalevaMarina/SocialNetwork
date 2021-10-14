// <copyright file="FriendService.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;

namespace SocialNetwork.BLL.Services
{
    /// <summary>
    /// Класс FriendService
    /// </summary>
    public class FriendService
    {
        /// <summary>
        /// Поле IFriendRepository
        /// </summary>
        private readonly IFriendRepository friendRepository;

        /// <summary>
        /// Поле IUserRepository
        /// </summary>
        private readonly IUserRepository userRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="FriendService"/> class.
        /// </summary>
       public FriendService()
        {
            this.userRepository = new UserRepository();
            this.friendRepository = new FriendRepository();
        }

        /// <summary>
        /// Метод получения списка друзей
        /// </summary>
        /// <param name="userId">Ввод ID</param>
        /// <returns> список друзей </returns>
       public IEnumerable<UserFriends> GetFriends(int userId)
        {
            var friends = new List<UserFriends>();

            this.friendRepository.FindAllByUserId(userId).ToList().ForEach(m =>
            {
                var friendEntity = userRepository.FindById(m.Friend_id);
                friends.Add(new UserFriends(friendEntity.Id, friendEntity.Firstname, friendEntity.Email));
            });

            return friends;
        }

        /// <summary>
        /// Метод добавления пользователя в друзья
        /// </summary>
        /// <param name="friendAddData">Ввод данных о друге</param>
        public void AddFriends(FriendAddData friendAddData)
        {
             var findUserEntity = this.userRepository.FindByEmail(friendAddData.FriendEmail);
            if (findUserEntity is null)
            {
                throw new UserNotFoundException();
            }

            var friendEntity = new FriendEntity()
            {
                Friend_id = findUserEntity.Id,
                User_id = friendAddData.User_id
             };

            if (this.friendRepository.Create(friendEntity) == 0)
            {
                throw new Exception();
            }
        }
    }
}
