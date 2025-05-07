start page.aspx

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="start page.aspx.cs" Inherits="Default7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <title>Freshy Zone</title>
   
       
        <meta charset="UTF-8">
        <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="preconnect" href="https://fonts.googleapis.com">
<link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
<link href="https://fonts.googleapis.com/css2?family=Poppins:wght@500&family=Raleway:wght@600&display=swap" rel="stylesheet">
   
    <style type="text/css">
        .auto-style3 {
            text-align: left;
        }
        .auto-style4 {
            width: 100%;
        }
        .auto-style5 {
            height: 23px;
            text-align: center;
        }
        * {box-sizing: border-box;}
        
.mySlides {display: none;}
img {vertical-align:middle;
     height:400px;
      margin-top: 7px; ;
}

/* Slideshow container */
.slideshow-container {
  max-width: 1000px;
  position: relative;
   margin-top: 30px;
            top: -32px;
            left: -8px;
            height: 29px;
        }

/* Caption text */
.text {
  color: #f2f2f2;
  font-size: 15px;
  padding: 8px 12px;
  position: absolute;
  bottom: 8px;
  width: 100%;
  text-align: center;
}

/* Number text (1/3 etc) */
.numbertext {
  color: #f2f2f2;
  font-size: 12px;
  padding: 8px 12px;
  position: absolute;
  top: 0;
}

/* The dots/bullets/indicators */
.dot {
  height: 15px;
  width: 15px;
  margin-top: 63px;
  background-color: #bbb;
  border-radius: 50%;
  display: inline-block;
  transition: background-color 0.6s ease;
  background-position:left;
}

.active {
  background-color: #717171;
}

/* Fading animation */
.fade {
  animation-name: fade;
  animation-duration: 1.5s;
}

@keyframes fade {
  from {opacity: .4} 
  to {opacity: 1}
}

/* On smaller screens, decrease text size */
@media only screen and (max-width: 300px) {
  .text {font-size: 11px}
}
body {
    overflow-x: hidden;
    font-family:'poppins';
    font-family:'raleway';                   

}


#sticky{
    position:fixed;
    top:0;
    width:100%;
            left: 0px;
            height: 86px;
        }
.menu{
    background:rgba(244, 180, 26, 1);
    text-align:center;
}
.menu-ul{
    margin:0;
    padding:0;
    display:inline;
}
.menu-ul li{
    font-size:20px;
    list-style:none;
    font-weight:bold;
    display:inline-block;
    padding:25px 25px 26px 25px;
    
}
.a-menu{
    text-decoration:none;
    color:rgba(20, 61, 89, 1);
    font-weight:bold;
    font-size:20px;
}
.aaa
{
color:rgba(20, 61, 89, 1);
    font-weight:bold;
    font-size:30px;
}

.menu-ul li:hover{
    background:rgba(244, 180, 26, 1);
    transform:scale(1.1);
}

i{
    font-size:20px;
     margin:0 10px 0 0;
}

a{
    text-decoration:none;
}
.buynow{
    border:1px solid rgba(244, 180, 26, 1);
    background: rgba(244, 180, 26, 1);
    padding:5px 15px;
    border-radius:20px;
    font-weight:bold;
    font-size:17px;
    margin-top:10px;
    color:rgba(20, 61, 89, 1);
}
.buynow:hover{
    border:2px solid rgba(244, 180, 26, 1);
    box-shadow:2px 2px 10px 5px white inset; 
}
 .parallax1{
    background-image:url('img/downback.jpg');
    height:max-content;
    background-attachment:fixed;
    background-position:center;
    background-repeat:no-repeat;
    background-size:cover;
}
        .footer{
    padding:20px;
    background:rgba(0,0,0,0.5);
    text-align:center;
}
.quick-links, .a-links{
    color:white;
    font-size:20px;
    font-weight:bold;
    display:inline-block;
    min-width:30%;
}
.quick-links{
 font-size:30px;
}
.quick-links ul{
    padding:0;
}
.quick-links li{
    list-style:none;
    padding:10px;
    font-weight:300;
}
.a-links:hover{
    color:rgba(244, 180, 26, 1);
}
.copyrights{
    font-size:16px;
    text-align:center;
    margin:15px;
}
.logo{
    border-radius:50%;
    position:left;
}
        </style>
</head>
<body>
     <form id="form1" runat="server">

 <div class="auto-style3">
    

    
        <br />
        <br />
       
 
            
    <div class="menu" id="sticky">
         <asp:Label ID="Label1" runat="server" Class="aaa" Text="Freshy Zone"></asp:Label>
  <img src="img/img.png" class="logo" style="height: 76px; color:rgba(20, 61, 89, 1); width: 96px; margin-left: 124px; margin-top: 0px;" align="left" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;Products&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
         &nbsp; in cart &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <ul class="menu-ul">
            
            <a href='start page.aspx' class="a-menu" ><li>Home</li></a>
           <a href='login page.aspx' class="a-menu" ><li>Registration</li></a>
            <a href='#contact' class="a-menu" ><li>Contact Us </li></a>
        </ul>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:HyperLink ID="HyperLink3" class="a-menu" runat="server" NavigateUrl="~/cart page.aspx">Show Cart</asp:HyperLink>
       </div>
 

        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <!--SLIDESHOW begins-->
        <div class="slideshow-container">

