using Microsoft.Extensions.Configuration;
using SampleWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;

namespace SampleWebApp.Services
{
    public interface IDatabaseService
    {
        IEnumerable<Animal> GetAnimals();
        Task<IEnumerable<Animal>> GetAnimalsByStoredProcedureAsync();
        Task<IEnumerable<Animal>> GetAnimalsAsync();
        Task<int> ChangeAnimalAsync();
        Task<Animal> CreateAnimal(Animal animal);
        Task<int> DeleteAnimal(int id);
    }


    public class DatabaseService : IDatabaseService
    {
        private readonly string _connectionString;
        public DatabaseService()
        {
            _connectionString = "Server=db-mssql16.pjwstk.edu.pl;Database=pd3825;Trusted_Connection=True;";
        }
        public IEnumerable<Animal> GetAnimals()
        {
            using var con = new SqlConnection(_connectionString);
            using var com = new SqlCommand("select * from animal", con);
            con.Open();
            var dr = com.ExecuteReader();
            var result = new List<Animal>();
            while (dr.Read())
            {
                Thread.Sleep(300);
                result.Add(new Animal
                {
                    IdAnimal = Convert.ToInt16(dr["IdAnimal"].ToString()),
                    Name = dr["Name"].ToString(),
                    Description = dr["Description"].ToString(),
                    Category = dr["Category"].ToString(),
                    Area = dr["Area"].ToString()
                });
            }

            return result;
        }


        public async Task<int> ChangeAnimalAsync()
        {
            using var con = new SqlConnection(_connectionString);
            using var com = new SqlCommand("select * from animal", con);

            await con.OpenAsync();
            DbTransaction tran = await con.BeginTransactionAsync();
            com.Transaction = (SqlTransaction)tran;

            try
            {
                var list = new List<Animal>();
                using (var dr = await com.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Animal
                        {
                            Name = dr["Name"].ToString(),
                            Description = dr["Description"].ToString()
                        });
                    }
                }

                com.Parameters.Clear();
                com.CommandText = "UPDATE Animal SET Name=Name+'a' WHERE Name=@Name";
                com.Parameters.AddWithValue("@Name", list[0].Name);
                await com.ExecuteNonQueryAsync();

                throw new Exception("Error");

                com.Parameters.Clear();
                com.Parameters.AddWithValue("@Name", list[1].Name);
                await com.ExecuteNonQueryAsync();

                await tran.CommitAsync();
            }
            catch (SqlException exc)
            {
                await tran.RollbackAsync();
            }
            catch (Exception exc)
            {  
                await tran.RollbackAsync();
            }

            return 1;
        }

        public async Task<IEnumerable<Animal>> GetAnimalsAsync()
        {
            using var con = new SqlConnection(_connectionString);
            using var com = new SqlCommand("select * from animal", con);
            await con.OpenAsync();
            var dr = await com.ExecuteReaderAsync();
            var result = new List<Animal>();
            while (await dr.ReadAsync())
            {
                await Task.Delay(300);
                result.Add(new Animal
                {
                    Name = dr["Name"].ToString(),
                    Description = dr["Description"].ToString()
                });
            }

            return result;
        }

        public async Task<IEnumerable<Animal>> GetAnimalsByStoredProcedureAsync()
        {
            using var con = new SqlConnection(_connectionString);
            using var com = new SqlCommand("GetAnimals", con);
            com.CommandType = CommandType.StoredProcedure;

            await con.OpenAsync();
            var result = new List<Animal>();
            using (var dr = await com.ExecuteReaderAsync())
            {
                while (await dr.ReadAsync())
                {
                    result.Add(new Animal
                    {
                        Name = dr["Name"].ToString(),
                        Description = dr["Description"].ToString()
                    });
                }
            }

            return result;
        }

        public async Task<Animal> CreateAnimal(Animal animal)
        {
            Animal res = null;
            using (var con = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"INSERT INTO Animal(IdAnimal, Name, Description, Category, Area) " +
                    @"Values(@IdAnimal, @Name, @Description, @Category, @Area);";

                cmd.Parameters.AddWithValue("@Name", animal.IdAnimal);
                cmd.Parameters.AddWithValue("@Name", animal.Name);
                cmd.Parameters.AddWithValue("@Description", animal.Description);
                cmd.Parameters.AddWithValue("@Category", animal.Category);
                cmd.Parameters.AddWithValue("@Area", animal.Area);
                con.Open();
                var cntInserted = await cmd.ExecuteNonQueryAsync();
                if (cntInserted == 1)
                {
                    cmd.CommandText = "SELECT * FROM Animal WHERE IdAnimal=@IdAnimal AND Name=@Name AND Description=@Description AND Category=@Category AND Area=@Area";
                    SqlDataReader dr = await cmd.ExecuteReaderAsync();
                    while (dr.Read())
                    {
                        res = new Animal()
                        {
                            IdAnimal = Convert.ToInt16(dr["IdAnimal"].ToString()),
                            Name = dr["Name"].ToString(),
                            Description = dr["Description"].ToString(),
                            Category = dr["Category"].ToString(),
                            Area = dr["Area"].ToString()
                        };
                    }
                }
                cmd.Dispose();
            }
            return res;
        }

        public async Task<int> DeleteAnimal(int id)
        {
            int res = 0;
            using (var con = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM Animal WHERE IdAnimal=@AnimalID;";
                cmd.Parameters.AddWithValue("@AnimalID", id);
                con.Open();
                res = await cmd.ExecuteNonQueryAsync();
                cmd.Dispose();
            }
            return res;
        }
    }
}
