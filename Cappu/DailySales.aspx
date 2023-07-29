﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DailySales.aspx.cs" Inherits="Cappu.DailySales" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="https://code.jquery.com/jquery-3.5.1.js"></script>
<script src="https://cdn.datatables.net/1.13.4/js/jquery.dataTables.min.js"></script>
<script src="https://cdn.datatables.net/buttons/2.3.6/js/dataTables.buttons.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/jszip/3.1.3/jszip.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/pdfmake.min.js"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/vfs_fonts.js"></script>
<script src="https://cdn.datatables.net/buttons/2.3.6/js/buttons.html5.min.js"></script>
<script src="https://cdn.datatables.net/buttons/2.3.6/js/buttons.print.min.js"></script>
    <style>
        .gridview-table {
            border-collapse: collapse;
            width: 100%;
        }

            .gridview-table th, .gridview-table td {
                border: 1px solid black;
                padding: 8px;
            }

        .center{
            text-align:right;
        }

        .left{
            text-align:left;
        }
  

        @media (max-width: 767px){
            .center{
                text-align:center;
            
        }
        }
        
    </style>
    


  <script>
      $(document).ready(function () {
          $('#GridView2').DataTable({
              dom: 'Bfrtip',
              buttons: [
                  'copy', 'csv', 'excel', 'pdf', 'print', 'colvis'
              ]
          });
      });
  </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="justify-content-center mt-5" style="background-color: lightblue;">
            <div class="row">
         


                <div class="col-lg-3 col-md-6 col-sm-12 p-3 center">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Date"  Height="50"  Font-Size="25"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="TextBox2" ForeColor="Red" ></asp:RequiredFieldValidator>
                </div>
                <div class="col-lg-3 col-md-6 col-sm-12 p-3 center left">
                      <asp:Button ID="Button1" runat="server" Text="Search" OnClick="search" BackColor="Red" Font-Size="25"/>
                </div>
                   <div class="col-lg-3 col-md-6 col-sm-12  p-3 center ">
                       <asp:DropDownList ID="filterSearch" runat="server" Height="50"  Font-Size="25">
                           <asp:ListItem Selected="True" Value="1">1 day</asp:ListItem>
                           <asp:ListItem Value="3">3 days</asp:ListItem>
                           <asp:ListItem Value="7">1 week</asp:ListItem>
                           <asp:ListItem Value="30">1 month</asp:ListItem>
                           <asp:ListItem Value="90">3 months</asp:ListItem>
                           <asp:ListItem Value="180">6 months</asp:ListItem>
                           <asp:ListItem Value="365">1 year</asp:ListItem>
                       </asp:DropDownList>
                </div>
                  <div class="col-lg-3 col-md-6 col-sm-12 p-3 center left" >
                      <asp:Button ID="Button2" runat="server" Text="Filter" BackColor="Red" Font-Size="25" OnClick="filter" />
                      </div>
               
            </div>
        </div>

        <div class="mb-5">

            <div class="w-100 p-2 text-center">
                <asp:GridView ID="GridView2" runat="server" Width="100%" AutoGenerateColumns="true" CssClass="gridview-table">
                </asp:GridView>
            </div>

        </div>


        <div class="m-5">
            <span class="me-4">
                <asp:Label ID="Label1" runat="server" Text="Total:"></asp:Label></span><span><asp:TextBox ID="TextBox1" runat="server" Enabled="False" CssClass="text-center"></asp:TextBox>
            <br />
            </span>
        </div>
        <div>

            <div>
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Convert to excel</asp:LinkButton>
            </div>

            </div>
    </form>




</asp:Content>
