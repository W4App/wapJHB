Public Class Form1
    '定义天窗需求, 每个站不同, 为了方便选择
    Dim ak_req As String()
    Dim smg_req As String()

    Dim zhanName As String
    Dim waIsAdd As Boolean

    Dim wacanEdit As Boolean
    Private Sub T_wtjuBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles T_wtjuBindingNavigatorSaveItem.Click
        Me.Validate()

        Try

            Me.T_wtjuBindingSource.EndEdit()
            Me.T_WTJUTableAdapter.Update(Me.JHBDataSet.T_WTJU)
            '更新完毕重新填充?!
            Me.T_WTJUTableAdapter.FillBy_zm_lr(JHBDataSet.T_WTJU, zhanName)
            Me.T_wtjuBindingSource.MoveLast()

            Me.ToolStripLabel1.Text = "提示:"
            Me.ToolStripLabel1.ForeColor = Color.Black

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If wacanEdit = True Then
            'MsgBox("change")
            Me.T_wtjuBindingSource.EndEdit()
            Me.T_WTJUTableAdapter.Update(Me.JHBDataSet.T_WTJU)
        End If
        Me.Owner.Show()
        Me.Dispose()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Text = "录入"
        'TODO:  这行代码将数据加载到表“JHBDataSet.x_fz”中。您可以根据需要移动或删除它。
        Me.X_fzTableAdapter.Fill(Me.JHBDataSet.x_fz)
        '用全部的数据填充
        Me.站名ComboBox.Text = "选择站"
        Me.T_WTJUTableAdapter.Fill(Me.JHBDataSet.T_WTJU)
        Me.T_wtjuBindingSource.MoveLast()
        Me.ToolStripButton1.Enabled = False
        Me.waIsAdd = False
        Me.wacanEdit = False
        '初始化天窗需求
        ak_req = {"垂直东", "垂直西", "上行东正线", "上行东站专", "上行西正线", "上行西站专", "阳安线正线", "阳安线站专", _
                             "下行东正线", "下行东站专", "下行西正线", "下行西站专"}
        smg_req = {"上行上咽喉", "上行下咽喉", "下行上咽喉", "下行下咽喉"}
    End Sub

    Private Sub 设备名称TextBox_TextChanged(sender As Object, e As EventArgs) Handles 设备名称TextBox.TextChanged
        '用手工方式绑定控件:(常规方式用添加控件方式) :
        '思路-->用适配器的get方法获得数据表w1dt-->绑定到一个绑定源w1bs-->设置控件的数据源ds        
        Dim w1dt As DataTable
        Dim w1bs = New BindingSource()
        '使用适配器方法!
        w1dt = X_fzTableAdapter.GetDataBy_sbName(设备名称TextBox.Text, 站名ComboBox.Text)
        w1bs.DataSource = w1dt
        X_fzDataGridView.DataSource = w1bs
    End Sub
    Private Sub 存在问题TextBox_TextChanged(sender As Object, e As EventArgs) Handles 存在问题TextBox.TextChanged
        Dim w1dt As DataTable
        Dim w1bs = New BindingSource
        w1dt = X_fzTableAdapter.GetDataBy_sbQuestion(存在问题TextBox.Text, 站名ComboBox.Text)
        w1bs.DataSource = w1dt
        X_fzDataGridView1.DataSource = w1bs
    End Sub

    Private Sub 设备名称TextBox_Validated(sender As Object, e As EventArgs) Handles 设备名称TextBox.Validated
        If 设备名称TextBox.Text = "" Or 设备名称TextBox.Text = "必填" Then
            With 设备名称TextBox
                .Text = "必填"
                .SelectAll()
                .BackColor = Color.LightYellow
                .Focus()
            End With
        Else
            With 设备名称TextBox
                .BackColor = Color.White
            End With

        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click     
        Me.站名ComboBox.Tag = zhanName
        Me.站名ComboBox.Text = zhanName
        Me.BindingNavigatorAddNewItem.Enabled = False
        Me.ToolStripButton1.Enabled = True
        Me.设备名称TextBox.Focus()
        waIsAdd = True
        '关闭其他会干扰添加的按钮, 哎没办法的法子
        T_wtjuBindingNavigatorSaveItem.Enabled = False
        Me.BindingNavigatorMoveFirstItem.Visible = False
        Me.BindingNavigatorMoveLastItem.Visible = False
        Me.BindingNavigatorMoveNextItem.Visible = False
        Me.BindingNavigatorMovePreviousItem.Visible = False
        '-------------------------
    End Sub

    Private Sub 存在问题TextBox_Validated(sender As Object, e As EventArgs) Handles 存在问题TextBox.Validated
        If 存在问题TextBox.Text = "" Or 存在问题TextBox.Text = "必填" Then
            With 存在问题TextBox
                .Text = "必填"
                .SelectAll()
                .BackColor = Color.LightYellow
                .Focus()
            End With
        Else
            With 存在问题TextBox
                .BackColor = Color.White
            End With

        End If
    End Sub
    Private Sub 整治方案TextBox_Validated(sender As Object, e As EventArgs) Handles 整治方案TextBox.Validated
        If 整治方案TextBox.Text = "" Or 整治方案TextBox.Text = "必填" Then
            With 整治方案TextBox
                .Text = "必填"
                .SelectAll()
                .BackColor = Color.LightYellow
                .Focus()
            End With
        Else
            With 整治方案TextBox
                .BackColor = Color.White
            End With
        End If
    End Sub
 
    
    Private Sub 计划时间DateTimePicker_CloseUp(sender As Object, e As EventArgs) Handles 计划时间DateTimePicker.CloseUp
        Me.TextBox1.Text = Me.计划时间DateTimePicker.Value
    End Sub
    Private Sub 发现问题时间DateTimePicker_CloseUp(sender As Object, e As EventArgs) Handles 发现问题时间DateTimePicker.CloseUp
        Me.TextBox3.Text = Me.发现问题时间DateTimePicker.Value
    End Sub
    Private Sub 录入时间DateTimePicker_CloseUp(sender As Object, e As EventArgs) Handles 录入时间DateTimePicker.CloseUp
        Me.TextBox2.Text = Me.录入时间DateTimePicker.Value
    End Sub 
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        '计划
        If IsDate(Me.TextBox1.Text) Then
            Me.计划时间DateTimePicker.Value = Me.TextBox1.Text
        End If
        Me.计划时间DateTimePicker.Focus()
        My.Computer.Keyboard.SendKeys("%{DOWN}")
    End Sub
    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        '录入
        If IsDate(TextBox2.Text) Then
            录入时间DateTimePicker.Value = TextBox2.Text
        End If
        Me.录入时间DateTimePicker.Focus()
        My.Computer.Keyboard.SendKeys("%{DOWN}")
    End Sub

    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        '发现
        If IsDate(TextBox3.Text) Then
            Me.发现问题时间DateTimePicker.Value = TextBox3.Text
        End If
        Me.发现问题时间DateTimePicker.Focus()
        My.Computer.Keyboard.SendKeys("%{DOWN}")
    End Sub

 
    Private Sub T_wtjuBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles T_wtjuBindingSource.CurrentChanged
        If waIsAdd = False Then
            Me.站名ComboBox.Text = 站名ComboBox.Tag
        Else
            Me.站名ComboBox.Text = zhanName
        End If
        Me.ToolStripLabel1.Text = ""
    End Sub

    Private Sub 站名ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles 站名ComboBox.SelectedIndexChanged
        zhanName = 站名ComboBox.Text
        站名ComboBox.Tag = zhanName
        If zhanName = "安康" Then
            Me.天窗需求ComboBox.Items.Clear()
            Me.天窗需求ComboBox.Items.AddRange(ak_req)
        End If
        If zhanName = "石庙沟" Then
            Me.天窗需求ComboBox.Items.Clear()
            Me.天窗需求ComboBox.Items.AddRange(smg_req)
        End If
        If BindingNavigatorAddNewItem.Enabled = True Then
            Me.T_WTJUTableAdapter.FillBy_zm_lr(JHBDataSet.T_WTJU, zhanName)
        End If
    End Sub
  
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If Me.站名ComboBox.Text = "" And Me.站名ComboBox.Text = "选择站" Then
            Me.站名ComboBox.Focus()
            Me.ToolStripLabel1.Text = "站名未选!"
            Exit Sub
        Else
            站名ComboBox.Tag = 站名ComboBox.Text
        End If
        If 设备名称TextBox.Text = "" Then
            设备名称TextBox.Focus()
            Me.ToolStripLabel1.Text = "设备名称没填写,数据不完整!"
            Exit Sub
        End If
        If 存在问题TextBox.Text = "" Then
            存在问题TextBox.Focus()
            Me.ToolStripLabel1.Text = "存在问题没填写,数据不完整"
            Exit Sub
        End If
        If 整治方案TextBox.Text = "" Then
            整治方案TextBox.Focus()
            Me.ToolStripLabel1.Text = "整治方案未填写,数据不完整"
            Exit Sub
        End If
        Try
            Me.T_wtjuBindingSource.EndEdit()
            Me.T_WTJUTableAdapter.Update(JHBDataSet.T_WTJU)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.BindingNavigatorAddNewItem.Enabled = True
        Me.ToolStripButton1.Enabled = False
        waIsAdd = False
        Me.BindingNavigatorMoveFirstItem.Visible = True
        Me.BindingNavigatorMoveLastItem.Visible = True
        Me.BindingNavigatorMoveNextItem.Visible = True
        Me.BindingNavigatorMovePreviousItem.Visible = True
        If BindingNavigatorAddNewItem.Enabled = True Then
            Me.T_WTJUTableAdapter.FillBy_zm_lr(JHBDataSet.T_WTJU, zhanName)
            Me.T_wtjuBindingSource.MoveLast()
        End If
        Me.ToolStripLabel1.Text = "该数据已经录入!"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        wacanEdit = CheckBox1.Checked
        'MsgBox(wacanEdit)
        If wacanEdit = True Then
            Me.T_wtjuBindingNavigatorSaveItem.Enabled = False
        Else
            Me.T_wtjuBindingNavigatorSaveItem.Enabled = True
        End If
    End Sub
End Class
