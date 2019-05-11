Public Class DiffPrincipal
    Public ERROR_VERIFICATION As String = "IF @@ERROR<>0 OR @@TRANCOUNT=0 BEGIN IF @@TRANCOUNT>0 ROLLBACK SET NOEXEC ON END" & Environment.NewLine &
                              "GO" & Environment.NewLine & Environment.NewLine
    Private _padre As Form

    Private listaCaso1 As New List(Of Entidad.SQLObject)
    Private listaCaso2 As New List(Of Entidad.SQLObject)
    Private listaCaso3 As New List(Of Entidad.SQLObject)
    Private listaCaso4 As New List(Of Entidad.SQLObject)

    Public WriteOnly Property Padre() As Form
        Set(value As Form)
            Me._padre = value
        End Set
    End Property

    Private conexion1 As Negocio.Loader.Conexion
    Private conexion2 As Negocio.Loader.Conexion

    Private loader As Negocio.Loader

    Public WriteOnly Property ConexionModelo As Negocio.Loader.Conexion
        Set(value As Negocio.Loader.Conexion)
            conexion1 = value
        End Set
    End Property
    Public WriteOnly Property ConexionDestino As Negocio.Loader.Conexion
        Set(value As Negocio.Loader.Conexion)
            conexion2 = value
        End Set
    End Property

    Private Sub DiffPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loader = New Negocio.Loader(conexion1, conexion2)

        CargarObjetosFaltantes()
        CargarObjetosSobrantes()
    End Sub

    Private Sub CargarObjetosFaltantes()
        Dim lista = New List(Of Entidad.SQLObject)
        lista = Negocio.Comparador.GetCreatableObjects(loader.Modelo, loader.Destino)

        For Each o In Negocio.Comparador.GetComparableObjects(loader.Modelo, loader.Destino)
            Dim tablaModelo = DirectCast(o.Modelo, Entidad.Tabla)
            Dim tablaDestino = DirectCast(o.Destino, Entidad.Tabla)

            Dim camposCreables = Negocio.Comparador.GetCreatableObjects(tablaModelo.CamposSQLObject, tablaDestino.CamposSQLObject)

            lista.AddRange(camposCreables)
        Next
        gcTablasFaltantes.DataSource = lista
    End Sub

    Private Sub CargarObjetosSobrantes()
        Dim lista = New List(Of Entidad.SQLObject)
        lista = Negocio.Comparador.GetDroppableObjects(loader.Modelo, loader.Destino)

        For Each o In Negocio.Comparador.GetComparableObjects(loader.Modelo, loader.Destino)
            Dim tablaModelo = DirectCast(o.Modelo, Entidad.Tabla)
            Dim tablaDestino = DirectCast(o.Destino, Entidad.Tabla)

            Dim camposCreables = Negocio.Comparador.GetDroppableObjects(tablaModelo.CamposSQLObject, tablaDestino.CamposSQLObject)

            Dim listaCamposComparables = Negocio.Comparador.GetComparableObjects(tablaModelo.CamposSQLObject, tablaDestino.CamposSQLObject)

            CompararCampos(listaCamposComparables)

            lista.AddRange(camposCreables)
        Next
        gcCamposDistintos.DataSource = lista
    End Sub

    Private Sub CompararCampos(listaCamposComparables As IEnumerable(Of Object))
        For Each c In listaCamposComparables
            Dim caso = Negocio.Comparador.CompareFields(c.Modelo, c.Destino)

            Select Case (caso)
                Case Negocio.Comparador.DifferenceType.SimpleAlter
                    listaCaso1.Add(DirectCast(c.Modelo, Entidad.Campo))
                Case Negocio.Comparador.DifferenceType.AlterDrop
                    listaCaso2.Add(DirectCast(c.Modelo, Entidad.Campo))
                Case Negocio.Comparador.DifferenceType.IdentityCorrection
                    listaCaso3.Add(DirectCast(c.Modelo, Entidad.Campo))
                Case Negocio.Comparador.DifferenceType.TableRebuild
                    listaCaso4.Add(DirectCast(c.Modelo, Entidad.Campo))
            End Select

        Next
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GenerarScript()
    End Sub

    Private Sub GenerarScript()

        Dim script As String

        script = "--Se recomienda hacer una revision de este script previo a correrlo en su base de datos" & Environment.NewLine & Environment.NewLine
        script += "BEGIN TRAN" & Environment.NewLine &
                    "GO" & Environment.NewLine &
                    "SET ANSI_NULLS OFF" & Environment.NewLine &
                    "GO" & Environment.NewLine

        For Each o As Entidad.SQLObject In loader.Destino
            Dim t = DirectCast(o, Entidad.Tabla)
            For Each i As Entidad.Index In t.Indices
                script += ERROR_VERIFICATION
                script += i.Drop() & Environment.NewLine & Environment.NewLine
            Next
            For Each i As Entidad.Constraint In t.Constraints
                If TypeOf i IsNot Entidad.PrimaryKey Then
                    script += ERROR_VERIFICATION
                    script += i.Drop() & Environment.NewLine & Environment.NewLine
                End If
            Next
        Next

        For Each o As Entidad.SQLObject In loader.Destino
            Dim t = DirectCast(o, Entidad.Tabla)
            For Each i As Entidad.Constraint In t.Constraints
                If TypeOf i Is Entidad.PrimaryKey Then
                    script += ERROR_VERIFICATION
                    script += i.Drop() & Environment.NewLine & Environment.NewLine
                End If
            Next
        Next

        For Each o As Entidad.SQLObject In gcTablasFaltantes.DataSource
            script += ERROR_VERIFICATION
            script += o.Create() & Environment.NewLine & Environment.NewLine
        Next

        For Each o As Entidad.SQLObject In gcCamposDistintos.DataSource
            script += ERROR_VERIFICATION
            script += o.Drop() & Environment.NewLine & Environment.NewLine
        Next

        For Each o In listaCaso1
            script += ERROR_VERIFICATION
            script += DirectCast(o, Entidad.Campo).Alter & Environment.NewLine & Environment.NewLine
        Next
        For Each o In listaCaso2
            script += ERROR_VERIFICATION
            script += DirectCast(o, Entidad.Campo).Alter & Environment.NewLine
        Next
        For Each o In listaCaso3
            script += ERROR_VERIFICATION
            script += DirectCast(o, Entidad.Campo).DropIdentity & Environment.NewLine
        Next
        For Each o In listaCaso4
            script += ERROR_VERIFICATION
            script += DirectCast(o, Entidad.Campo).Tabla.Rebuild & Environment.NewLine
        Next

        For Each o As Entidad.SQLObject In loader.Modelo
            If TypeOf o Is Entidad.Tabla Then
                For Each i As Entidad.Constraint In DirectCast(o, Entidad.Tabla).Constraints
                    If TypeOf i Is Entidad.PrimaryKey Then
                        script += ERROR_VERIFICATION
                        script += i.Create() & Environment.NewLine & Environment.NewLine
                    End If
                Next
            End If
        Next

        For Each o As Entidad.SQLObject In loader.Modelo
            Dim t = DirectCast(o, Entidad.Tabla)
            For Each i As Entidad.Constraint In t.Constraints
                If TypeOf i IsNot Entidad.PrimaryKey Then
                    script += ERROR_VERIFICATION
                    script += i.Create() & Environment.NewLine & Environment.NewLine
                End If
            Next

            For Each i As Entidad.Index In t.Indices
                script += ERROR_VERIFICATION
                script += i.Create() & Environment.NewLine & Environment.NewLine
            Next
        Next

        script += ERROR_VERIFICATION &
        "IF @@TRANCOUNT>0" & Environment.NewLine &
        "COMMIT" & Environment.NewLine &
        "SET NOEXEC OFF" & Environment.NewLine &
        "GO" & Environment.NewLine

        Dim view = New ScriptView(script)
        view.Show()
    End Sub

    Private Sub DiffPrincipal_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        _padre.Close()
    End Sub
End Class