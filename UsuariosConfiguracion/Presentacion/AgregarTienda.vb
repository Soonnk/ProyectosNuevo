Imports System.ComponentModel

Public Class AgregarTienda
    Public modo As tipo
    Private _mdiPrincipal As mdiPrincipal
    Enum tipo
        Nuevo
        Editar
    End Enum

    Private Sub AgregarTienda_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarDB()
        CargarAlmacen()
        TipoReporte()
    End Sub

    Public Sub CargarDB()
        Try
            Dim oNegocioEmpresa As New Negocios.Tienda
            Me.txtBasePV.Properties.DataSource = oNegocioEmpresa.GetDB
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub CargarAlmacen()
        Try
            Dim oNegocioEmpresa As New Negocios.Tienda
            Me.txtAlmacen.Properties.DataSource = oNegocioEmpresa.CargarAlmacen
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub CargarFolioAlmacen()
        Try
            Dim oNegocioEmpresa As New Negocios.Tienda
            'If Not txtFolio.EditValue Is Nothing Then Exit Sub
            Me.txtFolio.Properties.DataSource = oNegocioEmpresa.CargarFolioAlmacen(txtAlmacen.EditValue)
        Catch ex As Exception
            MsgBox(ex.Message)
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



    Private Sub txtFolio_QueryPopUp(sender As Object, e As CancelEventArgs) Handles txtFolio.QueryPopUp
        CargarFolioAlmacen()
    End Sub
End Class