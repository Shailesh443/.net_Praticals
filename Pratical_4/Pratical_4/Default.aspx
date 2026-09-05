 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Pratical_4.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Online Event Registration</title>
    <style>
        table {
            margin: auto;
            font-family: Arial;
        }
        td {
            padding: 8px;
        }
        h2 {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <h2>ONLINE EVENT REGISTRATION</h2>

        <table>

            <tr>
                <td>Full Name</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator
                        ID="RequiredFieldValidator1"
                        runat="server"
                        ControlToValidate="TextBox1"
                        ErrorMessage="Enter Name"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>
                </td>
            </tr>

            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator
                        ID="RequiredFieldValidator2"
                        runat="server"
                        ControlToValidate="TextBox2"
                        ErrorMessage="Enter Email"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>

                    <br />

                    <asp:RegularExpressionValidator
                        ID="RegularExpressionValidator1"
                        runat="server"
                        ControlToValidate="TextBox2"
                        ValidationExpression="\w+([-.+']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                        ErrorMessage="Invalid Email"
                        ForeColor="Red">
                    </asp:RegularExpressionValidator>

                </td>
            </tr>

            <tr>
                <td>Mobile</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td>

                    <asp:RequiredFieldValidator
                        ID="RequiredFieldValidator3"
                        runat="server"
                        ControlToValidate="TextBox3"
                        ErrorMessage="Enter Mobile"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>

                    <br />

                    <asp:RegularExpressionValidator
                        ID="RegularExpressionValidator2"
                        runat="server"
                        ControlToValidate="TextBox3"
                        ValidationExpression="[0-9]{10}"
                        ErrorMessage="Enter 10 Digit Mobile Number"
                        ForeColor="Red">
                    </asp:RegularExpressionValidator>

                </td>
            </tr>

            <tr>
                <td>College</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
                <td>

                    <asp:RequiredFieldValidator
                        ID="RequiredFieldValidator4"
                        runat="server"
                        ControlToValidate="TextBox4"
                        ErrorMessage="Enter College"
                        ForeColor="Red">
                    </asp:RequiredFieldValidator>

                </td>
            </tr>

            <tr>
                <td>Department</td>
                <td>

                    <asp:RadioButton ID="RadioButton1" runat="server" Text="Computer" GroupName="Dept" /><br />

                    <asp:RadioButton ID="RadioButton2" runat="server" Text="IT" GroupName="Dept" /><br />

                    <asp:RadioButton ID="RadioButton3" runat="server" Text="Mechanical" GroupName="Dept" /><br />

                    <asp:RadioButton ID="RadioButton4" runat="server" Text="Civil" GroupName="Dept" />

                </td>
            </tr>

            <tr>
                <td>Event</td>
                <td>

                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Select Event</asp:ListItem>
                        <asp:ListItem>Club Event</asp:ListItem>
                        <asp:ListItem>MU Event</asp:ListItem>
                        <asp:ListItem>Hackathon</asp:ListItem>
                    </asp:DropDownList>

                </td>
            </tr>

            <tr>
                <td>Gender</td>
                <td>

                    <asp:RadioButton ID="RadioButton5" runat="server" Text="Male" GroupName="Gender" />

                    <asp:RadioButton ID="RadioButton6" runat="server" Text="Female" GroupName="Gender" />

                </td>
            </tr>

            <tr>
                <td>Skills</td>
                <td>

                    <asp:CheckBox ID="CheckBox1" runat="server" Text="Java" /><br />

                    <asp:CheckBox ID="CheckBox2" runat="server" Text="Python" /><br />

                    <asp:CheckBox ID="CheckBox3" runat="server" Text="C++" /><br />

                    <asp:CheckBox ID="CheckBox4" runat="server" Text="AI" />

                </td>
            </tr>

            <tr>
                <td>Address</td>
                <td>

                    <asp:TextBox ID="TextBox5"
                        runat="server"
                        TextMode="MultiLine"
                        Rows="4"
                        Columns="25">
                    </asp:TextBox>

                </td>
            </tr>

            <tr>
                <td>Terms</td>
                <td>

                    <asp:CheckBox ID="CheckBox5"
                        runat="server"
                        Text="I Accept Terms & Conditions" />

                </td>
            </tr>

            <tr>
                <td></td>
                <td>

                    <asp:Button
                        ID="Button1"
                        runat="server"
                        Text="Register"
                        OnClick="Button1_Click" />

                    &nbsp;

                    <asp:Button
                        ID="Button2"
                        runat="server"
                        Text="Reset"
                        OnClick="Button2_Click" />

                </td>
            </tr>

            <tr>
                <td></td>
                <td>

                    <asp:Label
                        ID="Label11"
                        runat="server"
                        ForeColor="Green">
                    </asp:Label>

                </td>
            </tr>

        </table>

    </form>
</body>
</html>