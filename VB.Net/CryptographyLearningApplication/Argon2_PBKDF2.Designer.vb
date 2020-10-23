<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Argon2_PBKDF2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ThreadsAmountTB = New System.Windows.Forms.TextBox()
        Me.RamSizeTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IterationTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HashBTN = New System.Windows.Forms.Button()
        Me.PasswordTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SaltBase64TB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SettingsCB = New System.Windows.Forms.ComboBox()
        Me.PasswordHash64TB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PasswordHashBigIntTB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PasswordHashHexaTB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.AmountOfUserTB = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ReadMeBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Core's thread amount"
        '
        'ThreadsAmountTB
        '
        Me.ThreadsAmountTB.Location = New System.Drawing.Point(351, 13)
        Me.ThreadsAmountTB.Name = "ThreadsAmountTB"
        Me.ThreadsAmountTB.ReadOnly = True
        Me.ThreadsAmountTB.Size = New System.Drawing.Size(877, 26)
        Me.ThreadsAmountTB.TabIndex = 1
        '
        'RamSizeTB
        '
        Me.RamSizeTB.Location = New System.Drawing.Point(351, 83)
        Me.RamSizeTB.Name = "RamSizeTB"
        Me.RamSizeTB.ReadOnly = True
        Me.RamSizeTB.Size = New System.Drawing.Size(877, 26)
        Me.RamSizeTB.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "RAM Size (MB)"
        '
        'IterationTB
        '
        Me.IterationTB.Location = New System.Drawing.Point(351, 157)
        Me.IterationTB.Name = "IterationTB"
        Me.IterationTB.ReadOnly = True
        Me.IterationTB.Size = New System.Drawing.Size(877, 26)
        Me.IterationTB.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Amount of Iterations"
        '
        'HashBTN
        '
        Me.HashBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.HashBTN.ForeColor = System.Drawing.Color.Green
        Me.HashBTN.Location = New System.Drawing.Point(12, 728)
        Me.HashBTN.Name = "HashBTN"
        Me.HashBTN.Size = New System.Drawing.Size(241, 91)
        Me.HashBTN.TabIndex = 6
        Me.HashBTN.Text = "Hash"
        Me.HashBTN.UseVisualStyleBackColor = True
        '
        'PasswordTB
        '
        Me.PasswordTB.Location = New System.Drawing.Point(351, 228)
        Me.PasswordTB.Name = "PasswordTB"
        Me.PasswordTB.Size = New System.Drawing.Size(877, 26)
        Me.PasswordTB.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Password"
        '
        'SaltBase64TB
        '
        Me.SaltBase64TB.Location = New System.Drawing.Point(351, 298)
        Me.SaltBase64TB.Name = "SaltBase64TB"
        Me.SaltBase64TB.ReadOnly = True
        Me.SaltBase64TB.Size = New System.Drawing.Size(877, 26)
        Me.SaltBase64TB.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Salt (Base 64)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 373)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Settings"
        '
        'SettingsCB
        '
        Me.SettingsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SettingsCB.FormattingEnabled = True
        Me.SettingsCB.Items.AddRange(New Object() {"Low", "Medium", "Recommended", "Custom"})
        Me.SettingsCB.Location = New System.Drawing.Point(351, 364)
        Me.SettingsCB.Name = "SettingsCB"
        Me.SettingsCB.Size = New System.Drawing.Size(877, 28)
        Me.SettingsCB.TabIndex = 12
        '
        'PasswordHash64TB
        '
        Me.PasswordHash64TB.Location = New System.Drawing.Point(351, 501)
        Me.PasswordHash64TB.Name = "PasswordHash64TB"
        Me.PasswordHash64TB.ReadOnly = True
        Me.PasswordHash64TB.Size = New System.Drawing.Size(877, 26)
        Me.PasswordHash64TB.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 501)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(227, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Password after hash (Base 64)"
        '
        'PasswordHashBigIntTB
        '
        Me.PasswordHashBigIntTB.Location = New System.Drawing.Point(351, 569)
        Me.PasswordHashBigIntTB.Name = "PasswordHashBigIntTB"
        Me.PasswordHashBigIntTB.ReadOnly = True
        Me.PasswordHashBigIntTB.Size = New System.Drawing.Size(877, 26)
        Me.PasswordHashBigIntTB.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 569)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(246, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Password after hash (Big Integer)"
        '
        'PasswordHashHexaTB
        '
        Me.PasswordHashHexaTB.Location = New System.Drawing.Point(351, 639)
        Me.PasswordHashHexaTB.Name = "PasswordHashHexaTB"
        Me.PasswordHashHexaTB.ReadOnly = True
        Me.PasswordHashHexaTB.Size = New System.Drawing.Size(877, 26)
        Me.PasswordHashHexaTB.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 639)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(205, 20)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Password after hash (Hexa)"
        '
        'AmountOfUserTB
        '
        Me.AmountOfUserTB.Location = New System.Drawing.Point(351, 435)
        Me.AmountOfUserTB.Name = "AmountOfUserTB"
        Me.AmountOfUserTB.ReadOnly = True
        Me.AmountOfUserTB.Size = New System.Drawing.Size(877, 26)
        Me.AmountOfUserTB.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 435)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(249, 20)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Amount of users using the system"
        '
        'ReadMeBTN
        '
        Me.ReadMeBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ReadMeBTN.ForeColor = System.Drawing.Color.Red
        Me.ReadMeBTN.Location = New System.Drawing.Point(351, 728)
        Me.ReadMeBTN.Name = "ReadMeBTN"
        Me.ReadMeBTN.Size = New System.Drawing.Size(228, 91)
        Me.ReadMeBTN.TabIndex = 21
        Me.ReadMeBTN.Text = "Read Me"
        Me.ReadMeBTN.UseVisualStyleBackColor = True
        '
        'Argon2_PBKDF2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1240, 835)
        Me.Controls.Add(Me.ReadMeBTN)
        Me.Controls.Add(Me.AmountOfUserTB)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PasswordHashHexaTB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PasswordHashBigIntTB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PasswordHash64TB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.SettingsCB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SaltBase64TB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PasswordTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.HashBTN)
        Me.Controls.Add(Me.IterationTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RamSizeTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ThreadsAmountTB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Argon2_PBKDF2"
        Me.Text = "Argon2_PBKDF2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ThreadsAmountTB As TextBox
    Friend WithEvents RamSizeTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents IterationTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents HashBTN As Button
    Friend WithEvents PasswordTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SaltBase64TB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SettingsCB As ComboBox
    Friend WithEvents PasswordHash64TB As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PasswordHashBigIntTB As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents PasswordHashHexaTB As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents AmountOfUserTB As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ReadMeBTN As Button
End Class
