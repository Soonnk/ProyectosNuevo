Public Class AgregarMagnusERP
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

    Private Sub AgregarMagnusERP_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarEmpresas()
        CargarDB()

    End Sub

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

End Class