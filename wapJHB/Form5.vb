Public Class Form5

    Private Sub 销记信息ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 销记信息ToolStripMenuItem.Click
        My.Forms.FormXJ.Show(Me)
        Me.Hide()
    End Sub

    Private Sub 问题录入ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 问题录入ToolStripMenuItem.Click
        My.Forms.Form1.Show(Me)
        Me.Hide()
    End Sub

    Private Sub 问题派发ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 问题派发ToolStripMenuItem.Click
        My.Forms.Form2.Show(Me)
        Me.Hide()
    End Sub

    Private Sub 问题销记ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 问题销记ToolStripMenuItem.Click
        My.Forms.Form3.Show(Me)
        Me.Hide()
    End Sub

    Private Sub 生成报表ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 生成报表ToolStripMenuItem.Click
        My.Forms.Form4.Show(Me)
        Me.Hide()
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        Me.Dispose()

    End Sub

    Private Sub T_wtjuBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.T_wtjuBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JHBDataSet)

    End Sub

    Private Sub Form5_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.T_wtjuDataGridView.Refresh()
        Me.MenuStrip1.Refresh()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO:  这行代码将数据加载到表“JHBDataSet.T_WTJU”中。您可以根据需要移动或删除它。
        Me.T_WTJUTableAdapter.Fill(Me.JHBDataSet.T_WTJU)
        Me.T_wtjuDataGridView.Refresh()
    End Sub

    Private Sub 后台ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 后台ToolStripMenuItem.Click
        'My.Forms.Form说明.Show(Me)

    End Sub

    Private Sub 总览问题库ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 总览问题库ToolStripMenuItem.Click
        Dim waTbl As New DataTable
        Dim waBind As New BindingSource()

        'Me.T_wtjuDataGridView.DataSource = Nothing
        Me.T_wtjuDataGridView.AutoGenerateColumns = True

        waTbl = Me.T_WTJUTableAdapter.GetDataBy_4_ZLWT()
        waBind.DataSource = waTbl
        Me.T_wtjuDataGridView.DataSource = waBind
        With Me.T_wtjuDataGridView
            .Columns("整治情况").Visible = False
            .Columns("完成情况").Visible = False
            .Columns("参加整治负责人签字").Visible = False
            .Columns("终止").Visible = False
            .Columns("留存").Visible = False
            .Columns("销记时间").Visible = False
            .Columns("计划时间").Visible = True

        End With
        Me.T_wtjuDataGridView.Refresh()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub 登销ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 登销ToolStripMenuItem.Click
        My.Forms.Form6.Show(Me)
        Me.Hide()
    End Sub

    Private Sub 报表ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 报表ToolStripMenuItem.Click
        My.Forms.Form7.Show(Me)
        Me.Hide()
    End Sub

    Private Sub 需派发问题ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 需派发问题ToolStripMenuItem.Click
        My.Forms.FormPF.Show(Me)
        Me.Hide()
    End Sub

    Private Sub 快速销记入口ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 快速销记入口ToolStripMenuItem.Click
        My.Forms.FormKX.Show(Me)
        Me.Hide()
    End Sub
End Class