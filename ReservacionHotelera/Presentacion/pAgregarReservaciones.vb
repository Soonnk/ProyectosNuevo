Imports DevExpress.XtraEditors.Controls

Public Class pAgregarReservaciones
    Dim detalle As DataTable
    Public modo As tipo
    Private _mdiPrincipal As mdiPrincipal

    Enum tipo
        Nuevo
        Editar
    End Enum

    Private Sub pAgregarReservaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
        PrepararDetalle()
    End Sub
    Public Sub consultarReservacion(ByVal row As DataRow)
        Try
            txtId.EditValue = row("id")
            cmbFormaPago.EditValue = row("formaDePago")
            dtpLlegada.EditValue = row("fechaLlegada")
            tpkLlegada.EditValue = row("horaLlegada")
            dtpSalida.EditValue = row("fechaSalida")
            tpkSalida.EditValue = row("horaLlegada")
            txtCliente.EditValue = row("idCliente")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ComboBoxEdit1_Clicked(sender As Object, e As EventArgs) Handles cmbHabitacion.ButtonClick
        If dtpLlegada.DateTime = Nothing Or dtpSalida.DateTime = Nothing Then
            MsgBox("Selecciona Fechas de llegada y salida por favor")
            Return
        End If
        If tpkLlegada.EditValue = Nothing Or dtpSalida.EditValue = Nothing Then
            MsgBox("Selecciona Horas de llegada y salida por favor")
            Return
        End If
    End Sub

    Private Function CrearReservacion() As Entidades.Reservaciones
        Dim oReservacion = New Entidades.Reservaciones
        With oReservacion
            .Id = CInt(txtId.EditValue)
            .FechaLlegada = dtpLlegada.DateTime
            .HoraLlegada = tpkLlegada.EditValue
            .FechaSalida = dtpSalida.DateTime
            .HoraSalida = tpkSalida.EditValue
            .FormaPago = cmbFormaPago.EditValue

            For Each row As DataRow In detalle.Rows
                Dim habitacion = New Entidades.Habitaciones
                habitacion.Id = row.Item("id")
                habitacion.PrecioPorNoche = row.Item("precioPorNoche")
                .AgregarHabitacion(habitacion)
            Next
        End With
        Return oReservacion
    End Function

    Public Sub Cargar()
        Dim coleccion As ComboBoxItemCollection = cmbHabitacion.Properties.Items

        Dim tabla As New DataTable
        Dim nReservacion As Negocios.Reservaciones = New Negocios.Reservaciones
        tabla = nReservacion.Consultar()

        coleccion.BeginUpdate()
        Try
            For i As Integer = 0 To tabla.Rows.Count - 1
                Dim habitacion = New Entidades.Habitaciones

                habitacion.Descripcion = tabla.Rows(i).Item("descripcion")
                habitacion.PrecioPorNoche = tabla.Rows(i).Item("precioPorNoche")
                habitacion.Id = tabla.Rows(i).Item("Id")

                coleccion.Add(habitacion)
            Next
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            coleccion.EndUpdate()
        End Try
    End Sub

    Public Sub BuscarCliente(ByVal id As Integer)
        Dim nClientes As Negocios.Clientes = New Negocios.Clientes
        Dim cliente As Entidades.Clientes = nClientes.CargarCliente(id)
        If cliente Is Nothing Then
            lblCliente.Text = "Cliente no encontrado"
        Else
            lblCliente.Text = cliente.Nombre & cliente.Apellido
        End If
    End Sub

    Private Sub PrepararDetalle()
        detalle = New DataTable

        'Dim id = New DataColumn("id")
        'Dim descripcion = New DataColumn("descripcion")
        'Dim precioPorNoche = New DataColumn("precioPorNoche")
        'Dim totalDeNoches = New DataColumn("totalDeNoches")
        'Dim subtotal = New DataColumn("subtotal")

        'detalle.Columns.AddRange({id, descripcion, precioPorNoche, totalDeNoches, subtotal})
        detalle.Columns.Add("id", GetType(Integer))
        detalle.Columns.Add("descripcion", GetType(String))
        detalle.Columns.Add("precioPorNoche", GetType(Decimal))
        detalle.Columns.Add("totalDeNoches", GetType(Integer))
        detalle.Columns.Add("subtotal", GetType(Decimal))

        gridDetalle.DataSource = detalle
    End Sub

    Private Sub agregarHabitacionDetalle(ByRef habitacion As Entidades.Habitaciones)
        Dim dias As Integer = DateDiff(DateInterval.Day, dtpLlegada.EditValue, dtpSalida.EditValue)
        With habitacion
            detalle.Rows.Add(.Id, .Descripcion, .PrecioPorNoche, dias, .PrecioPorNoche * dias)
        End With

        actualizarTotal()
    End Sub

    Private Sub actualizarTotal()
        Dim total As Decimal = 0
        For Each row As DataRow In detalle.Rows
            total += row.Item("subtotal")
        Next
        lblTotal.Text = "Total: $" & total
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        agregarHabitacionDetalle(cmbHabitacion.SelectedItem)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim nReservacion = New Negocios.Reservaciones

        If (Not nReservacion.GuardarReservacion(CrearReservacion)) Then
            MsgBox("No ha sido posible guardar")
        End If

    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        BuscarCliente(txtCliente.EditValue)
    End Sub
End Class