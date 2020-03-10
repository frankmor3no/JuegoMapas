Public Class FrmNoCierto

    Private Sub BtnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOK.Click
        Close()
    End Sub

    Private Sub FrmNoCierto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Risa, AudioPlayMode.Background)
    End Sub
End Class