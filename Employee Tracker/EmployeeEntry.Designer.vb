<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeEntry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EmpName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EmpAddress = New System.Windows.Forms.TextBox()
        Me.EmpTypeCombo = New System.Windows.Forms.ComboBox()
        Me.EmpLocationCombo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EnterButton = New System.Windows.Forms.Button()
        Me.Resetbutton = New System.Windows.Forms.Button()
        Me.EmployID = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(14, 4, 0, 4)
        Me.MenuStrip1.Size = New System.Drawing.Size(2022, 44)
        Me.MenuStrip1.TabIndex = 5
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
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 136)
        Me.Label1.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 42)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Employee ID: "
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(186, 283)
        Me.Label2.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 42)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Name:"
        '
        'EmpName
        '
        Me.EmpName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EmpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpName.Location = New System.Drawing.Point(504, 270)
        Me.EmpName.Margin = New System.Windows.Forms.Padding(7)
        Me.EmpName.Name = "EmpName"
        Me.EmpName.Size = New System.Drawing.Size(902, 49)
        Me.EmpName.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(221, 599)
        Me.Label3.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 42)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Type:"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(186, 457)
        Me.Label4.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 42)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Address:"
        '
        'EmpAddress
        '
        Me.EmpAddress.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EmpAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpAddress.Location = New System.Drawing.Point(504, 443)
        Me.EmpAddress.Margin = New System.Windows.Forms.Padding(7)
        Me.EmpAddress.Name = "EmpAddress"
        Me.EmpAddress.Size = New System.Drawing.Size(902, 49)
        Me.EmpAddress.TabIndex = 12
        '
        'EmpTypeCombo
        '
        Me.EmpTypeCombo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EmpTypeCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpTypeCombo.FormattingEnabled = True
        Me.EmpTypeCombo.Location = New System.Drawing.Point(504, 596)
        Me.EmpTypeCombo.Name = "EmpTypeCombo"
        Me.EmpTypeCombo.Size = New System.Drawing.Size(395, 50)
        Me.EmpTypeCombo.TabIndex = 14
        '
        'EmpLocationCombo
        '
        Me.EmpLocationCombo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EmpLocationCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpLocationCombo.FormattingEnabled = True
        Me.EmpLocationCombo.Location = New System.Drawing.Point(519, 740)
        Me.EmpLocationCombo.Name = "EmpLocationCombo"
        Me.EmpLocationCombo.Size = New System.Drawing.Size(380, 50)
        Me.EmpLocationCombo.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(221, 748)
        Me.Label5.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(170, 42)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Location:"
        '
        'EnterButton
        '
        Me.EnterButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EnterButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnterButton.Location = New System.Drawing.Point(1319, 842)
        Me.EnterButton.Name = "EnterButton"
        Me.EnterButton.Size = New System.Drawing.Size(231, 85)
        Me.EnterButton.TabIndex = 17
        Me.EnterButton.Text = "Enter"
        Me.EnterButton.UseVisualStyleBackColor = True
        '
        'Resetbutton
        '
        Me.Resetbutton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Resetbutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resetbutton.Location = New System.Drawing.Point(1578, 842)
        Me.Resetbutton.Name = "Resetbutton"
        Me.Resetbutton.Size = New System.Drawing.Size(231, 85)
        Me.Resetbutton.TabIndex = 18
        Me.Resetbutton.Text = "Reset"
        Me.Resetbutton.UseVisualStyleBackColor = True
        '
        'EmployID
        '
        Me.EmployID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EmployID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmployID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployID.Location = New System.Drawing.Point(509, 136)
        Me.EmployID.Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
        Me.EmployID.Name = "EmployID"
        Me.EmployID.Size = New System.Drawing.Size(883, 55)
        Me.EmployID.TabIndex = 19
        Me.EmployID.Text = "Employee ID number"
        Me.EmployID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmployeeEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(28.0!, 55.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2022, 1023)
        Me.Controls.Add(Me.EmployID)
        Me.Controls.Add(Me.Resetbutton)
        Me.Controls.Add(Me.EnterButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.EmpLocationCombo)
        Me.Controls.Add(Me.EmpTypeCombo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.EmpAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.EmpName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(7)
        Me.Name = "EmployeeEntry"
        Me.Text = "EmployeeEntry"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EmpName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents EmpAddress As TextBox
    Friend WithEvents EmpTypeCombo As ComboBox
    Friend WithEvents EmpLocationCombo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents EnterButton As Button
    Friend WithEvents Resetbutton As Button
    Friend WithEvents EmployID As Label
End Class
