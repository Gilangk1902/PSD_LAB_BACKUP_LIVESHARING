<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="RamenCart.aspx.cs" Inherits="RAAMEN_Project.Views.RamenCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding:2% 10%">
        <table class="table">
            <thead>
                <tr>
                    <th scope="col">Ramen ID</th>
                    <th scope="col">Ramen Meat</th>
                    <th scope="col">Ramen Name</th>
                    <th scope="col">Ramen Broth</th>
                    <th scope="col">Ramen Price</th>
                    <th scope="col">Ramen Quantity</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ID="TableRepeater" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td scope="row"><%# Eval("Ramen.id") %></td>
                            <td scope="row"><%# Eval("Ramen.Meat.name") %></td>
                            <td scope="row"><%# Eval("Ramen.Name") %></td>
                            <td scope="row"><%# Eval("Ramen.Broth") %></td>
                            <td scope="row"><%# Eval("Ramen.Price") %></td>
                            <td scope="row"><%# Eval("Quantity") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
</asp:Content>
