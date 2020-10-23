<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salt_Pepper_String
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PasswordTB = New System.Windows.Forms.TextBox()
        Me.PepperTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SaltTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PasswordHashedHexaTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PasswordHashedBigIntTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.HashBTN = New System.Windows.Forms.Button()
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
        Me.PasswordTB.Location = New System.Drawing.Point(365, 13)
        Me.PasswordTB.Name = "PasswordTB"
        Me.PasswordTB.Size = New System.Drawing.Size(820, 26)
        Me.PasswordTB.TabIndex = 1
        '
        'PepperTB
        '
        Me.PepperTB.Location = New System.Drawing.Point(365, 80)
        Me.PepperTB.Name = "PepperTB"
        Me.PepperTB.ReadOnly = True
        Me.PepperTB.Size = New System.Drawing.Size(820, 26)
        Me.PepperTB.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Pepper (String)"
        '
        'SaltTB
        '
        Me.SaltTB.Location = New System.Drawing.Point(365, 152)
        Me.SaltTB.Name = "SaltTB"
        Me.SaltTB.ReadOnly = True
        Me.SaltTB.Size = New System.Drawing.Size(820, 26)
        Me.SaltTB.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Salt (String)"
        '
        'PasswordHashedHexaTB
        '
        Me.PasswordHashedHexaTB.Location = New System.Drawing.Point(365, 226)
        Me.PasswordHashedHexaTB.Name = "PasswordHashedHexaTB"
        Me.PasswordHashedHexaTB.ReadOnly = True
        Me.PasswordHashedHexaTB.Size = New System.Drawing.Size(820, 26)
        Me.PasswordHashedHexaTB.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(223, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Password after hashed (Hexa)"
        '
        'PasswordHashedBigIntTB
        '
        Me.PasswordHashedBigIntTB.Location = New System.Drawing.Point(365, 295)
        Me.PasswordHashedBigIntTB.Name = "PasswordHashedBigIntTB"
        Me.PasswordHashedBigIntTB.ReadOnly = True
        Me.PasswordHashedBigIntTB.Size = New System.Drawing.Size(820, 26)
        Me.PasswordHashedBigIntTB.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(264, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Password after hashed (Big Integer)"
        '
        'HashBTN
        '
        Me.HashBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.HashBTN.ForeColor = System.Drawing.Color.Green
        Me.HashBTN.Location = New System.Drawing.Point(17, 480)
        Me.HashBTN.Name = "HashBTN"
        Me.HashBTN.Size = New System.Drawing.Size(210, 76)
        Me.HashBTN.TabIndex = 10
        Me.HashBTN.Text = "Hash"
        Me.HashBTN.UseVisualStyleBackColor = True
        '
        'Salt_Pepper_String
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 568)
        Me.Controls.Add(Me.HashBTN)
        Me.Controls.Add(Me.PasswordHashedBigIntTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PasswordHashedHexaTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SaltTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PepperTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PasswordTB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Salt_Pepper_String"
        Me.Text = "Salt_Pepper_String"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PasswordTB As TextBox
    Friend WithEvents PepperTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents SaltTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PasswordHashedHexaTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PasswordHashedBigIntTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents HashBTN As Button
End Class
