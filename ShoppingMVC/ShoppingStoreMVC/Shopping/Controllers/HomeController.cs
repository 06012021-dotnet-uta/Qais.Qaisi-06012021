using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Shopping.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Shopping.BLL;

namespace Shopping.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public ActionResult SignUp()
        {
            ViewBag.message = "Sign up for new Account";
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User model)
        {
            int found = 0;
            if (model.Userid != "" && model.User_Pwd != "" && model.Userid != null && model.User_Pwd != null)
            {
                User Luserid = new User();
                var UserlogedIn = UserProccessor.LoadUser(model.Userid, model.User_Pwd);
                if (UserlogedIn != null)
                    found = 1;

            }
            if (found==1)
            return RedirectToAction("StoresList");
            else
            return RedirectToAction("index");
            //return View("StoresList");

        }


        public ActionResult StoresList()
        {
            ViewBag.Message = "Stores List";
            var StoresData = UserProccessor.LoadStores();
            List<Models.StoresName> StoresDataList = new List<Models.StoresName>();
            
            for (int i=0; i<=StoresData.Count()-1; i++)
            {
                StoresDataList.Add(new Models.StoresName
                {
                    StoreNameId = StoresData[i].StoreNameId,
                    StoreName = StoresData[i].StoreName
                });
            }
            
            return View("StoresDataList",StoresDataList);
        }

        public ActionResult StoreBranchesList(int id,string storename)
        {
            ViewBag.storename = storename;
            

            var BranchesData = UserProccessor.LoadBranches(id);
            List<Models.StoreBranch> BranchesDataList = new List<Models.StoreBranch>();

            for (int i = 0; i <= BranchesData.Count() - 1; i++)
            {
                BranchesDataList.Add(new Models.StoreBranch
                {
                    StoreBranchId=BranchesData[i].StoreBranchId,
                    StoreNameId=BranchesData[i].StoreNameId,
                    StoreStreet=BranchesData[i].StoreStreet,
                    StoreCity=BranchesData[i].StoreCity,
                    StoreState=BranchesData[i].StoreState,
                    StoreZipcode=BranchesData[i].StoreZipcode,
                    StorePhone=BranchesData[i].StorePhone
                    
                });
            }

            return View("StoreBranchesList", BranchesDataList);
        }



        public ActionResult CatList(int id , string city)
        {
            ViewBag.city = city;
            //ViewBag.state = state;
            

            var CatData = UserProccessor.LoadCats();
            List<Models.ItemsCat> CatDataList = new List<Models.ItemsCat>();

            for (int i = 0; i <= CatData.Count() - 1; i++)
            {
                CatDataList.Add(new Models.ItemsCat
                {
                    CatId = CatData[i].CatId,
                    CatName = CatData[i].CatName
                });
            }

            return View("CatList", CatDataList);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(User model)
        {
            if (ModelState.IsValid)
            {
                int RecordCreated = UserProccessor.CreateUser(model.Userid,model.User_Pwd,model.Ustreet,model.Ucity,model.Ustate,model.Uzip,model.Email);
                return RedirectToAction("index");
            }
            
            return View();
        }


        public ActionResult SubCatList(int id, string catname)
        {
            ViewBag.CatName = catname;
            var SubCatData = UserProccessor.LoadSubCat(id);
            List<Models.ItemsSubCat> SubCatDataList = new List<Models.ItemsSubCat>();

            for (int i = 0; i <= SubCatData.Count() - 1; i++)
            {
                SubCatDataList.Add(new Models.ItemsSubCat
                {
                    CatId = SubCatData[i].CatId,
                    SubCatId = SubCatData[i].SubCatId,
                    SubCatName=SubCatData[i].SubCatName
                });
            }

            return View("SubCatList", SubCatDataList);
        }

    }
}
