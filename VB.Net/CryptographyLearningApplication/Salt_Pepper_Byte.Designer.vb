<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Salt_Pepper_Byte
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
        Me.PasswordTB = New System.Windows.Forms.TextBox()
        Me.SaltHexaTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PepperHexaTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PasswordAfterHashHexaTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PasswordAfterHashBase64TB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GoBTN = New System.Windows.Forms.Button()
        Me.ReadMeBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Password"
        '
        'PasswordTB
        '
        Me.PasswordTB.Location = New System.Drawing.Point(329, 13)
        Me.PasswordTB.Name = "PasswordTB"
        Me.PasswordTB.Size = New System.Drawing.Size(812, 26)
        Me.PasswordTB.TabIndex = 1
        '
        'SaltHexaTB
        '
        Me.SaltHexaTB.Location = New System.Drawing.Point(329, 71)
        Me.SaltHexaTB.Name = "SaltHexaTB"
        Me.SaltHexaTB.ReadOnly = True
        Me.SaltHexaTB.Size = New System.Drawing.Size(812, 26)
        Me.SaltHexaTB.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Salt (Hexa Array)"
        '
        'PepperHexaTB
        '
        Me.PepperHexaTB.Location = New System.Drawing.Point(329, 129)
        Me.PepperHexaTB.Name = "PepperHexaTB"
        Me.PepperHexaTB.ReadOnly = True
        Me.PepperHexaTB.Size = New System.Drawing.Size(812, 26)
        Me.PepperHexaTB.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(152, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Pepper (Hexa Array)"
        '
        'PasswordAfterHashHexaTB
        '
        Me.PasswordAfterHashHexaTB.Location = New System.Drawing.Point(329, 192)
        Me.PasswordAfterHashHexaTB.Name = "PasswordAfterHashHexaTB"
        Me.PasswordAfterHashHexaTB.ReadOnly = True
        Me.PasswordAfterHashHexaTB.Size = New System.Drawing.Size(812, 26)
        Me.PasswordAfterHashHexaTB.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(251, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Password After Hash (Hexa Array)"
        '
        'PasswordAfterHashBase64TB
        '
        Me.PasswordAfterHashBase64TB.Location = New System.Drawing.Point(329, 257)
        Me.PasswordAfterHashBase64TB.Name = "PasswordAfterHashBase64TB"
        Me.PasswordAfterHashBase64TB.ReadOnly = True
        Me.PasswordAfterHashBase64TB.Size = New System.Drawing.Size(812, 26)
        Me.PasswordAfterHashBase64TB.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(232, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Password After Hash (Base 64)"
        '
        'GoBTN
        '
        Me.GoBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GoBTN.ForeColor = System.Drawing.Color.Green
        Me.GoBTN.Location = New System.Drawing.Point(17, 477)
        Me.GoBTN.Name = "GoBTN"
        Me.GoBTN.Size = New System.Drawing.Size(228, 95)
        Me.GoBTN.TabIndex = 10
        Me.GoBTN.Text = "Go/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Hash"
        Me.GoBTN.UseVisualStyleBackColor = True
        '
        'ReadMeBTN
        '
        Me.ReadMeBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ReadMeBTN.ForeColor = System.Drawing.Color.Red
        Me.ReadMeBTN.Location = New System.Drawing.Point(329, 477)
        Me.ReadMeBTN.Name = "ReadMeBTN"
        Me.ReadMeBTN.Size = New System.Drawing.Size(224, 95)
        Me.ReadMeBTN.TabIndex = 11
        Me.ReadMeBTN.Text = "Read Me"
        Me.ReadMeBTN.UseVisualStyleBackColor = True
        '
        'Salt_Pepper_Byte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 584)
        Me.Controls.Add(Me.ReadMeBTN)
        Me.Controls.Add(Me.GoBTN)
        Me.Controls.Add(Me.PasswordAfterHashBase64TB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PasswordAfterHashHexaTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PepperHexaTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SaltHexaTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PasswordTB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Salt_Pepper_Byte"
        Me.Text = "Salt_Pepper_Byte"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PasswordTB As TextBox
    Friend WithEvents SaltHexaTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PepperHexaTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PasswordAfterHashHexaTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PasswordAfterHashBase64TB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GoBTN As Button
    Friend WithEvents ReadMeBTN As Button
End Class
