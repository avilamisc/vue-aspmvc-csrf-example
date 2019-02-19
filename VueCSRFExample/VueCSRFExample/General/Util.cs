using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VueCSRFExample.General
{
    public static class Util
    {
        public static String GetToken()
        {
            string cookieToken, formToken;
            System.Web.Helpers.AntiForgery.GetTokens(null, out cookieToken, out formToken);
            return cookieToken + ":" + formToken;
        }
    }
}