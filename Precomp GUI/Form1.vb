Public Class Form1
    Private Sub PrecompressRadiobutton_CheckedChanged(sender As Object, e As EventArgs) Handles PrecompressRadiobutton.CheckedChanged
        If PrecompressRadiobutton.Checked Then
            Step1label.Text = "Step 1: Browse for a file to precompress:"
            Step2label.Text = "Step 2: Browse for a location to save the precompressed file:"
        End If
    End Sub

    Private Sub RecompressRadiobutton_CheckedChanged(sender As Object, e As EventArgs) Handles RecompressRadiobutton.CheckedChanged
        If RecompressRadiobutton.Checked Then
            Step1label.Text = "Step 1: Browse for a file to recompress:"
            Step2label.Text = "Step 2: Browse for a location to save the recompressed file:"
        End If
    End Sub
End Class
