Public Class InicioUC
    Private Sub Masmiembros_Click(sender As Object, e As EventArgs) Handles masmiembros.Click, masactivos.Click
        MostrarUserControl(Form1.Miembros)
        Form1.Miembros.BringToFront()
        'cambiaColor(Form1.miembrosBtn, Form1.inicioBtn, Form1.pagosBtn, Form1.rutinasBtn)
        CambiarColorTest(Form1.miembrosBtn)
    End Sub

    Private Sub Maspagos_Click(sender As Object, e As EventArgs) Handles maspagos.Click, mastiempo.Click
        MostrarUserControl(Form1.Pagos)
        Form1.Pagos.BringToFront()
        'cambiaColor(Form1.pagosBtn, Form1.inicioBtn, Form1.miembrosBtn, Form1.rutinasBtn)
        CambiarColorTest(Form1.pagosBtn)
    End Sub

    Private Sub InicioUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = miembrosCont
        Label2.Text = "$" + gananciasCont.ToString
        Label3.Text = miembrosActivosCont
        Me.Label1.Parent = Me.PictureBox1
        Me.Label2.Parent = Me.PictureBox2
        Me.Label3.Parent = Me.PictureBox3
    End Sub
End Class
