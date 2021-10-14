// <copyright file="UserService.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System;
using System.ComponentModel.DataAnnotations;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;

namespace SocialNetwork.BLL.Services
{
    /// <summary>
    /// Класс UserService
    /// </summary>
    public class UserService
    {
        /// <summary>
        /// Поле MessageService
        /// </summary>
       private readonly MessageService messageService;

        /// <summary>
        /// Поле IUserRepository
        /// </summary>
       private readonly FriendService friendService;

        /// <summary>
        /// Поле IMessageRepository
        /// </summary>
        private readonly IUserRepository userRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserService"/> class.
        /// </summary>
        public UserService()
        {
            this.userRepository = new UserRepository();
            this.messageService = new MessageService();
            this.friendService = new FriendService();
        }

        /// <summary>
        /// Метод для регистрации
        /// </summary>
        /// <param name="userRegistrationData">Ввод данных при регистрации</param>
        public void Register(UserRegistrationData userRegistrationData)
        {
            if (string.IsNullOrEmpty(userRegistrationData.FirstName))
            {
                throw new ArgumentNullException();
            }

            if (string.IsNullOrEmpty(userRegistrationData.LastName))
            {
                throw new ArgumentNullException();
            }

            if (string.IsNullOrEmpty(userRegistrationData.Password))
            {
                throw new ArgumentNullException();
            }

            if (string.IsNullOrEmpty(userRegistrationData.Email))
            {
                throw new ArgumentNullException();
            }

            if (userRegistrationData.Password.Length < 8)
            {
                throw new ArgumentNullException();
            }

            if (!new EmailAddressAttribute().IsValid(userRegistrationData.Email))
            {
                throw new ArgumentNullException();
            }

            if (this.userRepository.FindByEmail(userRegistrationData.Email) != null)
            {
                throw new ArgumentNullException();
            }

            var userEntity = new UserEntity()
            {
                Firstname = userRegistrationData.FirstName,
                Lastname = userRegistrationData.LastName,
                Password = userRegistrationData.Password,
                Email = userRegistrationData.Email
            };

            if (this.userRepository.Create(userEntity) == 0)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Метод для авторизации
        /// </summary>
        /// <param name="userAuthenticationData">Ввод данных при авторизации</param>
        /// <returns> возвращает пользователя </returns>
        public User Authenticate(UserAuthenticationData userAuthenticationData)
        {
            var findUserEntity = this.userRepository.FindByEmail(userAuthenticationData.Email);
            if (findUserEntity is null)
            {
                throw new UserNotFoundException();
            }

            if (findUserEntity.Password != userAuthenticationData.Password)
            {
                throw new WrongPasswordException();
            }

            return this.ConstructUserModel(findUserEntity);
        }

        /// <summary>
        /// Метод для нахождения пользователя по email
        /// </summary>
        /// <param name="email">Ввод email</param>
        /// <returns> возвращает пользователя </returns>
        public User FindByEmail(string email)
        {
            var findUserEntity = this.userRepository.FindByEmail(email);
            if (findUserEntity is null)
            {
                throw new UserNotFoundException();
            }

            return this.ConstructUserModel(findUserEntity);
        }

        /// <summary>
        /// Метод для нахождения пользователя для id
        /// </summary>
        /// <param name="id">Ввод id</param>
        /// <returns> возвращает пользователя </returns>
        public User FindById(int id)
        {
            var findUserEntity = this.userRepository.FindById(id);
            if (findUserEntity is null)
            {
                throw new UserNotFoundException();
            }

            return this.ConstructUserModel(findUserEntity);
        }

        /// <summary>
        /// Метод для обновления данных о пользователи
        /// </summary>
        /// <param name="user">Ввод пользователя</param>
        public void Update(User user)
        {
            var updatableUserEntity = new UserEntity()
            {
                Id = user.Id,
                Firstname = user.FirstName,
                Lastname = user.LastName,
                Password = user.Password,
                Email = user.Email,
                Photo = user.Photo,
                Favorite_movie = user.FavoriteMovie,
                Favorite_book = user.FavoriteBook
            };

            if (this.userRepository.Update(updatableUserEntity) == 0)
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Метод ConstructUserModel
        /// </summary>
        /// <param name="userEntity">Ввод userEntity</param>
        /// <returns> возвращает пользователя </returns>
        private User ConstructUserModel(UserEntity userEntity)
        {
            var incomingMessages = this.messageService.GetIncomingMessagesByUserId(userEntity.Id);

            var outgoingMessages = this.messageService.GetOutcomingMessagesByUserId(userEntity.Id);

            var userfriends = this.friendService.GetFriends(userEntity.Id);
            
            return new User(
                          userEntity.Id,
                          userEntity.Firstname,
                          userEntity.Lastname,
                          userEntity.Password,
                          userEntity.Email,
                          userEntity.Photo,
                          userEntity.Favorite_movie,
                          userEntity.Favorite_book,
                          incomingMessages,
                          outgoingMessages,
                          userfriends);
        }
    }
}