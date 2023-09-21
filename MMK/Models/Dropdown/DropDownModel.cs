using System;
using System.Collections.Generic;
using System.Linq;

using CMS.DocumentEngine.Types.MMK;
using MMK.Models;
using Kentico.Content.Web.Mvc;
using System.Reflection.Metadata;
namespace MMK.Models
{
    public class DropDownModel
    {
        public string Name { get; set; }

        public static DropDownModel Map(Dropdown _dropdown)
        {
            DropDownModel dropdown = new DropDownModel();
            dropdown.Name = _dropdown.EmployeeName;
           
            return dropdown;
        }
    }
}