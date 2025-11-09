using System.Data.SqlClient;

namespace House.DataAccess
{
    /// <summary>
    /// Класс для управления подключением к базе данных
    /// </summary>
    public static class DatabaseConnection
    {
        private static string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;" +
            @"AttachDbFilename=C:\Users\evgen\Desktop\практика рабочая 1\House\House\Database1.mdf;" +
            @"Integrated Security=True;" +
            @"Connect Timeout=30";

        /// <summary>
        /// Получить новое подключение к базе данных
        /// </summary>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        /// <summary>
        /// Проверить подключение к базе данных
        /// </summary>
        public static bool TestConnection()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
