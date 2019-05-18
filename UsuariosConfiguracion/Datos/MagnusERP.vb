'Consultas a la base de datos en la tabla Configuracion_Magnus
Public Class MagnusERP

    Dim obj As New clsSQL
    Public ds As DataSet

    Public Function Cargar() As DataTable
        Dim dt As New DataTable
        Dim Query As String
        Try
            Query = "SELECT * FROM Configuracion_Magnus"
            dt = obj.RegresarDatos(Query)
            Return dt
        Finally

        End Try
    End Function

    Public Function CargarEntidadMagnusERP(ByRef _OID As Integer) As Entidades.Sistema
        Dim query As String = "SELECT * FROM Sistemas WHERE Empresa = " & _OID
        Try
            Dim magnusERP As New Entidades.Sistema
            Dim dt As DataTable = obj.RegresarDatos(query)
            With dt.Rows(0)
                magnusERP.OID = .Item("OID")
                magnusERP.Nombre = .Item("Nombre")
                magnusERP.Empresa = .Item("Empresa")
                magnusERP.Codigo = .Item("Codigo")
                magnusERP.Serie = .Item("Serie")
                magnusERP.Activacion = .Item("Activacion")
            End With
            Return magnusERP
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function CargarEmpresa() As DataTable
        Dim dt As New DataTable
        Dim Query As String
        Try
            Query = "SELECT Empresas.OID, Empresas.Nombre from Empresas inner join Sistemas ON Empresas.OID = Sistemas.Empresa Where Sistemas.Nombre = 'Magnus ERP' "
            dt = obj.RegresarDatos(Query)
            Return dt
        Finally

        End Try
    End Function



End Class
