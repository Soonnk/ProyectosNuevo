Public Class pConsultarHabitaciones
    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        Nuevo()
    End Sub

    Dim ds As DataSet
    Dim hnegocio As New Negocios.Habitaciones

    Public Sub Cargar()
        Dim dt As New DataTable
        Try
            dt = hnegocio.Cargar()
            Me.GridControl1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub UpdateBD()
        Try
            hnegocio.Update()
            MessageBox.Show("Datos guardados")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Nuevo()
        Try
            Dim formulario As New pAgregarHabitaciones
            formulario.TipoForma = pAgregarHabitaciones.enuTipoForma.Agregar
            formulario.ShowDialog()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ObtenerId()
        Dim Id As Integer
        Try
            Id = GridView1.GetFocusedRowCellValue("Id")
            Dim formulario As New pAgregarHabitaciones
            formulario.TipoForma = pAgregarHabitaciones.enuTipoForma.Modificar
            formulario._Id2 = Id

            formulario.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pConsultarHabitaciones_Load(sender As Object, e As EventArgs) Handles Me.Load
        Cargar()
    End Sub
End Class