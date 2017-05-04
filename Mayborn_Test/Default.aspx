<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Mayborn_Test.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtFirst" runat="server" Text="Enter First Name"></asp:TextBox>
            <asp:TextBox ID="txtLast" runat="server" Text="Enter Last Name"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
        <div>
            <asp:TextBox ID="txtOutput" runat="server" Text="" ReadOnly="true" TextMode="MultiLine"></asp:TextBox>
        </div>
    </form>

</body>
</html>
