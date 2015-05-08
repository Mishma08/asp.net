<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddEvent.aspx.cs" Inherits="PlanMyEvents.AddEvent"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
            <tr>
                <td style="text-align: right">Event Type:</td>
                <td>
                    <asp:DropDownList ID="EventType" runat="server" OnSelectedIndexChanged="itemSelected" AutoPostBack="True">
                        <asp:ListItem>Birthday</asp:ListItem>
                        <asp:ListItem>Wedding</asp:ListItem>
                        <asp:ListItem>Bar Mizva</asp:ListItem>
                        <asp:ListItem>Other</asp:ListItem>
                    </asp:DropDownList>
                    <asp:TextBox ID="TextBoxEventType" runat="server" Visible="false" placeholder ="Event type"> </asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorUserName" CssClass="Req" runat="server" ControlToValidate="TextBoxEventType" ErrorMessage="Event Type Is Required!"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="text-align: right">Event Date:</td>
                <td>
                    <asp:TextBox ID="TextBoxBdate" runat="server" placeholder ="Date"> </asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" Cssclass="Req" ErrorMessage="Date Isn't Valid!" ControlToValidate="TextBoxBdate" ValidationExpression="^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$"></asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="Req" runat="server" ControlToValidate="TextBoxBdate" ErrorMessage="Event Date Is Required!"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>

    <div>
        <asp:Button ID="ButtonSubmit" runat="server"  Text="Submit" Width="129px" OnClick="ButtonSubmit_Click" />
    </div>
</asp:Content>
