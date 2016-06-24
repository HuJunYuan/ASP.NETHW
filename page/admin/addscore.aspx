<%@ Page Title="" Language="C#" MasterPageFile="~/page/student/stuMasterPage.master" AutoEventWireup="true" CodeFile="addscore.aspx.cs" Inherits="page_admin_addscore" %>

<asp:Content ID="Content1" ContentPlaceHolderID="nav" Runat="Server">
<div class="col-lg-2 span3">
	            <ul class="nav nav-pills nav-stacked text-center">
                    <li><a href="./homepage.aspx">首页</a></li>
 	                <li><a href="./signup.aspx">用户注册</a></li>
 	                <li><a href="./select.aspx">信息查询</a></li>
 	                <li><a href="./delete.aspx">删除信息</a></li>
 	                <li><a href="./add.aspx">增添信息</a></li>
                    <li  class="active"><a href="./addscore.aspx">成绩录入</a></li>
                    <li><a href="../login.aspx">退出</a></li>
                </ul>
	        </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
<p class="text-center h1" style="margin-top:80px;">分数录入</p>
<div class="form-group col-lg-5">
    <asp:TextBox ID="stuNum" runat="server" class="form-control input-lg col-lg-offset-6" style="margin-top:15px;" placeholder="请输入学号"></asp:TextBox>
    <asp:TextBox ID="score" runat="server" class="form-control input-lg col-lg-offset-6" style="margin-top:15px;" placeholder="请输入分数"></asp:TextBox>
    <asp:DropDownList runat="server" ID="which" class="form-control input-lg col-lg-offset-6" style="width:100px; margin-top:15px;">
        <asp:ListItem Value="0001">C++</asp:ListItem>
        <asp:ListItem Value="0002">C#</asp:ListItem>
        <asp:ListItem Value="0003">计算机组成原理</asp:ListItem>
        <asp:ListItem Value="0004">计算机网络</asp:ListItem>
    </asp:DropDownList>
  </div>
  <div>
    <asp:Button runat="server" ID="submit" class="btn btn-default btn-lg" 
          style="margin-top:135px;" Text="确认" onclick="submit_Click"/>
    <asp:Button runat="server" ID="reset" class="btn btn-default btn-lg" 
          style="margin-top:135px;" Text="重置"/>
  </div>
  </div>
</asp:Content>

