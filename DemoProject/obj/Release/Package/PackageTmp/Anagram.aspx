<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Anagram.aspx.cs" Inherits="DemoProject.Anagram" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script>
        function msg1() {
            alert('You must enter text in the first or second field');
        }

        function msg2() {
            alert('¡Is an anagram!');
        }

        function msg3() {
            alert('¡Is not an anagram!');
        }

        function msg4() {
            alert('You must enter only text.');
        }

    </script>
    
        <a class="btn btn-lg btn-success" href="Default.aspx" role="button">Back</a>
        <h2 class="form-signin-heading">Anagram</h2>
    <asp:Label ID="Label1" runat="server" Text="Label">Type a word</asp:Label>
         <asp:TextBox  class="form-control" runat="server" ID="TextBox1" ></asp:TextBox>   
    <br/>    
    <asp:Label ID="Label2" runat="server" Text="Label">Type other word</asp:Label>
        <asp:TextBox   class="form-control" runat="server" ID="TextBox2" ></asp:TextBox>      
    <br/>    
    <asp:Button class="btn btn-lg btn-primary btn-block"  Text="Validate" runat="server" OnClick="Validate_Cick"  />
    

</asp:Content>
