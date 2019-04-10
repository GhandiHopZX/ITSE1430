﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager.Sql
{
    public class SqlGameDatabase : GameDatabase
    {
        public SqlGameDatabase ( string connectionString )
        {
            _connectionString = connectionString;
        }

        private readonly string _connectionString;

        protected override Game AddCore( Game game )
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                //var cmd = new SqlCommand("", connection);
                var cmd = connection.CreateCommand();
                cmd.CommandText = "AddGame";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //Add parameter 1
                var parameter = new SqlParameter("@name", System.Data.SqlDbType.NVarChar) {
                    Value = game.Name
                };
                cmd.Parameters.Add(parameter);

                //Add parameter 2
                cmd.Parameters.AddWithValue("@description", game.Description);
                cmd.Parameters.AddWithValue("@price", game.Price);
                cmd.Parameters.AddWithValue("@completed", game.Completed);
                cmd.Parameters.AddWithValue("@owned", game.Owned);

                var result2 = Convert.ToInt32(cmd.ExecuteScalar());

                game.Id = result2;
                return game;
            };

            throw new NotImplementedException();
        }

        private SqlConnection GetConnection() => new SqlConnection(_connectionString);

        protected override void DeleteCore( int id ) => throw new NotImplementedException();

        protected override IEnumerable<Game> GetAllCore() =>
            //throw new NotImplementedException();
            Enumerable.Empty<Game>();

        protected override Game GetCore( int id ) =>
            //throw new NotImplementedException();
            null;

        protected override Game UpdateCore( int id, Game newGame ) => throw new NotImplementedException();
    }
}
