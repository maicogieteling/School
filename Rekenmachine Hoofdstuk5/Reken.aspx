<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reken.aspx.cs" Inherits="Rekenmachine_Hoofdstuk5.Reken" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
       
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
        <th><asp:Label ID="lblGetal1" runat="server" Text="Getal 1"></asp:Label>&nbsp;&nbsp;&nbsp;</th>
        <th><asp:TextBox ID="txtGetal1" runat="server" OnTextChanged="txtGetal1_TextChanged"></asp:TextBox></th>
        <th>*<asp:RequiredFieldValidator ID="rfvGetal1" runat="server" ControlToValidate="txtGetal1" Display="Dynamic" ErrorMessage="Vul getal 1 in!"></asp:RequiredFieldValidator></th>
        <th><asp:RangeValidator ID="rvGetal1" runat="server" ControlToValidate="txtGetal1" Display="Dynamic" ErrorMessage="Tussen de 1 en 100" MaximumValue="100" MinimumValue="1" Type="Double"></asp:RangeValidator></th>
            
        <th><asp:Button ID="btnOptel" runat="server" Text="Optellen" OnClick="btnOptel_Click" /></th>
                </tr>
        <br />
            <tr>
        <th><asp:Label ID="lblGetal2" runat="server" Text="Getal 2"></asp:Label>&nbsp;&nbsp;&nbsp;</th>
        <th><asp:TextBox ID="txtGetal2" runat="server"></asp:TextBox></th>
        <th>*<asp:RequiredFieldValidator ID="rvfGetal2" runat="server" ControlToValidate="txtGetal2" Display="Dynamic" ErrorMessage="Vul getal 2 in!"></asp:RequiredFieldValidator></th>
        <th> <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtGetal2" Display="Dynamic" ErrorMessage="Tussen de 1 en 100" MaximumValue="100" MinimumValue="1" Type="Double"></asp:RangeValidator></th>
        <th>&nbsp;&nbsp;<asp:Button ID="btnAftrek" runat="server" Text="Aftrekken" OnClick="btnAftrek_Click" /></th>
            </tr>
        <br />
            <tr>
        <th><asp:Label ID="lblUitkomst" runat="server" Text="Uitkomst"></asp:Label></th>
            
        <th><asp:TextBox ID="txtUitkomst" runat="server" ReadOnly="True"></asp:TextBox></th>
           </tr>
        </table>
        <p>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtGetal1" ControlToValidate="txtGetal2" ErrorMessage="Vul dezelfde getallen in!" Display="Dynamic"></asp:CompareValidator>
        </p>
        <p>
            <table>
                <tr>
            <th><asp:Label ID="Label1" runat="server" Text="Telefoonnummer"></asp:Label>&nbsp;</th>
            <th><asp:TextBox ID="txtTelefoon" runat="server"></asp:TextBox></th>
            <th><asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtTelefoon" ErrorMessage="Het telefoon nummer moet de volgende format hebben: bijv. 073 6249909 " ValidationExpression="((\d{3}) (\d{7}))"></asp:RegularExpressionValidator></th>
                </tr>
             </table>
           </p>
    </form>
</body>
</html>
