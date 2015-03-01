Public Class Form1
    Private Sub btncheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncheck.Click
        Dim year As Integer = txtyearenter.Text

        For i = 1 To 10
            If year Mod 4 = 0 And (year Mod 100 <> 0 Or year Mod 400 = 0) Then
                lbyear.Items.Add(year & " is a leap year")
            Else
                lbyear.Items.Add(year & " is not a leap year")
            End If
            year += 1
        Next
    End Sub

End Class
