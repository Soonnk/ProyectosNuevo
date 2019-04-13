Public Class pAgregarClientes
    Public modo As tipo
    Private _mdiPrincipal As mdiPrincipal

    Enum tipo
        Nuevo
        Editar
    End Enum
    Private Sub pAgregarClientes_Load(sender As Object, e As EventArgs) Handles Me.Load

        Cargar()
    End Sub
    Public Sub consultarCliente(ByVal row As DataRow)
        Try
            txtId.EditValue = row("id")
            txtNombre.EditValue = row("nombre")
            txtApellido.EditValue = row("apellido")
            txtDireccion.EditValue = row("direccion")
            txtMunicipio.EditValue = row("municipo")
            txtEstado.EditValue = row("estado")
            txtPais.EditValue = row("pais")
            txtTelefono.EditValue = row("telefono")
            txtCorreo.EditValue = row("correo")
        Catch ex As Exception

        End Try
    End Sub
    '---------------------------------------------------------------
    Public TipoForma As enuTipoForma

    Public Enum enuTipoForma
        Nuevo
        Editar
    End Enum
    Public Forma As New pConsultarClientes
    Public _IdCliente2 As Integer


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

    Private Sub GuardarCliente()
        Try
            Dim oNegocio As New Negocios.Clientes

            Select Case TipoForma
                Case enuTipoForma.Nuevo
                    If oNegocio.InsertarCliente(llenarEntidades) = True Then
                        MessageBox.Show("Los datos han sido guardados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CType(Owner, pConsultarClientes).Cargar()
                        Me.Close()
                    Else
                        MessageBox.Show("No se han podido guardar los datos solicitados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Public Sub Cargar()
        Try
            Select Case TipoForma
                Case enuTipoForma.Nuevo
                    Me.Text = ".: Agregar Cliente :."
                Case enuTipoForma.Editar
                    Me.Text = ".: Editar Cliente :."
                    CargarCliente()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub CargarCliente()
        Dim oNegocio As New Negocios.Clientes
        Dim oEntidad As New Entidades.Clientes
        Try
            oEntidad = oNegocio.CargarCliente(_IdCliente2)
            Me.txtNombre.Text = oEntidad.Nombre
            Me.txtDireccion.Text = oEntidad.Direccion
            Me.txtCorreo.Text = oEntidad.Correo
            Me.txtTelefono.Text = oEntidad.Telefono
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        GuardarCliente()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub


End Class