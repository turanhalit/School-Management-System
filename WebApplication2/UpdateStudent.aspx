<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UpdateStudent.aspx.cs" Inherits="WebApplication2.UpdateStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">

        <div class="form-group">
            <div>
                <asp:Label for="TextId" runat="server" Text="Student ID" style="font-weight: 700"></asp:Label>
                <asp:TextBox ID="TextId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label for="TextName" runat="server" Text="Student Name" style="font-weight: 700"></asp:Label>
                <asp:TextBox ID="TextName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div>
                <asp:Label for="TextSurname" runat="server" Text="Student Surname" style="font-weight: 700"></asp:Label>
                <asp:TextBox ID="TextSurname" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

            <div>
                <asp:Label for="TextNumber" runat="server" Text="Student Number" style="font-weight: 700"></asp:Label>
                <asp:TextBox ID="TextNumber" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

            <div>
                <asp:Label for="TextPassword" runat="server" Text="Student Password" style="font-weight: 700"></asp:Label>
                <asp:TextBox ID="TextPassword" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

            <div>
                <asp:Label for="TextPhoto" runat="server" Text="Student Photo" style="font-weight: 700"></asp:Label>
                <asp:TextBox ID="TextPhoto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

        </div>

        <asp:Button ID="Button1" runat="server" Text="Update" CssClass="btn btn-warning" OnClick="Button1_Click" />
    </form>
</asp:Content>


