<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RSA
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
        Me.PTB = New System.Windows.Forms.TextBox()
        Me.QTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ModulusTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ExponentTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataTB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataBigIntTB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EncryptedDataTB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DecryptedDataTB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GoBTN = New System.Windows.Forms.Button()
        Me.ReadMeBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "P"
        '
        'PTB
        '
        Me.PTB.Location = New System.Drawing.Point(167, 13)
        Me.PTB.Name = "PTB"
        Me.PTB.Size = New System.Drawing.Size(736, 26)
        Me.PTB.TabIndex = 1
        Me.PTB.Text = "197"
        '
        'QTB
        '
        Me.QTB.Location = New System.Drawing.Point(167, 59)
        Me.QTB.Name = "QTB"
        Me.QTB.Size = New System.Drawing.Size(736, 26)
        Me.QTB.TabIndex = 3
        Me.QTB.Text = "199"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Q"
        '
        'ModulusTB
        '
        Me.ModulusTB.Location = New System.Drawing.Point(167, 113)
        Me.ModulusTB.Name = "ModulusTB"
        Me.ModulusTB.ReadOnly = True
        Me.ModulusTB.Size = New System.Drawing.Size(736, 26)
        Me.ModulusTB.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Modulus"
        '
        'ExponentTB
        '
        Me.ExponentTB.Location = New System.Drawing.Point(167, 163)
        Me.ExponentTB.Name = "ExponentTB"
        Me.ExponentTB.ReadOnly = True
        Me.ExponentTB.Size = New System.Drawing.Size(736, 26)
        Me.ExponentTB.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Exponent"
        '
        'DTB
        '
        Me.DTB.Location = New System.Drawing.Point(167, 209)
        Me.DTB.Name = "DTB"
        Me.DTB.ReadOnly = True
        Me.DTB.Size = New System.Drawing.Size(736, 26)
        Me.DTB.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "D"
        '
        'DataTB
        '
        Me.DataTB.Location = New System.Drawing.Point(167, 265)
        Me.DataTB.Name = "DataTB"
        Me.DataTB.Size = New System.Drawing.Size(736, 26)
        Me.DataTB.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 40)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Data to be" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "encrypted"
        '
        'DataBigIntTB
        '
        Me.DataBigIntTB.Location = New System.Drawing.Point(167, 339)
        Me.DataBigIntTB.Name = "DataBigIntTB"
        Me.DataBigIntTB.ReadOnly = True
        Me.DataBigIntTB.Size = New System.Drawing.Size(736, 26)
        Me.DataBigIntTB.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 339)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 40)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Data to be" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "encrypted(BigInt)"
        '
        'EncryptedDataTB
        '
        Me.EncryptedDataTB.Location = New System.Drawing.Point(167, 404)
        Me.EncryptedDataTB.Name = "EncryptedDataTB"
        Me.EncryptedDataTB.ReadOnly = True
        Me.EncryptedDataTB.Size = New System.Drawing.Size(736, 26)
        Me.EncryptedDataTB.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 404)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 40)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Encrypted" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data"
        '
        'DecryptedDataTB
        '
        Me.DecryptedDataTB.Location = New System.Drawing.Point(167, 463)
        Me.DecryptedDataTB.Name = "DecryptedDataTB"
        Me.DecryptedDataTB.ReadOnly = True
        Me.DecryptedDataTB.Size = New System.Drawing.Size(736, 26)
        Me.DecryptedDataTB.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 463)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 40)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Decrypted" & Global.Microsoft.VisualBasic.ChrW(10) & "Data"
        '
        'GoBTN
        '
        Me.GoBTN.Location = New System.Drawing.Point(17, 535)
        Me.GoBTN.Name = "GoBTN"
        Me.GoBTN.Size = New System.Drawing.Size(177, 71)
        Me.GoBTN.TabIndex = 18
        Me.GoBTN.Text = "Go" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Encrypt/Decrypt)"
        Me.GoBTN.UseVisualStyleBackColor = True
        '
        'ReadMeBTN
        '
        Me.ReadMeBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ReadMeBTN.ForeColor = System.Drawing.Color.Red
        Me.ReadMeBTN.Location = New System.Drawing.Point(275, 535)
        Me.ReadMeBTN.Name = "ReadMeBTN"
        Me.ReadMeBTN.Size = New System.Drawing.Size(177, 71)
        Me.ReadMeBTN.TabIndex = 19
        Me.ReadMeBTN.Text = "Read Me"
        Me.ReadMeBTN.UseVisualStyleBackColor = True
        '
        'RSA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1167, 632)
        Me.Controls.Add(Me.ReadMeBTN)
        Me.Controls.Add(Me.GoBTN)
        Me.Controls.Add(Me.DecryptedDataTB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.EncryptedDataTB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DataBigIntTB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataTB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ExponentTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ModulusTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.QTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PTB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RSA"
        Me.Text = "RSA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PTB As TextBox
    Friend WithEvents QTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ModulusTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ExponentTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataTB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DataBigIntTB As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents EncryptedDataTB As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DecryptedDataTB As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GoBTN As Button
    Friend WithEvents ReadMeBTN As Button
End Class
