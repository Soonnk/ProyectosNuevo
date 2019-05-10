Module Module1

    Sub Main()
        Dim conexion1 = New Negocio.Loader.Conexion("DESKTOP-82O7NUQ\SQLEXPRESS", "usuario", "root", "prueba1")
        Dim conexion2 = New Negocio.Loader.Conexion("DESKTOP-82O7NUQ\SQLEXPRESS", "usuario", "root", "prueba2")

        Dim loader = New Negocio.Loader(conexion1, conexion2)

        Dim Droppables = Negocio.Comparador.GetDroppableObjects(loader.Modelo, loader.Destino)
        Dim Creatables = Negocio.Comparador.GetCreatableObjects(loader.Modelo, loader.Destino)
        Dim Comparables = Negocio.Comparador.GetComparableObjects(loader.Modelo, loader.Destino)

        Console.WriteLine("nepe")
    End Sub

End Module
