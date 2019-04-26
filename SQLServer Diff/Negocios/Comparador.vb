''' <summary>
''' Clase que provee de los metodos necesarios para comparar las Datatables que contengan las tablas de una base de datos
''' o bien las columnas de tablas especificas
''' </summary>
Public Class Comparador
    Private dt1 As DataTable
    Private dt2 As DataTable

    Private dtSolo1 As DataTable
    Private dtSolo2 As DataTable
    Private dtIguales As DataTable
    Private dtDiferentes As DataTable

    Public Sub New(ByRef dt1 As DataTable, ByRef dt2 As DataTable)
        Me.dt1 = dt1
        Me.dt2 = dt2

        dtSolo1 = New DataTable
        dtSolo2 = New DataTable
        dtIguales = New DataTable
        dtDiferentes = New DataTable

        AgregarColumnas(dtSolo1)
        AgregarColumnas(dtSolo2)
        AgregarColumnas(dtIguales)
        AgregarColumnas(dtDiferentes)
    End Sub

    Public Sub CompararTablas()
        While dt1.Rows.Count > 0 And dt2.Rows.Count > 0
            Dim order = CompararRow(dt1.Rows(0), dt2.Rows(0), "name")

            If order = 0 Then
                With dt1.Rows(0)
                    dtIguales.Rows.Add(.Item("objeto"), .Item("name"), "", "")
                End With
                dt1.Rows.RemoveAt(0)
                dt2.Rows.RemoveAt(0)
            ElseIf order < 0 Then
                With dt1.Rows(0)
                    'Dim campos() = GenerarCamposString(.Item("name"))
                    'Dim correccion = GeneradorScript.CreateTable(.Item("name"), campos,)

                    dtSolo1.Rows.Add(.Item("objeto"), .Item("name"), "Tabla Solo Existe en Modelo", "")
                End With
                dt1.Rows.RemoveAt(0)
            Else
                With dt2.Rows(0)
                    Dim correccion = GeneradorScript.DropTable(.Item("name"))

                    dtSolo2.Rows.Add(.Item("objeto"), .Item("name"), "Tabla Solo Existe en Destino", correccion)
                End With
                dt2.Rows.RemoveAt(0)
            End If

        End While
        While dt1.Rows.Count > 0
            With dt1.Rows(0)
                dtSolo1.Rows.Add(.Item("objeto"), .Item("name"), "Tabla Solo Existe en Modelo", "")
                dt1.Rows.RemoveAt(0)
            End With
        End While
        While dt2.Rows.Count > 0
            With dt2.Rows(0)
                Dim correccion = GeneradorScript.DropTable(.Item("name"))

                dtSolo2.Rows.Add(.Item("objeto"), .Item("name"), "Tabla Solo Existe en Destino", correccion)
                dt2.Rows.RemoveAt(0)
            End With
        End While
    End Sub

    Public Sub CompararCampos()
        While dt1.Rows.Count > 0 And dt2.Rows.Count > 0
            Dim order = CompararRow(dt1.Rows(0), dt2.Rows(0), "name")
            If order = 0 Then
                If CompararTipo(dt1.Rows(0), dt2.Rows(0)) Then
                    With dt1.Rows(0)
                        dtIguales.Rows.Add(.Item("objeto"), .Item("name"), "", "")
                    End With
                Else
                    With dt1.Rows(0)
                        Dim correccion As String

                        correccion = GeneradorScript.ModifyColumn(.Item("name"), GeneradorScript.DefineType(dt1.Rows(0)))

                        dtDiferentes.Rows.Add(.Item("objeto"), .Item("name"), "Cambia el tipo de dato", correccion)
                    End With
                End If

                dt1.Rows.RemoveAt(0)
                dt2.Rows.RemoveAt(0)
            ElseIf order < 0 Then
                With dt1.Rows(0)
                    Dim correccion As String

                    correccion = GeneradorScript.CreateColumn(.Item("name"), GeneradorScript.DefineType(dt1.Rows(0)))

                    dtSolo1.Rows.Add(.Item("objeto"), .Item("name"), "Columna Solo Existe en Modelo", correccion)

                    dt1.Rows.RemoveAt(0)
                End With
            Else
                With dt1.Rows(0)
                    Dim correccion = GeneradorScript.DropColumn(.Item("name"))

                    dtSolo2.Rows.Add(.Item("objeto"), .Item("name"), "Columna Solo Existe en Destino", correccion)

                    dt2.Rows.RemoveAt(0)
                End With
            End If
        End While
        While dt1.Rows.Count > 0
            With dt1.Rows(0)
                Dim correccion As String

                correccion = GeneradorScript.CreateColumn(.Item("name"), GeneradorScript.DefineType(dt1.Rows(0)))

                dtSolo1.Rows.Add(.Item("objeto"), .Item("name"), "Columna Solo Existe en Modelo", correccion)
                dt1.Rows.RemoveAt(0)
            End With
        End While
        While dt2.Rows.Count > 0
            With dt2.Rows(0)
                Dim correccion = GeneradorScript.DropTable(.Item("name"))

                dtSolo2.Rows.Add(.Item("objeto"), .Item("name"), "Columna Solo Existe en Destino", correccion)
                dt2.Rows.RemoveAt(0)
            End With
        End While
    End Sub

    Private Function CompararRow(ByRef dr1 As DataRow, ByRef dr2 As DataRow, ByVal field As String) As Integer
        Return String.Compare(dr1.Item(field), dr2.Item(field))
    End Function

    Private Function CompararRow(ByRef dr1 As DataRow, ByRef dr2 As DataRow, ByVal field As Int16) As Integer
        Return dr1.Item(field).Equals(dr2.Item(field))
    End Function

    Private Function CompararTipo(ByRef dr1 As DataRow, ByRef dr2 As DataRow) As Boolean
        If Not dr1.Item("type").Equals(dr2.Item("type")) Then
            Return False
        ElseIf Not dr1.Item("longitud").Equals(dr2.Item("longitud")) Then
            Return False
        ElseIf Not dr1.Item("precision").Equals(dr2.Item("precision")) Then
            Return False
        ElseIf Not dr1.Item("scale").Equals(dr2.Item("scale")) Then
            Return False
        End If
        Return True
    End Function

    'Public Function GenerarCamposString(ByVal name As String) As String()
    '    Dim con = New

    'End Function
    '--------------------------------------Encapsulados y Herramientas para construccion----------------------------------
    Public ReadOnly Property Iguales() As DataTable
        Get
            Return dtIguales
        End Get
    End Property
    Public ReadOnly Property Diferentes() As DataTable
        Get
            Return dtDiferentes
        End Get
    End Property
    Public ReadOnly Property SoloOrigen() As DataTable
        Get
            Return dtSolo1
        End Get
    End Property
    Public ReadOnly Property SoloDestino() As DataTable
        Get
            Return dtSolo2
        End Get
    End Property

    Public Shared Sub AgregarColumnas(ByRef dt As DataTable)
        dt.Columns.Add("ObjectType")
        dt.Columns.Add("Object")
        dt.Columns.Add("Error")
        dt.Columns.Add("CorrectionScript")
    End Sub

End Class
