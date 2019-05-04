Public Class AgregarEmpresa
    Public modo As tipo
    Private _mdiPrincipal As mdiPrincipal
    Public _IdEmpresa As Integer
    Dim ruta As String

    Dim nImagenes As New Negocios.Imagen
    Enum tipo
        Nuevo
        Editar
    End Enum
    Public TipoForma As enuTipoForma
    Public Enum enuTipoForma
        Nuevo
        Editar
    End Enum
    Public Forma As New ConsultarEmpresa

    Private Sub GuardarEmpresa()
        Try
            Dim oNegocio As New Negocios.Empresa
            Dim camposVacios As String = ""
            Select Case modo
                Case tipo.Nuevo
                    If Not ValidarCampos(camposVacios) Then Exit Sub
                    If oNegocio.InsertarEmpresa(llenarEntidades) = True Then
                        MessageBox.Show("Los datos han sido guardados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LimpiarCampos()
                    Else
                        MessageBox.Show("No se han podido guardar los datos solicitados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Case tipo.Editar
                    If Not ValidarCampos(camposVacios) Then Exit Sub
                    If oNegocio.EditarEmpresa(llenarEntidades2) = True Then
                        MessageBox.Show("Los datos han sido modificados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Else
                        MessageBox.Show("No se han podido modificar los datos solicitados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function ValidarCampos(ByVal camposVacios As String) As Boolean
        Try
            camposVacios = "Los siguientes campos esta vacios:" & Chr(10) & Chr(10)
            Dim resultado As Boolean = True
            If Not txtNombre.EditValue <> "" Then
                camposVacios &= "Nombre" & Chr(10)
                resultado = False
            End If
            If Not txtRfc.EditValue <> "" Then
                camposVacios &= "RFC" & Chr(10)
                resultado = False
            End If
            If resultado = False Then
                MessageBox.Show(camposVacios, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            Else
                Return True
            End If
        Catch ex As Exception

        End Try
    End Function

    Public Sub LimpiarCampos()
        txtNombre.EditValue = ""
        txtDireccion.EditValue = ""
        txtColonia.EditValue = ""
        txtPoblacion.EditValue = ""
        txtPais.EditValue = ""
        txtCodigo.EditValue = ""
        txtRfc.EditValue = ""
        txtGiro.EditValue = ""
        txtTelefono.EditValue = ""
        ceActiva.Checked = False
    End Sub
    Public Sub Cargar()
        Try
            Select Case modo
                Case tipo.Nuevo
                    Me.Text = "Agregar Empresa"
                Case tipo.Editar
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

    Public Function llenarEntidades2() As Entidades.Empresa
        Dim eEmpresa As New Entidades.Empresa
        eEmpresa.OID = _IdEmpresa
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
        Try
            Dim ms1 As New System.IO.MemoryStream
            peLogotipo.BackgroundImage.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg)
            nImagenes.InsertarImagen(ms1)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Public Sub consultarEmpresa(ByVal row As DataRow)
        Try
            _IdEmpresa = row("OID")
            txtNombre.EditValue = row("Nombre")
            txtDireccion.EditValue = row("Direccion")
            txtColonia.EditValue = row("Colonia")
            txtPoblacion.EditValue = row("Poblacion")
            txtPais.EditValue = row("Pais")
            txtCodigo.EditValue = row("CP")
            txtRfc.EditValue = row("RFC")
            txtGiro.EditValue = row("Giro")
            txtTelefono.EditValue = row("Telefono")
            ceActiva.Checked = row("activo")
        Catch ex As Exception

        End Try
    End Sub


    Private Sub peLogotipo_DoubleClick(sender As Object, e As EventArgs) Handles peLogotipo.DoubleClick
        Try
            Dim openFileDialog1 As New OpenFileDialog()
            Dim dialogo As New DialogResult
            openFileDialog1.Filter = "Imagen (JPG,BMP,PNG)|*.JPG;*.BMP;*.PNG|All files (*.*)|*.*"

            openFileDialog1.FilterIndex = 1
            openFileDialog1.RestoreDirectory = True
            dialogo = openFileDialog1.ShowDialog()

            If (dialogo = DialogResult.OK) Then
                Dim bmp As New Bitmap(Image.FromFile(openFileDialog1.FileName))
                bmp = bmp.GetThumbnailImage(480, 480, Nothing, IntPtr.Zero)
                'Redimencionamos pixeles de imagen (Opcional).
                peLogotipo.BackgroundImage = Nothing
                peLogotipo.BackgroundImageLayout = ImageLayout.Stretch 'Ajustamos la imagen a todo el picturebox.
                peLogotipo.BackgroundImage = bmp 'Cargamos la imagen al PictureBox.
                peLogotipo.Image = bmp
                'sExtencion = System.IO.Path.GetExtension(openFileDialog1.FileName) 'Obtenemos la Extencion de la imagen cargada.
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub peLogotipo_EditValueChanged(sender As Object, e As EventArgs) Handles peLogotipo.EditValueChanged

    End Sub


End Class