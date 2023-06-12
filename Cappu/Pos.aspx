<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pos.aspx.cs" Inherits="Cappu.Pos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pos</title>

    <meta charset="UTF-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />

    <link
      href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"
      rel="stylesheet"
      integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"
      crossorigin="anonymous"
    />
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
    height: 100%; /* Default height */
    overflow-y: auto;
  }

  .col-6 {
    height: 100vh; /* Full height */
  }

  .scrollable-row {
    flex-wrap: wrap;
    max-height: 100vh;

  }
</style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container-fluid border">
            <div class="row">
                <div class="col-lg-8 col-md-6">
                     <div class="scrollable-row">
                       <div class="row">
                         <div class="col-lg-6">
                           <asp:Button ID="Button1" runat="server" Text="button1" CssClass="btn btn-primary btn-block btn-lg" OnClick="K1_Click" />
                         </div>
                         <div class="col-lg-6">
                           <asp:Button ID="Button2" runat="server" Text="button2" CssClass="btn btn-primary btn-block btn-lg" OnClick="K2_Click" />
                         </div>
                         <div class="col-lg-6">
                           <asp:Button ID="Button3" runat="server" Text="button3" CssClass="btn btn-primary btn-block btn-lg" OnClick="K3_Click" />
                         </div>
                         <div class="col-lg-6">
                           <asp:Button ID="Button4" runat="server" Text="button4" CssClass="btn btn-primary btn-block btn-lg" OnClick="K4_Click" />
                         </div>
                         <div class="col-lg-6">
                           <asp:Button ID="Button5" runat="server" Text="button5" CssClass="btn btn-primary btn-block btn-lg" OnClick="K5_Click" />
                         </div>
                         <div class="col-lg-6">
                           <asp:Button ID="Button6" runat="server" Text="button6" CssClass="btn btn-primary btn-block btn-lg" OnClick="K6_Click"  />
                         </div>
                         <div class="col-lg-6">
                           <asp:Button ID="Button7" runat="server" Text="button7" CssClass="btn btn-primary btn-block btn-lg" OnClick="K7_Click" />
                         </div>
                         <div class="col-lg-6">
                           <asp:Button ID="Button8" runat="server" Text="button8" CssClass="btn btn-primary btn-block btn-lg" OnClick="K8_Click" />
                         </div>
                         <div class="col-lg-6">
                           <asp:Button ID="Button9" runat="server" Text="button9" CssClass="btn btn-primary btn-block btn-lg" OnClick="K9_Click" />
                         </div>
                         <div class="col-lg-6">
                           <asp:Button ID="Button10" runat="server" Text="button10" CssClass="btn btn-primary btn-block btn-lg" OnClick="K10_Click" />
                         </div>
                         <div class="col-lg-6">
                           <asp:Button ID="Button11" runat="server" Text="button11" CssClass="btn btn-primary btn-block btn-lg" OnClick="K11_Click" />
                         </div>
                         <div class="col-lg-6">
                           <asp:Button ID="Button12" runat="server" Text="button12" CssClass="btn btn-primary btn-block btn-lg" OnClick="K12_Click" />
                         </div>
                       </div>
                     </div>
                </div>
                <div class="col-lg-4 col-md-6">Col 2</div>
            </div>
        </div>
    </form>
</body>

</html>
