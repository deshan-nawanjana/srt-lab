Public Class editor

    Private Sub editor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
 
        My.Computer.FileSystem.WriteAllText("C:\tmp.xml", Form1.TextBox1.Text, False)





        Me.ListBox1.Items.Clear()



        Dim reader As IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\tmp.xml")
        Dim a As String

        Dim out = ""
        Dim sit = ""
        Dim done = "0"
        Dim n_c = 0
        Dim t_c = 0
        Dim s_c = 0
        Dim ret = 0
        Do
            done = "0"
            a = reader.ReadLine

            ' number finder ============
            If a = "" Then
            Else
                If Val(a) / 1 = 0 Then
                Else
                    If a.Length < 6 Then
                        Me.ListBox1.Items.Add(a)
                        sit = "n"
                    End If
                End If
            End If
            If a = "0" Then
                Me.ListBox1.Items.Add(a)
                sit = "n"
                done = "1"
                n_c += 1
            End If

            ' number finder ============

            If a = "" Then
            Else


                If done = "0" And (a.Length = 29) And sit = "n" Then
                    sit = "t"
                    done = "1"
                    t_c += 1
                End If
                If done = "0" And (a.Length = 28) And sit = "n" Then
                    sit = "t"
                    done = "1"
                    t_c += 1
                End If
                If done = "0" And (a.Length = 27) And sit = "n" Then
                    sit = "t"
                    done = "1"
                    t_c += 1
                End If


                If (done = "0") Then
                    If sit = "s" Then
                        done = "1"
                        sit = "s"
                    ElseIf sit = "t" Then
                        sit = "s"
                        done = "1"
                        s_c += 1
                    End If

                End If
            End If

        Loop Until a Is Nothing



        reader.Close()

        If ListBox1.Items.Count > 0 Then
            Me.ListBox1.SelectedItem = ListBox1.Items.Item(0)
            Me.TextBox1.Text = ListBox1.Items.Item(0)
        End If


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim o = (ListBox1.Items.IndexOf(ListBox1.SelectedItem))
        If ListBox1.Items.Count > o Then
            Try
                Me.ListBox1.SelectedItem = ListBox1.Items.Item(o + 1)
                Me.TextBox1.Text = ListBox1.Items.Item(o + 1)


            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged


        Try
            Me.ListBox1.SelectedItem = Me.TextBox1.Text
        Catch ex As Exception

        End Try





        Dim reader As IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader("C:\tmp.xml")
        Dim a As String

        Dim out = ""
        Dim sit = ""
        Dim done = "0"
        Dim n_c = 0
        Dim t_c = 0
        Dim s_c = 0
        Dim ret = 0
        Dim need = Me.TextBox1.Text
        Dim needn = ""
        Do
            done = "0"
            a = reader.ReadLine

            ' number finder ============
            If a = "" Then
            Else
                If Val(a) / 1 = 0 Then
                Else
                    If a.Length < 6 Then
                        If needn = "2" Or needn = "1" Then
                            Exit Sub
                        End If

                        If a = need Then
                            needn = "1"
                        End If

                        sit = "n"
                    End If
                End If
            End If
            If a = "0" Then

                If needn = "1" Then
                    needn = "x"
                End If
                If a = need Then
                    needn = "1"
                End If
                sit = "n"
                done = "1"
                n_c += 1
            End If

            ' number finder ============

            If a = "" Then
            Else


                If done = "0" And (a.Length = 29) And sit = "n" Then
                    If needn = "1" Then
                        Me.TextBox2.Text = a
                    End If
                    sit = "t"
                    done = "1"
                    t_c += 1
                End If
                If done = "0" And (a.Length = 28) And sit = "n" Then

                    If needn = "1" Then
                        Me.TextBox2.Text = a
                    End If
                    sit = "t"
                    done = "1"
                    t_c += 1
                End If
                If done = "0" And (a.Length = 27) And sit = "n" Then

                    If needn = "1" Then
                        Me.TextBox2.Text = a
                    End If
                    sit = "t"
                    done = "1"
                    t_c += 1
                End If


                If (done = "0") Then
                    If sit = "s" Then
                        If needn = "2" Then
                            Me.TextBox3.Text += spc.Text & a
                            needn = "2"
                        End If
                        done = "1"
                        sit = "s"
                    ElseIf sit = "t" Then

                        If needn = "1" Then
                            Me.TextBox3.Text = a
                            needn = "2"
                        End If
                        sit = "s"
                        done = "1"
                        s_c += 1
                    End If

                End If
            End If

        Loop Until a Is Nothing



        reader.Close()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim o = (ListBox1.Items.IndexOf(ListBox1.SelectedItem))
        If o > 0 Then
            Me.ListBox1.SelectedItem = ListBox1.Items.Item(o - 1)
            Me.TextBox1.Text = ListBox1.Items.Item(o - 1)
        End If
    End Sub
End Class