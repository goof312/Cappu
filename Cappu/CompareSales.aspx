<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CompareSales.aspx.cs" Inherits="Cappu.CompareSales" %>

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
        <div class="m-5">
            <div class="row justify-content-center">
                <div class="col-lg-3 col-md-12 text-center mb-3">
                    <asp:TextBox ID="TextBox1" runat="server" TextMode="Date" CssClass="text-center"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
                <div class="col-lg-3 col-md-12 text-center mb-3"><span class="m-5">Compare Sales</span></div>
                <div class="col-lg-3 col-md-12 text-center mb-3">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Date" CssClass="text-center"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
                <div class="col-lg-3 col-md-12 text-center mb-3">
                    <asp:Button ID="Button1" runat="server" Text="Compare" OnClick="information_show" BackColor="Red" />
                </div>
            </div>

        </div>



   
            <div class="justify-content-center mt-5 " style="background-color: lightblue">
                <div class="text-center">
          <asp:Label ID="Label1" runat="server" Text="Total"></asp:Label>
                    <asp:TextBox ID="TextBox3" runat="server" Enabled="false" CssClass="text-center"></asp:TextBox>
                </div>
                <div class="text-center">
                 <asp:Label ID="Label2" runat="server" Text="Total"></asp:Label>
                    <asp:TextBox ID="TextBox4" runat="server" Enabled="false" CssClass="text-center"></asp:TextBox>
                </div>
                 <div class="text-center">
                 <asp:Label ID="Label3" runat="server" Text="Difference"></asp:Label>
                    <asp:TextBox ID="TextBox5" runat="server" Enabled="false" CssClass="text-center"></asp:TextBox>
                </div>
              
                 
            </div>

           


         <div class="w-100 p-2 text-center">
                <asp:GridView ID="GridView1" runat="server" Width="100%" CssClass="gridview-table"></asp:GridView>
            </div>

   
            <div class="justify-content-center mt-5 " style="background-color: lightblue">
                <div  class="text-center">
                   
  
                </div>
                   

        

        </div>
            <div class="w-100 p-2 text-center">
                <asp:GridView ID="GridView2" runat="server" Width="100%" CssClass="gridview-table"></asp:GridView>
            </div>
    </form>
</asp:Content>
