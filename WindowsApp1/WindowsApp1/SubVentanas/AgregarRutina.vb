Public Class AgregarRutina


    Private Sub exmRutinaBtn_Click(sender As Object, e As EventArgs) Handles exmRutinaBtn.Click
        Dim dialog As New OpenFileDialog
        dialog.Filter = "imagenes |*.png"
        If dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            rutinaPB.ImageLocation = dialog.FileName
            rutinaPB.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ms As New IO.MemoryStream()
        rutinaPB.Image.Save(ms, rutinaPB.Image.RawFormat)
        Dim i() As Byte = ms.GetBuffer

        Form1.comando = New OleDb.OleDbCommand("insert into Rutina(nombre_rutina,descripcion,imagen)" & Chr(13) & '<- seria como un .then y sigo abajo
                                               "values(nombreTxtBx, descripcionTxtBx, RutinaPB)", Form1.conexion)
        Form1.comando.Parameters.AddWithValue("@nombre_rutina", nombreTxtBx.Text)
        Form1.comando.Parameters.AddWithValue("@descripcion", descripcionTxtBx.Text)
        Form1.comando.Parameters.AddWithValue("@imagen", i)

        Form1.comando.ExecuteNonQuery()
    End Sub


End Class