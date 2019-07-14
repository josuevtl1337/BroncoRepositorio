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
        Me.PanelForms.Controls.Add(Pagos)
        Me.PanelForms.Controls.Add(Rutinas)
        Inicio.Show()


    End Sub

    Public Sub enlace()
        Try
            'Conexion Facu
            'conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Cande\Documents\GitHub\BroncoRepositorio\WindowsApp1\WindowsApp1\bin\Debug\DB.accdb"
            'Conexion Josue
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\josue\Desktop\git\BroncoRepositorio\WindowsApp1\WindowsApp1\bin\Debug\DB.accdb"
            conexion.Open()
            estado = "conectado"

        Catch ex As Exception
            estado = "desconectado"
        End Try
        Label1.Text = estado

    End Sub





    Private Sub inicioBtn_Click(sender As Object, e As EventArgs) Handles inicioBtn.Click
        Panel_Botones.Hide()
        title.Text = "Inicio"
        MostrarUserControl(Inicio)
        cambiaColor(inicioBtn, miembrosBtn, pagosBtn, rutinasBtn)
    End Sub

    Private Sub miembrosBtn_Click(sender As Object, e As EventArgs) Handles miembrosBtn.Click
        Panel_Botones.Hide()
        title.Text = "Miembros"
        MostrarUserControl(Miembros)
        cambiaColor(miembrosBtn, inicioBtn, pagosBtn, rutinasBtn)
    End Sub

    Private Sub pagosBtn_Click(sender As Object, e As EventArgs) Handles pagosBtn.Click
        Panel_Botones.Hide()
        title.Text = "Pagos"
        MostrarUserControl(Pagos)
        cambiaColor(pagosBtn, inicioBtn, miembrosBtn, rutinasBtn)
    End Sub

    Private Sub rutinasBtn_Click(sender As Object, e As EventArgs) Handles rutinasBtn.Click
        Panel_Botones.Hide()
        title.Text = "Rutinas"
        MostrarUserControl(Rutinas)
        cambiaColor(rutinasBtn, inicioBtn, miembrosBtn, pagosBtn)
    End Sub



End Class
