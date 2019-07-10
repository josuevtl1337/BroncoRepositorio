Module Module1
    Dim con As New OleDb.OleDbConnection
    Public Nombre, Apellido, Telefono, Email, Deportista As String
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



End Module
