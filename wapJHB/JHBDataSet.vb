Partial Class JHBDataSet
   

    Partial Class t_pfjuDataTable

    End Class

    Partial Class T_WTJUDataTable

        Private Sub T_WTJUDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.计划时间Column.ColumnName) Then
                '在此处添加用户代码
            End If

        End Sub

    End Class

End Class

Namespace JHBDataSetTableAdapters
    
    Partial Class T_WTJUTableAdapter

    End Class

    Partial Public Class t_pfjuTableAdapter
    End Class
End Namespace
