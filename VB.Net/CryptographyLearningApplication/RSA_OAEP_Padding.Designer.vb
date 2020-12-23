<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RSA_OAEP_Padding
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PaddingCB = New System.Windows.Forms.ComboBox()
        Me.GoBTN = New System.Windows.Forms.Button()
        Me.DecryptedDataBigIntTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ReadMeBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data"
        '
        'DataTB
        '
        Me.DataTB.Location = New System.Drawing.Point(161, 12)
        Me.DataTB.Name = "DataTB"
        Me.DataTB.Size = New System.Drawing.Size(1025, 26)
        Me.DataTB.TabIndex = 1
        '
        'EncryptedDataTB
        '
        Me.EncryptedDataTB.Location = New System.Drawing.Point(161, 80)
        Me.EncryptedDataTB.Name = "EncryptedDataTB"
        Me.EncryptedDataTB.ReadOnly = True
        Me.EncryptedDataTB.Size = New System.Drawing.Size(1025, 26)
        Me.EncryptedDataTB.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 40)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Encrypted" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data"
        '
        'DecryptedDataTB
        '
        Me.DecryptedDataTB.Location = New System.Drawing.Point(161, 154)
        Me.DecryptedDataTB.Name = "DecryptedDataTB"
        Me.DecryptedDataTB.ReadOnly = True
        Me.DecryptedDataTB.Size = New System.Drawing.Size(1025, 26)
        Me.DecryptedDataTB.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 40)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Decrypted" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 40)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Choose a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "padding"
        '
        'PaddingCB
        '
        Me.PaddingCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PaddingCB.FormattingEnabled = True
        Me.PaddingCB.Items.AddRange(New Object() {"OAEP SHA1"})
        Me.PaddingCB.Location = New System.Drawing.Point(161, 300)
        Me.PaddingCB.Name = "PaddingCB"
        Me.PaddingCB.Size = New System.Drawing.Size(1025, 28)
        Me.PaddingCB.TabIndex = 7
        '
        'GoBTN
        '
        Me.GoBTN.Location = New System.Drawing.Point(12, 463)
        Me.GoBTN.Name = "GoBTN"
        Me.GoBTN.Size = New System.Drawing.Size(213, 78)
        Me.GoBTN.TabIndex = 8
        Me.GoBTN.Text = "Go" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Encrypt/Decrypt"
        Me.GoBTN.UseVisualStyleBackColor = True
        '
        'DecryptedDataBigIntTB
        '
        Me.DecryptedDataBigIntTB.Location = New System.Drawing.Point(161, 226)
        Me.DecryptedDataBigIntTB.Name = "DecryptedDataBigIntTB"
        Me.DecryptedDataBigIntTB.ReadOnly = True
        Me.DecryptedDataBigIntTB.Size = New System.Drawing.Size(1025, 26)
        Me.DecryptedDataBigIntTB.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 40)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Decrypted" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Data (BigInt)"
        '
        'ReadMeBTN
        '
        Me.ReadMeBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ReadMeBTN.ForeColor = System.Drawing.Color.Red
        Me.ReadMeBTN.Location = New System.Drawing.Point(338, 463)
        Me.ReadMeBTN.Name = "ReadMeBTN"
        Me.ReadMeBTN.Size = New System.Drawing.Size(213, 78)
        Me.ReadMeBTN.TabIndex = 11
        Me.ReadMeBTN.Text = "Read Me"
        Me.ReadMeBTN.UseVisualStyleBackColor = True
        '
        'RSA_OAEP_Padding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1198, 553)
        Me.Controls.Add(Me.ReadMeBTN)
        Me.Controls.Add(Me.DecryptedDataBigIntTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GoBTN)
        Me.Controls.Add(Me.PaddingCB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DecryptedDataTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.EncryptedDataTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataTB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RSA_OAEP_Padding"
        Me.Text = "RSA_OAEP_Padding"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataTB As TextBox
    Friend WithEvents EncryptedDataTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DecryptedDataTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PaddingCB As ComboBox
    Friend WithEvents GoBTN As Button
    Friend WithEvents DecryptedDataBigIntTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ReadMeBTN As Button
End Class
