Public Class ConsultarMagnusGo
    Dim onegocio As New Negocios.Tienda
    Public modo As tipo
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


    Private Sub ConsultarEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.mdiPrincipal1.activo = "magnusgo"
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

    Public Sub ConsultarMagnusGo()
        Try
            Dim row As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frmEditar As New AgregarTienda
            If Not row Is Nothing Then
                'frmEditar.modo = AgregarTienda.tipo.Editar
                frmEditar.Text = "Editar Empresa"
                'frmEditar.consultarEmpresa(GridView1.GetFocusedDataRow)
                frmEditar.ShowDialog()
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class