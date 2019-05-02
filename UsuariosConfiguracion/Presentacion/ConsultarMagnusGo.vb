﻿Public Class ConsultarMagnusGo
    Dim onegocio As New Negocios.Tienda
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
End Class