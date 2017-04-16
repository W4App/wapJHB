Public Class Form3
    Dim zhanName As String
    Dim pf_date_last As Date

    Private Sub T_wtjuBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles T_wtjuBindingNavigatorSaveItem.Click
        Me.Validate()
        '为代码防止错误销记信息被写入,把更新动作加入到销记按钮上, 这里的更新去掉
        'Me.T_wtjuBindingSource.EndEdit()
        'Me.T_WTJUTableAdapter.Update(JHBDataSet.T_WTJU)

        'Me.TableAdapterManager.UpdateAll(Me.JHBDataSet)
    End Sub

    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Me.T_wtjuBindingSource.EndEdit()
        'Me.T_WTJUTableAdapter.Update(JHBDataSet.T_WTJU)

        'Me.TableAdapterManager.UpdateAll(Me.JHBDataSet)
        Me.Owner.Show()
        Me.Dispose()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '写入默认的站
        站名ComboBox.Text = "安康"
        站名ComboBox.Tag = 站名ComboBox.Tag

        Me.T_pfjuTableAdapter.Fill(JHBDataSet.t_pfju)

        Me.T_WTJUTableAdapter.Fill(Me.JHBDataSet.T_WTJU)
        'Me.ToolStripTextBox1.Text = "debug: why other computer can not show infomation?"

    End Sub
    Private Sub 销记时间TextBox_Click(sender As Object, e As EventArgs) Handles 销记时间TextBox.Click
        Me.销记时间TextBox.ForeColor = Color.Black
        Me.ToolStripTextBox1.Text = ""
        Me.ToolStripTextBox1.ForeColor = Color.Black
        xjDateTimePicker.Focus()
        My.Computer.Keyboard.SendKeys("%{DOWN}")
    End Sub
    Private Sub xjDateTimePicker_CloseUp(sender As Object, e As EventArgs) Handles xjDateTimePicker.CloseUp
        销记时间TextBox.Text = xjDateTimePicker.Value
    End Sub 
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Validate()
        If 站名ComboBox.Text = "" Then
            Me.ToolStripTextBox1.Text = "站名没填"
            站名ComboBox.Focus()
            Exit Sub
        End If
        If Me.整治情况TextBox.Text = "" Then
            Me.ToolStripTextBox1.Text = "整治情况没填写"
            Me.整治情况TextBox.Focus()
            Exit Sub
        End If
        If Me.完成情况TextBox.Text = "" Then
            Me.ToolStripTextBox1.Text = "完成情况没填写"
            Me.完成情况TextBox.Focus()
            Exit Sub
        End If
        If Me.参加整治负责人签字TextBox.Text = "" Then
            Me.ToolStripTextBox1.Text = "整改人没填写"
            Me.参加整治负责人签字TextBox.Focus()
            Exit Sub
        End If
        If 销记时间TextBox.Text = "" Then
            Me.销记时间TextBox.ForeColor = Color.Red
            Me.ToolStripTextBox1.Text = "销记时间不能是空,请重新填写!"
            Me.ToolStripTextBox1.ForeColor = Color.Red
            Me.销记时间TextBox.Focus()
            Exit Sub
        End If
        If Weekday(销记时间TextBox.Text, FirstDayOfWeek.Monday) > 5 Then
            ' Me.销记时间TextBox.ForeColor = Color.Red
            Me.ToolStripTextBox1.Text = "销记时间是周末,请重新填写!"
            Me.ToolStripTextBox1.ForeColor = Color.Red
            Me.销记时间TextBox.Focus()
            Exit Sub
        End If

        销记CheckBox.Checked = True  '销记动作!

        Me.T_wtjuBindingSource.EndEdit()
        Me.T_WTJUTableAdapter.Update(JHBDataSet.T_WTJU)
        '显然不能直接更新, 得找到本条记录的位置才能更新.
        Me.CheckBox1.Checked = True   '更新派发表

        Me.T_pfjuBindingSource.EndEdit()
        Me.T_pfjuTableAdapter.UpdateQuery_pf_xjstate(Me.CheckBox1.Checked, 问题编号Label1.Text, pf_date_last, zhanName)

        Me.T_pfjuTableAdapter.FillBy_ZM(JHBDataSet.t_pfju, zhanName)
        'Me.T_pfjuTableAdapter.Fill(JHBDataSet.t_pfju)
        Me.T_wtjuBindingSource.MoveNext()
    End Sub

    Private Sub T_wtjuBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles T_wtjuBindingSource.CurrentItemChanged
        Me.Validate()

        Refresh_pfInfo()
    End Sub

    Private Sub 站名ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles 站名ComboBox.SelectedIndexChanged
        Me.zhanName = 站名ComboBox.Text
        站名ComboBox.Tag = Me.zhanName
        Me.T_WTJUTableAdapter.FillBy_zhanName_PF(JHBDataSet.T_WTJU, zhanName)

        Me.Validate()
        If 问题编号Label1.Text = "" Then
            Me.ToolStripTextBox1.Text = "Infomation:没有所选站的记录"
        Else
            Me.T_pfjuTableAdapter.FillBy_ZM(JHBDataSet.t_pfju, zhanName)
            Refresh_pfInfo()
        End If


    End Sub
    Sub Refresh_pfInfo()
        Dim wapfTBL As DataTable = New JHBDataSet.t_pfjuDataTable
        Dim warow As JHBDataSet.t_pfjuRow
        ' 清理外观设置

        wapfTBL.Clear()

        wapfTBL = Me.T_pfjuTableAdapter.GetDataBy_orderbydate(Me.问题编号Label1.Text, Me.zhanName)
        'MsgBox(wapfTBL.Rows.Count)
        If wapfTBL.Rows.Count = 0 Then
            Me.ToolStripTextBox1.Text = "Infomation: 问题:->" + Me.问题编号Label1.Text + "#  尚未派发不能销记"
            Me.Button1.Enabled = False
            Me.Button1.Text = "未派发项目"
            '没有派发的记录直接翻过?  尝试加入看效果

        Else
            warow = wapfTBL.Rows(0)
            '返回最后的派发日期
            pf_date_last = warow.Item(1)      
            Me.ToolStripTextBox1.Text = "Infomation: 问题:->" + Me.问题编号Label1.Text + "#  在" + Format(warow.Item(1), "yyyy年M月dd日") + "(最近)已派发"
            Me.Button1.Enabled = True
            Me.Button1.Text = "销记"
            'MsgBox(Me.T_pfjuBindingSource.Current().ToString)
        End If
    End Sub


End Class