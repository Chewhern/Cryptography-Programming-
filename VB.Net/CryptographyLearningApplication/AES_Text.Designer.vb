<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AES_Text
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
        Me.DataBigIntTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataHexaTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EncryptedDataBigIntTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EncryptedDataHexaTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DecryptedDataTB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GoBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data"
        '
        'DataTB
        '
        Me.DataTB.Location = New System.Drawing.Point(257, 19)
        Me.DataTB.Name = "DataTB"
        Me.DataTB.Size = New System.Drawing.Size(936, 26)
        Me.DataTB.TabIndex = 1
        '
        'DataBigIntTB
        '
        Me.DataBigIntTB.Location = New System.Drawing.Point(257, 76)
        Me.DataBigIntTB.Name = "DataBigIntTB"
        Me.DataBigIntTB.ReadOnly = True
        Me.DataBigIntTB.Size = New System.Drawing.Size(936, 26)
        Me.DataBigIntTB.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Data Big Integer"
        '
        'DataHexaTB
        '
        Me.DataHexaTB.Location = New System.Drawing.Point(257, 138)
        Me.DataHexaTB.Name = "DataHexaTB"
        Me.DataHexaTB.ReadOnly = True
        Me.DataHexaTB.Size = New System.Drawing.Size(936, 26)
        Me.DataHexaTB.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Data Hexa"
        '
        'EncryptedDataBigIntTB
        '
        Me.EncryptedDataBigIntTB.Location = New System.Drawing.Point(257, 206)
        Me.EncryptedDataBigIntTB.Name = "EncryptedDataBigIntTB"
        Me.EncryptedDataBigIntTB.ReadOnly = True
        Me.EncryptedDataBigIntTB.Size = New System.Drawing.Size(936, 26)
        Me.EncryptedDataBigIntTB.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Encrypted Data Big Integer"
        '
        'EncryptedDataHexaTB
        '
        Me.EncryptedDataHexaTB.Location = New System.Drawing.Point(257, 271)
        Me.EncryptedDataHexaTB.Name = "EncryptedDataHexaTB"
        Me.EncryptedDataHexaTB.ReadOnly = True
        Me.EncryptedDataHexaTB.Size = New System.Drawing.Size(936, 26)
        Me.EncryptedDataHexaTB.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Encrypted Data Hexa"
        '
        'DecryptedDataTB
        '
        Me.DecryptedDataTB.Location = New System.Drawing.Point(257, 331)
        Me.DecryptedDataTB.Name = "DecryptedDataTB"
        Me.DecryptedDataTB.ReadOnly = True
        Me.DecryptedDataTB.Size = New System.Drawing.Size(936, 26)
        Me.DecryptedDataTB.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 331)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Decrypted Data"
        '
        'GoBTN
        '
        Me.GoBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GoBTN.ForeColor = System.Drawing.Color.Red
        Me.GoBTN.Location = New System.Drawing.Point(17, 434)
        Me.GoBTN.Name = "GoBTN"
        Me.GoBTN.Size = New System.Drawing.Size(256, 83)
        Me.GoBTN.TabIndex = 16
        Me.GoBTN.Text = "Go" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Encrypt/Decrypt"
        Me.GoBTN.UseVisualStyleBackColor = True
        '
        'AES_Text
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1205, 555)
        Me.Controls.Add(Me.GoBTN)
        Me.Controls.Add(Me.DecryptedDataTB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.EncryptedDataHexaTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.EncryptedDataBigIntTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataHexaTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataBigIntTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataTB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AES_Text"
        Me.Text = "AES_Text"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataTB As TextBox
    Friend WithEvents DataBigIntTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataHexaTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents EncryptedDataBigIntTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents EncryptedDataHexaTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DecryptedDataTB As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GoBTN As Button
End Class
