Imports Entidad
Public Class Comparador
    Private objetosPorCrear As List(Of SQLObject)
    Public ReadOnly Property PorCrear() As List(Of SQLObject)
        Get
            Return objetosPorCrear
        End Get
    End Property
    Private objetosPorDropear As List(Of SQLObject)
    Public ReadOnly Property PorDropear() As List(Of SQLObject)
        Get
            Return objetosPorDropear
        End Get
    End Property
    Public Sub New()
        objetosPorCrear = New List(Of SQLObject)
        objetosPorDropear = New List(Of SQLObject)
    End Sub
    Public Sub Comparar(ByVal objetosModelo As List(Of SQLObject), ByVal objetosDestino As List(Of SQLObject))
        For Each obj As SQLObject In objetosModelo
            If TypeOf obj Is Tabla Then
                Dim o = Buscar(obj, objetosDestino)
                If (o Is Nothing) Then
                    objetosPorCrear.Add(obj)
                    objetosModelo.Remove(obj)
                End If
            End If
        Next
        For Each obj As SQLObject In objetosDestino
            If TypeOf obj Is Tabla Then
                Dim o = Buscar(obj, objetosDestino)
                If (o Is Nothing) Then
                    objetosPorDropear.Add(obj)
                    objetosDestino.Remove(obj)
                Else
                End If
            End If
        Next
        For Each obj As SQLObject In objetosModelo
            Dim objM = DirectCast(obj, Tabla)
            Dim objD = DirectCast(Buscar(obj, objetosDestino), Tabla)
            'Comparar(objM.Campos, objD.Campos)
        Next
    End Sub
    Private Function Buscar(ByRef busqueda As SQLObject, ByRef lista As List(Of SQLObject)) As SQLObject
        For Each obj As SQLObject In lista
            If (obj.Nombre.Equals(busqueda.Nombre)) Then
                Return obj
            End If
        Next
        Return Nothing
    End Function

    '-------------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------------
    '-------------------------------------------------------------------------------------------------------------------

    Public Shared Function GetCreatableObjects(
                                              listaModelo As List(Of SQLObject),
                                              listaDestino As List(Of SQLObject)
                                              ) As List(Of SQLObject)
        'Dim lista = From o In listaModelo
        '            From d In listaDestino
        '            Where o.Nombre <> d.Nombre And d.Nombre <> Nothing
        '            Select o
        Dim lista = From a In listaModelo Where Not listaDestino.Contains(a) Select a

        If (lista IsNot Nothing AndAlso lista.LongCount > 0) Then
            Return lista.ToList
        Else
            Return New List(Of SQLObject)
        End If
    End Function

    Public Shared Function GetDroppableObjects(
                                              listaModelo As List(Of SQLObject),
                                              listaDestino As List(Of SQLObject)
                                              ) As List(Of SQLObject)
        Dim lista = From a In listaDestino Where Not listaModelo.Contains(a) Select a

        If (lista IsNot Nothing AndAlso lista.LongCount > 0) Then
            Return lista.ToList
        Else
            Return New List(Of SQLObject)
        End If
    End Function

    Public Shared Function GetComparableObjects(
                                               listaModelo As List(Of SQLObject),
                                               listaDestino As List(Of SQLObject)
                                               ) As Object
        Dim lista = From modelo In listaModelo
                    From destino In listaDestino
                    Where modelo.Nombre = destino.Nombre
                    Select modelo, destino
        If (lista IsNot Nothing) Then
            Return lista.ToList
        Else
            Return Nothing
        End If
    End Function

    Public Enum DifferenceType
        NoDifference = 0
        SimpleAlter = 1
        AlterDrop = 2
        IdentityCorrection = 3
        TableRebuild = 4
    End Enum

    Public Shared Function CompareFields(
                                        ByRef campoModelo As Campo,
                                        ByRef campoDestino As Campo
                                        ) As DifferenceType
        If (campoModelo.Identity And Not campoDestino.Identity) Then
            Return DifferenceType.TableRebuild
        End If
        If (Not campoModelo.Identity And campoDestino.Identity) Then
            Return DifferenceType.IdentityCorrection
        End If
        If Not campoModelo.Nullable And campoDestino.Nullable Then
            Return DifferenceType.AlterDrop
        End If
        If (Not campoModelo.Tipo.Equals(campoDestino.Tipo) _
            Or campoModelo.Longitud <> campoDestino.Longitud _
            Or campoModelo.Precision <> campoDestino.Precision _
            Or campoModelo.Escala <> campoDestino.Escala) Then
            Return DifferenceType.SimpleAlter
        End If
        Return DifferenceType.NoDifference
    End Function
End Class
