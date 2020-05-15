<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KeyGenerationForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.QTextBox = New System.Windows.Forms.TextBox()
        Me.PTextBox = New System.Windows.Forms.TextBox()
        Me.ModulusTextBox = New System.Windows.Forms.TextBox()
        Me.ExponentTextBox = New System.Windows.Forms.TextBox()
        Me.DTextBox = New System.Windows.Forms.TextBox()
        Me.DPTextBox = New System.Windows.Forms.TextBox()
        Me.DQTextBox = New System.Windows.Forms.TextBox()
        Me.GenerateBTN = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.InverseQTextBox = New System.Windows.Forms.TextBox()
        Me.TestBTN = New System.Windows.Forms.Button()
        Me.EncryptionBTN = New System.Windows.Forms.Button()
        Me.GenerateCustomBTN = New System.Windows.Forms.Button()
        Me.GenerateSmallerKeyBTN = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.IndexTB = New System.Windows.Forms.TextBox()
        Me.GenerateBiggerRandomKeyBTN = New System.Windows.Forms.Button()
        Me.GenerateSmallerRandomKeyBTN = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RandomIndexTB = New System.Windows.Forms.TextBox()
        Me.ReadMeBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "P"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Q"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Modulus"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Exponent"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "D"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "DP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 311)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "DQ"
        '
        'QTextBox
        '
        Me.QTextBox.Location = New System.Drawing.Point(151, 59)
        Me.QTextBox.Multiline = True
        Me.QTextBox.Name = "QTextBox"
        Me.QTextBox.Size = New System.Drawing.Size(917, 26)
        Me.QTextBox.TabIndex = 8
        '
        'PTextBox
        '
        Me.PTextBox.Location = New System.Drawing.Point(151, 13)
        Me.PTextBox.Multiline = True
        Me.PTextBox.Name = "PTextBox"
        Me.PTextBox.Size = New System.Drawing.Size(917, 26)
        Me.PTextBox.TabIndex = 9
        '
        'ModulusTextBox
        '
        Me.ModulusTextBox.Location = New System.Drawing.Point(151, 108)
        Me.ModulusTextBox.Multiline = True
        Me.ModulusTextBox.Name = "ModulusTextBox"
        Me.ModulusTextBox.Size = New System.Drawing.Size(917, 26)
        Me.ModulusTextBox.TabIndex = 10
        '
        'ExponentTextBox
        '
        Me.ExponentTextBox.Location = New System.Drawing.Point(151, 157)
        Me.ExponentTextBox.Multiline = True
        Me.ExponentTextBox.Name = "ExponentTextBox"
        Me.ExponentTextBox.Size = New System.Drawing.Size(917, 26)
        Me.ExponentTextBox.TabIndex = 11
        '
        'DTextBox
        '
        Me.DTextBox.Location = New System.Drawing.Point(151, 206)
        Me.DTextBox.Multiline = True
        Me.DTextBox.Name = "DTextBox"
        Me.DTextBox.Size = New System.Drawing.Size(917, 26)
        Me.DTextBox.TabIndex = 12
        '
        'DPTextBox
        '
        Me.DPTextBox.Location = New System.Drawing.Point(151, 254)
        Me.DPTextBox.Multiline = True
        Me.DPTextBox.Name = "DPTextBox"
        Me.DPTextBox.Size = New System.Drawing.Size(917, 26)
        Me.DPTextBox.TabIndex = 13
        '
        'DQTextBox
        '
        Me.DQTextBox.Location = New System.Drawing.Point(151, 305)
        Me.DQTextBox.Multiline = True
        Me.DQTextBox.Name = "DQTextBox"
        Me.DQTextBox.Size = New System.Drawing.Size(917, 26)
        Me.DQTextBox.TabIndex = 14
        '
        'GenerateBTN
        '
        Me.GenerateBTN.Location = New System.Drawing.Point(698, 676)
        Me.GenerateBTN.Name = "GenerateBTN"
        Me.GenerateBTN.Size = New System.Drawing.Size(206, 46)
        Me.GenerateBTN.TabIndex = 15
        Me.GenerateBTN.Text = "Generate"
        Me.GenerateBTN.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 372)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "InverseQ"
        '
        'InverseQTextBox
        '
        Me.InverseQTextBox.Location = New System.Drawing.Point(151, 365)
        Me.InverseQTextBox.Multiline = True
        Me.InverseQTextBox.Name = "InverseQTextBox"
        Me.InverseQTextBox.Size = New System.Drawing.Size(917, 27)
        Me.InverseQTextBox.TabIndex = 17
        '
        'TestBTN
        '
        Me.TestBTN.Location = New System.Drawing.Point(383, 542)
        Me.TestBTN.Name = "TestBTN"
        Me.TestBTN.Size = New System.Drawing.Size(223, 64)
        Me.TestBTN.TabIndex = 18
        Me.TestBTN.Text = "Get 384 bit RSA " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Key Information"
        Me.TestBTN.UseVisualStyleBackColor = True
        '
        'EncryptionBTN
        '
        Me.EncryptionBTN.Location = New System.Drawing.Point(383, 676)
        Me.EncryptionBTN.Name = "EncryptionBTN"
        Me.EncryptionBTN.Size = New System.Drawing.Size(223, 46)
        Me.EncryptionBTN.TabIndex = 19
        Me.EncryptionBTN.Text = "Encrypt/Decrypt"
        Me.EncryptionBTN.UseVisualStyleBackColor = True
        '
        'GenerateCustomBTN
        '
        Me.GenerateCustomBTN.Location = New System.Drawing.Point(698, 611)
        Me.GenerateCustomBTN.Name = "GenerateCustomBTN"
        Me.GenerateCustomBTN.Size = New System.Drawing.Size(206, 46)
        Me.GenerateCustomBTN.TabIndex = 20
        Me.GenerateCustomBTN.Text = "Generate Bigger Key"
        Me.GenerateCustomBTN.UseVisualStyleBackColor = True
        '
        'GenerateSmallerKeyBTN
        '
        Me.GenerateSmallerKeyBTN.Location = New System.Drawing.Point(698, 542)
        Me.GenerateSmallerKeyBTN.Name = "GenerateSmallerKeyBTN"
        Me.GenerateSmallerKeyBTN.Size = New System.Drawing.Size(206, 46)
        Me.GenerateSmallerKeyBTN.TabIndex = 21
        Me.GenerateSmallerKeyBTN.Text = "Generate Smaller Key"
        Me.GenerateSmallerKeyBTN.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 423)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 20)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Index finding"
        '
        'IndexTB
        '
        Me.IndexTB.Location = New System.Drawing.Point(151, 423)
        Me.IndexTB.Name = "IndexTB"
        Me.IndexTB.ReadOnly = True
        Me.IndexTB.Size = New System.Drawing.Size(917, 26)
        Me.IndexTB.TabIndex = 23
        '
        'GenerateBiggerRandomKeyBTN
        '
        Me.GenerateBiggerRandomKeyBTN.Location = New System.Drawing.Point(17, 611)
        Me.GenerateBiggerRandomKeyBTN.Name = "GenerateBiggerRandomKeyBTN"
        Me.GenerateBiggerRandomKeyBTN.Size = New System.Drawing.Size(256, 46)
        Me.GenerateBiggerRandomKeyBTN.TabIndex = 24
        Me.GenerateBiggerRandomKeyBTN.Text = "Generate Bigger Key (Random)"
        Me.GenerateBiggerRandomKeyBTN.UseVisualStyleBackColor = True
        '
        'GenerateSmallerRandomKeyBTN
        '
        Me.GenerateSmallerRandomKeyBTN.Location = New System.Drawing.Point(16, 671)
        Me.GenerateSmallerRandomKeyBTN.Name = "GenerateSmallerRandomKeyBTN"
        Me.GenerateSmallerRandomKeyBTN.Size = New System.Drawing.Size(256, 51)
        Me.GenerateSmallerRandomKeyBTN.TabIndex = 25
        Me.GenerateSmallerRandomKeyBTN.Text = "Generate Smaller Key (Random)"
        Me.GenerateSmallerRandomKeyBTN.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 482)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 20)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Random Index"
        '
        'RandomIndexTB
        '
        Me.RandomIndexTB.Location = New System.Drawing.Point(151, 476)
        Me.RandomIndexTB.Name = "RandomIndexTB"
        Me.RandomIndexTB.ReadOnly = True
        Me.RandomIndexTB.Size = New System.Drawing.Size(917, 26)
        Me.RandomIndexTB.TabIndex = 27
        '
        'ReadMeBTN
        '
        Me.ReadMeBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ReadMeBTN.ForeColor = System.Drawing.Color.Red
        Me.ReadMeBTN.Location = New System.Drawing.Point(966, 542)
        Me.ReadMeBTN.Name = "ReadMeBTN"
        Me.ReadMeBTN.Size = New System.Drawing.Size(187, 46)
        Me.ReadMeBTN.TabIndex = 28
        Me.ReadMeBTN.Text = "Read Me"
        Me.ReadMeBTN.UseVisualStyleBackColor = True
        '
        'KeyGenerationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1346, 773)
        Me.Controls.Add(Me.ReadMeBTN)
        Me.Controls.Add(Me.RandomIndexTB)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GenerateSmallerRandomKeyBTN)
        Me.Controls.Add(Me.GenerateBiggerRandomKeyBTN)
        Me.Controls.Add(Me.IndexTB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GenerateSmallerKeyBTN)
        Me.Controls.Add(Me.GenerateCustomBTN)
        Me.Controls.Add(Me.EncryptionBTN)
        Me.Controls.Add(Me.TestBTN)
        Me.Controls.Add(Me.InverseQTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GenerateBTN)
        Me.Controls.Add(Me.DQTextBox)
        Me.Controls.Add(Me.DPTextBox)
        Me.Controls.Add(Me.DTextBox)
        Me.Controls.Add(Me.ExponentTextBox)
        Me.Controls.Add(Me.ModulusTextBox)
        Me.Controls.Add(Me.PTextBox)
        Me.Controls.Add(Me.QTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "KeyGenerationForm"
        Me.Text = "Key Generation V1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents QTextBox As TextBox
    Friend WithEvents PTextBox As TextBox
    Friend WithEvents ModulusTextBox As TextBox
    Friend WithEvents ExponentTextBox As TextBox
    Friend WithEvents DTextBox As TextBox
    Friend WithEvents DPTextBox As TextBox
    Friend WithEvents DQTextBox As TextBox
    Friend WithEvents GenerateBTN As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents InverseQTextBox As TextBox
    Friend WithEvents TestBTN As Button
    Friend WithEvents EncryptionBTN As Button
    Friend WithEvents GenerateCustomBTN As Button
    Friend WithEvents GenerateSmallerKeyBTN As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents IndexTB As TextBox
    Friend WithEvents GenerateBiggerRandomKeyBTN As Button
    Friend WithEvents GenerateSmallerRandomKeyBTN As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents RandomIndexTB As TextBox
    Friend WithEvents ReadMeBTN As Button
End Class
