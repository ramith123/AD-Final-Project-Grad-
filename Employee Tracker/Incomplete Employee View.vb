Imports System.Data.OleDb
Public Class Incomplete_Employee_View
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=employeeDatabase.accdb; Persist Security Info=False;"
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Incomplete_Employee_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using conn As New OleDbConnection(connString)
            conn.Open()
            Dim Adapter As New OleDbDataAdapter("SELECT Employee.[Employee ID], Employee.[Employee Name], [Work Entry].[Work Entry ID], [Work Entry].[Start time]
FROM Employee INNER JOIN [Work Entry] ON Employee.[Employee ID] = [Work Entry].[Employee ID]
WHERE ((([Work Entry].[Work schedule Status])=1))", conn)
            Dim dt As New DataTable()

            Adapter.Fill(dt)
            DataGridView1.DataSource = dt





        End Using



    End Sub

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)

    End Sub
End Class