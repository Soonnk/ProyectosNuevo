Public Class AgregarSistema
    Public modo As tipo
    Private _mdiPrincipal As mdiPrincipal
    Public _IdSistema As Integer
    Enum tipo
        Nuevo
        Editar
    End Enum

    Private Sub AgregarSistema_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        GuardarSistema()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub GuardarSistema()
        Try
            Dim oNegocio As New Negocios.Sistema
            'Dim camposVacios As String = ""
            Select Case modo
                Case tipo.Nuevo
                    'If Not ValidarCampos(camposVacios) Then Exit Sub
                    If oNegocio.InsertarSistema(llenarEntidades) = True Then
                        MessageBox.Show("Los datos han sido guardados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CType(Owner, ConsultarSistemas).Cargar()
                        LimpiarCampos()
                    Else
                        MessageBox.Show("No se han podido guardar los datos solicitados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Case tipo.Editar
                    'If Not ValidarCampos(camposVacios) Then Exit Sub
                    If oNegocio.EditarSistema(llenarEntidades2) = True Then
                        MessageBox.Show("Los datos han sido modificados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CType(Owner, ConsultarSistemas).Cargar()
                        LimpiarCampos()
                    Else
                        MessageBox.Show("No se han podido modificar los datos solicitados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub LimpiarCampos()
        'glempresa = ""
        'cmbSistema. = ""
        txtCodigo.EditValue = ""
        txtSerie.EditValue = ""
        txtActivacion.EditValue = ""
    End Sub

    Public Sub Cargar()
        Try
            Select Case modo
                Case tipo.Nuevo
                    Me.Text = "Agregar Sistema"
                Case tipo.Editar
                    Me.Text = "Editar Sistema"
                    CargarSistema()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Public Sub CargarSistema()
        Dim oNegocio As New Negocios.Sistema
        Dim oEntidad As New Entidades.Sistema
        Try
            oEntidad = oNegocio.CargarSistema(_IdSistema)

            Me.txtCodigo.Text = oEntidad.Codigo
            Me.txtSerie.Text = oEntidad.Serie
            Me.txtActivacion.Text = oEntidad.Activacion
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function llenarEntidades() As Entidades.Sistema
        Dim eSistema As New Entidades.Sistema
        'eSistema.Empresa = Me.glEmpresa.Text
        'eSistema.Sistema = Me.cmbSistema.Text
        eSistema.Codigo = txtCodigo.Text
        eSistema.Serie = txtSerie.Text
        eSistema.Activacion = txtActivacion.Text

        Return eSistema
    End Function

    Public Function llenarEntidades2() As Entidades.Sistema
        Dim eSistema As New Entidades.Sistema
        eSistema.OID = _IdSistema
        'eSistema.Empresa = Me.glEmpresa.ValueMember
        'eSistema.Sistema = Me.cmbSistema.Text
        eSistema.Codigo = txtCodigo.Text
        eSistema.Serie = txtSerie.Text
        eSistema.Activacion = txtActivacion.Text

        Return eSistema
    End Function

    Public Sub consultarSistema(ByVal row As DataRow)
        Try
            _IdSistema = row("OID")
            cmbSistema.EditValue = row("Nombre")
            txtCodigo.EditValue = row("Codigo")
            txtSerie.EditValue = row("Serie")
            txtActivacion.EditValue = row("Activacion")
        Catch ex As Exception

        End Try
    End Sub

End Class