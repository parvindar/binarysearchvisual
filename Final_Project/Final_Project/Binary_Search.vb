Public Class CONTROLLER_2
    'INPUT ARRAY IN THE FORM OF A STRING
    Dim input_string As String = Nothing
    'NUMBER OF ELEMENTS
    Dim N As Integer = Nothing
    'FUNCTION TO CALCULATE THE INDEX OF THE DISPLAYING STRING FOR HIGHLIGHTING
    Dim inputindex() As Integer
    'FLAG FOR CONVERTING START TO NEXT AFTER THE FIRST ITERATION
    Dim started As Boolean = False
    'ELEMENT WHICH NEEDS TO BE SEARCHED BOTH IN STRING AND DECIMAL FORMAT
    Dim Element_2 As String = Nothing
    Dim Element As Decimal = Nothing
    'FLAG TO CHECK WHETHER INPUT DATA IS STRING OR NOT
    Dim isString As Boolean = False
    'FLAG TO CHECK WHETHER INPUT DATA IS EITHER INT/FLOAT OR NOT
    Dim isDec As Boolean = False
    'INPUT ARRAY IN CASE OF INPUT DATA AS ARRAY OF STRINGS
    Dim Input_Array_2(100) As String

    'DEALY FUNCTION TO PAUSE THE PROGRAM FOR A FEW SECONDS
    'ARGUMENT SPECIFIES THE NUMBER OF SECONDS FOR DELAY
    'CODE OF THIS DELAY FUNCTION COPIED FROM A TRUSTED RESOURCE(STACKOVERFLOW)
    Sub Delay(ByVal dblSecs As Double)
        Try
            Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
            Dim dblWaitTil As Date
            Now.AddSeconds(OneSec)
            dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
            Do Until Now > dblWaitTil
                Application.DoEvents() ' Allow windows messages to be processed
            Loop
        Catch ex As Exception
        End Try
    End Sub

    'RESET FUNCTION ENABLING THE USER TO TRY FOR THE NEXT INPUT
    Private Sub Reset()
        Try
            'INITIALISING ALL REQUIRED TEXTBOXES AND GLOBAL VARIABLES TO NOTHING
            ARRAY_2.Text = Nothing
            START.Text = Nothing
            ENDING.Text = Nothing
            MIDDLE.Text = Nothing
            OUTPUT.Text = Nothing
            'RESETING THE COLOR OF THE PANEL
            PANEL_RESULT.BackColor = Color.Blue
            START_2.Text = "START"
            started = False

        Catch ex As Exception

        End Try
    End Sub
    'UTILITY FUNCTION
    Private Sub Func()
        START_2.Text = "START"
    End Sub

    'START BUTTON TO BEGIN THE BINARY SEARCH
    Private Sub START_2_Click(sender As Object, e As EventArgs) Handles START_2.Click

        'RESET FUNCTION AFTER GETTING THE RESULT
        If OUTPUT.Text <> Nothing Then
            Reset()
        End If
        'DEPENDING ON WHETHER AUTO CHECKBOX IS ON DO THE PROCESS COMPLETELY OR JUST A SINGLE TIME
        Try
            Do
                'CHANGE THE START BUTTON 
                If started = False Then
                    If (autocheck.Checked = False) Then
                        START_2.Text = "NEXT"
                    End If

                    'SETTING THE ALIGNMENT FOR THE DISPLAYING TEXTBOX
                    ARRAY_2.SelectAll()
                    ARRAY_2.SelectionAlignment = HorizontalAlignment.Center

                    'INITIALSING THE GLOBAL VARIABLES
                    input_string = Nothing
                    N = Nothing

                    'TAKING THE INPUT FOR THE NUMBER OF ENTRIES
                    Dim test As String = Nothing
                    test = INPUT.Text
                    If test = Nothing Then
                        Try
                            MessageBox.Show("NO INPUT", "INVALID DATA")
                            Reset()
                            Exit Sub

                        Catch ex As Exception
                        End Try
                    End If


                    'TAKING THE INPUT FOR ALL THE ELEMENTS IN A DUMMY STRING
                    Dim Input_String2 As String = Nothing
                    Input_String2 = ARRAY.Text

                    'TAKING THE INPUT FOR THE ELEMENT TO BE SEARCHED
                    Element_2 = Nothing
                    Element = Nothing
                    Element_2 = SEARCH.Text

                    If Element_2 = Nothing Then
                        Try
                            MessageBox.Show("NO INPUT", "INVALID DATA")
                            Reset()
                            Exit Sub

                        Catch ex As Exception
                        End Try
                    End If


                    Try
                        'TRIMMING THE SPACES FROM THE START AND END OF THE INPUT FOR THE SEARCH ELEMENT
                        While Element_2.Substring(0, 1) = " " Or Element_2.Substring(Element_2.Length - 1, 1) = " "
                            If Element_2.Substring(0, 1) = " " Then
                                Element_2 = Element_2.Remove(0, 1)
                            End If
                            If Element_2.Substring(Element_2.Length - 1, 1) = " " Then
                                Element_2 = Element_2.Remove(Element_2.Length - 1, 1)
                            End If
                        End While

                        'TRIMMING THE SPACES FROM THE START AND END OF THE INPUT FOR THE NUMBER OF ENTRIES
                        While test.Substring(0, 1) = " " Or test.Substring(test.Length - 1, 1) = " "
                            If test.Substring(0, 1) = " " Then
                                test = test.Remove(0, 1)
                            End If
                            If test.Substring(test.Length - 1, 1) = " " Then
                                test = test.Remove(test.Length - 1, 1)
                            End If
                        End While
                    Catch ex As Exception
                        MessageBox.Show("NO INPUT", "INVALID DATA")
                        Reset()
                        Exit Sub
                    End Try

                    'CHECKING THE SPECIAL CASE WHEN THERE IS NO INPUT FOR THE NUMBER OF ENTRIES

                    If test.Length = 0 Then
                        Try
                            MessageBox.Show("NO INPUT", "INVALID DATA")
                            Reset()
                            Exit Sub

                        Catch ex As Exception
                        End Try
                    End If

                    'CONVERT THE INPUT INTO INTEGER FORMAT FOR FUTURE PURPOSES
                    Try
                        N = Convert.ToInt32 (test)

                    Catch ex As Exception
                        MessageBox.Show("NO INPUT", "INVALID DATA")
                        Reset()
                        Exit Sub

                    End Try


                    'CHECKING THE SPECIAL CASE WHEN THERE IS NO INPUT FOR THE SEARCH ELEMENT
                    If Element_2.Length = 0 Then
                        Try
                            MessageBox.Show("NO INPUT", "INVALID DATA")
                            Reset()
                            Exit Sub

                        Catch ex As Exception
                        End Try
                    End If

                    'CHECKING FOR THE DATATYPE MISMATCHING FOR THE INPUT REPRESENTING THE NUMBER OF ENTRIES
                    For Each x As Char In test
                        'IF THE NUMBER OF ENTRIES IS NOT AN INTEGER DISPLAY THE ERROR
                        If Char.IsNumber(x) = False Then
                            MessageBox.Show("Number of elements should be an integer!!", "INVALID INPUT VALUE")
                            Reset()
                            Exit Sub
                        End If
                    Next

                    'IF THE NUMBER OF ENTRIES EXCEEDS 10 RAISE TO THE POWER 8 DISPLAY THE ERROR AS IN MOST PROGRAMS IT TAKES TOO MUCH TIME PRACTICALLY
                    If test.Length > 8 Then
                        MessageBox.Show("Too Much Elements!!", "INVALID INPUT VALUE")
                        Reset()
                        Exit Sub
                    End If

                    'DISPLAY THE ERROR IF THERE IS NO DATA FOR THE INPUT
                    If Input_String2.Length = 0 Then
                        MessageBox.Show("ENTER SOME ELEMENTS", "INVALID INPUT")
                        Reset()
                        Exit Sub
                    End If

                    'UTILITY FLAGS FOR PROCESSING OF THE INPUT STRINGS TO GET THE INDIVIDUAL ELEMENTS
                    Dim flag_2 As Boolean = False
                    Dim flag_3 As Boolean = False

                    'PROCESSING OF THE DUMMY STRING IN ORDER TO DEAL WITH THE EXTRA SPACES AND STUFF
                    Input_String2 += " "
                    For Each c As Char In Input_String2
                        If c = " " And flag_2 = False And flag_3 = True Then
                            input_string += c
                            flag_2 = True
                        End If
                        If c <> " " Then
                            input_string += c
                            flag_2 = False
                            flag_3 = True
                        End If
                    Next

                    'IF NOTHING IS LEFT IN THE INPUT STRING AFTER TRIMMING SPACES DISPLAY THE ERROR
                    If input_string = Nothing Then
                        MessageBox.Show("ENTER SOME ELEMENTS", "INVALID INPUT")
                        Reset()
                        Exit Sub
                    End If

                    'COUNTER FOR CHECKING IF THE NUMBER OF ENTRIES ACTUALLY MATCH THE NUMBER OF ELEMENTS GIVEN AS INPUT
                    Dim i As Integer = 0

                    'UTILITY FLAG FOR CHECKING THE DATATYPE OF THE FIRST CHARACTER IN THE INPUT DATA
                    Dim flag As Boolean = False

                    'COUNTER FOR CHECKING AT WHICH STAGE OF THE INPUT DATA WE ARE CURRENTLY PROCESSING
                    Dim j As Integer = 0

                    'DUMMY STRING USED FOR CREATING AN ARRAY OF STRINGS
                    Dim help As String = Nothing

                    'FLAG FOR CHECKING IF A SPECIAL CHARACTER IS PRESENT OR NOT
                    Dim isSpecial As Boolean = False

                    'PROCESSING THE INPUT STRING FOR VARIOUS ERRORS LIKE DATATYPE MISMATCHING, SPECIAL CHARACTERS AND FINALLY GETTING THE ARRAY OF ELEMENTS
                    For Each c As Char In input_string
                        'CHECKING FOR SPECIAL CHARACTERS
                        Select Case Asc(c)
                            Case 65 To 90, 97 To 122
                            Case Else
                                If c <> "." And c <> "-" And c <> " " And Char.IsNumber(c) = False Then
                                    isSpecial = True
                                End If
                        End Select
                        'IF FLAG FOR SPECIAL CHARACTERS IS SET DISPLAY THE ERROR
                        If isSpecial = True Then
                            MessageBox.Show("No Special Characters Allowed", "INVALID DATA")
                            Reset()
                            Exit Sub
                        End If
                        'SPECIAL CASE IF FIRST CHARACTER IS A DECIMAL POINT
                        'SETTING THE FLAG TRUE AS WELL IF THE FIRST CHARACTER IS A NUMBER
                        If j = 0 Then
                            If c = "." Then
                                MessageBox.Show("Input can't start with '.'!!", "INVALID INPUT VALUE")
                                Reset()
                                Exit Sub
                            ElseIf Char.IsNumber(c) = True Or c = "-" Then
                                flag = True
                            End If
                        End If

                        'IF THE FIRST CHARACTER IS A NUMBER AND THERE IS DATA TYPE MISMATCHING LATER ON
                        If flag = True And Char.IsNumber(c) = False And c <> "." And c <> " " And c <> "-" Then
                            MessageBox.Show("Datatype Mismatching!!", "INVALID INPUT VALUE")
                            Reset()
                            Exit Sub
                        End If

                        'IF THE FIRST CHARACTER IS AN ENGLISH ALPHABET AND THERE IS DATA TYPE MISMATCHING LATER ON
                        If flag = False And Char.IsLetter(c) = False And c <> " " Then
                            MessageBox.Show("Datatype Mismatching!!", "INVALID INPUT VALUE")
                            Reset()
                            Exit Sub
                        End If

                        'SPLIT THE INPUT STRING AT SPACES FOR GETTING THE ARRAY OF ELEMENTS
                        'INCREASING THE COUNT FOR THE NUMBER OF ELEMENTS TOO
                        If c = " " Then
                            Input_Array_2(i) = help
                            i += 1
                            help = ""
                        End If
                        If c <> " " Then
                            help += c
                        End If
                        j += 1
                    Next

                    'IF NUMBER OF INPUT ELEMENTS IS LESS THAN REQUIRED NUMBER OF ENTIRES
                    If i < N Then
                        MessageBox.Show("Less Number Of Entries Than Expected!!", "INVALID INPUT VALUE")
                        Reset()
                        Exit Sub
                    End If

                    'IF NUMBER OF INPUT ELEMENTS IS GREATER THAN REQUIRED NUMBER OF ENTIRES
                    If i > N Then
                        MessageBox.Show("Greater Number Of Entries Than Expected!!", "INVALID INPUT VALUE")
                        Reset()
                        Exit Sub
                    End If

                    'FUNCTION FOR OBTAINING INDEXES OF THE FIRST CHARACTER OF EACH ELEMENT IN ORDER TO HIGHLIGHT WITH SPECIFIC COLOURS REQUIRED FOR VISUALSING THE BINARY SEARCH
                    inputindex = setindex()

                    'FLAGS FOR CHECKING IF ELEMENTS ARE STRINGS OR INT/FLOAT
                    isString = False
                    isDec = False

                    'ACCESSING THE FIRST CHARACTER OF THE FIRST ELEMENT IN ORDER TO CHECK THE DATATYPE
                    Dim c2 As Char = Input_Array_2(0)(0)
                    If Char.IsNumber(c2) Or c2 = "-" Then
                        isDec = True
                    End If
                    If Char.IsLetter(c2) = True Then
                        isString = True
                    End If
                End If

                'IF THE DATATYPE IS INT/FLOAT CONVERT THE SEARCH ELEMENT INTO THE CORRESPONDING DATATYPE
                If isDec = True Then
                    Try
                        'SPECIAL CASE WHEN THE LAST CHARACTER OF AN ELEMENT IS -
                        If Element_2(Element_2.Length - 1) = "-" Then
                            MessageBox.Show("Invalid search value!!", "INVALID SEARCH VALUE")
                            Reset()
                            Exit Sub
                        End If
                        Element = CDec(Element_2)
                    Catch ex As Exception
                        'CHECKING FOR ABSURD WAYS OF ENTERING NUMBERS
                        MessageBox.Show("Search Element should be a Decimal!!", "INVALID SEARCH VALUE")
                        Reset()
                        Exit Sub
                    End Try
                End If

                'IF THE DATATYPE IS STRING CHECK FOR FURTHER DATA TYPE MISMATCHING(CASES WHICH WERE LEFT EARLIER)
                If isDec = False Then
                    For Each c As Char In Element_2
                        If Char.IsLetter(c) = False Then
                            MessageBox.Show("Search element should contain only LowerCase or UpperCase English Alphabets!!", "INVALID SEARCH VALUE")
                            Reset()
                            Exit Sub
                        End If
                    Next
                End If

                'INPUT ARRAY WHERE REQUIRED DATATYPE IS INT/FLOAT
                Dim Input_Array(N - 1) As Decimal

                'CONVERTING THE DATATYPE OF THE INPUT ARRAY INTO THE REQUIRED ONE BY CHANGING AND COERCING EACH AND EVERY ELEMENT
                'CHECKING FOR SOME CORRESPONDING ERRORS AS WELL
                If isDec = True Then
                    For index As Integer = 0 To N - 1
                        Try
                            'SPECIAL CASE OF "-0"
                            If Input_Array_2(index) = "-0" Then
                                MessageBox.Show("Invalid Input")
                                Reset()
                                Exit Sub
                            End If
                            'HANDLING NEGATIVE NUMBERS
                            If Input_Array_2(index)(Input_Array_2(index).Length - 1) = "-" Then
                                MessageBox.Show("Invalid Input")
                                Reset()
                                Exit Sub
                            End If
                            'COERCING THE STRING INTO THE REQUIRED DATATYPE
                            Input_Array(index) = CDec(Input_Array_2(index))
                        Catch ex As Exception
                            MessageBox.Show("All Elements should be of type 'Decimal'!!", "INVALID DATA")
                            Reset()
                            Exit Sub
                        End Try
                    Next
                End If

                'CASE-1 ARRAY OF STRINGS
                If isDec = False Then
                    'SPECIAL CASE IF IT CONTAINS ONLY ONE ELEMENT
                    If N = 1 Then
                        'IF ELEMENT MATCHES I AM DONE
                        If Input_Array_2(0) = Element_2 Then
                            OUTPUT.Text = 0
                            PANEL_RESULT.BackColor = Color.SpringGreen
                            Func()
                            Exit Do
                        End If
                        'OTHERWISE ALSO OUTPUT THAT ELEMENT IS NOT PRESENT
                        PANEL_RESULT.BackColor = Color.Red
                        MessageBox.Show("Element Not Found")
                        Func()
                        Exit Do
                    End If

                    'FLAG REPRESNTING WHETHER THE INPUT DATA IS SORTED IN INCREASING OR DECREASING ORDER
                    Dim check As Boolean = False

                    'UTILITY FLAG FOR CHECKING THE SAME
                    Dim check_2 As Boolean = False

                    'CHECKING IF INPUT IS SORTED OR NOT
                    For index As Integer = 0 To N - 2
                        'IF 2 ELEMENTS ARE EQUAL PROCEED FURTHER
                        If String.Compare(Input_Array_2(index), Input_Array_2(index + 1)) = 0 Then
                            Continue For
                        End If
                        'CHECK THE FIRST INSTANCE WHEN ELEMENTS ARE NOT EQUAL WHICH TELLS US THE ORDER EITHER INCREASING OR DECREASING
                        If check_2 = False Then
                            If String.Compare(Input_Array_2(index), Input_Array_2(index + 1)) < 0 Then
                                check = True
                                check_2 = True
                            End If
                            check_2 = True
                        End If
                        'IF THE FIRST INSTANCE DEPICTS INCREASING THEN DISPLAY THE ERROR IF EARLIER ELEMENT IS GREATER THAN THE NEXT ONE
                        If check = True And check_2 = True Then
                            If String.Compare(Input_Array_2(index), Input_Array_2(index + 1)) > 0 Then
                                MessageBox.Show("NOT SORTED", "INVALID INPUT")
                                Reset()
                                Exit Sub
                            End If
                        End If
                        'IF THE FIRST INSTANCE DEPICTS DECREASING THEN DISPLAY THE ERROR IF EARLIER ELEMENT IS LOWER THAN THE NEXT ONE
                        If check = False And check_2 = True Then
                            If String.Compare(Input_Array_2(index), Input_Array_2(index + 1)) < 0 Then
                                MessageBox.Show("NOT SORTED", "INVALID INPUT")
                                Reset()
                                Exit Sub
                            End If
                        End If
                    Next

                    'IF SORTED IN INCREASING ORDER
                    If check = True Then
                        'FOR THE VERY FIRST INSTANCE:-IF THE START TEXTBOX IS EMPTY DISPLAY THE WHOLE ARRAY REPRESENTING CORRESPONDING START, MID AND END
                        If String.IsNullOrEmpty(START.Text) Then
                            'DEFINING THE INDICES
                            START.Text = 0
                            ENDING.Text = N - 1
                            Dim mid As Integer = Nothing
                            'CALCULATING THE MID
                            mid = Math.Floor((N - 1) / 2)
                            MIDDLE.Text = mid.ToString()
                            'DUMMY STRING FOR THE STORING THE COMPLETE OUTPUT IN THE FORM OF A STRING
                            Dim Output_string As String = Nothing
                            For index As Integer = 0 To N - 1
                                Output_string += Input_Array_2(index) + " "
                            Next
                            Output_string = Output_string.Remove(Output_string.Length - 1, 1)
                            'DISPLAYING THE OUTPUT
                            ARRAY_2.Text = Output_string
                            highlightlist()
                        Else
                            'GETTING THE INTEGER VALUES OF ALL THE INDICES
                            Dim found As Boolean = False
                            Dim Start_2 As Integer = Convert.ToInt32(START.Text)
                            Dim End_2 As Integer = Convert.ToInt32(ENDING.Text)
                            Dim mid As Integer = Convert.ToInt32(MIDDLE.Text)
                            'IF ELEMENT PRESENT AT THE MIDDLE OF THE ARRAY IS GREATER THAN THE REQUIRED ELEMENT TO BE SEARCHED THEN GO TO THE LEFT HALF
                            If String.Compare(Input_Array_2(mid), Element_2) > 0 Then
                                START.Text = Start_2.ToString()
                                ENDING.Text = (mid - 1).ToString()
                                MIDDLE.Text = Math.Floor(((Start_2 + mid - 1) / 2)).ToString()
                                highlightlist()
                                'IF ELEMENT PRESENT AT THE MIDDLE OF THE ARRAY IS LOWER THAN THE REQUIRED ELEMENT TO BE SEARCHED THEN GO TO THE RIGHT HALF
                            ElseIf String.Compare(Input_Array_2(mid), Element_2) < 0 Then
                                START.Text = (mid + 1).ToString()
                                ENDING.Text = End_2.ToString()
                                MIDDLE.Text = Math.Floor(((End_2 + mid + 1) / 2)).ToString()
                                highlightlist()
                            Else
                                'IF ELEMENT MATCHES THEN JUST DISPLAY THE OUTPUT
                                OUTPUT.Text = mid.ToString
                                PANEL_RESULT.BackColor = Color.SpringGreen
                                Func()
                                found = True
                                highlightlist()
                                START.Text = mid.ToString()
                                MIDDLE.Text = mid.ToString()
                                ENDING.Text = mid.ToString()
                                Exit Do
                            End If
                            'IF ELEMENT IS NOT FOUND AND START >= END:-
                            'THEN ELEMENT NOT FOUND
                            If found = False And (CInt(START.Text) >= CInt(ENDING.Text)) And (Input_Array_2(CInt(START.Text)) <> Element_2) Then
                                PANEL_RESULT.BackColor = Color.Red
                                OUTPUT.Text = "ELEMENT NOT FOUND"
                                Func()
                                Exit Do
                            End If
                        End If
                    Else
                        'THIS IS THE CASE WHEN ELEMENTS ARE SORTED IN DECREASING ORDER
                        'FOR THE VERY FIRST INSTANCE:-IF THE START TEXTBOX IS EMPTY DISPLAY THE WHOLE ARRAY REPRESENTING CORRESPONDING START, MID AND END
                        If String.IsNullOrEmpty(START.Text) Then
                            'DEFINING THE INDICES
                            START.Text = 0
                            ENDING.Text = N - 1
                            Dim mid As Integer = Nothing
                            'CALCULATING THE MID
                            mid = Math.Floor((N - 1) / 2)
                            MIDDLE.Text = mid.ToString()
                            'DUMMY STRING FOR THE STORING THE COMPLETE OUTPUT IN THE FORM OF A STRING
                            Dim Output_string As String = Nothing
                            For index As Integer = 0 To N - 1
                                Output_string += Input_Array_2(index) + " "
                            Next
                            'DISPLAYING THE OUTPUT
                            Output_string = Output_string.Remove(Output_string.Length - 1, 1)
                            ARRAY_2.Text = Output_string
                            highlightlist()
                        Else
                            'GETTING THE INTEGER VALUES OF ALL THE INDICES
                            Dim found As Boolean = False
                            Dim Start_2 As Integer = Convert.ToInt32(START.Text)
                            Dim End_2 As Integer = Convert.ToInt32(ENDING.Text)
                            Dim mid As Integer = Convert.ToInt32(MIDDLE.Text)
                            'IF ELEMENT PRESENT AT THE MIDDLE OF THE ARRAY IS GREATER THAN THE REQUIRED ELEMENT TO BE SEARCHED THEN GO TO THE RIGHT HALF
                            If String.Compare(Input_Array_2(mid), Element_2) > 0 Then
                                START.Text = Start_2.ToString()
                                ENDING.Text = (mid - 1).ToString()
                                MIDDLE.Text = Math.Floor(((Start_2 + mid - 1) / 2)).ToString()

                                highlightlist()
                                'IF ELEMENT PRESENT AT THE MIDDLE OF THE ARRAY IS LOWER THAN THE REQUIRED ELEMENT TO BE SEARCHED THEN GO TO THE LEFT HALF
                            ElseIf String.Compare(Input_Array_2(mid), Element_2) < 0 Then
                                START.Text = (mid + 1).ToString()
                                ENDING.Text = End_2.ToString()
                                MIDDLE.Text = Math.Floor(((End_2 + mid + 1) / 2)).ToString()

                                highlightlist()
                            Else
                                'IF ELEMENT MATCHES THEN JUST DISPLAY THE OUTPUT
                                OUTPUT.Text = mid.ToString
                                PANEL_RESULT.BackColor = Color.SpringGreen
                                found = True
                                Func()
                                highlightlist()
                                START.Text = mid.ToString()
                                MIDDLE.Text = mid.ToString()
                                ENDING.Text = mid.ToString()
                                Exit Do
                            End If
                            'IF ELEMENT IS NOT FOUND AND START >= END:-
                            'THEN ELEMENT NOT FOUND
                            If found = False And (CInt(START.Text) >= CInt(ENDING.Text)) And (Input_Array_2(CInt(START.Text)) <> Element_2) Then
                                PANEL_RESULT.BackColor = Color.Red
                                OUTPUT.Text = "ELEMENT NOT FOUND"
                                Func()
                                Exit Do
                            End If
                        End If
                    End If
                Else
                    'CASE-2:- ARRAY OF INT/FLOAT
                    'SPECIAL CASE IF IT CONTAINS ONLY ONE ELEMENT
                    If Input_Array.Length = 1 Then
                        If Input_Array(0) = Element Then
                            'IF ELEMENT MATCHES I AM DONE
                            PANEL_RESULT.BackColor = Color.Red
                            OUTPUT.Text = 0
                            Func()
                            Exit Do
                        End If
                        'OTHERWISE ALSO OUTPUT THAT ELEMENT IS NOT PRESENT
                        PANEL_RESULT.BackColor = Color.SpringGreen
                        MessageBox.Show("ELEMENT NOT FOUND")
                        Func()
                        Exit Do
                    End If

                    'FLAG REPRESNTING WHETHER THE INPUT DATA IS SORTED IN INCREASING OR DECREASING ORDER
                    Dim check As Boolean = False

                    'UTILITY FLAG FOR CHECKING THE SAME
                    Dim check_2 As Boolean = False

                    'CHECKING IF INPUT IS SORTED OR NOT
                    For index As Integer = 0 To Input_Array.Length - 2
                        'IF 2 ELEMENTS ARE EQUAL PROCEED FURTHER
                        If Input_Array(index) = Input_Array(index + 1) Then
                            Continue For
                        End If
                        'CHECK THE FIRST INSTANCE WHEN ELEMENTS ARE NOT EQUAL WHICH TELLS US THE ORDER EITHER INCREASING OR DECREASING
                        If check_2 = False Then
                            If Input_Array(index) < Input_Array(index + 1) Then
                                check = True
                                check_2 = True
                            End If
                            check_2 = True
                        End If
                        'IF THE FIRST INSTANCE DEPICTS INCREASING THEN DISPLAY THE ERROR IF EARLIER ELEMENT IS GREATER THAN THE NEXT ONE
                        If check = True And check_2 = True Then
                            If Input_Array(index) > Input_Array(index + 1) Then
                                Try
                                    MessageBox.Show("NOT SORTED", "INVALID INPUT")
                                    Reset()
                                    Exit Sub
                                Catch ex As Exception
                                End Try
                            End If
                        End If
                        'IF THE FIRST INSTANCE DEPICTS DECREASING THEN DISPLAY THE ERROR IF EARLIER ELEMENT IS LOWER THAN THE NEXT ONE
                        If check = False And check_2 = True Then
                            Try
                                If Input_Array(index) < Input_Array(index + 1) Then
                                    MessageBox.Show("NOT SORTED", "INVALID INOUT")
                                    Reset()
                                    Exit Sub
                                End If
                            Catch ex As Exception
                            End Try
                        End If
                    Next

                    'IF SORTED IN INCREASING ORDER
                    If check = True Then
                        'FOR THE VERY FIRST INSTANCE:-IF THE START TEXTBOX IS EMPTY DISPLAY THW WHOLE ARRAY REPRESENTING CORRESPONDING START, MID AND END
                        If String.IsNullOrEmpty(START.Text) Then
                            'DEFINING THE INDICES
                            START.Text = 0
                            ENDING.Text = N - 1
                            'CALCULATING THE MID
                            Dim mid As Integer = Nothing
                            mid = Math.Floor((N - 1) / 2)
                            MIDDLE.Text = mid.ToString()
                            'DUMMY STRING FOR THE STORING THE COMPLETE OUTPUT IN THE FORM OF A STRING
                            Dim Output_string As String = Nothing
                            For Each item As Decimal In Input_Array
                                Output_string += item.ToString() + " "
                            Next
                            'DISPLAYING THE OUTPUT
                            Output_string = Output_string.Remove(Output_string.Length - 1, 1)
                            ARRAY_2.Text = Output_string
                            highlightlist()
                        Else
                            'GETTING THE INTEGER VALUES OF ALL THE INDICES
                            Dim found As Boolean = False
                            Dim Start_2 As Integer = Convert.ToInt32(START.Text)
                            Dim End_2 As Integer = Convert.ToInt32(ENDING.Text)
                            Dim mid As Integer = Convert.ToInt32(MIDDLE.Text)
                            'IF ELEMENT PRESENT AT THE MIDDLE OF THE ARRAY IS GREATER THAN THE REQUIRED ELEMENT TO BE SEARCHED THEN GO TO THE LEFT HALF
                            If Input_Array(mid) > Element Then
                                START.Text = Start_2.ToString()
                                ENDING.Text = (mid - 1).ToString()
                                MIDDLE.Text = Math.Floor(((Start_2 + mid - 1) / 2)).ToString()
                                highlightlist()
                                'IF ELEMENT PRESENT AT THE MIDDLE OF THE ARRAY IS LOWER THAN THE REQUIRED ELEMENT TO BE SEARCHED THEN GO TO THE RIGHT HALF
                            ElseIf Input_Array(mid) < Element Then
                                START.Text = (mid + 1).ToString()
                                ENDING.Text = End_2.ToString()
                                MIDDLE.Text = Math.Floor(((End_2 + mid + 1) / 2)).ToString()
                                highlightlist()
                            Else
                                'IF ELEMENT MATCHES THEN JUST DISPLAY THE OUTPUT
                                OUTPUT.Text = mid.ToString
                                PANEL_RESULT.BackColor = Color.SpringGreen
                                found = True
                                Func()
                                highlightlist()
                                START.Text = mid.ToString()
                                MIDDLE.Text = mid.ToString()
                                ENDING.Text = mid.ToString()
                                Exit Do
                            End If
                            'IF ELEMENT IS NOT FOUND AND START >= END:-
                            'THEN ELEMENT NOT FOUND
                            If found = False And (CInt(START.Text) >= CInt(ENDING.Text)) And (Input_Array(CInt(START.Text)) <> Element) Then
                                OUTPUT.Text = "ELEMENT NOT FOUND"
                                PANEL_RESULT.BackColor = Color.Red
                                Func()
                                Exit Do
                            End If
                        End If
                    Else
                        'FOR THE VERY FIRST INSTANCE:-IF THE START TEXTBOX IS EMPTY DISPLAY THW WHOLE ARRAY REPRESENTING CORRESPONDING START, MID AND END
                        If String.IsNullOrEmpty(START.Text) Then
                            'DEFINING THE INDICES
                            START.Text = 0
                            ENDING.Text = N - 1
                            'CALCULATING THE MID
                            Dim mid As Integer = Nothing
                            mid = Math.Floor((N - 1) / 2)
                            MIDDLE.Text = mid.ToString()
                            'DUMMY STRING FOR THE STORING THE COMPLETE OUTPUT IN THE FORM OF A STRING
                            Dim Output_string As String = Nothing
                            For Each item As Decimal In Input_Array
                                Output_string += item.ToString() + " "
                            Next
                            'DISPLAYING THE OUTPUT
                            Output_string = Output_string.Remove(Output_string.Length - 1, 1)
                            ARRAY_2.Text = Output_string
                            highlightlist()
                        Else
                            'GETTING THE INTEGER VALUES OF ALL THE INDICES
                            Dim found As Boolean = False
                            Dim Start_2 As Integer = Convert.ToInt32(START.Text)
                            Dim End_2 As Integer = Convert.ToInt32(ENDING.Text)
                            Dim mid As Integer = Convert.ToInt32(MIDDLE.Text)
                            'IF ELEMENT PRESENT AT THE MIDDLE OF THE ARRAY IS LOWER THAN THE REQUIRED ELEMENT TO BE SEARCHED THEN GO TO THE LEFT HALF
                            If Input_Array(mid) < Element Then
                                START.Text = Start_2.ToString()
                                ENDING.Text = (mid - 1).ToString()
                                MIDDLE.Text = Math.Floor(((Start_2 + mid - 1) / 2)).ToString()
                                highlightlist()
                                'IF ELEMENT PRESENT AT THE MIDDLE OF THE ARRAY IS GREATER THAN THE REQUIRED ELEMENT TO BE SEARCHED THEN GO TO THE RIGHT HALF
                            ElseIf Input_Array(mid) > Element Then
                                START.Text = (mid + 1).ToString()
                                ENDING.Text = End_2.ToString()
                                MIDDLE.Text = Math.Floor(((End_2 + mid + 1) / 2)).ToString()
                                highlightlist()
                            Else
                                'IF ELEMENT MATCHES THEN JUST DISPLAY THE OUTPUT
                                OUTPUT.Text = mid.ToString
                                PANEL_RESULT.BackColor = Color.SpringGreen
                                Func()
                                found = True
                                highlightlist()
                                START.Text = mid.ToString()
                                MIDDLE.Text = mid.ToString()
                                ENDING.Text = mid.ToString()
                                Exit Do
                            End If
                            'IF ELEMENT IS NOT FOUND AND START >= END:-
                            'THEN ELEMENT NOT FOUND
                            If found = False And (CInt(START.Text) >= CInt(ENDING.Text)) And (Input_Array(CInt(START.Text)) <> Element) Then
                                PANEL_RESULT.BackColor = Color.Red
                                OUTPUT.Text = "ELEMENT NOT FOUND"
                                Func()
                                Exit Do
                            End If
                        End If
                    End If
                End If
                'IF THE CHECKBOX IS ON FOR VISUALISING CALLING THE DELAY FUNCTION AFTER EVERY ITERATION
                If (autocheck.Checked) Then
                    Delay(1)
                End If
            Loop While autocheck.Checked
        Catch ex As Exception
        End Try
    End Sub
    'FUNCTION FOR OBTAINING INDEXES OF THE FIRST CHARACTER OF EACH ELEMENT IN ORDER TO HIGHLIGHT WITH SPECIFIC COLOURS REQUIRED FOR VISUALSING THE BINARY SEARCH
    Function setindex() As Integer()
        Try
            Dim j As Integer = 1
            Dim index(N) As Integer
            'SET INDEX OF FIRST ELEMENT TO 0
            index(0) = 0
            For i As Integer = 0 To input_string.Length - 1
                'EVERY CHARACTER AFTER SPACES IS ASIGNED NEW INDEX.
                If input_string(i) = " " Then
                    index(j) = i + 1
                    j = j + 1
                End If
            Next
            Return index
        Catch ex As Exception
        End Try
    End Function
    'FUNCTION USED TO COLOR THE RANGE OF SELECTED ELEMENTS CORRESPONDING TO LEFT, MID AND RIGHT INDICES .
    Private Sub highlightlist()
        Try

            'COLORING THE LEFT AND RIGHT INDICES WITH AQUA COLOR.
            ARRAY_2.Select(inputindex(CInt(START.Text)), inputindex(CInt(START.Text) + 1) - inputindex(CInt(START.Text)) - 1)
            ARRAY_2.SelectionBackColor = Color.Aqua

            'IF RIGHT ELEMENT IS THE LAST ELEMENT OF THE ARRAY.
            If CInt(ENDING.Text) = inputindex.Length - 2 Then
                ARRAY_2.Select(inputindex(CInt(ENDING.Text)), input_string.Length - inputindex(CInt(ENDING.Text) - 1))
                ARRAY_2.SelectionBackColor = Color.Aqua
            Else
                ARRAY_2.Select(inputindex(CInt(ENDING.Text)), inputindex(CInt(ENDING.Text) + 1) - inputindex(CInt(ENDING.Text)) - 1)
                ARRAY_2.SelectionBackColor = Color.Aqua
            End If

            'COLOR THE MID ELEMENT WITH ORANGE COLOR.
            ARRAY_2.Select(inputindex(CInt(MIDDLE.Text)), inputindex(CInt(MIDDLE.Text) + 1) - inputindex(CInt(MIDDLE.Text)) - 1)
            ARRAY_2.SelectionBackColor = Color.Orange

            'COLOR THE DISCARDED PORTION OF THE ARRAY WITH GRAY COLOR.
            'COLOR ELEMENTS RIGHTSIDE OF THE RIGHT INDEX WITH GRAY.
            If CInt(ENDING.Text) <> inputindex.Length - 2 Then
                ARRAY_2.Select(inputindex(CInt(ENDING.Text) + 1) - 1, input_string.Length - inputindex(CInt(ENDING.Text) + 1) + 1)
                ARRAY_2.SelectionBackColor = Color.Gray

            End If
            'COLOR ELEMENTS LEFTSIDE OF THE LEFT INDEX WITH GRAY COLOR.
            ARRAY_2.Select(inputindex(0), inputindex(CInt(START.Text)))
            ARRAY_2.SelectionBackColor = Color.Gray
            Return
        Catch ex As Exception
        End Try
    End Sub

    'RESET FUNCTION TO SET ALL THE OBJECTS TO THEIR INITIAL STATE.
    Private Sub RESET_2_Click(sender As Object, e As EventArgs) Handles RESET_2.Click
        Try
            INPUT.Text = Nothing
            SEARCH.Text = Nothing
            ARRAY.Text = Nothing
            ARRAY_2.Text = Nothing
            START.Text = Nothing
            ENDING.Text = Nothing
            MIDDLE.Text = Nothing
            OUTPUT.Text = Nothing
            PANEL_RESULT.BackColor = Color.Blue
            START_2.Text = "START"
            started = False
        Catch ex As Exception
        End Try
    End Sub

    'FUNCTION TO TAKE INPUTS FROM FILE.
    Private Sub button_file_Click(sender As Object, e As EventArgs) Handles button_file.Click
        Try
            MessageBox.Show("Input format for file -" + Environment.NewLine + "Number of elements of input    (newline)" + Environment.NewLine + "Element to be searched  (newline)" + Environment.NewLine + "Space seperated elements of any similar type", "INFO")
            'OPENS THE FILE BROWSER TO SELECT INPUT FILE.
            Dim fd As OpenFileDialog = New OpenFileDialog()
            'STRING TO FETCH ALL THE CONTENTS OF THE FILE.
            Dim fileReader As String = Nothing
            Dim dumm_3 As String = Nothing
            If fd.ShowDialog() = DialogResult.OK Then
                dumm_3 = fd.FileName
            End If
            'READS ALL THE CONTENTS OF THE FILE. 
            fileReader = My.Computer.FileSystem.ReadAllText(dumm_3)
            'SPLITTING THE CONTENTS OF THE FILE AT EVERY NEW LINE.
            Dim file() As String = fileReader.Split(Environment.NewLine)
            Dim dummy As String = Nothing
            Dim dummy_2 As String = Nothing
            'ALLOCATING THE ELEMENTS TO THE CORRESTPONDING TEXTBOX.
            INPUT.Text = file(0)
            SEARCH.Text = file(1)
            dummy = file(2)
            For index = 1 To dummy.Length - 1
                dummy_2 += dummy(index)
            Next
            ARRAY.Text = dummy_2
        Catch ex As Exception
        End Try
    End Sub

End Class
