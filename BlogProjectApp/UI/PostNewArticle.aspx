<%@ Page Title="" Language="C#" MasterPageFile="~/UI/Master.Master" AutoEventWireup="true" CodeBehind="PostNewArticle.aspx.cs" Inherits="BlogProjectApp.UI.PostNewArticle"  ValidateRequest="false" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderMiddle" runat="server">
    <h1 id="msg" runat="server"></h1>
    <form class="form-horizontal" runat="server" id="articleForm">
    <div class="form-group">
        
        
            <label for="articletitleTextbox" class="">Article Title</label>
            <asp:TextBox ID="articletitleTextbox"  runat="server" class="form-control"></asp:TextBox>
            
       
    </div>
    
    <div class="form-group">
        <label for="writeArticle">Write Article</label>
        <textarea  id="edit" name="edit"></textarea>
        
    </div>
    <div class="form-group">
        <label for="statusDropDown" >Status</label>
        
            <select id="status" name="status" class="form-control">
                <option value="1">Publish</option>
                <option value="2">UnPublish</option>
            </select>
        
    </div>
    <div class="form-group">
        <div class="col-sm-10 col-sm-offset-2">
            <asp:Button ID="postArticle" runat="server" Text="Post Article" class="btn btn-primary" OnClick="postArticle_Click" />
            
        </div>
    </div>
        
    
</form>
    
    

</asp:Content>
