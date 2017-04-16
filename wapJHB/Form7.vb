Public Class Form7
    Const conQi As Date = #1/1/2000#
    Const conZhi As Date = #1/1/2025#
    Dim waMonth As Date

    Dim rp_ok As Boolean

    Private Sub T_wtjuBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Form7_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Owner.Show()
        Me.Dispose()
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
 

        Me.T_WTJUTableAdapter.FillBy_All(Me.JHBDataSet.T_WTJU, conQi, conZhi)

        Me.ReportViewer1.RefreshReport()
        rp_ok = False
    End Sub
    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If Me.ToolStripTextBox1.Text = "" And Me.ToolStripTextBox2.Text = "" Then
            Me.T_WTJUTableAdapter.FillBy_All(Me.JHBDataSet.T_WTJU, conQi, conZhi)
        Else
            Me.T_WTJUTableAdapter.ClearBeforeFill = True
            Debug.WriteLine("W_>> 重新载入筛选表")
            Me.T_WTJUTableAdapter.FillBy_All(Me.JHBDataSet.T_WTJU, Me.ToolStripTextBox1.Text, Me.ToolStripTextBox2.Text)
            Me.ReportViewer1.RefreshReport()  ' 强制刷新数据,实现数据筛选
            ' Me.ReportViewer1.LocalReport.DataSources.Clear()
            'Dim repS As New ReportDataSource()
            'repS.Name = "DataSet1"
            'repS.Value = Me.T_wtjuBindingSource
            'Me.ReportViewer1.LocalReport.DataSources.Add(repS)
            'Me.ReportViewer1.RefreshReport()
        End If
        Me.ReportViewer1.Dock = DockStyle.Fill
        rp_ok = True
    End Sub

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.ReportViewer1.Dock = DockStyle.None
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Me.Validate()
        Me.T_wtjuBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JHBDataSet)
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click
        With Me.DateTimePicker1
            .Visible = True
            .Show()
            .Focus()
        End With
        My.Computer.Keyboard.SendKeys("%{DOWN}")
    End Sub

    Private Sub ToolStripTextBox2_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox2.Click
        With Me.DateTimePicker2
            .Visible = True
            .Show()
            .Focus()
        End With
        My.Computer.Keyboard.SendKeys("%{DOWN}")
    End Sub

    Private Sub DateTimePicker1_CloseUp(sender As Object, e As EventArgs) Handles DateTimePicker1.CloseUp
        Me.ToolStripTextBox1.Text = Me.DateTimePicker1.Text
        Me.DateTimePicker1.Visible = False
    End Sub

    Private Sub DateTimePicker2_CloseUp(sender As Object, e As EventArgs) Handles DateTimePicker2.CloseUp
        Me.ToolStripTextBox2.Text = Me.DateTimePicker2.Text
        waMonth = Me.DateTimePicker2.Value
        Me.DateTimePicker2.Visible = False
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Dim warns As WinForms.Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mime As String = Nothing
        Dim encode As String = Nothing
        Dim ext As String = Nothing
        Dim outbytes As Byte()

        If rp_ok = False Then
            MsgBox("报表未生成,不能导出文件")
            Exit Sub
        End If
        Dim pfName As String
        Dim fsName As String
        Dim result As Windows.Forms.DialogResult
        pfName = "工区质检报表(" + Format(waMonth, "yyyy年M月") + ")"

        Me.SaveFileDialog1.FileName = pfName
        Me.SaveFileDialog1.Filter = "Excel2003(*.xls)|*.xls"
        result = Me.SaveFileDialog1.ShowDialog()
        fsName = Me.SaveFileDialog1.FileName
        If result = 2 Then
            Exit Sub
        Else
            outbytes = Me.ReportViewer1.LocalReport.Render("Excel", Nothing, mime, encode, ext, streamids, warns)
            Dim fs As New IO.FileStream(fsName, IO.FileMode.Create)
            fs.Write(outbytes, 0, outbytes.Length)
            fs.Close()
        End If
    End Sub
End Class