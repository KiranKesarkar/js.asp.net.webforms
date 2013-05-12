using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmptyApp.UserControls
{
    public partial class Hello : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            JavaScriptLibrary.JavaScriptHelper.Include_GreetUser(Page.ClientScript);
            JavaScriptLibrary.JavaScriptHelper.Include_jQuery(Page);
        }

    }
}