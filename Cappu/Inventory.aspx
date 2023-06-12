<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Inventory.aspx.cs" Inherits="Cappu.Inventory" %>

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
        <div>
         
            <div class="w-100 p-2 text-center">
                <asp:GridView ID="GridView1" runat="server" Width="100%" CssClass="gridview-table"></asp:GridView>
            </div>

        </div>
    </form>
</asp:Content>
