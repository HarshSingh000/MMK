using Kentico.Content.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using MMK.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace MMK.Components
{
    public class TeamViewComponent : ViewComponent
    {
        private readonly TeamRepository teamRepository;
        private readonly IPageUrlRetriever pageUrlRetriever;


        public TeamViewComponent(TeamRepository teamRepository, IPageUrlRetriever pageUrlRetriever)
        {
            this.teamRepository = teamRepository;
            this.pageUrlRetriever = pageUrlRetriever;
        }


        public IViewComponentResult Invoke(bool footerNavigation)
        {
            try
            {
                List<TeamModel> team = teamRepository.GetMemberList();
                return View("~/Views/Team/Index.cshtml", team);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
