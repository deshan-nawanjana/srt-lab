Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      
    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

        Me.Tag = Me.OpenFileDialog1.FileName
        Me.TextBox1.Text = My.Computer.FileSystem.ReadAllText(Me.Tag)

        TextBox1.Focus()
        TextBox1.Select(0, 0)


    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        My.Computer.FileSystem.WriteAllText(Me.SaveFileDialog1.FileName, Me.TextBox1.Text, False)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Me.Tag = "" Then
        Else
            resync.ShowDialog()
        End If
        TextBox1.Focus()
        TextBox1.Select(0, 0)
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F11 Then
            TextBox1.Focus()
            TextBox1.Select(0, 0)
            If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None Then
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                Me.WindowState = FormWindowState.Normal
                Exit Sub
            Else
                Me.WindowState = FormWindowState.Normal
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                Me.WindowState = FormWindowState.Maximized
            End If

        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Font = fs1.Font
        TextBox1.Focus()
        TextBox1.Select(0, 0)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        TextBox1.Focus()
        TextBox1.Select(0, 0)
        If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Me.WindowState = FormWindowState.Normal
            Exit Sub
        Else
            Me.WindowState = FormWindowState.Normal
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
        End If

    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        TextBox1.Focus()
        TextBox1.Select(0, 0)

        If TextBox1.Font.Size = fs0.Font.Size Then
            TextBox1.Font = fs1.Font
            Exit Sub
        End If
        If TextBox1.Font.Size = fs1.Font.Size Then
            TextBox1.Font = fs2.Font
            Exit Sub
        End If
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        TextBox1.Focus()
        TextBox1.Select(0, 0)

        If TextBox1.Font.Size = fs2.Font.Size Then
            TextBox1.Font = fs1.Font
            Exit Sub
        End If
        If TextBox1.Font.Size = fs1.Font.Size Then
            TextBox1.Font = fs0.Font
            Exit Sub
        End If

    End Sub

    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn.Click
        OpenFileDialog1.ShowDialog()
        TextBox1.Focus()
        TextBox1.Select(0, 0)
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.SaveFileDialog1.FileName = Me.Tag
        Me.SaveFileDialog1.ShowDialog()
        TextBox1.Focus()
        TextBox1.Select(0, 0)
    End Sub

    Private Sub btn_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn.MouseLeave

        tt1.Hide()
        tt2.Hide()
        tt3.Hide()
        tt4.Hide()
    End Sub

    Private Sub btn_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btn.MouseMove
        tt1.Show()
        tt2.Hide()
        tt3.Hide()
        tt4.Hide()
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave

        tt1.Hide()
        tt2.Hide()
        tt3.Hide()
        tt4.Hide()
    End Sub

    Private Sub Button2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button2.MouseMove
        tt1.Hide()
        tt3.Hide()
        tt2.Show()
        tt4.Hide()
    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave

        tt1.Hide()
        tt2.Hide()
        tt3.Hide()
        tt4.Hide()
    End Sub

    Private Sub Button3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button3.MouseMove
        tt3.Show()
        tt1.Hide()
        tt2.Hide()
        tt4.Hide()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.F11 Then
            TextBox1.Focus()
            TextBox1.Select(0, 0)
            If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None Then
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                Me.WindowState = FormWindowState.Normal
                Exit Sub
            Else
                Me.WindowState = FormWindowState.Normal
                Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                Me.WindowState = FormWindowState.Maximized
            End If

        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Me.Tag = "" Then
        Else
            Try
                editor.ShowDialog()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Button7_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.MouseHover

    End Sub

    Private Sub Button7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.MouseLeave

        tt1.Hide()
        tt2.Hide()
        tt3.Hide()
        tt4.Hide()
    End Sub

    Private Sub Button7_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button7.MouseMove

        tt1.Hide()
        tt2.Hide()
        tt3.Hide()
        tt4.Show()
    End Sub
End Class
