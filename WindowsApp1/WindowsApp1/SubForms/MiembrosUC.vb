﻿Public Class MiembrosUC
    Dim referencia As New probando()

    Private Sub MiembrosUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Trigger = False
        cargardatagrid1("Cliente", DataGridView1)
        LongitudColumnas(DataGridView1, 150, 195, 195, 150, 125, 80, 80)
    End Sub


    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        cargardatagrid1("Cliente", DataGridView1)
    End Sub

    Private Sub ModBtn_Click(sender As Object, e As EventArgs) Handles ModBtn.Click
        'referencia.setNombre(Nombre)
        Trigger = True
        probando.Show()
        MsgBox(Nombre)

    End Sub

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        camposRetornados()


    End Sub

    Public Sub camposRetornados()
        Nombre = Me.DataGridView1.CurrentRow.Cells(1).Value.ToString
        Apellido = Me.DataGridView1.CurrentRow.Cells(2).Value.ToString
        Telefono = Me.DataGridView1.CurrentRow.Cells(4).Value.ToString
        Email = Me.DataGridView1.CurrentRow.Cells(3).Value.ToString
        Deportista = Me.DataGridView1.CurrentRow.Cells(5).Value

    End Sub


End Class