using System;
using System.Collections.Generic;
using System.Linq;

using CMS.DocumentEngine.Types.MMK;
using MMK.Models;
using Kentico.Content.Web.Mvc;
using System.Reflection.Metadata;

namespace MMK.Models
{ 
    public class TeamModel
    {
        public string Name { get; set; }
        public string Details { get; set; }
        public string Photo { get; set; }

        public static TeamModel Map(Team teams)
        {
            TeamModel team = new TeamModel();
            team.Name = teams.Name;
            team.Details = teams.Details;
            team.Photo = teams.Photo;
            return team;
        }
    }
}
