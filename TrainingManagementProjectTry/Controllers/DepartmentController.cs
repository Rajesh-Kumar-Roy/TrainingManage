using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TrainingManagement.Manager.Contract;
using TrainingManagement.Models;
using TrainingManagementProjectTry.Models;

namespace TrainingManagementProjectTry.Controllers
{
    public class DepartmentController : Controller
    {
        private IDepartmentManager _departmentManager;
        private IMapper _mapper;
        public DepartmentController(IDepartmentManager departmentManager,IMapper mapper)
        {
            _departmentManager = departmentManager;
            _mapper = mapper;
        }
       [HttpGet]
        public IActionResult Entry()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Entry(DepartmentViewModel model)
        {
            var deaptment = _mapper.Map<Department>(model);
            bool  IsAdded=   _departmentManager.Add(deaptment);
            return View();
        }
    }
}