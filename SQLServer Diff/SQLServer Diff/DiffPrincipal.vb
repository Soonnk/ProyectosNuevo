Imports Negocios
Public Class DiffPrincipal
    Private _padre As Form
    Public WriteOnly Property Padre() As Form
        Set(value As Form)
            Me._padre = value
        End Set
    End Property

    Private conn1 As ConnSettings
    Private conn2 As ConnSettings

    Private conector1 As Conector
    Private conector2 As Conector

    Private tablasIguales As DataTable
    Private tablasDiferentes As DataTable

    Private camposDiferentes As DataTable
    Private camposFaltantes As DataTable

    Public Structure ConnSettings
        Public server As String
        Public user As String
        Public pass As String
        Public db As String
    End Structure

    Public Sub SetConn1(ByVal server As String, ByVal user As String, ByVal pass As String, ByVal db As String)
        With conn1
            .server = server
            .user = user
            .pass = pass
            .db = db
        End With
    End Sub
    Public Sub SetConn2(ByVal server As String, ByVal user As String, ByVal pass As String, ByVal db As String)
        With conn2
            .server = server
            .user = user
            .pass = pass
            .db = db
        End With
    End Sub

    Private Sub DiffPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With conn1
            conector1 = New Conector(.server, .user, .pass, .db)
        End With

        With conn2
            conector2 = New Conector(.server, .user, .pass, .db)
        End With

        Me.tablasDiferentes = New DataTable
        Me.tablasIguales = New DataTable
        Me.camposDiferentes = New DataTable
        Me.camposFaltantes = New DataTable

        CargarTablasFaltantes()
    End Sub

    Private Sub CargarTablasFaltantes()
        Dim comparador = New Comparador(conector1.ConsultarTablas, conector2.ConsultarTablas)
        comparador.CompararTablas()

        tablasIguales = comparador.Iguales

        Comparador.AgregarColumnas(tablasDiferentes)

        For Each r As DataRow In comparador.SoloOrigen.Rows
            ConstruirTabla(r)
            tablasDiferentes.Rows.Add(r.ItemArray)
        Next

        For Each r As DataRow In comparador.SoloDestino.Rows
            tablasDiferentes.Rows.Add(r.ItemArray)
        Next

        gcTablasFaltantes.DataSource = tablasDiferentes

        CompararTablas(tablasIguales)
    End Sub

    Public Sub ConstruirTabla(ByRef dr As DataRow)
        Dim campos = New Conector(conn1.server, conn1.user, conn1.pass, conn1.db).ConsultarCampos(dr.Item("Object").ToString)

        Dim columnas(campos.Rows.Count) As String
        Dim tipos(campos.Rows.Count) As String

        For i = 0 To campos.Rows.Count - 1
            Dim columna = campos.Rows(i).Item("name").ToString()
            columna = columna.Split(CType(".", Char))(1)

            columnas(i) = columna
            tipos(i) = GeneradorScript.DefineType(campos.Rows(i))
        Next

        dr.Item("CorrectionScript") = GeneradorScript.CreateTable(dr.Item("Object").ToString, columnas, tipos)
    End Sub

    Public Sub CompararTablas(ByVal tablas As DataTable)
        Dim comparador As Comparador

        Dim camposDiferentes = New DataTable

        Comparador.AgregarColumnas(Me.camposDiferentes)

        For Each r As DataRow In tablas.Rows
            comparador = New Comparador(conector1.ConsultarCampos(r.Item("Object").ToString), conector2.ConsultarCampos(r.Item("Object").ToString))
            comparador.CompararCampos()
            camposDiferentes = comparador.Diferentes
            For Each sr As DataRow In camposDiferentes.Rows
                Me.camposDiferentes.Rows.Add(sr.ItemArray)
            Next

            Me.camposFaltantes = concatenarTablas(comparador.SoloOrigen, comparador.SoloDestino)
        Next
        gcCamposDistintos.DataSource = Me.camposDiferentes
        gcCamposFaltantes.DataSource = Me.camposFaltantes
    End Sub

    Public Function concatenarTablas(ByVal t1 As DataTable, ByVal t2 As DataTable) As DataTable
        Dim dt = New DataTable

        Comparador.AgregarColumnas(dt)

        For Each sr As DataRow In t1.Rows
            dt.Rows.Add(sr.ItemArray)
        Next
        For Each sr As DataRow In t2.Rows
            dt.Rows.Add(sr.ItemArray)
        Next

        Return dt

    End Function

    Private Sub gcTablasFaltantes_DoubleClick(sender As Object, e As EventArgs) Handles gcTablasFaltantes.DoubleClick
        MostrarScriptDeObjeto(GridView3)
    End Sub

    Private Sub gcCamposDistintos_DoubleClick(sender As Object, e As EventArgs) Handles gcCamposDistintos.DoubleClick
        MostrarScriptDeObjeto(GridView2)
    End Sub

    Private Sub gcCamposFaltantes_DoubleClick(sender As Object, e As EventArgs) Handles gcCamposFaltantes.DoubleClick
        MostrarScriptDeObjeto(GridView1)
    End Sub

    Private Sub MostrarScriptDeObjeto(ByVal grid As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim row As DataRow
        row = grid.GetFocusedDataRow
        Dim scriptView As New ScriptView(row.Item("CorrectionScript").ToString)

        scriptView.ShowDialog()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GenerarScript()
    End Sub

    Private Sub GenerarScript()
        Dim script As String

        script = "--Se recomienda hacer una revision de este script previo a correrlo en su base de datos" & Environment.NewLine & Environment.NewLine

        If (tablasDiferentes.Rows.Count > 0) Then
            script += "--CORRECCION DE TABLAS FALTANTES Y SOBREANTES" & Environment.NewLine
            For Each r As DataRow In tablasDiferentes.Rows
                script += r.Item("CorrectionScript").ToString & Environment.NewLine & Environment.NewLine
            Next
        End If
        If (camposDiferentes.Rows.Count > 0) Then
            script += "--CORRECCION DE TIPOS DE DATOS DE LOS CAMPOS" & Environment.NewLine
            For Each r As DataRow In camposDiferentes.Rows
                script += r.Item("CorrectionScript").ToString & Environment.NewLine & Environment.NewLine
            Next
        End If
        If (camposFaltantes.Rows.Count > 0) Then
            script += "--CORRECCION DE CAMPOS EN LAS TABLAS EXISTENTES" & Environment.NewLine
            For Each r As DataRow In camposFaltantes.Rows
                script += r.Item("CorrectionScript").ToString & Environment.NewLine & Environment.NewLine
            Next
        End If
        Dim view = New ScriptView(script)
        view.Show()
    End Sub

    Private Sub DiffPrincipal_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        _padre.Close()
    End Sub
End Class