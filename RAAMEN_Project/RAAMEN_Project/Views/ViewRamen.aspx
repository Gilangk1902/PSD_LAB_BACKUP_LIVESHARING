<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="ViewRamen.aspx.cs" Inherits="RAAMEN_Project.Views.ViewRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="all-gigs-section" style="margin: 0 3%" >
            <h2 class="mb-4" style="font-size: 36px;">All Products</h2>
            <div class="" style="display: grid; grid-template-columns: repeat(5, minmax(0, 1fr)); gap: 1rem;"
                id="post-data">
                <asp:Repeater ID="CardRepeater" runat="server">
                    <ItemTemplate>
                        <div class="card m-2 card-cloth">
                            <asp:LinkButton ID="OpenDetail" runat="server" Style="cursor: pointer" CommandArgument='<%#Eval("id") %>' onclick="OpenDetail_Click1">
                                <div>
                                    <p>
                                        <%--<asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("ItemPicture") %>' class="card-img-top title-hover" Height="350px" />--%>
                                    </p>
                                    <div class="card-body"> 
                                        <p class="card-text title-hover"><%# Eval("Name") %></p>
                                    </div>
                                    <div class="list-group list-group-flush">
                                        <p class="list-group-item text-right" style="font-size: 18px;"><b>$<%# Eval("Price") %></b></p>
                                    </div>
                                </div>
                            </asp:LinkButton>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>

            </div>
        </div>
</asp:Content>
