﻿Public Class PagosUC

    Private Sub PagosUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargardatagrid1("Pago", DataGridView1)
        state = "Pagos"
        MostrarUserControl(Form1.Pagos)
        LongitudColumnas(DataGridView1, 195, 195, 195, 195, 195)
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        'probando.Show()
        AgregarPago.Show()
    End Sub

    Public Sub camposRetornados()
        Id = Me.DataGridView1.CurrentRow.Cells(0).Value.ToString
        Nombre = Me.DataGridView1.CurrentRow.Cells(1).Value.ToString


    End Sub

End Class
