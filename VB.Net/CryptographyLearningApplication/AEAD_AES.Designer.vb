<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AEAD_AES
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
        Me.DataHexaTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataBigIntTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AddDataTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EncryptedDataHexaTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EncryptedDataBigIntTB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DecryptedDataHexaTB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DecryptedDataBigIntTB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DecryptedDataTB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GoBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data"
        '
        'DataTB
        '
        Me.DataTB.Location = New System.Drawing.Point(306, 13)
        Me.DataTB.Name = "DataTB"
        Me.DataTB.Size = New System.Drawing.Size(915, 26)
        Me.DataTB.TabIndex = 1
        '
        'DataHexaTB
        '
        Me.DataHexaTB.Location = New System.Drawing.Point(306, 78)
        Me.DataHexaTB.Name = "DataHexaTB"
        Me.DataHexaTB.ReadOnly = True
        Me.DataHexaTB.Size = New System.Drawing.Size(915, 26)
        Me.DataHexaTB.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Data (Hexa)"
        '
        'DataBigIntTB
        '
        Me.DataBigIntTB.Location = New System.Drawing.Point(306, 147)
        Me.DataBigIntTB.Name = "DataBigIntTB"
        Me.DataBigIntTB.ReadOnly = True
        Me.DataBigIntTB.Size = New System.Drawing.Size(915, 26)
        Me.DataBigIntTB.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Data (Big Integer)"
        '
        'AddDataTB
        '
        Me.AddDataTB.Location = New System.Drawing.Point(306, 222)
        Me.AddDataTB.Name = "AddDataTB"
        Me.AddDataTB.Size = New System.Drawing.Size(915, 26)
        Me.AddDataTB.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Additional Data"
        '
        'EncryptedDataHexaTB
        '
        Me.EncryptedDataHexaTB.Location = New System.Drawing.Point(306, 300)
        Me.EncryptedDataHexaTB.Name = "EncryptedDataHexaTB"
        Me.EncryptedDataHexaTB.ReadOnly = True
        Me.EncryptedDataHexaTB.Size = New System.Drawing.Size(915, 26)
        Me.EncryptedDataHexaTB.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Encrypted Data (Hexa)"
        '
        'EncryptedDataBigIntTB
        '
        Me.EncryptedDataBigIntTB.Location = New System.Drawing.Point(306, 375)
        Me.EncryptedDataBigIntTB.Name = "EncryptedDataBigIntTB"
        Me.EncryptedDataBigIntTB.ReadOnly = True
        Me.EncryptedDataBigIntTB.Size = New System.Drawing.Size(915, 26)
        Me.EncryptedDataBigIntTB.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 375)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(212, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Encrypted Data (Big Integer)"
        '
        'DecryptedDataHexaTB
        '
        Me.DecryptedDataHexaTB.Location = New System.Drawing.Point(306, 452)
        Me.DecryptedDataHexaTB.Name = "DecryptedDataHexaTB"
        Me.DecryptedDataHexaTB.ReadOnly = True
        Me.DecryptedDataHexaTB.Size = New System.Drawing.Size(915, 26)
        Me.DecryptedDataHexaTB.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 452)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Decrypted Data (Hexa)"
        '
        'DecryptedDataBigIntTB
        '
        Me.DecryptedDataBigIntTB.Location = New System.Drawing.Point(306, 527)
        Me.DecryptedDataBigIntTB.Name = "DecryptedDataBigIntTB"
        Me.DecryptedDataBigIntTB.ReadOnly = True
        Me.DecryptedDataBigIntTB.Size = New System.Drawing.Size(915, 26)
        Me.DecryptedDataBigIntTB.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 527)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(213, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Decrypted Data (Big Integer)"
        '
        'DecryptedDataTB
        '
        Me.DecryptedDataTB.Location = New System.Drawing.Point(306, 602)
        Me.DecryptedDataTB.Name = "DecryptedDataTB"
        Me.DecryptedDataTB.ReadOnly = True
        Me.DecryptedDataTB.Size = New System.Drawing.Size(915, 26)
        Me.DecryptedDataTB.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 602)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Decrypted Data"
        '
        'GoBTN
        '
        Me.GoBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GoBTN.ForeColor = System.Drawing.Color.Green
        Me.GoBTN.Location = New System.Drawing.Point(13, 721)
        Me.GoBTN.Name = "GoBTN"
        Me.GoBTN.Size = New System.Drawing.Size(295, 99)
        Me.GoBTN.TabIndex = 18
        Me.GoBTN.Text = "Go" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Encrypt/Decrypt"
        Me.GoBTN.UseVisualStyleBackColor = True
        '
        'AEAD_AES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1233, 832)
        Me.Controls.Add(Me.GoBTN)
        Me.Controls.Add(Me.DecryptedDataTB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DecryptedDataBigIntTB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DecryptedDataHexaTB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.EncryptedDataBigIntTB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.EncryptedDataHexaTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AddDataTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataBigIntTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataHexaTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataTB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AEAD_AES"
        Me.Text = "AEAD_AES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataTB As TextBox
    Friend WithEvents DataHexaTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataBigIntTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AddDataTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents EncryptedDataHexaTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents EncryptedDataBigIntTB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DecryptedDataHexaTB As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DecryptedDataBigIntTB As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DecryptedDataTB As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GoBTN As Button
End Class
