<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Elliptic_Curves_Cryptography_Signature_To_DH
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SignaturePKTB = New System.Windows.Forms.TextBox()
        Me.SignatureSKTB = New System.Windows.Forms.TextBox()
        Me.DHPKTB = New System.Windows.Forms.TextBox()
        Me.DHSKTB = New System.Windows.Forms.TextBox()
        Me.ConvertBTN = New System.Windows.Forms.Button()
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
        Me.Label2.Location = New System.Drawing.Point(13, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Signature Private Key"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Diffie Hellman Public Key"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Diffie Hellman Private Key"
        '
        'SignaturePKTB
        '
        Me.SignaturePKTB.Location = New System.Drawing.Point(243, 13)
        Me.SignaturePKTB.Name = "SignaturePKTB"
        Me.SignaturePKTB.ReadOnly = True
        Me.SignaturePKTB.Size = New System.Drawing.Size(955, 26)
        Me.SignaturePKTB.TabIndex = 4
        '
        'SignatureSKTB
        '
        Me.SignatureSKTB.Location = New System.Drawing.Point(243, 66)
        Me.SignatureSKTB.Name = "SignatureSKTB"
        Me.SignatureSKTB.ReadOnly = True
        Me.SignatureSKTB.Size = New System.Drawing.Size(955, 26)
        Me.SignatureSKTB.TabIndex = 5
        '
        'DHPKTB
        '
        Me.DHPKTB.Location = New System.Drawing.Point(243, 133)
        Me.DHPKTB.Name = "DHPKTB"
        Me.DHPKTB.ReadOnly = True
        Me.DHPKTB.Size = New System.Drawing.Size(955, 26)
        Me.DHPKTB.TabIndex = 6
        '
        'DHSKTB
        '
        Me.DHSKTB.Location = New System.Drawing.Point(243, 199)
        Me.DHSKTB.Name = "DHSKTB"
        Me.DHSKTB.ReadOnly = True
        Me.DHSKTB.Size = New System.Drawing.Size(955, 26)
        Me.DHSKTB.TabIndex = 7
        '
        'ConvertBTN
        '
        Me.ConvertBTN.Location = New System.Drawing.Point(17, 308)
        Me.ConvertBTN.Name = "ConvertBTN"
        Me.ConvertBTN.Size = New System.Drawing.Size(180, 58)
        Me.ConvertBTN.TabIndex = 8
        Me.ConvertBTN.Text = "Convert"
        Me.ConvertBTN.UseVisualStyleBackColor = True
        '
        'Elliptic_Curves_Cryptography_Signature_To_DH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1210, 450)
        Me.Controls.Add(Me.ConvertBTN)
        Me.Controls.Add(Me.DHSKTB)
        Me.Controls.Add(Me.DHPKTB)
        Me.Controls.Add(Me.SignatureSKTB)
        Me.Controls.Add(Me.SignaturePKTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Elliptic_Curves_Cryptography_Signature_To_DH"
        Me.Text = "Elliptic_Curves_Cryptography_Signature_To_DH"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SignaturePKTB As TextBox
    Friend WithEvents SignatureSKTB As TextBox
    Friend WithEvents DHPKTB As TextBox
    Friend WithEvents DHSKTB As TextBox
    Friend WithEvents ConvertBTN As Button
End Class
