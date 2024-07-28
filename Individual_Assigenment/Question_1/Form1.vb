Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim strSentence As String = txtSentences.Text
        Dim strWords() As String = strSentence.Split(" "c)
        Dim pigLatinWords As New List(Of String)

        If String.IsNullOrEmpty(strSentence) Then
            MessageBox.Show("Please input a sentence.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        For Each word As String In strWords
            pigLatinWords.Add(ConvertToPigLatin(word))
        Next

        txtLatin.Text = String.Join(" ", pigLatinWords)

    End Sub

    Private Function ConvertToPigLatin(word As String) As String

        If String.IsNullOrEmpty(word) Then
            Return word
        End If

        Dim firstLetter As Char = word(0)
        If "aeiouAEIOU".IndexOf(firstLetter) >= 0 Then
            ' Word starts with a vowel
            Return word & "way"
        Else
            ' Word starts with a consonant
            Return word.Substring(1) & firstLetter & "ary"
        End If
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSentences.Clear()
        txtLatin.Clear()
    End Sub
End Class
