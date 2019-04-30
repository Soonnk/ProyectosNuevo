Public Class ConsultarEmpresa
    Public modo As tipo
    Dim onegocio As New Negocios.Empresa

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
        ConsultarEmpresa()
        Cargar()
    End Sub

    Public Sub ConsultarEmpresa()
        Try
            Dim row As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frmEditar As New AgregarEmpresa
            If Not row Is Nothing Then
                frmEditar.modo = AgregarEmpresa.tipo.Editar
                frmEditar.Text = "Editar Empresa"
                frmEditar.consultarEmpresa(GridView1.GetFocusedDataRow)
                frmEditar.ShowDialog()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ConsultarEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.mdiPrincipal1.activo = "empresas"
        Cargar()
    End Sub

    Public Sub Cargar()
        Dim dt As New DataTable
        Try
            dt = onegocio.Cargar()
            Me.GridControl1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



End Class