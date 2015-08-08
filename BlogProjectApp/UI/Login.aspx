<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BlogProjectApp.UI.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderMiddle" runat="server">
    
    <div class="container" style="margin-top:50px ">
    <div class="row" >
        <div class="col-xs-12">
            <h3 runat="server" id="errMesg"></h3>
            <form id="form1" runat="server" class="form-horizontal">

                <div class="form-group">
                    <label class="col-sm-2 control-label">User Name</label>
                    <div class="col-sm-5">
                        <asp:TextBox ID="loginUserNameTextBox" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-2 control-label">Password</label>
                    <div class="col-sm-5">
                        
                        <asp:TextBox  ID="loginPasswordTextBox" class="form-control" runat="server"></asp:TextBox>
                        
                    </div>
                    
                </div>
                <div class="form-group">
                    <div class="col-sm-7">
                        <%--<button type="submit" class="btn pull-right">Login</button>--%>
                        <asp:Button ID="loginButton" runat="server" Text="Login" class="btn pull-right" OnClick="loginButton_Click"/>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-2 control-label"> </label>
                    <div class="col-sm-5">
                        <asp:Label ID="msgLabel" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                
            </form>
        </div>
    </div>
    </div>

</asp:Content>
