using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NTierApp.BLL.Interfaces;
using NTierApp.PL.Models;

namespace NTierApp.PL.Controllers
{
    public class EmployeeController : Controller
    {/*
        EmployeeService db = new EmployeeService();
        static EmployeeController()
        {

        }
        // GET: Employee
        */
        //private readonly Class1 class1; //
        private readonly IEmployeeService _employeeService;
        
        public EmployeeController(IEmployeeService employeeService)//, Class1 class1)
        {
            //var container = AutofacConfig.ConfigureContainer("DefaultConnection");
            //_employeeService = container.Resolve(typeof(IEmployeeService)) as IEmployeeService;
            //var x = class1.Get5();
            _employeeService = employeeService;            
        }

        public ActionResult Index(int companyId)
        {
            var employees = _employeeService.GetAllEmloyees();

            return View();
        }
    }
}