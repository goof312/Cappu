<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminPage.aspx.cs" Inherits="Cappu.AdminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <div class="w-100 p-2 text-center">
                <asp:GridView ID="GridView1" runat="server" Width="100%" AutoGenerateColumns="true">
                </asp:GridView>
            </div>

        </div>
    </form>
</body>
</html>
