using MVCCRUD.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVCCRUD.Controllers
{
    public class EmployeeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Read()
        {
            List<EmpModel> empList = new List<EmpModel>();
            empList = EmpDal.Read();
            return View(empList);
        }
    }
}