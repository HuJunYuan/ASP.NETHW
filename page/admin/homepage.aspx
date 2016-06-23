<%@ Page Title="" Language="C#" MasterPageFile="~/page/admin/MasterPage.master" AutoEventWireup="true" CodeFile="homepage.aspx.cs" Inherits="page_admin_homepage" %>

<asp:Content ID="nav_hompage" ContentPlaceHolderID="nav" runat="server">
<div class="col-lg-2 span3">
	            <ul class="nav nav-pills nav-stacked text-center">
                    <li class="active"><a href="./homepage.aspx">首页</a></li>
 	                <li><a href="./signup.aspx">用户注册</a></li>
 	                <li><a href="./select.aspx">信息查询</a></li>
 	                <li><a href="./delete.aspx">删除信息</a></li>
 	                <li><a href="./add.aspx">增添信息</a></li>
                    <li><a href="../login.aspx">退出</a></li>
                </ul>
	        </div>
</asp:Content>
<asp:Content ID="welcome" ContentPlaceHolderID="content" Runat="Server">
<div style="margin-top:100px;">
    <asp:Label ID="info" Text="welcome" class=" col-lg-offset-3  h3" runat="server"></asp:Label>
   </div>


</asp:Content>

