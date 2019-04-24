Public Class AgregarEmpresa
    Private Sub AgregarEmpresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub bbiImagen_ItemClick(sender As Object, e As DevExpress.Xtra   Bars.ItemClickEventArgs) Handles bbiImagen.ItemClick
        Try

            Dim imagen As New OpenFileDialog()
            imagen.Filter = "Imagen JPG (*.jpg)|*.jpg|Imagen BMP (*.bmp)|*.bmp|Imagen PNG (*.png)|*.png|Imagen GIF (*.gif)|*.gif"
            If imagen.ShowDialog() = DialogResult.OK Then
                imgReporte.Properties.SizeMode = PictureBoxSizeMode.AutoSize
                ruta = imagen.FileName.ToString
                imgReporte.Image = System.Drawing.Image.FromFile(ruta)

            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar la imagen", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

End Class