Public Class mdiPrincipal
    Public activo As String

    Private ReadOnly Property Empresa() As ConsultarEmpresa
        Get
            If Me.ActiveMdiChild Is Nothing Then
                Return Nothing
            End If
            Return TryCast(Me.ActiveMdiChild, ConsultarEmpresa)
        End Get
    End Property

    Private ReadOnly Property Sistema() As ConsultarSistemas
        Get
            If Me.ActiveMdiChild Is Nothing Then
                Return Nothing
            End If
            Return TryCast(Me.ActiveMdiChild, ConsultarSistemas)
        End Get
    End Property


    Private Sub btnEmpresas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEmpresas.ItemClick
        Try
            Dim f As ConsultarEmpresa = BuscarFormulario(Me.RibbonControl1.Pages.Item(0).Tag, Me.RibbonControl1.Pages.Item(0).Groups(0).Tag, Me.RibbonControl1.Pages.Item(0).Groups(0).ItemLinks(0).Item.Tag)

            If Object.Equals(f, Nothing) Then
                Dim frmEmpresas As New ConsultarEmpresa
                frmEmpresas.MdiParent = Me
                frmEmpresas.Show()
            Else : f.Activate
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnSistemas_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSistemas.ItemClick
        Try
            Dim f As ConsultarSistemas = BuscarFormulario(Me.RibbonControl1.Pages.Item(0).Tag, Me.RibbonControl1.Pages.Item(0).Groups(0).Tag, Me.RibbonControl1.Pages.Item(0).Groups(0).ItemLinks(1).Item.Tag)
            If Object.Equals(f, Nothing) Then
                Dim frmSistemas As New ConsultarSistemas
                frmSistemas.MdiParent = Me
                frmSistemas.Show()
            Else : f.Activate
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnMagnusERP_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMagnusERP.ItemClick
        Try
            'Dim f As ConsultarMagnusERP = BuscarFormulario(Me.RibbonControl1.Pages.Item(0).Tag, Me.RibbonControl1.Pages.Item(0).Groups(1).Tag, Me.RibbonControl1.Pages.Item(0).Groups(1).ItemLinks(0).Item.Tag)
            'If Object.Equals(f, Nothing) Then
            '    Dim frmMagnusERP As New ConsultarMagnusERP
            '    frmMagnusERP.MdiParent = Me
            '    frmMagnusERP.Show()
            'Else : f.Activate
            'End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnMagnusCONTA_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMagnusCONTA.ItemClick
        Try
            'Dim f As ConsultarMagnusCONTA = BuscarFormulario(Me.RibbonControl1.Pages.Item(0).Tag, Me.RibbonControl1.Pages.Item(0).Groups(1).Tag, Me.RibbonControl1.Pages.Item(0).Groups(1).ItemLinks(1).Item.Tag)
            'If Object.Equals(f, Nothing) Then
            '    Dim frmSistemas As New ConsultarSistemas
            '    frmSistemas.MdiParent = Me
            '    frmSistemas.Show()
            'Else : f.Activate
            'End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSIMAC_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnSIMAC.ItemClick
        Try
            'Dim f As ConsultarSIMAC = BuscarFormulario(Me.RibbonControl1.Pages.Item(0).Tag, Me.RibbonControl1.Pages.Item(0).Groups(1).Tag, Me.RibbonControl1.Pages.Item(0).Groups(1).ItemLinks(2).Item.Tag)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnMagnusGo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnMagnusGo.ItemClick
        Try
            Dim f As ConsultarMagnusGo = BuscarFormulario(Me.RibbonControl1.Pages.Item(0).Tag, Me.RibbonControl1.Pages.Item(0).Groups(1).Tag, Me.RibbonControl1.Pages.Item(0).Groups(1).ItemLinks(3).Item.Tag)
            If Object.Equals(f, Nothing) Then
                Dim frmMagnusGo As New ConsultarMagnusGo
                frmMagnusGo.MdiParent = Me
                frmMagnusGo.Show()
            Else : f.Activate()
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btnNuevoSuperior_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnNuevoSuperior.ItemClick
        Try
            Dim frmActivo As Form = Me.ActiveMdiChild
            If frmActivo Is Nothing Then Return
            Select Case RibbonControl1.SelectedPage.Text
                Case "Configuración"
                    Select Case frmActivo.Name
                        Case "ConsultarEmpresa"
                            Dim frmNuevo As New AgregarEmpresa
                            frmNuevo.modo = AgregarEmpresa.tipo.Nuevo
                            frmNuevo.Owner = Empresa
                            frmNuevo.ShowDialog()
                        Case "ConsultarSistemas"
                            Dim frmNuevo As New AgregarSistema
                            frmNuevo.modo = AgregarSistema.tipo.Nuevo
                            frmNuevo.Owner = Sistema
                            frmNuevo.ShowDialog()
                        Case "ConsultarMagnusGo"
                            Dim frmNuevo As New AgregarTienda
                            frmNuevo.modo = AgregarTienda.tipo.Nuevo
                            frmNuevo.Owner = Sistema
                            frmNuevo.ShowDialog()
                    End Select
                Case "Usuarios"
                    Select Case frmActivo.Name

                    End Select
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub btnEditarSuperior_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnEditarSuperior.ItemClick
        Try
            Dim frmActivo As Form = Me.ActiveMdiChild
            If frmActivo Is Nothing Then Return
            Select Case RibbonControl1.SelectedPage.Text
                Case "Configuración"
                    Select Case frmActivo.Name
                        Case "ConsultarEmpresa"
                            Dim frmEditar As New ConsultarEmpresa
                            frmEditar.modo = ConsultarEmpresa.tipo.Editar
                            frmEditar = frmActivo
                            frmEditar.ConsultarEmpresa()
                        Case "ConsultarSistemas"
                            Dim frmEditar As New ConsultarSistemas
                            frmEditar.modo = ConsultarSistemas.tipo.Editar
                            frmEditar = frmActivo
                            frmEditar.ConsultarSistema()
                        Case "ConsultarMagnusGo"
                            Dim frmEditar As New ConsultarMagnusGo
                            frmEditar.modo = ConsultarMagnusGo.tipo.Editar
                            frmEditar = frmActivo
                            frmEditar.ConsultarMagnusGo()
                    End Select
                Case "Usuarios"
                    Select Case frmActivo.Name

                    End Select
            End Select
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub
    Public Function BuscarFormulario(ByVal pestaña As Integer, ByVal grupo As Integer, ByVal boton As String)
        Dim f As Form
        Dim exist As Boolean
        Try
            Select Case pestaña
                Case 1000
                    Select Case grupo
                        Case 1100
                            Select Case boton
                                Case 1110
                                    For Each f In Me.MdiChildren
                                        If Object.Equals(f.GetType(), GetType(ConsultarEmpresa)) Then
                                            exist = True
                                            Exit For
                                        End If
                                    Next
                                Case 1120
                                    For Each f In Me.MdiChildren
                                        If Object.Equals(f.GetType(), GetType(ConsultarSistemas)) Then
                                            exist = True
                                            Exit For
                                        End If
                                    Next
                            End Select
                        Case 1200
                            Select Case boton
                                Case 1240
                                    For Each f In Me.MdiChildren
                                        If Object.Equals(f.GetType(), GetType(ConsultarMagnusGo)) Then
                                            exist = True
                                            Exit For
                                        End If
                                    Next
                            End Select
                    End Select
                Case 2000
            End Select
            If exist Then
                Return f
            Else : Return Nothing
            End If
        Catch ex As Exception

        End Try
    End Function
End Class