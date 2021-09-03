using System;
using System.Web.Mvc;
using Login_MVC_.Models;
using System.Data;
using System.Data.SqlClient;
namespace Login_MVC_.Controllers {
    public class AccountController : Controller {
        SqlConnection cx = new SqlConnection(@"server=.\SQLEXPRESS; DATABASE=Library; Integrated Security=True;");
        SqlCommand com;
        SqlDataReader dr;
        // GET: Account
        [HttpGet]
        public ActionResult Index() {
            return View("Login");
        }
        [HttpPost]
        public ActionResult Verify(Account acc) {
            cx.Open();
            string req = $"Select username, password From Users where username = '{acc.Username_}' and password = '{acc.Password_}'";
            com = new SqlCommand(req, cx);
            dr = com.ExecuteReader();
            /*
            if (cx.State == ConnectionState.Open) return View("Create");
            else return View("Error");
            */
            if (dr.Read()) {
                cx.Close();
                return View("Create");
            } else {
                cx.Close();
                return View("Error");
            }
        }
        // public ActionResult Error() { return View(); }
        // public ActionResult Create() { return View(); }
    }
}