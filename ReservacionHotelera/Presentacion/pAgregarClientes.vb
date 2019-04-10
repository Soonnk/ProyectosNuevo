Public Class pAgregarClientes
    Public Function llenarEntidades() As Entidades.Clientes
        Dim eCliente As New Entidades.Clientes
        eCliente.Nombre = Me.txtNombre.Text
        eCliente.Apellido = Me.txtApellido.Text
        eCliente.Direccion = Me.txtDireccion.Text
        eCliente.Municipio = Me.txtMunicipio.Text
        eCliente.Estado = Me.txtEstado.Text
        eCliente.Pais = Me.txtPais.Text
        eCliente.Correo = Me.txtCorreo.Text
        Return eCliente
    End Function

End Class