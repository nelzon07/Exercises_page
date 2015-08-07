<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Odd.aspx.cs" Inherits="DemoProject.Odd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
        <script>
            function msg1() {
            alert('Please, enter a valid number. ( From 0 to 999');
            }
         </script>

      <a class="btn btn-lg btn-success" href="Default.aspx" role="button">Back</a>

            <h2 class="form-signin-heading">Odd Numbers</h2>

    <br/>    <br/>
    <asp:Label ID="Label1" runat="server" Text="Label">Odd numbers from 1 to: </asp:Label>
             <asp:TextBox  class="form-control" runat="server" ID="textBox1" Text="99" ></asp:TextBox>  
        <br/>    <br/>
    <asp:ListBox runat="server" ID="listBox1" class="list-group" Width="500px" Height="300px"/>
        <br/>    <br/>
    <asp:Button class="btn btn-lg btn-primary btn-block"  Text="Validate" runat="server" OnClick="Validate_Cick"  />
    

</asp:Content>
