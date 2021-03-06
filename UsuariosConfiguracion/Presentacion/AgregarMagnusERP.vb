﻿Public Class AgregarMagnusERP
    Public modo As tipo
    Private _mdiPrincipal As mdiPrincipal
    Public _idMagnusERP As Integer
    Public _IdSistema As Integer
    Enum tipo
        Nuevo
        Editar
    End Enum
    Public ModoForma As enuModoForma

    Public Enum enuModoForma
        Nuevo
        Editar
    End Enum

    Private Sub AgregarMagnusERP_Load(sender As Object, e As EventArgs) Handles Me.Load
        'CargarEmpresas()
        CargarDB()
        TipoReporte()
        txtNumeroActivacion.ReadOnly = True

        If modo = tipo.Nuevo Then

            Me.gcReportes.Enabled = False
            CargarEmpresas()
        Else

            Me.gcReportes.Enabled = True
            CargarEmpresa()
            'CargarReporte()
        End If
    End Sub
    'Cargar solo las empresas que pertenecen al sistema cuando no está registrada la configuración de ese sistema
    Private Sub CargarEmpresas()
        Dim dt As New DataTable
        Dim nEmpresa As New Negocios.MagnusERP
        Try
            dt = nEmpresa.CargarEmpresas
            Me.txtEmpresa.Properties.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'Cargar la empresa del registro, de otro modo no la muestra porque la consulta del método de arriba es NOT IN
    Private Sub CargarEmpresa()
        Dim dt As New DataTable
        Dim nEmpresa As New Negocios.Empresa
        Try
            dt = nEmpresa.Cargar
            txtEmpresa.Properties.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub CargarDB()
        Dim oNegocioSimac As New Negocios.SIMAC
        Try
            Me.txtBDMagnus.Properties.DataSource = oNegocioSimac.GetDB
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            oNegocioSimac = Nothing
        End Try
    End Sub

    Public Sub TipoReporte()
        Try
            Dim tipos As DataTable = New DataTable
            tipos.Columns.Add("Tipo")
            tipos.Columns.Add("Descripcion")
            tipos.Rows.Add("ReportePeriodoAutorizaciones", "Reporte periodo autorizaciones")
            tipos.Rows.Add("ReportePeriodoEntregasEmbarque", "Reporte periodo entregas embarque")
            tipos.Rows.Add("ReporteEmbarque", "Reporte embarque")
            tipos.Rows.Add("ReporteAutorizaciones", "Reporte autorizaciones")
            tipos.Rows.Add("ReporteLotesDocumento", "Reporte lotes documento")
            tipos.Rows.Add("ReportePendientesPorSubir", "Reporte pendientes por subir")
            tipos.Rows.Add("RutaReportes", "Ruta reportes")
            tipos.Rows.Add("RutaImagenes", "Ruta imágenes")
            tipos.Rows.Add("Etiqueta", "Etiqueta")
            tipos.Rows.Add("Traspasos", "Traspasos")
            tipos.Rows.Add("Inventarios", "Inventarios")
            tipos.Rows.Add("ReporteLiquidacionMovil", "Reporte liquidación móvil")
            tipos.Rows.Add("ReporteAdeudoRetornable", "Reporte adeudo retornable")
            tipos.Rows.Add("ListaPrecios", "Lista de precios")
            Me.txtTipoReporte.Properties.DataSource = tipos
            Me.txtTipoReporte.Properties.DisplayMember = "Descripcion"
            Me.txtTipoReporte.Properties.ValueMember = "Tipo"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GuardarMagnusERP()
        Dim oNegocio As New Negocios.MagnusERP
        Try
            Dim camposVacios As String = ""
            Select Case modo
                Case tipo.Nuevo
                    'If Not ValidarCampos(camposVacios) Then Exit Sub
                    If oNegocio.InsertarMagnusERP(llenarEntidades) = True Then
                        MessageBox.Show("Los datos han sido guardados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LimpiarCampos()
                    Else
                        MessageBox.Show("No se han podido guardar los datos solicitados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Case tipo.Editar
                    'If Not ValidarCampos(camposVacios) Then Exit Sub
                    If oNegocio.EditarMagnusERP(llenarEntidades2) = True Then
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

    Public Function llenarEntidades() As Entidades.MagnusERP
        Dim eMagnusERP As New Entidades.MagnusERP
        eMagnusERP.DBMagnus = Me.txtBDMagnus.EditValue
        eMagnusERP.Empresa = Me.txtEmpresa.EditValue
        eMagnusERP.Sistema = _IdSistema
        eMagnusERP.manejaMovil = Me.cheManejaMovil.Checked
        eMagnusERP.manejaObras = Me.cheManejaObras.Checked
        eMagnusERP.manejaRenta = Me.cheManejaRentas.Checked
        eMagnusERP.manejaTransportes = Me.cheManejaTransportes.Checked
        'eMagnusERP.m  maneja descuento
        eMagnusERP.desMax = Me.txtDescuentoMax.EditValue
        eMagnusERP.desfinMax = Me.txtDescuentoFinalMax.EditValue
        'eMagnusERP.ru ruta certificado
        'ruta almacenaje xml
        eMagnusERP.EnvioCorreo = Me.rgEnvioCorreoAutomatico.EditValue
        eMagnusERP.EditarTipoPago = Me.cheEditarFormaPago.Checked
        eMagnusERP.FormaPago = Me.cheFormaPago.Checked
        eMagnusERP.EditarComision = Me.cheEditarComision.Checked
        eMagnusERP.ManejaDescuentoComision = Me.cheManejaDescuentoComision.Checked
        eMagnusERP.ventaSoloListaPrecio = Me.cheVenderSobreListaPrecios.Checked
        eMagnusERP.AutoAsignarClave = Me.cheAutoasignarClaveCliente.Checked
        eMagnusERP.CuentasComplemento = Me.cheCuentasComplemento.Checked
        'contabilizar por subdivision
        eMagnusERP.Lotes = Me.cheLotes.Checked
        eMagnusERP.controLotes = Me.cheLotesControlClave.Checked
        eMagnusERP.numeroDecimalesC = Me.txtNumeroDecimalesCantidad.EditValue
        eMagnusERP.ValidacionCredito = Me.txtValidarCredito.EditValue
        eMagnusERP.enlazarParcialPicking = Me.cheEntregarPickingParcial.Checked
        eMagnusERP.LecturaPickingIncrementoUnidad = Me.chePickingIncrementarUnidadLectura.Checked
        eMagnusERP.AgrupaTallasFactura = Me.cheAgruparTallaDocumentos.Checked
        eMagnusERP.ServicioFleteFactura = Me.cheAgregarServicioFleteFactura.Checked
        eMagnusERP.cantidadPorPrecio = Me.cheImporteCantidadPrecio.Checked
        eMagnusERP.numeroDecimalesV = Me.txtNumeroDecimalesImporte.EditValue
        eMagnusERP.ServicioFlete = Me.txtServicioFlete.Text
        eMagnusERP.RptEnlaces = Me.btnReporteEnlaceDocumentos.EditValue
        eMagnusERP.Simac = Me.txtSimac.Text
        eMagnusERP.envioProduccion = Me.cheEnvioPedidosProduccion.Checked
        eMagnusERP.detallarLotesSIMAC = Me.cheDetallarLotesSimac.Checked
        'Group de autorización simac
        eMagnusERP.equivalenciasDuplicadas = Me.cheEquivalenciasDuplicadas.Checked
        eMagnusERP.EquivalenciaClientes = Me.cheMostrarSoloEquivalencias.Checked

        Return eMagnusERP
    End Function

    Public Function llenarEntidades2() As Entidades.MagnusERP
        Dim eMagnusERP As New Entidades.MagnusERP
        eMagnusERP.OID = _idMagnusERP
        eMagnusERP.Sistema = _IdSistema
        eMagnusERP.DBMagnus = Me.txtBDMagnus.EditValue
        eMagnusERP.Empresa = Me.txtEmpresa.EditValue
        eMagnusERP.Sistema = _IdSistema
        eMagnusERP.manejaMovil = Me.cheManejaMovil.Checked
        eMagnusERP.manejaObras = Me.cheManejaObras.Checked
        eMagnusERP.manejaRenta = Me.cheManejaRentas.Checked
        eMagnusERP.manejaTransportes = Me.cheManejaTransportes.Checked
        'eMagnusERP.m  maneja descuento
        eMagnusERP.desMax = Me.txtDescuentoMax.EditValue
        eMagnusERP.desfinMax = Me.txtDescuentoFinalMax.EditValue
        'eMagnusERP.ru ruta certificado
        'ruta almacenaje xml
        eMagnusERP.EnvioCorreo = Me.rgEnvioCorreoAutomatico.EditValue
        eMagnusERP.EditarTipoPago = Me.cheEditarFormaPago.Checked
        eMagnusERP.FormaPago = Me.cheFormaPago.Checked
        eMagnusERP.EditarComision = Me.cheEditarComision.Checked
        eMagnusERP.ManejaDescuentoComision = Me.cheManejaDescuentoComision.Checked
        eMagnusERP.ventaSoloListaPrecio = Me.cheVenderSobreListaPrecios.Checked
        eMagnusERP.AutoAsignarClave = Me.cheAutoasignarClaveCliente.Checked
        eMagnusERP.CuentasComplemento = Me.cheCuentasComplemento.Checked
        'contabilizar por subdivision
        eMagnusERP.Lotes = Me.cheLotes.Checked
        eMagnusERP.controLotes = Me.cheLotesControlClave.Checked
        eMagnusERP.numeroDecimalesC = Me.txtNumeroDecimalesCantidad.EditValue
        eMagnusERP.ValidacionCredito = Me.txtValidarCredito.EditValue
        eMagnusERP.enlazarParcialPicking = Me.cheEntregarPickingParcial.Checked
        eMagnusERP.LecturaPickingIncrementoUnidad = Me.chePickingIncrementarUnidadLectura.Checked
        eMagnusERP.AgrupaTallasFactura = Me.cheAgruparTallaDocumentos.Checked
        eMagnusERP.ServicioFleteFactura = Me.cheAgregarServicioFleteFactura.Checked
        eMagnusERP.cantidadPorPrecio = Me.cheImporteCantidadPrecio.Checked
        eMagnusERP.numeroDecimalesV = Me.txtNumeroDecimalesImporte.EditValue
        eMagnusERP.ServicioFlete = Me.txtServicioFlete.Text
        eMagnusERP.RptEnlaces = Me.btnReporteEnlaceDocumentos.EditValue
        eMagnusERP.Simac = Me.txtSimac.Text
        eMagnusERP.envioProduccion = Me.cheEnvioPedidosProduccion.Checked
        eMagnusERP.detallarLotesSIMAC = Me.cheDetallarLotesSimac.Checked
        'Group de autorización simac
        eMagnusERP.equivalenciasDuplicadas = Me.cheEquivalenciasDuplicadas.Checked
        eMagnusERP.EquivalenciaClientes = Me.cheMostrarSoloEquivalencias.Checked
        Return eMagnusERP
    End Function

    Public Sub LimpiarCampos()
        Me.txtBDMagnus.EditValue = ""
        Me.txtEmpresa.EditValue = ""
        _IdSistema = 0

    End Sub
    Private Sub txtEmpresa_EditValueChanged(sender As Object, e As EventArgs) Handles txtEmpresa.EditValueChanged
        Dim nMagnus As New Negocios.MagnusERP
        Dim eSistemas As New Entidades.Sistema
        eSistemas = nMagnus.CargarEntidadMagnusERP(txtEmpresa.EditValue)
        txtNumeroActivacion.EditValue = eSistemas.Activacion
        _IdSistema = eSistemas.OID
        txtNumeroActivacion.ReadOnly = True
    End Sub
    Public Sub consultarMagnusERP(ByVal row As DataRow)
        Try
            txtNumeroActivacion.ReadOnly = True
            txtEmpresa.ReadOnly = True
            _IdSistema = row("Sistema")
            _idMagnusERP = row("OID")
            Me.txtBDMagnus.EditValue = row("DBMagnus")
            Me.txtEmpresa.EditValue = row("Empresa")

            Me.cheManejaMovil.Checked = row("manejaMovil")
            Me.cheManejaObras.Checked = row("manejaObras")
            Me.cheManejaTransportes.Checked = row("manejaTransportes")
            Me.cheManejaRentas.Checked = row("manejaRenta")
            'eMagnusERP.m  maneja descuento
            Me.txtDescuentoMax.EditValue = row("desMax")
            Me.txtDescuentoFinalMax.EditValue = row("desfinMax")
            'eMagnusERP.ru ruta certificado
            'ruta almacenaje xml
            Me.rgEnvioCorreoAutomatico.EditValue = row("EnvioCorreo")
            Me.cheEditarFormaPago.Checked = row("EditarTipoPago")
            Me.cheFormaPago.Checked = row("FormaPago")
            Me.cheEditarComision.Checked = row("EditarComision")
            Me.cheManejaDescuentoComision.Checked = row("ManejaDescuentoComision")
            Me.cheVenderSobreListaPrecios.Checked = row("ventaSoloListaPrecio")
            Me.cheAutoasignarClaveCliente.Checked = row("AutoAsignarClave")
            Me.cheCuentasComplemento.Checked = row("CuentasComplemento")
            'contabilizar por subdivision
            Me.cheLotes.Checked = row("Lotes")
            Me.cheLotesControlClave.Checked = row("controLotes")
            Me.txtNumeroDecimalesCantidad.EditValue = row("numeroDecimalesC")
            Me.txtValidarCredito.EditValue = row("ValidacionCredito")
            Me.cheEntregarPickingParcial.Checked = row("enlazarParcialPicking")
            Me.chePickingIncrementarUnidadLectura.Checked = row("LecturaPickingIncrementoUnidad")
            Me.cheAgruparTallaDocumentos.Checked = row("AgrupaTallasFactura")
            Me.cheAgregarServicioFleteFactura.Checked = row("ServicioFleteFactura")
            Me.cheImporteCantidadPrecio.Checked = row("cantidadPorPrecio")
            Me.txtNumeroDecimalesImporte.EditValue = row("numeroDecimalesV")
            Me.txtServicioFlete.Text = row("ServicioFlete")
            Me.btnReporteEnlaceDocumentos.EditValue = row("RptEnlaces")
            Me.txtSimac.Text = row("Simac")
            Me.cheEnvioPedidosProduccion.Checked = row("envioProduccion")
            Me.cheDetallarLotesSimac.Checked = row("detallarLotesSIMAC")
            'Group de autorización simac
            Me.cheEquivalenciasDuplicadas.Checked = row("equivalenciasDuplicadas")
            Me.cheMostrarSoloEquivalencias.Checked = row("EquivalenciaClientes")

        Catch ex As Exception
            MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class