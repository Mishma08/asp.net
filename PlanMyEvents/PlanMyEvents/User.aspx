<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="PlanMyEvents.User1"  MasterPageFile="~/site.master" EnableEventValidation="false" %>


<asp:Content ID="ContentUser" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <p>Hello <% Response.Write(Session["UserName"].ToString()); %></p>
    </div>
   
    <div>
     <asp:Repeater id="events" runat="server">
        <HeaderTemplate>
            <table class="table">
                <thead>
                    <tr>
                        <th></th>
                        <th></th>
                        <th>Type</th>
                        <th>Date</th>
                    </tr>
                </thead>
                <tbody>
        </HeaderTemplate>

        <ItemTemplate>
            <tr>
                <td><asp:Button runat="server"  Text="Edit" Width="129px" OnClick="ButtonEdit_Click" CommandArgument = '<%# Eval("Id") %>' /></td>
                <td><asp:Button runat="server"  Text="Delete" Width="129px" OnClick="ButtonDelete_Click" CommandArgument = '<%# Eval("Id") %>'/></td>
                <td><%# Eval("Type") %></td>
                <td><%# Eval("Date")%></td> 
            </tr>
        </ItemTemplate>

        <AlternatingItemTemplate>
            <tr bgcolor="#e8e8e8">
                <td><asp:Button runat="server"  Text="Edit" Width="129px" OnClick="ButtonEdit_Click" CommandArgument = '<%# Eval("Id") %>'/></td>
                <td><asp:Button runat="server"  Text="Delete" Width="129px" OnClick="ButtonDelete_Click" CommandArgument = '<%# Eval("Id") %>'/></td>
                <td><%# Eval("Type") %></td>
                <td><%# Eval("Date")%></td> 
            </tr>
        </AlternatingItemTemplate>

        <FooterTemplate>
             </tbody>
            </table>
        </FooterTemplate>

        </asp:Repeater>
    </div>

    <div>
        <asp:Button runat="server"  Text="Add event" Width="129px" OnClick="ButtonAdd_Click" />
    </div>
 </asp:Content>
 