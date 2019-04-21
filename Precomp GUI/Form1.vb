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

End Class
