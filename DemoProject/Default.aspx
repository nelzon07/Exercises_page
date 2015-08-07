<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DemoProject._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
            <h2 style="color:#ffffff;">Nelson Arroyo Guzman</h2>
        <h4>nelsonag22@hotmail.com</h4>
          </div>

    <div class="row">
                <div class="col-md-3">
            <h2>Exercise 1</h2>
            <p>
                <a class="btn btn-default" href="Anagram.aspx">Anagrams &raquo;</a>
            </p>
        </div>
        <div class="col-md-3">
            <h2>Exercise 2</h2>

            <p>
                <a class="btn btn-default" href="Table.aspx">12X12 &raquo;</a>
            </p>
        </div>
        <div class="col-md-3">
            <h2>Exercise 3</h2>
            <p>
                <a class="btn btn-default" href="Odd.aspx">Odd numbers &raquo;</a>
            </p>
        </div>
        <div class="col-md-3">
            <h2>Exercise 4</h2>
            <p>
                <a class="btn btn-default" href="Palindrome.aspx">Palindrome &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
