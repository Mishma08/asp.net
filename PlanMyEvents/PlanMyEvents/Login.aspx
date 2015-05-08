<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PlanMyEvents.Login" MasterPageFile="~/site.master" %>

<asp:Content ID="ContentLogin" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    

        <table class="auto-style1">
            <tr>
                <td class="auto-style4" >  UserName:</td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBoxUserName" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorUserName" runat="server" ControlToValidate="TextBoxUserName" Cssclass="Req" ErrorMessage="UserName is required"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr >
                <td class="auto-style5" >Password:</td>
                <td>
                    <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorUserName0" runat="server" ControlToValidate="TextBoxPassword" Cssclass="Req" ErrorMessage="Password is required"></asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
    

    </div>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login"   />
                </asp:Content> 
<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
            text-align: right;
        }
        .auto-style5 {
            text-align: right;
        }
    </style>
</asp:Content>
 