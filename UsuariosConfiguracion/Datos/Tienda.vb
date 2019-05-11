﻿Public Class Tienda
    Dim obj As New clsSQL
    Public ds As DataSet

    Public Function Cargar() As DataTable
        Dim dt As New DataTable
        Dim Query As String
        Try
            Query = "SELECT * FROM Tiendas"
            dt = obj.RegresarDatos(Query)
            Return dt
        Finally

        End Try
    End Function

    Public Function CargarTiendas(ByVal _OID) As Entidades.Tienda
        Dim query As String = "SELECT * FROM Tiendas WHERE OID = " & _OID
        Try
            Dim oTienda As New Entidades.Tienda
            Dim dt As DataTable = obj.RegresarDatos(query)
            With dt.Rows(0)
                oTienda.Descripcion = .Item("Descripcion")
                oTienda.IdAlmacen = .Item("idAlmacen")
                oTienda.IdFolio = .Item("idFolio")
                oTienda.Factura = .Item("Factura")
                oTienda.BasePuntoVenta = .Item("BasePuntoVenta")
                oTienda.BaseMagnus = .Item("BaseMagnus")
                oTienda.ServidorLocal = .Item("ServidorLocal")
                oTienda.ServidorRemoto = .Item("ServidorRemoto")
                oTienda.UsuarioLocal = .Item("UsuarioLocal")
                oTienda.UsuarioRemoto = .Item("UsuarioRemoto")
                oTienda.PasswordLocal = .Item("PasswordLocal")
                oTienda.PasswordRemoto = .Item("PasswordRemoto")
                oTienda.DynDns = .Item("DynDns")
                oTienda.PrecioMinimoVenta = .Item("PrecioMinimoVenta")
                oTienda.FacturarPrecioMinimo = .Item("FacturarPrecioMinimo")
                oTienda.Empresa = .Item("Empresa")
                oTienda.MuestraExistencia = .Item("MuestraExistencia")
            End With
            Return oTienda
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Function InsertarTienda(ByRef tienda As Entidades.Tienda) As Boolean
        Dim Query As String
        Dim _OID = obj.Incrementar("Tiendas")
        Try
            Query = "INSERT INTO Tiendas(OID,Descripcion,
                                        idAlmacen,idFolio,
                                        BasePuntoVenta,
					                    PrecioMinimoVenta,Empresa) VALUES
                                        (" & _OID & ",'" & tienda.Descripcion & "',
                                        '" & tienda.IdAlmacen & "','" & tienda.IdFolio & "',
                                        '" & tienda.BasePuntoVenta & "',
                                        '" & tienda.PrecioMinimoVenta & "','" & tienda.Empresa & "')"

            Return obj.commandSQL(Query)
        Catch ex As Exception
            MsgBox(ex)
            Return False
        End Try
    End Function

    Public Function EditarTienda(ByRef tienda As Entidades.Tienda) As Boolean
        Dim Query As String
        With tienda
            Query = "UPDATE Tiendas SET
                                         Descripcion = '" & .Descripcion & "', idAlmacen = '" & .IdAlmacen & "',
                                         idFolio = '" & .IdFolio & "', Factura = '" & .Factura & "',
                                         BasePuntoVenta = '" & .BasePuntoVenta & "', BaseMagnus '" & .BaseMagnus & "',
                                         ServidorLocal = '" & .ServidorLocal & "', ServidorRemoto = '" & .ServidorRemoto & "',
                                         UsuarioLocal= '" & .UsuarioLocal & "', UsuarioRemoto= '" & .UsuarioRemoto & "',
                                         PasswordLocal = '" & .PasswordLocal & "', PasswordRemoto= '" & .PasswordRemoto & "',
                                         DynDns = '" & .DynDns & "', PrecioMinimoVenta= '" & .PrecioMinimoVenta & "',
                                         FacturarPrecioMinimo ='" & .FacturarPrecioMinimo & "', Empresa = '" & .Empresa & "',
                                         MuestraExistencia= '" & .MuestraExistencia & "'
                                         WHERE OID = " & .OID
        End With
        Return obj.commandSQL(Query)
    End Function

    Public Function CargarPrueba() As DataTable
        Dim dt As New DataTable
        Dim Query As String
        Try
            Query = "Select Tiendas.OID, Descripcion, idAlmacen, idFolio, Factura, BasePuntoVenta, BaseMagnus, ServidorLocal, 
                     ServidorRemoto, UsuarioLocal, UsuarioRemoto, PasswordLocal, PasswordRemoto, DynDns, PrecioMinimoVenta, FacturarPrecioMinimo,
                     Empresa, MuestraExistencia, Empresas.Nombre
                     from Tiendas inner join Empresas on (Tiendas.Empresa = Empresas.OID)"
            dt = obj.RegresarDatos(Query)
            Return dt
        Finally

        End Try
    End Function


    Public Function GetDB() As DataTable
        Try
            Dim query As String = ""
            Dim obj As New clsSQL
            query = "Select name From sys.databases Order By create_date Desc"
            Return obj.RegresarDatos(query)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function

    Public Function CargarAlmacen() As DataTable
        Dim dt As New DataTable
        Dim Query As String
        Try
            Query = "SELECT * FROM Almacen"
            dt = obj.RegresarDatosMagnus(Query)
            Return dt
        Finally

        End Try
    End Function

    Public Function CargarFolioAlmacen(ByVal IdAlmacen As Integer) As DataTable
        Dim dt As New DataTable
        Dim Query As String
        Try
            Query = "SELECT * FROM FolioAlmacen where Documento = 5 AND IdAlmacen = '" & IdAlmacen & "'"
            dt = obj.RegresarDatosMagnus(Query)
            Return dt
        Finally

        End Try
    End Function

    Public Function UnicodeBytesToString(ByVal bytes() As Byte) As String

        Return System.Text.Encoding.Unicode.GetString(bytes)
    End Function

    Public Function GuardarReportePuntoVenta(ByVal entReporte As Entidades.ReportesPuntoVenta) As Boolean
        Dim dt As New DataTable
        Dim Query As String
        Dim hola As String

        Try
            If entReporte.Archivo Is Nothing Then
                hola = ""
            Else
                hola = Convert.ToBase64String(entReporte.Archivo)
                'hola = UnicodeBytesToString(entReporte.Archivo)
            End If

            Query = "insert ReportesPuntoventa(Nombre, FechaModificacion, Tipo, Archivo, Tienda)values
                    ('" & entReporte.Nombre & "', '" & Format(entReporte.FechaModificacion, "yyyy/MM/dd") & "', '" & entReporte.Tipo & "', '" & hola & "', " & entReporte.Tienda & ")"
            Return obj.commandSQL(Query)
        Catch ex As Exception
            MsgBox(ex)
            Return False
        End Try
    End Function

    Public Function CargarReportePuntoVenta() As DataTable
        Dim Query As String
        Dim dt As DataTable
        Try
            Query = " SELECT * FROM ReportesPuntoVenta"
            dt = obj.RegresarDatos(Query)
            Return dt

        Catch ex As Exception

        End Try
    End Function
End Class