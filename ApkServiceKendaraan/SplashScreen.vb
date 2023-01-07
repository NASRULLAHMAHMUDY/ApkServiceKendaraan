Public Class SplashScreen
    Dim progress As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim newprogress = progress + 1
        progress = newprogress
        If (progress = 100) Then
            Timer1.Stop()
            Me.Hide()
            'FormLogin.ShowDialog()
            'Me.Close()

            FormMenuUtama.ShowDialog()
            'Me.Close()
        End If
        Pb_Progress.Value = newprogress
        lbl_Loading.Text = "Loading... " & newprogress & "%"

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl1.Click

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If lbl1.Left >= Me.Width Then
            lbl1.Left = -lbl1.Width
        Else
            lbl1.Left = lbl1.Left + 100
        End If
    End Sub
End Class