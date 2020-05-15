<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RSAEncryptDecryptForm
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
        Me.MessageTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MessageByteArrayTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EncryptedMessageByteArrayTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DecryptedMessageByteArrayTB = New System.Windows.Forms.TextBox()
        Me.EncryptBTN = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DecryptedMessageTB = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Message "
        '
        'MessageTB
        '
        Me.MessageTB.Location = New System.Drawing.Point(196, 13)
        Me.MessageTB.Name = "MessageTB"
        Me.MessageTB.Size = New System.Drawing.Size(592, 26)
        Me.MessageTB.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 40)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Message Byte Array" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Hexa)"
        '
        'MessageByteArrayTB
        '
        Me.MessageByteArrayTB.Location = New System.Drawing.Point(196, 63)
        Me.MessageByteArrayTB.Name = "MessageByteArrayTB"
        Me.MessageByteArrayTB.ReadOnly = True
        Me.MessageByteArrayTB.Size = New System.Drawing.Size(592, 26)
        Me.MessageByteArrayTB.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 40)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Encrypted Message" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Byte Array (Hexa)"
        '
        'EncryptedMessageByteArrayTB
        '
        Me.EncryptedMessageByteArrayTB.Location = New System.Drawing.Point(196, 115)
        Me.EncryptedMessageByteArrayTB.Name = "EncryptedMessageByteArrayTB"
        Me.EncryptedMessageByteArrayTB.ReadOnly = True
        Me.EncryptedMessageByteArrayTB.Size = New System.Drawing.Size(592, 26)
        Me.EncryptedMessageByteArrayTB.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 40)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Decrypted Message " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Byte Array (Hexa)"
        '
        'DecryptedMessageByteArrayTB
        '
        Me.DecryptedMessageByteArrayTB.Location = New System.Drawing.Point(196, 176)
        Me.DecryptedMessageByteArrayTB.Name = "DecryptedMessageByteArrayTB"
        Me.DecryptedMessageByteArrayTB.ReadOnly = True
        Me.DecryptedMessageByteArrayTB.Size = New System.Drawing.Size(592, 26)
        Me.DecryptedMessageByteArrayTB.TabIndex = 7
        '
        'EncryptBTN
        '
        Me.EncryptBTN.Location = New System.Drawing.Point(614, 393)
        Me.EncryptBTN.Name = "EncryptBTN"
        Me.EncryptBTN.Size = New System.Drawing.Size(174, 45)
        Me.EncryptBTN.TabIndex = 8
        Me.EncryptBTN.Text = "Encrypt/Decrypt"
        Me.EncryptBTN.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Decrypted Message"
        '
        'DecryptedMessageTB
        '
        Me.DecryptedMessageTB.Location = New System.Drawing.Point(196, 225)
        Me.DecryptedMessageTB.Name = "DecryptedMessageTB"
        Me.DecryptedMessageTB.ReadOnly = True
        Me.DecryptedMessageTB.Size = New System.Drawing.Size(592, 26)
        Me.DecryptedMessageTB.TabIndex = 10
        '
        'RSAEncryptDecryptForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DecryptedMessageTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.EncryptBTN)
        Me.Controls.Add(Me.DecryptedMessageByteArrayTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.EncryptedMessageByteArrayTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MessageByteArrayTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MessageTB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RSAEncryptDecryptForm"
        Me.Text = "Encryption and Decryption using RSA (UTF 8 String)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MessageTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MessageByteArrayTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents EncryptedMessageByteArrayTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DecryptedMessageByteArrayTB As TextBox
    Friend WithEvents EncryptBTN As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DecryptedMessageTB As TextBox
End Class
