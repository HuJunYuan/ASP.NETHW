<%@ Page Title="" Language="C#" MasterPageFile="~/page/student/stuMasterPage.master" AutoEventWireup="true" CodeFile="homepage.aspx.cs" Inherits="page_student_homepage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="nav" Runat="Server">
<div class="col-lg-2 span3">
	            <ul class="nav nav-pills nav-stacked text-center">
                    <li class="active"><a href="./homepage.aspx">首页</a></li>
 	                <li><a href="./myinfo.aspx">我的信息</a></li>
 	                <li><a href="./myscore.aspx">我的成绩</a></li>
 	                <li><a href="./change.aspx">修改密码</a></li>
                    <li><a href="../login.aspx">退出</a></li>
                </ul>
	        </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
<div style="margin-top:100px;">
    <asp:Label ID="info" Text="welcome" class=" col-lg-offset-3  h3" runat="server"></asp:Label>
   </div>
</asp:Content>

