﻿Public Class GeneradorScript

    ''' <summary>
    ''' Genera el script para el borrado de una columna
    ''' </summary>
    ''' <param name="tabla">Nombre de la tabla a borrar</param>
    ''' <returns>El script de Borado de la columna especificada</returns>
    Public Shared Function DropTable(ByVal tabla As String) As String
        Return "DROP TABLE IF EXISTS [" & tabla & "];"
    End Function

    ''' <summary>
    ''' Construye la creacion de una tabla para la con los paramentros especificados
    ''' </summary>
    ''' <param name="name">Nombre de la tabla a crear</param>
    ''' <param name="columns">Arreglo de nombres de las columnas a agregar</param>
    ''' <param name="columnTypes">Arreglo de los tipos de las columnas (debe tener el mismo tamaño de arreglo que <paramref name="columns"/>)</param>
    ''' <returns></returns>
    Public Shared Function CreateTable(ByVal name As String, ByVal columns() As String, ByVal columnTypes() As String) As String
        If columns.Count <> columnTypes.Count Then
            Throw New Exception("El número de columnas no coincide con el numero de tipos para las mismas")
        End If

        Dim statement As String
        statement = "CREATE TABLE [" & name & "]("
        For i = 0 To columns.Count - 1
            statement += Environment.NewLine & vbTab & "[" & columns(i) & "] " & columnTypes(i)
            If (i < (columns.Count - 2)) Then
                statement += ","
            End If
        Next
        statement += ");"

        Return statement
    End Function

    ''' <summary>
    ''' Construye la creacion de una tabla para la con los paramentros especificados
    ''' </summary>
    ''' <param name="name">Nombre de la tabla a crear</param>
    ''' <param name="columns">Arreglo de nombres de las columnas a agregar</param>
    ''' <param name="columnTypes">Arreglo de los tipos de las columnas (debe tener el mismo tamaño de arreglo que <paramref name="columns"/>)</param>
    ''' <param name="nullables">Arreglo de Strings con los parametros adicionales de la columna(debe tener el mismo tamaño de arreglo que <paramref name="columns"/>)</param>
    ''' <returns></returns>
    Public Shared Function CreateTable(ByVal name As String, ByVal columns() As String, ByVal columnTypes() As String, ByVal nullables() As String) As String
        If columns.Count <> columnTypes.Count Then
            Throw New Exception("El número de columnas no coincide con el numero de tipos para las mismas")
        End If

        Dim statement As String
        statement = "CREATE TABLE [" & name & "]("
        For i = 0 To columns.Count - 1
            statement += "[" & columns(i) & "] " & columnTypes(i) & " " & nullables(i)
            If (i < columns.Count - 2) Then
                statement += ","
            End If
        Next
        statement += ");"

        Return statement
    End Function

    ''' <summary>
    ''' Genera el script para el borrado de una columna
    ''' </summary>
    ''' <param name="name">El namespace de la tabla ep: Usuarios.nombre donde Usuarios es la tabla y nombre es la columna</param>
    ''' <returns>El script de Borado de la columna especificada</returns>
    Public Shared Function DropColumn(ByVal name As String) As String
        Dim tabla As String
        Dim columna As String

        Dim p = name.Split(".")

        tabla = p(0)
        columna = p(1)

        Return "ALTER TABLE [" & tabla & "] DROP COLUMN [" & columna & "];"
    End Function

    ''' <summary>
    ''' Genera el script de creacion de una columna en el namespace especificado
    ''' </summary>
    ''' <param name="name">El namespace de la tabla ep: Usuarios.nombre donde Usuarios es la tabla y nombre es la columna</param>
    ''' <returns>El script de Creacion de la columna especificada</returns>
    Public Shared Function CreateColumn(ByVal name As String, ByVal type As String) As String
        Dim tabla As String
        Dim columna As String

        Dim p = name.Split(".")

        tabla = p(0)
        columna = p(1)

        Return "ALTER TABLE [" & tabla & "] ADD [" & columna & "] " & type & ";"
    End Function

    ''' <summary>
    ''' Genera el script de modificacion de una columna especificada
    ''' </summary>
    ''' <param name="name">El namespace de la tabla ep: Usuarios.nombre donde Usuarios es la tabla y nombre es la columna</param>
    ''' <returns>Script de modificacion completo de la tabla</returns>
    Public Shared Function ModifyColumn(ByVal name As String, ByVal type As String) As String
        Dim tabla As String
        Dim columna As String

        Dim p = name.Split(".")

        tabla = p(0)
        columna = p(1)

        Dim statement = "ALTER TABLE [" & tabla & "] ADD [" & columna & "tempDiff] " & type & ";"
        statement += Environment.NewLine & "Go"
        statement += Environment.NewLine & "UPDATE [" & tabla & "] SET [" & columna & "tempDiff] = [" & columna & "];"
        statement += Environment.NewLine & "ALTER TABLE [" & tabla & "] DROP COLUMN [" & columna & "];"
        statement += Environment.NewLine & "Go"
        statement += Environment.NewLine & "EXEC sp_rename '" & name & "tempDiff', '" & columna & "', 'COLUMN'"
        statement += Environment.NewLine & "Go"

        Return statement
    End Function

    Public Shared Function CreateIndex(ByVal columnName As String, ByVal indexName As String) As String
        Dim tabla As String
        Dim columna As String

        Dim p = columnName.Split(".")

        tabla = p(0)
        columna = p(1)

        Dim statement = "CREATE INDEX [" & indexName & "] ON [" & tabla & "] ([" & columna & "]);"

        Return statement
    End Function

    Public Shared Function DropIndex(ByVal name As String) As String
        Dim tabla As String
        Dim index As String

        Dim p = name.Split(".")

        tabla = p(0)
        index = p(1)

        Dim statement = "DROP INDEX [" & tabla & "].[" & index & "];"

        Return statement
    End Function

    Public Shared Function CreateForeignKey(ByVal name As String, ByVal foreignKey As String, ByVal primaryKey As String) As String
        Dim tablaPadre As String
        Dim tablaHijo As String
        Dim columnaPadre As String
        Dim columnaHijo As String

        Dim p = primaryKey.Split(".")
        Dim h = foreignKey.Split(".")

        tablaPadre = p(0)
        tablaHijo = h(0)

        columnaPadre = p(1)
        columnaHijo = h(1)

        name = name.Split(".")(1)

        Dim statement = "ALTER TABLE [" & tablaHijo & "]" & Environment.NewLine &
                        vbTab & "WITH NOCHECK" & Environment.NewLine &
                        vbTab & "ADD CONSTRAINT [" & name & "]" & Environment.NewLine &
                        vbTab & "FOREIGN KEY ([" & columnaHijo & "]) REFERENCES [" & tablaPadre & "] ([" & columnaPadre & "]);" & Environment.NewLine &
                        "ALTER TABLE [" & tablaHijo & "]" & Environment.NewLine &
                        vbTab & "CHECK CONSTRAINT [" & name & "];"

        Return statement
    End Function

    Public Shared Function DropForeignKey(ByVal name As String) As String
        Dim tabla As String
        Dim constraint As String

        Dim p = name.Split(".")

        tabla = p(0)
        constraint = p(1)

        Dim statement = "ALTER TABLE [" & tabla & "] DROP CONSTRAINT [" & constraint & "];"

        Return statement
    End Function

    Public Shared Function CreatePrimaryKey(ByVal name As String, ByVal column As String) As String
        Dim tabla As String
        Dim columna As String

        Dim p = name.Split(".")

        tabla = p(0)
        name = p(1)

        columna = column.Split(".")(1)

        Dim statement = "ALTER TABLE [" & tabla & "]" & Environment.NewLine &
                        vbTab & "ADD CONSTRAINT [" & name & "]" & Environment.NewLine &
                        vbTab & "PRIMARY KEY ([" & columna & "]);" & Environment.NewLine

        Return statement
    End Function

    Public Shared Function DropPrimaryKey(ByVal Name As String) As String
        Dim tabla As String
        Dim constraint As String

        Dim p = Name.Split(".")

        tabla = p(0)
        constraint = p(1)

        Dim statement = "ALTER TABLE [" & tabla & "] DROP CONSTRAINT [" & constraint & "];"

        Return statement
    End Function

    ''' <summary>
    ''' Genera el tipo de dato de una columna dada con los parametros que a esta le correspondan
    ''' </summary>
    ''' <param name="dr">DataRow con los datos de la columna. Debe tener los Items "type", "longitud", "precision" y "scale"</param>
    ''' <returns></returns>
    Public Shared Function DefineType(ByRef dr As DataRow) As String
        Dim type As String
        Dim longitud As String
        Dim precision As Int16
        Dim scale As Int16
        Dim isNullable As Boolean
        Dim isIdentity As Boolean


        Dim finalType As String

        With dr
            type = .Item("type")
            If .Item("longitud").ToString().Equals("-1") Then
                longitud = "max"
            Else
                longitud = .Item("longitud")
            End If
            precision = .Item("precision")
            scale = .Item("scale")
            isNullable = .Item("is_nullable")
            isIdentity = .Item("is_identity")
        End With

        If type.Equals("varchar") Or type.Equals("nvarchar") Or type.Equals("varbinary") Then
            finalType = type & "(" & longitud & ")"
        ElseIf type.Equals("decimal") Or type.Equals("numeric") Then
            finalType = type & "(" & precision & "," & scale & ")"
        Else
            finalType = type
        End If

        If isIdentity Then
            finalType += " IDENTITY(1,1)"
        End If

        If isNullable Then
            finalType += " NULL"
        Else
            If isIdentity Then
                finalType += " NOT NULL"
            Else
                If type.Equals("varchar") Or type.Equals("nvarchar") Or type.Equals("varbinary") Then
                    finalType += " NOT NULL DEFAULT ''"
                ElseIf type.Equals("decimal") Or type.Equals("numeric") Or type.Equals("int") Or type.Equals("smallint") Or type.Equals("tinyint") Or type.Equals("float") Or type.Equals("bigint") Then
                    finalType += " NOT NULL DEFAULT 0"
                ElseIf type.Equals("varchar") Or type.Equals("nvarchar") Or type.Equals("varbinary") Then
                    finalType += " NOT NULL DEFAULT getdate()"
                Else
                    finalType += " NOT NULL"
                End If
            End If
        End If

            Return finalType
    End Function

End Class
