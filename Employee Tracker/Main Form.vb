Imports System.Windows.Forms
Imports System.Data.OleDb

Public Class MainForm
    Dim WEstatus As Integer
    Dim employeeID As String
    Dim WEID As Integer
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=employeeDatabase.accdb; Persist Security Info=False;"

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub COonectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COonectToolStripMenuItem.Click
        Using Conn As New OleDbConnection(connString)
            Try
                Conn.Open()
                Status.Text = "Connection Established"
                Status.ForeColor = Color.Green
            Catch ex As Exception
                Status.Text = "Connection Failed.   " + ControlChars.NewLine + ex.Message
                Status.ForeColor = Color.Red

            End Try
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmpName.Text = String.Empty
        WorkEntryID.Text = String.Empty
        TimeEnd.Text = String.Empty
        TimeStart.Text = String.Empty
        Status.Text = String.Empty

    End Sub

    Private Sub EmpID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EmpID.KeyPress
        If (e.KeyChar < "0" Or e.KeyChar > "9") And e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub EmpID_KeyDown(sender As Object, e As KeyEventArgs) Handles EmpID.KeyDown
        WEstatus = 0

        If e.KeyCode = Keys.Enter Then
            EmpName.Text = String.Empty
            WorkEntryID.Text = String.Empty
            TimeEnd.Text = String.Empty
            TimeStart.Text = String.Empty
            Status.Text = String.Empty

            Status.Text = "yay"
            EmpID.Text.Remove(EmpID.Text.Count = -1)
            employeeID = EmpID.Text
            EmpID.Text = String.Empty
            EmpID.Text = employeeID
            Status.Text = employeeID
            Focus()
            Using conn As New OleDbConnection(connString)
                conn.Open()

                Dim employeeName As String
                Dim WorkEntryCheck As New OleDbCommand("SELECT * From [Work Entry]
                WHERE [Employee ID]= " & employeeID & "", conn)
                Dim WorkEntryCheckStartTime As New OleDbCommand("SELECT * From [Work Entry] 
                WHERE [Employee ID]= " & employeeID & "and [Work schedule Status]= 1 ", conn)
                Dim WorkEntryCheckEndTime As New OleDbCommand("SELECT * From [Work Entry] 
                WHERE [Employee ID]= " & employeeID & "and [Work schedule Status]= 2 ", conn)
                Dim Empcheckcommand As New OleDbCommand("SELECT * FROM Employee
                WHERE Employee.[Employee ID]=" & employeeID & "", conn)
                Dim StartEntry As New OleDbCommand("INSERT INTO [Work Entry] ([Start time], 
                [Work schedule Status], [Employee ID]) VALUES 
                ('" & DateTime.Now & "', 1, " & employeeID & ")", conn)

                Dim readercheck As OleDbDataReader = Empcheckcommand.ExecuteReader()
                Dim readerempentry As OleDbDataReader = WorkEntryCheck.ExecuteReader()

                Dim count As Integer = 0


                While (readercheck.Read())
                    count += 1
                End While
                readercheck.Close()





                If count = 1 Then
                    Dim readdata As OleDbDataReader = (Empcheckcommand.ExecuteReader())
                    While (readdata.Read())
                        employeeName = readdata.GetString(1)
                        EmpName.Text = employeeName
                    End While
                    readdata.Close()

                    While (readerempentry.Read())
                        WEstatus = readerempentry.GetInt16(5)
                    End While
                    readerempentry.Close()
                    If WEstatus = 0 Then
                        Dim dialogResult As DialogResult
                        dialogResult = MessageBox.Show("This employee Does not Have a New timer. Should I start One?", "Employee time start", MessageBoxButtons.OKCancel)
                        If dialogResult = DialogResult.OK Then
                            StartEntry.ExecuteNonQuery()
                            Dim readWEdata As OleDbDataReader = (WorkEntryCheck.ExecuteReader())
                            While readWEdata.Read()
                                WorkEntryID.Text = readWEdata.GetInt32(0)
                                Integer.TryParse(WorkEntryID.Text, WEID)
                                TimeStart.Text = readWEdata.GetString(1)
                            End While
                        End If
                    ElseIf WEstatus = 1 Then
                        Dim readWEdata As OleDbDataReader = (WorkEntryCheck.ExecuteReader())
                        While readWEdata.Read()
                            WorkEntryID.Text = readWEdata.GetInt32(0)
                            Integer.TryParse(WorkEntryID.Text, WEID)
                            TimeStart.Text = readWEdata.GetString(1)


                        End While
                    ElseIf WEstatus = 2 Then
                        Dim readWedata As OleDbDataReader = (WorkEntryCheck.ExecuteReader())
                        While readWedata.Read()
                            TimeEnd.Text = readWedata.GetString(2)
                            TimeStart.Text = readWedata.GetString(1)
                            WorkEntryID.Text = readWedata.GetInt32(0)
                            Integer.TryParse(WorkEntryID.Text, WEID)
                        End While

                    End If


                ElseIf count > 1 Then
                    MessageBox.Show("There is a duplication error. Please Check database")

                ElseIf count = 0 Then
                    MessageBox.Show("This is a new Employee. CLick Edit/Add employee to add Employee Information.")
                End If

                Status.Text = WEstatus.ToString

            End Using

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim box = New EmployeeEntry()
        box.Show()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        EmpID.Focus()

        Using Conn As New OleDbConnection(connString)
            Conn.Open()
            Dim StopEntry As New OleDbCommand("UPDATE [Work Entry] SET [End time] ='" & DateTime.Now & "', [Work schedule Status] = 2 WHERE [Employee ID] = " & employeeID & " AND [Work schedule Status] = 1", Conn)
            Dim StartEntry As New OleDbCommand("INSERT INTO [Work Entry] ([Start time], [Work schedule Status], [Employee ID]) VALUES ('" & DateTime.Now & "', 1, " & EmpID.Text & ")", Conn)
            Dim WorkEntryCheck As New OleDbCommand("SELECT * From [Work Entry] WHERE [Employee ID]= " & employeeID & "", Conn)

            If WEstatus = 1 Then


                StopEntry.ExecuteNonQuery()


                Status.Text = WEstatus.ToString
                Dim read As OleDbDataReader = WorkEntryCheck.ExecuteReader()
                While read.Read()
                    WorkEntryID.Text = read.GetInt32(0)
                    Integer.TryParse(WorkEntryID.Text, WEID)
                    TimeStart.Text = read.GetString(1)
                    TimeEnd.Text = read.GetString(2)
                    WEstatus = read.GetInt16(5)
                End While

            ElseIf (WEstatus <> 1) Then
                WorkEntryID.Text = String.Empty
                TimeEnd.Text = String.Empty
                TimeStart.Text = String.Empty


                StartEntry.ExecuteNonQuery()
                Status.Text = WEstatus.ToString



                Dim read As OleDbDataReader = WorkEntryCheck.ExecuteReader()
                While read.Read()
                    WorkEntryID.Text = read.GetInt32(0)
                    Integer.TryParse(WorkEntryID.Text, WEID)
                    TimeStart.Text = read.GetString(1)
                    TimeEnd.Text = String.Empty
                    WEstatus = read.GetInt16(5)
                    Status.Text = WEstatus.ToString
                End While

            End If
        End Using
        employeeID = String.Empty
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        EmpID.Focus()
        Using Conn As New OleDbConnection(connString)
            Conn.Open()

            Dim DelLastWE As New OleDbCommand("DELETE FROM [Work Entry] WHERE [Work Entry ID]=" & WEID & " AND [Employee ID]=" & EmpID.Text & "", Conn)
            DelLastWE.ExecuteNonQuery()
            WorkEntryID.Text = String.Empty
            TimeEnd.Text = String.Empty
            TimeStart.Text = String.Empty
        End Using
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        EmpID.Focus()
        Dim box = New Incomplete_Employee_View()
        box.Show()
    End Sub

    Private Sub HoursCalButton_Click(sender As Object, e As EventArgs) Handles HoursCalButton.Click
        EmpID.Focus()
        Dim StartDate As DateTime
        Dim EndDate As DateTime
        Dim hours As Double
        Dim minutes As Double
        Dim WEID As Integer

        Using conn As New OleDbConnection(connString)
            conn.Open()
            Dim WorkEntryData As New OleDbCommand("SELECT * from [Work Entry] ", conn)
            Dim Getdate As OleDbDataReader = WorkEntryData.ExecuteReader()
            While (Getdate.Read())
                WEID = Getdate.GetInt32(0)
                StartDate = Getdate.GetString(1)
                EndDate = Getdate.GetString(2)
                minutes = DateDiff(DateInterval.Minute, StartDate, EndDate)
                hours = Math.Round(minutes / 60, 0)
                hours = hours + 1
                Dim SetWorkHours As New OleDbCommand("UPDATE [Work Entry] SET [Work Entry].[Hours Worked] = " & hours.ToString() & " WHERE ((([Work Entry].[Work Entry ID])=" & WEID & "));", conn)
                SetWorkHours.ExecuteNonQuery()
            End While

            Status.Text = hours.ToString
        End Using
    End Sub
End Class
