using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using TrainingManagement.Manager.Contract;

namespace TrainingManagementProjectTry.Utility
{
    public class StudentDropDownUtitily:IUtilityManager
    {
        private IDepartmentManager _departmentManager;
        public StudentDropDownUtitily(IDepartmentManager departmentManager)
        {
            _departmentManager = departmentManager;
        }

        public ICollection<SelectListItem> GetAllDepartmentLoopUpData()
        {
            return _departmentManager.GetAll().Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();
        }
    }
}
