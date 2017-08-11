<%@ Page Title="" Async="true" AsyncTimeout="10" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Google_Translation_API.aspx.cs" Inherits="Dev_Forms.Google_Translation_API" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <section class="panel panel-default">
        <header class="panel-heading">
            <h3 class="panel-title">Description</h3>
        </header>
        <div class="panel-body">
            <p>This page demonstrates the ability to translate both from English to French as well as French to English when focus is lost on a question box.
                Current code is rudimentary however displays the possibility of using google script API's in future applications to reduce user input time when doing internationalization.
                The current code does not allow editing as a change in the test will launch a translation in it's partner box.  This will need to be a future enhancement.
            </p>
        </div>
    </section>
        <asp:UpdatePanel ID="BamBam" runat="server">
        <ContentTemplate>
            <div class="form-group col-md-12" role="form">
                <div class="well col-md-6">
                       <label for="EngText1" class="control-label">Question</label>
                   
                        <asp:TextBox ID="EngText1" CssClass="form-control " Rows="3" Width="100%" TextMode="MultiLine" runat="server" AutoPostBack="true" OnTextChanged="GetTrans_Click" />
                    
                </div>
                <div class="well col-md-6">
                    <label for="FrenchText1" class="control-label">Quéstion</label>
                    <asp:TextBox ID="FrenchText1" CssClass="form-control" Rows="3" Width="100%" TextMode="MultiLine" runat="server" AutoPostBack="true" OnTextChanged="GetTrans_Click" />

                </div>
               
            </div>
      
 
        
            <div class="form-group col-md-12" role="form">
                <div class="well col-md-6">
                       <label for="EngText2" class="control-label">Question</label>
                   
                        <asp:TextBox ID="EngText2" CssClass="form-control " Rows="3" Width="100%" TextMode="MultiLine" runat="server" AutoPostBack="true" OnTextChanged="GetTrans_Click" />
                    
                </div>
                <div class="well col-md-6">
                    <label for="FrenchText2" class="control-label">Quéstion</label>
                    <asp:TextBox ID="FrenchText2" CssClass="form-control" Rows="3" Width="100%" TextMode="MultiLine" runat="server" AutoPostBack="true" OnTextChanged="GetTrans_Click" />

                </div>
               
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    <asp:UpdateProgress ID="UpdateBamBam" runat="server" AssociatedUpdatePanelID="BamBam">
        <ProgressTemplate>
            <div style="position: relative; bottom: 225px; z-index: 1000;">
                <asp:Image ID="loadingimage2" runat="server" ImageUrl="~/Assets/loading.gif" CssClass="center-block" AlternateText="Loading..." />
            </div>
        </ProgressTemplate>
    </asp:UpdateProgress>
 <asp:Button ID="GetTrans" CssClass="btn" Visible="false" OnClick="GetTrans_Click" runat="server" Text="Translate" />
</asp:Content>

