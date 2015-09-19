<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrimePage.aspx.cs" Inherits="Homework14.PrimePage" UnobtrusiveValidationMode="None" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
             background-repeat: no-repeat;
        }
        #UserRfield, #PassRfield, #RpassRfield, #AgeRfield, #MailRfield, #Validateemail{
            color : red;
        }
        #UserLabel, #PassLabel, #RpassLabel, #AgeLabel, #MailLabel{
            color : white;
        }
        #Success{
            color : green;
        }
    </style>
</head>
<body background="bgimage.jpg">
    <form id="form1" runat="server">
    <div>
        <center>
            <h1><asp:Label ID="Success" runat="server" Text="Data is successfully submit :)" Visible="false"/></h1>
            <h3><asp:Label ID="UserLabel" runat="server" Text="Username : "/>
            <asp:Label ID="UserRfield" runat="server" Text="Field is empty" Visible="false"/>
            <asp:TextBox ID="username" runat="server" />
            <br/><br/>
            <asp:Label ID="PassLabel" runat="server" Text="Password : " />
            <asp:Label ID="PassRfield" runat="server" Text="Field is empty" Visible="false"/>
            <asp:TextBox  ID="password" runat="server" TextMode="Password"/>
            <br/><br/>
            <asp:Label ID="RpassLabel" runat="server" Text="Repeat password : "/>
            <asp:Label ID="RpassRfield" runat="server" Text="Field is empty" Visible="false"/>
            <asp:TextBox ID="rpassword" runat="server" TextMode="Password"/>
            <br/><br/>
            <asp:Label ID="AgeLabel" runat="server" Text="Age : "/>
            <asp:Label ID="AgeRfield" runat="server" Text="Filed is empty" Visible="false"/>
            <asp:TextBox ID="age" runat="server"/>
            <br/><br/>
            <asp:Label ID="MailLabel" runat="server" Text="Email : "/>
            <asp:Label ID="MailRfield" runat="server" Text="Field is empty" Visible="false"/>
            <asp:TextBox ID="email" runat="server"/>  
            </br></br>
            <asp:Button ID="InfoInTxt" runat="server" Text="Register" OnClick="InfoInTxt_Click"/>
            </h3></center>
    </div>
    </form>
</body>
</html>
