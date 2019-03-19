﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sqlparameterUpdateCloumnNameIsNumber.aspx.cs" Inherits="WebFormCases2.GridViewDemo.sqlparameterUpdateCloumnNameIsNumber" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" DataKeyNames="AttID"   AutoGenerateDeleteButton="true" AutoGenerateEditButton="true" >

        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:EntityDb %>" DeleteCommand="DELETE FROM [Attendance] WHERE [AttID] = @original_AttID AND (([EmpNo] = @original_EmpNo) OR ([EmpNo] IS NULL AND @original_EmpNo IS NULL)) AND (([Name] = @original_Name) OR ([Name] IS NULL AND @original_Name IS NULL)) AND (([Designation] = @original_Designation) OR ([Designation] IS NULL AND @original_Designation IS NULL)) AND (([1] = @original_column1) OR ([1] IS NULL AND @original_column1 IS NULL)) AND (([2] = @original_column2) OR ([2] IS NULL AND @original_column2 IS NULL)) AND (([3] = @original_column3) OR ([3] IS NULL AND @original_column3 IS NULL))" InsertCommand="INSERT INTO [Attendance] ([EmpNo], [Name], [Designation], [1], [2], [3]) VALUES (@EmpNo, @Name, @Designation, @column1, @column2, @column3)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [AttID], [EmpNo], [Name], [Designation], [1] AS column1, [2] AS column2, [3] AS column3 FROM [Attendance]" UpdateCommand="UPDATE [Attendance] SET [EmpNo] = @EmpNo, [Name] = @Name, [Designation] = @Designation, [1] = @column1, [2] = @column2, [3] = @column3 WHERE [AttID] = @original_AttID AND (([EmpNo] = @original_EmpNo) OR ([EmpNo] IS NULL AND @original_EmpNo IS NULL)) AND (([Name] = @original_Name) OR ([Name] IS NULL AND @original_Name IS NULL)) AND (([Designation] = @original_Designation) OR ([Designation] IS NULL AND @original_Designation IS NULL)) AND (([1] = @original_column1) OR ([1] IS NULL AND @original_column1 IS NULL)) AND (([2] = @original_column2) OR ([2] IS NULL AND @original_column2 IS NULL)) AND (([3] = @original_column3) OR ([3] IS NULL AND @original_column3 IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_AttID" Type="Int32" />
                <asp:Parameter Name="original_EmpNo" Type="String" />
                <asp:Parameter Name="original_Name" Type="String" />
                <asp:Parameter Name="original_Designation" Type="String" />
                <asp:Parameter Name="original_column1" Type="String" />
                <asp:Parameter Name="original_column2" Type="String" />
                <asp:Parameter Name="original_column3" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="EmpNo" Type="String" />
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Designation" Type="String" />
                <asp:Parameter Name="column1" Type="String" />
                <asp:Parameter Name="column2" Type="String" />
                <asp:Parameter Name="column3" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="EmpNo" Type="String" />
                <asp:Parameter Name="Name" Type="String" />
                <asp:Parameter Name="Designation" Type="String" />
                <asp:Parameter Name="column1" Type="String" />
                <asp:Parameter Name="column2" Type="String" />
                <asp:Parameter Name="column3" Type="String" />
                <asp:Parameter Name="original_AttID" Type="Int32" />
                <asp:Parameter Name="original_EmpNo" Type="String" />
                <asp:Parameter Name="original_Name" Type="String" />
                <asp:Parameter Name="original_Designation" Type="String" />
                <asp:Parameter Name="original_column1" Type="String" />
                <asp:Parameter Name="original_column2" Type="String" />
                <asp:Parameter Name="original_column3" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
