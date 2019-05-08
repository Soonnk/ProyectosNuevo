Public Class AgregarMagnusCONTA
    Public modo As tipo
    Private _mdiPrincipal As mdiPrincipal
    Public _IdMagnusC As Integer
    Enum tipo
        Nuevo
        Editar
    End Enum

    Public Forma As New ConsultarMagnusCONTA

    Private Sub CargarEmpresas()
        Dim dt As New DataTable
        Dim nEmpresa As New Negocios.Empresa
        Try
            dt = nEmpresa.Cargar
            txtEmpresa.Properties.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub CargarSistema()
        Dim dt As New DataTable
        Dim nSistema As New Negocios.Sistema
        Try
            dt = nSistema.Cargar
            txtSistema.Properties.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub CargarDB()
        Dim oNegocioMagnusC As New Negocios.MagnusCONTA
        Try
            Me.txtBase.Properties.DataSource = oNegocioMagnusC.GetDB
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            oNegocioMagnusC = Nothing
        End Try
    End Sub

    Private Sub AgregarMagnusCONTA_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarEmpresas()
        CargarSistema()
        CargarDB()
    End Sub

    Public Sub Guardar()
        Dim oNegocio As New Negocios.MagnusCONTA
        Try
            Dim camposVacios As String = ""
            Select Case modo
                Case tipo.Nuevo
                    'If Not ValidarCampos(camposVacios) Then Exit Sub
                    If oNegocio.InsertarMagnusCONTA(llenarEntidades) = True Then
                        MessageBox.Show("Los datos han sido guardados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        CType(Owner, ConsultarMagnusCONTA).Cargar()
                        LimpiarCampos()
                    Else
                        MessageBox.Show("No se han podido guardar los datos solicitados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Case tipo.Editar
                    'If Not ValidarCampos(camposVacios) Then Exit Sub
                    If oNegocio.EditarMagnusCONTA(llenarEntidades2) = True Then
                        MessageBox.Show("Los datos han sido modificados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Else
                        MessageBox.Show("No se han podido modificar los datos solicitados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            oNegocio = Nothing
        End Try
    End Sub

    Public Function llenarEntidades() As Entidades.MagnusCONTA
        Dim eMagnusC As New Entidades.MagnusCONTA
        eMagnusC.DBConta = Me.txtBase.EditValue
        eMagnusC.Empresa = Me.txtEmpresa.EditValue
        eMagnusC.Sistema = Me.txtSistema.EditValue
        eMagnusC.Autonumerico = Me.ceAutonumerico.Checked
        eMagnusC.EjercicioUno = Me.txtEjercicioUno.Text
        eMagnusC.ManejarFiscal = Me.ceManejarFiscal.Checked
        eMagnusC.Reubicaciones = Me.ceReubicaciones.Checked
        eMagnusC.PorSucursal = Me.cePorSucursal.Checked
        eMagnusC.ConceptoNotaCredito = Me.txtConceptoNotaCredito.Text
        eMagnusC.ContrapartidaCancelacion = Me.ceContrapartidaCancelacion.Checked
        eMagnusC.VistaPrevia = Me.ceVistaPrevia.Checked
        eMagnusC.Catalogo2 = ""
        Return eMagnusC
    End Function

    Public Function llenarEntidades2() As Entidades.MagnusCONTA
        Dim eMagnusC As New Entidades.MagnusCONTA
        eMagnusC.OID = _IdMagnusC
        eMagnusC.DBConta = Me.txtBase.EditValue
        eMagnusC.Empresa = Me.txtEmpresa.EditValue
        eMagnusC.Sistema = Me.txtSistema.EditValue
        eMagnusC.Autonumerico = Me.ceAutonumerico.Checked
        eMagnusC.EjercicioUno = Me.txtEjercicioUno.Text
        eMagnusC.ManejarFiscal = Me.ceManejarFiscal.Checked
        eMagnusC.Reubicaciones = Me.ceReubicaciones.Checked
        eMagnusC.PorSucursal = Me.cePorSucursal.Checked
        eMagnusC.ConceptoNotaCredito = Me.txtConceptoNotaCredito.Text
        eMagnusC.ContrapartidaCancelacion = Me.ceContrapartidaCancelacion.Checked
        eMagnusC.VistaPrevia = Me.ceVistaPrevia.Checked
        Return eMagnusC
    End Function

    Public Sub LimpiarCampos()
        txtBase.EditValue = ""
        txtSistema.EditValue = ""
        ceAutonumerico.Checked = False
        txtEjercicioUno.EditValue = ""
        txtConceptoNotaCredito.EditValue = ""
        txtEmpresa.EditValue = ""
        ceContrapartidaCancelacion.Checked = False
        ceManejarFiscal.Checked = False
        ceReubicaciones.Checked = False
        cePorSucursal.Checked = False
        ceVistaPrevia.Checked = False
    End Sub

    Public Sub consultarMagnusCONTA(ByVal row As DataRow)
        Try
            _IdMagnusC = row("OID")
            txtBase.EditValue = row("DBConta")
            txtEmpresa.EditValue = row("Empresa")
            txtSistema.EditValue = row("Sistema")
            ceAutonumerico.Checked = row("Autonumerico")
            txtEjercicioUno.EditValue = row("EjercicioUno")
            ceManejarFiscal.Checked = row("ManejarFiscal")
            ceReubicaciones.Checked = row("Reubicaciones")
            cePorSucursal.Checked = row("PorSucursal")
            txtConceptoNotaCredito.EditValue = row("ConceptoNotaCredito")
            ceContrapartidaCancelacion.Checked = row("ContrapartidaCancelacion")
            ceVistaPrevia.Checked = row("VistaPrevia")
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Guardar()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
End Class