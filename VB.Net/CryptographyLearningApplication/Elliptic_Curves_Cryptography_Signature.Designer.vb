<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Elliptic_Curves_Cryptography_Signature
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
        Me.SignaturePublicKeyTB = New System.Windows.Forms.TextBox()
        Me.SignaturePrivateKeyTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataHexaTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataBigIntTB = New System.Windows.Forms.TextBox()
        Me.DataAfterSignedHexaTB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataAfterSignedBigIntTB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SignBTN = New System.Windows.Forms.Button()
        Me.DataVerifySignatureTB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataVerifySignatureHexaTB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataVerifySignatureBigIntTB = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Signature Public Key"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Signature Private Key"
        '
        'SignaturePublicKeyTB
        '
        Me.SignaturePublicKeyTB.Location = New System.Drawing.Point(229, 13)
        Me.SignaturePublicKeyTB.Name = "SignaturePublicKeyTB"
        Me.SignaturePublicKeyTB.ReadOnly = True
        Me.SignaturePublicKeyTB.Size = New System.Drawing.Size(925, 26)
        Me.SignaturePublicKeyTB.TabIndex = 2
        '
        'SignaturePrivateKeyTB
        '
        Me.SignaturePrivateKeyTB.Location = New System.Drawing.Point(229, 72)
        Me.SignaturePrivateKeyTB.Name = "SignaturePrivateKeyTB"
        Me.SignaturePrivateKeyTB.ReadOnly = True
        Me.SignaturePrivateKeyTB.Size = New System.Drawing.Size(925, 26)
        Me.SignaturePrivateKeyTB.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Data to be signed(Text)"
        '
        'DataTB
        '
        Me.DataTB.Location = New System.Drawing.Point(229, 133)
        Me.DataTB.Name = "DataTB"
        Me.DataTB.Size = New System.Drawing.Size(925, 26)
        Me.DataTB.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Data to be signed(HEXA)"
        '
        'DataHexaTB
        '
        Me.DataHexaTB.Location = New System.Drawing.Point(229, 202)
        Me.DataHexaTB.Name = "DataHexaTB"
        Me.DataHexaTB.ReadOnly = True
        Me.DataHexaTB.Size = New System.Drawing.Size(925, 26)
        Me.DataHexaTB.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 271)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 40)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Data to be signed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Big Integer)"
        '
        'DataBigIntTB
        '
        Me.DataBigIntTB.Location = New System.Drawing.Point(229, 271)
        Me.DataBigIntTB.Name = "DataBigIntTB"
        Me.DataBigIntTB.ReadOnly = True
        Me.DataBigIntTB.Size = New System.Drawing.Size(925, 26)
        Me.DataBigIntTB.TabIndex = 9
        '
        'DataAfterSignedHexaTB
        '
        Me.DataAfterSignedHexaTB.Location = New System.Drawing.Point(229, 341)
        Me.DataAfterSignedHexaTB.Name = "DataAfterSignedHexaTB"
        Me.DataAfterSignedHexaTB.ReadOnly = True
        Me.DataAfterSignedHexaTB.Size = New System.Drawing.Size(925, 26)
        Me.DataAfterSignedHexaTB.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 341)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Data after signed (HEXA)"
        '
        'DataAfterSignedBigIntTB
        '
        Me.DataAfterSignedBigIntTB.Location = New System.Drawing.Point(229, 408)
        Me.DataAfterSignedBigIntTB.Name = "DataAfterSignedBigIntTB"
        Me.DataAfterSignedBigIntTB.ReadOnly = True
        Me.DataAfterSignedBigIntTB.Size = New System.Drawing.Size(925, 26)
        Me.DataAfterSignedBigIntTB.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 394)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 40)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Data after signed" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Big Integer)"
        '
        'SignBTN
        '
        Me.SignBTN.Location = New System.Drawing.Point(17, 700)
        Me.SignBTN.Name = "SignBTN"
        Me.SignBTN.Size = New System.Drawing.Size(226, 56)
        Me.SignBTN.TabIndex = 14
        Me.SignBTN.Text = "Sign Data"
        Me.SignBTN.UseVisualStyleBackColor = True
        '
        'DataVerifySignatureTB
        '
        Me.DataVerifySignatureTB.Location = New System.Drawing.Point(229, 474)
        Me.DataVerifySignatureTB.Name = "DataVerifySignatureTB"
        Me.DataVerifySignatureTB.ReadOnly = True
        Me.DataVerifySignatureTB.Size = New System.Drawing.Size(925, 26)
        Me.DataVerifySignatureTB.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 460)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 40)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Data after verifying " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "signature"
        '
        'DataVerifySignatureHexaTB
        '
        Me.DataVerifySignatureHexaTB.Location = New System.Drawing.Point(229, 534)
        Me.DataVerifySignatureHexaTB.Name = "DataVerifySignatureHexaTB"
        Me.DataVerifySignatureHexaTB.ReadOnly = True
        Me.DataVerifySignatureHexaTB.Size = New System.Drawing.Size(925, 26)
        Me.DataVerifySignatureHexaTB.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 520)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 40)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Data after verifying " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "signature (HEXA)"
        '
        'DataVerifySignatureBigIntTB
        '
        Me.DataVerifySignatureBigIntTB.Location = New System.Drawing.Point(229, 599)
        Me.DataVerifySignatureBigIntTB.Name = "DataVerifySignatureBigIntTB"
        Me.DataVerifySignatureBigIntTB.ReadOnly = True
        Me.DataVerifySignatureBigIntTB.Size = New System.Drawing.Size(925, 26)
        Me.DataVerifySignatureBigIntTB.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 585)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(167, 40)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Data after verifying " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "signature (Big Integer)"
        '
        'Elliptic_Curves_Cryptography_Signature
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1166, 768)
        Me.Controls.Add(Me.DataVerifySignatureBigIntTB)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DataVerifySignatureHexaTB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataVerifySignatureTB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.SignBTN)
        Me.Controls.Add(Me.DataAfterSignedBigIntTB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataAfterSignedHexaTB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataBigIntTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataHexaTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SignaturePrivateKeyTB)
        Me.Controls.Add(Me.SignaturePublicKeyTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Elliptic_Curves_Cryptography_Signature"
        Me.Text = "Elliptic_Curves_Cryptography_Signature"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SignaturePublicKeyTB As TextBox
    Friend WithEvents SignaturePrivateKeyTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataHexaTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataBigIntTB As TextBox
    Friend WithEvents DataAfterSignedHexaTB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DataAfterSignedBigIntTB As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents SignBTN As Button
    Friend WithEvents DataVerifySignatureTB As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DataVerifySignatureHexaTB As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DataVerifySignatureBigIntTB As TextBox
    Friend WithEvents Label10 As Label
End Class
