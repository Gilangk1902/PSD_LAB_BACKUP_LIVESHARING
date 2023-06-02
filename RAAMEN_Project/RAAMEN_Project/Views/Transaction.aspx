<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="Transaction.aspx.cs" Inherits="RAAMEN_Project.Views.Transaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:GridView ID="trGridView" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
