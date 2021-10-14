// <copyright file="BaseRepository.cs" company="My Company Marina">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using Dapper;

namespace SocialNetwork.DAL.Repositories
{
    /// <summary>
    /// Класс BaseRepository
    /// </summary>
    public class BaseRepository
    {
        /// <summary>
        /// Метод для нахождения соединения
        /// </summary>
        /// <param name="sql">Ввод sql</param>
        /// <param name="parameters">Ввод parameters</param>
        /// <returns> соединение T </returns>
        protected T QueryFirstOrDefault<T>(string sql, object parameters = null)
        {
            using (var connection = this.CreateConnection())
            {
                connection.Open();
                return connection.QueryFirstOrDefault<T>(sql, parameters);
            }
        }

        /// <summary>
        /// Метод для нахождения соединения
        /// </summary>
        /// <param name="sql">Ввод sql</param>
        /// <param name="parameters">Ввод parameters</param>
        /// <returns> список соединений T </returns>
        protected List<T> Query<T>(string sql, object parameters = null)
        {
            using (var connection = this.CreateConnection())
            {
                connection.Open();
                return connection.Query<T>(sql, parameters).ToList();
            }
        }

        /// <summary>
        /// Метод для выполнения
        /// </summary>
        /// <param name="sql">Ввод sql</param>
        /// <param name="parameters">Ввод parameters</param>
        /// <returns> количество записей </returns>
        protected int Execute(string sql, object parameters = null)
        {
            using (var connection = this.CreateConnection())
            {
                connection.Open();
                return connection.Execute(sql, parameters);
            }
        }

        /// <summary>
        /// Метод для определения соединения
        /// </summary>
        /// <returns> соединение IDbConnection </returns>
        private IDbConnection CreateConnection()
        {
            return new SQLiteConnection("Data Source = DAL/DB/social_network_bd.db; Version = 3");
        }
    }
}
