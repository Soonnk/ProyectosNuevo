﻿Imports System.ComponentModel

Public Class AgregarTienda
    Public modo As tipo
    Private _mdiPrincipal As mdiPrincipal
    Public _IdTienda As Integer
    Enum tipo
        Nuevo
        Editar
    End Enum
    Public ModoForma As enuModoForma

    Public Enum enuModoForma
        Nuevo
        Editar
    End Enum

    Private Sub AgregarTienda_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarEmpresas()
        CargarDB()
        CargarAlmacen()
        TipoReporte()
    End Sub

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

    Public Sub CargarDB()
        Dim oNegocioEmpresa As New Negocios.Tienda
        Try
            Me.txtBasePV.Properties.DataSource = oNegocioEmpresa.GetDB
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            oNegocioEmpresa = Nothing
        End Try
    End Sub

    Public Sub CargarAlmacen()
        Dim oNegocioEmpresa As New Negocios.Tienda
        Try
            Me.txtAlmacen.Properties.DataSource = oNegocioEmpresa.CargarAlmacen
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            oNegocioEmpresa = Nothing
        End Try
    End Sub

    Public Sub CargarFolioAlmacen()
        Dim oNegocioEmpresa As New Negocios.Tienda
        Try
            'If Not txtFolio.EditValue Is Nothing Then Exit Sub
            Me.txtFolio.Properties.DataSource = oNegocioEmpresa.CargarFolioAlmacen(txtAlmacen.EditValue)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            oNegocioEmpresa = Nothing
        End Try
    End Sub

    Public Sub TipoReporte()
        Try
            Dim tipos As DataTable = New DataTable
            tipos.Columns.Add("Tipo")
            tipos.Columns.Add("Descripcion")
            tipos.Rows.Add("Ticket", "Ticket")
            tipos.Rows.Add("TicketEspera", "Ticket en Espera")
            tipos.Rows.Add("SalidaDinero", "Salida de Dinero")
            tipos.Rows.Add("Ventas", "Total de Ventas")
            tipos.Rows.Add("Productos", "Venta de Productos")
            tipos.Rows.Add("Corte", "Corte de Caja")
            tipos.Rows.Add("VentasCorte", "Lista de Ventas en corte")
            tipos.Rows.Add("Cortes", "Lista de Cortes")
            tipos.Rows.Add("Factura", "Factura")
            tipos.Rows.Add("Traspasos", "Traspasos")
            tipos.Rows.Add("VentasDetalle", "Ventas Detalle")
            tipos.Rows.Add("Devoluciones", "Devoluciones")
            tipos.Rows.Add("Salidas", "Salidas")
            tipos.Rows.Add("DevolucionesUtilizadas", "Devoluciones Utilizadas")
            tipos.Rows.Add("FormasPago", "Formas de Pago")
            Me.txtTipoReporte.Properties.DataSource = tipos
            Me.txtTipoReporte.Properties.DisplayMember = "Descripcion"
            Me.txtTipoReporte.Properties.ValueMember = "Tipo"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub GuardarTienda()
        Dim oNegocio As New Negocios.Tienda
        Try
            Dim camposVacios As String = ""
            Select Case modo
                Case tipo.Nuevo
                    'If Not ValidarCampos(camposVacios) Then Exit Sub
                    If oNegocio.InsertarTienda(llenarEntidades) = True Then
                        MessageBox.Show("Los datos han sido guardados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'CType(Owner, ConsultarMagnusGo).Cargar()
                        LimpiarCampos()
                    Else
                        MessageBox.Show("No se han podido guardar los datos solicitados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Case tipo.Editar
                    'If Not ValidarCampos(camposVacios) Then Exit Sub
                    If oNegocio.EditarTienda(llenarEntidades2) = True Then
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


    'Pendiente de agregar en capas anteriores

    'Private Sub GuardarReporte()
    '    Try
    '        Dim oNegocio As New Negocios.Tienda
    '        Dim camposVacios As String = ""
    '        If Not ValidarCampos(camposVacios) Then Exit Sub
    '        If oNegocio.InsertarReporte(llenarEntidadesReporte) = True Then
    '            MessageBox.Show("El reporte ha sido guardado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            CType(Owner, GridControl1).Cargar()
    '            LimpiarCamposReporte()
    '        Else
    '            MessageBox.Show("No se han podido guardar lel reporte solicitado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub


    'Public Function ValidarCampos(ByVal camposVacios As String) As Boolean
    '    Try
    '        camposVacios = "Los siguientes campos esta vacios:" & Chr(10)
    '        Dim resultado As Boolean = True
    '        If Not txtTipoReporte.EditValue <> "" Then
    '            camposVacios &= "Tipo reporte" & Chr(10)
    '            resultado = False
    '        End If
    '        If resultado = False Then
    '            MessageBox.Show(camposVacios, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            Return False
    '        Else
    '            Return True
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Function

    Public Function llenarEntidades() As Entidades.Tienda
        Dim eTienda As New Entidades.Tienda
        eTienda.Descripcion = Me.txtDescripcion.Text
        eTienda.IdAlmacen = Me.txtAlmacen.EditValue
        eTienda.IdFolio = Me.txtFolio.Text
        eTienda.BasePuntoVenta = Me.txtBasePV.Text
        eTienda.PrecioMinimoVenta = Me.cmbPrecioMinV.Text
        eTienda.Empresa = Me.txtEmpresa.EditValue
        Return eTienda
    End Function

    Public Function llenarEntidades2() As Entidades.Tienda
        Dim eTienda As New Entidades.Tienda
        eTienda.OID = _IdTienda
        eTienda.BasePuntoVenta = Me.txtBasePV.EditValue
        eTienda.Descripcion = Me.txtDescripcion.EditValue
        eTienda.IdAlmacen = Me.txtAlmacen.EditValue
        eTienda.IdFolio = Me.txtFolio.EditValue
        eTienda.PrecioMinimoVenta = Me.cmbPrecioMinV.EditValue
        eTienda.Empresa = Me.txtEmpresa.EditValue
        Return eTienda
    End Function


    '    Pendiente agregar en capas anteriores
    'Public Function llenarEntidadesReporte() As Entidades.Tienda
    '    Dim eTienda As New Entidades.Tienda
    '    'Pendiente agregar en capas anteriores
    '    eTienda.NombreReporte = Me.txtNombreReporte.Text
    '    eTienda.TipoReporte = Me.txtTipoReporte.Text
    '    Return eTienda
    'End Function

    Public Sub LimpiarCampos()
        txtBasePV.EditValue = ""
        txtDescripcion.EditValue = ""
        txtAlmacen.EditValue = ""
        txtFolio.EditValue = ""
        cmbPrecioMinV.EditValue = ""
        txtNombreReporte.EditValue = ""
        txtTipoReporte.EditValue = ""
        txtEmpresa.EditValue = ""
    End Sub

    Public Sub LimpiarCamposReporte()
        txtNombreReporte.EditValue = ""
        txtTipoReporte.EditValue = ""
    End Sub

    Public Sub Cargar()
        Try
            Select Case modo
                Case tipo.Nuevo
                    Me.Text = "Agregar Tienda"
                Case tipo.Editar
                    Me.Text = "Editar Tienda"
                    CargarTienda()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub CargarTienda()
        Dim oNegocio As New Negocios.Tienda
        Dim oEntidad As New Entidades.Tienda
        Try
            oEntidad = oNegocio.CargarTienda(_IdTienda)

            Me.txtBasePV.Text = oEntidad.BasePuntoVenta
            Me.txtDescripcion.Text = oEntidad.Descripcion
            Me.txtAlmacen.Text = oEntidad.IdAlmacen
            Me.txtFolio.Text = oEntidad.IdFolio
            Me.cmbPrecioMinV.Text = oEntidad.PrecioMinimoVenta
            Me.txtEmpresa.Text = oEntidad.Empresa
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            oNegocio = Nothing
        End Try
    End Sub

    Public Sub consultarTienda(ByVal row As DataRow)
        Try
            _IdTienda = row("OID")
            txtBasePV.EditValue = row("BasePuntoVenta")
            txtDescripcion.EditValue = row("Descripcion")
            txtAlmacen.EditValue = row("idAlmacen")
            txtFolio.EditValue = row("idFolio")
            cmbPrecioMinV.EditValue = row("PrecioMinimoVenta")
            txtEmpresa.EditValue = row("Empresa")
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ConsultarMagnusGo()
        Dim obj As New ConsultarMagnusGo
        Try
            Dim row As DataRow = obj.GridView1.GetDataRow(obj.GridView1.FocusedRowHandle)
            Dim frmEditar As New AgregarTienda
            If Not row Is Nothing Then
                frmEditar.modo = AgregarTienda.tipo.Editar
                frmEditar.Text = "Editar Tienda"
                frmEditar.consultarTienda(obj.GridView1.GetFocusedDataRow)
                frmEditar.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtFolio_QueryPopUp(sender As Object, e As CancelEventArgs) Handles txtFolio.QueryPopUp
        CargarFolioAlmacen()
    End Sub

    Public Function GuardarArchivo() As Boolean
        Try
            Select Case ModoForma
                Case enuModoForma.Editar
                    Me.CurrentTienda.Reportes.Add(Me.GeneraObjReporte(Me.GetArchivoBytes, Me.CurrentTienda.Session))
                Case enuModoForma.Nuevo
                    Me.tienda.Reportes.Add(Me.GeneraObjReporte(Me.GetArchivoBytes, Me.tienda.Session))
            End Select
            Me.txtTipoReporte.EditValue = Nothing
            Me.txtNombreReporte.EditValue = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Public Function GeneraObjReporte(ByVal FileBytes() As Byte) As Entidades.ReportesPuntoVenta
        Try
            Dim ReportePV As New Entidades.ReportesPuntoVenta()
            If Me.txtTipoReporte.EditValue Is Nothing Then
                MsgBox("No has capturado un tipo", MsgBoxStyle.Exclamation, "Tiendas")
            Else
                ReportePV.Tipo = Me.txtTipoReporte.EditValue
                'ReportePV.Archivo = FileBytes
                ReportePV.Nombre = Me.txtNombreReporte.EditValue
                ReportePV.FechaModificacion = Date.Now
            End If
            Return ReportePV
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Sub AbrirReporte()
        Try
            Dim CurrentReporte As New Entidades.ReportesPuntoVenta(Me.CurrentTienda.Session)
            CurrentReporte = Me.GridViewReportes.GetFocusedRow
            Dim ds As New DsTicket
            Dim stream As New IO.MemoryStream(CurrentReporte.Archivo)
            Dim report As New DevExpress.XtraReports.UI.XtraReport
            report = DevExpress.XtraReports.UI.XtraReport.FromStream(stream, True)
            'If CurrentReporte.Nombre = "Ticket" Then
            '    report.DataSource = ds
            '    report.DataMember = "Datos"
            'End If
            report.ShowRibbonDesigner()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEditarReporte_Click(sender As Object, e As EventArgs) Handles btnEditarReporte.Click
        Try
            Me.AbrirReporte()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCargarArchivo_Click(sender As Object, e As EventArgs) Handles btnCargarArchivo.Click
        Try
            Dim CurrentReporte As New Entidades.ReportesPuntoVenta(Me.CurrentTienda.Session)
            CurrentReporte = Me.GridViewReportes.GetFocusedRow
            CurrentReporte.Archivo = Me.GetArchivoBytes
            CurrentReporte.FechaModificacion = Date.Now
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Function GetArchivoBytes() As Byte()
        Try
            Dim myStream As System.IO.Stream = Nothing
            If WindowOpen.ShowDialog() = DialogResult.OK Then
                myStream = WindowOpen.OpenFile()
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