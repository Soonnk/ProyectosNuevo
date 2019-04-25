﻿Public Class AgregarEmpresa
    Public modo As tipo
    Private _mdiPrincipal As mdiPrincipal
    Public _IdEmpresa As Integer
    Dim ruta As String
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
            Dim camposVacios As String = ""
            Select Case TipoForma
                Case enuTipoForma.Nuevo
                    If Not ValidarCampos(camposVacios) Then Exit Sub
                    If oNegocio.InsertarEmpresa(llenarEntidades) = True Then
                        MessageBox.Show("Los datos han sido guardados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CType(Owner, ConsultarEmpresa).Cargar()
                        LimpiarCampos()
                    Else
                        MessageBox.Show("No se han podido guardar los datos solicitados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            If Not txtDireccion.EditValue <> "" Then
                camposVacios &= "Direccion" & Chr(10)
                resultado = False
            End If
            If Not txtColonia.EditValue <> "" Then
                camposVacios &= "Colonia" & Chr(10)
                resultado = False
            End If
            If Not txtPoblacion.EditValue <> "" Then
                camposVacios &= "Poblacion" & Chr(10)
                resultado = False
            End If
            If Not txtPais.EditValue <> "" Then
                camposVacios &= "Pais" & Chr(10)
                resultado = False
            End If
            If Not txtCodigo.EditValue <> "" Then
                camposVacios &= "CP" & Chr(10)
                resultado = False
            End If
            If Not txtRfc.EditValue <> "" Then
                camposVacios &= "RFC" & Chr(10)
                resultado = False
            End If
            If Not txtGiro.EditValue <> "" Then
                camposVacios &= "Giro" & Chr(10)
                resultado = False
            End If
            If Not txtTelefono.EditValue <> "" Then
                camposVacios &= "Telefono" & Chr(10)
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

    Private Sub peLogotipo_DoubleClick(sender As Object, e As EventArgs) Handles peLogotipo.DoubleClick
        Try

            Dim imagen As New OpenFileDialog()
            imagen.Filter = "Imagen JPG (*.jpg)|*.jpg|Imagen BMP (*.bmp)|*.bmp|Imagen PNG (*.png)|*.png|Imagen GIF (*.gif)|*.gif"
            If imagen.ShowDialog() = DialogResult.OK Then
                peLogotipo.Properties.SizeMode = PictureBoxSizeMode.AutoSize
                ruta = imagen.FileName.ToString
                peLogotipo.Image = System.Drawing.Image.FromFile(ruta)

            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar la imagen", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class