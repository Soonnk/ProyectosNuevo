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

    Public Sub consultarCliente()
        Try
            Dim row As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frmEditar As New pAgregarClientes
            If Not row Is Nothing Then
                frmEditar.modo = pAgregarClientes.tipo.Editar
                frmEditar.Text = "Editar Cliente"
                frmEditar.consultarCliente(GridView1.GetFocusedDataRow)
                frmEditar.ShowDialog()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Public Sub EliminarCliente()
        Dim sacarIdCliente As New Negocios.Clientes
        Try
            Dim row As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim _idCliente As Integer = row("id")
            GridView1.DeleteRow(GridView1.FocusedRowHandle)
            If sacarIdCliente.BorrarCliente(_idCliente) Then
                MessageBox.Show("El cliente ha sido eliminado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al eliminar el cliente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class