<%@ Page Title="" Language="C#" MasterPageFile="~/page/admin/MasterPage.master" AutoEventWireup="true" CodeFile="signup.aspx.cs" Inherits="page_admin_signup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="nav" Runat="Server">
    <div class="col-lg-2 span3">
	            <ul class="nav nav-pills nav-stacked text-center">
                    <li><a href="./homepage.aspx">首页</a></li>
 	                <li class="active"><a href="./signup.aspx">用户注册</a></li>
 	                <li><a href="./select.aspx">信息查询</a></li>
 	                <li><a href="./delete.aspx">删除信息</a></li>
 	                <li><a href="./add.aspx">增添信息</a></li>
                    <li><a href="../login.aspx">退出</a></li>
                </ul>
	        </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
    <div class="form-group col-lg-5 col-lg-offset-1">
    <asp:TextBox runat="server" ID="username" type="text" style="margin-top:5px;" class=" form-control input-lg col-lg-6 "  placeholder="新输入新增用户名"/>
    <asp:TextBox runat="server" ID="password" type="text" style="margin-top:5px;" class=" form-control input-lg col-lg-6 "  placeholder="请输入密码"/>
    <asp:Button runat="server" ID="submit"  
        style="margin-top:15px; margin-left:150px;" class=" btn btn-default btn-lg col-lg-offset-1" 
      Text="提交" onclick="submit_Click"/>
      <asp:Button runat="server" ID="reset"  style="margin-top:15px;" class="btn btn-default btn-lg col-lg-offset-1" 
      Text="重置" onclick="reset_Click"/>
  </div>
  <div style="text-align: center">
  
      <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
          BackColor="White" BorderColor="Silver" BorderStyle="None" BorderWidth="0px" 
          CellPadding="4" DataKeyNames="username" DataSourceID="SqlDataSource1" 
          ForeColor="Black" GridLines="Horizontal" HorizontalAlign="Center" Width="398px">
          <Columns>
              <asp:BoundField DataField="username" HeaderText="username" ReadOnly="True" 
                  SortExpression="username" />
              <asp:BoundField DataField="password" HeaderText="password" 
                  SortExpression="password" />
          </Columns>
          <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
          <HeaderStyle BackColor="#999999" Font-Bold="True" Font-Size="Large" 
              ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
          <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
          <RowStyle HorizontalAlign="Center" />
          <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" 
              HorizontalAlign="Center" VerticalAlign="Middle" />
          <SortedAscendingCellStyle BackColor="#F7F7F7" />
          <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
          <SortedDescendingCellStyle BackColor="#E5E5E5" />
          <SortedDescendingHeaderStyle BackColor="#242121" />
      </asp:GridView>
      <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
          ConnectionString="<%$ ConnectionStrings:StuInfoConnectionString %>" 
          SelectCommand="SELECT * FROM [admin]"></asp:SqlDataSource>
  
  </div>
</asp:Content>

