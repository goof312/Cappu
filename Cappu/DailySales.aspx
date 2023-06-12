<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DailySales.aspx.cs" Inherits="Cappu.DailySales" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <style>
    .gridview-table {
        border-collapse: collapse;
        width: 100%;
    }
    .gridview-table th, .gridview-table td {
        border: 1px solid black;
        padding: 8px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="mb-5">

            <div class="w-100 p-2 text-center">
                <asp:GridView ID="GridView2" runat="server" Width="100%" AutoGenerateColumns="true" CssClass="gridview-table">
                </asp:GridView>
            </div>

        </div>


        <div class="m-5">
            <span class="me-4">
                <asp:Label ID="Label1" runat="server" Text="Total:"></asp:Label></span><span><asp:TextBox ID="TextBox1" runat="server" Enabled="False" CssClass="text-center"></asp:TextBox></span>

        </div>
    </form>




</asp:Content>
