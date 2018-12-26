Imports System.Math
Public Class Form1
    Dim _
    NumShotsFix,
    NumShotsFlex,
    NumShotsEyeDie,
    AvShots,
    NumIt,
    BF,
    S,
    T,
    NumRerollH,
    NumRerollW,
    RerollEyeH,
    RerollEyeW,
    Mortal,
    AvHits,
    AvPreWounds,
    AvWounds,
    MWounds,
    AvModels As Integer
    Dim aHitMod(4), aWMod(4) As Integer

    Public Sub New()
        Randomize()
        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Private Sub ButCalc_Click(sender As Object, e As EventArgs) Handles ButCalc.Click
        Dim i, ItShots As Integer
        'Determine number of hits-------------------------------------------------------------------------------------------------------------------------------------------
        NumIt = CInt(TBNumIt.Text)
        AvHits = 0
        AvShots = 0
        MWounds = 0
        AvPreWounds = 0
        For i = 1 To NumIt
            CalcPreWounds(CalcHits(CalcShots))
        Next
        AvHits = CInt(AvHits / (i - 1))
        AvShots = CInt(AvShots / (i - 1))
        AvPreWounds = CInt(AvPreWounds / (i - 1))
        LabResult.Text = CStr(AvShots)
        LabAvHits.Text = CStr(AvHits)
        LabprelWounds.Text = CStr(AvPreWounds)
    End Sub

    Private Function CalcShots()
        Dim j, NumShots As Integer
        Dim RanditNum As Integer
        NumShotsFix = CInt(TBNumShotsFix.Text)
        NumShotsFlex = CInt(TBNumShotsFlex.Text)
        NumShotsEyeDie = CInt(TBEyeDie.Text)
        RanditNum = 0
        For j = 1 To NumShotsFlex
            RanditNum += Roll(NumShotsEyeDie)
            'Debug.Print(RanditNum)
        Next
        AvShots += (NumShotsFix + RanditNum)
        Return (NumShotsFix + RanditNum)
    End Function

    Private Function CalcHits(ByVal Shots As Integer)
        Dim tmp, Hits As Integer
        NumRerollH = CInt(TBNumRerollTot.Text)
        RerollEyeH = CInt(TBNumRerollEye.Text)
        If RerollEyeH <> 0 Then
            NumRerollH = Shots
        End If
        While Shots > 0
            tmp = CalcHit(RerollEyeH)
            If tmp = 1 Then
                Hits += 1
            ElseIf tmp = -1 Or tmp = 0 And NumRerollH > 0 Then
                tmp = CalcHit(RerollEyeH)
                If tmp = 0 Then
                    NumRerollH -= 1
                ElseIf tmp = 1 Then
                    Hits += 1
                End If
            End If
            Shots -= 1
        End While
        AvHits = AvHits + Hits
        Return Hits
    End Function

    Private Function CalcHit(Reroll As Integer) As Integer
        Dim tRoll As Integer
        BF = CInt(TBBF.Text)
        aHitMod(1) = -CInt(TBMod1.Text)
        aHitMod(2) = -CInt(TBMod2.Text)
        aHitMod(3) = -CInt(TBMod3.Text)
        aHitMod(4) = -CInt(TBMod4.Text)
        tRoll = Roll(6)
        If tRoll >= (BF + aHitMod.Sum) Then
            Return 1
        ElseIf (tRoll = Reroll) And (Reroll <> 0) Then
            Return -1
        Else
            Return 0
        End If

    End Function

    Private Function CalcPreWounds(Hits As Integer)
        Dim tmp, PrelWounds As Integer
        NumRerollW = CInt(TBWReroll.Text)
        RerollEyeW = CInt(TBWRerollEye.Text)
        Mortal = CInt(TBMortal.Text)

        If RerollEyeW <> 0 Then
            NumRerollW = Hits
        End If
        While Hits > 0
            tmp = CalcPreWound(RerollEyeW, Mortal)
            If tmp = 1 Then
                PrelWounds += 1
            ElseIf tmp = -1 Then
                MWounds += 1
                PrelWounds += 1
            ElseIf tmp = 0 And NumRerollW > 0 Then
                tmp = CalcPreWound(RerollEyeW, Mortal)
                If tmp = 0 Then
                    NumRerollH -= 1
                ElseIf tmp = 1 Then
                    PrelWounds += 1
                ElseIf tmp = -1 Then
                    MWounds += 1
                    PrelWounds += 1
                End If
            End If
            Hits -= 1
        End While
        AvPreWounds += PrelWounds
        Return PrelWounds
    End Function

    Private Function CalcPreWound(Reroll As Integer, Mortal As Integer)
        Dim tRoll, th As Integer
        S = CInt(TBStrength.Text)
        T = CInt(TBTough.Text)
        aWMod(1) = -CInt(TBWMod1.Text)
        aWMod(2) = -CInt(TBWMod2.Text)
        aWMod(3) = -CInt(TBWMod3.Text)
        aWMod(4) = -CInt(TBWMod4.Text)

        If S = T Then
            th = 4
        ElseIf S < T Then
            If 2 * S <= T Then
                th = 6
            Else
                th = 5
            End If
        ElseIf S > T Then
            If S >= 2 * T Then
                th = 2
            Else
                th = 3
            End If
        End If

        tRoll = Roll(6)

        If tRoll = Mortal Then
            Return -1
        ElseIf tRoll >= (th + aWMod.Sum) Then
            Return 1
        ElseIf (tRoll = Reroll) And (Reroll <> 0) Then
            Return 0
        Else
            Return 0
        End If
    End Function

    Private Sub TBMod1_LClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TBMod1.MouseDown
        TBIncDec(e, TBMod1, 1)
    End Sub
    Private Sub TBMod2_LClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TBMod2.MouseDown
        TBIncDec(e, TBMod2, 2)
    End Sub
    Private Sub TBMod3_LClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TBMod3.MouseDown
        TBIncDec(e, TBMod3, 3)
    End Sub
    Private Sub TBMod4_LClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TBMod4.MouseDown
        TBIncDec(e, TBMod4, 4)
    End Sub
    Private Sub TBWMod1_LClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TBWMod1.MouseDown
        TBIncDec(e, TBWMod1, 1)
    End Sub
    Private Sub TBWMod2_LClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TBWMod2.MouseDown
        TBIncDec(e, TBWMod2, 1)
    End Sub
    Private Sub TBWMod3_LClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TBWMod3.MouseDown
        TBIncDec(e, TBWMod3, 1)
    End Sub
    Private Sub TBWMod4_LClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles TBWMod4.MouseDown
        TBIncDec(e, TBWMod4, 1)
    End Sub

    Private Function TBIncDec(buttonEv As System.Windows.Forms.MouseEventArgs, TB As TextBox, pos As Integer)
        If buttonEv.Button = MouseButtons.Left Then
            aHitMod(pos) = CInt(TB.Text)
            aHitMod(pos) += 1
            TB.Text = CStr(aHitMod(pos))
        ElseIf buttonEv.Button = MouseButtons.Middle Then
            aHitMod(pos) = CInt(TB.Text)
            aHitMod(pos) -= 1
            TB.Text = CStr(aHitMod(pos))
        End If
    End Function

    Private Function Roll(Eyes As Int32) As Int32
        Static staticRandomGenerator As New System.Random
        If Eyes < Int32.MaxValue Then Return staticRandomGenerator.Next(1, Eyes + 1)
        ' now max = Int32.MaxValue, so we need to work around Microsoft's quirk of an exclusive max parameter.
        If 1 > Int32.MinValue Then Return staticRandomGenerator.Next(1 - 1, Eyes) + 1 ' okay, this was the easy one.
        ' now min and max give full range of integer, but Random.Next() does not give us an option for the full range of integer.
        ' so we need to use Random.NextBytes() to give us 4 random bytes, then convert that to our random int.
        Dim bytes(3) As Byte ' 4 bytes, 0 to 3
        staticRandomGenerator.NextBytes(bytes) ' 4 random bytes
        Return BitConverter.ToInt32(bytes, 0) ' return bytes converted to a random Int32
    End Function
End Class
