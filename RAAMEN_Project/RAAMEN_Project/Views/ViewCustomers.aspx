<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="ViewCustomers.aspx.cs" Inherits="RAAMEN_Project.Views.ViewCustomers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="all-gigs-section" style="margin: 0 3%" >
        <h2 class="mb-4" style="font-size: 36px;">All Customers</h2>
        <div class="" style="display: grid; grid-template-columns: repeat(5, minmax(0, 1fr)); gap: 1rem;"
                id="post-data">
            <asp:Repeater ID="CardRepeater" runat="server">
                <ItemTemplate>
                    <div class="card text-center">
                        <div class="card-body">
                            <p>Username: <%# Eval("Username") %></p>
                            <p>Email: <%# Eval("Email") %></p>
                            <p>Gender: <%# Eval("Gender") %></p>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
