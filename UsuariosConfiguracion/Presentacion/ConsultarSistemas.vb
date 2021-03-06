﻿Public Class ConsultarSistemas
    Dim onegocio As New Negocios.Sistema
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

    Private Sub ConsultarSistemas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.mdiPrincipal1.activo = "sistemas"
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
    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        ConsultarSistema()
        Cargar()
    End Sub

    Public Sub ConsultarSistema()
        Try
            Dim row As DataRow = GridView1.GetDataRow(GridView1.FocusedRowHandle)
            Dim frmEditar As New AgregarSistema
            If Not row Is Nothing Then
                frmEditar.modo = AgregarSistema.tipo.Editar
                frmEditar.Text = "Editar Sistema"
                frmEditar.consultarSistema(GridView1.GetFocusedDataRow)
                frmEditar.ShowDialog()
                Cargar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class