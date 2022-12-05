Public Class SplashScreen
    Dim progress As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim newprogress = progress + 1
        progress = newprogress
        If (progress = 100) Then
            Timer1.Stop()
            Me.Hide()
            FormLogin.ShowDialog()
            Me.Close()

            FormMenuUtama.ShowDialog()
            Me.Close()
        End If
        Pb_Progress.Value = newprogress
        lbl_Loading.Text = "Loading... " & newprogress & "%"

    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class