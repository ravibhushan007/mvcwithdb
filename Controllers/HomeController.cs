using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demolinq.Models;

namespace Demolinq.Controllers
{
    
    public class HomeController : Controller
    {
        ArrayList ay = new ArrayList();
        
        AngularEntities Entitis = new AngularEntities();
        private object emp_name;

        public ActionResult Index()
        {
            //List<Employee> stlist = new List<Employee>()
            //{
            //    new Employee{ emp_name="naresh",emp_age=56},
            //    new Employee{ emp_age=56,emp_job="romance"}
            //};

            ////Employee obj = new Employee() { emp_name = "sona", emp_age = 62, emp_job = "actess" };
            //Employee obj1 = new Employee();
            //obj1.emp_name = "papa";
            //obj1.emp_age=12;
            //obj1.emp_job = "money";



            //stlist.Add(obj1);
            //stlist.Add(new Employee() { emp_name = "sona", emp_age = 62, emp_job = "actess" });
            ///* IEnumerable<Employee>*/ Employee stlist=Entitis.Employees.Where(m=>m.emp_name=="ravi").FirstOrDefault(); //data will retrieve but we can't see due to model data
            // IEnumerable<Employee> stlis = Entitis.Employees.Where(m => m.emp_name == "ravi").ToList(); ///we can see retrieved data in list count
            // var stlists = Entitis.Employees.Where(m => m.emp_name == "ravi"); //we can't see retrieved data due to model data

            //   var stlistsl = (from x in Entitis.Employees
            //                  where x.emp_name=="ravi"
            //                  select x).SingleOrDefault(); ///we can see retrieved data in list count
            //Employee stlist = Entitis.Employees.Select(m => m.emp_name == "ravi");
            /* IEnumerable<Employee>*/
            var Selfselect = (from x in Entitis.Employees
                              //where x.emp_name == "ravi"
                              //orderby  x.emp_name descending
                              select new 
                              {
                                   x.emp_name,
                                 x.emp_age ,
                                 x.emp_job
                                

                            }).ToList();
            string gj = "ravi";

            //var gh = Entitis.Employees.OrderByDescending(x => x.emp_name);
            //var gh = Entitis.Employees.OrderBy(x=>x.emp_name).Skip(2).ToArray();
           // var gh = Entitis.Employees.OrderBy(x => x.emp_name).TakeWhile(m=>m.emp_name==gj).ToArray();
            var loda = Entitis.Employees.OrderBy(x => x.emp_name).Skip(2).ToArray().Reverse();


            var baba= Json(Selfselect, JsonRequestBehavior.AllowGet);
            //return stlistsl;
            return View(baba);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var VMclass = (from x in Entitis.Employees
                           //where x.emp_name == "ravi"
                           select new ravivm
                           {
                               name = x.emp_name,
                               age = x.emp_age,
                               adderes = x.emp_job


                           })/*.FirstOrDefault()*/;
             var hj=Json(VMclass, JsonRequestBehavior.AllowGet);
            return hj;
        }

        public ActionResult Contact()
        {
            var stlistsl = (from x in Entitis.Employees
                            //where x.emp_name == "ravi"
                            select new
                            {
                                Anynomous1 = x.emp_name,
                                anynomous2 = x.emp_age,
                                anynomous3 = x.emp_job


                            })/*.FirstOrDefault()*/;
            var fg= Json(stlistsl, JsonRequestBehavior.AllowGet);
            return fg;
        }
        public static void Ravi()
        {
            string[] gh = { "gfhg", "gfhg" };
            string[] jh = new string[5];
            ArrayList lo = new ArrayList();
            
                 ArrayList al = new ArrayList();

            

        }
    }
}