using Kentico.Content.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using MMK.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace MMK.Components
{
    public class FaqViewComponent : ViewComponent
    {
        private readonly FaqRepository faqRepository;
        private readonly IPageUrlRetriever pageUrlRetriever;


        public FaqViewComponent(FaqRepository faqRepository, IPageUrlRetriever pageUrlRetriever)
        {
            this.faqRepository = faqRepository;
            this.pageUrlRetriever = pageUrlRetriever;
        }


        public IViewComponentResult Invoke(bool footerNavigation)
        {
            try
            {
                List<FaqModel> faq = faqRepository.GetFaqList();
                return View("~/Views/Faq/Index.cshtml", faq);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
