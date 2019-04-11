Public Class pAgregarHabitaciones
    Public modo As tipo
    Private _mdiPrincipal As mdiPrincipal

    Enum tipo
        Nuevo
        Editar
    End Enum
    Private Sub pAgregarHabitaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cargar()
        'Me.mdiPrincipal1.activo = "habitaciones"
    End Sub
    Public Sub consultarHabitacion(ByRef row As DataRow)
        Try
            txtId.EditValue = row("id")
            txtDescripcion.EditValue = row("descipcion")
            txtCapacidad.EditValue = row("capacidad")
            txtPrecioPorNoche.EditValue = row("precioPorNoche")

        Catch ex As Exception

        End Try
    End Sub
    Private Sub GroupControl1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TextEdit2_EditValueChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Guardar()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

    End Sub



    '------------------------------------------------------------------------------------------------------------------------


    Public TipoForma As enuTipoForma
    Public Enum enuTipoForma
        Agregar
        Modificar
    End Enum
    'Public Forma As New pAgregarHabitaciones

    Public _Id2 As Integer

    Private Sub Guardar()
        Try
            Dim hNegocio As New Negocios.Habitaciones

            Select Case TipoForma
                Case enuTipoForma.Agregar
                    If hNegocio.Insertar(llenarEntidad) = True Then
                        MessageBox.Show("Datos guardados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'Forma.Cargar()
                        Me.Close()
                    Else
                        MessageBox.Show("No se pudo guardar los datos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Function llenarEntidad() As Entidades.Habitaciones
        Dim hEntidad As New Entidades.Habitaciones

        hEntidad.Descripcion = Me.txtDescripcion.Text
        hEntidad.Capacidad = Me.txtCapacidad.Text
        hEntidad.PrecioPorNoche = Me.txtPrecioPorNoche.Text

        Return hEntidad

    End Function

    Public Sub Cargar()
        Try
            Select Case TipoForma
                Case enuTipoForma.Agregar
                    Me.Text = ".: Agregar Habitación :."
                Case enuTipoForma.Modificar
                    Me.Text = ".: Modificar Habitación :."
                    cargarHabitacion()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Public Sub cargarHabitacion()
        Dim hNegocio As Negocios.Habitaciones
        Dim hEntidad As Entidades.Habitaciones
        Try
            hEntidad = hNegocio.cargarHabitaciones(_Id2)
            Me.txtDescripcion.Text = hEntidad.Descripcion
            Me.txtCapacidad.Text = hEntidad.Capacidad
            Me.txtPrecioPorNoche.Text = hEntidad.PrecioPorNoche

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class