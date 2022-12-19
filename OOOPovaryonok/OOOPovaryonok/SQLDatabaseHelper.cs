using OOOPovaryonok.Entities;
using System;
using System.Windows.Forms;

namespace OOOPovaryonok
{
    public static class SQLDatabaseHelper
    {
        public static Trade DatabaseContext { get; set; }

        public static void SaveDatabaseContext()
        {
            try
            {
                DatabaseContext.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show("Внимание!", "Произошла ошибка " +
                    $"при попытке сохранить измерения: {e.Message}");
            }
        }
    }
}
