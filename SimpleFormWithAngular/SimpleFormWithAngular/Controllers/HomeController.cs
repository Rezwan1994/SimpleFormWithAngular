using SFA.Entity;
using SFA.Facade;
using SFA.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleFormWithAngular.Controllers
{
    public class HomeController : Controller
    {
        UserFacade userFacade = null;
        public HomeController()
        {
            DataContext Context = DataContext.getInstance();
            userFacade = new UserFacade(Context);
         
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult UserList()
        {
            

            return View();
        }

        public JsonResult GetUserList()
        {
            List<User> userList = new List<User>();
            userList = userFacade.GetAll();

            return Json(userList, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetUser(int id)
        {
            List<User> user = new List<User>();
            user = userFacade.GetAll().Where(x => x.Id == id).ToList();

            return Json(user, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public ActionResult AddUsers(int? id)
        { 
            return View();
        }
        public ActionResult UpdateUser(int id)
        {
            return View();
        }
        [HttpPost]
        public JsonResult AddUsers(User user)
        {
            string res = "";
            try
            {
                if(user.Id > 0)
                {
                    User upUser = new SFA.Entity.User();
                    upUser = userFacade.Get(user.Id);
                    upUser.Name = user.Name;
                    upUser.Email = user.Email;
                    upUser.PhoneNo = user.PhoneNo;
                    upUser.Company = user.Company;
                    upUser.Designation = user.Designation;

                    userFacade.Update(upUser);
                    res = "Updated Successfully";
                }
                else
                {
                    userFacade.Insert(user);
                    res = "Inserted Successfully";
                }
               
            }catch(Exception ex)
            {
                res = "Failed";
            }
            return Json(res, JsonRequestBehavior.AllowGet);
        }

        public JsonResult DeleteUser(int id)
        {
            string res = "";
            try
            {
                userFacade.Delete(id);
                res = "Deleted Successfully";
            }
            catch (Exception ex)
            {
                res = "Failed";
            }
            return Json(res, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}