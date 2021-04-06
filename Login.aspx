<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Partie_5_Exercice_1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Acceil</h1>
        <label>Nom</label>
        <asp:TextBox runat="server" ID="Nom"/>
        <br />
        <label>Mot de pass</label>
        <asp:TextBox runat="server" ID="MotPass" />
        <br />
        <asp:Button runat="server" ID="Connecter" OnClick="Connecter_Click" Text="Connecter"/>
        <asp:Label ID="Message" runat="server"></asp:Label>
    </form>
</body>
</html>
