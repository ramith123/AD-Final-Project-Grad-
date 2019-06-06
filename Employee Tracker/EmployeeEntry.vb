Imports System.Data.OleDb
Public Class EmployeeEntry
    Dim EmpID As String = MainForm.EmpID.Text
    Dim count As Integer
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EmployeeEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim errorcheck As Integer
        Try

            EmployID.Text = MainForm.EmpID.Text

            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=employeeDatabase.accdb; Persist Security Info=False;")
                conn.Open()
                Dim EmpData As New OleDbCommand("SELECT * From Employee Where (((Employee.[Employee ID])=" & EmpID & "));", conn)
                Dim LocationCombo As New OleDbCommand("Select * From Location", conn)
                Dim TypeCombo As New OleDbCommand("SELECT * From [Employee Type]", conn)
                Dim check As OleDbDataReader = EmpData.ExecuteReader()



                Dim LocationComboboxData As OleDbDataReader = LocationCombo.ExecuteReader()
                Dim TypeComboboxData As OleDbDataReader = TypeCombo.ExecuteReader()


                While (check.Read())
                    count += 1
                End While
                check.Close()



                'Combo boxes fill
                While (LocationComboboxData.Read())
                    EmpLocationCombo.Items.Add(LocationComboboxData.GetString(0))
                End While
                While (TypeComboboxData.Read())
                    EmpTypeCombo.Items.Add(TypeComboboxData.GetString(0))
                End While

                LocationComboboxData.Close()
                TypeComboboxData.Close()
                Dim GetEmpData As OleDbDataReader = EmpData.ExecuteReader()

                If count = 1 Then

                    While (GetEmpData.Read())
                        EmpName.Text = GetEmpData.GetString(1)
                        EmpAddress.Text = GetEmpData.GetString(2)
                        EmpTypeCombo.SelectedText = GetEmpData.GetString(3)
                        EmpLocationCombo.SelectedText = GetEmpData.GetString(4)
                    End While
                End If





            End Using

        Catch help As Exception
            MessageBox.Show("" & help.ToString() & "", "ERROR! REFER TO TECHNICAL DOCUMENTATION")
            errorcheck = 1
        Finally
            If errorcheck = 1 Then
                Me.Close()
            End If

        End Try

    End Sub

    Private Sub EnterButton_Click(sender As Object, e As EventArgs) Handles EnterButton.Click
        Try
            Dim Name As String = EmpName.Text
            Dim Address As String = EmpAddress.Text
            Dim EmpType As String = EmpTypeCombo.Text
            Dim Location As String = EmpLocationCombo.Text


            Using conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=employeeDatabase.accdb; Persist Security Info=False;")
                conn.Open()
                If count = 1 Then
                    Dim UpdateData As New OleDbCommand(" UPDATE Employee SET [Employee Name] = """ & Name & """, [Employee Address] = """ & Address & """, [Employee Type] = """ & EmpType & """, [Site Name] = """ & Location & """ WHERE [Employee ID] =" & EmployID.Text & "", conn)
                    UpdateData.ExecuteNonQuery()
                    Me.Close()
                Else
                    Dim InsertData As New OleDbCommand("INSERT INTO Employee ([Employee ID], [Employee Name], [Employee Address], [Employee Type], [Site Name]) VALUES (" & EmpID.ToString() & ", """ & Name & """, """ & Address & """, """ & EmpType & """, """ & Location & """)", conn)
                    InsertData.ExecuteNonQuery()
                    Me.Close()
                End If
                MainForm.EmpID.Focus()
            End Using
        Catch help As Exception
            MessageBox.Show("" & help.ToString() & "", "ERROR! REFER TO TECHNICAL DOCUMENTATION")
        End Try
    End Sub

    Private Sub Resetbutton_Click(sender As Object, e As EventArgs) Handles Resetbutton.Click
        Dim Name As String = String.Empty
        Dim Address As String = String.Empty
        Dim EmpType As String = String.Empty
        Dim Location As String = String.Empty
    End Sub
End Class