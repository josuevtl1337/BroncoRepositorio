Module Module1
    Dim con As New OleDb.OleDbConnection
    Public Id, Nombre, Apellido, Telefono, Email As String
    Public Deportista As Boolean
    Public Trigger As Boolean
    Public state As String
    Public triggerFiltro As Boolean
    Public miembrosCont, gananciasCont, miembrosActivosCont As Integer



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


    'LongitudColumnas es una herramienta que nos facilita fijar el ancho de las columnas con los datos en pantalla.
    Public Sub LongitudColumnas(dgview As DataGridView, ParamArray longitudes() As Object)
        Dim i As Integer

        While i < longitudes.Length()

            dgview.Columns(i).Width = longitudes(i)
            i = i + 1

        End While

    End Sub

    'El método MostrarUserControl toma como parámetro una pestaña, muestra la seleccionada, mientras que oculta cualquier otra que sea visible
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


    Public Sub cambiaColor(btn1 As Button, btn2 As Button, btn3 As Button, btn4 As Button)
        btn1.BackColor = Color.FromArgb(101, 194, 206)
        btn2.BackColor = Color.FromArgb(74, 88, 99)
        btn3.BackColor = Color.FromArgb(74, 88, 99)
        btn4.BackColor = Color.FromArgb(74, 88, 99)
    End Sub

    Public Sub CambiarColorTest(btn As Button)
        Dim i As Integer
        Dim ButtonList = New Button(3) {Form1.inicioBtn, Form1.miembrosBtn, Form1.pagosBtn, Form1.rutinasBtn}

        While i < 4
            If btn.Equals(ButtonList(i)) Then
                ButtonList(i).BackColor = Color.FromArgb(101, 194, 206)
            Else
                ButtonList(i).BackColor = Color.FromArgb(74, 88, 99)
            End If
            i = i + 1
        End While

    End Sub




End Module
