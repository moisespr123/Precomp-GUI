Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrecompressRadiobutton.Checked = My.Settings.Precompress
        RecompressRadiobutton.Checked = My.Settings.Recompress
        NormalPrecompression.Checked = My.Settings.Normal
        IntensePrecompression.Checked = My.Settings.Intense
        BrutePrecompression.Checked = My.Settings.Brute
    End Sub
    Private Sub PrecompressRadiobutton_CheckedChanged(sender As Object, e As EventArgs) Handles PrecompressRadiobutton.CheckedChanged
        If PrecompressRadiobutton.Checked Then
            Step1label.Text = "Step 1: Browse for a file to precompress:"
            Step2label.Text = "Step 2: Browse for a location to save the precompressed file:"
        End If
        My.Settings.Precompress = PrecompressRadiobutton.Checked
        My.Settings.Save()
    End Sub

    Private Sub RecompressRadiobutton_CheckedChanged(sender As Object, e As EventArgs) Handles RecompressRadiobutton.CheckedChanged
        If RecompressRadiobutton.Checked Then
            Step1label.Text = "Step 1: Browse for a file to recompress:"
            Step2label.Text = "Step 2: Browse for a location to save the recompressed file:"
        End If
        My.Settings.Recompress = RecompressRadiobutton.Checked
        My.Settings.Save()
    End Sub

    Private Sub NormalPrecompression_CheckedChanged(sender As Object, e As EventArgs) Handles NormalPrecompression.CheckedChanged
        My.Settings.Normal = NormalPrecompression.Checked
        My.Settings.Save()
    End Sub

    Private Sub IntensePrecompression_CheckedChanged(sender As Object, e As EventArgs) Handles IntensePrecompression.CheckedChanged
        My.Settings.Intense = IntensePrecompression.Checked
        My.Settings.Save()
    End Sub

    Private Sub BrutePrecompression_CheckedChanged(sender As Object, e As EventArgs) Handles BrutePrecompression.CheckedChanged
        My.Settings.Brute = BrutePrecompression.Checked
        My.Settings.Save()
    End Sub

    Private Sub UpdateLogEventHandler(sender As Object, e As DataReceivedEventArgs)
        If Not e.Data = Nothing Then
            UpdateLog(e.Data)
        End If
    End Sub
    Private Delegate Sub UpdateLogInvoker(message As String)
    Private Sub UpdateLog(message As String)
        If ProgressLog.InvokeRequired Then
            ProgressLog.Invoke(New UpdateLogInvoker(AddressOf UpdateLog), message)
        Else
            If Not String.IsNullOrWhiteSpace(message) Then
                message = message.Replace(vbBack, "")
                ProgressLog.AppendText(Date.Now().ToString() + " || " + message + vbCrLf)
                ProgressLog.SelectionStart = ProgressLog.Text.Length - 1
                ProgressLog.ScrollToCaret()
            End If
        End If
    End Sub
    Private Sub PrecompThread(Compressor As String, Params As String)
        Using process As New Process()
            process.StartInfo.WorkingDirectory = IO.Path.GetDirectoryName(Compressor)
            process.StartInfo.FileName = Compressor
            process.StartInfo.Arguments = Params
            process.StartInfo.UseShellExecute = False
            process.StartInfo.RedirectStandardOutput = True
            process.StartInfo.RedirectStandardError = True
            process.StartInfo.CreateNoWindow = True
            AddHandler process.OutputDataReceived, New DataReceivedEventHandler(AddressOf UpdateLogEventHandler)
            AddHandler process.ErrorDataReceived, New DataReceivedEventHandler(AddressOf UpdateLogEventHandler)
            process.Start()
            process.BeginOutputReadLine()
            process.BeginErrorReadLine()
            process.WaitForExit()
            StartButton.BeginInvoke(Sub() StartButton.Enabled = True)
            ClearLogButton.BeginInvoke(Sub() ClearLogButton.Enabled = True)
            SaveLogButton.BeginInvoke(Sub() SaveLogButton.Enabled = True)
        End Using
    End Sub

    Private Sub SaveLogButton_Click(sender As Object, e As EventArgs) Handles SaveLogButton.Click
        Dim SaveDialog As New SaveFileDialog With {
          .Filter = "Text file|*.txt",
          .FileName = String.Empty,
          .Title = "Browse to save the log"}
        Dim result As DialogResult = SaveDialog.ShowDialog
        If result = DialogResult.OK Then
            If Not String.IsNullOrWhiteSpace(SaveDialog.FileName) Then My.Computer.FileSystem.WriteAllText(SaveDialog.FileName, ProgressLog.Text, False)
        End If
    End Sub

    Private Sub ClearLogButton_Click(sender As Object, e As EventArgs) Handles ClearLogButton.Click
        ProgressLog.Text = String.Empty
    End Sub

    Private Sub BrowseInputButton_Click(sender As Object, e As EventArgs) Handles BrowseInputButton.Click
        OpenFileDialog1.Filter = "All Files|*.*"
        If PrecompressRadiobutton.Checked Then
            OpenFileDialog1.Title = "Browse for a file to precompress"
        Else
            OpenFileDialog1.Title = "Browse for a file to recompress"
        End If
        If Not String.IsNullOrWhiteSpace(InputFileTextbox.Text) Then OpenFileDialog1.FileName = IO.Path.GetFileName(InputFileTextbox.Text) Else OpenFileDialog1.FileName = String.Empty
        Dim result As DialogResult = OpenFileDialog1.ShowDialog
        If result = DialogResult.OK Then
            InputFileTextbox.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BrowseOutputButton_Click(sender As Object, e As EventArgs) Handles BrowseOutputButton.Click
        If PrecompressRadiobutton.Checked Then
            SaveFileDialog1.Filter = "Precomp file|*.pcf"
            SaveFileDialog1.Title = "Browse for a location to save the precompressed file"
        Else
            SaveFileDialog1.Filter = "All Files|*.*"
            SaveFileDialog1.Title = "Browse for a location to save the recompressed file"
        End If
        If Not String.IsNullOrWhiteSpace(OutputFileTextbox.Text) Then SaveFileDialog1.FileName = IO.Path.GetFileName(OutputFileTextbox.Text) Else SaveFileDialog1.FileName = String.Empty
        Dim result As DialogResult = SaveFileDialog1.ShowDialog
        If result = DialogResult.OK Then
            OutputFileTextbox.Text = SaveFileDialog1.FileName
        End If
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Dim OutputPathString As String = String.Empty
        If Not String.IsNullOrEmpty(OutputFileTextbox.Text) Then
            If Not IO.Directory.Exists(OutputFileTextbox.Text) Then IO.Directory.CreateDirectory(OutputFileTextbox.Text)
            OutputPathString = "-o" + OutputFileTextbox.Text
        End If
        Dim Params As String = "-d9999 -cn -v "
        If IntensePrecompression.Checked Then
            Params += "-intense "
        ElseIf BrutePrecompression.Checked Then
            Params += "-brute "
        End If
        Params += """" + InputFileTextbox.Text + """ """ + OutputPathString + """"
        StartButton.Enabled = False
        Dim StartTask As New Threading.Thread(Sub() PrecompThread("precomp v0.4.7.exe", Params))
        StartTask.Start()
    End Sub
End Class
