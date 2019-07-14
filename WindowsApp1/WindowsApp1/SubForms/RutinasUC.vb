Public Class RutinasUC
    Private Sub RutinasUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargardatagrid1("Rutina", DataGridView1)
        'LongitudColumnas(DataGridView1, 150, 195, 195, 150, 125, 80, 80)
    End Sub

    Private Sub addRutinaBtn_Click(sender As Object, e As EventArgs) Handles addRutinaBtn.Click
        AgregarRutina.Show()
    End Sub
End Class
