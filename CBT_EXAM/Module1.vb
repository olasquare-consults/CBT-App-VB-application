Module Module1
    Function setAnswer()
        Dim correctAnswer(30)
        correctAnswer(1) = Dashboard.q1optionBLB.Text
        correctAnswer(2) = Dashboard.q2optionBLB.Text
        correctAnswer(3) = Dashboard.q3optionALB.Text
        correctAnswer(4) = Dashboard.q4optionALB.Text
        correctAnswer(5) = Dashboard.q5optionCLB.Text
        correctAnswer(6) = Dashboard.q6optionBLB.Text
        correctAnswer(7) = Dashboard.q7optionBLB.Text
        correctAnswer(8) = Dashboard.q8optionBLB.Text
        correctAnswer(9) = Dashboard.q9optionALB.Text
        correctAnswer(10) = Dashboard.q10optionALB.Text
        correctAnswer(11) = Dashboard.q11optionCLB.Text
        correctAnswer(12) = Dashboard.q12optionCLB.Text
        correctAnswer(13) = Dashboard.q13optionBLB.Text
        correctAnswer(14) = Dashboard.q14optionALB.Text
        correctAnswer(15) = Dashboard.q15optionCLB.Text
        correctAnswer(16) = Dashboard.q16optionALB.Text
        correctAnswer(17) = Dashboard.q17optionALB.Text
        correctAnswer(18) = Dashboard.q18optionBLB.Text
        correctAnswer(19) = Dashboard.q19optionCLB.Text
        correctAnswer(20) = Dashboard.q20optionBLB.Text
        correctAnswer(21) = Dashboard.q21optionCLB.Text
        correctAnswer(22) = Dashboard.q22optionBLB.Text
        correctAnswer(23) = Dashboard.q23optionALB.Text
        correctAnswer(24) = Dashboard.q24optionCLB.Text
        correctAnswer(25) = Dashboard.q25optionBLB.Text
        correctAnswer(26) = Dashboard.q26optionBLB.Text
        correctAnswer(27) = Dashboard.q27optionALB.Text
        correctAnswer(28) = Dashboard.q28optionALB.Text
        correctAnswer(29) = Dashboard.q29optionALB.Text
        correctAnswer(30) = Dashboard.q30optionCLB.Text
        Return correctAnswer
    End Function
    Function answeredCheck()
        Dim answer(100)
        If Dashboard.q1optionALB.Checked = True Or Dashboard.q1optionBLB.Checked = True Or Dashboard.q1optionCLB.Checked = True Then
            If Dashboard.q1optionALB.Checked = True Then
                answer(1) = Dashboard.q1optionALB.Text
            ElseIf Dashboard.q1optionBLB.Checked = True Then
                answer(1) = Dashboard.q1optionBLB.Text
            ElseIf Dashboard.q1optionCLB.Checked = True Then
                answer(1) = Dashboard.q1optionCLB.Text
            End If
        End If
        If Dashboard.q2optionALB.Checked = True Or Dashboard.q2optionBLB.Checked = True Or Dashboard.q2optionCLB.Checked = True Then
            If Dashboard.q2optionALB.Checked = True Then
                answer(2) = Dashboard.q2optionALB.Text
            ElseIf Dashboard.q2optionBLB.Checked = True Then
                answer(2) = Dashboard.q2optionBLB.Text
            ElseIf Dashboard.q2optionCLB.Checked = True Then
                answer(2) = Dashboard.q2optionCLB.Text
            End If
        End If
        If Dashboard.q3optionALB.Checked = True Or Dashboard.q3optionBLB.Checked = True Or Dashboard.q3optionCLB.Checked = True Then
            If Dashboard.q3optionALB.Checked = True Then
                answer(3) = Dashboard.q3optionALB.Text
            ElseIf Dashboard.q3optionBLB.Checked = True Then
                answer(3) = Dashboard.q3optionBLB.Text
            ElseIf Dashboard.q3optionCLB.Checked = True Then
                answer(3) = Dashboard.q3optionCLB.Text
            End If
        End If
        If Dashboard.q4optionALB.Checked = True Or Dashboard.q4optionBLB.Checked = True Or Dashboard.q4optionCLB.Checked = True Then
            If Dashboard.q4optionALB.Checked = True Then
                answer(4) = Dashboard.q4optionALB.Text
            ElseIf Dashboard.q4optionBLB.Checked = True Then
                answer(4) = Dashboard.q4optionBLB.Text
            ElseIf Dashboard.q4optionCLB.Checked = True Then
                answer(4) = Dashboard.q4optionCLB.Text
            End If
        End If
        If Dashboard.q5optionALB.Checked = True Or Dashboard.q5optionBLB.Checked = True Or Dashboard.q5optionCLB.Checked = True Then
            If Dashboard.q5optionALB.Checked = True Then
                answer(5) = Dashboard.q5optionALB.Text
            ElseIf Dashboard.q5optionBLB.Checked = True Then
                answer(5) = Dashboard.q5optionBLB.Text
            ElseIf Dashboard.q5optionCLB.Checked = True Then
                answer(5) = Dashboard.q5optionCLB.Text
            End If
        End If
        If Dashboard.q6optionALB.Checked = True Or Dashboard.q6optionBLB.Checked = True Or Dashboard.q6optionCLB.Checked = True Then
            If Dashboard.q6optionALB.Checked = True Then
                answer(6) = Dashboard.q6optionALB.Text
            ElseIf Dashboard.q6optionBLB.Checked = True Then
                answer(6) = Dashboard.q6optionBLB.Text
            ElseIf Dashboard.q6optionCLB.Checked = True Then
                answer(6) = Dashboard.q6optionCLB.Text
            End If
        End If
        If Dashboard.q7optionALB.Checked = True Or Dashboard.q7optionBLB.Checked = True Or Dashboard.q7optionCLB.Checked = True Then
            If Dashboard.q7optionALB.Checked = True Then
                answer(7) = Dashboard.q7optionALB.Text
            ElseIf Dashboard.q7optionBLB.Checked = True Then
                answer(7) = Dashboard.q7optionBLB.Text
            ElseIf Dashboard.q7optionCLB.Checked = True Then
                answer(7) = Dashboard.q7optionCLB.Text
            End If
        End If
        If Dashboard.q8optionALB.Checked = True Or Dashboard.q8optionBLB.Checked = True Or Dashboard.q8optionCLB.Checked = True Then
            If Dashboard.q8optionALB.Checked = True Then
                answer(8) = Dashboard.q8optionALB.Text
            ElseIf Dashboard.q8optionBLB.Checked = True Then
                answer(8) = Dashboard.q8optionBLB.Text
            ElseIf Dashboard.q8optionCLB.Checked = True Then
                answer(8) = Dashboard.q8optionCLB.Text
            End If
        End If
        If Dashboard.q9optionALB.Checked = True Or Dashboard.q9optionBLB.Checked = True Or Dashboard.q9optionCLB.Checked = True Then
            If Dashboard.q9optionALB.Checked = True Then
                answer(9) = Dashboard.q9optionALB.Text
            ElseIf Dashboard.q9optionBLB.Checked = True Then
                answer(9) = Dashboard.q9optionBLB.Text
            ElseIf Dashboard.q9optionCLB.Checked = True Then
                answer(9) = Dashboard.q9optionCLB.Text
            End If
        End If
        If Dashboard.q10optionALB.Checked = True Or Dashboard.q10optionBLB.Checked = True Or Dashboard.q10optionCLB.Checked = True Then
            If Dashboard.q10optionALB.Checked = True Then
                answer(10) = Dashboard.q10optionALB.Text
            ElseIf Dashboard.q10optionBLB.Checked = True Then
                answer(10) = Dashboard.q10optionBLB.Text
            ElseIf Dashboard.q10optionCLB.Checked = True Then
                answer(10) = Dashboard.q10optionCLB.Text
            End If
        End If
        If Dashboard.q11optionALB.Checked = True Or Dashboard.q11optionBLB.Checked = True Or Dashboard.q11optionCLB.Checked = True Then
            If Dashboard.q11optionALB.Checked = True Then
                answer(11) = Dashboard.q11optionALB.Text
            ElseIf Dashboard.q11optionBLB.Checked = True Then
                answer(11) = Dashboard.q11optionBLB.Text
            ElseIf Dashboard.q11optionCLB.Checked = True Then
                answer(11) = Dashboard.q11optionCLB.Text
            End If
        End If
        If Dashboard.q12optionALB.Checked = True Or Dashboard.q12optionBLB.Checked = True Or Dashboard.q12optionCLB.Checked = True Then
            If Dashboard.q12optionALB.Checked = True Then
                answer(12) = Dashboard.q12optionALB.Text
            ElseIf Dashboard.q12optionBLB.Checked = True Then
                answer(12) = Dashboard.q12optionBLB.Text
            ElseIf Dashboard.q12optionCLB.Checked = True Then
                answer(12) = Dashboard.q12optionCLB.Text
            End If
        End If
        If Dashboard.q13optionALB.Checked = True Or Dashboard.q13optionBLB.Checked = True Or Dashboard.q13optionCLB.Checked = True Then
            If Dashboard.q13optionALB.Checked = True Then
                answer(13) = Dashboard.q13optionALB.Text
            ElseIf Dashboard.q13optionBLB.Checked = True Then
                answer(13) = Dashboard.q13optionBLB.Text
            ElseIf Dashboard.q13optionCLB.Checked = True Then
                answer(13) = Dashboard.q13optionCLB.Text
            End If
        End If
        If Dashboard.q14optionALB.Checked = True Or Dashboard.q14optionBLB.Checked = True Or Dashboard.q14optionCLB.Checked = True Then
            If Dashboard.q14optionALB.Checked = True Then
                answer(14) = Dashboard.q14optionALB.Text
            ElseIf Dashboard.q14optionBLB.Checked = True Then
                answer(14) = Dashboard.q14optionBLB.Text
            ElseIf Dashboard.q14optionCLB.Checked = True Then
                answer(14) = Dashboard.q14optionCLB.Text
            End If
        End If
        If Dashboard.q15optionALB.Checked = True Or Dashboard.q15optionBLB.Checked = True Or Dashboard.q15optionCLB.Checked = True Then
            If Dashboard.q15optionALB.Checked = True Then
                answer(15) = Dashboard.q15optionALB.Text
            ElseIf Dashboard.q15optionBLB.Checked = True Then
                answer(15) = Dashboard.q15optionBLB.Text
            ElseIf Dashboard.q15optionCLB.Checked = True Then
                answer(15) = Dashboard.q15optionCLB.Text
            End If
        End If
        If Dashboard.q16optionALB.Checked = True Or Dashboard.q16optionBLB.Checked = True Or Dashboard.q16optionCLB.Checked = True Then
            If Dashboard.q16optionALB.Checked = True Then
                answer(16) = Dashboard.q16optionALB.Text
            ElseIf Dashboard.q16optionBLB.Checked = True Then
                answer(16) = Dashboard.q16optionBLB.Text
            ElseIf Dashboard.q16optionCLB.Checked = True Then
                answer(16) = Dashboard.q16optionCLB.Text
            End If
        End If
        If Dashboard.q17optionALB.Checked = True Or Dashboard.q17optionBLB.Checked = True Or Dashboard.q17optionCLB.Checked = True Then
            If Dashboard.q17optionALB.Checked = True Then
                answer(17) = Dashboard.q17optionALB.Text
            ElseIf Dashboard.q17optionBLB.Checked = True Then
                answer(17) = Dashboard.q17optionBLB.Text
            ElseIf Dashboard.q17optionCLB.Checked = True Then
                answer(17) = Dashboard.q17optionCLB.Text
            End If
        End If
        If Dashboard.q18optionALB.Checked = True Or Dashboard.q18optionBLB.Checked = True Or Dashboard.q18optionCLB.Checked = True Then
            If Dashboard.q18optionALB.Checked = True Then
                answer(18) = Dashboard.q18optionALB.Text
            ElseIf Dashboard.q18optionBLB.Checked = True Then
                answer(18) = Dashboard.q18optionBLB.Text
            ElseIf Dashboard.q18optionCLB.Checked = True Then
                answer(18) = Dashboard.q18optionCLB.Text
            End If
        End If
        If Dashboard.q19optionALB.Checked = True Or Dashboard.q19optionBLB.Checked = True Or Dashboard.q19optionCLB.Checked = True Then
            If Dashboard.q19optionALB.Checked = True Then
                answer(19) = Dashboard.q19optionALB.Text
            ElseIf Dashboard.q19optionBLB.Checked = True Then
                answer(19) = Dashboard.q19optionBLB.Text
            ElseIf Dashboard.q19optionCLB.Checked = True Then
                answer(19) = Dashboard.q19optionCLB.Text
            End If
        End If
        If Dashboard.q20optionALB.Checked = True Or Dashboard.q20optionBLB.Checked = True Or Dashboard.q20optionCLB.Checked = True Then
            If Dashboard.q20optionALB.Checked = True Then
                answer(20) = Dashboard.q20optionALB.Text
            ElseIf Dashboard.q20optionBLB.Checked = True Then
                answer(20) = Dashboard.q20optionBLB.Text
            ElseIf Dashboard.q20optionCLB.Checked = True Then
                answer(20) = Dashboard.q20optionCLB.Text
            End If
        End If
        If Dashboard.q21optionALB.Checked = True Or Dashboard.q21optionBLB.Checked = True Or Dashboard.q21optionCLB.Checked = True Then
            If Dashboard.q21optionALB.Checked = True Then
                answer(21) = Dashboard.q21optionALB.Text
            ElseIf Dashboard.q21optionBLB.Checked = True Then
                answer(21) = Dashboard.q21optionBLB.Text
            ElseIf Dashboard.q21optionCLB.Checked = True Then
                answer(21) = Dashboard.q21optionCLB.Text
            End If
        End If
        If Dashboard.q22optionALB.Checked = True Or Dashboard.q22optionBLB.Checked = True Or Dashboard.q22optionCLB.Checked = True Then
            If Dashboard.q22optionALB.Checked = True Then
                answer(22) = Dashboard.q22optionALB.Text
            ElseIf Dashboard.q22optionBLB.Checked = True Then
                answer(22) = Dashboard.q22optionBLB.Text
            ElseIf Dashboard.q22optionCLB.Checked = True Then
                answer(22) = Dashboard.q22optionCLB.Text
            End If
        End If
        If Dashboard.q23optionALB.Checked = True Or Dashboard.q23optionBLB.Checked = True Or Dashboard.q23optionCLB.Checked = True Then
            If Dashboard.q23optionALB.Checked = True Then
                answer(23) = Dashboard.q23optionALB.Text
            ElseIf Dashboard.q23optionBLB.Checked = True Then
                answer(23) = Dashboard.q23optionBLB.Text
            ElseIf Dashboard.q23optionCLB.Checked = True Then
                answer(23) = Dashboard.q23optionCLB.Text
            End If
        End If
        If Dashboard.q24optionALB.Checked = True Or Dashboard.q24optionBLB.Checked = True Or Dashboard.q24optionCLB.Checked = True Then
            If Dashboard.q24optionALB.Checked = True Then
                answer(24) = Dashboard.q24optionALB.Text
            ElseIf Dashboard.q24optionBLB.Checked = True Then
                answer(24) = Dashboard.q24optionBLB.Text
            ElseIf Dashboard.q24optionCLB.Checked = True Then
                answer(24) = Dashboard.q24optionCLB.Text
            End If
        End If
        If Dashboard.q25optionALB.Checked = True Or Dashboard.q25optionBLB.Checked = True Or Dashboard.q25optionCLB.Checked = True Then
            If Dashboard.q25optionALB.Checked = True Then
                answer(25) = Dashboard.q25optionALB.Text
            ElseIf Dashboard.q25optionBLB.Checked = True Then
                answer(25) = Dashboard.q25optionBLB.Text
            ElseIf Dashboard.q25optionCLB.Checked = True Then
                answer(25) = Dashboard.q25optionCLB.Text
            End If
        End If
        If Dashboard.q26optionALB.Checked = True Or Dashboard.q26optionBLB.Checked = True Or Dashboard.q26optionCLB.Checked = True Then
            If Dashboard.q26optionALB.Checked = True Then
                answer(26) = Dashboard.q26optionALB.Text
            ElseIf Dashboard.q26optionBLB.Checked = True Then
                answer(26) = Dashboard.q26optionBLB.Text
            ElseIf Dashboard.q26optionCLB.Checked = True Then
                answer(26) = Dashboard.q26optionCLB.Text
            End If
        End If
        If Dashboard.q27optionALB.Checked = True Or Dashboard.q27optionBLB.Checked = True Or Dashboard.q27optionCLB.Checked = True Then
            If Dashboard.q27optionALB.Checked = True Then
                answer(27) = Dashboard.q27optionALB.Text
            ElseIf Dashboard.q27optionBLB.Checked = True Then
                answer(27) = Dashboard.q27optionBLB.Text
            ElseIf Dashboard.q27optionCLB.Checked = True Then
                answer(27) = Dashboard.q27optionCLB.Text
            End If
        End If
        If Dashboard.q28optionALB.Checked = True Or Dashboard.q28optionBLB.Checked = True Or Dashboard.q28optionCLB.Checked = True Then
            If Dashboard.q28optionALB.Checked = True Then
                answer(28) = Dashboard.q28optionALB.Text
            ElseIf Dashboard.q28optionBLB.Checked = True Then
                answer(28) = Dashboard.q28optionBLB.Text
            ElseIf Dashboard.q28optionCLB.Checked = True Then
                answer(28) = Dashboard.q28optionCLB.Text
            End If
        End If
        If Dashboard.q29optionALB.Checked = True Or Dashboard.q29optionBLB.Checked = True Or Dashboard.q29optionCLB.Checked = True Then
            If Dashboard.q29optionALB.Checked = True Then
                answer(29) = Dashboard.q29optionALB.Text
            ElseIf Dashboard.q29optionBLB.Checked = True Then
                answer(29) = Dashboard.q29optionBLB.Text
            ElseIf Dashboard.q29optionCLB.Checked = True Then
                answer(29) = Dashboard.q29optionCLB.Text
            End If
        End If
        If Dashboard.q30optionALB.Checked = True Or Dashboard.q30optionBLB.Checked = True Or Dashboard.q30optionCLB.Checked = True Then
            If Dashboard.q30optionALB.Checked = True Then
                answer(30) = Dashboard.q30optionALB.Text
            ElseIf Dashboard.q30optionBLB.Checked = True Then
                answer(30) = Dashboard.q30optionBLB.Text
            ElseIf Dashboard.q30optionCLB.Checked = True Then
                answer(30) = Dashboard.q30optionCLB.Text
            End If
        End If
        Return answer
    End Function
    Function getResult()
        Dim result = 0
        Dim answer()
        Dim pickAnswer = answeredCheck()
        answer = setAnswer()
        For i = 1 To 30
            If pickAnswer(i) = answer(i) Then
                result += 1
            End If
        Next
        Return result
    End Function
End Module
