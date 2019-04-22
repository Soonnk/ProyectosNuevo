Imports Negocios

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarServidores()

    End Sub

    Private Sub LlenarServidores()
        'Dim instancias = Negocios.Conector.CargarInstanciasLocales()

        cmbServidor1.Properties.BeginUpdate()
        cmbServidor2.Properties.BeginUpdate()

        'cmbServidor1.Properties.Items.AddRange(instancias)
        'cmbServidor2.Properties.Items.AddRange(instancias)

        cmbServidor1.Properties.Items.Add("Servidor Remoto")
        cmbServidor2.Properties.Items.Add("Servidor Remoto")

        cmbServidor1.Properties.EndUpdate()
        cmbServidor2.Properties.EndUpdate()
    End Sub

    Private Sub cmbDB1_Click(sender As Object, e As EventArgs) Handles cmbDB1.Click
        If ((Not txtURL1.EditValue.Equals("")) And (Not txtUsuario1.EditValue.Equals("")) And (Not txtPass1.EditValue.Equals(""))) Then
            Try
                Dim con = New Conector(txtURL1.EditValue.ToString, txtUsuario1.EditValue.ToString, txtPass1.EditValue.ToString)

                Dim lista As String() = con.CargarBasesDeDatos

                Dim cmb As ComboBox = CType(sender, ComboBox)
                cmb.Items.AddRange(lista)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        Else
            MsgBox("Faltan campos para conectar con el servidor")
        End If
    End Sub
End Class