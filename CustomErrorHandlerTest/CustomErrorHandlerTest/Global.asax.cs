using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomErrorHandlerTest
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            new AppHost().Init();
        }
    }
}
