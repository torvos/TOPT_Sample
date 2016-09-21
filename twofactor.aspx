<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="twofactor.aspx.vb" Inherits="OPT.twofactor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="Label1" AssociatedControlID="TextBox1" runat="server" CssClass="col-sm-2 control-label">Email:</asp:Label>
    <asp:TextBox ID="TextBox1" cssclass="form-control" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label2" AssociatedControlID="TextBox2" runat="server" CssClass="col-sm-2 control-label">Phone Number:</asp:Label>
    <asp:TextBox ID="TextBox2" cssClass="form-control"  runat="server"></asp:TextBox><br />
    <asp:Button ID="btnEnable2Factor" cssClass="btn btn-primary" Text="Enable Two Factor Authentication" runat="server"/>
    <hr />
        
    <asp:Label ID="lblAUTHY_ID" AssociatedControlID="txtAUTHY_ID" runat="server" CssClass="col-sm-2 control-label">AUTHY_ID</asp:Label> 
    <asp:TextBox ID="txtAUTHY_ID" cssclass="form-control" runat="server"></asp:TextBox> <asp:Button ID="btnRequest" cssClass="btn btn-primary" Text="Request SMS token" runat="server"/><br />
    <asp:Label ID="lblTOKEN" AssociatedControlID="txtTOKEN" runat="server" CssClass="col-sm-2 control-label">TOKEN</asp:Label>
    <asp:TextBox ID="txtTOKEN" cssClass="form-control"  runat="server"></asp:TextBox><br />
    <asp:Button ID="btnValidate" cssClass="btn btn-primary" Text="Validate" runat="server"/>  
    <hr />
    <asp:Literal ID="litResults" runat="server"></asp:Literal>
    </div>
    </form>
</body>
</html>
