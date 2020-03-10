Public Class FrmPickMap

    Private Sub BtnMapCoah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMapCoah.Click
        FrmEdoCoahGame.Show()
        Me.Hide()
    End Sub

    Private Sub BtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVolver.Click
        Regiones.Show()
        Me.Hide()
    End Sub
End Class