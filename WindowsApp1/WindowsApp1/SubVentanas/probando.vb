
Imports System.Runtime.InteropServices
Public Class probando

    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(LR As Integer, Tr As Integer, RR As Integer, Br As Integer, We As Integer, Hr As Integer) As IntPtr

    End Function

    Public Valor As String

    Private Sub probando_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Trigger Then
            setTxtBxs()
            Trigger = False
        Else
            limpiar()
        End If

        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20))

    End Sub

    Private Sub sendBtn_Click(sender As Object, e As EventArgs) Handles sendBtn.Click
        Form1.comando = New OleDb.OleDbCommand("insert into Cliente(nombre,apellido,telefono,email,deportista)" & Chr(13) & '<- seria como un .then y sigo abajo
                      "values(nombreTxtBx,apellidoTxtBx,telefonoTxtBx,emailTxtBx,deportistaChkBx)", Form1.conexion)
        Form1.comando.Parameters.AddWithValue("@nombre", nombreTxtBx.Text.ToUpper)
        Form1.comando.Parameters.AddWithValue("@apellido", apellidoTxtBx.Text.ToUpper)
        Form1.comando.Parameters.AddWithValue("@telefono", telefonoTxtBx.Text.ToUpper)
        Form1.comando.Parameters.AddWithValue("@email", emailTxtBx.Text.ToUpper)
        Form1.comando.Parameters.AddWithValue("@deportista", deportistaChkBx.Checked)


        Form1.comando.ExecuteNonQuery()

        Me.Close()

    End Sub

    Public Sub setTxtBxs()
        nombreTxtBx.Text = Nombre
        apellidoTxtBx.Text = Apellido
        telefonoTxtBx.Text = Telefono
        emailTxtBx.Text = Email
        deportistaChkBx.Checked = Deportista
    End Sub
    Public Sub limpiar()
        nombreTxtBx.Text = ""
        apellidoTxtBx.Text = ""
        telefonoTxtBx.Text = ""
        emailTxtBx.Text = ""
        deportistaChkBx.Checked = False
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub
End Class