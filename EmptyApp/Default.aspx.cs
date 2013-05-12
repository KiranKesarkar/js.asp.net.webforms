using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmptyApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            //JavaScriptLibrary.JavaScriptHelper.Include_jQuery(Page);
            //JavaScriptLibrary.JavaScriptHelper.Include_GreetUser(Page.ClientScript);
            //JavaScriptLibrary.JavaScriptHelper.Include_jQueryLocal(Page.ClientScript);
        }

    }
}