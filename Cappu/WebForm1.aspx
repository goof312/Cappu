<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Cappu.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta http-equiv="x-ua-compatible" content="ie=edge" />
    <link rel="stylesheet"  href="css/mdb.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css"/>
    <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Roboto:wght@300;400;500;700;900&display=swap" />

 
    <title></title>
</head>
    
<body>
<style>
  [class*="col"] {
    padding: 1rem;
    background-color: #33b5e5;
    border: 2px solid #fff;
    color: #fff;
  }

  .child {
    background-color: #2041d3;
  }

  .col-lg-8 {
      flex-wrap: wrap;
    height: 100%; /* Default height */
   
  }

  .col-6 {
    height: 100vh; /* Full height */
     overflow-y: auto;
  }
   #exampleForm2 { /* For button */
        height: 450px; /* Default height */
         overflow-y: auto;
    }

    /* Media query for screens smaller than 600px */
    @media (max-width: 600px) {
        #exampleForm2 {
            height: 300px; /* Adjusted height for smaller screens */
        }
    }

    /* Media query for screens between 601px and 1200px */
    @media (min-width: 601px) and (max-width: 1200px) {
        #exampleForm2 {
            height: 250px; /* Adjusted height for medium screens */
        }
    }

    /* Media query for screens larger than 1200px */
    @media (min-width: 1201px) {
        #exampleForm2 {
            height: 300px; /* Adjusted height for larger screens */
        }
    }
</style>





 


<form id="form1" runat="server">
  <div class="row">
    <div class="col-lg-8 col-6">
      <div class="row scrollable-row">
        <div class="col-lg-4 col-sm-5">
          <asp:Button ID="Button1" runat="server" Text="k1" CssClass="btn btn-primary btn-block btn-lg" OnClick="Button1_Click" />
        </div>
        <div class="col-lg-4 col-sm-5">
          <asp:Button ID="Button2" runat="server" Text="k2" CssClass="btn btn-primary btn-block btn-lg" OnClick="Button2_Click" />
        </div>
        <div class="col-lg-4 col-sm-5">
          <asp:Button ID="Button3" runat="server" Text="K3" CssClass="btn btn-primary btn-block btn-lg" OnClick="Button3_Click" />
        </div>
        <div class="col-lg-4 col-sm-5">
          <asp:Button ID="Button4" runat="server" Text="K4" CssClass="btn btn-primary btn-block btn-lg" OnClick="Button4_Click" />
        </div>
        <div class="col-lg-4 col-sm-5">
          <asp:Button ID="Button5" runat="server" Text="K5" CssClass="btn btn-primary btn-block btn-lg" OnClick="Button5_Click" />
        </div>
        <div class="col-lg-4 col-sm-5">
          <asp:Button ID="Button6" runat="server" Text="K6" CssClass="btn btn-primary btn-block btn-lg" OnClick="Button6_Click" />
        </div>
        <div class="col-lg-4 col-sm-5">
          <asp:Button ID="Button7" runat="server" Text="K7" CssClass="btn btn-primary btn-block btn-lg" OnClick="Button7_Click" />
        </div>
        <div class="col-lg-4 col-sm-5">
          <asp:Button ID="Button8" runat="server" Text="K8" CssClass="btn btn-primary btn-block btn-lg" OnClick="Button8_Click" />
        </div>
        <div class="col-lg-4 col-sm-5">
          <asp:Button ID="Button9" runat="server" Text="K9" CssClass="btn btn-primary btn-block btn-lg" OnClick="Button9_Click" />
        </div>
      </div>
    </div>
    <div class="col-lg-4 col-6">
      <input type="text" id="exampleForm2" class="form-control"/>
    </div>
  </div>
</form>

</body>
</html>
