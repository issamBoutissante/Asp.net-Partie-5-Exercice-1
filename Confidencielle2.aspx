<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Confidencielle2.aspx.cs" Inherits="Partie_5_Exercice_1.Confidencielle2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Confidencielle 2</h1>
        <asp:Label runat="server" ID="Message" />
        <p>
            <asp:Button ID="Deconnecter" runat="server" OnClick="Deconnecter_Click" Text="Deconnecter" />
        </p>
    </form>
</body>
</html>
