<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="history.aspx.cs" Inherits="Cappu.history" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
         <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta http-equiv="x-ua-compatible" content="ie=edge" />
    <link rel="stylesheet"  href="css/mdb.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css"/>
    <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Roboto:wght@300;400;500;700;900&display=swap" />
    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

    <link
      href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"
      rel="stylesheet"
      integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"
      crossorigin="anonymous" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <div class="sticky-lg-top d-flex justify-content-center" style="margin-bottom: 10px">
  <asp:Button ID="btnButton" runat="server" Text="BACK" CssClass="btn btn-primary btn-lg" OnClick="btnButton_Click" />
</div>

            <asp:GridView ID="gridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered bg-ghostwhite small">
                    <Columns>
        <asp:BoundField DataField="OrderID" HeaderText="Order ID" />

                  </Columns>
</asp:GridView>
        </div>

    </form>
</body>
</html>
