Public Class Form1
    'Maritza Mills - 20160725
    'Board represents 3x3 matrix of x's and o's

    Dim board(3, 3) As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblStatus.Hide()
        lblResponse.Hide()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn11.Click
        'add subroutine for standard button click actions, such as hiding labels

        If btn11.Text = "" Then
            btn11.Text = "X"
            board(1, 1) = "X"
            Console.Out.Write(board(1, 1).ToString) 'bookmark, for testing purpose only
            btnClkStdActions()
        Else
            lblResponse.Text = "Please choose another square."
            lblResponse.Show()
        End If

    End Sub

    Private Sub doNextMove()
        'bookmark - need a subroutine that checks the state of the board so the AI can choose the best move
        Dim i As Integer
        Dim j As Integer

        lblCurrentTurn.Text = "O"

        For i = 1 To 3
            For j = 1 To 3
                If board(i, j) Is Nothing Then
                    board(i, j) = "O"
                    Dim nextButton As Button
                    nextButton = CType(Me.Controls.Find("btn" & i & j, True).ElementAt(0), Button)
                    nextButton.Text = "O"
                    If CheckForWin() = "WINNER" Then
                        EvaluateWinner()
                    End If
                    lblCurrentTurn.Text = "X"
                    Exit Sub
                End If
            Next j
        Next i

        If CheckForWin() = "WINNER" Then
            EvaluateWinner()
        End If
    End Sub

    Private Sub btnClkStdActions()
        If CheckForWin() = "WINNER" Then
            EvaluateWinner()
            Exit Sub
        End If
        doNextMove()
        lblResponse.Hide()
    End Sub

    Private Sub btn21_Click(sender As Object, e As EventArgs) Handles btn21.Click
        If btn21.Text = "" Then
            btn21.Text = "X"
            board(2, 1) = "X"
            btnClkStdActions()
        Else
            lblResponse.Text = "Please choose another square."
            lblResponse.Show()
        End If

    End Sub

    Private Sub btn31_Click(sender As Object, e As EventArgs) Handles btn31.Click
        If btn31.Text = "" Then
            btn31.Text = "X"
            board(3, 1) = "X"
            btnClkStdActions()
        Else
            lblResponse.Text = "Please choose another square."
            lblResponse.Show()
        End If

    End Sub

    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        If btn12.Text = "" Then
            btn12.Text = "X"
            board(1, 2) = "X"
            btnClkStdActions()
        Else
            lblResponse.Text = "Please choose another square."
            lblResponse.Show()
        End If

    End Sub

    Private Sub btn22_Click(sender As Object, e As EventArgs) Handles btn22.Click
        If btn22.Text = "" Then
            btn22.Text = "X"
            board(2, 2) = "X"
            btnClkStdActions()
        Else
            lblResponse.Text = "Please choose another square."
            lblResponse.Show()
        End If

    End Sub

    Private Sub btn32_Click(sender As Object, e As EventArgs) Handles btn32.Click
        If btn32.Text = "" Then
            btn32.Text = "X"
            board(3, 2) = "X"
            btnClkStdActions()
        Else
            lblResponse.Text = "Please choose another square."
            lblResponse.Show()
        End If

    End Sub

    Private Sub btn13_Click(sender As Object, e As EventArgs) Handles btn13.Click
        If btn13.Text = "" Then
            btn13.Text = "X"
            board(1, 3) = "X"
            btnClkStdActions()
        Else
            lblResponse.Text = "Please choose another square."
            lblResponse.Show()
        End If

    End Sub

    Private Sub btn23_Click(sender As Object, e As EventArgs) Handles btn23.Click
        If btn23.Text = "" Then
            btn23.Text = "X"
            board(2, 3) = "X"
            btnClkStdActions()
        Else
            lblResponse.Text = "Please choose another square."
            lblResponse.Show()
        End If

    End Sub

    Private Sub btn33_Click(sender As Object, e As EventArgs) Handles btn33.Click
        If btn33.Text = "" Then
            btn33.Text = "X"
            board(3, 3) = "X"
            btnClkStdActions()
        Else
            lblResponse.Text = "Please choose another square."
            lblResponse.Show()
        End If

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        btn11.Text = ""
        btn12.Text = ""
        btn13.Text = ""
        btn21.Text = ""
        btn22.Text = ""
        btn23.Text = ""
        btn31.Text = ""
        btn32.Text = ""
        btn33.Text = ""

        'bookmark - need to loop through array to reset all array values

    End Sub
    Private Function CheckForWin()
        Dim i As Integer
        Dim j As Integer
        Dim result As String = "WINNER"

        For i = 1 To 3
            For j = 1 To 3
                If board(i, j) Is Nothing Then
                    result = "CONTINUE"
                End If
            Next j
        Next i

        Return result
    End Function

    Private Sub EvaluateWinner()
        If lblCurrentTurn.Text = "X" Then
            lblStatus.Text = "X WINS!"
        Else
            lblStatus.Text = "O WINS!"
        End If

        lblResponse.Hide()
        lblStatus.Show()
    End Sub

End Class
