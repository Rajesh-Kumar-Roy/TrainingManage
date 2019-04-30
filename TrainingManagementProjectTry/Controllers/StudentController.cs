using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TrainingManagement.Manager.Contract;
using TrainingManagement.Models;
using TrainingManagementProjectTry.Models.StudentViewModel;
using TrainingManagementProjectTry.Utility;

namespace TrainingManagementProjectTry.Controllers
{
    public class StudentController : Controller
    {
        private IMapper _mapper;
        private IStudentManager _studentManager;
        private IDepartmentManager _departmentManager;
        private IUtilityManager _utilityManager;

        public StudentController(IStudentManager studentManager,IMapper mapper,IDepartmentManager departmentManager,IUtilityManager utilityManager)
        {
            _studentManager = studentManager;
            _mapper = mapper;
            _departmentManager = departmentManager;
            _utilityManager = utilityManager;
        }

        [HttpGet]
        public IActionResult Entry()
        {
            var model=new StudentCreateViewModel();
            model.studentcollection = _studentManager.GetAll();
            model.DepartLoopupdata = _utilityManager.GetAllDepartmentLoopUpData();
            return View(model);
        }
        [HttpPost]
        public IActionResult Entry(StudentCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                var student = _mapper.Map<Student>(model);
                bool IsSuccess = _studentManager.Add(student);
                if (IsSuccess)
                {
                    //successful!
                }
            }

            model.studentcollection = _studentManager.GetAll();
            model.DepartLoopupdata = _utilityManager.GetAllDepartmentLoopUpData();
            return View(model);
        }

        public JsonResult GetByDepartmentJsonResult(int departmentId)
        {
            var studentList = _studentManager.GetByDepartment(departmentId);
            return Json(studentList);
        }

        public JsonResult GetAllDepartmentJsonResult()
        {
            var department = _departmentManager.GetAll();
            return Json(department);
        }

        public PartialViewResult GetByDepartmentPartial(int departmentId)
        {
            ICollection<Student> studentLis = null;
            if (departmentId > 0)
            {
                   studentLis = _studentManager.GetByDepartment(departmentId);
               
            }
            else
            {
               studentLis= _studentManager.GetAll();
            }
            return PartialView("_StudentList",studentLis);
        }
    }
}