<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TimeEnd = New System.Windows.Forms.Label()
        Me.TimeStart = New System.Windows.Forms.Label()
        Me.WorkEntryID = New System.Windows.Forms.Label()
        Me.EmpName = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EmpID = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COonectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Status = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.HoursCalButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.64024!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.35976!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TimeEnd, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TimeStart, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.WorkEntryID, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.EmpName, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.EmpID, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(289, 200)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(796, 338)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(237, 67)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Work Entry"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(237, 67)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Employee Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimeEnd
        '
        Me.TimeEnd.AutoSize = True
        Me.TimeEnd.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TimeEnd.Location = New System.Drawing.Point(246, 268)
        Me.TimeEnd.Name = "TimeEnd"
        Me.TimeEnd.Size = New System.Drawing.Size(547, 70)
        Me.TimeEnd.TabIndex = 12
        Me.TimeEnd.Text = "Time End"
        Me.TimeEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimeStart
        '
        Me.TimeStart.AutoSize = True
        Me.TimeStart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TimeStart.Location = New System.Drawing.Point(246, 201)
        Me.TimeStart.Name = "TimeStart"
        Me.TimeStart.Size = New System.Drawing.Size(547, 67)
        Me.TimeStart.TabIndex = 11
        Me.TimeStart.Text = "Time Start"
        Me.TimeStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'WorkEntryID
        '
        Me.WorkEntryID.AutoSize = True
        Me.WorkEntryID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WorkEntryID.Location = New System.Drawing.Point(246, 134)
        Me.WorkEntryID.Name = "WorkEntryID"
        Me.WorkEntryID.Size = New System.Drawing.Size(547, 67)
        Me.WorkEntryID.TabIndex = 10
        Me.WorkEntryID.Text = "Work Entry ID"
        Me.WorkEntryID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmpName
        '
        Me.EmpName.AutoSize = True
        Me.EmpName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EmpName.Location = New System.Drawing.Point(246, 67)
        Me.EmpName.Name = "EmpName"
        Me.EmpName.Size = New System.Drawing.Size(547, 67)
        Me.EmpName.TabIndex = 9
        Me.EmpName.Text = "Name"
        Me.EmpName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(3, 268)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(237, 70)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "TIme End"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(237, 67)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Time Start"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(237, 67)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Employee ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmpID
        '
        Me.EmpID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmpID.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpID.Location = New System.Drawing.Point(246, 3)
        Me.EmpID.Multiline = True
        Me.EmpID.Name = "EmpID"
        Me.EmpID.Size = New System.Drawing.Size(547, 61)
        Me.EmpID.TabIndex = 0
        Me.EmpID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ExitButton, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Button2, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(891, 656)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.69445!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.30555!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(194, 176)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'ExitButton
        '
        Me.ExitButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExitButton.Location = New System.Drawing.Point(3, 92)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(188, 81)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button2.Location = New System.Drawing.Point(3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(188, 83)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Edit/Add Employee"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Button5, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Button4, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(297, 656)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(446, 132)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'Button5
        '
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button5.Location = New System.Drawing.Point(297, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(146, 126)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Delete Work Entry"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button4.Location = New System.Drawing.Point(3, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(288, 126)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Start/Stop timer"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DatabaseToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1234, 40)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(64, 36)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(151, 38)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DatabaseToolStripMenuItem
        '
        Me.DatabaseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COonectToolStripMenuItem})
        Me.DatabaseToolStripMenuItem.Name = "DatabaseToolStripMenuItem"
        Me.DatabaseToolStripMenuItem.Size = New System.Drawing.Size(125, 36)
        Me.DatabaseToolStripMenuItem.Text = "Database"
        '
        'COonectToolStripMenuItem
        '
        Me.COonectToolStripMenuItem.Name = "COonectToolStripMenuItem"
        Me.COonectToolStripMenuItem.Size = New System.Drawing.Size(252, 38)
        Me.COonectToolStripMenuItem.Text = "Connect Test"
        '
        'Status
        '
        Me.Status.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Status.AutoSize = True
        Me.Status.Location = New System.Drawing.Point(284, 588)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(168, 25)
        Me.Status.TabIndex = 5
        Me.Status.Text = "Database status"
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button6.Location = New System.Drawing.Point(3, 3)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(160, 68)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "Incompleted Employees"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.HoursCalButton, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Button6, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(743, 84)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(342, 74)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'HoursCalButton
        '
        Me.HoursCalButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HoursCalButton.Location = New System.Drawing.Point(169, 3)
        Me.HoursCalButton.Name = "HoursCalButton"
        Me.HoursCalButton.Size = New System.Drawing.Size(170, 68)
        Me.HoursCalButton.TabIndex = 2
        Me.HoursCalButton.Text = "Calculate Hours in DB"
        Me.HoursCalButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(239, 950)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(559, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "REMEMBER: Press enter after typing  Barcode manually."
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 1073)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.TableLayoutPanel4)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Employee Tracking SYstem"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button2 As Button
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COonectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Status As Label
    Friend WithEvents EmpID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TimeEnd As Label
    Friend WithEvents TimeStart As Label
    Friend WithEvents WorkEntryID As Label
    Friend WithEvents EmpName As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents HoursCalButton As Button
End Class
