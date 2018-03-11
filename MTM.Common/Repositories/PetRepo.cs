using MTM.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MTM.Models.Models;
using Dapper;
using Dapper.Contrib;
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

        public IQueryable<Pet> Create(Pet Entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Pet> Delete(Pet Entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Pet> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                return connection.Query<Pet>("Select * from Pet").AsQueryable();
            }
        }

        public IQueryable<Pet> GetById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Pet> Update(Pet Entity)
        {
            throw new NotImplementedException();
        }
    }
}
