Public Class Regiones

    Private Sub BtnNoreste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNoreste.Click
        FrmPickMap.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmSelect.Show()
        Me.Hide()
    End Sub
End Class