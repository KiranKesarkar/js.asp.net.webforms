<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="InlineGreeting.ascx.cs" Inherits="EmptyApp.UserControls.InlineGreeting" %>
<script type="text/javascript" 
	src="http://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.5.1.js">
</script>
<script type="text/javascript">
    $(document).ready(function () {
        $("#lblGreeting").text("Hello");
    });
</script>
<p>
    <label id="lblGreeting"></label>
</p>
