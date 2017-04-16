Public Class FormKX

    Private Sub T_wtjuBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles T_wtjuBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.T_wtjuBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.JHBDataSet)

    End Sub

    Private Sub FormKX_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Owner.Show()
        Me.Dispose()
    End Sub

    Private Sub FormKX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO:  这行代码将数据加载到表“JHBDataSet.T_WTJU”中。您可以根据需要移动或删除它。
        Me.T_WTJUTableAdapter.Fill(Me.JHBDataSet.T_WTJU)

    End Sub
End Class