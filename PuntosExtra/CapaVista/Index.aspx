<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PuntosExtra.CapaVista.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 <link href="StyleSheet1.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <section class="form" >
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nombre del Cliente"></asp:Label>           
            
         </div>
              <div>
                 <asp:Label ID="Label2" runat="server" Text="Cédula"></asp:Label>
                
             </div>
                   <div>
                       <asp:Label ID="Label3" runat="server" Text="Fecha de Resarvación"></asp:Label>
                      
                   </div>
                        <div>
                            <asp:Label ID="Label4" runat="server" Text="Tipo de Reservación"></asp:Label>
                          
                         </div>
                               <div>
                                    <asp:Label ID="Label5" runat="server" Text=" "></asp:Label>
                                     
                                </div>
            
         </section>
        <section class="Text">
            <div>
              <asp:TextBox ID="txtName" runat="server"></asp:TextBox>           
             </div>
              <div>
                 <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox>
             </div>
                   <div>
        
                       <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
                   </div>
                        <div>
                          
                            <asp:DropDownList ID="cboTipo" runat="server"></asp:DropDownList>
                         </div>
                               

        </section>
     
        <div>
            <asp:GridView ID="dgVer" runat="server"></asp:GridView>
            <asp:GridView ID="dgVerTodos" runat="server"></asp:GridView>
        </div>
        <div>
            <asp:Button ID="bntVerUno" runat="server" Text="Ver Primer Reserva" onclick="bntVerUno_Click" />
            <asp:Button ID="bntVer" runat="server" Text="Ver Reservas" onclick="bntVer_Click" />
        </div>
    </form>
</body>
</html>
