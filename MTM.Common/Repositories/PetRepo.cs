using MTM.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MTM.Models.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Data.SqlClient;
using System.Data;

namespace MTM.Common.Repositories
{
    public class PetRepo : IMTMProvider<Pet>
    {
        private string _connectionString;

        public PetRepo(string connection)
        {
            this._connectionString = connection;
        }

        public Pet Create(Pet Entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                //Setup a few of the defaults
                Entity.Active = true;
                Entity.CreatedDate = DateTime.Now;
                Entity.ModifiedDate = DateTime.Now;
                Entity.ModifiedBy = Guid.NewGuid();

                connection.Insert<Pet>(Entity);

                return Entity;
            }
        }

        public int Delete(Guid Id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                return connection.Execute("Delete from Pet where id = @Id", new { Id = Id });
            }
        }

        public IQueryable<Pet> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                return connection.Query<Pet>("Select * from Pet").AsQueryable();
            }
        }

        public Pet GetById(Guid Id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                return connection.Query<Pet>("Select * from Pet where id = @Id", new { Id = Id }).FirstOrDefault();
            }
        }

        public Pet Update(Pet Entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                //Setup a few of the defaults
                Entity.ModifiedDate = DateTime.Now;
                Entity.ModifiedBy = Guid.NewGuid();

                connection.Update<Pet>(Entity);

                return Entity;
            }
        }
    }
}
