Public Class AgregarSistema
    Public modo As tipo
    Private _mdiPrincipal As mdiPrincipal
    Public _IdSistema As Integer
    Enum tipo
        Nuevo
        Editar
    End Enum

    Public Forma As New ConsultarSistemas

    Private Sub AgregarSistema_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEmpresas()

    End Sub
    Private Sub CargarEmpresas()
        Dim dt As New DataTable
        Dim nEmpresa As New Negocios.Empresa
        Try
            dt = nEmpresa.Cargar
            glEmpresa.Properties.DataSource = dt
        Catch ex As Exception

        End Try
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
        glEmpresa.EditValue = ""
        cmbSistema.EditValue = ""
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
        eSistema.Empresa = Me.glEmpresa.EditValue
        eSistema.Nombre = Me.cmbSistema.Text
        eSistema.Codigo = Me.txtCodigo.Text
        eSistema.Serie = Me.txtSerie.Text
        eSistema.Activacion = Me.txtActivacion.Text
        eSistema.DB = ""

        Return eSistema
    End Function

    Public Function llenarEntidades2() As Entidades.Sistema
        Dim eSistema As New Entidades.Sistema
        eSistema.OID = _IdSistema
        eSistema.Empresa = Me.glEmpresa.EditValue
        eSistema.Nombre = Me.cmbSistema.Text
        eSistema.Codigo = Me.txtCodigo.Text
        eSistema.Serie = Me.txtSerie.Text
        eSistema.Activacion = Me.txtActivacion.Text
        eSistema.DB = ""

        Return eSistema
    End Function

    Public Sub consultarSistema(ByVal row As DataRow)
        Try
            _IdSistema = row("OID")
            cmbSistema.EditValue = row("Nombre")
            txtCodigo.EditValue = row("Codigo")
            txtSerie.EditValue = row("Serie")
            txtActivacion.EditValue = row("Activacion")
            glEmpresa.EditValue = row("Empresa")
        Catch ex As Exception

        End Try
    End Sub

End Class