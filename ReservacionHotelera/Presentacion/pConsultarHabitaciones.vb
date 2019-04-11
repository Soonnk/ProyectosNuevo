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
            Cargar()

        Catch ex As Exception

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

End Class