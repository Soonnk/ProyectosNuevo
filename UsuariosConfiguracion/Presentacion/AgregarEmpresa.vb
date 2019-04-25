Public Class AgregarEmpresa
    Public modo As tipo
    Private _mdiPrincipal As mdiPrincipal
    Public _IdEmpresa As Integer
    Enum tipo
        Nuevo
        Editar
    End Enum

    Public TipoForma As enuTipoForma
    Public Forma As New ConsultarEmpresa
    Public Enum enuTipoForma
        Nuevo
        Editar
    End Enum
    Private Sub GuardarEmpresa()
        Try
            Dim oNegocio As New Negocios.Empresa

            Select Case TipoForma
                Case enuTipoForma.Nuevo
                    If oNegocio.InsertarEmpresa(llenarEntidades) = True Then
                        MessageBox.Show("Los datos han sido guardados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CType(Owner, ConsultarEmpresa).Cargar()
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
                    Me.Text = "Agregar Empresa"
                Case enuTipoForma.Editar
                    Me.Text = "Editar Empresa"
                    CargarEmpresa()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub CargarEmpresa()
        Dim oNegocio As New Negocios.Empresa
        Dim oEntidad As New Entidades.Empresa
        Try
            oEntidad = oNegocio.CargarEmpresa(_IdEmpresa)
            Me.txtNombre.Text = oEntidad.Nombre
            Me.txtDireccion.Text = oEntidad.Direccion
            Me.txtColonia.Text = oEntidad.Colonia
            Me.txtPoblacion.Text = oEntidad.Poblacion
            Me.txtPais.Text = oEntidad.Pais
            Me.txtCodigo.Text = oEntidad.CP
            Me.txtRfc.Text = oEntidad.RFC
            Me.txtGiro.Text = oEntidad.Giro
            Me.txtTelefono.Text = oEntidad.Telefono
            Me.ceActiva.Checked = oEntidad.Estatus
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function llenarEntidades() As Entidades.Empresa
        Dim eEmpresa As New Entidades.Empresa
        eEmpresa.Nombre = Me.txtNombre.Text
        eEmpresa.Direccion = Me.txtDireccion.Text
        eEmpresa.Colonia = Me.txtColonia.Text
        eEmpresa.Poblacion = Me.txtPoblacion.Text
        eEmpresa.Pais = Me.txtPais.Text
        eEmpresa.CP = Me.txtCodigo.Text
        eEmpresa.RFC = Me.txtRfc.Text
        eEmpresa.Giro = Me.txtGiro.Text
        eEmpresa.Telefono = Me.txtTelefono.Text
        eEmpresa.Estatus = Me.ceActiva.Checked

        Return eEmpresa
    End Function


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        GuardarEmpresa()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub PictureEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles PictureEdit1.EditValueChanged
        Try
            Dim imagen As New OpenFileDialog()
            imagen.Filter = "Imagen JPG (*.jpg)|*.jpg|Imagen BMP (*.bmp)|*.bmp|Imagen PNG (*.png)|*.png|Imagen GIF (*.gif)|*.gif"
            If imagen.ShowDialog() = DialogResult Then

            End If
        Catch ex As Exception

        End Try
    End Sub

    Public Sub consultarEmpresa(ByVal row As DataRow)
        Try
            txtNombre.EditValue = row("Nombre")
            txtDireccion.EditValue = row("Direccion")
            txtColonia.EditValue = row("Colonia")
            txtPoblacion.EditValue = row("Poblacion")
            txtPais.EditValue = row("Pais")
            txtCodigo.EditValue = row("CodigoPostal")
            txtRfc.EditValue = row("RFC")
            txtGiro.EditValue = row("Giro")
            txtTelefono.EditValue = row("Telefono")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles txtNombre.EditValueChanged

    End Sub
End Class