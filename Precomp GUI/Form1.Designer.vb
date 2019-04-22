<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Step1label = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RecompressRadiobutton = New System.Windows.Forms.RadioButton()
        Me.PrecompressRadiobutton = New System.Windows.Forms.RadioButton()
        Me.InputFileTextbox = New System.Windows.Forms.TextBox()
        Me.BrowseInputButton = New System.Windows.Forms.Button()
        Me.BrowseOutputButton = New System.Windows.Forms.Button()
        Me.OutputFileTextbox = New System.Windows.Forms.TextBox()
        Me.Step2label = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BrutePrecompression = New System.Windows.Forms.RadioButton()
        Me.IntensePrecompression = New System.Windows.Forms.RadioButton()
        Me.NormalPrecompression = New System.Windows.Forms.RadioButton()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressLog = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ClearLogButton = New System.Windows.Forms.Button()
        Me.SaveLogButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.VerboseLogging = New System.Windows.Forms.CheckBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Step1label
        '
        Me.Step1label.AutoSize = True
        Me.Step1label.Location = New System.Drawing.Point(6, 67)
        Me.Step1label.Name = "Step1label"
        Me.Step1label.Size = New System.Drawing.Size(197, 13)
        Me.Step1label.TabIndex = 0
        Me.Step1label.Text = "Step 1: Browse for a file to precompress:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RecompressRadiobutton)
        Me.GroupBox1.Controls.Add(Me.PrecompressRadiobutton)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 51)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Action"
        '
        'RecompressRadiobutton
        '
        Me.RecompressRadiobutton.AutoSize = True
        Me.RecompressRadiobutton.Location = New System.Drawing.Point(98, 19)
        Me.RecompressRadiobutton.Name = "RecompressRadiobutton"
        Me.RecompressRadiobutton.Size = New System.Drawing.Size(84, 17)
        Me.RecompressRadiobutton.TabIndex = 1
        Me.RecompressRadiobutton.TabStop = True
        Me.RecompressRadiobutton.Text = "Recompress"
        Me.RecompressRadiobutton.UseVisualStyleBackColor = True
        '
        'PrecompressRadiobutton
        '
        Me.PrecompressRadiobutton.AutoSize = True
        Me.PrecompressRadiobutton.Location = New System.Drawing.Point(6, 19)
        Me.PrecompressRadiobutton.Name = "PrecompressRadiobutton"
        Me.PrecompressRadiobutton.Size = New System.Drawing.Size(86, 17)
        Me.PrecompressRadiobutton.TabIndex = 0
        Me.PrecompressRadiobutton.TabStop = True
        Me.PrecompressRadiobutton.Text = "Precompress"
        Me.PrecompressRadiobutton.UseVisualStyleBackColor = True
        '
        'InputFileTextbox
        '
        Me.InputFileTextbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputFileTextbox.Location = New System.Drawing.Point(9, 84)
        Me.InputFileTextbox.Name = "InputFileTextbox"
        Me.InputFileTextbox.Size = New System.Drawing.Size(302, 20)
        Me.InputFileTextbox.TabIndex = 2
        '
        'BrowseInputButton
        '
        Me.BrowseInputButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseInputButton.Location = New System.Drawing.Point(317, 82)
        Me.BrowseInputButton.Name = "BrowseInputButton"
        Me.BrowseInputButton.Size = New System.Drawing.Size(75, 23)
        Me.BrowseInputButton.TabIndex = 3
        Me.BrowseInputButton.Text = "Browse"
        Me.BrowseInputButton.UseVisualStyleBackColor = True
        '
        'BrowseOutputButton
        '
        Me.BrowseOutputButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseOutputButton.Location = New System.Drawing.Point(317, 134)
        Me.BrowseOutputButton.Name = "BrowseOutputButton"
        Me.BrowseOutputButton.Size = New System.Drawing.Size(75, 23)
        Me.BrowseOutputButton.TabIndex = 6
        Me.BrowseOutputButton.Text = "Browse"
        Me.BrowseOutputButton.UseVisualStyleBackColor = True
        '
        'OutputFileTextbox
        '
        Me.OutputFileTextbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputFileTextbox.Location = New System.Drawing.Point(9, 134)
        Me.OutputFileTextbox.Name = "OutputFileTextbox"
        Me.OutputFileTextbox.Size = New System.Drawing.Size(302, 20)
        Me.OutputFileTextbox.TabIndex = 5
        '
        'Step2label
        '
        Me.Step2label.AutoSize = True
        Me.Step2label.Location = New System.Drawing.Point(6, 117)
        Me.Step2label.Name = "Step2label"
        Me.Step2label.Size = New System.Drawing.Size(293, 13)
        Me.Step2label.TabIndex = 4
        Me.Step2label.Text = "Step 2: Browse for a location to save the precompressed file:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BrutePrecompression)
        Me.GroupBox2.Controls.Add(Me.IntensePrecompression)
        Me.GroupBox2.Controls.Add(Me.NormalPrecompression)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 160)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(209, 50)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Precompression mode:"
        '
        'BrutePrecompression
        '
        Me.BrutePrecompression.AutoSize = True
        Me.BrutePrecompression.Location = New System.Drawing.Point(134, 19)
        Me.BrutePrecompression.Name = "BrutePrecompression"
        Me.BrutePrecompression.Size = New System.Drawing.Size(50, 17)
        Me.BrutePrecompression.TabIndex = 2
        Me.BrutePrecompression.TabStop = True
        Me.BrutePrecompression.Text = "Brute"
        Me.BrutePrecompression.UseVisualStyleBackColor = True
        '
        'IntensePrecompression
        '
        Me.IntensePrecompression.AutoSize = True
        Me.IntensePrecompression.Location = New System.Drawing.Point(70, 19)
        Me.IntensePrecompression.Name = "IntensePrecompression"
        Me.IntensePrecompression.Size = New System.Drawing.Size(60, 17)
        Me.IntensePrecompression.TabIndex = 1
        Me.IntensePrecompression.TabStop = True
        Me.IntensePrecompression.Text = "Intense"
        Me.IntensePrecompression.UseVisualStyleBackColor = True
        '
        'NormalPrecompression
        '
        Me.NormalPrecompression.AutoSize = True
        Me.NormalPrecompression.Location = New System.Drawing.Point(6, 19)
        Me.NormalPrecompression.Name = "NormalPrecompression"
        Me.NormalPrecompression.Size = New System.Drawing.Size(58, 17)
        Me.NormalPrecompression.TabIndex = 0
        Me.NormalPrecompression.TabStop = True
        Me.NormalPrecompression.Text = "Normal"
        Me.NormalPrecompression.UseVisualStyleBackColor = True
        '
        'StartButton
        '
        Me.StartButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartButton.Location = New System.Drawing.Point(9, 216)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(383, 29)
        Me.StartButton.TabIndex = 8
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Log:"
        '
        'ProgressLog
        '
        Me.ProgressLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressLog.Location = New System.Drawing.Point(6, 25)
        Me.ProgressLog.Name = "ProgressLog"
        Me.ProgressLog.Size = New System.Drawing.Size(380, 206)
        Me.ProgressLog.TabIndex = 10
        Me.ProgressLog.Text = ""
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "GUI by: Moisés Cardona"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(358, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "v0.1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(802, 302)
        Me.TableLayoutPanel1.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ClearLogButton)
        Me.Panel2.Controls.Add(Me.SaveLogButton)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.ProgressLog)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(404, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(395, 296)
        Me.Panel2.TabIndex = 1
        '
        'ClearLogButton
        '
        Me.ClearLogButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearLogButton.Location = New System.Drawing.Point(136, 237)
        Me.ClearLogButton.Name = "ClearLogButton"
        Me.ClearLogButton.Size = New System.Drawing.Size(122, 23)
        Me.ClearLogButton.TabIndex = 14
        Me.ClearLogButton.Text = "Clear Log"
        Me.ClearLogButton.UseVisualStyleBackColor = True
        '
        'SaveLogButton
        '
        Me.SaveLogButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveLogButton.Location = New System.Drawing.Point(264, 237)
        Me.SaveLogButton.Name = "SaveLogButton"
        Me.SaveLogButton.Size = New System.Drawing.Size(122, 23)
        Me.SaveLogButton.TabIndex = 13
        Me.SaveLogButton.Text = "Save Log"
        Me.SaveLogButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.VerboseLogging)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Step1label)
        Me.Panel1.Controls.Add(Me.StartButton)
        Me.Panel1.Controls.Add(Me.InputFileTextbox)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.BrowseInputButton)
        Me.Panel1.Controls.Add(Me.BrowseOutputButton)
        Me.Panel1.Controls.Add(Me.Step2label)
        Me.Panel1.Controls.Add(Me.OutputFileTextbox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(395, 296)
        Me.Panel1.TabIndex = 0
        '
        'VerboseLogging
        '
        Me.VerboseLogging.AutoSize = True
        Me.VerboseLogging.Location = New System.Drawing.Point(224, 179)
        Me.VerboseLogging.Name = "VerboseLogging"
        Me.VerboseLogging.Size = New System.Drawing.Size(106, 17)
        Me.VerboseLogging.TabIndex = 12
        Me.VerboseLogging.Text = "Verbose Logging"
        Me.VerboseLogging.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(9, 262)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(119, 13)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Precomp by: schnaader"
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 302)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Precomp GUI"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Step1label As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RecompressRadiobutton As RadioButton
    Friend WithEvents PrecompressRadiobutton As RadioButton
    Friend WithEvents InputFileTextbox As TextBox
    Friend WithEvents BrowseInputButton As Button
    Friend WithEvents BrowseOutputButton As Button
    Friend WithEvents OutputFileTextbox As TextBox
    Friend WithEvents Step2label As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BrutePrecompression As RadioButton
    Friend WithEvents IntensePrecompression As RadioButton
    Friend WithEvents NormalPrecompression As RadioButton
    Friend WithEvents StartButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressLog As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ClearLogButton As Button
    Friend WithEvents SaveLogButton As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents VerboseLogging As CheckBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
