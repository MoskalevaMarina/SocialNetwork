// <copyright file="Tests.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using NUnit.Framework;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;

namespace SocialNetwork.Tests
{
    /// <summary>
    /// Класс Для тестирования
    /// </summary>
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

       [Test]
        public void FindByIdMustReturnNotNull()
        {
            var userServiceTest = new UserService();
            var userPit = new UserRegistrationData()
            {
                FirstName = "Pit",
                LastName = "Poter",
                Email = "pit@gmail.com",
                Password = "12345678"
            };
            userServiceTest.Register(userPit);

            Assert.IsNotNull(userServiceTest.FindById(1));
        }
    }
}