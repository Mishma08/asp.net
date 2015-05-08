<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="PlanMyEvents.HomePage" MasterPageFile="~/site.master"%>

<asp:Content ID="ContentHomePage" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div id="LoginAndRegister">
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx" class="btn btn-default navbar-btn">Login    </asp:HyperLink>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/Register.aspx" class="btn btn-default navbar-btn">    Register</asp:HyperLink>
    </div>
    <br /><br /><br />
    <div id="carousel-example-generic" class="carousel slide" data-ride="carousel">
      <!-- Indicators -->
      <ol class="carousel-indicators">
        <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
        <li data-target="#carousel-example-generic" data-slide-to="1"></li>
        <li data-target="#carousel-example-generic" data-slide-to="2"></li>

      </ol>

      <!-- Wrapper for slides -->
      <div class="carousel-inner" role="listbox">
        <div class="item active">
          <img src="Imgs/homeW.jpg" alt="Wedding"/>
          <div class="carousel-caption">
          </div>
        </div>
        <div class="item">
          <img src="Imgs/homeBM.jpg" alt="Bar Mizva"/>
          <div class="carousel-caption">
          </div>
        </div>
        <div class="item">
          <img src="Imgs/homeO.png" alt="Celebration"/>
          <div class="carousel-caption">
          </div>
        </div>
      </div>

      <!-- Controls -->
      <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
        <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
        <span class="sr-only">Previous</span>
      </a>
      <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
        <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
        <span class="sr-only">Next</span>
      </a>
    </div>
 
</asp:Content>