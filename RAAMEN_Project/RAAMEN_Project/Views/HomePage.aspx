<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="RAAMEN_Project.Views.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="min-h-screen bg-gray-50 flex flex-col justify-center py-12 sm:px-6 lg:px-8" style="margin-top: 5%;">
        <div class="sm:mx-auto sm:w-full sm:max-w-md">
            <h2 class="mt-6 text-center text-3xl font-extrabold text-gray-900">
                View Customers
            </h2>
        </div>
        <div class="container d-flex justify-content-center" style="margin-top: 2.5%;">
<%--            <div class="row">
                <div class="col-sm">
                    <p>Username</p>
                </div>
                <div class="col-sm">
                    <p>Email</p>
                </div>
                <div class="col-sm">
                    <p>Gender</p>
                </div>
            </div> --%>
            <asp:Repeater ID="CardRepeater" runat="server">
                <HeaderTemplate>
                    <table class="table table-bordered">
                        <tr>
                            <th scope="col">Username</th>
                            <th scope="col">Email</th>
                            <th scope="col">Gender</th>
                        </tr
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Username") %></td>
                        <td><%# Eval("Email") %></td>
                        <td><%# Eval("Gender") %></td>
                    </tr>
                    <%--<div class="row">
                        <div class="col-sm">
                            <p><%# Eval("Username") %></p>
                        </div>
                        <div class="col-sm">
                            <p><%# Eval("Email") %></p>
                        </div>
                        <div class="col-sm">
                            <p><%# Eval("Gender") %></p>
                        </div>
                    </div> --%>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </div>

    <div class="min-h-screen bg-gray-50 flex flex-col justify-center py-12 sm:px-6 lg:px-8" style="margin-top: 5%;">
        <div class="sm:mx-auto sm:w-full sm:max-w-md">
            <h2 class="mt-6 text-center text-3xl font-extrabold text-gray-900">
                View Staffs
            </h2>
        </div>
        <div class="container d-flex justify-content-center" style="margin-top: 2.5%;">
            <asp:Repeater ID="Repeater1" runat="server">
                <HeaderTemplate>
                    <table class="table table-bordered">
                        <tr>
                            <th scope="col">Username</th>
                            <th scope="col">Email</th>
                            <th scope="col">Gender</th>
                        </tr
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("Username") %></td>
                        <td><%# Eval("Email") %></td>
                        <td><%# Eval("Gender") %></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
