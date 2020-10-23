<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signal_Out_Of_Band_Authentication
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MyDiffieHellmanPKTB = New System.Windows.Forms.TextBox()
        Me.OtherDiffieHellmanPKTB = New System.Windows.Forms.TextBox()
        Me.MutualFingerPrintTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CreateBTN = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Your Diffie Hellman Public Key"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Other Diffie Hellman Public Key"
        '
        'MyDiffieHellmanPKTB
        '
        Me.MyDiffieHellmanPKTB.Location = New System.Drawing.Point(17, 46)
        Me.MyDiffieHellmanPKTB.Name = "MyDiffieHellmanPKTB"
        Me.MyDiffieHellmanPKTB.ReadOnly = True
        Me.MyDiffieHellmanPKTB.Size = New System.Drawing.Size(980, 26)
        Me.MyDiffieHellmanPKTB.TabIndex = 2
        '
        'OtherDiffieHellmanPKTB
        '
        Me.OtherDiffieHellmanPKTB.Location = New System.Drawing.Point(17, 157)
        Me.OtherDiffieHellmanPKTB.Name = "OtherDiffieHellmanPKTB"
        Me.OtherDiffieHellmanPKTB.ReadOnly = True
        Me.OtherDiffieHellmanPKTB.Size = New System.Drawing.Size(980, 26)
        Me.OtherDiffieHellmanPKTB.TabIndex = 3
        '
        'MutualFingerPrintTB
        '
        Me.MutualFingerPrintTB.Location = New System.Drawing.Point(17, 271)
        Me.MutualFingerPrintTB.Name = "MutualFingerPrintTB"
        Me.MutualFingerPrintTB.ReadOnly = True
        Me.MutualFingerPrintTB.Size = New System.Drawing.Size(980, 26)
        Me.MutualFingerPrintTB.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mutual Finger Print"
        '
        'CreateBTN
        '
        Me.CreateBTN.Location = New System.Drawing.Point(17, 482)
        Me.CreateBTN.Name = "CreateBTN"
        Me.CreateBTN.Size = New System.Drawing.Size(175, 69)
        Me.CreateBTN.TabIndex = 6
        Me.CreateBTN.Text = "Create"
        Me.CreateBTN.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(170, 341)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(480, 26)
        Me.TextBox4.TabIndex = 8
        Me.TextBox4.Text = "https://www.youtube.com/watch?v=DXv1boalsDI"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Mutual Finger Print"
        '
        'Signal_Out_Of_Band_Authentication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 563)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CreateBTN)
        Me.Controls.Add(Me.MutualFingerPrintTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.OtherDiffieHellmanPKTB)
        Me.Controls.Add(Me.MyDiffieHellmanPKTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Signal_Out_Of_Band_Authentication"
        Me.Text = "Signal_Out_Of_Band_Authentication"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MyDiffieHellmanPKTB As TextBox
    Friend WithEvents OtherDiffieHellmanPKTB As TextBox
    Friend WithEvents MutualFingerPrintTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CreateBTN As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
End Class
