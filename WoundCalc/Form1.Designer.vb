<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButCalc = New System.Windows.Forms.Button()
        Me.LabNumShotsfix = New System.Windows.Forms.Label()
        Me.TBNumShotsFix = New System.Windows.Forms.TextBox()
        Me.TBNumShotsFlex = New System.Windows.Forms.TextBox()
        Me.LabNumShotsFlex = New System.Windows.Forms.Label()
        Me.Sign1 = New System.Windows.Forms.Label()
        Me.TBEyeDie = New System.Windows.Forms.TextBox()
        Me.LabEyeDie = New System.Windows.Forms.Label()
        Me.LabResult = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButReset = New System.Windows.Forms.Button()
        Me.TBNumIt = New System.Windows.Forms.TextBox()
        Me.LabNumIt = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LabAvHits = New System.Windows.Forms.Label()
        Me.TBMod1 = New System.Windows.Forms.TextBox()
        Me.LabMod1 = New System.Windows.Forms.Label()
        Me.TBBF = New System.Windows.Forms.TextBox()
        Me.LabBF = New System.Windows.Forms.Label()
        Me.TBMod2 = New System.Windows.Forms.TextBox()
        Me.LabMod2 = New System.Windows.Forms.Label()
        Me.TBMod3 = New System.Windows.Forms.TextBox()
        Me.LabMod3 = New System.Windows.Forms.Label()
        Me.TBMod4 = New System.Windows.Forms.TextBox()
        Me.LabMod4 = New System.Windows.Forms.Label()
        Me.TBNumRerollEye = New System.Windows.Forms.TextBox()
        Me.LabNumRerollEye = New System.Windows.Forms.Label()
        Me.TBNumRerollTot = New System.Windows.Forms.TextBox()
        Me.LabNumRerollTot = New System.Windows.Forms.Label()
        Me.TBWRerollEye = New System.Windows.Forms.TextBox()
        Me.NumWRerollEye = New System.Windows.Forms.Label()
        Me.TBWReroll = New System.Windows.Forms.TextBox()
        Me.NumWReroll = New System.Windows.Forms.Label()
        Me.TBWMod4 = New System.Windows.Forms.TextBox()
        Me.LabSMod4 = New System.Windows.Forms.Label()
        Me.TBWMod3 = New System.Windows.Forms.TextBox()
        Me.LabSMod3 = New System.Windows.Forms.Label()
        Me.TBWMod2 = New System.Windows.Forms.TextBox()
        Me.LabSMod2 = New System.Windows.Forms.Label()
        Me.LabWound = New System.Windows.Forms.Label()
        Me.LabprelWounds = New System.Windows.Forms.Label()
        Me.TBWMod1 = New System.Windows.Forms.TextBox()
        Me.LabSMod1 = New System.Windows.Forms.Label()
        Me.TBStrength = New System.Windows.Forms.TextBox()
        Me.LabS = New System.Windows.Forms.Label()
        Me.TBTough = New System.Windows.Forms.TextBox()
        Me.LabT = New System.Windows.Forms.Label()
        Me.TBMortal = New System.Windows.Forms.TextBox()
        Me.LabMortal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButCalc
        '
        Me.ButCalc.Location = New System.Drawing.Point(705, 509)
        Me.ButCalc.Name = "ButCalc"
        Me.ButCalc.Size = New System.Drawing.Size(75, 23)
        Me.ButCalc.TabIndex = 0
        Me.ButCalc.Text = "Berechnen"
        Me.ButCalc.UseVisualStyleBackColor = True
        '
        'LabNumShotsfix
        '
        Me.LabNumShotsfix.AutoSize = True
        Me.LabNumShotsfix.Location = New System.Drawing.Point(200, 29)
        Me.LabNumShotsfix.Name = "LabNumShotsfix"
        Me.LabNumShotsfix.Size = New System.Drawing.Size(24, 13)
        Me.LabNumShotsfix.TabIndex = 1
        Me.LabNumShotsfix.Text = "fest"
        '
        'TBNumShotsFix
        '
        Me.TBNumShotsFix.Location = New System.Drawing.Point(203, 45)
        Me.TBNumShotsFix.Name = "TBNumShotsFix"
        Me.TBNumShotsFix.Size = New System.Drawing.Size(100, 20)
        Me.TBNumShotsFix.TabIndex = 2
        Me.TBNumShotsFix.Text = "0"
        '
        'TBNumShotsFlex
        '
        Me.TBNumShotsFlex.Location = New System.Drawing.Point(376, 45)
        Me.TBNumShotsFlex.Name = "TBNumShotsFlex"
        Me.TBNumShotsFlex.Size = New System.Drawing.Size(100, 20)
        Me.TBNumShotsFlex.TabIndex = 4
        Me.TBNumShotsFlex.Text = "0"
        '
        'LabNumShotsFlex
        '
        Me.LabNumShotsFlex.AutoSize = True
        Me.LabNumShotsFlex.Location = New System.Drawing.Point(373, 29)
        Me.LabNumShotsFlex.Name = "LabNumShotsFlex"
        Me.LabNumShotsFlex.Size = New System.Drawing.Size(41, 13)
        Me.LabNumShotsFlex.TabIndex = 3
        Me.LabNumShotsFlex.Text = "Zufällig"
        '
        'Sign1
        '
        Me.Sign1.AutoSize = True
        Me.Sign1.Location = New System.Drawing.Point(324, 48)
        Me.Sign1.Name = "Sign1"
        Me.Sign1.Size = New System.Drawing.Size(13, 13)
        Me.Sign1.TabIndex = 5
        Me.Sign1.Text = "+"
        '
        'TBEyeDie
        '
        Me.TBEyeDie.Location = New System.Drawing.Point(482, 45)
        Me.TBEyeDie.Name = "TBEyeDie"
        Me.TBEyeDie.Size = New System.Drawing.Size(100, 20)
        Me.TBEyeDie.TabIndex = 7
        Me.TBEyeDie.Text = "0"
        '
        'LabEyeDie
        '
        Me.LabEyeDie.AutoSize = True
        Me.LabEyeDie.Location = New System.Drawing.Point(479, 29)
        Me.LabEyeDie.Name = "LabEyeDie"
        Me.LabEyeDie.Size = New System.Drawing.Size(57, 13)
        Me.LabEyeDie.TabIndex = 6
        Me.LabEyeDie.Text = "Augenzahl"
        '
        'LabResult
        '
        Me.LabResult.AutoSize = True
        Me.LabResult.Location = New System.Drawing.Point(673, 48)
        Me.LabResult.Name = "LabResult"
        Me.LabResult.Size = New System.Drawing.Size(0, 13)
        Me.LabResult.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(673, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Durchschnittliche Schusszahl"
        '
        'ButReset
        '
        Me.ButReset.Location = New System.Drawing.Point(798, 509)
        Me.ButReset.Name = "ButReset"
        Me.ButReset.Size = New System.Drawing.Size(75, 23)
        Me.ButReset.TabIndex = 10
        Me.ButReset.Text = "Reset"
        Me.ButReset.UseVisualStyleBackColor = True
        '
        'TBNumIt
        '
        Me.TBNumIt.Location = New System.Drawing.Point(511, 512)
        Me.TBNumIt.Name = "TBNumIt"
        Me.TBNumIt.Size = New System.Drawing.Size(100, 20)
        Me.TBNumIt.TabIndex = 12
        Me.TBNumIt.Text = "1000"
        '
        'LabNumIt
        '
        Me.LabNumIt.AutoSize = True
        Me.LabNumIt.Location = New System.Drawing.Point(508, 496)
        Me.LabNumIt.Name = "LabNumIt"
        Me.LabNumIt.Size = New System.Drawing.Size(92, 13)
        Me.LabNumIt.TabIndex = 11
        Me.LabNumIt.Text = "Anzahl Iterationen"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(673, 166)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(123, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Durchschnittliche Treffer"
        '
        'LabAvHits
        '
        Me.LabAvHits.AutoSize = True
        Me.LabAvHits.Location = New System.Drawing.Point(673, 138)
        Me.LabAvHits.Name = "LabAvHits"
        Me.LabAvHits.Size = New System.Drawing.Size(0, 13)
        Me.LabAvHits.TabIndex = 20
        '
        'TBMod1
        '
        Me.TBMod1.Location = New System.Drawing.Point(376, 135)
        Me.TBMod1.Name = "TBMod1"
        Me.TBMod1.Size = New System.Drawing.Size(34, 20)
        Me.TBMod1.TabIndex = 16
        Me.TBMod1.Text = "0"
        '
        'LabMod1
        '
        Me.LabMod1.AutoSize = True
        Me.LabMod1.Location = New System.Drawing.Point(373, 119)
        Me.LabMod1.Name = "LabMod1"
        Me.LabMod1.Size = New System.Drawing.Size(37, 13)
        Me.LabMod1.TabIndex = 15
        Me.LabMod1.Text = "Mod 1"
        '
        'TBBF
        '
        Me.TBBF.Location = New System.Drawing.Point(203, 135)
        Me.TBBF.Name = "TBBF"
        Me.TBBF.Size = New System.Drawing.Size(30, 20)
        Me.TBBF.TabIndex = 14
        Me.TBBF.Text = "0"
        '
        'LabBF
        '
        Me.LabBF.AutoSize = True
        Me.LabBF.Location = New System.Drawing.Point(200, 119)
        Me.LabBF.Name = "LabBF"
        Me.LabBF.Size = New System.Drawing.Size(20, 13)
        Me.LabBF.TabIndex = 13
        Me.LabBF.Text = "BF"
        '
        'TBMod2
        '
        Me.TBMod2.Location = New System.Drawing.Point(416, 135)
        Me.TBMod2.Name = "TBMod2"
        Me.TBMod2.Size = New System.Drawing.Size(34, 20)
        Me.TBMod2.TabIndex = 23
        Me.TBMod2.Text = "0"
        '
        'LabMod2
        '
        Me.LabMod2.AutoSize = True
        Me.LabMod2.Location = New System.Drawing.Point(413, 119)
        Me.LabMod2.Name = "LabMod2"
        Me.LabMod2.Size = New System.Drawing.Size(37, 13)
        Me.LabMod2.TabIndex = 22
        Me.LabMod2.Text = "Mod 2"
        '
        'TBMod3
        '
        Me.TBMod3.Location = New System.Drawing.Point(456, 135)
        Me.TBMod3.Name = "TBMod3"
        Me.TBMod3.Size = New System.Drawing.Size(34, 20)
        Me.TBMod3.TabIndex = 25
        Me.TBMod3.Text = "0"
        '
        'LabMod3
        '
        Me.LabMod3.AutoSize = True
        Me.LabMod3.Location = New System.Drawing.Point(453, 119)
        Me.LabMod3.Name = "LabMod3"
        Me.LabMod3.Size = New System.Drawing.Size(37, 13)
        Me.LabMod3.TabIndex = 24
        Me.LabMod3.Text = "Mod 3"
        '
        'TBMod4
        '
        Me.TBMod4.Location = New System.Drawing.Point(496, 135)
        Me.TBMod4.Name = "TBMod4"
        Me.TBMod4.Size = New System.Drawing.Size(34, 20)
        Me.TBMod4.TabIndex = 27
        Me.TBMod4.Text = "0"
        '
        'LabMod4
        '
        Me.LabMod4.AutoSize = True
        Me.LabMod4.Location = New System.Drawing.Point(493, 119)
        Me.LabMod4.Name = "LabMod4"
        Me.LabMod4.Size = New System.Drawing.Size(37, 13)
        Me.LabMod4.TabIndex = 26
        Me.LabMod4.Text = "Mod 4"
        '
        'TBNumRerollEye
        '
        Me.TBNumRerollEye.Location = New System.Drawing.Point(482, 192)
        Me.TBNumRerollEye.Name = "TBNumRerollEye"
        Me.TBNumRerollEye.Size = New System.Drawing.Size(100, 20)
        Me.TBNumRerollEye.TabIndex = 31
        Me.TBNumRerollEye.Text = "0"
        '
        'LabNumRerollEye
        '
        Me.LabNumRerollEye.AutoSize = True
        Me.LabNumRerollEye.Location = New System.Drawing.Point(479, 176)
        Me.LabNumRerollEye.Name = "LabNumRerollEye"
        Me.LabNumRerollEye.Size = New System.Drawing.Size(142, 13)
        Me.LabNumRerollEye.TabIndex = 30
        Me.LabNumRerollEye.Text = "Augenzahl zum Wiederholen"
        '
        'TBNumRerollTot
        '
        Me.TBNumRerollTot.Location = New System.Drawing.Point(376, 192)
        Me.TBNumRerollTot.Name = "TBNumRerollTot"
        Me.TBNumRerollTot.Size = New System.Drawing.Size(100, 20)
        Me.TBNumRerollTot.TabIndex = 29
        Me.TBNumRerollTot.Text = "0"
        '
        'LabNumRerollTot
        '
        Me.LabNumRerollTot.AutoSize = True
        Me.LabNumRerollTot.Location = New System.Drawing.Point(373, 176)
        Me.LabNumRerollTot.Name = "LabNumRerollTot"
        Me.LabNumRerollTot.Size = New System.Drawing.Size(74, 13)
        Me.LabNumRerollTot.TabIndex = 28
        Me.LabNumRerollTot.Text = "Anzahl Rerolls"
        '
        'TBWRerollEye
        '
        Me.TBWRerollEye.Location = New System.Drawing.Point(482, 306)
        Me.TBWRerollEye.Name = "TBWRerollEye"
        Me.TBWRerollEye.Size = New System.Drawing.Size(100, 20)
        Me.TBWRerollEye.TabIndex = 47
        Me.TBWRerollEye.Text = "0"
        '
        'NumWRerollEye
        '
        Me.NumWRerollEye.AutoSize = True
        Me.NumWRerollEye.Location = New System.Drawing.Point(479, 290)
        Me.NumWRerollEye.Name = "NumWRerollEye"
        Me.NumWRerollEye.Size = New System.Drawing.Size(142, 13)
        Me.NumWRerollEye.TabIndex = 46
        Me.NumWRerollEye.Text = "Augenzahl zum Wiederholen"
        '
        'TBWReroll
        '
        Me.TBWReroll.Location = New System.Drawing.Point(376, 306)
        Me.TBWReroll.Name = "TBWReroll"
        Me.TBWReroll.Size = New System.Drawing.Size(100, 20)
        Me.TBWReroll.TabIndex = 45
        Me.TBWReroll.Text = "0"
        '
        'NumWReroll
        '
        Me.NumWReroll.AutoSize = True
        Me.NumWReroll.Location = New System.Drawing.Point(373, 290)
        Me.NumWReroll.Name = "NumWReroll"
        Me.NumWReroll.Size = New System.Drawing.Size(74, 13)
        Me.NumWReroll.TabIndex = 44
        Me.NumWReroll.Text = "Anzahl Rerolls"
        '
        'TBWMod4
        '
        Me.TBWMod4.Location = New System.Drawing.Point(496, 249)
        Me.TBWMod4.Name = "TBWMod4"
        Me.TBWMod4.Size = New System.Drawing.Size(34, 20)
        Me.TBWMod4.TabIndex = 43
        Me.TBWMod4.Text = "0"
        '
        'LabSMod4
        '
        Me.LabSMod4.AutoSize = True
        Me.LabSMod4.Location = New System.Drawing.Point(493, 233)
        Me.LabSMod4.Name = "LabSMod4"
        Me.LabSMod4.Size = New System.Drawing.Size(37, 13)
        Me.LabSMod4.TabIndex = 42
        Me.LabSMod4.Text = "Mod 4"
        '
        'TBWMod3
        '
        Me.TBWMod3.Location = New System.Drawing.Point(456, 249)
        Me.TBWMod3.Name = "TBWMod3"
        Me.TBWMod3.Size = New System.Drawing.Size(34, 20)
        Me.TBWMod3.TabIndex = 41
        Me.TBWMod3.Text = "0"
        '
        'LabSMod3
        '
        Me.LabSMod3.AutoSize = True
        Me.LabSMod3.Location = New System.Drawing.Point(453, 233)
        Me.LabSMod3.Name = "LabSMod3"
        Me.LabSMod3.Size = New System.Drawing.Size(37, 13)
        Me.LabSMod3.TabIndex = 40
        Me.LabSMod3.Text = "Mod 3"
        '
        'TBWMod2
        '
        Me.TBWMod2.Location = New System.Drawing.Point(416, 249)
        Me.TBWMod2.Name = "TBWMod2"
        Me.TBWMod2.Size = New System.Drawing.Size(34, 20)
        Me.TBWMod2.TabIndex = 39
        Me.TBWMod2.Text = "0"
        '
        'LabSMod2
        '
        Me.LabSMod2.AutoSize = True
        Me.LabSMod2.Location = New System.Drawing.Point(413, 233)
        Me.LabSMod2.Name = "LabSMod2"
        Me.LabSMod2.Size = New System.Drawing.Size(37, 13)
        Me.LabSMod2.TabIndex = 38
        Me.LabSMod2.Text = "Mod 2"
        '
        'LabWound
        '
        Me.LabWound.AutoSize = True
        Me.LabWound.Location = New System.Drawing.Point(673, 280)
        Me.LabWound.Name = "LabWound"
        Me.LabWound.Size = New System.Drawing.Size(182, 13)
        Me.LabWound.TabIndex = 37
        Me.LabWound.Text = "Durchschnittliche Vorläufige Wounds"
        '
        'LabprelWounds
        '
        Me.LabprelWounds.AutoSize = True
        Me.LabprelWounds.Location = New System.Drawing.Point(673, 252)
        Me.LabprelWounds.Name = "LabprelWounds"
        Me.LabprelWounds.Size = New System.Drawing.Size(0, 13)
        Me.LabprelWounds.TabIndex = 36
        '
        'TBWMod1
        '
        Me.TBWMod1.Location = New System.Drawing.Point(376, 249)
        Me.TBWMod1.Name = "TBWMod1"
        Me.TBWMod1.Size = New System.Drawing.Size(34, 20)
        Me.TBWMod1.TabIndex = 35
        Me.TBWMod1.Text = "0"
        '
        'LabSMod1
        '
        Me.LabSMod1.AutoSize = True
        Me.LabSMod1.Location = New System.Drawing.Point(373, 233)
        Me.LabSMod1.Name = "LabSMod1"
        Me.LabSMod1.Size = New System.Drawing.Size(37, 13)
        Me.LabSMod1.TabIndex = 34
        Me.LabSMod1.Text = "Mod 1"
        '
        'TBStrength
        '
        Me.TBStrength.Location = New System.Drawing.Point(203, 249)
        Me.TBStrength.Name = "TBStrength"
        Me.TBStrength.Size = New System.Drawing.Size(30, 20)
        Me.TBStrength.TabIndex = 33
        Me.TBStrength.Text = "0"
        '
        'LabS
        '
        Me.LabS.AutoSize = True
        Me.LabS.Location = New System.Drawing.Point(200, 233)
        Me.LabS.Name = "LabS"
        Me.LabS.Size = New System.Drawing.Size(14, 13)
        Me.LabS.TabIndex = 32
        Me.LabS.Text = "S"
        '
        'TBTough
        '
        Me.TBTough.Location = New System.Drawing.Point(273, 249)
        Me.TBTough.Name = "TBTough"
        Me.TBTough.Size = New System.Drawing.Size(30, 20)
        Me.TBTough.TabIndex = 49
        Me.TBTough.Text = "0"
        '
        'LabT
        '
        Me.LabT.AutoSize = True
        Me.LabT.Location = New System.Drawing.Point(270, 233)
        Me.LabT.Name = "LabT"
        Me.LabT.Size = New System.Drawing.Size(14, 13)
        Me.LabT.TabIndex = 48
        Me.LabT.Text = "T"
        '
        'TBMortal
        '
        Me.TBMortal.Location = New System.Drawing.Point(376, 351)
        Me.TBMortal.Name = "TBMortal"
        Me.TBMortal.Size = New System.Drawing.Size(100, 20)
        Me.TBMortal.TabIndex = 51
        Me.TBMortal.Text = "0"
        '
        'LabMortal
        '
        Me.LabMortal.AutoSize = True
        Me.LabMortal.Location = New System.Drawing.Point(373, 335)
        Me.LabMortal.Name = "LabMortal"
        Me.LabMortal.Size = New System.Drawing.Size(94, 13)
        Me.LabMortal.TabIndex = 50
        Me.LabMortal.Text = "Mortal Wounds on"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1114, 566)
        Me.Controls.Add(Me.TBMortal)
        Me.Controls.Add(Me.LabMortal)
        Me.Controls.Add(Me.TBTough)
        Me.Controls.Add(Me.LabT)
        Me.Controls.Add(Me.TBWRerollEye)
        Me.Controls.Add(Me.NumWRerollEye)
        Me.Controls.Add(Me.TBWReroll)
        Me.Controls.Add(Me.NumWReroll)
        Me.Controls.Add(Me.TBWMod4)
        Me.Controls.Add(Me.LabSMod4)
        Me.Controls.Add(Me.TBWMod3)
        Me.Controls.Add(Me.LabSMod3)
        Me.Controls.Add(Me.TBWMod2)
        Me.Controls.Add(Me.LabSMod2)
        Me.Controls.Add(Me.LabWound)
        Me.Controls.Add(Me.LabprelWounds)
        Me.Controls.Add(Me.TBWMod1)
        Me.Controls.Add(Me.LabSMod1)
        Me.Controls.Add(Me.TBStrength)
        Me.Controls.Add(Me.LabS)
        Me.Controls.Add(Me.TBNumRerollEye)
        Me.Controls.Add(Me.LabNumRerollEye)
        Me.Controls.Add(Me.TBNumRerollTot)
        Me.Controls.Add(Me.LabNumRerollTot)
        Me.Controls.Add(Me.TBMod4)
        Me.Controls.Add(Me.LabMod4)
        Me.Controls.Add(Me.TBMod3)
        Me.Controls.Add(Me.LabMod3)
        Me.Controls.Add(Me.TBMod2)
        Me.Controls.Add(Me.LabMod2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LabAvHits)
        Me.Controls.Add(Me.TBMod1)
        Me.Controls.Add(Me.LabMod1)
        Me.Controls.Add(Me.TBBF)
        Me.Controls.Add(Me.LabBF)
        Me.Controls.Add(Me.TBNumIt)
        Me.Controls.Add(Me.LabNumIt)
        Me.Controls.Add(Me.ButReset)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabResult)
        Me.Controls.Add(Me.TBEyeDie)
        Me.Controls.Add(Me.LabEyeDie)
        Me.Controls.Add(Me.Sign1)
        Me.Controls.Add(Me.TBNumShotsFlex)
        Me.Controls.Add(Me.LabNumShotsFlex)
        Me.Controls.Add(Me.TBNumShotsFix)
        Me.Controls.Add(Me.LabNumShotsfix)
        Me.Controls.Add(Me.ButCalc)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButCalc As Button
    Friend WithEvents LabNumShotsfix As Label
    Friend WithEvents TBNumShotsFix As TextBox
    Friend WithEvents TBNumShotsFlex As TextBox
    Friend WithEvents LabNumShotsFlex As Label
    Friend WithEvents Sign1 As Label
    Friend WithEvents TBEyeDie As TextBox
    Friend WithEvents LabEyeDie As Label
    Friend WithEvents LabResult As Label
    Friend WithEvents ButReset As Button
    Friend WithEvents TBNumIt As TextBox
    Friend WithEvents LabNumIt As Label
    Protected WithEvents Label2 As Label
    Protected WithEvents Label15 As Label
    Friend WithEvents LabAvHits As Label
    Friend WithEvents TBMod1 As TextBox
    Friend WithEvents LabMod1 As Label
    Friend WithEvents TBBF As TextBox
    Friend WithEvents LabBF As Label
    Friend WithEvents TBMod2 As TextBox
    Friend WithEvents LabMod2 As Label
    Friend WithEvents TBMod3 As TextBox
    Friend WithEvents LabMod3 As Label
    Friend WithEvents TBMod4 As TextBox
    Friend WithEvents LabMod4 As Label
    Friend WithEvents TBNumRerollEye As TextBox
    Friend WithEvents LabNumRerollEye As Label
    Friend WithEvents TBNumRerollTot As TextBox
    Friend WithEvents LabNumRerollTot As Label
    Friend WithEvents TBWRerollEye As TextBox
    Friend WithEvents NumWRerollEye As Label
    Friend WithEvents TBWReroll As TextBox
    Friend WithEvents NumWReroll As Label
    Friend WithEvents TBWMod4 As TextBox
    Friend WithEvents LabSMod4 As Label
    Friend WithEvents TBWMod3 As TextBox
    Friend WithEvents LabSMod3 As Label
    Friend WithEvents TBWMod2 As TextBox
    Friend WithEvents LabSMod2 As Label
    Protected WithEvents LabWound As Label
    Friend WithEvents LabprelWounds As Label
    Friend WithEvents TBWMod1 As TextBox
    Friend WithEvents LabSMod1 As Label
    Friend WithEvents TBStrength As TextBox
    Friend WithEvents LabS As Label
    Friend WithEvents TBTough As TextBox
    Friend WithEvents LabT As Label
    Friend WithEvents TBMortal As TextBox
    Friend WithEvents LabMortal As Label
End Class
