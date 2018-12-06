Public Class Form3

    Private Sub RadioButton19_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton19.CheckedChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a44, a45, a46, a47, a48, a49, a50 As Integer
        If b44.Checked = True Then
            a44 = 2
        End If
        If b45.Checked = True Then
            a45 = 2
        End If
        If b47.Checked = True Then
            a47 = 2
        End If
        If b48.Checked = True Then
            a48 = 2
        End If
        If b49.Checked = True Then
            a49 = 2
        End If
        If b50.Checked = True Then
            a50 = 2
        End If
        If b46.Checked = True Then
            a46 = 2
        End If

        Label10.Text = a44 + a45 + a46 + a47 + a48 + a49 + a50


        Dim a As Integer
        a = Label8.Text
        Label8.Text = a + 1
        If a = 1 Then
            GroupBox2.Visible = True
        ElseIf a = 2 Then
            GroupBox3.Visible = True
        ElseIf a = 3 Then
            GroupBox4.Visible = True
        ElseIf a = 4 Then
            GroupBox5.Visible = True
        ElseIf a = 5 Then
            GroupBox6.Visible = True
        ElseIf a = 6 Then
            GroupBox7.Visible = True
            Button1.Text = "SUBMIT"


        ElseIf a = 7 Then
            Dim d As Integer

            d = MsgBox("Are you sure you want to end the PUTME practice question.Click Ok to continue or Click Cancel to go back", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, "End putme peactice question")
            If d = 1 Then
                Me.Hide()
                Form2.Hide()
                Form4.Hide()
                Form4.Timer1.Enabled = False

                Form5.Label1.Text = Val(Label9.Text) + Val(Label10.Text)
                Form5.Show()
                Label8.Text = "7"
            ElseIf d = 2 Then
                Label8.Text = "7"
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim a As Integer
        a = Label8.Text
        Label8.Text = a - 1
        If a = 1 Then
            Me.Hide()
            Form4.Show()
            Form2.Show()
            Label8.Text = "1"
        ElseIf a = 2 Then
            GroupBox2.Visible = False

        ElseIf a = 3 Then
            GroupBox3.Visible = False
        ElseIf a = 4 Then
            GroupBox4.Visible = False
        ElseIf a = 5 Then
            GroupBox5.Visible = False
        ElseIf a = 6 Then
            GroupBox6.Visible = False
        ElseIf a = 7 Then
            GroupBox7.Visible = False
            Button1.Text = "NEXT"
            Button3.Text = "NEXT"
        End If

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form3_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim a As Integer
        a = Label8.Text
        Label8.Text = a + 1
        If a = 1 Then
            GroupBox2.Visible = True
        ElseIf a = 2 Then
            GroupBox3.Visible = True
        ElseIf a = 3 Then
            GroupBox4.Visible = True
        ElseIf a = 4 Then
            GroupBox5.Visible = True
        ElseIf a = 5 Then
            GroupBox6.Visible = True
        ElseIf a = 6 Then
            GroupBox7.Visible = True
            Button3.Text = "CLOSE"

        ElseIf a = 7 Then
            Me.Hide()
            Form2.Hide()
            Form4.Hide()
            Form5.Show()
            Label8.Text = "7"
        End If
    End Sub
End Class