<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="DetailRamen.aspx.cs" Inherits="RAAMEN_Project.Views.DetailRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card" style="width: 18rem;">
      <div class="card-body">
        <asp:Label runat="server" id="ramenName" class="card-title" Text="Label"></asp:Label>
        <asp:Label runat="server" id="ramenMeat" class="card-subtitle mb-2 text-body-secondary" Text="Label"></asp:Label>
        <asp:Label runat="server" id="ramenBroth" class="card-subtitle mb-2 text-body-secondary" Text="Label"></asp:Label>
        <asp:Label runat="server" id="ramenPrice" class="card-subtitle mb-2 text-body-secondary" Text="Label"></asp:Label>
         <asp:LinkButton ID="updateBtn" class="card-link" runat="server" Style="cursor: pointer" CommandArgument='<%#Eval("id") %>' onclick="updateBtn_Click" Visible="false">
             Update
         </asp:LinkButton>
          <asp:LinkButton ID="orderBtn" class="card-link" runat="server" Style="cursor: pointer" CommandArgument='<%#Eval("id") %>' onclick="orderBtn_Click" Visible="false">
             Order
         </asp:LinkButton>
          <asp:LinkButton ID="deleteBtn" class="card-link" runat="server" Style="cursor: pointer" CommandArgument='<%#Eval("id") %>' onclick="deleteBtn_Click" Visible="false">
             Delete
         </asp:LinkButton>
      </div>
    </div>
</asp:Content>
