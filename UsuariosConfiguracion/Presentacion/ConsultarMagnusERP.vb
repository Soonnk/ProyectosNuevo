Public Class ConsultarMagnusERP
    Dim onegocio As New Negocios.MagnusERP
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


    Private Sub ConsultarMagnusERP_Activated(sender As Object, e As EventArgs) Handles Me.Activated
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