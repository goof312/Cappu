<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="poss.aspx.cs" Inherits="Cappu.poss" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta http-equiv="x-ua-compatible" content="ie=edge" />
    <link rel="stylesheet" href="css/mdb.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/css2?family=Roboto:wght@300;400;500;700;900&display=swap" />
    <script>
        var clickCounts = []; // Array to store the click counts

        function countButtonClick(buttonIndex) {
            clickCounts[buttonIndex]++; // Increment the click count for the corresponding button

            // Bind the updated clickCounts array to the Repeater
            var resultsContainer = document.getElementById('resultsContainer');
            var repeaterContainer = resultsContainer.querySelector('[id$="ResultsRepeater"]');

            repeaterContainer.innerHTML = ''; // Clear the Repeater container

            for (var i = 0; i < clickCounts.length; i++) {
                if (clickCounts[i] > 0) {
                    var itemTemplate = document.createElement('div');
                    itemTemplate.innerHTML = 'Button ' + (i + 1) + ': Clicked <span>' + clickCounts[i] + '</span> times';
                    repeaterContainer.appendChild(itemTemplate);
                }
            }
        }
    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
            <div class="col-9">
                <div class="row">
                    <asp:Repeater ID="ProductsRepeater" runat="server" OnItemDataBound="ProductsRepeater_ItemDataBound">
                        <ItemTemplate>
                            <div class="col-4 p-3 mb-2" style="height: 200px">
                                <div class="row h-100">
                                    <button class="col-12" id="Button1" onclick='countButtonClick(<%# Container.ItemIndex %>)'>
                                        <%# Eval("product_name") %>
                                    </button>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>

                <div id="resultsContainer">
                    <asp:Repeater ID="ResultsRepeater" runat="server">
                        <ItemTemplate>
                            <div>Button <%# Container.ItemIndex + 1 %>: Clicked <span><%# Eval("Count") %></span> times</div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>


            </div>


            <div class="col-3 border border-dark">
            </div>

        </div>
    </form>
</body>


</html>
