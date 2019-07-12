Imports System.Runtime.InteropServices
Public Class Form1
    Public conexion As New OleDb.OleDbConnection
    Public comando As New OleDb.OleDbCommand
    Public estado As String
    Public Miembros As New MiembrosUC()
    Public Inicio As New InicioUC()
    Public Pagos As New PagosUC()
    Public Rutinas As New RutinasUC()

    Dim probando As New probando()



    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(LR As Integer, Tr As Integer, RR As Integer, Br As Integer, We As Integer, Hr As Integer) As IntPtr
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace()
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20))
        Me.PanelForms.Controls.Add(Inicio)
        Me.PanelForms.Controls.Add(Miembros)
        Inicio.Show()


    End Sub

    Public Sub enlace()
        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cande\Documents\GitHub\BroncoRepositorio\WindowsApp1\WindowsApp1\bin\Debug\DB.accdb"
            conexion.Open()
            estado = "conectado"

        Catch ex As Exception
            estado = "desconectado"
        End Try
        Label1.Text = estado

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel_Botones.Hide()
        title.Text = "Miembros"
        MostrarUserControl(Miembros)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel_Botones.Hide()
        title.Text = "Inicio"
        MostrarUserControl(Inicio)
    End Sub
End Class
