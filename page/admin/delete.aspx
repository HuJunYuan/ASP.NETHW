<%@ Page Title="" Language="C#" MasterPageFile="~/page/admin/MasterPage.master" AutoEventWireup="true" CodeFile="delete.aspx.cs" Inherits="page_admin_delete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="nav" Runat="Server">
<div class="col-lg-2 span3">
	            <ul class="nav nav-pills nav-stacked text-center">
                    <li><a href="./homepage.aspx">首页</a></li>
 	                <li><a href="./signup.aspx">用户注册</a></li>
 	                <li><a href="./select.aspx">信息查询</a></li>
 	                <li class="active"><a href="./delete.aspx">删除信息</a></li>
 	                <li><a href="./add.aspx">增添信息</a></li>
                    <li><a href="./addscore.aspx">成绩录入</a></li>
                    <li><a href="../login.aspx">退出</a></li>
                </ul>
	        </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<div class="form-group col-lg-5 form-search">
    <asp:TextBox runat="server" ID="name" type="text" class=" input-medium   input-lg col-lg-6 "  placeholder="请输入要删除的学号"/>
   <asp:Button runat="server" ID="submit" class="btn btn-default btn-lg col-lg-offset-1" 
      Text="删除" onclick="submit_Click"/>
  </div>
  <div>
      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
          DataKeyNames="ID" DataSourceID="SqlDataSource1" Width="363px">
          <Columns>
              <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
                  ReadOnly="True" SortExpression="ID" />
              <asp:BoundField DataField="学号" HeaderText="学号" SortExpression="学号" />
              <asp:BoundField DataField="姓名" HeaderText="姓名" SortExpression="姓名" />
              <asp:BoundField DataField="性别" HeaderText="性别" SortExpression="性别" />
              <asp:BoundField DataField="学院" HeaderText="学院" SortExpression="学院" />
              <asp:BoundField DataField="班级" HeaderText="班级" SortExpression="班级" />
              <asp:BoundField DataField="数学" HeaderText="数学" SortExpression="数学" />
              <asp:BoundField DataField="C语言" HeaderText="C语言" SortExpression="C语言" />
          </Columns>
      </asp:GridView>
      <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
          ConnectionString="<%$ ConnectionStrings:StuInfoConnectionString %>" 
          SelectCommand="SELECT * FROM [studentInfo]"></asp:SqlDataSource>
    </div>
</asp:Content>

