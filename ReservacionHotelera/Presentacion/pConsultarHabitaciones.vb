Public Class pConsultarHabitaciones
    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub
    Public Sub consultarHabitacion()
        Try
            Dim row As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frmEditar As New pAgregarHabitaciones
            If Not row Is Nothing Then
                frmEditar.modo = pAgregarHabitaciones.tipo.Editar
                frmEditar.Text = "Editar Habitacion"
                frmEditar.consultarHabitacion(GridView1.GetFocusedDataRow)
                frmEditar.ShowDialog()
            End If


        Catch ex As Exception

        End Try
    End Sub
    Private _mdiPrincipal As mdiPrincipal
    Private ReadOnly Property mdiPrincipal1() As mdiPrincipal
        Get
            If Me.ParentForm Is Nothing Then
                Return Nothing
            End If

            Return TryCast(Me.ParentForm, mdiPrincipal)
        End Get
    End Property
    Private Sub pConsultarHabitaciones_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.mdiPrincipal1.activo = "habitaciones"

        Catch ex As Exception

        End Try


    End Sub
End Class