<div class="mySlides fade">
  <div class="numbertext"></div>
  <img src="img/fruits2.jpg" style="width:150%">
  
</div>

<div class="mySlides fade">
  <div class="numbertext"></div>
  <img src="img/fruits3.png" style="width:150%" >
  
</div>

<div class="mySlides fade">
  <div class="numbertext"></div>
  <img src="img/slideshow4.jpg" style="width:150%">
  
</div>

</div>
<br>

<div style="text-align:center">
  <span class="dot"></span> 
  <span class="dot"></span> 
  <span class="dot"></span> 
</div>

<script>
    let slideIndex = 0;
    showSlides();

    function showSlides() {
        let i;
        let slides = document.getElementsByClassName("mySlides");
        let dots = document.getElementsByClassName("dot");
        for (i = 0; i < slides.length; i++) {
            slides[i].style.display = "none";
        }
        slideIndex++;
        if (slideIndex > slides.length) { slideIndex = 1 }
        for (i = 0; i < dots.length; i++) {
            dots[i].className = dots[i].className.replace(" active", "");
        }
        slides[slideIndex - 1].style.display = "block";
        dots[slideIndex - 1].className += " active";
        setTimeout(showSlides, 2000); // Change image every 2 seconds
    }
</script>
        <!--SLIDESHOW ends-->
     <br/>
         <br/>
         <br/>
         <br/>
         <br/>
         <br/>
         <br/>
         <br/>
         <br/>
         <br/>
         <br/>
         <br/>
     <br/>
         <br/>
         <br/>
     
     
       
        
         <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" style="text-align: center" Width="348px" HorizontalAlign="Center" OnItemCommand="DataList1_ItemCommand" RepeatColumns="3" RepeatDirection="Horizontal">
             <ItemTemplate>
                 <table class="auto-style4">
                     <tr>
                         <td style="text-align: center">ID:<asp:Label ID="Label3" runat="server" Text='<%# Eval("ProductID") %>'></asp:Label>
                             <br />
                             <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("ProductImage") %>' Height="220px" Width="269px" />
                         </td>
                     </tr>
                     <tr>
                         <td style="text-align: center">
                             <asp:Label ID="Label4" runat="server" Text='<%# Eval("ProductName") %>'></asp:Label>
                         </td>
                     </tr>
                     <tr>
                         <td class="auto-style5">Price:<asp:Label ID="Label5" runat="server" Text='<%# Eval("Price") %>'></asp:Label>
                             /kg</td>
                     </tr>
                     <tr>
                         <td style="text-align: center">Quantity:
                             <asp:DropDownList ID="DropDownList1" runat="server" >
                                 <asp:ListItem>1</asp:ListItem>
                                 <asp:ListItem>2</asp:ListItem>
                                 <asp:ListItem>3</asp:ListItem>
                                 <asp:ListItem>4</asp:ListItem>
                                 <asp:ListItem>5</asp:ListItem>
                             </asp:DropDownList>
                         </td>
                     </tr>
                     <tr>
                         <td style="text-align: center">
                             <asp:Button ID="Button1" runat="server" class="buynow" CommandName="Default8" CommandArgument='<%# Eval("Productid") %>' Text="Buy Now" />
                         </td>
                     </tr>
                 </table>
                 <br />
             </ItemTemplate>
         </asp:DataList>
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:saiConnectionString3 %>" SelectCommand="SELECT * FROM [sai]"></asp:SqlDataSource>
         <!--footer starts-->
        <div class="parallax1">
            <div class="footer" id="contact"> 
                <div class="quick-links">
                    <div>Locations</div>
                    <ul>
                        <li><a href="" class="a-links">Chennai</a></li>
                        <li><a href="" class="a-links">Madurai</a></li>
                        <li><a href="" class="a-links">Kovipatti</a></li>
                    </ul>
                </div>
                  <div class="quick-links">
                    <div>Careers</div>
                    <ul>
                        <li><a href="" class="a-links">Packing Staffs</a></li>
                        <li><a href="" class="a-links">Delivery Agents</a></li>
                        <li><a href="" class="a-links">Services</a></li>
                    </ul>
                </div>
                  <div class="quick-links">
                    <div>Quick links</div>
                    <ul>
                        <li><a href="" class="a-links">Contact Us</a></li>
                        <li><a href="" class="a-links">FAQ</a></li>
                        <li><a href="" class="a-links">Help</a></li>
                    </ul>
                </div>
            </div>
             </div>
        <div class="copyrights">
            <i class="copyright" ></i>@JJ Grocery store
        </div>
           
        <!--footer ends-->
    </div>   
    </form>
 </body>
</html>



start page.aspx.cs



using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class Default7 : System.Web.UI.Page
{
     protected void Page_Load(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        dt = (DataTable)Session["buyitems"];
        if (dt != null)
        {
            Label2.Text = dt.Rows.Count.ToString();
        }
        else
        {
            Label2.Text = "0";
        }
    }


     protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
     {
         DropDownList dlist = (DropDownList)(e.Item.FindControl("DropDownList1"));
         Response.Redirect("cart page.aspx?id=" + e.CommandArgument.ToString() + "&quantity=" + dlist.SelectedItem.ToString());
     }
}
   
