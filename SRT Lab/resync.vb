Public Class resync

    Dim oxt = ""
    Dim vax = ""
    Dim def = ""
    Dim errx = ""


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        errx = ""
        vax = ""

        Dim cnt = Me.TextBox1.Text
        Dim n = 0
        For Each c As Char In cnt
            If n = 0 Then
                If c = "+" Then
                    def = "+"
                ElseIf c = "-" Then
                    def = "-"
                Else
                    def = "+"
                    vax += c
                End If
            Else
                vax += c
            End If
            n += 1
        Next





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
                        out += spc.Text & a & spc.Text
                        sit = "n"
                        done = "1"
                        n_c += 1
                    End If
                End If
            End If
            If a = "0" Then
                out += spc.Text & a & spc.Text
                sit = "n"
                done = "1"
                n_c += 1
            End If

            ' number finder ============

            If a = "" Then
            Else



                If done = "0" And (a.Length = 29) And sit = "n" Then
                    re(a, ret)
                    out += oxt & spc.Text
                    sit = "t"
                    done = "1"
                    t_c += 1
                End If
                If done = "0" And (a.Length = 28) And sit = "n" Then
                    re(a, ret)
                    out += oxt & spc.Text
                    sit = "t"
                    done = "1"
                    t_c += 1
                End If
                If done = "0" And (a.Length = 27) And sit = "n" Then
                    re(a, ret)
                    out += oxt & spc.Text
                    sit = "t"
                    done = "1"
                    t_c += 1
                End If



                If (done = "0") Then
                    out += a & spc.Text
                    sit = "s"
                    done = "1"
                    s_c += 1

                End If
            End If

        Loop Until a Is Nothing

        If errx = "" Then

            Form1.TextBox1.Text = out
            out = ""
            reader.Close()

            Dim oldr = Val(Me.Tag)
            Me.Tag = oldr + Val(Me.TextBox1.Text)

            Me.Close()
        Else

        End If
    End Sub













    Private Sub re(ByVal x, ByVal t)
        Dim pa = ""
        Dim pb = ""

        Dim tmp = ""
        For Each c As Char In x
            If c = " " Or c = "-" Or c = ">" Then
                pa = tmp
            Else
                tmp += c
            End If
        Next
        tmp = ""
        For Each c As Char In x
            If c = " " Or c = "-" Or c = ">" Then
                tmp = ""
            Else
                tmp += c
            End If
        Next
        pb = tmp





        Dim pat = 0
        Dim s = 1
        Dim d = 0
        tmp = ""
        For Each c As Char In pa
            d = 0

            If c = ":" And s = 1 And d = 0 Then
                s = 2
                d = 1
                pat += Val(tmp) * 3600 * 1000
                tmp = ""
            End If

            If c = ":" And s = 2 And d = 0 Then
                s = 3
                d = 1
                pat += Val(tmp) * 60 * 1000
                tmp = ""
            End If

            If c = "," And s = 3 And d = 0 Then
                s = 4
                d = 1
                pat += Val(tmp) * 1000
                tmp = ""
            End If


            If d = 0 Then
                tmp += c
            End If
        Next
        pat += Val(tmp)


        Dim pbt = 0
        s = 1
        d = 0
        tmp = ""
        For Each c As Char In pb
            d = 0

            If c = ":" And s = 1 And d = 0 Then
                s = 2
                d = 1
                pbt += Val(tmp) * 3600 * 1000
                tmp = ""
            End If

            If c = ":" And s = 2 And d = 0 Then
                s = 3
                d = 1
                pbt += Val(tmp) * 60 * 1000
                tmp = ""
            End If

            If c = "," And s = 3 And d = 0 Then
                s = 4
                d = 1
                pbt += Val(tmp) * 1000
                tmp = ""
            End If


            If d = 0 Then
                tmp += c
            End If
        Next
        pbt += Val(tmp)






        If def = "+" Then
            pat += Val(vax)
            pbt += Val(vax)
        Else

            If Val(vax) > pat Or Val(vax) > pbt Then
                errr.Text = "Not able to Resync Subtitle to backward more than 0 ms"
                errx = "1"
            Else
                pat -= Val(vax)
                pbt -= Val(vax)
            End If

        End If




        Dim a_ms = pat Mod 1000
        Dim b_ms = pbt Mod 1000

        Dim a_tt_s = (pat - a_ms) / 1000
        Dim b_tt_s = (pbt - b_ms) / 1000

        Dim a_s = a_tt_s Mod 60
        Dim b_s = b_tt_s Mod 60

        Dim a_tt_m = (a_tt_s - a_s) / 60
        Dim b_tt_m = (b_tt_s - b_s) / 60

        Dim a_m = a_tt_m Mod 60
        Dim b_m = b_tt_m Mod 60

        Dim a_h = (a_tt_m - a_m) / 60
        Dim b_h = (b_tt_m - b_m) / 60






        Dim fa = ""

        If a_h.ToString.Length = 1 Then
            fa += "0" & a_h.ToString
        Else
            fa += a_h.ToString
        End If

        fa += ":"

        If a_m.ToString.Length = 1 Then
            fa += "0" & a_m.ToString
        Else
            fa += a_m.ToString
        End If

        fa += ":"

        If a_s.ToString.Length = 1 Then
            fa += "0" & a_s.ToString
        Else
            fa += a_s.ToString
        End If

        fa += ","

        If a_ms.ToString.Length = 1 Then
            fa += "00" & a_ms.ToString
        ElseIf a_ms.ToString.Length = 2 Then
            fa += "0" & a_ms.ToString
        Else
            fa += a_ms.ToString
        End If


        '==============================

        Dim fb = ""

        If b_h.ToString.Length = 1 Then
            fb += "0" & a_h.ToString
        Else
            fb += b_h.ToString
        End If

        fb += ":"

        If b_m.ToString.Length = 1 Then
            fb += "0" & b_m.ToString
        Else
            fb += b_m.ToString
        End If

        fb += ":"

        If b_s.ToString.Length = 1 Then
            fb += "0" & b_s.ToString
        Else
            fb += b_s.ToString
        End If

        fb += ","

        If b_ms.ToString.Length = 1 Then
            fb += "00" & b_ms.ToString
        ElseIf a_ms.ToString.Length = 2 Then
            fb += "0" & b_ms.ToString
        Else
            fb += b_ms.ToString
        End If

        oxt = fa & " --> " & fb


    End Sub




    Private Sub resync_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub


    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Button3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button3.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub resync_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        errx = ""
        errr.Text = ""
        Me.Label4.Text = "Total Resync : " & Val(Me.Tag) & " ms"
        Me.TextBox1.Text = ""
        Try

            My.Computer.FileSystem.WriteAllText("C:\tmp.xml", Form1.TextBox1.Text, False)
        Catch ex As Exception

        End Try
    End Sub
End Class