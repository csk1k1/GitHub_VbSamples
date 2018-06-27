Public Module RMB
    Function RMBChinese(ByVal dblRmb As Double) As String
        On Error Resume Next
        Dim strRmbExp As String, strRmbDa As String, strResult As String, intN As Integer, intCount As Integer, i As Integer, strNum As String

        dblRmb = Format(dblRmb, "###0.00")
        If dblRmb > 999999999999.99 Then
            RMBChinese = "需转换的金额整数长度超过了12位！"
            Exit Function
        End If

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
            Dim j = CInt(Mid(strNum, i, 1))
            strResult = Mid(strRmbDa, j + 1, 1) + IIf(j = 0 AndAlso (i <> 7 OrElse i <> 11), "", Mid(strRmbExp, i, 1)) + strResult
        Next

        If 


        RMBChinese = IIf(intN = 1, "负" + strResult, strResult)


    End Function
End Module
