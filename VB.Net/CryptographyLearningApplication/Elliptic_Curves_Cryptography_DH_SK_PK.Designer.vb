<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Elliptic_Curves_Cryptography_DH_SK_PK
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
        Me.ODHPKTB = New System.Windows.Forms.TextBox()
        Me.ODHSKTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DHSKTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DHPKTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CalculateBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Original Diffie Hellman Public Key"
        '
        'ODHPKTB
        '
        Me.ODHPKTB.Location = New System.Drawing.Point(17, 47)
        Me.ODHPKTB.Name = "ODHPKTB"
        Me.ODHPKTB.ReadOnly = True
        Me.ODHPKTB.Size = New System.Drawing.Size(771, 26)
        Me.ODHPKTB.TabIndex = 1
        '
        'ODHSKTB
        '
        Me.ODHSKTB.Location = New System.Drawing.Point(17, 128)
        Me.ODHSKTB.Name = "ODHSKTB"
        Me.ODHSKTB.ReadOnly = True
        Me.ODHSKTB.Size = New System.Drawing.Size(771, 26)
        Me.ODHSKTB.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Original Diffie Hellman Private Key"
        '
        'DHSKTB
        '
        Me.DHSKTB.Location = New System.Drawing.Point(17, 292)
        Me.DHSKTB.Name = "DHSKTB"
        Me.DHSKTB.ReadOnly = True
        Me.DHSKTB.Size = New System.Drawing.Size(771, 26)
        Me.DHSKTB.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Diffie Hellman Private Key"
        '
        'DHPKTB
        '
        Me.DHPKTB.Location = New System.Drawing.Point(17, 211)
        Me.DHPKTB.Name = "DHPKTB"
        Me.DHPKTB.ReadOnly = True
        Me.DHPKTB.Size = New System.Drawing.Size(771, 26)
        Me.DHPKTB.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Diffie Hellman Public Key"
        '
        'CalculateBTN
        '
        Me.CalculateBTN.Location = New System.Drawing.Point(17, 354)
        Me.CalculateBTN.Name = "CalculateBTN"
        Me.CalculateBTN.Size = New System.Drawing.Size(180, 59)
        Me.CalculateBTN.TabIndex = 8
        Me.CalculateBTN.Text = "Calculate"
        Me.CalculateBTN.UseVisualStyleBackColor = True
        '
        'Elliptic_Curves_Cryptography_DH_SK_PK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CalculateBTN)
        Me.Controls.Add(Me.DHSKTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DHPKTB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ODHSKTB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ODHPKTB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Elliptic_Curves_Cryptography_DH_SK_PK"
        Me.Text = "Elliptic_Curves_Cryptography_DH_SK_PK"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ODHPKTB As TextBox
    Friend WithEvents ODHSKTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DHSKTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DHPKTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CalculateBTN As Button
End Class
