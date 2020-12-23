<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Random_Pass_Generator_System_String
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
        Me.PasswordLengthTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PasswordBTTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PasswordActualLengthTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PasswordATTB = New System.Windows.Forms.TextBox()
        Me.GenPassBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Minimum Required Password Length"
        '
        'PasswordLengthTB
        '
        Me.PasswordLengthTB.Location = New System.Drawing.Point(288, 13)
        Me.PasswordLengthTB.Name = "PasswordLengthTB"
        Me.PasswordLengthTB.Size = New System.Drawing.Size(183, 26)
        Me.PasswordLengthTB.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password Before Trimming"
        '
        'PasswordBTTB
        '
        Me.PasswordBTTB.Location = New System.Drawing.Point(288, 63)
        Me.PasswordBTTB.Multiline = True
        Me.PasswordBTTB.Name = "PasswordBTTB"
        Me.PasswordBTTB.ReadOnly = True
        Me.PasswordBTTB.Size = New System.Drawing.Size(592, 70)
        Me.PasswordBTTB.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password Length"
        '
        'PasswordActualLengthTB
        '
        Me.PasswordActualLengthTB.Location = New System.Drawing.Point(288, 167)
        Me.PasswordActualLengthTB.Name = "PasswordActualLengthTB"
        Me.PasswordActualLengthTB.Size = New System.Drawing.Size(183, 26)
        Me.PasswordActualLengthTB.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Password After Trimming"
        '
        'PasswordATTB
        '
        Me.PasswordATTB.Location = New System.Drawing.Point(288, 223)
        Me.PasswordATTB.Multiline = True
        Me.PasswordATTB.Name = "PasswordATTB"
        Me.PasswordATTB.ReadOnly = True
        Me.PasswordATTB.Size = New System.Drawing.Size(592, 71)
        Me.PasswordATTB.TabIndex = 7
        '
        'GenPassBTN
        '
        Me.GenPassBTN.Location = New System.Drawing.Point(17, 408)
        Me.GenPassBTN.Name = "GenPassBTN"
        Me.GenPassBTN.Size = New System.Drawing.Size(275, 81)
        Me.GenPassBTN.TabIndex = 8
        Me.GenPassBTN.Text = "Generate Password"
        Me.GenPassBTN.UseVisualStyleBackColor = True
        '
        'Random_Pass_Generator_System_String
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1210, 501)
        Me.Controls.Add(Me.GenPassBTN)
        Me.Controls.Add(Me.PasswordATTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PasswordActualLengthTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PasswordBTTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PasswordLengthTB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Random_Pass_Generator_System_String"
        Me.Text = "Random_Pass_Generator_System_String"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PasswordLengthTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PasswordBTTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PasswordActualLengthTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PasswordATTB As TextBox
    Friend WithEvents GenPassBTN As Button
End Class
