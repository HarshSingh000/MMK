using System;
using System.Collections.Generic;
using System.Linq;

using CMS.DocumentEngine.Types.MMK;
using MMK.Models;
using Kentico.Content.Web.Mvc;
using System.Reflection.Metadata;

namespace MMK.Models
{
    public class FaqModel
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        public static FaqModel Map(Faq faqs)
        {
            FaqModel faq = new FaqModel();
            faq.Question = faqs.Question;
            faq.Answer = faqs.Answer;
            return faq;
        }
    }
}
