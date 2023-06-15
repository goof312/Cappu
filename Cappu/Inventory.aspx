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
   
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>


            <div class="w-100 p-2 text-center">
                <asp:GridView ID="GridView1" runat="server" Width="100%" CssClass="gridview-table" >
                    <Columns>
                  

                        <asp:TemplateField HeaderText="Delete">
                            <ItemTemplate>

                                 <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClientClick="return confirm('Are you sure you want to delete this item?');"  OnClick="btnDelete_Click" CommandArgument='<%# Eval("order_id") %>' />
              
    
                            
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>

        </div>
    </form>
</asp:Content>
