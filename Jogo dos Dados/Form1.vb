Public Class FormJogoparouimpar
    Dim dado1, dado2 As Integer
    Dim random As Random
    Private Sub BtnRoda_Click(sender As Object, e As EventArgs) Handles btnRoda.Click
        tmrTempo.Start()
    End Sub
    Private Sub TmrTempo_Tick(sender As Object, e As EventArgs) Handles tmrTempo.Tick
        random = New Random
        prgProgressBar.Increment(5)

        If prgProgressBar.Value = 100 Then
            tmrTempo.Stop()
            prgProgressBar.Value = 0
        Else
            dado1 = random.Next(1, 7)
            dado2 = random.Next(1, 7)

            If dado1 = 1 Then
                picDado1.Image = My.Resources.dado_1
            ElseIf dado1 = 2 Then
                picDado1.Image = My.Resources.dado_2
            ElseIf dado1 = 3 Then
                picDado1.Image = My.Resources.dado_3
            ElseIf dado1 = 4 Then
                picDado1.Image = My.Resources.dado_4
            ElseIf dado1 = 5 Then
                picDado1.Image = My.Resources.dado_5
            ElseIf dado1 = 6 Then
                picDado1.Image = My.Resources.dado_6
            End If

            If dado2 = 1 Then
                picDado2.Image = My.Resources.dado_1
            ElseIf dado2 = 2 Then
                picDado2.Image = My.Resources.dado_2
            ElseIf dado2 = 3 Then
                picDado2.Image = My.Resources.dado_3
            ElseIf dado2 = 4 Then
                picDado2.Image = My.Resources.dado_4
            ElseIf dado2 = 5 Then
                picDado2.Image = My.Resources.dado_5
            ElseIf dado2 = 6 Then
                picDado1.Image = My.Resources.dado_6
            End If
        End If

    End Sub
End Class
