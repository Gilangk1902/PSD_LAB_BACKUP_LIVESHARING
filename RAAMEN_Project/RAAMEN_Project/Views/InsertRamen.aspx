<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="InsertRamen.aspx.cs" Inherits="RAAMEN_Project.Views.InsertRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="min-h-screen bg-gray-50 flex flex-col justify-center py-12 sm:px-6 lg:px-8" style="margin-top: 5%; min-height:75vh">
        <div class="sm:mx-auto sm:w-full sm:max-w-md">
            <h2 class="mt-6 text-center text-3xl font-extrabold text-gray-900">
                insert Ramen
            </h2>
        </div>
        <div class="d-flex justify-content-center" style="margin-top: 2.5%;">
            <div class="card row d-flex" style="width: 30rem;">
                <div class="card-body">
                <p class="card-text">Ramen Name</p>
                <div class="mb-3">
                    <asp:TextBox ID="ramenName_TextBox" runat="server" class="form-control"></asp:TextBox>
                    <asp:Label ID="name_Label" runat="server" Text="" Visible="true" ForeColor="Red"></asp:Label>
                </div>
                <p class="card-text">Meat</p>
                <asp:DropDownList id="meat_selector" runat="server">
                    
                </asp:DropDownList>
                <p class="card-text">Broth</p>
                <div class="mb-3">
                    <asp:TextBox ID="ramenBroth_TextBox" runat="server" class="form-control"></asp:TextBox>
                    <asp:Label ID="broth_Label" runat="server" Text="" Visible="true" ForeColor="Red"></asp:Label>
                </div>
                <div class="mb-3">
                    <asp:TextBox ID="price_TextBox" runat="server" class="form-control"></asp:TextBox>
                    <asp:Label ID="price_Label" runat="server" Text="" Visible="true" ForeColor="Red"></asp:Label>
                </div>
                <div>
                    <asp:Label ID="error_Label" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                </div>
                <div>
                    <asp:Button ID="insertRamen_Button" runat="server" Text="Insert Ramen" class="btn btn-success" style="width: 100%;"
                        onClick="InsertRamen_Button_Click"/>
                </div>
                
            </div>
        </div>
        </div>
</asp:Content>