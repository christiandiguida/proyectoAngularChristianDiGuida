Imports System.Data.SqlClient
Public Class Form1
    Dim con As New SqlConnection("Data Source=212.101.89.7,55321;Initial Catalog=DDW04Pdb;Persist Security Info=True;User ID=DDW04Pusu;Password=T4buAzt2QcPYS7b")
    Dim cmd As New SqlCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DDW04PdbDataSet1.ALOJAMIENTO' table. You can move, or remove it, as needed.
        Me.ALOJAMIENTOTableAdapter1.Fill(Me.DDW04PdbDataSet1.ALOJAMIENTO)


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    End Sub



    Private Sub EditButton_Click(sender As Object, e As EventArgs) Handles EditButton.Click

        con.Open()

        cmd = con.CreateCommand()

        cmd.CommandType = CommandType.Text

        cmd.CommandText = "update  ALOJAMIENTO set CodAlojamiento = '" + CodAlojamientoTextBox.Text + "', Alojamiento = '" + AlojamientoTextBox.Text + "', Direccion = '" + DireccionTextBox.Text + "', Observaciones = '" + ObservacionesTextBox.Text + "' where Identifier = " & Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString()) & ""


        cmd.ExecuteNonQuery()
        MessageBox.Show("Elemento " & DataGridView1.SelectedCells.Item(0).Value & " modificado")

        con.Close()
        Me.ALOJAMIENTOTableAdapter1.Fill(Me.DDW04PdbDataSet1.ALOJAMIENTO)


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
