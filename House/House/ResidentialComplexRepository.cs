using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using House.Models;

namespace House.DataAccess
{
    /// <summary>
    /// Репозиторий для работы с жилищными комплексами
    /// </summary>
    public class ResidentialComplexRepository
    {
        public List<ResidentialComplex> GetAll()
        {
            var complexes = new List<ResidentialComplex>();

            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT Id, Name, City, Status, ComplexCostCoefficient, 
                           ConstructionCost, IsDeleted, CreatedDate, ModifiedDate
                    FROM ResidentialComplex
                    WHERE IsDeleted = 0
                    ORDER BY City, 
                             CASE Status 
                                 WHEN N'план' THEN 1 
                                 WHEN N'строительство' THEN 2 
                                 WHEN N'реализация' THEN 3 
                             END";

                using (var command = new SqlCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        complexes.Add(MapFromReader(reader));
                    }
                }
            }

            return complexes;
        }

        public ResidentialComplex GetById(int id)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT Id, Name, City, Status, ComplexCostCoefficient, 
                           ConstructionCost, IsDeleted, CreatedDate, ModifiedDate
                    FROM ResidentialComplex
                    WHERE Id = @Id AND IsDeleted = 0";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapFromReader(reader);
                        }
                    }
                }
            }

            return null;
        }

        private ResidentialComplex MapFromReader(SqlDataReader reader)
        {
            return new ResidentialComplex
            {
                Id = reader.GetInt32(0),
                Name = reader.GetString(1),
                City = reader.GetString(2),
                Status = reader.GetString(3),
                ComplexCostCoefficient = reader.GetDecimal(4),
                ConstructionCost = reader.GetDecimal(5),
                IsDeleted = reader.GetBoolean(6),
                CreatedDate = reader.GetDateTime(7),
                ModifiedDate = reader.GetDateTime(8)
            };
        }
    }
}
