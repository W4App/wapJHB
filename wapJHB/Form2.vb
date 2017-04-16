Public Class Form2
    '联合检查时间, 显示为派发时间!
    Dim LJDate As Date
    Dim tzdTxt As String
    Dim tmpDate As Date
    Dim zhanName As String
    Private Sub T_wtjuBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles T_wtjuBindingNavigatorSaveItem.Click
        Me.Validate()
        '问题记录更新
        Me.T_wtjuBindingSource.EndEdit()
        Me.T_WTJUTableAdapter.Update(JHBDataSet.T_WTJU)

        '派发记录表更新
        Me.T_pfjuBindingSource.EndEdit()
        Me.T_pfjuTableAdapter.Update(Me.JHBDataSet.t_pfju)
        '通知单表更新
        Me.TzdContentBindingSource.EndEdit()
        Me.TzdContentTableAdapter.Update(Me.JHBDataSet.tzdContent)
        '所有修改更新
        ' Me.TableAdapterManager.UpdateAll(Me.JHBDataSet)
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.T_wtjuBindingSource.EndEdit()
        Me.T_WTJUTableAdapter.Update(JHBDataSet.T_WTJU)

        '派发记录表更新
        Me.T_pfjuBindingSource.EndEdit()
        Me.T_pfjuTableAdapter.Update(Me.JHBDataSet.t_pfju)
        '通知单表更新
        Me.TzdContentBindingSource.EndEdit()
        Me.TzdContentTableAdapter.Update(Me.JHBDataSet.tzdContent)
        '所有修改更新
        'Me.TableAdapterManager.UpdateAll(Me.JHBDataSet)

        Me.Owner.Show()
        Me.Dispose()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.站名ComboBox.Text = "请选择派发站"

        Me.TzdContentTableAdapter.Fill(Me.JHBDataSet.tzdContent)
        'TODO:  这行代码将数据加载到表“JHBDataSet.t_pfju”中。您可以根据需要移动或删除它。
        Me.T_pfjuTableAdapter.Fill(Me.JHBDataSet.t_pfju)
        'TODO:  这行代码将数据加载到表“JHBDataSet.T_WTJU”中。您可以根据需要移动或删除它。
        Me.T_WTJUTableAdapter.Fill(Me.JHBDataSet.T_WTJU)
        ' Me.T_WTJUTableAdapter.FillBy_zm_lr(Me.JHBDataSet.T_WTJU, "安康")
        Me.ToolStripTextBox1.Text = "debug: why other computer can not show infomation?"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        Dim nr As String
        Dim tzd_wkNumber As String
        nr = 存在问题TextBox.Text
        If 计划时间TextBox.Text = "" Then
            MsgBox("计划时间没填写")
            计划时间TextBox.Focus()
            Exit Sub
        End If
        If 站名ComboBox.Text = "请选择派发站" Then
            MsgBox("请选择站名!")
            站名ComboBox.Focus()
            Exit Sub
        End If
        Try
            Me.T_pfjuTableAdapter.InsertQuery_pfju(问题编号Label1.Text, LJDate, 计划时间TextBox.Text, zhanName, 设备名称Label1.Text, 存在问题TextBox.Text, 天窗需求Label1.Text)
            tzd_wkNumber = mdl.get_wk(LJDate)
            Dim pfUnitName As String
            pfUnitName = 站名ComboBox.Text & "线路工区"
            Me.TzdContentTableAdapter.InsertQuery_pfInfo(LJDate, tzd_wkNumber, nr, 设备名称Label1.Text, 计划时间TextBox.Text, zhanName, pfUnitName, Me.整治方案TextBox.Text, 天窗需求Label1.Text)
        Catch ex As Exception
            MsgBox(ex)
        End Try
        'Me.T_pfjuTableAdapter.Fill(JHBDataSet.t_pfju)
        Me.T_pfjuTableAdapter.FillBy_orderbydate(JHBDataSet.t_pfju, 问题编号Label1.Text, zhanName)
        'Me.TzdContentTableAdapter.Fill(JHBDataSet.tzdContent)
        Me.TzdContentTableAdapter.FillBy_zm(JHBDataSet.tzdContent, zhanName)
        'tmpDate = 计划时间TextBox.Text
        '强制更新主表<计划时间数据段>!
        Me.T_wtjuBindingSource.EndEdit()
        Me.T_WTJUTableAdapter.Update(JHBDataSet.T_WTJU)
        '其他2个副表是直接插入的,不需更新
        Me.T_wtjuBindingSource.MoveNext()
        refresh_CruData(问题编号Label1.Text, zhanName)
    End Sub
    Private Sub 计划时间TextBox_Click(sender As Object, e As EventArgs) Handles 计划时间TextBox.Click
        Me.jhDateTimePicker.Focus()
        My.Computer.Keyboard.SendKeys("%{DOWN}")
    End Sub
    Private Sub 计划时间TextBox_TextChanged(sender As Object, e As EventArgs) Handles 计划时间TextBox.TextChanged
        If Weekday(计划时间TextBox.Text, FirstDayOfWeek.Monday) > 5 Then
            MsgBox("计划整治时间不能安排在休息日!")
            计划时间TextBox.Focus()
        End If
        If 发现问题时间Label1.Text = "" Then
            'Me.ToolStripTextBox1.Text = "这条记录<发现问题时间未填写>"
        Else
            If DateDiff(DateInterval.DayOfYear, CDate(计划时间TextBox.Text), CDate(发现问题时间Label1.Text)) > 0 Then
                MsgBox("计划时间早于发现时间,请重新选")
                计划时间TextBox.Focus()
            End If
        End If


    End Sub
    Private Sub 留存CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles 留存CheckBox.CheckedChanged
        If 留存CheckBox.Checked = True Then
            计划时间TextBox.Enabled = False
            整治方案TextBox.Enabled = False
            Button1.Enabled = False

        Else
            计划时间TextBox.Enabled = True
            整治方案TextBox.Enabled = True
            Button1.Enabled = True
        End If
    End Sub
    Private Sub T_wtjuBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles T_wtjuBindingSource.CurrentChanged
        '上次日期写入下次的默认值
        '计划时间TextBox.Text = tmpDate
        Me.Validate()

        Dim wapfTBL As DataTable = New JHBDataSet.t_pfjuDataTable
        Dim warow As JHBDataSet.t_pfjuRow

        ' 清理外观设置
        Me.Button1.Enabled = True
        Me.Button1.Text = "派发"
        wapfTBL.Clear()

        wapfTBL = Me.T_pfjuTableAdapter.GetDataBy_orderbydate(Me.问题编号Label1.Text, zhanName)
        'MsgBox(wapfTBL.Rows.Count)
        If wapfTBL.Rows.Count = 0 Then
            Me.ToolStripTextBox1.Text = "Infomation: 问题:->" + Me.问题编号Label1.Text + "#  尚未派发"
        Else
            warow = wapfTBL.Rows(0)
            Me.ToolStripTextBox1.Text = "Infomation: 问题:->" + Me.问题编号Label1.Text + "#  在" + Format(warow.Item(1), "yyyy年M月dd日") + "(最近)已派发"
            If DatePart(DateInterval.WeekOfYear, LJDate) = DatePart(DateInterval.WeekOfYear, warow.Item(1)) Then
                'MsgBox("本周已经派发过了~")
                Me.ToolStripTextBox1.Text = "Infomation: 问题:->" + Me.问题编号Label1.Text + "#  *本周已经派发过!!!  " + Format(warow.Item(1), "yyyy年M月dd日") + "(最近)已派发"
                Me.Button1.Text = "本周已发"
                Me.Button1.Enabled = False
            End If          
        End If
        ' Me.ToolStripTextBox1.Text = "debug: why other computer can not show infomation?"
    End Sub
    Private Sub LJDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles LJDateTimePicker.ValueChanged
        If Weekday(LJDateTimePicker.Value, FirstDayOfWeek.Monday) > 5 Then
            MsgBox("联检时间是周末,重新选择")
            LJDateTimePicker.Focus()
        End If
        LJDate = LJDateTimePicker.Value
        TextBox1.Text = LJDate
    End Sub
    Private Sub jhDateTimePicker_CloseUp(sender As Object, e As EventArgs) Handles jhDateTimePicker.CloseUp
        If Weekday(jhDateTimePicker.Value, FirstDayOfWeek.Monday) > 5 Then
            MsgBox("计划整治时间是周末,请重选择!")
            Me.计划时间TextBox.Focus()
        Else
            Me.计划时间TextBox.Text = jhDateTimePicker.Value
            tmpDate = jhDateTimePicker.Value
        End If
    End Sub

    Private Sub 站名ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles 站名ComboBox.SelectedIndexChanged
        Me.zhanName = 站名ComboBox.Text
        站名ComboBox.Tag = Me.zhanName
        Me.T_WTJUTableAdapter.FillBy_zhanName_PF(JHBDataSet.T_WTJU, zhanName)
        Me.T_pfjuTableAdapter.Fill(JHBDataSet.t_pfju)
        Me.TzdContentTableAdapter.Fill(JHBDataSet.tzdContent)
        Me.T_wtjuBindingSource.ResetCurrentItem()
        '强制刷新当前记录数据!
        If 问题编号Label1.Text = "" Then
            Me.ToolStripTextBox1.Text = "Infomation: 无相关记录!"
            Me.Button1.Text = "无记录"
            Me.Button1.Enabled = False
        Else

            refresh_CruData(问题编号Label1.Text, zhanName)
        End If

    End Sub

    Function refresh_CruData(bh As Integer, zm As String) As Boolean

        Dim wapfTBL As DataTable = New JHBDataSet.t_pfjuDataTable
        Dim warow As JHBDataSet.t_pfjuRow
        ' 清理外观设置
        Me.Button1.Enabled = True
        Me.Button1.Text = "派发"
        wapfTBL.Clear()
        wapfTBL = Me.T_pfjuTableAdapter.GetDataBy_orderbydate(Me.问题编号Label1.Text, zhanName)
        'MsgBox(wapfTBL.Rows.Count)
        If wapfTBL.Rows.Count = 0 Then
            Me.ToolStripTextBox1.Text = "Infomation: 问题:->" + Me.问题编号Label1.Text + "#  尚未派发"
        Else
            warow = wapfTBL.Rows(0)
            Me.ToolStripTextBox1.Text = "Infomation: 问题:->" + Me.问题编号Label1.Text + "#  在" + Format(warow.Item(1), "yyyy年M月dd日") + "(最近)已派发"
            If DatePart(DateInterval.WeekOfYear, LJDate) = DatePart(DateInterval.WeekOfYear, warow.Item(1)) Then
                'MsgBox("本周已经派发过了~")
                Me.ToolStripTextBox1.Text = "Infomation: 问题:->" + Me.问题编号Label1.Text + "#  *本周已经派发过!!!  " + Format(warow.Item(1), "yyyy年M月dd日") + "(最近)已派发"
                Me.Button1.Text = "本周已发"
                Me.Button1.Enabled = False
            End If

        End If
        Return True
    End Function
End Class