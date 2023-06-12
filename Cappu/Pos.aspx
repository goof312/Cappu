<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pos.aspx.cs" Inherits="Cappu.Pos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Pos</title>
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
    height: 100%; /* Full height */
  }

  .scrollable-row {
    flex-wrap: wrap;
    max-height: 100%;
  }
  /* Default height */
  #exampleForm2 {

    height: 200px;
  }

  /* Adjust height for screens smaller than 768px */
  @media (max-width: 767px) {
      .scrollable-row {
    flex-wrap: wrap;
    max-height: 830px;
  }


    #exampleForm2 {
      height: 150px;
    }
  }

  /* Adjust height for screens between 768px and 992px */
  @media (min-width: 768px) and (max-width: 991px) {
    #exampleForm2 {
      height: 250px;
    }
  }

  /* Adjust height for screens larger than 992px */
       @media (min-width: 992px) {
           #exampleForm2 {
               height: 500px;
           }
       }

    .no-resize {

  resize: none;
}

.no-drag {
  user-select: none;
}

#inputDisabledEx2{

    margin-top:15px;
}
#Button13{
    margin-top:15px;
}

.gridview {
    border-collapse: collapse;
    border: none;
}

.gridview td, .gridview th {
    border: none;
    padding: 5px;
}
</style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HiddenField ID="hiddenTotal" runat="server" />
        <asp:HiddenField ID="hiddenData" runat="server" />
        <div class="container-fluid border">
            <div class="row">
                <div class="col-lg-8 col-md-6 col-6">
                     <div class="scrollable-row">
                       <div class="row">
                         <div class="col-lg-6 col-md-6 col-12">
                           <asp:Button ID="Button1" runat="server" Text="K1" CssClass="btn btn-primary btn-block btn-lg" OnClick="K1_Click" />
                         </div>
                         <div class="col-lg-6 col-md-6 col-12">
                           <asp:Button ID="Button2" runat="server" Text="K2" CssClass="btn btn-primary btn-block btn-lg" OnClick="K2_Click" />
                         </div>
                         <div class="col-lg-6 col-md-6 col-12">
                           <asp:Button ID="Button3" runat="server" Text="K3" CssClass="btn btn-primary btn-block btn-lg" OnClick="K3_Click" />
                         </div>
                         <div class="col-lg-6 col-md-6 col-12">
                           <asp:Button ID="Button4" runat="server" Text="K4" CssClass="btn btn-primary btn-block btn-lg" OnClick="K4_Click" />
                         </div>
                         <div class="col-lg-6 col-md-6 col-12">
                           <asp:Button ID="Button5" runat="server" Text="K5" CssClass="btn btn-primary btn-block btn-lg" OnClick="K5_Click" />
                         </div>
                         <div class="col-lg-6 col-md-6 col-12">
                           <asp:Button ID="Button6" runat="server" Text="K6" CssClass="btn btn-primary btn-block btn-lg" OnClick="K6_Click"  />
                         </div>
                         <div class="col-lg-6 col-md-6 col-12">
                           <asp:Button ID="Button7" runat="server" Text="K7" CssClass="btn btn-primary btn-block btn-lg" OnClick="K7_Click" />
                         </div>
                         <div class="col-lg-6 col-md-6 col-12">
                           <asp:Button ID="Button8" runat="server" Text="K8" CssClass="btn btn-primary btn-block btn-lg" OnClick="K8_Click" />
                         </div>
                         <div class="col-lg-6 col-md-6 col-12">
                           <asp:Button ID="Button9" runat="server" Text="K9" CssClass="btn btn-primary btn-block btn-lg" OnClick="K9_Click" />
                         </div>
                         <div class="col-lg-6 col-md-6 col-12">
                           <asp:Button ID="Button10" runat="server" Text="K10" CssClass="btn btn-primary btn-block btn-lg" OnClick="K10_Click" />
                         </div>
                         <div class="col-lg-6 col-md-6 col-12">
                           <asp:Button ID="Button11" runat="server" Text="K11" CssClass="btn btn-primary btn-block btn-lg" OnClick="K11_Click" />
                         </div>
                         <div class="col-lg-6 col-md-6 col-12">
                           <asp:Button ID="Button12" runat="server" Text="K12" CssClass="btn btn-primary btn-block btn-lg" OnClick="K12_Click" />
                         </div>
                       </div>
                     </div>
                </div>
                <div class="col-lg-4 col-md-6 col-6" style="overflow: hidden;">
                    <!--<asp:TextBox ID="exampleForm2" runat="server" CssClass="form-control no-resize no-drag" TextMode="MultiLine" Enabled="false"></asp:TextBox>-->
                    <div style="height: 300px; overflow-y: auto;">
 <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered bg-white small">
    <Columns>
        <asp:BoundField DataField="Key" HeaderText="Product Name" ItemStyle-CssClass="text-center" />
        <asp:BoundField DataField="Quantity" HeaderText="Quantity" ItemStyle-CssClass="text-center" />
        <asp:BoundField DataField="Total" HeaderText="Total" ItemStyle-CssClass="text-center" />
    </Columns>
    <HeaderStyle CssClass="thead-dark" />
    <PagerStyle CssClass="pagination justify-content-center" />
    <PagerSettings FirstPageText="First" LastPageText="Last" Mode="Numeric" PageButtonCount="5" />
</asp:GridView>
                        </div>

                    <!-- Total -->
                  <asp:TextBox ID="inputDisabledEx2" runat="server" CssClass="form-control" Text="TOTAL: " Enabled="false" ></asp:TextBox>


                    <div class="col-lg-6 col-md-6 col-12">
                           <asp:Button ID="Button13" runat="server" Text="CANCEL" CssClass="btn btn-primary btn-block btn-lg" OnClick="Cancel_Click" />
                     </div>

                    
                </div>
            </div>
        </div>
    </form>
</body>

</html>
