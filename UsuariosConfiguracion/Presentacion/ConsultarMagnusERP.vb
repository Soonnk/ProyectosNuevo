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
End Class