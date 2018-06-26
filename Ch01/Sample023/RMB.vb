Public Module RMB
    Function RMBChinese(ByVal dblRmb As Double) As String
        On Error Resume Next
        Dim strRmbExp As String, strRmbDa As String, strResult As String, intN As Integer, intCount As Integer, i As Integer, strNum As String

        dblRmb = Format(dblRmb, "###0.00")
        If dblRmb > 999999999999.99 Then
            RMBChinese = "需转换的金额整数长度超过了12位！"
            Exit Function
        End If
        'strRmbExp = "仟佰拾亿仟佰拾万仟佰拾元角分"
        'Debug.Print(StrReverse(strRmbExp))
        strRmbExp = "分角元拾佰仟万拾佰仟亿拾佰仟"
        strRmbDa = "零壹贰叁肆伍陆柒捌玖"
        intN = 0
        strNum = Replace(Format(dblRmb, "0.00"), ".", "")

        If Left(strNum, 1) = "-" Then
            strNum = Mid(strNum, 2)
            intN = 1
        End If

        strNum = StrReverse(strNum)
        strResult = ""
        intCount = Len(strNum)


        For i = 1 To intCount
            strResult = Mid(strRmbDa, Val(Mid(strNum, i, 1)) + 1, 1)
        Next

        'For i = 1 To intCount
        '    strResult = Mid(strRmbDa, Val(Mid(strNum, intCount - i + 1, 1)) + 1, 1) + IIf(Mid(strRmbExp, i, 1) = "元", Mid(strRmbExp, i, 1) + " ", Mid(strRmbExp, i, 1)) + strResult
        'Next

        RMBChinese = IIf(intN = 1, "负" + strResult, strResult)


    End Function
End Module
