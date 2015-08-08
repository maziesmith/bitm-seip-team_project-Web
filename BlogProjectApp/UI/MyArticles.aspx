<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Master.Master" AutoEventWireup="true" CodeBehind="MyArticles.aspx.cs" Inherits="BlogProjectApp.UI.MyArticles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderMiddle" runat="server">
    
    <h1> All of My Articlse</h1>
    
    <asp:Repeater ID="AllPost" runat="server">
        <ItemTemplate>
            <div class="row" style="background-color: rgb(247, 247, 247);
  border: solid 1px green;
  padding: 0px 0 10px 16px;
  box-shadow: 0px 0px 5px green; margin-bottom: 10px;">
                <h2><%# Eval("Title")%></h2>
                
                <div class="col-md-1">
                    <img src="<%# Eval("Image") %>" style="width: 50px; height: 50px;" />
                </div>
                <div class="col-md-11 ">
                    <%# Eval("Description") %>
                    <br/>
                    
                    <a class="btn btn-success pull-right" href="Details.aspx?id=<%# Eval("Id") %>">Read More</a>
                </div>
            </div>
        </ItemTemplate>

    </asp:Repeater>

</asp:Content>
