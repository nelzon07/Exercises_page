<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Palindrome.aspx.cs" Inherits="DemoProject.Palindrome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
        <script>
        function msg1() {
            alert('You must enter text');
        }

        function msg2() {
            alert('¡The text is palindrome!');
        }

        function msg3() {
            alert('¡The text is not palindrome!');
        }

        function msg4() {
            alert('You must enter only text');
        }

    </script>
    
        <a class="btn btn-lg btn-success" href="Default.aspx" role="button">Back</a>
        <h2 class="form-signin-heading">Palindrome</h2>
    <br/>
    <asp:Label ID="Label1" runat="server" Text="Label">Type a word</asp:Label>
         <asp:TextBox  class="form-control" runat="server" ID="textBox1" ></asp:TextBox>   
    <br/>    
    <br/>    
    <asp:Button class="btn btn-lg btn-primary btn-block"  Text="Validate" runat="server" OnClick="Validate_Cick"  />
    

</asp:Content>
