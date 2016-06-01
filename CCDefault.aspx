<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title> Currency Converter</title>
</head>

<body style="background-color: Black; font-family:Calibri, Sans-Serif, Arial; color: White ">

    <form id="form1" runat="server">

     
     <b><asp:Label ID="Label3" runat="server" Text=" Standard Currency Converter"></asp:Label></b>
       :
          <div style="height: 346px">
  
        <p>Enter a number: <asp:TextBox ID="Txt3" runat="server"></asp:TextBox></p>
        
        &nbsp;
              <p style="text-align: left">
                  Select Currency: 
                  <asp:DropDownList ID="DDL3" runat="server" 
                onselectedindexchanged="DDL3_SelectedIndexChanged" >
                      <asp:ListItem Value="1.2329">Canadian Dollar</asp:ListItem>
                      <asp:ListItem Value="0.9326">Swiss Franc</asp:ListItem>
                      <asp:ListItem Value="0.6432">Pound Sterling</asp:ListItem>
                      <asp:ListItem Value="1">US Dollar</asp:ListItem>
                      <asp:ListItem Value="123.454">Japanese Yen</asp:ListItem>
                  </asp:DropDownList>
              </p>
            
        <p>Select Currency: <asp:DropDownList ID="DDL4" runat="server">
            <asp:ListItem Value="1.2329">Canadian Dollar</asp:ListItem>
            <asp:ListItem Value="0.9326">Swiss Franc</asp:ListItem>
            <asp:ListItem Value="0.6432">Pound Sterling</asp:ListItem>
            <asp:ListItem Value="1">US Dollar</asp:ListItem>
            <asp:ListItem Value="123.454">Japanese Yen</asp:ListItem>

        </asp:DropDownList></p>
            
     
          <p><asp:Button ID="Button2" runat="server" Text="Convert Currency" onclick="Button2_Click" />    </p>
              <p>
                  <asp:Label ID="Label4" runat="server" Text="Conversion"></asp:Label>
              </p>   
          </div>
     
        <b><asp:Label ID="Label1" runat="server" Text="Currency Converter using Json API"></asp:Label></b>
       
          <div style="height: 346px">
  
        <p>Enter a number: <asp:TextBox ID="Txt1" runat="server"></asp:TextBox></p>
        
        &nbsp;
        <p> Select Currency: <asp:DropDownList ID="DDLfrom" runat="server" >
              
        <asp:ListItem Value="CAD" Text="Canadian Dollar"></asp:ListItem>
        <asp:ListItem Value="CHF" Text="Swiss Franc"></asp:ListItem>
        <asp:ListItem Value="GBP" Text="Pound Sterling"></asp:ListItem>
        <asp:ListItem Value="USD" Text="US Dollar"></asp:ListItem>
        <asp:ListItem Value="JPY" Text="Japanese Yen"></asp:ListItem>
        </asp:DropDownList></p>
            
        <p>Select Currency: <asp:DropDownList ID="DDLto" runat="server">
     
        <asp:ListItem Value="CAD" Text="Canadian Dollar"></asp:ListItem>
        <asp:ListItem Value="CHF" Text="Swiss Franc"></asp:ListItem>
        <asp:ListItem Value="GBP" Text="Pound Sterling"></asp:ListItem>
        <asp:ListItem Value="USD" Text="US Dollar"></asp:ListItem>
        <asp:ListItem Value="JPY" Text="Japanese Yen"></asp:ListItem>
        </asp:DropDownList></p>

        
        <asp:Button ID="Button1" runat="server" Text="Convert Currency" 
                  onclick="Button1_Click" style="height: 26px" />
       
      
        <br />
       
    </div>

    </form>
</body>
</html>
