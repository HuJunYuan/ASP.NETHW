<%@ Page Title="" Language="C#" MasterPageFile="~/page/admin/MasterPage.master" AutoEventWireup="true" CodeFile="add.aspx.cs" Inherits="page_admin_add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="nav" Runat="Server">
<div class="col-lg-2 span3">
	            <ul class="nav nav-pills nav-stacked text-center">
                    <li><a href="./homepage.aspx">首页</a></li>
 	                <li><a href="./signup.aspx">用户注册</a></li>
 	                <li><a href="./select.aspx">信息查询</a></li>
 	                <li><a href="./delete.aspx">删除信息</a></li>
 	                <li   class="active"><a href="./add.aspx">增添信息</a></li>
                    <li><a href="../login.aspx">退出</a></li>
                </ul>
	        </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
<div class="form-group col-lg-5 col-lg-offset-1" >
    <asp:TextBox runat="server" ID="stuNum" type="text" style="margin-top:15px;" class=" form-control input-lg col-lg-6 "  placeholder="学号"/>
    <asp:TextBox runat="server" ID="name" type="text" style="margin-top:5px;"  class="form-control input-lg col-lg-6 "  placeholder="姓名"/>
    <asp:TextBox runat="server" ID="sex" type="text" style="margin-top:5px;" class="form-control input-lg col-lg-6 "  placeholder="性别"/>
    <asp:TextBox runat="server" ID="xueyuan" type="text" style="margin-top:5px;" class=" form-control input-lg col-lg-6 "  placeholder="学院"/>
    <asp:TextBox runat="server" ID="stuclass" type="text" style="margin-top:5px;" class=" form-control input-lg col-lg-6 "  placeholder="班级"/>
    <asp:TextBox runat="server" ID="math" type="text" style="margin-top:5px;" class=" form-control input-lg col-lg-6 "  placeholder="数学"/>
    <asp:TextBox runat="server" ID="Clan" type="text" style="margin-top:5px;" class=" form-control input-lg col-lg-6 "  placeholder="C语言"/>
    <asp:Button runat="server" ID="submit"  
        style="margin-top:5px; margin-left:150px;" class=" btn btn-default btn-lg col-lg-offset-1" 
      Text="提交" onclick="submit_Click"/>
      <asp:Button runat="server" ID="reset"  style="margin-top:5px;" class="btn btn-default btn-lg col-lg-offset-1" 
      Text="重置"/>
  </div>
 <div>
 
     <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
         DataKeyNames="ID" DataSourceID="SqlDataSource1" EmptyDataText="暂无" 
         Font-Size="Medium" ShowHeaderWhenEmpty="True" Width="406px">
         <Columns>
             <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" 
                 ReadOnly="True" SortExpression="ID" />
             <asp:BoundField DataField="学号" HeaderText="学号" SortExpression="学号">
             </asp:BoundField>
             <asp:BoundField DataField="姓名" HeaderText="姓名" SortExpression="姓名" />
             <asp:BoundField DataField="性别" HeaderText="性别" SortExpression="性别" />
             <asp:BoundField DataField="学院" HeaderText="学院" SortExpression="学院" />
             <asp:BoundField DataField="班级" HeaderText="班级" SortExpression="班级" />
             <asp:BoundField DataField="数学" HeaderText="数学" SortExpression="数学" />
             <asp:BoundField DataField="C语言" HeaderText="C语言" SortExpression="C语言" />
         </Columns>
         <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
         <PagerStyle HorizontalAlign="Center" VerticalAlign="Middle" />
         <RowStyle HorizontalAlign="Center" />
     </asp:GridView>
     <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
         ConnectionString="<%$ ConnectionStrings:StuInfoConnectionString %>" 
         SelectCommand="SELECT * FROM [studentInfo]"></asp:SqlDataSource>
 
 </div>
</asp:Content>

