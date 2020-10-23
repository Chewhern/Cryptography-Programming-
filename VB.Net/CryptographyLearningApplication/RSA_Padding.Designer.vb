<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RSA_Padding
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
        Me.DataTB = New System.Windows.Forms.TextBox()
        Me.EncryptedDataTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DecryptedDataTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GoBTN = New System.Windows.Forms.Button()
        Me.DecryptedDataBigIntTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ReadMeBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data"
        '
        'DataTB
        '
        Me.DataTB.Location = New System.Drawing.Point(103, 13)
        Me.DataTB.Name = "DataTB"
        Me.DataTB.Size = New System.Drawing.Size(830, 26)
        Me.DataTB.TabIndex = 1
        '
        'EncryptedDataTB
        '
        Me.EncryptedDataTB.Location = New System.Drawing.Point(103, 90)
        Me.EncryptedDataTB.Name = "EncryptedDataTB"
        Me.EncryptedDataTB.ReadOnly = True
        Me.EncryptedDataTB.Size = New System.Drawing.Size(830, 26)
        Me.EncryptedDataTB.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 40)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Encrypted" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data"
        '
        'DecryptedDataTB
        '
        Me.DecryptedDataTB.Location = New System.Drawing.Point(101, 158)
        Me.DecryptedDataTB.Name = "DecryptedDataTB"
        Me.DecryptedDataTB.ReadOnly = True
        Me.DecryptedDataTB.Size = New System.Drawing.Size(830, 26)
        Me.DecryptedDataTB.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 40)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Decrypted" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data"
        '
        'GoBTN
        '
        Me.GoBTN.Location = New System.Drawing.Point(17, 421)
        Me.GoBTN.Name = "GoBTN"
        Me.GoBTN.Size = New System.Drawing.Size(163, 82)
        Me.GoBTN.TabIndex = 6
        Me.GoBTN.Text = "Encrypt/Decrypt"
        Me.GoBTN.UseVisualStyleBackColor = True
        '
        'DecryptedDataBigIntTB
        '
        Me.DecryptedDataBigIntTB.Location = New System.Drawing.Point(101, 253)
        Me.DecryptedDataBigIntTB.Name = "DecryptedDataBigIntTB"
        Me.DecryptedDataBigIntTB.ReadOnly = True
        Me.DecryptedDataBigIntTB.Size = New System.Drawing.Size(830, 26)
        Me.DecryptedDataBigIntTB.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 60)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Decrypted" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(BigInt)"
        '
        'ReadMeBTN
        '
        Me.ReadMeBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ReadMeBTN.ForeColor = System.Drawing.Color.Red
        Me.ReadMeBTN.Location = New System.Drawing.Point(287, 421)
        Me.ReadMeBTN.Name = "ReadMeBTN"
        Me.ReadMeBTN.Size = New System.Drawing.Size(163, 82)
        Me.ReadMeBTN.TabIndex = 9
        Me.ReadMeBTN.Text = "Read Me"
        Me.ReadMeBTN.UseVisualStyleBackColor = True
        '
        'RSA_Padding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 515)
        Me.Controls.Add(Me.ReadMeBTN)
        Me.Controls.Add(Me.DecryptedDataBigIntTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GoBTN)
        Me.Controls.Add(Me.DecryptedDataTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.EncryptedDataTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataTB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RSA_Padding"
        Me.Text = "RSA_Padding"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataTB As TextBox
    Friend WithEvents EncryptedDataTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DecryptedDataTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GoBTN As Button
    Friend WithEvents DecryptedDataBigIntTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ReadMeBTN As Button
End Class
