Imports Negocios

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarServidores()

    End Sub

    Private Sub cmbDB1_Click(sender As Object, e As EventArgs) Handles cmbDB1.Click
        If ((Not txtURL1.EditValue.Equals("")) And (Not txtUsuario1.EditValue.Equals("")) And (Not txtPass1.EditValue.Equals(""))) Then
            LlenarDBs(sender)
        Else
            MsgBox("Faltan campos para conectar con el servidor")
        End If
    End Sub

    Private Sub cmbDB2_Click(sender As Object, e As EventArgs) Handles cmbDB2.Click
        If ((Not txtURL2.EditValue.Equals("")) And (Not txtUsuario2.EditValue.Equals("")) And (Not txtPass2.EditValue.Equals(""))) Then
            LlenarDBs(sender)
        Else
            MsgBox("Faltan campos para conectar con el servidor")
        End If
    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Dim ventanaComparador = New DiffPrincipal()
        ventanaComparador.SetConn1(
            txtURL1.EditValue.ToString(),
            txtUsuario1.EditValue.ToString(),
            txtPass1.EditValue.ToString(),
            cmbDB1.SelectedText
        )
        ventanaComparador.SetConn2(
            txtURL2.EditValue.ToString(),
            txtUsuario2.EditValue.ToString(),
            txtPass2.EditValue.ToString(),
            cmbDB2.SelectedText
        )
        ventanaComparador.Show()
        ventanaComparador.Padre = Me
        Me.Hide()
    End Sub

    Private Sub LlenarServidores()
        Dim instancias = Negocios.Conector.CargarInstanciasLocales()

        cmbServidor1.Properties.BeginUpdate()
        cmbServidor2.Properties.BeginUpdate()

        cmbServidor1.Properties.Items.AddRange(instancias)
        cmbServidor2.Properties.Items.AddRange(instancias)

        cmbServidor1.Properties.Items.Add("Servidor Remoto")
        cmbServidor2.Properties.Items.Add("Servidor Remoto")

        cmbServidor1.Properties.EndUpdate()
        cmbServidor2.Properties.EndUpdate()
    End Sub

    Private Sub LlenarDBs(sender As Object)
        Try
            Dim con = New Conector(txtURL1.EditValue.ToString, txtUsuario1.EditValue.ToString, txtPass1.EditValue.ToString)

            Dim lista As String() = con.CargarBasesDeDatos

            Dim cmb As DevExpress.XtraEditors.ComboBoxEdit = CType(sender, DevExpress.XtraEditors.ComboBoxEdit)

            cmb.Properties.Items.Clear()

            cmb.Properties.Items.AddRange(lista)

            cmb.ShowPopup()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class