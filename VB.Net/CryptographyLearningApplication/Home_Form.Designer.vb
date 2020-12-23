<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home_Form
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
        Me.Destination_CB = New System.Windows.Forms.ComboBox()
        Me.Go_BTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(396, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choose a destination"
        '
        'Destination_CB
        '
        Me.Destination_CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Destination_CB.FormattingEnabled = True
        Me.Destination_CB.Items.AddRange(New Object() {"Elliptic Curves Cryptography Diffie Hellman", "Elliptic Curves Cryptography Signature", "Elliptic Curves Cryptography Signature to DH Conversion", "Elliptic Curves Cryptography Calculate DH PK from DH SK", "RSA(Old School)", "RSA(Padding)", "RSA(OAEP Padding)", "AES(Byte)", "AES(Text)", "Authenticated Encryption (AES)", "Authenticated Encryption With Additional Data (AEAD + AES)", "Signal's Out Of Band's Authentication (DH + Hash)", "Signal's x3DH", "Proper Hashing(Salt + Pepper) {Byte}", "Proper Hashing(Salt + Pepper) {String}", "Random Password Generator with fixed length", "Random Password Generator with fixed length(Built In)", "Argon2"})
        Me.Destination_CB.Location = New System.Drawing.Point(17, 59)
        Me.Destination_CB.Name = "Destination_CB"
        Me.Destination_CB.Size = New System.Drawing.Size(680, 28)
        Me.Destination_CB.TabIndex = 1
        '
        'Go_BTN
        '
        Me.Go_BTN.Location = New System.Drawing.Point(17, 107)
        Me.Go_BTN.Name = "Go_BTN"
        Me.Go_BTN.Size = New System.Drawing.Size(100, 39)
        Me.Go_BTN.TabIndex = 2
        Me.Go_BTN.Text = "Go"
        Me.Go_BTN.UseVisualStyleBackColor = True
        '
        'Home_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 523)
        Me.Controls.Add(Me.Go_BTN)
        Me.Controls.Add(Me.Destination_CB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Home_Form"
        Me.Text = "Cryptography Learning Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Destination_CB As ComboBox
    Friend WithEvents Go_BTN As Button
End Class
