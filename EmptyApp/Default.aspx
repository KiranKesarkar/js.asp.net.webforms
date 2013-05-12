<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EmptyApp.Default" %><!DOCTYPE html>
<html>
<head runat="server">
    <title>Managing Your JavaScript Library in ASP.NET</title>
</head>
<body runat="server">
<form runat="server">
<!-- ############################ FORM ############################ -->
    
    <h1><a href="http://www.codeproject.com/Articles/196727/Managing-Your-JavaScript-Library-in-ASP-NET">Managing Your JavaScript Library in ASP.NET</a></h1>    
    <h2><a href="http://jupaol.blogspot.com/2012/09/enabling-unobtrusive-validation-from.html">Enabling unobtrusive validation from scratch in ASP.Net 4.5 webforms</a></h2>
    

    <asp:TextBox runat="server" ID="tb"></asp:TextBox>
    <asp:RequiredFieldValidator runat="server" ID="rfv" ControlToValidate="tb"></asp:RequiredFieldValidator>
    <asp:Button runat="server" ID="btn" Text="button" />
    


<%--
<% JavaScriptLibrary.JavaScriptHelper.Include_GreetUser(Page.ClientScript, true); %>
<% JavaScriptLibrary.JavaScriptHelper.Include_jQuery(Page, true); %>
--%>

 
<asp:ScriptManager ID="ScriptManager" AjaxFrameworkMode="Disabled" runat="server" LoadScriptsBeforeUI="false" ScriptMode="Release">
    <Scripts>    
        <%--<asp:ScriptReference Name="MicrosoftAjax.js" Assembly="System.Web.Extensions" Path="~/Scripts/WebForms/MSAjax/MicrosoftAjax.js" />--%>
        <%--<asp:ScriptReference Name="MicrosoftAjaxWebForms.js" Path="~/Scripts/WebForms/MSAjax/MicrosoftAjaxWebForms.js" />--%>
        <%--<asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />--%>
        <%--<asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />--%>
        <asp:ScriptReference Name="webForms" />
        <asp:ScriptReference Name="webValidation" />
        <asp:ScriptReference Name="msAjax" />
        <asp:ScriptReference Name="msAjaxWebForms" />
    </Scripts>
</asp:ScriptManager>


<script>window.onload = function () { GreetUser(); };</script>
<!-- ############################ FORM ############################ -->
</form>
</body>
</html>

