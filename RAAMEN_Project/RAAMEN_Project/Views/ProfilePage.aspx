<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="RAAMEN_Project.Views.ProfilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card" style="width: 18rem;">
      <div class="card-body">
        <asp:Label runat="server" id="username_Label" class="card-title" Text="Label"></asp:Label>
        <asp:Label runat="server" id="email_Label" class="card-subtitle mb-2 text-body-secondary" Text="Label"></asp:Label>
        <asp:Label runat="server" id="gender_Label" class="card-subtitle mb-2 text-body-secondary" Text="Label"></asp:Label>
         <asp:LinkButton ID="updateBtn" class="card-link" runat="server" Style="cursor: pointer" CommandArgument='<%#Eval("id") %>' onclick="UpdateBtn_Click">
             Update
         </asp:LinkButton>
      </div>
    </div>
</asp:Content>
