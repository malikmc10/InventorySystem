﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReorderRequest.aspx.cs" Inherits="SI_Project.ReorderRequest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reorder Request</title>
	 <link rel="icon" type="image" href="logo.jpg" />
    </head>
<body style="background-color:darkgray">
    <img src="logo2.jpg" style="text-align: center"  />
    <form id="form2" runat="server">
		<asp:Button ID="Button2" runat="server" BackColor="Yellow" BorderColor="#CCCCFF" OnClick="Button2_Click" Text="Return" Width="95px" />
        <asp:Button ID="Button3" runat="server" BackColor="#FFFF99" OnClick="Button3_Click" Text="Log Out" Width="95px" />

        <div id="container">
           
			
            
		   <div>
			   <div style="text-align: right; background-color: #FFFFCC">
			    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
			      <asp:GridView ID="GridView1" runat="server" BackColor="#CCCCCC"  HeaderStyle-Font-Bold="true" ShowHeader="True" AutoGenerateColumns="false" OnDataBound="GridView1_DataBound" >
  <Columns>
         <asp:BoundField DataField="ReOrder_Id" HeaderText="ReOrder ID" 
            />
	  <asp:BoundField DataField="Product_Id" HeaderText="Product ID" 
             />
	  <asp:BoundField DataField="Quantity" HeaderText="Quantity" 
            /> 
	 
    </Columns>

			    </asp:GridView>
				   <br />
                </div>
			   </div>

			<div>
				<br />

			  <h2 style="color:black; font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;">Reorder Submission</h2>
 
				<div style="text-align: left; background-color: #FFFFCC">
                <asp:Label ID="Label1" runat="server" Text="Product Id"></asp:Label>
                    :
                    <br />
                <asp:TextBox ID="TextBox1" runat="server" Width="184px"></asp:TextBox>
				
				<br />
				<asp:Label ID="Label3" runat="server" Text="Quantity"></asp:Label>
				    :<br />
				<asp:TextBox ID="TextBox3" runat="server" Width="186px"></asp:TextBox>
				<br />
				<br />
				<asp:Label ID="Label2" runat="server" Text="Delivery Time"></asp:Label>
				    :<br />
				<asp:TextBox ID="TextBox2" runat="server" Width="187px"></asp:TextBox>
				<br />
				
				<asp:Label ID="Label4" runat="server" Text="Store Location"></asp:Label>
				    :<br />
				<asp:TextBox ID="TextBox4" runat="server" Width="190px"></asp:TextBox>
				    <br />
				<br />
				
              
			</div>
				  <asp:Button ID="Button1" runat="server" Text="Submit Order" OnClick="Button1_Click" BackColor="#339933"  ForeColor="Black" Width="518px" />
                    <br />
                <asp:Label ID="Label5" runat="server" ForeColor="Green" Font-Bold="True"></asp:Label>

			</div>


           
            
        </div>
       
    </form>
    <style type="text/css">
        * {
	box-sizing: border-box;
}

body {
	background: #f6f5f7;
	display: flex;
	justify-content: center;
	align-items: center;
	flex-direction: column;
	font-family: 'Montserrat', sans-serif;
	height: 100vh;
	margin: -20px 0 50px;
}

h1 {
	font-weight: bold;
	margin: 0;
}

h2 {
	text-align: center;
}

p {
	font-size: 14px;
	font-weight: 100;
	line-height: 20px;
	letter-spacing: 0.5px;
	margin: 20px 0 30px;
}

span {
	font-size: 12px;
}

a {
	color: #333;
	font-size: 14px;
	text-decoration: none;
	margin: 15px 0;
}

button {
	border-radius: 20px;
	border: 1px solid #FF4B2B;
	background-color: #FF4B2B;
	color: #FFFFFF;
	font-size: 12px;
	font-weight: bold;
	padding: 12px 45px;
	letter-spacing: 1px;
	text-transform: uppercase;
	transition: transform 80ms ease-in;
}

button:active {
	transform: scale(0.95);
}

button:focus {
	outline: none;
}

button.ghost {
	background-color: transparent;
	border-color: #FFFFFF;
}

form {
	background-color: #FFFFFF;
	display: flex;
	align-items: center;
	justify-content: center;
	flex-direction: column;
	padding: 0 50px;
	height: 100%;
	text-align: center;
}

input {
	background-color: #eee;
	border: none;
	padding: 12px 15px;
	margin: 8px 0;
	width: 100%;
}

.container {
	background-color: #fff;
	border-radius: 10px;
  	box-shadow: 0 14px 28px rgba(0,0,0,0.25), 
			0 10px 10px rgba(0,0,0,0.22);
	position: relative;
	overflow: hidden;
	width: 768px;
	max-width: 100%;
	min-height: 480px;
}

.form-container {
	position: absolute;
	top: 0;
	height: 100%;
	transition: all 0.6s ease-in-out;
}

.sign-in-container {
	left: 0;
	width: 50%;
	z-index: 2;
}

.container.right-panel-active .sign-in-container {
	transform: translateX(100%);
}

.sign-up-container {
	left: 0;
	width: 50%;
	opacity: 0;
	z-index: 1;
}

.container.right-panel-active .sign-up-container {
	transform: translateX(100%);
	opacity: 1;
	z-index: 5;
	animation: show 0.6s;
}

@keyframes show {
	0%, 49.99% {
		opacity: 0;
		z-index: 1;
	}
	
	50%, 100% {
		opacity: 1;
		z-index: 5;
	}
}

.overlay-container {
	position: absolute;
	top: 0;
	left: 50%;
	width: 50%;
	height: 100%;
	overflow: hidden;
	transition: transform 0.6s ease-in-out;
	z-index: 100;
}

.container.right-panel-active .overlay-container{
	transform: translateX(-100%);
}

.overlay {
	background: #FF416C;
	background: -webkit-linear-gradient(to right, #FF4B2B, #FF416C);
	background: linear-gradient(to right, #FF4B2B, #FF416C);
	background-repeat: no-repeat;
	background-size: cover;
	background-position: 0 0;
	color: #FFFFFF;
	position: relative;
	left: -100%;
	height: 100%;
	width: 200%;
  	transform: translateX(0);
	transition: transform 0.6s ease-in-out;
}

.container.right-panel-active .overlay {
  	transform: translateX(50%);
}

.overlay-panel {
	position: absolute;
	display: flex;
	align-items: center;
	justify-content: center;
	flex-direction: column;
	padding: 0 40px;
	text-align: center;
	top: 0;
	height: 100%;
	width: 50%;
	transform: translateX(0);
	transition: transform 0.6s ease-in-out;
}

.overlay-left {
	transform: translateX(-20%);
}

.container.right-panel-active .overlay-left {
	transform: translateX(0);
}

.overlay-right {
	right: 0;
	transform: translateX(0);
}

.container.right-panel-active .overlay-right {
	transform: translateX(20%);
}

.social-container {
	margin: 20px 0;
}

.social-container a {
	border: 1px solid #DDDDDD;
	border-radius: 50%;
	display: inline-flex;
	justify-content: center;
	align-items: center;
	margin: 0 5px;
	height: 40px;
	width: 40px;
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
	<footer>&copy; Copyright 2020 Juici Patties Limited</footer>
</body>
</html>


