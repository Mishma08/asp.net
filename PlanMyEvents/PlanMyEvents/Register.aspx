<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PlanMyEvents.Register"  MasterPageFile="~/site.master" %>

<asp:Content ID="ContentRegister" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    
        <div class="auto-style3">
            <span class="auto-style2"><strong>Registration</strong></span><br />
        </div>
        <table class="auto-style1">
            <tr>
                <td style="text-align: right">User Name:</td>
                <td>
                    <asp:TextBox ID="TextBoxUserName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorUserName" CssClass="Req" runat="server" ControlToValidate="TextBoxUserName" ErrorMessage="User Name Is Required!"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right">Password:</td>
                <td>
                    <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" Cssclass="Req" runat="server" ControlToValidate="TextBoxPassword" ErrorMessage="Password Is Required!"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right">Confirm Password:</td>
                <td>
                    <asp:TextBox ID="TextBoxConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidatorPass" runat="server" ErrorMessage="Password don't Match!" Cssclass="Req" ControlToCompare="TextBoxPassword" ControlToValidate="TextBoxConfirmPassword"></asp:CompareValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right">E-Mail:</td>
                <td>
                    <asp:TextBox ID="TextBoxMail" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ControlToValidate="TextBoxMail" ErrorMessage="E-mail Is Wrong!" Cssclass="Req"  ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right">First Name:</td>
                <td>
                    <asp:TextBox ID="TextBoxFname" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorFname" Cssclass="Req" runat="server" ErrorMessage="First Name Is Required!" ControlToValidate="TextBoxFname"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right">Last Name:</td>
                <td>
                    <asp:TextBox ID="TextBoxLname" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorLname" runat="server" Cssclass="Req" ErrorMessage="Last Name Is Required!" ControlToValidate="TextBoxLname"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right">Birth Date:</td>
                <td>
                    <asp:TextBox ID="TextBoxBdate" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Cssclass="Req" ErrorMessage="Date Isn't Valid!" ControlToValidate="TextBoxBdate" ValidationExpression="^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$"></asp:RegularExpressionValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    <asp:Button ID="ButtonRegister" runat="server"  Text="Register" Width="129px" OnClick="ButtonRegister_Click1" />
   </asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-decoration: underline;
            font-size: large;
        }
        
    </style>
</asp:Content>
