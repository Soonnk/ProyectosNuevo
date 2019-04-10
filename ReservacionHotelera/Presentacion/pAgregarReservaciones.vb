Imports DevExpress.XtraEditors.Controls

Public Class pAgregarReservaciones
    Private Sub DateEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles dtpLlegada.EditValueChanged

    End Sub

    Private Sub pAgregarReservaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBoxEdit1_Clicked(sender As Object, e As EventArgs) Handles cmbHabitacion.ButtonClick
        If dtpLlegada.DateTime = Nothing Or dtpSalida.DateTime = Nothing Then
            MsgBox("Selecciona fechas de llegada y saida por favor")
            Return
        End If
        If tpkLlegada.EditValue = Nothing Or dtpSalida.EditValue = Nothing Then
            MsgBox("Selecciona Horas de llegada y saida por favor")
            Return
        End If

        List(Of Entidades.Habitaciones) lst = 
    End Sub

    Private Sub ComboBoxEdit1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHabitacion.SelectedIndexChanged

    End Sub

    Private Sub CrearReservacion()
        Dim oReservacion = New Entidades.Reservaciones
        With oReservacion
            .Id = CInt(txtId.EditValue)
            .FechaLlegada = dtpLlegada.DateTime
            .HoraLlegada = tpkLlegada.EditValue
            .FechaSalida = dtpSalida.DateTime
            .HoraSalida = tpkSalida.EditValue
            .FormaPago = cmbFormaPago.EditValue

            For Each h As Entidades.Habitaciones I
        End With
    End Sub

    Public Sub CargarHabitaciones()
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
End Class