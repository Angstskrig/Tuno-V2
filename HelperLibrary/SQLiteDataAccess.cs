using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLibrary
{
    public class SQLiteDataAccess
    {
        public static List<MemberModel> GetMember()
        {
            using (IDbConnection cnn = new SQLiteConnection(GetConnectionString()))
            {
                var output = cnn.Query<MemberModel>("SELECT * FROM medlem", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<TypeModel> GetType()
        {
            using (IDbConnection cnn = new SQLiteConnection(GetConnectionString()))
            {
                var output = cnn.Query<TypeModel>("SELECT type FROM varetyper ORDER BY type ASC");
                return output.ToList();
            }
        }

        public static List<BarModel> GetBar()
        {
            using (IDbConnection cnn = new SQLiteConnection(GetConnectionString()))
            {
                var output = cnn.Query<BarModel>("SELECT barnavn FROM barer ORDER BY barnavn ASC");
                return output.ToList();
            }
        }
        public static List<ItemModel> GetItem()
        {
            using (IDbConnection cnn = new SQLiteConnection(GetConnectionString()))
            {
                var output = cnn.Query<ItemModel>("SELECT * FROM varer ORDER BY type, navn ASC", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<ItemModel> GetDrinks()
        {
            using (IDbConnection cnn = new SQLiteConnection(GetConnectionString()))
            {
                var output = cnn.Query<ItemModel>("SELECT * FROM varer WHERE type = 'Øl' OR type = 'Vin' OR type = 'Spiritus' OR type = 'Shots' OR type = 'Sodavand' ORDER BY type, navn ASC", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<ItemModel> GetNonDrinks()
        {
            using (IDbConnection cnn = new SQLiteConnection(GetConnectionString()))
            {
                var output = cnn.Query<ItemModel>("SELECT * FROM varer WHERE type = 'Diverse' OR type = 'Cigaretter' OR type = 'Snacks' ORDER BY type, navn ASC", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<ItemModel> GetItemName()
        {
            using (IDbConnection cnn = new SQLiteConnection(GetConnectionString()))
            {
                var output = cnn.Query<ItemModel>("SELECT navn, antal FROM varer ORDER BY navn ASC", new DynamicParameters());
                return output.ToList();
            }
        }
        public static List<ItemModel> GetItemByCategory(string category)
        {
            using (IDbConnection cnn = new SQLiteConnection(GetConnectionString()))
            {
                var output = cnn.Query<ItemModel>("SELECT * FROM varer WHERE type = '" + category + "'", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveMember(MemberModel member)
        {
            using (IDbConnection cnn = new SQLiteConnection(GetConnectionString()))
            {
                cnn.Execute("INSERT into medlem (forNavn, efterNavn, alias, mobil, email) VALUES (@fornavn, @efternavn, @alias, @mobil, @email)", member);
            }
        }
        public static void SaveItem(ItemModel item)
        {
            using (IDbConnection cnn = new SQLiteConnection(GetConnectionString()))
            {
                cnn.Execute("INSERT into varer (navn, type, antal, startAntal) VALUES (@navn, @type, @antal, @startantal)", item);
            }
        }
        public static void UpdateItem(string navn, int nytAntal)
        {
            using (IDbConnection cnn = new SQLiteConnection(GetConnectionString()))
            {
                cnn.Execute("UPDATE varer SET antal = antal +'" + nytAntal + "' WHERE navn = '" + navn + "'");
                cnn.Execute("UPDATE varer SET totalantal = totalantal +'" + nytAntal + "' WHERE navn = '" + navn + "'");
            }
        }
        private static string GetConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
