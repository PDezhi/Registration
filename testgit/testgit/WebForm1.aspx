<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="testgit.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Panel ID="enterUserInfoPanel" runat="server">
                <table cellpadding="3" border="0">
                    <tr>
                        <td>First name:</td>
                        <td>
                            <asp:TextBox ID="firstNameTextBox" runat="server" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ForeColor="Red" ControlToValidate="firstNameTextBox" runat="server" ErrorMessage="Please enter first name"></asp:RequiredFieldValidator>
                    </tr>
                    <tr>
                        <td>Last name:</td>
                        <td>
                            <asp:TextBox ID="lastNameTextBox" runat="server" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ForeColor="Red" ControlToValidate="lastNameTextBox" runat="server" ErrorMessage="Please enter last name"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Address:</td>
                        <td>
                            <asp:TextBox ID="addressTextBox" runat="server" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ForeColor="Red" ControlToValidate="addressTextBox" runat="server" ErrorMessage="Please enter last name"></asp:RequiredFieldValidator>

                        </td>
                    </tr>
                    <tr>
                        <td>City:</td>
                        <td>
                            <asp:TextBox ID="cityTextBox" runat="server" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ForeColor="Red" ControlToValidate="cityTextBox" runat="server" ErrorMessage="Please enter last name"></asp:RequiredFieldValidator>

                        </td>
                    </tr>
                    <tr>
                        <td>State or Province:</td>
                        <td>
                            <asp:TextBox ID="stateOrProvinceTextBox" MaxLength="2" runat="server" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ForeColor="Red" ControlToValidate="stateOrProvinceTextBox" runat="server" ErrorMessage="Please enter last name"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="stateOrProvinceTextBox" runat="server" ValidationExpression="[1-z]{2}" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>Zip Code/Postal Code:</td>
                        <td>
                            <asp:TextBox ID="zipCodeTextBox" runat="server" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ForeColor="Red" ControlToValidate="zipCodeTextBox" runat="server" ErrorMessage="Please enter last name"></asp:RequiredFieldValidator>

                        </td>
                    </tr>
                    <tr>
                        <td>Country:</td>
                        <td>
                            <asp:TextBox ID="countryTextBox" runat="server" /></td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Button ID="enterInfoButton" runat="server" Text="Enter user information" OnClick="EnterInfoButton_OnClick" /></td>
                    </tr>
                </table>
            </asp:Panel>
            <asp:Panel ID="userInfoPanel" runat="server">
                <table cellpadding="3" border="0">
                    <tr>
                        <td>Name:</td>
                        <td>
                            <asp:Label ID="firstNameLabel" runat="server" />
                            <asp:Label ID="lastNameLabel" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">address:</td>
                        <td>
                            <asp:Label ID="addressLabel" runat="server" /><br />
                            <asp:Label ID="cityLabel" runat="server" />,
            <asp:Label ID="stateOrProvinceLabel" runat="server" />
                            <asp:Label ID="zipCodeLabel" runat="server" /><br />
                            <asp:Label ID="countryLabel" runat="server" />
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
                            <asp:Button ID="changeInfoButton" runat="server" Text="Change user information" OnClick="ChangeInfoButton_OnClick" /></td>
                    </tr>
                </table>
            </asp:Panel>

        </div>
    </form>
</body>
</html>
