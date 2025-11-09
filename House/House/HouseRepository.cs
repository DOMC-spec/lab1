using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using House.Models;

namespace House.DataAccess
{
    /// <summary>
    /// Репозиторий для работы с домами
    /// </summary>
    public class HouseRepository
    {
        public List<HouseModel> GetAll(int? complexId = null, string addressFilter = null)
        {
            var houses = new List<HouseModel>();

            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT 
                        h.Id,
                        h.ResidentialComplexId,
                        h.Street,
                        h.HouseNumber,
                        h.HouseCostCoefficient,
                        h.ConstructionCost,
                        h.IsDeleted,
                        h.CreatedDate,
                        h.ModifiedDate,
                        rc.Name AS ComplexName,
                        rc.Status AS ComplexStatus,
                        (SELECT COUNT(*) FROM Apartment a 
                         WHERE a.HouseId = h.Id AND a.Status = N'продана' AND a.IsDeleted = 0) AS SoldCount,
                        (SELECT COUNT(*) FROM Apartment a 
                         WHERE a.HouseId = h.Id AND a.Status = N'продается' AND a.IsDeleted = 0) AS SellingCount
                    FROM House h
                    INNER JOIN ResidentialComplex rc ON h.ResidentialComplexId = rc.Id
                    WHERE h.IsDeleted = 0";

                if (complexId.HasValue)
                {
                    query += " AND h.ResidentialComplexId = @ComplexId";
                }

                if (!string.IsNullOrWhiteSpace(addressFilter))
                {
                    query += " AND (h.Street LIKE @AddressFilter OR h.HouseNumber LIKE @AddressFilter)";
                }

                query += " ORDER BY rc.Name, h.Street, h.HouseNumber";

                using (var command = new SqlCommand(query, connection))
                {
                    if (complexId.HasValue)
                    {
                        command.Parameters.AddWithValue("@ComplexId", complexId.Value);
                    }

                    if (!string.IsNullOrWhiteSpace(addressFilter))
                    {
                        command.Parameters.AddWithValue("@AddressFilter", "%" + addressFilter + "%");
                    }

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            houses.Add(MapFromReader(reader));
                        }
                    }
                }
            }

            return houses;
        }

        public HouseModel GetById(int id)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT 
                        h.Id,
                        h.ResidentialComplexId,
                        h.Street,
                        h.HouseNumber,
                        h.HouseCostCoefficient,
                        h.ConstructionCost,
                        h.IsDeleted,
                        h.CreatedDate,
                        h.ModifiedDate,
                        rc.Name AS ComplexName,
                        rc.Status AS ComplexStatus,
                        0 AS SoldCount,
                        0 AS SellingCount
                    FROM House h
                    INNER JOIN ResidentialComplex rc ON h.ResidentialComplexId = rc.Id
                    WHERE h.Id = @Id AND h.IsDeleted = 0";

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

        public void Create(HouseModel house)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                string query = @"
                    INSERT INTO House (ResidentialComplexId, Street, HouseNumber, 
                                      HouseCostCoefficient, ConstructionCost, 
                                      IsDeleted, CreatedDate, ModifiedDate)
                    VALUES (@ResidentialComplexId, @Street, @HouseNumber, 
                            @HouseCostCoefficient, @ConstructionCost, 
                            0, GETDATE(), GETDATE())";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ResidentialComplexId", house.ResidentialComplexId);
                    command.Parameters.AddWithValue("@Street", house.Street);
                    command.Parameters.AddWithValue("@HouseNumber", house.HouseNumber);
                    command.Parameters.AddWithValue("@HouseCostCoefficient", house.HouseCostCoefficient);
                    command.Parameters.AddWithValue("@ConstructionCost", house.ConstructionCost);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Update(HouseModel house)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                string query = @"
                    UPDATE House
                    SET ResidentialComplexId = @ResidentialComplexId,
                        Street = @Street,
                        HouseNumber = @HouseNumber,
                        HouseCostCoefficient = @HouseCostCoefficient,
                        ConstructionCost = @ConstructionCost,
                        ModifiedDate = GETDATE()
                    WHERE Id = @Id";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", house.Id);
                    command.Parameters.AddWithValue("@ResidentialComplexId", house.ResidentialComplexId);
                    command.Parameters.AddWithValue("@Street", house.Street);
                    command.Parameters.AddWithValue("@HouseNumber", house.HouseNumber);
                    command.Parameters.AddWithValue("@HouseCostCoefficient", house.HouseCostCoefficient);
                    command.Parameters.AddWithValue("@ConstructionCost", house.ConstructionCost);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void Delete(int id)
        {
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();

                string query = @"
                    UPDATE House
                    SET IsDeleted = 1,
                        ModifiedDate = GETDATE()
                    WHERE Id = @Id";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        private HouseModel MapFromReader(SqlDataReader reader)
        {
            return new HouseModel
            {
                Id = reader.GetInt32(0),
                ResidentialComplexId = reader.GetInt32(1),
                Street = reader.GetString(2),
                HouseNumber = reader.GetString(3),
                HouseCostCoefficient = reader.GetDecimal(4),
                ConstructionCost = reader.GetDecimal(5),
                IsDeleted = reader.GetBoolean(6),
                CreatedDate = reader.GetDateTime(7),
                ModifiedDate = reader.GetDateTime(8),
                ComplexName = reader.GetString(9),
                ComplexStatus = reader.GetString(10),
                SoldApartmentsCount = reader.GetInt32(11),
                SellingApartmentsCount = reader.GetInt32(12)
            };
        }
    }
}
