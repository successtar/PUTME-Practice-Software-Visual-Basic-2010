Public Class Form5

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Label1.Text < 40 Then
            Label5.Text = "FAIL"
            Label5.ForeColor = Color.Red
            Label1.ForeColor = Color.Red
            Label8.ForeColor = Color.Red
            Label10.ForeColor = Color.Red
            Label8.Text = "Very poor but don't give up,you can still do better."

        End If

        If Label1.Text >= 40 Then
            Label5.Text = "PASS"
            Label8.Text = "Poor result but you can still do better."
            Label5.ForeColor = Color.Orange
            Label1.ForeColor = Color.Orange
            Label8.ForeColor = Color.Orange
        End If
        If Label1.Text >= 50 Then
            Label5.Text = "CREDIT"
            Label8.Text = "Average result, work harder."
            Label5.ForeColor = Color.Magenta
            Label1.ForeColor = Color.Magenta
            Label8.ForeColor = Color.Magenta
        End If
        If Label1.Text >= 60 Then
            Label5.Text = "GOOD"
            Label8.Text = "Nice result but you can still do better."
        End If
            If Label1.Text >= 70 Then
                Label5.Text = "EXCELLENT"
            Label8.Text = "Wow!!! what a great result,keep it up"
        End If
     
        
        

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form4.Show()
        Form2.Show()
        Form3.Show()
        Form3.Button1.Visible = False
        Form3.Button3.Visible = True
        Form4.Button3.Visible = True
        Form4.Label3.Visible = False
        Form4.Label4.Visible = False
        Form4.Label5.Visible = False
        Form4.Label1.Visible = True
        Form4.Label2.Visible = True
        Form4.Label7.Visible = True
        Form4.Button1.Visible = False
        Form4.Label8.Text = "       CORRECTION !!!!"
        If Form3.Label8.Text = 7 Then


            Form3.Button3.Text = "CLOSE"
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)

    End Sub
End Class