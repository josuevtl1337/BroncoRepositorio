Public Class AgregarPago

    Private Sub AgregarPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Trigger Then
            setTxtBxs()
            Trigger = False
        Else
            limpiar()
        End If

    End Sub

    Private Sub sendBtn_Click(sender As Object, e As EventArgs) Handles sendBtn.Click
        Try
            Form1.comando = New OleDb.OleDbCommand("insert into Pago(Id_Cliente,Monto,Fecha_Pago,Nombre_Rutina)" & Chr(13) & '<- seria como un .then y sigo abajo
                      "values(Id,fechaTxtBx,montoTxtBx,rutinaChkBx)", Form1.conexion)
            Form1.comando.Parameters.AddWithValue("@Id_Cliente", Id)
            Form1.comando.Parameters.AddWithValue("@Monto", montoTxtBx.Text.ToUpper)
            Form1.comando.Parameters.AddWithValue("@Fecha_Pago", fechaDP)
            Form1.comando.Parameters.AddWithValue("@Nombre_Rutina", rutinaCB.Text.ToUpper)


            Form1.comando.ExecuteNonQuery()

            MsgBox("Pago Generado Exitosamente", MsgBoxStyle.Information)
            Me.Close()
        Catch ex As Exception
            MsgBox("Error al generar pago", MsgBoxStyle.Critical)
            Me.Close()
        End Try
    End Sub

    Public Sub setTxtBxs()
        nombreTxtBx.Text = Nombre
    End Sub

    Public Sub limpiar()
        nombreTxtBx.Text = ""
        montoTxtBx.Text = ""
        rutinaCB.Text = ""
    End Sub

End Class