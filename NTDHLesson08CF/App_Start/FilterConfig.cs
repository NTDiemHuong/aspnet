﻿using System.Web;
using System.Web.Mvc;

namespace NTDHLesson08CF
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
