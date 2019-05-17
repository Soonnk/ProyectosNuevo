Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Public Class AgregarSIMAC
    Public modo As tipo
    Private _mdiPrincipal As mdiPrincipal
    Public _IdSimac As Integer
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
        CargarEmpresas()

        If modo = tipo.Nuevo Then
            Me.GroupControl8.Enabled = False
        Else
            'CargarReporte()
            Me.GroupControl8.Enabled = True
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

End Class