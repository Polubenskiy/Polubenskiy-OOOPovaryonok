namespace OOOPovaryonok
{
    using System;
    using System.Windows.Forms;

    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SQLDatabaseHelper.DatabaseContext = new Entities.Trade();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Authorization());
        }
    }
}
