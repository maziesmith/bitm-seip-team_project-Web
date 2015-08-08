<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Master.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="BlogProjectApp.UI.Index" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMiddle" runat="server">

    <h1>Read All Articles</h1>
    <asp:Repeater ID="AllPost" runat="server">
        <ItemTemplate>
            <div class="row">
                <h2><%# Eval("Title")%></h2>
                
                <div class="col-md-3">
                    <img src="<%# Eval("Image") %>" style="width: 180px; height: 150px;" />
                </div>
                <div class="col-md-9 ">
                    <%# Eval("Description") %>
                    <a class="btn btn-success pull-right" href="DetailBlog.aspx?articleId=<%# Eval("Id") %>">Read More</a>
                </div>
            </div>
        </ItemTemplate>

    </asp:Repeater>






</asp:Content>

