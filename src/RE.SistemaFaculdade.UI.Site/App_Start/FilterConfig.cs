﻿using System.Web;
using System.Web.Mvc;

namespace RE.SistemaFaculdade.UI.Site
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
