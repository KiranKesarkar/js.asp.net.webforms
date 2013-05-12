<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EmptyApp.Default" %><!DOCTYPE html>
<html>
<head runat="server">
    <title>Managing Your JavaScript Library in ASP.NET</title>
</head>
<body>
<form runat="server">
    <h1><a href="http://www.codeproject.com/Articles/196727/Managing-Your-JavaScript-Library-in-ASP-NET">Managing Your JavaScript Library in ASP.NET</a></h1>    
    <h2><a href="http://jupaol.blogspot.com/2012/09/enabling-unobtrusive-validation-from.html">Enabling unobtrusive validation from scratch in ASP.Net 4.5 webforms</a></h2>
    <asp:TextBox ID="tb" runat="server" BorderColor="#0099ff" CausesValidation="false"></asp:TextBox>
    <asp:RequiredFieldValidator ControlToValidate="tb" Display="Dynamic" runat="server" Text="required !!!!"></asp:RequiredFieldValidator>

    <asp:Button ID="aspBtn" runat="server" CausesValidation="false" />

<%--
<% JavaScriptLibrary.JavaScriptHelper.Include_GreetUser(Page.ClientScript, true); %>
<% JavaScriptLibrary.JavaScriptHelper.Include_jQuery(Page, true); %>
--%>

<%--
<asp:ScriptManager ID="ScriptManager" runat="server" LoadScriptsBeforeUI="false" AjaxFrameworkMode="Disabled">
<Scripts>
                
</Scripts>
</asp:ScriptManager>
--%>

<script>window.onload = function () { GreetUser(); };</script>
</form>
</body>
</html>
