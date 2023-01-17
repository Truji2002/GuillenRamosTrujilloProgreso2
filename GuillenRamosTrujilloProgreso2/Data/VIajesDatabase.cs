using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuillenRamosTrujilloProgreso2.Models;

namespace GuillenRamosTrujilloProgreso2.Data
{
    public class VIajesDatabase
    {
        static SQLiteAsyncConnection Database;

        public static readonly AsyncLazy<VIajesDatabase> Instance =
            new AsyncLazy<VIajesDatabase>(async () =>
            {
                var instance = new VIajesDatabase();
                try
                {
                    CreateTableResult result = await Database.CreateTableAsync<ViajesCRUD>();
                }
                catch (Exception ex)
                {

                    throw;
                }
                return instance;
            });


        public VIajesDatabase()
        {
            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        }

        public Task<List<ViajesCRUD>> GetItemsAsync()
        {
            return Database.Table<ViajesCRUD>().ToListAsync();
        }

        public Task<List<ViajesCRUD>> GetItemsNotDoneAsync()
        {
            return Database.QueryAsync<ViajesCRUD>("SELECT * FROM [ViajesCRUD] WHERE [Servicio] = 0");
        }

        public Task<ViajesCRUD> GetItemAsync(int id)
        {
            return Database.Table<ViajesCRUD>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(ViajesCRUD item)
        {
            if (item.Id != 0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(ViajesCRUD item)
        {
            return Database.DeleteAsync(item);
        }
    }
}
