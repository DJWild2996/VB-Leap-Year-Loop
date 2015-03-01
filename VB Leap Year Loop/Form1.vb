Public Class Form1
    '    Private Sub btncheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncheck.Click
    '        Dim year As Integer = txtyearenter.Text

    '        For i = 1 To 10
    '            If year Mod 4 = 0 And (year Mod 100 <> 0 Or year Mod 400 = 0) Then
    '                lbyear.Items.Add(year & " is a leap year")
    '            Else
    '                lbyear.Items.Add(year & " is not a leap year")
    '            End If
    '            year += 1
    '        Next
    '    End Sub

    'Private Sub btncheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncheck.Click

    '    Dim year As Integer = txtyearenter.Text
    '    Dim i As Integer = 1
    '    'do while "i" is less than or equal to 10
    '    Do While i <= 10
    '        If year Mod 4 = 0 And (year Mod 100 <> 0 Or year Mod 400 = 0) Then
    '            lbyear.Items.Add(year & " is a Leap Year")
    '            i += 1
    '        Else
    '            'lbyear.items.add( year & " is not a leap year"
    '        End If
    '        year += 1
    '    Loop

    'End Sub

    Private Sub btncheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncheck.Click
        Try
            Dim year As Integer = txtyearenter.Text

            Dim i As Integer = 1
            Do While i <= 10

                If year < 0 Then
                    lbyear.Items.Add(year & " Invalid year... terminating!")
                    Exit Do
                End If

                If year Mod 4 = 0 And (year Mod 100 <> 0 Or year Mod 400 = 0) Then
                    lbyear.Items.Add(year & " is a leap year")
                    i += 1
                Else
                    lbyear.Items.Add(year & " is not a leap year")
                End If
                year += 1
            Loop
        Catch
            MsgBox("please put a number in")

        End Try
    End Sub


End Class