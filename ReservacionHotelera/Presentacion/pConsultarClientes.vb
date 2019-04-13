Public Class pConsultarClientes
    Public modo As tipo
    Private ReadOnly Property mdiPrincipal1() As mdiPrincipal
        Get
            If Me.ParentForm Is Nothing Then
                Return Nothing
            End If

            Return TryCast(Me.ParentForm, mdiPrincipal)
        End Get
    End Property
    Enum tipo
        Nuevo
        Editar
    End Enum
    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        Nuevo()
    End Sub

    Dim ds As DataSet
    Dim onegocio As New Negocios.Clientes
    Public Sub Cargar()
        Dim dt As New DataTable
        Try
            dt = onegocio.Cargar()

            Me.GridControl1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub UpdateBD()
        Try
            onegocio.Update()
            MessageBox.Show("Los datos han sido guardados")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Nuevo()
        Try
            Dim formulario As New pAgregarClientes
            formulario.TipoForma = pAgregarClientes.enuTipoForma.Nuevo
            formulario.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ObtenerId()
        Dim IdCliente As Integer
        Try
            IdCliente = GridView1.GetFocusedRowCellValue("IdCliente")
            Dim formulario As New pAgregarClientes
            formulario.TipoForma = pAgregarClientes.enuTipoForma.Editar
            formulario.Forma = Me
            formulario._IdCliente2 = IdCliente

            formulario.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub pConsultarClientes_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.mdiPrincipal1.activo = "clientes"
        Cargar()
    End Sub
End Class