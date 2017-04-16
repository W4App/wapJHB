Imports Microsoft.Reporting.WinForms
Public Class Form4
    Const per_date As Date = #1/1/2000#
    Dim zName As String
    Dim pfDate As Date
    Dim rpzzFlag As Boolean
    Dim rptzdFlag As Boolean
    Dim rpv1_ok As Boolean  '报表1生成标志.  因为有参数传入,如果没有生成, 则导出处理抛出异常
    Dim rpv2_ok As Boolean  '报表2生成标志
    Dim strTzdContent As String


    Private Sub T_pfjuBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.T_pfjuBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JHBDataSet)
    End Sub

    Private Sub Form4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Owner.Show()
        Me.Dispose()
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.tzdContentTableAdapter.Fill(Me.JHBDataSet.tzdContent)
        Me.ReportViewer2.RefreshReport()
        rptzdFlag = False
        rpzzFlag = False
        Me.ReportViewer1.Visible = False
        Me.ReportViewer2.Visible = False
        rpv1_ok = False
        rpv2_ok = False

        'debug~
        'zName = "安康"
        ' pfDate = #11/22/2016#
    End Sub


    Private Sub 发放日期DateTimePicker_CloseUp(sender As Object, e As EventArgs) Handles 发放日期DateTimePicker.CloseUp
        pfDAte = 发放日期DateTimePicker.Text
        Me.ToolStripTextBox1.Text = pfDAte
        Me.发放日期DateTimePicker.Visible = False
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        With Me.发放日期DateTimePicker
            .Top = ToolStrip1.Top - 28
            .Left = ToolStrip1.Left + 196
            .Visible = True
            .Show()
            .Focus()
        End With
        My.Computer.Keyboard.SendKeys("%{DOWN}")
    End Sub
    Private Sub ToolStripComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        zName = ToolStripComboBox1.Text
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If pfDAte < per_date And IsNothing(zName) = True Then
            ToolStripLabel4.ForeColor = Color.Red
            ToolStripLabel4.Text = "站名或时间未选定!"
            Timer1.Enabled = True
            Exit Sub
        End If
        '  If rptzdFlag = True Then
        Me.ReportViewer2.Dock = DockStyle.None
        Me.ReportViewer2.Visible = False
        Me.TzdContentDataGridView.Visible = False

        'End If
        Me.ReportViewer1.Visible = True
        Try
            Me.tzdContentTableAdapter.FillBy_pfDate_zm(JHBDataSet.tzdContent, pfDate, zName)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim rpt1 As New ReportParameterCollection()
        Dim t1 As New ReportParameter("zhanName", zName)
        Dim t2 As New ReportParameter("pfDate", Format(pfDate, "yyyy年M月dd日"))
        Dim t3 As New ReportParameter("Zou", mdl.get_wk(pfDate).ToString + "周")
        rpt1.Add(t1)
        rpt1.Add(t2)
        rpt1.Add(t3)
        Me.ReportViewer1.LocalReport.SetParameters(rpt1)
        Me.ReportViewer1.Dock = DockStyle.Fill
        Me.ReportViewer1.RefreshReport()
        rpzzFlag = True
        rpv1_ok = True
        Me.TzdContentDataGridView.Focus()

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click    
        If pfDAte < per_date And IsNothing(zName) = True Then
            ToolStripLabel4.ForeColor = Color.Red
            ToolStripLabel4.Text = "站名或时间未选定!"
            Timer1.Enabled = True
            Exit Sub
        End If
        'If rpzzFlag = True Then
        Me.ReportViewer1.Dock = DockStyle.None
        Me.ReportViewer1.Visible = False
        Me.TzdContentDataGridView.Visible = False
        'End If
        Me.ReportViewer2.Visible = True
        Dim rpt1 As New ReportParameterCollection()
        Dim t1 As New ReportParameter("zhanName", zName)
        Dim t2 As New ReportParameter("pfDate", Format(pfDate, "yyyy年M月dd日"))
        Dim tmpStr = getTZDstr(zName, pfDate)        
        Dim t3 As New ReportParameter("StrTZD", tmpStr)
        rpt1.Add(t1)
        rpt1.Add(t2)
        rpt1.Add(t3)
        Me.ReportViewer2.LocalReport.SetParameters(rpt1)
        Me.ReportViewer2.Dock = DockStyle.Fill
        Me.ReportViewer2.RefreshReport()
        rptzdFlag = True
        rpv2_ok = True
        Me.TzdContentDataGridView.Focus()

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Me.ReportViewer1.Visible = False
        Me.ReportViewer2.Visible = False
        Me.TzdContentDataGridView.Visible = True
        Me.TzdContentDataGridView.Focus()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        Try
            Me.tzdContentTableAdapter.FillBy_pfDate_zm(JHBDataSet.tzdContent, pfDate, zName)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.TzdContentDataGridView.Focus()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripLabel4.ForeColor = Color.Black
        ToolStripLabel4.Text = "信息:"
        Timer1.Stop()
    End Sub
    Function renderReport2003(fsNa As String, repView As Integer) As String

        Dim warns As WinForms.Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mime As String = Nothing
        Dim encode As String = Nothing
        Dim ext As String = Nothing
        Dim outbytes As Byte()
        If repView = 1 And rpv1_ok = True Then
            outbytes = Me.ReportViewer1.LocalReport.Render("Excel", Nothing, mime, encode, ext, streamids, warns)
            Dim fs As New IO.FileStream(fsNa, IO.FileMode.Create)
            fs.Write(outbytes, 0, outbytes.Length)
            fs.Close()
        End If
        If repView = 2 And rpv2_ok = True Then
            outbytes = Me.ReportViewer2.LocalReport.Render("Word", Nothing, mime, encode, ext, streamids, warns)
            Dim fs As New IO.FileStream(fsNa, IO.FileMode.Create)
            fs.Write(outbytes, 0, outbytes.Length)
            fs.Close()
        End If
        Return fsNa
    End Function
    Private Sub 功能ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 整治ToolStripMenuItem.Click
        'MsgBox("xls")
        If rpv1_ok = False Then
            ToolStripLabel4.ForeColor = Color.Red
            ToolStripLabel4.Text = "整治表未生成,不能导出文件"
            Timer1.Enabled = True
            Exit Sub
        End If
        Dim pfName As String
        Dim fsName As String
        Dim result As Windows.Forms.DialogResult
        pfName = "车工电联合检查整治表(" + Format(pfDate, "yyyy年M月dd日") + ")" + "(第" + mdl.get_wk(pfDate).ToString + "周)"
        Me.SaveFileDialog1.Filter = "Excel2003(*.xls)|*.xls"
        Me.SaveFileDialog1.FileName = pfName
        result = Me.SaveFileDialog1.ShowDialog()
        fsName = Me.SaveFileDialog1.FileName
        If result = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        Else
            renderReport2003(fsName, 1)
        End If
    End Sub

    Private Sub 通知单ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 通知单ToolStripMenuItem.Click
        'MsgBox("doc")
        If rpv2_ok = False Then
            ToolStripLabel4.ForeColor = Color.Red
            ToolStripLabel4.Text = "通知单未生成,不能导出文件"
            Timer1.Enabled = True
            Exit Sub
        End If
        Dim pfName As String
        Dim fsName As String
        Dim result As Windows.Forms.DialogResult
        pfName = "车工电配合作业通知单(" + Format(pfDate, "yyyy年M月dd日") + ")" + "(第" + mdl.get_wk(pfDate).ToString + "周)"
        Me.SaveFileDialog1.Filter = "Word2003(*.doc)|*.doc"
        Me.SaveFileDialog1.FileName = pfName
        result = Me.SaveFileDialog1.ShowDialog()
        fsName = Me.SaveFileDialog1.FileName
        If result = 2 Then           
            Exit Sub
        Else
            renderReport2003(fsName, 2)
        End If
    End Sub

    Private Sub TzdContentDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TzdContentDataGridView.CellContentClick

    End Sub
    Private Function getTZDstr(zm As String, riqi As Date) As String
        Dim str = ""
        Dim k As Integer
        Dim tzdSet As DataTable = New JHBDataSet.tzdContentDataTable()
        Dim tzdRow As DataRow
        tzdSet = Me.tzdContentTableAdapter.GetDataBy_pfDate_zm(riqi, zm)
        For i As Integer = 0 To tzdSet.Rows.Count - 1
            k = i + 1
            tzdRow = tzdSet.Rows(i)
            str = str + k.ToString("00") + ". " + "[" + tzdRow.Item("设备名称").ToString + "] " + tzdRow.Item("内容").ToString + vbCrLf
        Next i
        tzdSet = Nothing
        tzdRow = Nothing
        Return str
    End Function
End Class