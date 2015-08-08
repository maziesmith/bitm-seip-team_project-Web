<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Master.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="BlogProjectApp.UI.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderMiddle" runat="server">
    <div class="row">
        <div class="col-xs-12">
            <h2 runat="server" id="msg"></h2>
            <form id="form1" runat="server" class="form-horizontal">

                <div class="form-group">
                    <label class="col-sm-2 control-label">Full Name</label>
                    <div class="col-sm-5">
                        <asp:TextBox ID="fullNameTextBox" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-2 control-label">Email</label>
                    <div class="col-sm-5">
                        <asp:TextBox ID="emailTextBox" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-2 control-label">User Name</label>
                    <div class="col-sm-5">
                        <asp:TextBox ID="userNameTextBox" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="col-sm-2 control-label">Password</label>
                    <div class="col-sm-5">
                        <asp:TextBox ID="passwordTextBox" class="form-control" runat="server"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-7">
                        <%--<button type="submit" class="btn pull-right">Registration</button>--%>
                        <asp:Button ID="registrationButton" runat="server" Text="Registration" class="btn pull-right" OnClick="registrationButton_Click"/>
                    </div>
                </div>

            </form>
        </div>
    </div>

</asp:Content>
