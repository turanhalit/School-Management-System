<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master"
    AutoEventWireup="true" CodeBehind="StudentList.aspx.cs"
    Inherits="WebApplication2.StudentList" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-bordered table-hover">

        <tr>
            <th>Student ID</th>
            <th>Student Name</th>
            <th>Student Surname</th>
            <th>Student Number</th>
            <th>Student Password</th>
            <th>Student Photo</th>
            <th>Student Balance</th>
            <th>Transactions</th>

        </tr>
        <tbody>

            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("id")%></td>
                        <td><%#Eval("name")%></td>
                        <td><%#Eval("surname")%></td>
                        <td><%#Eval("number")%></td>
                        <td><%#Eval("password")%></td>
                        <td><%#Eval("photo")%></td>
                        <td><%#Eval("balance")%></td>
                        <td>
                            <asp:HyperLink NavigateUrl='<%# "DeleteStudent.aspx?ID=" + Eval("ID") %>' ID="HyperLink1" CssClass="btn btn-danger " runat="server">Delete</asp:HyperLink>
                            <asp:HyperLink NavigateUrl='<%# "UpdateStudent.aspx?ID=" + Eval("ID") %>' ID="HyperLink2" CssClass="btn btn-success" runat="server">Update</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>

    </table>
</asp:Content>
