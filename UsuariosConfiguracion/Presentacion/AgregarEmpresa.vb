Public Class AgregarEmpresa
    Public modo As tipo
    Private _mdiPrincipal As mdiPrincipal
    Public _IdEmpresa As Integer
    Dim ruta As String
    Dim ms1 As New System.IO.MemoryStream
    Dim nImagenes As New Negocios.Imagen
    Enum tipo
        Nuevo
        Editar
    End Enum

    Public Forma As New ConsultarEmpresa

    'Metodo que permite el registro de una empresa o la edición de sus datos para que queden almacenados los cambios en la base de datos
    Private Sub GuardarEmpresa()
        Dim oNegocio As New Negocios.Empresa
        Try
            Dim camposVacios As String = ""
            Select Case modo
                Case tipo.Nuevo
                    If Not ValidarCampos(camposVacios) Then Exit Sub
                    If oNegocio.InsertarEmpresaImagen(llenarEntidades, ms1) = True Then
                        MessageBox.Show("Los datos han sido guardados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CType(Owner, ConsultarEmpresa).Cargar()
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

    'Metodo para validar que los campos obligatorios no esten vacios, se manda llamar en el metodo de GuardarEmpresa()
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
            MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    'Permite que los campos se limpien, una vez que la empresa haya sido guardada.
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
        peLogotipo.EditValue = Nothing
    End Sub

    'Encabezado del formulario que distingue si es un registro nuevo o una edición.
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

    'Llena los campos del formulario, sirve cuando un registro será editado.
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
            Me.peLogotipo.EditValue = oEntidad.Logotipo
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Permite que los valores ingresados por el usuario, se almacenen en su variable de la entidad, que es la que permitirá que el registro sea almecenado.
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
        peLogotipo.BackgroundImage.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return eEmpresa
    End Function

    'Para la edición es necesario concoer a cual clave de registro se le asignarán los nuevos datos, permite lo mismo que el anterior pero con la variación de llenar el campo de la clave desde este momento.
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
        'eEmpresa.Logotipo = Me.peLogotipo.EditValue
        Return eEmpresa
    End Function


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        GuardarEmpresa()
        Try
            peLogotipo.BackgroundImage.Save(ms1, System.Drawing.Imaging.ImageFormat.Jpeg)
            nImagenes.InsertarImagen(ms1, _IdEmpresa)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            peLogotipo.EditValue = row("Logotipo")
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
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

End Class