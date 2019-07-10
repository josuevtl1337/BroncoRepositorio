Imports System.Runtime.InteropServices
Public Class Form1
    Public conexion As New OleDb.OleDbConnection
    Public comando As New OleDb.OleDbCommand
    Public estado As String

    Dim probando As New probando()



    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(LR As Integer, Tr As Integer, RR As Integer, Br As Integer, We As Integer, Hr As Integer) As IntPtr
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20))
        'Timer1.Enabled = True
        enlace()

    End Sub

    Public Sub enlace()
        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\josue\Desktop\BroncoApp_Final\WindowsApp1\WindowsApp1\bin\Debug\DB.accdb"
            conexion.Open()
            estado = "conectado"

        Catch ex As Exception
            estado = "desconectado"
        End Try
        Label1.Text = estado

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim Miembros As New MiembrosUC()
        Me.PanelForms.Controls.Add(Miembros)
        Panel_Botones.Hide()
        title.Text = "Miembros"



    End Sub
End Class
