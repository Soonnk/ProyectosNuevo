Public Class pConsultarReservaciones
    Public Sub CargarTabla()
        Try
            Dim nReservacion = New Negocios.Reservaciones
            Dim tabla = nReservacion.Consultar()
            GridControl1.DataSource = tabla
        Catch ex As Exception

        End Try
    End Sub
    Public Sub consultarReservacion()
        Try
            Dim row As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frmEditar As New pAgregarReservaciones
            If Not row Is Nothing Then
                frmEditar.modo = pAgregarReservaciones.tipo.Editar
                frmEditar.Text = "Editar Reservacion"
                frmEditar.consultarReservacion(GridView1.GetFocusedDataRow)
                frmEditar.ShowDialog()
            End If


        Catch ex As Exception

        End Try
    End Sub
    Public Sub EliminarReservacion()
        'Dim sacarIdReservaciuon As New Negocios.Reservaciones
        'Try
        '    Dim row As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
        '    Dim _idReservacion As Integer = row("id")
        '    GridView1.DeleteRow(GridView1.FocusedRowHandle)
        '    If sacarIdReservaciuon.Then Then
        '        MessageBox.Show("La habitacion ha sido eliminado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Else
        '        MessageBox.Show("Error al eliminar la habitacion", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End If
        'Catch ex As Exception

        'End Try
    End Sub
    Public modo As tipo
    Private _mdiPrincipal As mdiPrincipal
    Enum tipo
        Nuevo
        Editar
    End Enum
    Private ReadOnly Property mdiPrincipal1() As mdiPrincipal
        Get
            If Me.ParentForm Is Nothing Then
                Return Nothing
            End If

            Return TryCast(Me.ParentForm, mdiPrincipal)
        End Get
    End Property
    Private Sub pConsultarReservaciones_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.mdiPrincipal1.activo = "reservaciones"
            Cargar()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Cargar()
        Throw New NotImplementedException()
    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        'GridControl1.ge
    End Sub
End Class