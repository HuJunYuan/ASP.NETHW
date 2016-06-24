<%@ Page Title="" Language="C#" MasterPageFile="~/page/student/stuMasterPage.master" AutoEventWireup="true" CodeFile="myscore.aspx.cs" Inherits="page_student_myscore" %>

<asp:Content ID="Content1" ContentPlaceHolderID="nav" Runat="Server">
    <div class="col-lg-2 span3">
	            <ul class="nav nav-pills nav-stacked text-center">
                    <li><a href="./homepage.aspx">首页</a></li>
 	                <li ><a href="./myinfo.aspx">我的信息</a></li>
 	                <li class="active"><a href="./myscore.aspx">我的成绩</a></li>
 	                <li><a href="./change.aspx">修改密码</a></li>
                    <li><a href="../login.aspx">退出</a></li>
                </ul>
	        </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="content" Runat="Server">
    <div style="margin-left:400px;margin-top:80px;">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="学号" DataSourceID="SqlDataSource1" Height="275px" Width="623px">
        <Columns>
            <asp:BoundField DataField="学号" HeaderText="学号" ReadOnly="True" 
                SortExpression="学号" />
            <asp:BoundField DataField="姓名" HeaderText="姓名" SortExpression="姓名" />
            <asp:BoundField DataField="成绩" HeaderText="成绩" SortExpression="成绩" />
            <asp:BoundField DataField="课程名称" HeaderText="课程名称" SortExpression="课程名称" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:StuInfoConnectionString %>" 
        SelectCommand="SELECT studentInfo.学号, studentInfo.姓名, score.成绩, stuclass.课程名称 FROM studentInfo INNER JOIN score ON studentInfo.学号 = score.学号 INNER JOIN stuclass ON score.课程编号 = stuclass.课程编号 WHERE (studentInfo.学号 = @stunum)">
        <SelectParameters>
            <asp:SessionParameter Name="stunum" SessionField="user" />
        </SelectParameters>
    </asp:SqlDataSource>
</div>
</asp:Content>

