Module mdl

    '返回指定星期几的日期,如星期二是几号?
    Function get_date_of_wd(tWeekday As Integer, inDate As Date) As String
        Dim wd As Integer '输入日期是周几?
        Dim twd As Integer
        Dim tday As Integer
        If tWeekday = 8 Then

            Return DatePart(DateInterval.WeekOfYear, inDate)
        Else
            tday = DatePart("d", inDate, vbMonday)
            wd = DatePart("w", inDate, vbMonday)
            twd = wd - tWeekday
            get_date_of_wd = DateSerial(Year(inDate), Month(inDate), tday - twd)
            Return get_date_of_wd
        End If


    End Function
    Function get_wk(indate As Date) As Integer
        '返回一月的第几周
        Dim t_m
        Dim t_Zm
        Dim t_day
        t_Zm = DatePart(DateInterval.WeekOfYear, indate)  '年周
        t_m = DatePart(DateInterval.Month, indate) '月
        t_day = DateSerial(DatePart(DateInterval.Year, indate), t_m, 1)

        Return t_Zm - DatePart(DateInterval.WeekOfYear, t_day) + 1

    End Function
End Module
