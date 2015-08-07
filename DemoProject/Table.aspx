<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Table.aspx.cs" Inherits="DemoProject.Table" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <a class="btn btn-lg btn-success" href="Default.aspx" role="button">Back</a>

            <h2 class="form-signin-heading">Table 12X12</h2>
  
 <asp:DropDownList runat="server" ID="comboBox1" class="btn btn-default dropdown-toggle"  OnTextChanged="Validate_Cick"  AutoPostBack = "true">

 </asp:DropDownList>
    <br/>    <br/>    <br/>
    
    <asp:ListBox runat="server" ID="listBox1" class="list-group" Width="500px" Height="300px"/>
        <br/>    <br/>
   
    

</asp:Content>
