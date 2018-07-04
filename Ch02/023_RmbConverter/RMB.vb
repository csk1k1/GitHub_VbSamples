Public Module RMB


    Public Function RMBChinese(ByVal dblRmb As Double) As String
        On Error Resume Next
        Dim strResult As String, intN As Integer, intCount As Integer, i As Integer, strNum As String
        Dim strRmbExp As String = "分角元拾佰仟万拾佰仟亿拾佰仟"
        Dim strRmbDa As String = "零壹贰叁肆伍陆柒捌玖"
        dblRmb = Format(dblRmb, "###0.00")
        If dblRmb > 999999999999.99 Then
            RMBChinese = "需转换的金额整数长度超过了12位！"
            Exit Function
        End If

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
            strResult = IIf(
                                j = 0 _
                                AndAlso (
                                                   i = 1 _
                                            OrElse i = 3 _
                                            OrElse i = 7 _
                                            OrElse i = 11 _
                                            OrElse Left(strResult, 1) = "" _
                                            OrElse Left(strResult, 1) = "零"
                                        ) _
                                , "", Mid(strRmbDa, j + 1, 1)
                           ) _
                + IIf(j = 0 AndAlso (i <> 3 OrElse i <> 7 OrElse i <> 11), "", Mid(strRmbExp, i, 1)) + strResult
        Next

        If Right(strResult, 1) = "元" Then
            strResult += "整"
        End If


        RMBChinese = IIf(intN = 1, "负" + strResult, strResult)


    End Function

    
End Module
