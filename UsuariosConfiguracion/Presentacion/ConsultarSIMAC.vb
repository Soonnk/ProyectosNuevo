Public Class ConsultarSIMAC
    Dim onegocio As New Negocios.SIMAC
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
    Private Sub ConsultarSIMAC_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Cargar()
    End Sub

    Public Sub ConsultarSIMAC()
        Try
            Dim row As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frmEditar As New AgregarSIMAC
            If Not row Is Nothing Then
                frmEditar.modo = AgregarSIMAC.tipo.Editar
                frmEditar.Text = "Editar SIMAC"
                frmEditar.consultarSIMAC(GridView1.GetFocusedDataRow)
                frmEditar.MdiParent = mdiPrincipal
                frmEditar.Show()
                Cargar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        ConsultarSIMAC()
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