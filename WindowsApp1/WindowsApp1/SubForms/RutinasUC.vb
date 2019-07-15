Imports System.Data.OleDb
Public Class RutinasUC

    Private r As New Random()

    Private Sub RutinasUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rutinasDataset As New DataSet
        rutinasDataset.Tables.Add("Rutina")
        Dim propietariosTableAdapter As New OleDbDataAdapter
        propietariosTableAdapter.SelectCommand = New OleDbCommand("SELECT * FROM Rutina", Form1.conexion)
        propietariosTableAdapter.Fill(rutinasDataset.Tables("Rutina"))


        cargardatagrid1("Rutina", DataGridView1)
        LongitudColumnas(DataGridView1, 200, 300, 200, 150)

        nombresLB.DataSource = rutinasDataset.Tables("Rutina")
        nombresLB.DisplayMember = "Nombre_Rutina"

        rutinaPB.DataBindings.Add("Image", rutinasDataset.Tables("Rutina"), "Imagen", True)
        rutinaPB.SizeMode = PictureBoxSizeMode.StretchImage
        'descripcionLB.Text = 
        descripcionLB.DataBindings.Add("Text", rutinasDataset.Tables("Rutina"), "Descripcion")




    End Sub

    Private Sub addRutinaBtn_Click(sender As Object, e As EventArgs) Handles addRutinaBtn.Click
        AgregarRutina.Show()
    End Sub



End Class
