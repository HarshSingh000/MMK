
using Kentico.Content.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using MMK.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace MMK.Components
{
    public class MenuViewComponent : ViewComponent
    {
        //private readonly IMenuRepository _navigationRepository; 
        

        private readonly MenuRepository navigationRepository;
        private readonly IPageUrlRetriever pageUrlRetriever;


        public MenuViewComponent(MenuRepository navigationRepository, IPageUrlRetriever pageUrlRetriever)
        {
            this.navigationRepository = navigationRepository;
            this.pageUrlRetriever = pageUrlRetriever;
        }


        public IViewComponentResult Invoke(bool footerNavigation)
        {
            try
            {
                List<NameMenu> menu = navigationRepository.GetMenuList();
                return View("~/Views/Menu/Index.cshtml", menu);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

