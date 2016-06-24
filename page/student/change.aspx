<%@ Page Title="" Language="C#" MasterPageFile="~/page/student/stuMasterPage.master" AutoEventWireup="true" CodeFile="change.aspx.cs" Inherits="page_student_change" %>

<asp:Content ID="Content1" ContentPlaceHolderID="nav" Runat="Server">
<div class="col-lg-2 span3">
	            <ul class="nav nav-pills nav-stacked text-center">
                    <li><a href="./homepage.aspx">首页</a></li>
 	                <li ><a href="./myinfo.aspx">我的信息</a></li>
 	                <li><a href="./myscore.aspx">我的成绩</a></li>
 	                <li  class="active"><a href="./change.aspx">修改密码</a></li>
                    <li><a href="../login.aspx">退出</a></li>
                </ul>
	        </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
<div class="form-group col-lg-5 col-lg-offset-1" >
    <asp:TextBox runat="server" ID="oldpsw" type="text" style="margin-top:15px;" class=" form-control input-lg col-lg-6 "  placeholder="请输入原密码"/>
    <asp:TextBox runat="server" ID="newpsw" type="text" style="margin-top:5px;"  class="form-control input-lg col-lg-6 "  placeholder="请输入新密码"/>
    <asp:Button runat="server" ID="submit"  
        style="margin-top:5px; margin-left:150px;" class=" btn btn-default btn-lg col-lg-offset-1" 
      Text="确定" onclick="submit_Click" />
      <asp:Button runat="server" ID="reset"  style="margin-top:5px;" class="btn btn-default btn-lg col-lg-offset-1" 
      Text="重置" onclick="reset_Click" />
  </div>
</asp:Content>

