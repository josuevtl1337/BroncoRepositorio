Module Module1
    Dim con As New OleDb.OleDbConnection
    Public Nombre, Apellido, Telefono, Email As String
    Public Deportista As Boolean
    Public Trigger As Boolean



    Public Sub cargardatagrid1(tabla As String, dgview As DataGridView)
        con = Form1.conexion
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim registros As New DataSet
        Dim consulta As String
        consulta = "select * from " + tabla
        adaptador = New OleDb.OleDbDataAdapter(consulta, con)
        registros.Tables.Add(tabla)
        adaptador.Fill(registros.Tables(tabla))
        dgview.DataSource = registros.Tables(tabla)
    End Sub

    Public Sub LongitudColumnas(dgview As DataGridView, ParamArray longitudes() As Object)
        Dim i As Integer

        While i < longitudes.Length()

            dgview.Columns(i).Width = longitudes(i)
            i = i + 1

        End While

    End Sub

    Public Sub MostrarUserControl(uc As UserControl)
        Dim i As Integer
        Dim Inicio = Form1.Inicio
        Dim Miembros = Form1.Miembros
        Dim Pagos = Form1.Pagos
        Dim Rutinas = Form1.Rutinas
        Dim uclist = New UserControl(3) {Inicio, Miembros, Pagos, Rutinas}

        While i < uclist.Length()
            If uc.Equals(uclist(i)) Then
                uclist(i).Show()
            Else
                uclist(i).Hide()
            End If
            i = i + 1
        End While

    End Sub
End Module
