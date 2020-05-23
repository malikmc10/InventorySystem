<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="POS.aspx.cs" Inherits="SI_Project.POS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Point Of Sale</title>
     <link rel="icon" type="image" href="logo.jpg" />
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/popper.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
     <script>
         function GetUserValue() {
             var person = prompt("Please Enter The Quantity", "1");
             if (person != null && person != "") {
                 document.getElementById("<%=hdnUserInput.ClientID%>").value = person;
                
                 return true;
             }
             else
                 return false;
         }
    </script>
</head>
<body style="background-color:darkgray">
   <p align="center"> <img src="logo2.jpg"/> </p> 
    <form id="form1" runat="server" align="center">
     
        <asp:Label ID="Label2" runat="server" Text="" Font-Bold="True" Font-Italic="True" Font-Size="Larger"></asp:Label>

         <asp:HiddenField runat="server" ID="hdnUserInput" />

        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="True" Font-Underline="True" Font-Size="XX-Large" Visible="False"></asp:Label>
        
       
     

            
    
        <div style="background-image: url('Image/posim.jpg');align-items:center">
            <br />
             <br />
             <br />
            <asp:Button ID="Button1" CssClass="button" runat="server" Text="Cheese Patty" value="180" OnClick="Button1_Click"  OnClientClick="return GetUserValue();"/>
            <asp:Button ID="Button2" CssClass="button" runat="server" Text="Large Food" value="570" OnClick="Button2_Click"  OnClientClick="return GetUserValue();" />
            <asp:Button ID="Button3" CssClass="button" runat="server" Text="Water" value="90" OnClick="Button3_Click" OnClientClick="return GetUserValue();" />
            <br />
             <br />
             <asp:Button ID="Button5" CssClass="button" runat="server" Text="Small Food" value="370" OnClick="Button5_Click" OnClientClick="return GetUserValue();"  />
            <asp:Button ID="Button6" CssClass="button" runat="server" Text="Soda" value="100" OnClick="Button6_Click" OnClientClick="return GetUserValue();"  />
            <asp:Button ID="Button7" CssClass="button" runat="server" Text="Coco-Bread" value="90" OnClick="Button7_Click" OnClientClick="return GetUserValue();"  />
            <br />
             <br />
            <asp:Button ID="Button8" CssClass="button" runat="server" Text="Beef Patty" value="150" OnClick="Button8_Click" OnClientClick="return GetUserValue();"  />
            <asp:Button ID="Button9" CssClass="button" runat="server" Text="Shrimp Patty" value="190" OnClick="Button9_Click"  OnClientClick="return GetUserValue();" />
            <asp:Button ID="Button10" CssClass="button" runat="server" Text="Orange Juice" value="130" OnClick="Button10_Click" OnClientClick="return GetUserValue();" />

             <br />
            <br />
            <br />
            <asp:Button ID="Button4" CssClass="button1" runat="server" Text="Total" OnClick="Button4_Click" />
   
            <asp:Button ID="Button11" CssClass="button1" runat="server" Text="Checkout" OnClick="Button11_Click"  />
             <br /> <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="totaltxt" runat="server" Font-Bold="True" Font-Size="Larger"></asp:Label>
            <br />
            <br />
             <asp:Label ID="Label3" runat="server" Text="" ForeColor="Green"></asp:Label>
             <br />
            <br />
            <asp:Button ID="Button12" runat="server" Text="Logout" CssClass="button1" OnClick="Button12_Click" />
            <br />
            <br />
           

        </div>
          <br />
       
        
        <div style="align-items:center">
      
          <img src="Image/ad%20image.jpg" />

        <img src="Image/advertise.jpg" height="225" width="225" />
             
              
              <img src="Image/advistisement.jpg" />
           </div>
          
           
    </form>
    <footer>&copy; Copyright 2020 Juici Patties Limited</footer>
</body>
    </html>
    <style>

.button {
  padding: 15px 25px;
  font-size: 24px;
  text-align: center;
  cursor: pointer;
  outline: none;
  color: #fff;
  background-color: #4CAF50;
  border: none;
  border-radius: 15px;
  box-shadow: 0 9px #999;
}

.button:hover {background-color: #3e8e41}

.button:active {
  background-color: #3e8e41;
  box-shadow: 0 5px #666;
  transform: translateY(4px);
}


.button1 {
  padding: 15px 25px;
  font-size: 24px;
  text-align: center;
  cursor: pointer;
  outline: none;
  color: black;
  background-color: yellow;
  border: none;
  border-radius: 15px;
  box-shadow: 0 9px #999;
}

.button1:hover {background-color: #3e8e41}

.button1:active {
  background-color: #3e8e41;
  box-shadow: 0 5px #666;
  transform: translateY(4px);
}
footer {
    background-color: #222;
    color: #fff;
    font-size: 14px;
    bottom: 0;
    position: fixed;
    left: 0;
    right: 0;
    text-align: center;
    z-index: 999;
}

footer p {
    margin: 10px 0;
}

footer i {
    color: red;
}

footer a {
    color: #3c97bf;
    text-decoration: none;
}
        
    </style>

