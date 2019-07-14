Public Class RutinasUC
    Private Sub RutinasUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargardatagrid1("Rutina", DataGridView1)
        LongitudColumnas(DataGridView1, 200, 300, 200, 150)
    End Sub

    Private Sub addRutinaBtn_Click(sender As Object, e As EventArgs) Handles addRutinaBtn.Click
        AgregarRutina.Show()
    End Sub
End Class
