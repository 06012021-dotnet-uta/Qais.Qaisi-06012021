using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;





namespace Shopping.BLL
{
    public class UserProccessor
    {
        public static int CreateUser(string userId, string userPwd, string street, string city, string state, string zipCode, string email)
        {
            
           Models.User NewUser = new Models.User
            {
                Userid = userId,
                User_Pwd = userPwd,
                Ustreet = street,
                Ucity = city,
                Ustate = state,
                Uzip = zipCode,
                Email = email

            };
            string sql = @"insert into users (UserId,User_Pwd,Ustreet,Ucity,Ustate,Uzip,Email) 
                        values(@Userid,@User_Pwd,@UStreet,@Ucity,@Ustate,@Uzip,@Email)";

            return RLL.DataAccess.SaveData(sql, NewUser);
        }
        public static Models.User LoadUser( string userid, string userpwd)
        {

            var LoggedUser = RLL.DataAccess.AllDbContext(userid, userpwd);
            if (LoggedUser.Count!=0)
            { 
            Models.User NewUser = new Models.User
            {
                UserPk = LoggedUser[0].UserPk,    
                Userid = LoggedUser[0].Userid,
                User_Pwd = LoggedUser[0].User_Pwd,
                Ustreet = LoggedUser[0].Ustreet,
                Ucity = LoggedUser[0].Ucity,
                Ustate = LoggedUser[0].Ustate,
                Uzip = LoggedUser[0].Uzip,
                Email = LoggedUser[0].Email

            };
                return NewUser;
            }
            return null;
            
            
        }
        public static List<DataLibrary.StoresName> LoadStores()
        {

            List<DataLibrary.StoresName> StoresList = RLL.DataAccess.AllDbContext();
           
            return StoresList;
        }
        public static List<DataLibrary.StoreBranch> LoadBranches(int storenameid)
        {

            List<DataLibrary.StoreBranch> BranchesList = RLL.DataAccess.AllDbContext(storenameid);

            return BranchesList;
        }

        public static List<DataLibrary.ItemsCat> LoadCats()
        {

            List<DataLibrary.ItemsCat> CatList = RLL.DataAccess.AllDbContextCat();

            return CatList;
        }

        public static List<DataLibrary.ItemsSubCat> LoadSubCat(int catid)
        {

            List<DataLibrary.ItemsSubCat> SubCatList = RLL.DataAccess.AllDbContextCat(catid);

            return SubCatList;
        }

    }
}

