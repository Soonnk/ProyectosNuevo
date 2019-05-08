Public Class ConsultarMagnusCONTA
    Dim onegocio As New Negocios.MagnusCONTA
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

    Public Sub Cargar()
        Dim dt As New DataTable
        Try
            dt = onegocio.Cargar()
            Me.GridControl1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub ConsultarMagnusCONTA()
        Try
            Dim row As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frmEditar As New AgregarMagnusCONTA
            If Not row Is Nothing Then
                frmEditar.modo = AgregarMagnusCONTA.tipo.Editar
                frmEditar.Text = "Editar MagnusCONTA"
                'frmEditar.consultarTienda(GridView1.GetFocusedDataRow)
                frmEditar.Show()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ConsultarMagnusCONTA_Load(sender As Object, e As EventArgs) Handles Me.Load
        Cargar()

    End Sub
End Class