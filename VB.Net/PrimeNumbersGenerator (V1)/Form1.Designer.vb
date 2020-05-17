<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrimeNumbersGeneratorForm
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
        Me.components = New System.ComponentModel.Container()
        Me.GenerateBTN = New System.Windows.Forms.Button()
        Me.PauseAllBTN = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CRThreadsRTB = New System.Windows.Forms.TextBox()
        Me.TPausedRTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TResumeRTB = New System.Windows.Forms.TextBox()
        Me.PrimeListCountRTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Timer1RTB = New System.Windows.Forms.TextBox()
        Me.ResumeBTN = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PList1GSRTB1 = New System.Windows.Forms.TextBox()
        Me.AbortBTN = New System.Windows.Forms.Button()
        Me.ExportBTN = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SNumberRTB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ENumberRTB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CNumberRTB = New System.Windows.Forms.TextBox()
        Me.CheckResultBTN = New System.Windows.Forms.Button()
        Me.BitsCB = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ReadMeBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GenerateBTN
        '
        Me.GenerateBTN.Location = New System.Drawing.Point(1047, 22)
        Me.GenerateBTN.Name = "GenerateBTN"
        Me.GenerateBTN.Size = New System.Drawing.Size(116, 56)
        Me.GenerateBTN.TabIndex = 4
        Me.GenerateBTN.Text = "Start All" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Threads"
        Me.GenerateBTN.UseVisualStyleBackColor = True
        '
        'PauseAllBTN
        '
        Me.PauseAllBTN.Location = New System.Drawing.Point(1047, 90)
        Me.PauseAllBTN.Name = "PauseAllBTN"
        Me.PauseAllBTN.Size = New System.Drawing.Size(119, 56)
        Me.PauseAllBTN.TabIndex = 9
        Me.PauseAllBTN.Text = "Pause All" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Threads"
        Me.PauseAllBTN.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3600000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Current Threads Running"
        '
        'CRThreadsRTB
        '
        Me.CRThreadsRTB.Location = New System.Drawing.Point(17, 37)
        Me.CRThreadsRTB.Name = "CRThreadsRTB"
        Me.CRThreadsRTB.ReadOnly = True
        Me.CRThreadsRTB.Size = New System.Drawing.Size(184, 26)
        Me.CRThreadsRTB.TabIndex = 11
        '
        'TPausedRTB
        '
        Me.TPausedRTB.Location = New System.Drawing.Point(17, 105)
        Me.TPausedRTB.Name = "TPausedRTB"
        Me.TPausedRTB.ReadOnly = True
        Me.TPausedRTB.Size = New System.Drawing.Size(184, 26)
        Me.TPausedRTB.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Threads Paused"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Threads Resume"
        '
        'TResumeRTB
        '
        Me.TResumeRTB.Location = New System.Drawing.Point(17, 176)
        Me.TResumeRTB.Name = "TResumeRTB"
        Me.TResumeRTB.ReadOnly = True
        Me.TResumeRTB.Size = New System.Drawing.Size(184, 26)
        Me.TResumeRTB.TabIndex = 15
        '
        'PrimeListCountRTB
        '
        Me.PrimeListCountRTB.Location = New System.Drawing.Point(17, 390)
        Me.PrimeListCountRTB.Name = "PrimeListCountRTB"
        Me.PrimeListCountRTB.ReadOnly = True
        Me.PrimeListCountRTB.Size = New System.Drawing.Size(184, 26)
        Me.PrimeListCountRTB.TabIndex = 16
        Me.PrimeListCountRTB.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 367)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Current Primes In List"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(172, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Timer1 Running Hours:"
        '
        'Timer1RTB
        '
        Me.Timer1RTB.Location = New System.Drawing.Point(17, 253)
        Me.Timer1RTB.Name = "Timer1RTB"
        Me.Timer1RTB.ReadOnly = True
        Me.Timer1RTB.Size = New System.Drawing.Size(168, 26)
        Me.Timer1RTB.TabIndex = 22
        '
        'ResumeBTN
        '
        Me.ResumeBTN.Location = New System.Drawing.Point(1047, 161)
        Me.ResumeBTN.Name = "ResumeBTN"
        Me.ResumeBTN.Size = New System.Drawing.Size(129, 56)
        Me.ResumeBTN.TabIndex = 26
        Me.ResumeBTN.Text = "Resume All" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Threads"
        Me.ResumeBTN.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(219, 20)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Prime List1 Generated Status"
        '
        'PList1GSRTB1
        '
        Me.PList1GSRTB1.Location = New System.Drawing.Point(17, 321)
        Me.PList1GSRTB1.Name = "PList1GSRTB1"
        Me.PList1GSRTB1.ReadOnly = True
        Me.PList1GSRTB1.Size = New System.Drawing.Size(215, 26)
        Me.PList1GSRTB1.TabIndex = 33
        Me.PList1GSRTB1.Text = "Not Completed"
        '
        'AbortBTN
        '
        Me.AbortBTN.Location = New System.Drawing.Point(1047, 229)
        Me.AbortBTN.Name = "AbortBTN"
        Me.AbortBTN.Size = New System.Drawing.Size(122, 56)
        Me.AbortBTN.TabIndex = 37
        Me.AbortBTN.Text = "Abort" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "All Threads"
        Me.AbortBTN.UseVisualStyleBackColor = True
        '
        'ExportBTN
        '
        Me.ExportBTN.Location = New System.Drawing.Point(1047, 298)
        Me.ExportBTN.Name = "ExportBTN"
        Me.ExportBTN.Size = New System.Drawing.Size(121, 56)
        Me.ExportBTN.TabIndex = 38
        Me.ExportBTN.Text = "Export Result"
        Me.ExportBTN.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(345, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(229, 20)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Starting Number (Odd Number)"
        '
        'SNumberRTB
        '
        Me.SNumberRTB.Location = New System.Drawing.Point(349, 37)
        Me.SNumberRTB.Multiline = True
        Me.SNumberRTB.Name = "SNumberRTB"
        Me.SNumberRTB.Size = New System.Drawing.Size(616, 135)
        Me.SNumberRTB.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(345, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 20)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Ending Number"
        '
        'ENumberRTB
        '
        Me.ENumberRTB.Location = New System.Drawing.Point(349, 212)
        Me.ENumberRTB.Multiline = True
        Me.ENumberRTB.Name = "ENumberRTB"
        Me.ENumberRTB.ReadOnly = True
        Me.ENumberRTB.Size = New System.Drawing.Size(616, 135)
        Me.ENumberRTB.TabIndex = 42
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(345, 363)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 20)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "CurrentNumber"
        '
        'CNumberRTB
        '
        Me.CNumberRTB.Location = New System.Drawing.Point(349, 390)
        Me.CNumberRTB.Multiline = True
        Me.CNumberRTB.Name = "CNumberRTB"
        Me.CNumberRTB.ReadOnly = True
        Me.CNumberRTB.Size = New System.Drawing.Size(616, 120)
        Me.CNumberRTB.TabIndex = 44
        '
        'CheckResultBTN
        '
        Me.CheckResultBTN.Location = New System.Drawing.Point(1047, 371)
        Me.CheckResultBTN.Name = "CheckResultBTN"
        Me.CheckResultBTN.Size = New System.Drawing.Size(113, 64)
        Me.CheckResultBTN.TabIndex = 45
        Me.CheckResultBTN.Text = "Check" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Result"
        Me.CheckResultBTN.UseVisualStyleBackColor = True
        '
        'BitsCB
        '
        Me.BitsCB.AllowDrop = True
        Me.BitsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BitsCB.FormattingEnabled = True
        Me.BitsCB.Items.AddRange(New Object() {"384", "512", "768", "1024", "1280", "1536", "1792", "2048", "2304", "2560", "2616", "3072", "3328", "3584", "3840", "4096", "15360", "16384"})
        Me.BitsCB.Location = New System.Drawing.Point(17, 482)
        Me.BitsCB.Name = "BitsCB"
        Me.BitsCB.Size = New System.Drawing.Size(184, 28)
        Me.BitsCB.TabIndex = 46
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 446)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 20)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Select number of bits"
        '
        'ReadMeBTN
        '
        Me.ReadMeBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ReadMeBTN.ForeColor = System.Drawing.Color.Red
        Me.ReadMeBTN.Location = New System.Drawing.Point(1047, 458)
        Me.ReadMeBTN.Name = "ReadMeBTN"
        Me.ReadMeBTN.Size = New System.Drawing.Size(119, 52)
        Me.ReadMeBTN.TabIndex = 48
        Me.ReadMeBTN.Text = "Read Me"
        Me.ReadMeBTN.UseVisualStyleBackColor = True
        '
        'PrimeNumbersGeneratorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 567)
        Me.Controls.Add(Me.ReadMeBTN)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BitsCB)
        Me.Controls.Add(Me.CheckResultBTN)
        Me.Controls.Add(Me.CNumberRTB)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ENumberRTB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.SNumberRTB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ExportBTN)
        Me.Controls.Add(Me.AbortBTN)
        Me.Controls.Add(Me.PList1GSRTB1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ResumeBTN)
        Me.Controls.Add(Me.Timer1RTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PrimeListCountRTB)
        Me.Controls.Add(Me.TResumeRTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TPausedRTB)
        Me.Controls.Add(Me.CRThreadsRTB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PauseAllBTN)
        Me.Controls.Add(Me.GenerateBTN)
        Me.Name = "PrimeNumbersGeneratorForm"
        Me.Text = "Prime Numbers Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GenerateBTN As Button
    Friend WithEvents PauseAllBTN As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents CRThreadsRTB As TextBox
    Friend WithEvents TPausedRTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TResumeRTB As TextBox
    Friend WithEvents PrimeListCountRTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer1RTB As TextBox
    Friend WithEvents ResumeBTN As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents PList1GSRTB1 As TextBox
    Friend WithEvents AbortBTN As Button
    Friend WithEvents ExportBTN As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents SNumberRTB As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ENumberRTB As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CNumberRTB As TextBox
    Friend WithEvents CheckResultBTN As Button
    Friend WithEvents BitsCB As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ReadMeBTN As Button
End Class
