using System;
using System.Web;
using System.Web.UI;

[assembly: WebResource("JavaScriptLibrary.JavaScript.ShowMessage.js", "application/x-javascript")]
[assembly: WebResource("JavaScriptLibrary.JavaScript.GreetUser.js", "application/x-javascript")]
[assembly: WebResource("JavaScriptLibrary.JavaScript.jquery-2.0.0.js", "application/x-javascript")]


//<asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />


namespace JavaScriptLibrary
{
    public class JavaScriptHelper
    {
    #region Constatns

        private const string TEMPLATE_SCRIPT = "<script src=\"{0}\"></script>\r\n";
        
        private const string NAME_SHOW_MESSAGE = "JavaScriptLibrary.JavaScript.ShowMessage.js";
        private const string NAME_GREET_USER = "JavaScriptLibrary.JavaScript.GreetUser.js";

        private const string NAME_JQUERY = "jQuery";
        private const string URL_JQUERY = "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.0.0.js";
        private const string URL_JQUERY_HTTPS = "https://ajax.aspnetcdn.com/ajax/jQuery/jquery-2.0.0.js";

        private const string NAME_JQUERY_LOCAL = "JavaScriptLibrary.JavaScript.jquery-2.0.0.js";


        private const string NAME_DUMMY_FILE = "JavaScriptLibrary.JavaScript.DummyFile.js";

    #endregion

    #region Public Methods

        public static void Include_ShowMessage(ClientScriptManager manager, bool late = true)
        {
            IncludeJavaScript(manager, NAME_SHOW_MESSAGE, late);
        }

        public static void Include_GreetUser(ClientScriptManager manager, bool late = true)
        {
            Include_ShowMessage(manager, late);
            IncludeJavaScript(manager, NAME_GREET_USER, late);
        }

        public static void Include_jQueryLocal(ClientScriptManager manager, bool late = true)
        {
            IncludeJavaScript(manager, NAME_JQUERY_LOCAL, late);
        }

        public static void Include_jQuery(Page page, bool late = true)
        {
            if (page == null)
            {
                page = (Page)HttpContext.Current.Handler;
            }
            IncludeExternalJavascript(page, NAME_JQUERY, URL_JQUERY, URL_JQUERY_HTTPS, late);
        }

        public static void Exclude_jQuery(ClientScriptManager manager)
        {
            ExcludeJavaScript(manager, NAME_JQUERY);
        }

    #endregion

    #region Private Methods

        private static void ExcludeJavaScript(ClientScriptManager manager, string key)
        {
            var type = typeof(JavaScriptLibrary.JavaScriptHelper);
            var url = manager.GetWebResourceUrl(type, NAME_DUMMY_FILE);
            manager.RegisterStartupScript(type, key, string.Empty);
            manager.RegisterClientScriptInclude(type, key, url);
        }

        private static void IncludeJavaScript(ClientScriptManager manager, string resourceName, bool late)
        {
            var type = typeof(JavaScriptLibrary.JavaScriptHelper);
            
            if (!manager.IsStartupScriptRegistered(type, resourceName)) 
            {
                if (late)
                {
                    var url = manager.GetWebResourceUrl(type, resourceName);
                    var scriptBlock = string.Format(TEMPLATE_SCRIPT, HttpUtility.HtmlEncode(url));
                    manager.RegisterStartupScript(type, resourceName, scriptBlock);
                }
                else
                {
                    manager.RegisterClientScriptResource(type, resourceName);
                    manager.RegisterStartupScript(type, resourceName, string.Empty);
                }
            }
            
            //manager.RegisterClientScriptResource(type, resourceName);
        }

        private static void IncludeExternalJavascript(Page page, string key, string httpUrl, string httpsUrl, bool late)
        {
            var manager = page.ClientScript;
            var type = typeof(JavaScriptLibrary.JavaScriptHelper);
            bool isStartupRegistered = manager.IsStartupScriptRegistered(type, key);
            bool isScriptRegistered = manager.IsClientScriptIncludeRegistered(type, key);

            if (!(isStartupRegistered || isScriptRegistered))
            {
                string url;

                if (page.Request.Url.Scheme.ToLower() == "http")
                {
                    url = httpUrl;
                }
                else
                {
                    url = httpsUrl;
                }

                if (late)
                {
                    manager.RegisterStartupScript(type, key, string.Format(TEMPLATE_SCRIPT, HttpUtility.HtmlEncode(url)));
                }
                else
                {
                    manager.RegisterClientScriptInclude(type, key, url);
                }
            }
        }

    #endregion
    }
}
