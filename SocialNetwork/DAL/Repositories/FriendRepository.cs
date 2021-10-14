// <copyright file="FriendRepository.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System.Collections.Generic;
using SocialNetwork.DAL.Entities;

namespace SocialNetwork.DAL.Repositories
{
    /// <summary>
    /// Интерфейс IFriendRepository
    /// </summary>
    public interface IFriendRepository
    {
        /// <summary>
        /// Метод для добавления друзей для пользователя
        /// </summary>
        /// <param name="friendEntity">Ввод FriendEntity</param>
        /// <returns> количества добавленных записей </returns>
        int Create(FriendEntity friendEntity);

        /// <summary>
        /// Метод для нахождения всех друзей для пользователя
        /// </summary>
        /// <param name="userId">Ввод Id</param>
        /// <returns> списка FriendEntity </returns>
        IEnumerable<FriendEntity> FindAllByUserId(int userId);

        /// <summary>
        /// Метод для удаления друга из друзей 
        /// </summary>
        /// <param name="id">Ввод Id</param>
        /// <returns> количества удаленных записей </returns>
        int Delete(int id);
    }

    /// <summary>
    /// Класс FriendRepository
    /// </summary>
    public class FriendRepository : BaseRepository, IFriendRepository
    {
        /// <summary>
        /// Метод для нахождения всех друзей для пользователя
        /// </summary>
        /// <param name="userId">Ввод Id</param>
        /// <returns> списка FriendEntity </returns>
        public IEnumerable<FriendEntity> FindAllByUserId(int userId)
        {
            return Query<FriendEntity>(@"select * from friends where user_id = :user_id", new { user_id = userId });
        }

        /// <summary>
        /// Метод для добавления друзей для пользователя
        /// </summary>
        /// <param name="friendEntity">Ввод FriendEntity</param>
        /// <returns> количества добавленных записей </returns>
        public int Create(FriendEntity friendEntity)
        {
            return Execute(@"insert into friends (user_id,friend_id) values (:user_id,:friend_id)", friendEntity);
        }

        /// <summary>
        /// Метод для удаления друга из друзей 
        /// </summary>
        /// <param name="id">Ввод Id</param>
        /// <returns> количества удаленных записей </returns>
        public int Delete(int id)
        {
            return Execute(@"delete from friends where id = :id_p", new { id_p = id });
        }
    }
}
