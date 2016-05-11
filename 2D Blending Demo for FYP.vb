Imports System.IO
Imports System.Threading
Imports Microsoft.VisualBasic.PowerPacks
Imports Microsoft.VisualBasic.Strings
Imports System.Math

Public Class Form1

    ' Open File as Textname
    Private txtFileName As Object
    Private fromFileName As String
    Private toFileName As String
    ' Variable
    Private Max_X As Integer
    Private Min_X As Integer
    Private Mid_X As Integer
    Private Max_Y As Integer
    Private Min_Y As Integer
    Private Mid_Y As Integer
    Private NumVertexFrom As Integer
    Private NumVertexTo As Integer
    Private Different As Integer

    ' True for Vertex and False for Edge
    'Private MorphMethod As Boolean
    Private Auto_Start As Boolean

    ' Step Variable 
    Private MorphStep As Integer
    Private TotalStep As Integer    ' this is input by user
    Private initialTotalStep As Integer 'this can be changed 

    ' Coordinate of From  To  Morph
    Private FromX(0) As Double
    Private FromY(0) As Double
    Private ToX(0) As Double
    Private ToY(0) As Double
    Private MorphX(0) As Double
    Private MorphY(0) As Double

    ' Copy of from and to array after sync
    Private CopyFromX(0) As Double
    Private CopyFromY(0) As Double
    Private CopyToX(0) As Double
    Private CopyToY(0) As Double
    Private numofVertex As Integer 'the numofVertex is the num of vertexes after synced vertexes

    'for edge tweakling
    Dim srcAngleArray(0) As Double
    Dim destAngleArray(0) As Double
    Dim LA(0) As Double
    Dim LB(0) As Double
    Dim Lab(0) As Double

    ' Create array of points that define lines to draw.
    Private FromPoints As New List(Of Point)
    Private ToPoints As New List(Of Point)
    Private MorphPoints As New List(Of Point)
    Private MorphInteger As New List(Of Integer)

    Private pictureBox1 As New PictureBox()

    ' Main Function 
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MorphStep = 1
        initialTotalStep = 100
        TotalStep = initialTotalStep
        LastTimeFrame_Txt.Text = CStr(TotalStep)
        halfTimeFrame_Txt.Text = CStr(TotalStep / 2)
        OnetoOne_RBtn.Checked = True
        Vertex_RBtn.Checked = True
        Auto_Start = False

        Txt_TimeFrame.Text = TotalStep

    End Sub
    'mathc method selected
    Private Sub SyncVertex()
        If OnetoOne_RBtn.Checked = True Then
            OnetoOne()
        Else
            NtoOne()
        End If
    End Sub
    'mroph methods selected
    Private Sub eliminateDup()
        Dim countFrom As Integer
        Dim countTo As Integer
        countFrom = 0
        countTo = 0

        Dim m As Integer
        Dim n As Integer
        m = n = 0
        For i = 0 To NumVertexFrom - 2
            If getfromAnlge(i) = getfromAnlge(i + 1) Then
                countFrom += 1
            Else
                ReDim CopyFromX(m)
                CopyFromX(m) = FromX(i)
                CopyFromY(m) = FromY(i)
            End If
        Next

        For i = 0 To NumVertexTo - 2
            If gettoAngle(i) = gettoAngle(i + 1) Then
                countTo += 1
            End If
        Next
    End Sub
    Private Sub MorphProgress(ByRef steps As Integer)
        If NtoOne_RBtn.Checked = True Or NtoOne_RBtn.Checked = False Then
            If Vertex_RBtn.Checked = True Then
                VertexMorphingProgress(steps)
            Else
                EdgeMorphingProgress(steps)
            End If
        End If
    End Sub

    ' From Button Function when Mouse Down (Click) event
    Private Sub From_Click(sender As Object, e As EventArgs) Handles FromBtn.Click

        Dim OpenFile As New OpenFileDialog
        OpenFile.FileName = ""
        OpenFile.Filter = "Text Files (*.txt)|*.txt"
        OpenFile.Title = "Please Select Initial Shape File"
        OpenFile.ShowDialog()

        Try
            Dim Read As New System.IO.StreamReader(OpenFile.FileName)
            Read.Close()
        Catch ex As Exception
        End Try

        FromPoints.Clear()

        Dim lines() As String = IO.File.ReadAllLines(OpenFile.FileName)
        fromFileName = OpenFile.FileName

        NumVertexFrom = Convert.ToInt32(lines(0))

        ReDim FromX(NumVertexFrom - 1)
        ReDim FromY(NumVertexFrom - 1)

        Setup(FromX, FromY, lines, FromPoints, NumVertexFrom)

        For i = 0 To NumVertexFrom - 1
            FromX(i) = 2 * Mid_X - FromX(i)
            FromY(i) = 2 * Mid_Y - FromY(i)
        Next
        If NumVertexFrom > 0 And NumVertexTo > 0 Then
            SyncVertex()
        End If
        Me.Refresh()
    End Sub

    ' To Button Function when Mouse Down (Click) event
    Private Sub To_Click(sender As Object, e As EventArgs) Handles ToBtn.Click
        Dim OpenFile As New OpenFileDialog
        OpenFile.FileName = ""
        OpenFile.Filter = "Text Files (*.txt)|*.txt"
        OpenFile.Title = "Open"
        OpenFile.ShowDialog()

        Try
            Dim Read As New System.IO.StreamReader(OpenFile.FileName)
            Read.Close()
        Catch ex As Exception
        End Try

        ToPoints.Clear()
        Dim lines() As String = IO.File.ReadAllLines(OpenFile.FileName)
        fromFileName = OpenFile.FileName

        NumVertexTo = Convert.ToInt32(lines(0))

        ReDim ToX(NumVertexTo - 1)
        ReDim ToY(NumVertexTo - 1)

        Setup(ToX, ToY, lines, ToPoints, NumVertexTo)

        For i = 0 To NumVertexTo - 1
            ToX(i) = 2 * Mid_X - ToX(i)
            ToY(i) = 2 * Mid_Y - ToY(i)
        Next

        If NumVertexFrom > 0 And NumVertexTo > 0 Then
            SyncVertex()
        End If
        Me.Refresh()
    End Sub

    ' Draw From Panel
    Private Sub Panel_From_Paint(sender As Object, e As PaintEventArgs) Handles Panel_From.Paint
        'Draw lines to screen.
        If NumVertexFrom > 0 Then
            ' Set world transform of graphics object to translate.
            e.Graphics.TranslateTransform(230.0F, 200.0F)
            ' Then to rotate, prepending rotation matrix.
            e.Graphics.RotateTransform(180.0F)
            e.Graphics.DrawLines(Pens.Blue, FromPoints.ToArray())

        End If
    End Sub

    ' Draw TO Panel
    Private Sub Panel_To_Paint(sender As Object, e As PaintEventArgs) Handles Panel_To.Paint
        'Draw lines to screen.
        If NumVertexTo > 0 Then
            ' Set world transform of graphics object to translate.
            e.Graphics.TranslateTransform(230.0F, 200.0F)
            ' Then to rotate, prepending rotation matrix.
            e.Graphics.RotateTransform(180.0F)
            e.Graphics.DrawLines(Pens.DarkGoldenrod, ToPoints.ToArray())
        End If
    End Sub

    ' Draw Morph Panel
    Private Sub Panel_Morph_Paint(sender As Object, e As PaintEventArgs) Handles Panel_Morph.Paint
        If NumVertexTo > 0 And NumVertexFrom > 0 Then
            e.Graphics.TranslateTransform(-75.0F, -20.0F)
            e.Graphics.DrawLines(Pens.Black, MorphPoints.ToArray())
            'e.Graphics.DrawLine(Pens.Red, New Point(MorphX(0), MorphY(0)), New Point(MorphX(1), MorphY(1)))
        End If

    End Sub

    ' Next Button Function when Mouse Down (Click) event
    Private Sub Next_Click(sender As Object, e As EventArgs) Handles Next_Btn.Click
        If MorphStep >= TotalStep - 1 Then
            MorphStep = TotalStep
            Timeline_Bar.Value = TotalStep
        Else
            MorphStep += 1
            Timeline_Bar.Value = MorphStep
        End If
        MorphProgress(MorphStep)

        Me.Refresh()
    End Sub

    Private Sub Previous_Click(sender As Object, e As EventArgs) Handles Prev_Btn.Click
        MorphStep -= 1 '(100 / TotalStep)
        If MorphStep <= 0 Then
            MorphStep = 0
            Timeline_Bar.Value = 0
        End If
        Timeline_Bar.Value = MorphStep
        MorphProgress(MorphStep)

        Me.Refresh()
    End Sub

    Private Sub AutoPlay_Click(sender As Object, e As EventArgs) Handles Autoplay_Btn.Click
        If Auto_Start = False Then
            MorphTimer.Start()
            Auto_Start = True
        Else
            MorphTimer.Stop()
            Auto_Start = False
        End If
    End Sub

    Private Sub MorphTimer_Tick(sender As Object, e As EventArgs) Handles MorphTimer.Tick
        If MorphStep = TotalStep Then
            MorphStep = 0
        End If
        MorphStep += (100 / TotalStep)
        'autodisplay stops at totalStep
        If MorphStep >= TotalStep Then
            MorphStep = TotalStep 'at the end of morphing  stay in the final status
            MorphTimer.Stop()
        End If
        Timeline_Bar.Value = MorphStep * 100 / TotalStep
        MorphProgress(MorphStep)

        Me.Refresh()
    End Sub

    Private Sub TimelineBar_Scroll(sender As Object, e As EventArgs) Handles Timeline_Bar.Scroll
        'Txt_TimeFrame.Text = Timeline_Bar.Value
        MorphStep = Timeline_Bar.Value
        MorphProgress(MorphStep)
        Me.Refresh()
    End Sub

    Private Sub Setup(ByRef CoordinateX() As Double, ByRef CoordinateY() As Double, ByVal lines() As String, ByRef Points As List(Of Point), ByVal NumVertexs As Integer)

        Dim i As Integer

        CoordinateX(0) = Convert.ToInt32(Trim(Microsoft.VisualBasic.Left(lines(i + 1), 3)))
        CoordinateY(0) = Convert.ToInt32(Trim(Microsoft.VisualBasic.Right(lines(i + 1), 3)))

        Max_X = CoordinateX(0)
        Min_X = CoordinateX(0)
        Max_Y = CoordinateY(0)
        Min_Y = CoordinateY(0)

        For i = 0 To NumVertexs - 1
            CoordinateX(i) = Convert.ToInt32(Trim(Microsoft.VisualBasic.Left(lines(i + 1), 3)))
            CoordinateY(i) = Convert.ToInt32(Trim(Microsoft.VisualBasic.Right(lines(i + 1), 3)))

            If CoordinateX(i) > Max_X Then
                Max_X = CoordinateX(i)
            End If
            If CoordinateX(i) < Min_X Then
                Min_X = CoordinateX(i)
            End If

            If CoordinateY(i) > Max_Y Then
                Max_Y = CoordinateY(i)
            End If
            If CoordinateY(i) < Min_Y Then
                Min_Y = CoordinateY(i)
            End If

            Points.Add(New Point(CoordinateX(i) / 3, CoordinateY(i) / 3))

        Next

        Mid_X = (Max_X + Min_X) / 2
        Mid_Y = (Max_Y + Min_Y) / 2

    End Sub

    Private Sub OnetoOne()
        'match total number of vertexes and create copyfrom array
        MorphPoints.Clear()

        If NumVertexFrom >= NumVertexTo Then
            numofVertex = NumVertexFrom
        Else
            numofVertex = NumVertexTo
        End If

        ReDim CopyFromX(numofVertex - 1)
        ReDim CopyFromY(numofVertex - 1)
        ReDim CopyToX(numofVertex - 1)
        ReDim CopyToY(numofVertex - 1)

        ReDim MorphX(numofVertex - 1)
        ReDim MorphY(numofVertex - 1)

        Dim Counter = 1
        Different = Math.Abs(NumVertexFrom - NumVertexTo)

        'if total number of from and to are equal
        If NumVertexFrom = NumVertexTo Then
            For i = 0 To numofVertex - 1
                CopyFromX(i) = FromX(i)
                CopyFromY(i) = FromY(i)
                CopyToX(i) = ToX(i)
                CopyToY(i) = ToY(i)
            Next
        ElseIf NumVertexFrom > NumVertexTo Then
            For i = 0 To numofVertex - 1
                CopyFromX(i) = FromX(i)
                CopyFromY(i) = FromY(i)
                If i <= NumVertexTo - 1 Then
                    CopyToX(i) = ToX(i)
                    CopyToY(i) = ToY(i)
                Else
                    CopyToX(i) = ToX(NumVertexTo - 1)
                    CopyToY(i) = ToY(NumVertexTo - 1)
                End If
            Next
        Else
            For i = 0 To numofVertex - 1
                CopyToX(i) = ToX(i)
                CopyToY(i) = ToY(i)
                If i <= NumVertexFrom - 1 Then
                    CopyFromX(i) = FromX(i)
                    CopyFromY(i) = FromY(i)
                Else
                    CopyFromX(i) = FromX(NumVertexFrom - 1)
                    CopyFromY(i) = FromY(NumVertexFrom - 1)
                End If
            Next
        End If

        If NumVertexFrom > NumVertexTo Then
            'find where to insert new value to 
            For i = 0 To numofVertex - 1
                If (Math.Floor(numofVertex / Different) - 1) * Counter + Counter - 1 = i And Counter < Different Then
                    ' copy value of previous 
                    For j = numofVertex - 2 To i + 1
                        CopyToX(j + 1) = CopyToX(j)
                        CopyToY(j + 1) = CopyToY(j)
                    Next
                    CopyToX(i + 1) = (CopyToX(i) + CopyToX(i + 2)) / 2
                    CopyToY(i + 1) = (CopyToY(i) + CopyToY(i + 2)) / 2
                    Counter += 1
                End If
            Next

        ElseIf NumVertexFrom < NumVertexTo Then 'if numVertex To bigger than from vertex
            For i = 0 To numofVertex - 1
                If (Math.Floor(numofVertex / Different) - 1) * Counter + Counter - 1 = i And Counter < Different Then
                    ' This may have issues on the last Index
                    For j = numofVertex - 2 To i + 1
                        CopyFromX(j + 1) = CopyFromX(j)
                        CopyFromY(j + 1) = CopyFromY(j)
                    Next
                    CopyFromX(i + 1) = (CopyFromX(i) + CopyFromX(i + 2)) / 2
                    CopyFromY(i + 1) = (CopyFromY(i) + CopyFromY(i + 2)) / 2
                    Counter += 1
                End If
            Next
        End If

        For i = 0 To numofVertex - 1
            MorphX(i) = CopyFromX(i)
            MorphY(i) = CopyFromY(i)
            MorphPoints.Add(New Point(CopyFromX(i), CopyFromY(i)))
        Next

    End Sub

    Private Sub NtoOne()
        MorphPoints.Clear()

        If NumVertexFrom >= NumVertexTo Then
            numofVertex = NumVertexFrom
        Else
            numofVertex = NumVertexTo
        End If

        ReDim CopyFromX(numofVertex - 1)
        ReDim CopyFromY(numofVertex - 1)
        ReDim CopyToX(numofVertex - 1)
        ReDim CopyToY(numofVertex - 1)

        ReDim MorphX(numofVertex - 1)
        ReDim MorphY(numofVertex - 1)

        Dim Counter = 1
        Different = Math.Abs(NumVertexFrom - NumVertexTo)

        For i = 0 To numofVertex - 1
            'if total number of from and to are equal
            If NumVertexFrom = NumVertexTo Then
                CopyFromX(i) = FromX(i)
                CopyFromY(i) = FromY(i)
                CopyToX(i) = ToX(i)
                CopyToY(i) = ToY(i)
                MorphPoints.Add(New Point(FromX(i), FromY(i)))
            Else
                'if num from bigger
                If NumVertexFrom > NumVertexTo Then
                    CopyFromX(i) = FromX(i)
                    CopyFromY(i) = FromY(i)
                    'assign values to morphX and morphY
                    If i <= NumVertexTo - 1 Then
                        MorphX(i) = ToX(i)
                        MorphY(i) = ToY(i)
                    Else
                        MorphX(i) = ToX(NumVertexTo - 1)
                        MorphY(i) = ToY(NumVertexTo - 1)
                    End If
                    'find where to insert new value to 
                    If (Math.Floor(numofVertex / Different) - 1) * Counter + Counter - 1 = i And Counter < Different Then
                        ' copy value of previous 
                        For j = numofVertex - 2 To i + 1
                            MorphX(j + 1) = MorphX(j)
                            MorphY(j + 1) = MorphY(j)
                        Next
                        MorphX(i + 1) = MorphX(i)
                        MorphY(i + 1) = MorphY(i)
                        Counter += 1
                    End If

                    'destination need to add vertexes
                    CopyToX(i) = MorphX(i)
                    CopyToY(i) = MorphY(i)
                    MorphPoints.Add(New Point(FromX(i), FromY(i)))
                Else
                    CopyToX(i) = ToX(i)
                    CopyToY(i) = ToY(i)
                    If i <= NumVertexFrom - 1 Then
                        MorphX(i) = FromX(i)
                        MorphY(i) = FromY(i)
                    Else
                        MorphX(i) = FromX(NumVertexFrom - 1)
                        MorphY(i) = FromY(NumVertexFrom - 1)
                    End If
                    If (Math.Floor(numofVertex / Different) - 1) * Counter + Counter - 1 = i And Counter < Different Then
                        ' This may have issues on the last Index
                        For j = numofVertex - 2 To i + 1
                            MorphX(j + 1) = MorphX(j)
                            MorphY(j + 1) = MorphX(j)
                        Next
                        MorphX(i + 1) = MorphX(i)
                        MorphY(i + 1) = MorphY(i)
                        Counter += 1
                    End If
                    CopyFromX(i) = MorphX(i)
                    CopyFromY(i) = MorphY(i)
                    MorphPoints.Add(New Point(MorphX(i), MorphY(i)))
                End If
            End If
            MorphX(i) = CopyFromX(i)
            MorphY(i) = CopyFromY(i)
        Next

    End Sub
    Private Sub VertexMorphingProgress(ByRef steps As Integer)
        'takes morph step as parameter
        MorphPoints.Clear()
        Dim t As Double = steps / TotalStep

        For i = 0 To numofVertex - 1
            MorphX(i) = CopyFromX(i) * (1 - t) + CopyToX(i) * t
            MorphY(i) = CopyFromY(i) * (1 - t) + CopyToY(i) * t
        Next

        ' Write to Morph Corrdinate
        For i = 0 To NumVertexTo - 1
            MorphPoints.Add(New Point(MorphX(i), MorphY(i)))
        Next
    End Sub
    Private Function getleastAngleDiff(ByRef angle1 As Double, ByRef angle2 As Double) As Double
        Dim output_angle1 As Double
        Dim output_angle2 As Double
        regulateAngle(angle1)
        regulateAngle(angle2)

        output_angle1 = angle2 - angle1

        'output2 is output 1 within 
        If (output_angle1 >= 0) Then 'angle2 bigger-> output2 = 1 - 2pi  
            output_angle2 = output_angle1 - Math.PI * 2
        Else
            output_angle2 = output_angle1 + Math.PI * 2
        End If

        If (Math.Abs(output_angle1) >= Math.Abs(output_angle2)) Then
            Return output_angle2
        Else
            Return output_angle1
        End If
    End Function

    'to regulate an angle in -2pi to 2pi tobe -pi to pi
    'Its very important to ensure fromChange and toChange to be within this range
    Private Sub regulateAngle2(ByRef angle As Double)
        If angle > Math.PI Then
            angle = angle - 2 * Math.PI
        ElseIf angle <= (-1) * Math.PI Then
            angle = angle + 2 * PI
        End If
    End Sub
    'to regulate angle to be within 0 to 2pi
    Private Sub regulateAngle(ByRef angle As Double)
        If angle < 0 Then
            angle = angle + 2 * Math.PI
        End If
        If angle > 2 * Math.PI Then
            angle = angle - 2 * Math.PI
        End If

    End Sub

    'to return the angle between positive x axis and the line made of current vertex with previous vertex
    Public Function getfromAnlge(ByVal i As Integer) As Double
        Dim x1 As Double
        Dim y1 As Double
        Dim angle As Double
        x1 = CopyFromX(i + 1) - CopyFromX(i)
        y1 = CopyFromY(i + 1) - CopyFromY(i)

        angle = Math.Atan2(y1, x1)
        'regulateAngle(angle)
        Return angle
    End Function
    Public Function gettoAngle(ByVal i As Integer) As Double
        Dim x1 As Double
        Dim y1 As Double
        Dim angle As Double

        x1 = CopyToX(i + 1) - CopyToX(i)
        y1 = CopyToY(i + 1) - CopyToY(i)

        angle = Math.Atan2(y1, x1)
        'regulateAngle(angle)
        Return angle
    End Function

    Private Sub EdgeMorphingProgress(ByRef steps As Integer)
        MorphPoints.Clear()
        Dim t As Double = steps / TotalStep
        Dim m As Integer = numofVertex - 2

        Dim alpha(numofVertex - 1) As Double
        Dim alphaA(numofVertex - 1) As Double
        Dim alphaB(numofVertex - 1) As Double

        Dim thetaA(numofVertex - 1) As Double
        Dim thetaB(numofVertex - 1) As Double
        Dim theta(numofVertex - 1) As Double

        Dim s(numofVertex - 1) As Double
        ReDim LA(numofVertex - 1)
        ReDim LB(numofVertex - 1)
        Dim MorphL(numofVertex - 1) As Double
        Dim newLength1(numofVertex - 1) As Double ' this is (1-t)La + tLB before edge tweakling

        Dim fromX1 As Double
        Dim fromY1 As Double
        Dim ToX1 As Double
        Dim ToY1 As Double

        'initialize all alpha and morphx and morphy
        For i = 0 To m
            fromX1 = CopyFromX(i + 1) - CopyFromX(i)
            fromY1 = CopyFromY(i + 1) - CopyFromY(i)
            ToX1 = CopyToX(i + 1) - CopyToX(i)
            ToY1 = CopyToY(i + 1) - CopyToY(i)
            LA(i) = Math.Sqrt(fromX1 * fromX1 + fromY1 * fromY1)
            LB(i) = Math.Sqrt(ToX1 * ToX1 + ToY1 * ToY1)
            'below computes new Length before tweakling
            newLength1(i) = LA(i) * (1 - t) + LB(i) * t

            alphaA(i) = Math.Atan2(fromY1, fromX1)
            alphaB(i) = Math.Atan2(ToY1, ToX1)
        Next

        ' end of initialization B-A
        alpha(0) = alphaA(0) + getleastanglediff(alphaA(0), alphaB(0)) * steps / TotalStep
        'below computes new angle changes
        'alpha(0) = alphaA(0) * (1 - t) + alphaB(0) * t
        For i = 1 To m
            thetaA(i) = alphaA(i) - alphaA(i - 1)
            thetaB(i) = alphaB(i) - alphaB(i - 1)

            While thetaA(i) > Math.PI Or thetaA(i) <= -Math.PI
                regulateAngle2(thetaA(i))
            End While
            While thetaB(i) > Math.PI Or thetaB(i) < -Math.PI
                regulateAngle2(thetaB(i))
            End While

            'theta value is in between -pi to pi
            theta(i) = thetaA(i) * (1 - t) + thetaB(i) * t
            alpha(i) = alpha(i - 1) + theta(i)
            regulateAngle(alpha(i)) 'alpha is for get its sin and cos, no need to regulate
        Next

        'compute LAB as global variable
        ReDim Lab(numofVertex - 1)
        Dim edge_difference As Double
        Dim Ltol As Double = ComputeLtol()

        For i = 0 To numofVertex - 1
            edge_difference = Math.Abs(LA(i) - LB(i))
            If edge_difference >= Ltol Then
                Lab(i) = edge_difference
            Else
                Lab(i) = Ltol
            End If
        Next

        'calculate for morphx and morph y for last vertex first  which is the same postition as i =0
        For i = 0 To numofVertex - 1

            'use edge tweakling to close the shape
            Dim e As Double = ComputeE(alpha)
            Dim f As Double = ComputeF(alpha)
            Dim g As Double = ComputeG(alpha)
            Dim u As Double = ComputeU(newLength1, alpha)
            Dim v As Double = ComputeV(newLength1, alpha)
            Dim lambda_1 As Double = Computelambda1(e, f, g, u, v)
            Dim lambda_2 As Double = Computelambda2(e, f, g, u, v)

            'regulateAngle(alpha(i))
            s(i) = -0.5 * Lab(i) * Lab(i) * (lambda_1 * Math.Cos(alpha(i)) + lambda_2 * Math.Sin(alpha(i)))
            'end of normalization in edge tweakling
            MorphL(i) = newLength1(i) + s(i)
            If i = 0 Or i = numofVertex - 1 Then
                MorphX(i) = CopyFromX(i) * (1 - t) + CopyToX(i) * t
                MorphY(i) = CopyFromY(i) * (1 - t) + CopyToY(i) * t
            Else
                MorphX(i) = MorphX(i - 1) + MorphL(i - 1) * Math.Cos(alpha(i - 1))
                MorphY(i) = MorphY(i - 1) + MorphL(i - 1) * Math.Sin(alpha(i - 1))
            End If
        Next

        ' Write to Morph Coordinate
        For i = 0 To NumVertexTo - 1
            MorphPoints.Add(New Point(MorphX(i), MorphY(i)))
        Next

    End Sub
    Private Function ComputeLtol() As Double
        Dim i As Integer = 0
        Dim edge_difference As Double '= 0.0F
        Dim max_edge_difference As Double '= 0.0F

        For i = 0 To numofVertex - 1
            edge_difference = Math.Abs(LA(i) - LB(i))
            If (edge_difference > max_edge_difference) Then
                max_edge_difference = edge_difference
            End If
        Next
        Return 0.0001 * max_edge_difference
    End Function

    Private Function ComputeE(ByRef alpha) As Double
        Dim e As Double = 0.0F
        For i = 0 To numofVertex - 1
            e += Lab(i) * Lab(i) * Math.Cos(alpha(i)) * Math.Cos(alpha(i))
            'e = lab^2 + cos(alpha)^2
        Next
        Return e
    End Function

    Private Function ComputeF(ByRef alpha) As Double
        Dim f As Double = 0
        For i = 0 To numofVertex - 1
            f += Lab(i) * Lab(i) * Math.Sin(alpha(i)) * Math.Cos(alpha(i))
        Next
        Return f
    End Function

    Private Function ComputeG(ByRef alpha) As Double
        Dim g As Double = 0
        For i = 0 To numofVertex - 1
            g += Lab(i) * Lab(i) * Math.Sin(alpha(i)) * Math.Sin(alpha(i))
        Next
        Return g
    End Function

    Private Function ComputeU(ByRef length, ByRef alpha) As Double
        Dim u As Double = 0
        For i = 0 To numofVertex - 1
            u += length(i) * Math.Cos(alpha(i))
        Next
        u *= 2
        Return u
    End Function

    Private Function ComputeV(ByRef length, ByRef alpha) As Double
        Dim v As Double = 0.0F

        For i = 0 To numofVertex - 1
            v += length(i) * Math.Sin(alpha(i))
        Next
        v *= 2
        Return v
    End Function

    Private Function ComputeDeterminant(ByRef a, ByRef b, ByRef c, ByRef d) As Double
        Return a * d - b * c
    End Function

    Private Function Computelambda1(ByRef e, ByRef f, ByRef g, ByRef u, ByRef v) As Double
        Dim lambda_1 As Double = 0.0
        Dim det_1 As Double = 0.0F
        Dim det_2 As Double = 0.0F
        If e * g - f <> 0 Then
            det_1 = ComputeDeterminant(u, f, v, g)
            det_2 = ComputeDeterminant(e, f, f, g)
            lambda_1 = det_1 / det_2
        Else
            lambda_1 = 0
        End If
        Return lambda_1
    End Function

    Private Function Computelambda2(ByRef e, ByRef f, ByRef g, ByRef u, ByRef v) As Double
        Dim lambda_2 As Double = 0.0F
        Dim det_1 As Double = 0.0F
        Dim det_2 As Double = 0.0F

        If e * g - f <> 0 Then
            det_1 = ComputeDeterminant(e, u, f, v)
            det_2 = ComputeDeterminant(e, f, f, g)
            lambda_2 = det_1 / det_2
        Else
            lambda_2 = 0
        End If
        Return lambda_2
    End Function

    Private Sub Txt_TimeFrame_TextChanged(sender As Object, e As EventArgs) Handles Txt_TimeFrame.TextChanged
        Try
            ' Convert the text to a Double and determine if it is a negative number.
            If Double.Parse(Txt_TimeFrame.Text) < 0 Then
                ' If the number is negative  display it in Red.
                Txt_TimeFrame.ForeColor = Color.Red
            Else
                ' If the number is not negative  display it in Black.
                Txt_TimeFrame.ForeColor = Color.Black
                TotalStep = CInt(Txt_TimeFrame.Text)
                'below changes the displayed numbers on axis
                LastTimeFrame_Txt.Text = CStr(TotalStep)
                halfTimeFrame_Txt.Text = CStr(TotalStep / 2)
                'Timeline_Bar.Value = Timeline_Bar.Value / initialTotalStep * TotalStep
            End If
        Catch
            ' If there is an error  display the text using the system colors.
            Txt_TimeFrame.ForeColor = SystemColors.ControlText
        End Try

    End Sub

    Private Sub InfoInitial_Click(sender As Object, e As EventArgs) Handles InfoInitial.Click
        Dim F As New infoForm
        F.Size = New Size(175, 150)
        F.Location = New Point(100 + 138, 30 + 232)
        F.Text = "Initial Information"
        F.StringPass = "Name: Horse" & vbCrLf & "File: Horse.txt" & vbCrLf & "Vertex Number: " & NumVertexFrom & vbCrLf & "Initial Coordinates: " & FromX(0) & "  " & FromY(0)
        F.Show()
    End Sub

    Private Sub InfoTerminal_Click(sender As Object, e As EventArgs) Handles InfoTerminal.Click
        Dim F As New infoForm
        F.Size = New Size(175, 150)
        F.Location = New Point(100 + 138, 250 + 232)
        F.Text = "Initial Information"
        F.StringPass = "Name: Lion" & vbCrLf & "File: Lion.txt " & vbCrLf & "Vertex Number: " & NumVertexTo & vbCrLf & "Initial Coordinates: " & ToX(0) & "  " & ToY(0)
        F.Show()
    End Sub

    Public Sub CreateBitmapAtRuntime()
        pictureBox1.Size = New Size(210, 110)
        Me.Controls.Add(pictureBox1)
        Dim newImage As New Bitmap(200, 100)
        Dim imageGraphics As Graphics = Graphics.FromImage(newImage)
        imageGraphics.FillRectangle(Brushes.White, 0, 0, 200, 100)
        imageGraphics.DrawLines(Pens.Black, FromPoints.ToArray())
        pictureBox1.Image = newImage
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CreateBitmapAtRuntime()
        pictureBox1.Image.Save("C:\Users\Xiaohan Wang\Desktop\2D Morph.gif")
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class
