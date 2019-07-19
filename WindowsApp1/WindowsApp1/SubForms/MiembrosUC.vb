Public Class MiembrosUC
    Dim referencia As New probando()
    Private Sub MiembrosUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Trigger = False
        cargardatagrid1("Cliente", DataGridView1)
        LongitudColumnas(DataGridView1, 140, 190, 190, 150, 125, 80, 80)
        triggerFiltro = True
        cantidadMiembros()

    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        probando.Show()
    End Sub

    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        cargardatagrid1("Cliente", DataGridView1)
    End Sub

    Private Sub ModBtn_Click(sender As Object, e As EventArgs) Handles ModBtn.Click
        'referencia.setNombre(Nombre)
        Trigger = True
        probando.Show()

    End Sub




    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        camposRetornados()
    End Sub

    Public Sub camposRetornados()
        Id = Me.DataGridView1.CurrentRow.Cells(0).Value.ToString
        Nombre = Me.DataGridView1.CurrentRow.Cells(1).Value.ToString
        Apellido = Me.DataGridView1.CurrentRow.Cells(2).Value.ToString
        Telefono = Me.DataGridView1.CurrentRow.Cells(4).Value.ToString
        Email = Me.DataGridView1.CurrentRow.Cells(3).Value.ToString
        Deportista = Me.DataGridView1.CurrentRow.Cells(5).Value
    End Sub

    Private Sub filtroBtn_Click(sender As Object, e As EventArgs) Handles filtroBtn.Click


        If triggerFiltro = True Then
            For filas As Integer = 0 To DataGridView1.RowCount - 1

                If Me.DataGridView1.Item(5, filas).Value = False Then
                    Me.DataGridView1.CurrentCell = Nothing
                    Me.DataGridView1.Rows(filas).Visible = False


                End If

            Next
            triggerFiltro = False
        Else
            For filas As Integer = 0 To DataGridView1.RowCount - 1
                If Me.DataGridView1.Item(5, filas).Value = False Or Me.DataGridView1.Item(5, filas).Value = True Then
                    Me.DataGridView1.CurrentCell = Nothing
                    Me.DataGridView1.Rows(filas).Visible = True
                End If
            Next
            triggerFiltro = True


        End If
    End Sub

    Public Sub cantidadMiembros()
        Dim cont As Integer
        cont = 0
        For filas As Integer = 0 To DataGridView1.RowCount - 1
            If Me.DataGridView1.Item(6, filas).Value = True Then
                miembrosActivosCont = miembrosActivosCont + 1
            End If
            cont = cont + 1
        Next
        miembrosCont = cont

    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Try
            Dim eliminar As String
            eliminar = "DELETE from Cliente WHERE Id_Cliente = " & Id
            Form1.comando = New OleDb.OleDbCommand(eliminar, Form1.conexion)
            Form1.comando.ExecuteNonQuery()
            MsgBox("Cliente Eliminado Satifactoriamente, por favor Refresca la Tabla con el botón refrescar", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Error al Eliminar Cliente, por favor Vuelva a Intentar", MsgBoxStyle.Critical)
        End Try
        refrescarActivado()
    End Sub


    Private Sub paymentBtn_Click(sender As Object, e As EventArgs) Handles paymentBtn.Click
        Trigger = True
        AgregarPago.Show()

    End Sub



    Public Sub refrescarActivado()
        'refreshBtn.ForeColor = Color.Red
    End Sub
End Class