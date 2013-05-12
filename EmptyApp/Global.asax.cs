using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Web.SessionState;

//using WebFormsLab.Model;
//using System.Web.ModelBinding;


namespace EmptyApp
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            //ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            System.Reflection.Assembly ext = typeof(ScriptManager).Assembly;
            System.Reflection.Assembly web = typeof(HttpApplication).Assembly;

            ScriptResourceDefinition msAjax = new ScriptResourceDefinition();
            msAjax.ResourceName = "MicrosoftAjax.js";
            msAjax.ResourceAssembly = ext;
            msAjax.Path = "~/Scripts/WebForms/MSAjax/MicrosoftAjax.js";
            msAjax.CdnPath = "http://ajax.microsoft.com/ajax/4.0/1/MicrosoftAjax.js";
            msAjax.CdnDebugPath = "http://ajax.microsoft.com/ajax/4.0/1/MicrosoftAjax.debug.js";
            msAjax.CdnSupportsSecureConnection = true;
            ScriptManager.ScriptResourceMapping.AddDefinition("msAjax", msAjax);

            ScriptResourceDefinition msAjaxWebForms = new ScriptResourceDefinition();
            msAjaxWebForms.ResourceName = "MicrosoftAjaxWebForms.js";
            msAjaxWebForms.ResourceAssembly = ext;
            msAjaxWebForms.Path = "~/Scripts/WebForms/MSAjax/MicrosoftAjaxWebForms.js";
            msAjaxWebForms.CdnPath = "http://ajax.aspnetcdn.com/ajax/4.5/6/MicrosoftAjaxWebForms.js";
            msAjaxWebForms.CdnPath = "http://ajax.aspnetcdn.com/ajax/4.5/6/MicrosoftAjaxWebForms.debug.js";
            msAjaxWebForms.CdnSupportsSecureConnection = true;
            ScriptManager.ScriptResourceMapping.AddDefinition("msAjaxWebForms", msAjaxWebForms);

            ScriptResourceDefinition webForms = new ScriptResourceDefinition();
            webForms.ResourceName = "WebForms.js";
            webForms.ResourceAssembly = web;
            webForms.Path = "~/Scripts/WebForms/WebForms.js";
            webForms.CdnPath = "http://ajax.aspnetcdn.com/ajax/4.5/6/WebForms.js";
            webForms.CdnSupportsSecureConnection = true;
            ScriptManager.ScriptResourceMapping.AddDefinition("webForms", webForms);

            ScriptResourceDefinition webValidation = new ScriptResourceDefinition();
            webValidation.ResourceName = "WebUIValidation.js";
            webValidation.ResourceAssembly = web;
            webValidation.Path = "~/Scripts/WebForms/WebUIValidation.js";
            webValidation.CdnPath = "http://ajax.aspnetcdn.com/ajax/4.5/6/WebUIValidation.js";
            webForms.CdnSupportsSecureConnection = true;
            ScriptManager.ScriptResourceMapping.AddDefinition("webValidation", webValidation);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}