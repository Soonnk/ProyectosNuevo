Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Public Class AgregarSIMAC
    Public modo As tipo
    Private _mdiPrincipal As mdiPrincipal
    Public _IdSimac As Integer
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

    Private Sub AgregarSIMAC_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarDB()

        TipoReporte()
        txtNumeroActivacion.ReadOnly = True

        If modo = tipo.Nuevo Then
            Me.GroupControl8.Enabled = False
            CargarEmpresas()
        Else
            CargarEmpresa()
            Me.GroupControl8.Enabled = True
            CargarReporte()
        End If

    End Sub

    Private Sub CargarEmpresas()
        Dim dt As New DataTable
        Dim nEmpresa As New Negocios.SIMAC
        Try
            dt = nEmpresa.CargarEmpresas
            Me.txtEmpresa.Properties.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
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
            Me.txtBDSimac.Properties.DataSource = oNegocioSimac.GetDB
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
            tipos.Rows.Add("Etiqueta", "Etiqueta")
            tipos.Rows.Add("Orden", "Orden")
            tipos.Rows.Add("OrdenPiezas", "Orden de Piezas")
            tipos.Rows.Add("Produccion", "Produccion")
            tipos.Rows.Add("PreasignacionCelulas", "Preasignacion de Celulas")
            tipos.Rows.Add("HojaCosto", "Hoja de costo")
            tipos.Rows.Add("Avance", "Avance")
            tipos.Rows.Add("Embarque", "Embarque")
            tipos.Rows.Add("ListaEmbarque", "Lista de Embarque")
            tipos.Rows.Add("HojaCostoProv", "Hoja costo prov")
            tipos.Rows.Add("ProductosExplosion", "Productos explosión")
            tipos.Rows.Add("Pedido", "Pedido")
            tipos.Rows.Add("ConcentradoMateriales", "Concentrado de materiales")
            tipos.Rows.Add("Formulas", "Formulas")
            tipos.Rows.Add("ExplosionFormulas", "Explosión de formulas")
            Me.txtTipoReporte.Properties.DataSource = tipos
            Me.txtTipoReporte.Properties.DisplayMember = "Descripcion"
            Me.txtTipoReporte.Properties.ValueMember = "Tipo"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub GuardarSIMAC()
        Dim oNegocio As New Negocios.SIMAC
        Try
            Dim camposVacios As String = ""
            Select Case modo
                Case tipo.Nuevo
                    'If Not ValidarCampos(camposVacios) Then Exit Sub
                    If oNegocio.InsertarSIMAC(llenarEntidades) = True Then
                        MessageBox.Show("Los datos han sido guardados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LimpiarCampos()
                    Else
                        MessageBox.Show("No se han podido guardar los datos solicitados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Case tipo.Editar
                    'If Not ValidarCampos(camposVacios) Then Exit Sub
                    If oNegocio.EditarSimac(llenarEntidades2) = True Then
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

    Public Function llenarEntidades() As Entidades.SIMAC
        Dim eSimac As New Entidades.SIMAC
        eSimac.DBSimac = Me.txtBDSimac.EditValue
        eSimac.Empresa = Me.txtEmpresa.EditValue
        eSimac.Sistema = _IdSistema
        eSimac.ManejaTenerias = Me.cheManejaTenerias.Checked
        eSimac.MaxLote = Me.txtDefaultMaximoLote.EditValue
        eSimac.CalculoDesperdicio = Me.cheModuloCalculoDesperdicio.Checked
        eSimac.editarCostoDestaje = Me.cheEditarCostoPagoDestajos.Checked
        eSimac.editarCantidadDestajo = Me.cheEditarCantidadPagoDestajos.Checked
        eSimac.DestajosAvance = Me.cheSaldarDestajosAvanzar.Checked
        eSimac.MinutosSemanales = Me.txtMinutoSemanales.EditValue
        eSimac.Tabla1 = Me.txtTabla1.Text
        eSimac.Tabla2 = Me.txtTabla2.Text
        eSimac.Tabla3 = Me.txtTabla3.Text
        eSimac.Tabla4 = Me.txtTabla4.Text
        eSimac.Tabla5 = Me.txtTabla5.Text
        eSimac.Tabla6 = Me.txtTabla6.Text
        eSimac.Tabla7 = Me.txtTabla7.Text
        eSimac.Tabla8 = Me.txtTabla8.Text
        eSimac.Tabla9 = Me.txtTabla9.Text
        eSimac.Tabla10 = Me.txtTabla10.Text
        eSimac.Tabla11 = Me.txtTabla11.Text
        eSimac.Tabla12 = Me.txtTabla12.Text
        eSimac.FolioPedidoA = Me.txtFolioPedidoA.EditValue
        eSimac.FolioPedidoB = Me.txtFolioPedidoB.EditValue
        eSimac.FolioOrdenA = Me.txtFolioOrdenA.EditValue
        eSimac.FolioOrdenB = Me.txtFolioOrdenB.EditValue
        eSimac.ValidadSuPedido = Me.cheValidarPedido.Checked
        eSimac.AutPedido = Me.cheAutorizarPedidosProduccion.Checked
        eSimac.PedProdAutorizado = Me.cheCargarSoloProductosAutorizados.Checked
        eSimac.ProgBase = Me.cheProgramarSistemaBase.Checked
        eSimac.EntregaParcial = cheEntregaParcial.Checked
        eSimac.dividirLote = Me.cheDividirLotes.Checked
        eSimac.CantAvance = Me.cheSolicitarCantidadAvance.Checked
        eSimac.AutoAvance = Me.cheAvanceAutomatico.Checked
        eSimac.FechaAvance = Me.cheFechaAvance.Checked
        eSimac.ValidaUnidad = Me.cheValidaUnidad.Checked
        eSimac.avancePorProceso = Me.cheAvanceProceso.Checked
        eSimac.avanceNoValidarProg = Me.cheNoValidarFechaProgramacion.Checked
        eSimac.MultiAlmacen = Me.cheMultialmacen.Checked
        eSimac.MaterialAlmacen = Me.txtAlmacenMateriaPrima.EditValue
        eSimac.ProductoAlmacen = Me.txtAlmacenProductoTerminado.EditValue
        Return eSimac
    End Function

    Public Function llenarEntidades2() As Entidades.SIMAC
        Dim eSimac As New Entidades.SIMAC
        eSimac.OID = _IdSimac
        eSimac.DBSimac = Me.txtBDSimac.EditValue
        eSimac.Empresa = Me.txtEmpresa.EditValue
        eSimac.Sistema = _IdSistema
        eSimac.ManejaTenerias = Me.cheManejaTenerias.Checked
        eSimac.MaxLote = Me.txtDefaultMaximoLote.Text
        eSimac.CalculoDesperdicio = Me.cheModuloCalculoDesperdicio.Checked
        eSimac.editarCostoDestaje = Me.cheEditarCostoPagoDestajos.Checked
        eSimac.editarCantidadDestajo = Me.cheEditarCantidadPagoDestajos.Checked
        eSimac.DestajosAvance = Me.cheSaldarDestajosAvanzar.Checked
        eSimac.MinutosSemanales = Me.txtMinutoSemanales.Text
        eSimac.Tabla1 = Me.txtTabla1.Text
        eSimac.Tabla2 = Me.txtTabla2.Text
        eSimac.Tabla3 = Me.txtTabla3.Text
        eSimac.Tabla4 = Me.txtTabla4.Text
        eSimac.Tabla5 = Me.txtTabla5.Text
        eSimac.Tabla6 = Me.txtTabla6.Text
        eSimac.Tabla7 = Me.txtTabla7.Text
        eSimac.Tabla8 = Me.txtTabla8.Text
        eSimac.Tabla9 = Me.txtTabla9.Text
        eSimac.Tabla10 = Me.txtTabla10.Text
        eSimac.Tabla11 = Me.txtTabla11.Text
        eSimac.Tabla12 = Me.txtTabla12.Text
        eSimac.FolioPedidoA = Me.txtFolioPedidoA.Text
        eSimac.FolioPedidoB = Me.txtFolioPedidoB.Text
        eSimac.FolioOrdenA = Me.txtFolioOrdenA.Text
        eSimac.FolioOrdenB = Me.txtFolioOrdenB.Text
        eSimac.ValidadSuPedido = Me.cheValidarPedido.Checked
        eSimac.AutPedido = Me.cheAutorizarPedidosProduccion.Checked
        eSimac.PedProdAutorizado = Me.cheCargarSoloProductosAutorizados.Checked
        eSimac.ProgBase = Me.cheProgramarSistemaBase.Checked
        eSimac.EntregaParcial = cheEntregaParcial.Checked
        eSimac.dividirLote = Me.cheDividirLotes.Checked
        eSimac.CantAvance = Me.cheSolicitarCantidadAvance.Checked
        eSimac.AutoAvance = Me.cheAvanceAutomatico.Checked
        eSimac.FechaAvance = Me.cheFechaAvance.Checked
        eSimac.ValidaUnidad = Me.cheValidaUnidad.Checked
        eSimac.avancePorProceso = Me.cheAvanceProceso.Checked
        eSimac.avanceNoValidarProg = Me.cheNoValidarFechaProgramacion.Checked
        eSimac.MultiAlmacen = Me.cheMultialmacen.Checked
        eSimac.MaterialAlmacen = Me.txtAlmacenMateriaPrima.Text
        eSimac.ProductoAlmacen = Me.txtAlmacenProductoTerminado.Text
        Return eSimac
    End Function

    Public Sub LimpiarCampos()
        Me.txtBDSimac.EditValue = ""
        Me.txtEmpresa.EditValue = ""
        _IdSistema = 0
        Me.cheManejaTenerias.Checked = False
        Me.txtDefaultMaximoLote.EditValue = ""
        Me.cheModuloCalculoDesperdicio.Checked = False
        Me.cheEditarCostoPagoDestajos.Checked = False
        Me.cheEditarCantidadPagoDestajos.Checked = False
        Me.cheSaldarDestajosAvanzar.Checked = False
        Me.txtMinutoSemanales.EditValue = ""
        Me.txtTabla1.EditValue = ""
        Me.txtTabla2.EditValue = ""
        Me.txtTabla3.EditValue = ""
        Me.txtTabla4.EditValue = ""
        Me.txtTabla5.EditValue = ""
        Me.txtTabla6.EditValue = ""
        Me.txtTabla7.EditValue = ""
        Me.txtTabla8.EditValue = ""
        Me.txtTabla9.EditValue = ""
        Me.txtTabla10.EditValue = ""
        Me.txtTabla11.EditValue = ""
        Me.txtTabla12.EditValue = ""
        Me.txtFolioPedidoA.EditValue = ""
        Me.txtFolioPedidoB.EditValue = ""
        Me.txtFolioOrdenA.EditValue = ""
        Me.txtFolioOrdenB.EditValue = ""
        Me.cheValidarPedido.Checked = False
        Me.cheAutorizarPedidosProduccion.Checked = False
        'Falta Pedidos: cargar solo productos autorizados.
        Me.cheProgramarSistemaBase.Checked = False
        cheEntregaParcial.Checked = False
        Me.cheDividirLotes.Checked = False
        Me.cheSolicitarCantidadAvance.Checked = False
        Me.cheAvanceAutomatico.Checked = False
        Me.cheFechaAvance.Checked = False
        Me.cheValidaUnidad.Checked = False
        Me.cheAvanceProceso.Checked = False
        Me.cheNoValidarFechaProgramacion.Checked = False
        Me.cheMultialmacen.Checked = False
        Me.txtAlmacenMateriaPrima.EditValue = ""
        Me.txtAlmacenProductoTerminado.EditValue = ""
    End Sub

    Public Sub consultarSIMAC(ByVal row As DataRow)
        Try
            txtNumeroActivacion.ReadOnly = True
            txtEmpresa.ReadOnly = True
            _IdSimac = row("OID")
            Me.txtBDSimac.EditValue = row("DBSimac")
            Me.txtEmpresa.EditValue = row("Empresa")
            _IdSistema = row("Sistema")
            Me.cheManejaTenerias.Checked = row("ManejaTenerias")
            Me.txtDefaultMaximoLote.EditValue = row("MaxLote")
            Me.cheModuloCalculoDesperdicio.Checked = row("CalculoDesperdicio")
            Me.cheEditarCostoPagoDestajos.Checked = row("editarCostoDestaje")
            Me.cheEditarCantidadPagoDestajos.Checked = row("editarCantidadDestajo")
            Me.cheSaldarDestajosAvanzar.Checked = row("DestajosAvance")
            Me.txtMinutoSemanales.EditValue = row("MinutosSemanales")
            Me.txtTabla1.EditValue = row("Tabla1")
            Me.txtTabla2.EditValue = row("Tabla2")
            Me.txtTabla3.EditValue = row("Tabla3")
            Me.txtTabla4.EditValue = row("Tabla4")
            Me.txtTabla5.EditValue = row("Tabla5")
            Me.txtTabla6.EditValue = row("Tabla6")
            Me.txtTabla7.EditValue = row("Tabla7")
            Me.txtTabla8.EditValue = row("Tabla8")
            Me.txtTabla9.EditValue = row("Tabla9")
            Me.txtTabla10.EditValue = row("Tabla10")
            Me.txtTabla11.EditValue = row("Tabla11")
            Me.txtTabla12.EditValue = row("Tabla12")
            Me.txtFolioPedidoA.EditValue = row("FolioPedidoA")
            Me.txtFolioPedidoB.EditValue = row("FolioPedidoB")
            Me.txtFolioOrdenA.EditValue = row("FolioOrdenA")
            Me.txtFolioOrdenB.EditValue = row("FolioOrdenB")
            Me.cheValidarPedido.Checked = row("ValidadSuPedido")
            Me.cheAutorizarPedidosProduccion.Checked = row("AutPedido")
            Me.cheCargarSoloProductosAutorizados.Checked = row("PedProdAutorizado")
            Me.cheProgramarSistemaBase.Checked = row("ProgBase")
            Me.cheEntregaParcial.Checked = row("EntregaParcial")
            Me.cheDividirLotes.Checked = row("dividirLote")
            Me.cheSolicitarCantidadAvance.Checked = row("CantAvance")
            Me.cheAvanceAutomatico.Checked = row("AutoAvance")
            Me.cheFechaAvance.Checked = row("FechaAvance")
            Me.cheValidaUnidad.Checked = row("ValidaUnidad")
            Me.cheAvanceProceso.Checked = row("avancePorProceso")
            Me.cheNoValidarFechaProgramacion.Checked = row("avanceNoValidarProg")
            Me.cheMultialmacen.Checked = row("MultiAlmacen")
            Me.txtAlmacenMateriaPrima.EditValue = row("MaterialAlmacen")
            Me.txtAlmacenProductoTerminado.EditValue = row("ProductoAlmacen")
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtEmpresa_EditValueChanged(sender As Object, e As EventArgs) Handles txtEmpresa.EditValueChanged
        Dim nSimac As New Negocios.SIMAC
        Dim eSistemas As New Entidades.Sistema
        eSistemas = nSimac.CargarEntidadSIMAC(txtEmpresa.EditValue)
        txtNumeroActivacion.EditValue = eSistemas.Activacion
        _IdSistema = eSistemas.OID
        txtNumeroActivacion.ReadOnly = True
    End Sub


    Public Function GeneraObjReporte(ByVal FileBytes() As Byte) As Entidades.ReporteSIMAC
        Dim _Clave As New Integer
        Try
            Dim ReporteSimac As New Entidades.ReporteSIMAC()
            If ModoForma = enuModoForma.Editar Then
                Dim dt As DataRow
                dt = Me.GridView1.GetDataRow(GridView1.FocusedRowHandle)
                _Clave = dt("OID")
                ReporteSimac.Tipo = dt("Tipo")
                ReporteSimac.Archivo = FileBytes
                ReporteSimac.Nombre = dt("Nombre")
                ReporteSimac.FechaModificacion = Date.Now
                ReporteSimac.SIMAC = _IdSimac
                ReporteSimac.OID = _Clave
            Else
                If Me.txtTipoReporte.EditValue Is Nothing Then
                    MsgBox("No has capturado un tipo", MsgBoxStyle.Exclamation, "Tiendas")
                Else
                    ReporteSimac.Tipo = Me.txtTipoReporte.EditValue
                    ReporteSimac.Archivo = FileBytes
                    ReporteSimac.Nombre = Me.txtNombreReporte.EditValue
                    ReporteSimac.FechaModificacion = Date.Now
                    ReporteSimac.SIMAC = _IdSimac
                End If
            End If
            Return ReporteSimac
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub AbrirReporte()
        Try
            Dim CurrentReporte As DataRow
            CurrentReporte = Me.GridView1.GetFocusedDataRow
            If CurrentReporte.IsNull("Archivo") Then Exit Sub

            Dim ds As New DsTicket
            Dim stream As New IO.MemoryStream(CurrentReporte.Item("Archivo"), True)
            Dim report As New XtraReport
            report = XtraReport.FromStream(stream, True)
            If CurrentReporte.Item("Tipo") = "Etiqueta" Then
                report.DataSource = ds
                report.DataMember = "Etiqueta"
            End If
            If CurrentReporte.Item("Tipo") = "Orden" Then
                report.DataSource = ds
                report.DataMember = "Orden"
            End If
            If CurrentReporte.Item("Tipo") = "OrdenPiezas" Then
                report.DataSource = ds
                report.DataMember = "OrdenPiezas"
            End If
            If CurrentReporte.Item("Tipo") = "Produccion" Then
                report.DataSource = ds
                report.DataMember = "Produccion"
            End If
            If CurrentReporte.Item("Tipo") = "PreasignacionCelulas" Then
                report.DataSource = ds
                report.DataMember = "PreasignacionCelulas"
            End If
            If CurrentReporte.Item("Tipo") = "HojaCosto" Then
                report.DataSource = ds
                report.DataMember = "HojaCosto"
            End If
            If CurrentReporte.Item("Tipo") = "Avance" Then
                report.DataSource = ds
                report.DataMember = "Avance"
            End If
            If CurrentReporte.Item("Tipo") = "Embarque" Then
                report.DataSource = ds
                report.DataMember = "Embarque"
            End If
            If CurrentReporte.Item("Tipo") = "ListaEmbarque" Then
                report.DataSource = ds
                report.DataMember = "ListaEmbarque"
            End If
            If CurrentReporte.Item("Tipo") = "HojaCostoProv" Then
                report.DataSource = ds
                report.DataMember = "HojaCostoProv"
            End If
            If CurrentReporte.Item("Tipo") = "ProductosExplosion" Then
                report.DataSource = ds
                report.DataMember = "ProductosExplosion"
            End If
            If CurrentReporte.Item("Tipo") = "Pedido" Then
                report.DataSource = ds
                report.DataMember = "Pedido"
            End If
            If CurrentReporte.Item("Tipo") = "ConcentradoMateriales" Then
                report.DataSource = ds
                report.DataMember = "ConcentradoMateriales"
            End If
            If CurrentReporte.Item("Tipo") = "Formulas" Then
                report.DataSource = ds
                report.DataMember = "Formulas"
            End If
            If CurrentReporte.Item("Tipo") = "ExplosionFormulas" Then
                report.DataSource = ds
                report.DataMember = "ExplosionFormulas"
            End If
            report.ShowRibbonDesigner
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGuardarReporte_Click(sender As Object, e As EventArgs) Handles btnGuardarReporte.Click
        Try
            ModoForma = enuModoForma.Nuevo
            GuardarArchivo()
        Catch ex As Exception

        End Try
    End Sub

    Public Function GuardarArchivo() As Boolean
        Dim nSimac As New Negocios.SIMAC
        Try
            Select Case ModoForma
                Case enuModoForma.Editar
                    nSimac.EditarReporteSIMAC(Me.GeneraObjReporte(GetArchivoBytes))
                    CargarReporte()
                    'Me.tienda.Reportes.Add(Me.GeneraObjReporte(Me.GetArchivoBytes, Me.tienda.Session))
                Case enuModoForma.Nuevo
                    nSimac.GuardarReporteSIMAC(Me.GeneraObjReporte(GetArchivoBytes()))
                    CargarReporte()
            End Select
            Me.txtTipoReporte.EditValue = Nothing
            Me.txtNombreReporte.EditValue = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Private Sub CargarReporte()
        Dim neg As New Negocios.SIMAC
        Dim dt As New DataTable

        dt = neg.CargarReporteSIMAC(_IdSimac)
        GridControl1.DataSource = dt
    End Sub


    Public Function GetArchivoBytes() As Byte()
        Try
            Dim opend As New OpenFileDialog
            Dim result As New DialogResult
            result = opend.ShowDialog
            Dim myStream As System.IO.Stream = Nothing
            If result = DialogResult.OK Then
                myStream = opend.OpenFile()
            Else
                Return Nothing
            End If
            Dim FileBytes(CInt(myStream.Length)) As Byte
            myStream.Read(FileBytes, 0, FileBytes.Length)
            Return FileBytes
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

End Class