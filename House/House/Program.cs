using System;
using System.Windows.Forms;
using House.Forms;

namespace House
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                if (!DataAccess.DatabaseConnection.TestConnection())
                {
                    throw new Exception("Не удалось подключиться к базе данных");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ошибка подключения к базе данных:\n{ex.Message}\n\n" +
                    "Убедитесь, что SQL Server запущен и база данных создана.",
                    "Ошибка подключения",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Application.Run(new MainForm());
        }
    }
}
