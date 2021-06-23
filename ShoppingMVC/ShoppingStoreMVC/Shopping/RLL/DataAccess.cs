using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DataLibrary;
using Microsoft.IdentityModel.Protocols;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Shopping.RLL
{
    public static class DataAccess
    {
        
        public static string GetConnectionString(string connectionName = "RTM-GDR")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }
        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cnn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=SHOPPING_DB;Trusted_Connection=True;"))
            
            return cnn.Query<T>(sql).ToList();
        }
        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=SHOPPING_DB;Trusted_Connection=True;"))
                return cnn.Execute(sql, data);
            //Console.WriteLine(sql);
            //Console.ReadLine();
        }
        //EF dbContext method
        public static List<User> AllDbContext(string userid, string userpwd)
        {
            SHOPPING_DBContext context = new SHOPPING_DBContext();
            List<User> DBUser = context.Users.Where(s => s.Userid.ToLower() == userid.ToLower() && s.User_Pwd.ToLower() == userpwd.ToLower()).ToList();
            if (DBUser.Count != 0)
                return DBUser;
            else
                return DBUser;
        }

        public static List<StoresName> AllDbContext()
        {
            SHOPPING_DBContext context = new SHOPPING_DBContext();
            var DBStores = context.StoresNames.ToList();
           
            if (DBStores.Count != 0)
                return DBStores;
            else
                return DBStores;
        }

        public static List<StoreBranch> AllDbContext(int storenameid)
        {
            SHOPPING_DBContext context = new SHOPPING_DBContext();
            var DBBranches = context.StoreBranches.Where(s => s.StoreNameId == storenameid).ToList();

            if (DBBranches.Count != 0)
                return DBBranches;
            else
                return DBBranches;
        }

        public static List<ItemsCat> AllDbContextCat()
        {
            SHOPPING_DBContext context = new SHOPPING_DBContext();
            var DBCats = context.ItemsCats.ToList();

            if (DBCats.Count != 0)
                return DBCats;
            else
                return DBCats;
        }

        public static List<ItemsSubCat> AllDbContextCat(int catid)
        {
            SHOPPING_DBContext context = new SHOPPING_DBContext();
            var DBSubCat = context.ItemsSubCats.Where(s => s.CatId == catid).ToList();

            if (DBSubCat.Count != 0)
                return DBSubCat;
            else
                return DBSubCat;
        }


    }

}
