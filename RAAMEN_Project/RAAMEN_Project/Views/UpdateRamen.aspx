<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="UpdateRamen.aspx.cs" Inherits="RAAMEN_Project.Views.UpdateRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="min-h-screen bg-gray-50 flex flex-col justify-center py-12 sm:px-6 lg:px-8" style="margin-top: 5%; min-height:75vh">
        <div class="sm:mx-auto sm:w-full sm:max-w-md">
            <h2 class="mt-6 text-center text-3xl font-extrabold text-gray-900">
                Insert Ramen
            </h2>
        </div>
        <div class="d-flex justify-content-center" style="margin-top: 2.5%;">
            <div class="card row d-flex" style="width: 30rem;">
                <div class="card-body">
                <p class="card-text">New Ramen Name</p>
                <div class="mb-3">
                    <asp:TextBox ID="ramenName_TextBox" runat="server" class="form-control"></asp:TextBox>
                    <asp:Label ID="name_Label" runat="server" Text="" Visible="true" ForeColor="Red"></asp:Label>
                </div>
                <p class="card-text">New Meat</p>
                <asp:DropDownList id="meat_selector" runat="server">
                    <asp:ListItem Text="Chicken Breast" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Pork" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Moo" Value="3"></asp:ListItem>
                </asp:DropDownList>
                <p class="card-text">new Broth</p>
                <div class="mb-3">
                    <asp:TextBox ID="ramenBroth_TextBox" runat="server" class="form-control"></asp:TextBox>
                    <asp:Label ID="broth_Label" runat="server" Text="" Visible="true" ForeColor="Red"></asp:Label>
                </div>
                <p class="card-text">New Price</p>
                <div class="mb-3">
                    <asp:TextBox ID="TextBox1" runat="server" class="form-control"></asp:TextBox>
                    <asp:Label ID="ramenPrice_TextBox" runat="server" Text="" Visible="true" ForeColor="Red"></asp:Label>
                </div>
                <div>
                    <asp:Button ID="updateRamen_Button" runat="server" Text="Update Ramen" class="btn btn-success" style="width: 100%;"
                        onClick="updateRamen_Button_Click"/>
                </div>
                
            </div>
        </div>
        </div>
       </div>
</asp:Content>
