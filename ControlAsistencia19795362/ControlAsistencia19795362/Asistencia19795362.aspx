<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Asistencia19795362.aspx.cs" Inherits="ControlAsistencia19795362.Asistencia19795362" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Control de Asistencia - Rodrigo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Control de Asistencia</h2>
            
            <asp:Label ID="lblAlumno" runat="server" Text="Nombre del Alumno:"></asp:Label>
            <br />
            <asp:TextBox ID="txtAlumno" runat="server" Width="250px"></asp:TextBox>
            
            <br /><br /> 
            <asp:Label ID="lblFecha" runat="server" Text="Fecha:"></asp:Label>
            <br />
            <asp:TextBox ID="txtFecha" runat="server" TextMode="Date" Width="250px"></asp:TextBox>
            
            <br /><br /> 
            <asp:Label ID="lblEstado" runat="server" Text="Estado:"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlEstado" runat="server" Width="258px">
                <asp:ListItem Text="asistio" Value="asistio"></asp:ListItem>
                <asp:ListItem Text="falto" Value="falto"></asp:ListItem>
                <asp:ListItem Text="tarde" Value="tarde"></asp:ListItem>
            </asp:DropDownList>

            <br /><br /> 
            <asp:Button ID="btnGuardar" runat="server" Text="Registrar Asistencia" OnClick="btnGuardar_Click" Width="260px" />
        </div>

        <br /><br />

        <asp:GridView ID="gvAlumnos" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" 
            OnRowDeleting="gvAlumnos_RowDeleting" 
            OnRowEditing="gvAlumnos_RowEditing" 
            OnRowCancelingEdit="gvAlumnos_RowCancelingEdit" 
            OnRowUpdating="gvAlumnos_RowUpdating" 
            BorderWidth="1px" CellPadding="5">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID" ReadOnly="True" />
                <asp:BoundField DataField="NombreAlumno" HeaderText="Alumno" />
                <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                <asp:BoundField DataField="Estado" HeaderText="Estado" />
                

                <asp:CommandField ShowEditButton="True" EditText="Editar" UpdateText="Actualizar" CancelText="Cancelar" HeaderText="Modificar" />
                <asp:CommandField ShowDeleteButton="True" DeleteText="Eliminar" HeaderText="Acción" />
            </Columns>
        </asp:GridView>
        </form>
</body>
</html>