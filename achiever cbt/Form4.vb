Public Class Form4

    Private Sub Form4_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Form3.Hide()
        Form2.Hide()
       

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form3.Show()
        Form2.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label3.Text = Label3.Text - 1
        If Label3.Text = 0 Then
            Label4.Text = Label4.Text - 1
            Label3.Text = 60

        End If
        If Label4.Text = -1 Then
            Timer1.Enabled = False
            Label3.Text = "00"
            Label4.Text = "00"
            MsgBox("Sorry your time is up. Click OK to see your result", MsgBoxStyle.Exclamation, "Time up")
            Me.Hide()
            Form3.Hide()
            Form2.Hide()
            Form5.Label1.Text = Val(Label10.Text) + Val(Form3.Label10.Text)
            Form5.Show()

        End If

        If Label4.Text = 5 Then

            Label3.ForeColor = Color.Red
            Label4.ForeColor = Color.Red
            Label5.ForeColor = Color.Red
        End If

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Form3.Hide()
        Form2.Hide()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Form3.Hide()
        Form2.Hide()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Form3.Hide()
        Form2.Hide()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Form3.Hide()
        Form2.Hide()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Form3.Hide()
        Form2.Hide()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Form3.Hide()
        Form2.Hide()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick

        Label9.Text = Label9.Text - 1
        If Label9.Text = 300 Then


            MsgBox("You Have less than 5 minutes for the Exam !!!")
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Hide()
        Form3.Hide()
        Dim d As Integer
        d = MsgBox("Are you sure you want to end the PUTME practice question.Click Ok to continue or Click Cancel to go back", MsgBoxStyle.OkCancel + MsgBoxStyle.DefaultButton2 + MsgBoxStyle.Question, "End putme peactice question")
        If d = 1 Then
            Me.Hide()
            Form3.Hide()
            Form2.Hide()
            Form5.Label1.Text = Val(Label10.Text) + Val(Form3.Label10.Text)
            Form5.Show()
            Timer1.Enabled = False
            Timer2.Enabled = False
        ElseIf d = 2 Then
            Form3.Show()
            Form2.Show()

        End If

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Label6.Text = TimeOfDay
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Form3.Hide()
        Form2.Hide()
        Form5.Show()
    End Sub
End Class