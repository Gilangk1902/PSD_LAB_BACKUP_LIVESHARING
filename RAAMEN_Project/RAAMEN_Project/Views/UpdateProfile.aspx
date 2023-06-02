<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="RAAMEN_Project.Views.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="min-h-screen bg-gray-50 flex flex-col justify-center py-12 sm:px-6 lg:px-8" style="margin-top: 5%; min-height:75vh">
        <div class="sm:mx-auto sm:w-full sm:max-w-md">
            <h2 class="mt-6 text-center text-3xl font-extrabold text-gray-900">
                Update Profile
            </h2>
        </div>
        <div class="d-flex justify-content-center" style="margin-top: 2.5%;">
            <div class="card row d-flex" style="width: 30rem;">
                <div class="card-body">
                <p class="card-text">Change Username</p>
                <div class="mb-3">
                    <asp:TextBox ID="username_TextBox" runat="server" class="form-control"></asp:TextBox>
                    <asp:Label ID="username_Label" runat="server" Text="" Visible="true" ForeColor="Red"></asp:Label>
                </div>
                <p class="card-text">Change Email</p>
                <div class="mb-3">
                    <asp:TextBox ID="email_TextBox" runat="server" class="form-control"></asp:TextBox>
                    <asp:Label ID="email_Label" runat="server" Text="" Visible="true" ForeColor="Red"></asp:Label>
                </div>
                <p class="card-text">Gender</p>
                <div class="mb-3">
                    <asp:DropDownList ID="gender_DropDownList" runat="server"></asp:DropDownList>
                </div>
                <p class="card-text">Change Password</p>
                <div class="mb-3">
                    <asp:TextBox ID="password_TextBox" runat="server" class="form-control"></asp:TextBox>
                    <asp:Label ID="password_Label" runat="server" Text="" Visible="true" ForeColor="Red"></asp:Label>
                </div>
                <div>
                    <asp:Button ID="updateProfile_Button" runat="server" Text="Update Ramen" class="btn btn-success" style="width: 100%;"
                        OnClick="UpdateProfile_Button_Click"/>
                </div>
                
            </div>
        </div>
        </div>
       </div>
</asp:Content>
