Partial Class DsTicket
    Partial Public Class TicketDataTable
        Private Sub TicketDataTable_TicketRowChanging(sender As Object, e As TicketRowChangeEvent) Handles Me.TicketRowChanging

        End Sub

        Private Sub TicketDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.PoblaciónColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class
End Class
