<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="page_login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>后台登陆</title>
    <link rel="stylesheet" href="../css/bootstrap.min.css">
</head>
<body>
    <form id="form1" runat="server">
       <div class="container">


  <div class="container-fluid">
    <asp:Image runat="server" ID = "head" ImageUrl="~/logo.png" Width="100%" />
    
  </div>
   <!-- zhe li shi daohang lan-->
<p class="text-center h1" style="margin-top:80px;">登录</p>
<div class="form-group col-lg-5">
    <asp:TextBox ID="name" runat="server" class="form-control input-lg col-lg-offset-9" style="margin-top:15px;" placeholder="请输入账号"></asp:TextBox>
    <asp:TextBox ID="password" runat="server" class="form-control input-lg col-lg-offset-9" style="margin-top:15px;" placeholder="请输入账号"></asp:TextBox>
    <asp:DropDownList runat="server" ID="who" class="form-control input-lg col-lg-offset-9" style="width:100px; margin-top:15px;">
        <asp:ListItem Value="学生">学生</asp:ListItem>
        <asp:ListItem Value="家长">家长</asp:ListItem>
        <asp:ListItem Value="管理员">管理员</asp:ListItem>
    </asp:DropDownList>
  </div>
  <div>
    <asp:Button runat="server" ID="submit" class="btn btn-default btn-lg" 
          style="margin-top:135px;" Text="确认" onclick="submit_Click"/>
    <asp:Button runat="server" ID="reset" class="btn btn-default btn-lg" 
          style="margin-top:135px;" Text="重置" onclick="reset_Click"/>
  </div>
  </div>
    </form>
</body>
</html>
