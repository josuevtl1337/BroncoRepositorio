Module Module1
    Dim con As New OleDb.OleDbConnection

    Public Sub enlace()
        con = Form1.conexion
        Try
            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\josue\Desktop\BroncoApp_Final\WindowsApp1\WindowsApp1\bin\Debug\DB.accdb"
            con.Open()
            Form1.estado = "conectado"

        Catch ex As Exception
            Form1.estado = "desconectado"
        End Try
        Form1.Label1.Text = Form1.estado

    End Sub

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

End Module
