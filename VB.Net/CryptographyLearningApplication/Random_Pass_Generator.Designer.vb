<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Random_Pass_Generator
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
        Me.PasswordBytesLengthTB = New System.Windows.Forms.TextBox()
        Me.PasswordBase64TB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PasswordHexaTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PasswordBigIntTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GenerateBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Password Bytes Length (>=32)"
        '
        'PasswordBytesLengthTB
        '
        Me.PasswordBytesLengthTB.Location = New System.Drawing.Point(345, 13)
        Me.PasswordBytesLengthTB.Name = "PasswordBytesLengthTB"
        Me.PasswordBytesLengthTB.Size = New System.Drawing.Size(853, 26)
        Me.PasswordBytesLengthTB.TabIndex = 1
        '
        'PasswordBase64TB
        '
        Me.PasswordBase64TB.Location = New System.Drawing.Point(345, 79)
        Me.PasswordBase64TB.Name = "PasswordBase64TB"
        Me.PasswordBase64TB.ReadOnly = True
        Me.PasswordBase64TB.Size = New System.Drawing.Size(853, 26)
        Me.PasswordBase64TB.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password (Base 64)"
        '
        'PasswordHexaTB
        '
        Me.PasswordHexaTB.Location = New System.Drawing.Point(345, 149)
        Me.PasswordHexaTB.Name = "PasswordHexaTB"
        Me.PasswordHexaTB.ReadOnly = True
        Me.PasswordHexaTB.Size = New System.Drawing.Size(853, 26)
        Me.PasswordHexaTB.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password (Hexa)"
        '
        'PasswordBigIntTB
        '
        Me.PasswordBigIntTB.Location = New System.Drawing.Point(345, 220)
        Me.PasswordBigIntTB.Name = "PasswordBigIntTB"
        Me.PasswordBigIntTB.ReadOnly = True
        Me.PasswordBigIntTB.Size = New System.Drawing.Size(853, 26)
        Me.PasswordBigIntTB.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Password (Big Integer)"
        '
        'GenerateBTN
        '
        Me.GenerateBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GenerateBTN.ForeColor = System.Drawing.Color.Green
        Me.GenerateBTN.Location = New System.Drawing.Point(17, 363)
        Me.GenerateBTN.Name = "GenerateBTN"
        Me.GenerateBTN.Size = New System.Drawing.Size(250, 95)
        Me.GenerateBTN.TabIndex = 8
        Me.GenerateBTN.Text = "Generate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password"
        Me.GenerateBTN.UseVisualStyleBackColor = True
        '
        'Random_Pass_Generator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1210, 501)
        Me.Controls.Add(Me.GenerateBTN)
        Me.Controls.Add(Me.PasswordBigIntTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PasswordHexaTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PasswordBase64TB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PasswordBytesLengthTB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Random_Pass_Generator"
        Me.Text = "Random_Pass_Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PasswordBytesLengthTB As TextBox
    Friend WithEvents PasswordBase64TB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PasswordHexaTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PasswordBigIntTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GenerateBTN As Button
End Class
