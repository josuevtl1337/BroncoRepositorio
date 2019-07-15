Public Class InicioUC
    Private Sub Masmiembros_Click(sender As Object, e As EventArgs) Handles masmiembros.Click, masactivos.Click
        MostrarUserControl(Form1.Miembros)
        Form1.Miembros.BringToFront()
        cambiaColor(Form1.miembrosBtn, Form1.inicioBtn, Form1.pagosBtn, Form1.rutinasBtn)
    End Sub

    Private Sub Maspagos_Click(sender As Object, e As EventArgs) Handles maspagos.Click, mastiempo.Click
        MostrarUserControl(Form1.Pagos)
        Form1.Pagos.BringToFront()
        cambiaColor(Form1.pagosBtn, Form1.inicioBtn, Form1.miembrosBtn, Form1.rutinasBtn)
    End Sub

    Private Sub InicioUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = miembrosCont
        Label2.Text = gananciasCont
        Label3.Text = miembrosActivosCont
    End Sub
End Class
