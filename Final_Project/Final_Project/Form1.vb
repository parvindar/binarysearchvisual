Public Class CONTROLLER_2

    Private Sub START_2_Click(sender As Object, e As EventArgs) Handles START_2.Click
        Dim N As Integer = Nothing
        Dim test As String = Nothing
        test = INPUT.Text
        For Each x As Char In test
            If Char.IsNumber(x) = False Then
                OUTPUT.Text = "Invalid Number of Entries"
                MsgBox("Terminating program")
                End
            End If
        Next
        If test.Length > 8 Then
            MsgBox("terminating program")
            End
        End If

        N = Convert.ToInt32(INPUT.Text)
        Dim Input_String As String = Nothing
        Dim Input_Array(100) As String
        Input_String = ARRAY.Text
        Dim i As Integer = 0
        Dim s As String = Nothing
        Dim flag As Boolean = False
        Dim j As Integer = 0
        Dim help As String = Nothing
        For Each c As Char In Input_String
            If j = 0 Then
                If c = "." Then
                    MsgBox("invalid input")
                    End
                ElseIf Char.IsNumber(c) = True Then
                    flag = True
                End If
            End If

            If flag = True And Char.IsNumber(c) = False And c <> "." And c <> " " Then
                MsgBox("invalid input")
                End
            End If
            If flag = False And Char.IsLetter(c) = False And c <> " " Then
                MsgBox("invalid input")
                End
            End If
            If c = " " Then
                Input_Array(i) = help
                i += 1
                help = ""
            End If
            If c <> " " Then
                help += c
            End If
            j += 1
        Next
        'ARRAY_2.Text = s

        Dim Element As String = Nothing
        Element = SEARCH.Text
        If String.IsNullOrEmpty(START.Text) Then
            START.Text = 0
            ENDING.Text = i - 1
            Dim mid As Integer = Nothing
            mid = Math.Floor((i - 1) / 2)
            MIDDLE.Text = mid.ToString()
            Dim Output_string As String = Nothing
            For Each item As String In Input_Array
                Output_string += item + " "
            Next
            ARRAY_2.Text = Output_string
        Else
            Dim Start_2 As Integer = Convert.ToInt32(START.Text)
            Dim End_2 As Integer = Convert.ToInt32(ENDING.Text)
            Dim mid As Integer = Convert.ToInt32(MIDDLE.Text)
            If Input_Array(mid) > Element Then
                START.Text = Start_2.ToString()
                ENDING.Text = (mid - 1).ToString()
                MIDDLE.Text = Math.Floor(((Start_2 + mid - 1) / 2)).ToString()
                Dim output_string As String = Nothing
                For index As Integer = Start_2 To mid - 1
                    output_string += Input_Array(index) + " "
                Next
                ARRAY_2.Text = output_string

            ElseIf Input_Array(mid) < Element Then
                START.Text = (mid + 1).ToString()
                ENDING.Text = End_2.ToString()
                MIDDLE.Text = Math.Floor(((End_2 + mid + 1) / 2)).ToString()
                Dim output_string As String = Nothing
                For index As Integer = mid + 1 To End_2
                    output_string += Input_Array(index) + " "
                Next
                ARRAY_2.Text = output_string
            Else
                OUTPUT.Text = mid.ToString
                ARRAY_2.Text = Input_Array(mid)
                START.Text = mid.ToString()
                MIDDLE.Text = mid.ToString()
                ENDING.Text = mid.ToString()
                End
            End If
            If START.Text = ENDING.Text Then
                OUTPUT.Text = "element not present"
                ARRAY_2.Text = ""
            End If

        End If

    End Sub

    Private Sub MIDDLE_TextChanged(sender As Object, e As EventArgs) Handles MIDDLE.TextChanged

    End Sub
End Class
