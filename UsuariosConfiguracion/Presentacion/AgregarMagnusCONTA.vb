Public Class AgregarMagnusCONTA
    Public modo As tipo
    Private _mdiPrincipal As mdiPrincipal
    Public _IdMagnusC As Integer
    Public idSistema As Integer
    Enum tipo
        Nuevo
        Editar
    End Enum

    Public Forma As New ConsultarMagnusCONTA



    Private Sub AgregarMagnusCONTA_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarEmpresas()
        CargarDB()
    End Sub

    Private Sub CargarEmpresas()
        Dim dt As New DataTable
        Dim nEmpresa As New Negocios.MagnusCONTA
        Try
            dt = nEmpresa.CargarEmpresas
            txtEmpresa.Properties.DataSource = dt
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
            'MessageBox.Show(ex.Message)
        Finally
            oNegocio = Nothing
        End Try
    End Sub

    Public Function llenarEntidades() As Entidades.MagnusCONTA
        Dim eMagnusC As New Entidades.MagnusCONTA
        eMagnusC.DBConta = Me.txtBase.EditValue
        eMagnusC.Empresa = Me.txtEmpresa.EditValue
        eMagnusC.Sistema = idSistema
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
        eMagnusC.Sistema = idSistema
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
        ceAutonumerico.Checked = False
        ceContrapartidaCancelacion.Checked = False
        txtEjercicioUno.EditValue = ""
        txtConceptoNotaCredito.EditValue = ""
        txtEmpresa.EditValue = ""
        ceContrapartidaCancelacion.Checked = False
        ceManejarFiscal.Checked = False
        ceReubicaciones.Checked = False
        cePorSucursal.Checked = False
        ceVistaPrevia.Checked = False
        txtNumeroActivacion.EditValue = ""
    End Sub

    Public Sub consultarMagnusCONTA(ByVal row As DataRow)
        Try
            txtNumeroActivacion.ReadOnly = True
            txtEmpresa.ReadOnly = True
            _IdMagnusC = row("OID")
            txtBase.EditValue = row("DBConta")
            txtEmpresa.EditValue = row("Empresa")
            ceAutonumerico.Checked = row("Autonumerico")
            txtEjercicioUno.EditValue = row("EjercicioUno")
            ceManejarFiscal.Checked = row("ManejarFiscal")
            ceReubicaciones.Checked = row("Reubicaciones")
            cePorSucursal.Checked = row("PorSucursal")
            txtConceptoNotaCredito.EditValue = row("ConceptoNotaCredito")
            ceContrapartidaCancelacion.Checked = row("ContrapartidaCancelacion")
            ceVistaPrevia.Checked = row("VistaPrevia")
        Catch ex As Exception
            'MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Cargar()
        Try
            Select Case modo
                Case tipo.Nuevo
                    Me.Text = "Agregar MagnusCONTA"
                Case tipo.Editar
                    Me.Text = "Editar MagnusConta"
                    CargarMagnusCONTA()
            End Select
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub CargarMagnusCONTA()
        Dim oNegocio As New Negocios.MagnusCONTA
        Dim oEntidad As New Entidades.MagnusCONTA
        Try
            oEntidad = oNegocio.CargarMagnusCONTA(_IdMagnusC)
            Me.txtBase.Text = oEntidad.DBConta
            Me.txtEmpresa.Text = oEntidad.Empresa
            idSistema = oEntidad.Sistema
            Me.txtEjercicioUno.Text = oEntidad.EjercicioUno
            Me.txtConceptoNotaCredito.Text = oEntidad.ConceptoNotaCredito
            Me.ceAutonumerico.Checked = oEntidad.Autonumerico
            Me.ceContrapartidaCancelacion.Checked = oEntidad.ContrapartidaCancelacion
            Me.ceManejarFiscal.Checked = oEntidad.ManejarFiscal
            Me.cePorSucursal.Checked = oEntidad.PorSucursal
            Me.ceReubicaciones.Checked = oEntidad.Reubicaciones
            Me.ceVistaPrevia.Checked = oEntidad.VistaPrevia
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Guardar()

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub

    Private Sub txtEmpresa_EditValueChanged(sender As Object, e As EventArgs) Handles txtEmpresa.EditValueChanged
        Dim nConta As New Negocios.MagnusCONTA
        Dim eSistemas As New Entidades.Sistema
        eSistemas = nConta.CargarEntidadMagnusConta(txtEmpresa.EditValue)
        txtNumeroActivacion.EditValue = eSistemas.Activacion
        idSistema = eSistemas.OID
        txtNumeroActivacion.ReadOnly = True
    End Sub
End Class