<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.功能ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.问题录入ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.问题派发ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.问题销记ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.生成报表ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.信息浏览ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.总览问题库ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.需派发问题ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.销记信息ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.搜索ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.其他ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.严重程度ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.不需配合问题ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.登销ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.报表ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.快速销记入口ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.后台ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JHBDataSet = New wapJHB.JHBDataSet()
        Me.T_WTJUTableAdapter = New wapJHB.JHBDataSetTableAdapters.T_WTJUTableAdapter()
        Me.T_wtjuBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.T_wtjuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.T_wtjuDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.天窗需求 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.计划时间 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.录入时间 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.销记时间 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.是否需要发通知单 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TableAdapterManager = New wapJHB.JHBDataSetTableAdapters.TableAdapterManager()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.JHBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_wtjuBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.T_wtjuBindingNavigator.SuspendLayout()
        CType(Me.T_wtjuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_wtjuDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.功能ToolStripMenuItem, Me.信息浏览ToolStripMenuItem, Me.ToolStripMenuItem1, Me.后台ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1258, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '功能ToolStripMenuItem
        '
        Me.功能ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.问题录入ToolStripMenuItem, Me.问题派发ToolStripMenuItem, Me.问题销记ToolStripMenuItem, Me.生成报表ToolStripMenuItem, Me.ToolStripSeparator1, Me.退出ToolStripMenuItem})
        Me.功能ToolStripMenuItem.Name = "功能ToolStripMenuItem"
        Me.功能ToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.功能ToolStripMenuItem.Text = "功能"
        '
        '问题录入ToolStripMenuItem
        '
        Me.问题录入ToolStripMenuItem.Name = "问题录入ToolStripMenuItem"
        Me.问题录入ToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.问题录入ToolStripMenuItem.Text = "问题录入"
        '
        '问题派发ToolStripMenuItem
        '
        Me.问题派发ToolStripMenuItem.Name = "问题派发ToolStripMenuItem"
        Me.问题派发ToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.问题派发ToolStripMenuItem.Text = "问题派发"
        '
        '问题销记ToolStripMenuItem
        '
        Me.问题销记ToolStripMenuItem.Name = "问题销记ToolStripMenuItem"
        Me.问题销记ToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.问题销记ToolStripMenuItem.Text = "问题销记"
        '
        '生成报表ToolStripMenuItem
        '
        Me.生成报表ToolStripMenuItem.Name = "生成报表ToolStripMenuItem"
        Me.生成报表ToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.生成报表ToolStripMenuItem.Text = "生成报表"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(141, 6)
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        '信息浏览ToolStripMenuItem
        '
        Me.信息浏览ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.总览问题库ToolStripMenuItem, Me.需派发问题ToolStripMenuItem, Me.销记信息ToolStripMenuItem, Me.搜索ToolStripMenuItem, Me.其他ToolStripMenuItem})
        Me.信息浏览ToolStripMenuItem.Name = "信息浏览ToolStripMenuItem"
        Me.信息浏览ToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.信息浏览ToolStripMenuItem.Text = "信息浏览"
        '
        '总览问题库ToolStripMenuItem
        '
        Me.总览问题库ToolStripMenuItem.Name = "总览问题库ToolStripMenuItem"
        Me.总览问题库ToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.总览问题库ToolStripMenuItem.Text = "问题记录"
        '
        '需派发问题ToolStripMenuItem
        '
        Me.需派发问题ToolStripMenuItem.Name = "需派发问题ToolStripMenuItem"
        Me.需派发问题ToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.需派发问题ToolStripMenuItem.Text = "派发记录"
        '
        '销记信息ToolStripMenuItem
        '
        Me.销记信息ToolStripMenuItem.Name = "销记信息ToolStripMenuItem"
        Me.销记信息ToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.销记信息ToolStripMenuItem.Text = "销记信息"
        '
        '搜索ToolStripMenuItem
        '
        Me.搜索ToolStripMenuItem.Name = "搜索ToolStripMenuItem"
        Me.搜索ToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.搜索ToolStripMenuItem.Text = "搜索"
        '
        '其他ToolStripMenuItem
        '
        Me.其他ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.严重程度ToolStripMenuItem, Me.不需配合问题ToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.其他ToolStripMenuItem.Name = "其他ToolStripMenuItem"
        Me.其他ToolStripMenuItem.Size = New System.Drawing.Size(144, 26)
        Me.其他ToolStripMenuItem.Text = "其他"
        '
        '严重程度ToolStripMenuItem
        '
        Me.严重程度ToolStripMenuItem.Name = "严重程度ToolStripMenuItem"
        Me.严重程度ToolStripMenuItem.Size = New System.Drawing.Size(174, 26)
        Me.严重程度ToolStripMenuItem.Text = "严重程度"
        '
        '不需配合问题ToolStripMenuItem
        '
        Me.不需配合问题ToolStripMenuItem.Name = "不需配合问题ToolStripMenuItem"
        Me.不需配合问题ToolStripMenuItem.Size = New System.Drawing.Size(174, 26)
        Me.不需配合问题ToolStripMenuItem.Text = "不需配合问题"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(174, 26)
        Me.ToolStripMenuItem2.Text = "..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.登销ToolStripMenuItem, Me.报表ToolStripMenuItem, Me.快速销记入口ToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(51, 24)
        Me.ToolStripMenuItem1.Text = "其他"
        '
        '登销ToolStripMenuItem
        '
        Me.登销ToolStripMenuItem.Name = "登销ToolStripMenuItem"
        Me.登销ToolStripMenuItem.Size = New System.Drawing.Size(174, 26)
        Me.登销ToolStripMenuItem.Text = "登销"
        '
        '报表ToolStripMenuItem
        '
        Me.报表ToolStripMenuItem.Name = "报表ToolStripMenuItem"
        Me.报表ToolStripMenuItem.Size = New System.Drawing.Size(174, 26)
        Me.报表ToolStripMenuItem.Text = "报表"
        '
        '快速销记入口ToolStripMenuItem
        '
        Me.快速销记入口ToolStripMenuItem.Name = "快速销记入口ToolStripMenuItem"
        Me.快速销记入口ToolStripMenuItem.Size = New System.Drawing.Size(174, 26)
        Me.快速销记入口ToolStripMenuItem.Text = "快速销记入口"
        '
        '后台ToolStripMenuItem
        '
        Me.后台ToolStripMenuItem.Name = "后台ToolStripMenuItem"
        Me.后台ToolStripMenuItem.Size = New System.Drawing.Size(51, 24)
        Me.后台ToolStripMenuItem.Text = "说明"
        '
        'JHBDataSet
        '
        Me.JHBDataSet.DataSetName = "JHBDataSet"
        Me.JHBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'T_WTJUTableAdapter
        '
        Me.T_WTJUTableAdapter.ClearBeforeFill = True
        '
        'T_wtjuBindingNavigator
        '
        Me.T_wtjuBindingNavigator.AddNewItem = Nothing
        Me.T_wtjuBindingNavigator.BindingSource = Me.T_wtjuBindingSource
        Me.T_wtjuBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.T_wtjuBindingNavigator.DeleteItem = Nothing
        Me.T_wtjuBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.T_wtjuBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.T_wtjuBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.T_wtjuBindingNavigator.Location = New System.Drawing.Point(0, 722)
        Me.T_wtjuBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.T_wtjuBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.T_wtjuBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.T_wtjuBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.T_wtjuBindingNavigator.Name = "T_wtjuBindingNavigator"
        Me.T_wtjuBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.T_wtjuBindingNavigator.Size = New System.Drawing.Size(1258, 27)
        Me.T_wtjuBindingNavigator.TabIndex = 1
        Me.T_wtjuBindingNavigator.Text = "BindingNavigator1"
        '
        'T_wtjuBindingSource
        '
        Me.T_wtjuBindingSource.DataMember = "t_wtju"
        Me.T_wtjuBindingSource.DataSource = Me.JHBDataSet
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(38, 24)
        Me.BindingNavigatorCountItem.Text = "/ {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "总项数"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "移到第一条记录"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "移到上一条记录"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "当前位置"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "移到下一条记录"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "移到最后一条记录"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'T_wtjuDataGridView
        '
        Me.T_wtjuDataGridView.AllowUserToAddRows = False
        Me.T_wtjuDataGridView.AllowUserToDeleteRows = False
        Me.T_wtjuDataGridView.AutoGenerateColumns = False
        Me.T_wtjuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.T_wtjuDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn12, Me.天窗需求, Me.计划时间, Me.录入时间, Me.销记时间, Me.DataGridViewCheckBoxColumn1, Me.是否需要发通知单})
        Me.T_wtjuDataGridView.DataSource = Me.T_wtjuBindingSource
        Me.T_wtjuDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.T_wtjuDataGridView.Location = New System.Drawing.Point(0, 28)
        Me.T_wtjuDataGridView.Name = "T_wtjuDataGridView"
        Me.T_wtjuDataGridView.ReadOnly = True
        Me.T_wtjuDataGridView.RowTemplate.Height = 27
        Me.T_wtjuDataGridView.Size = New System.Drawing.Size(1258, 694)
        Me.T_wtjuDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "站名"
        Me.DataGridViewTextBoxColumn13.HeaderText = "站名"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "设备名称"
        Me.DataGridViewTextBoxColumn2.HeaderText = "设备名称"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "存在问题"
        Me.DataGridViewTextBoxColumn3.HeaderText = "存在问题"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 400
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "发现问题时间"
        DataGridViewCellStyle1.Format = "M"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn10.HeaderText = "发现问题时间"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "问题等级"
        Me.DataGridViewTextBoxColumn12.HeaderText = "问题等级"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        '天窗需求
        '
        Me.天窗需求.DataPropertyName = "天窗需求"
        Me.天窗需求.HeaderText = "天窗需求"
        Me.天窗需求.Name = "天窗需求"
        Me.天窗需求.ReadOnly = True
        Me.天窗需求.Width = 180
        '
        '计划时间
        '
        Me.计划时间.DataPropertyName = "计划时间"
        DataGridViewCellStyle2.Format = "M"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.计划时间.DefaultCellStyle = DataGridViewCellStyle2
        Me.计划时间.HeaderText = "计划时间"
        Me.计划时间.Name = "计划时间"
        Me.计划时间.ReadOnly = True
        Me.计划时间.Visible = False
        '
        '录入时间
        '
        Me.录入时间.DataPropertyName = "录入时间"
        DataGridViewCellStyle3.Format = "M"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.录入时间.DefaultCellStyle = DataGridViewCellStyle3
        Me.录入时间.HeaderText = "录入时间"
        Me.录入时间.Name = "录入时间"
        Me.录入时间.ReadOnly = True
        Me.录入时间.Visible = False
        '
        '销记时间
        '
        Me.销记时间.DataPropertyName = "销记时间"
        DataGridViewCellStyle4.Format = "M"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.销记时间.DefaultCellStyle = DataGridViewCellStyle4
        Me.销记时间.HeaderText = "销记时间"
        Me.销记时间.Name = "销记时间"
        Me.销记时间.ReadOnly = True
        Me.销记时间.Visible = False
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "销记"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "销记"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        '是否需要发通知单
        '
        Me.是否需要发通知单.DataPropertyName = "是否需要发通知单"
        Me.是否需要发通知单.HeaderText = "是否需要发通知单"
        Me.是否需要发通知单.Name = "是否需要发通知单"
        Me.是否需要发通知单.ReadOnly = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.t_pfjuTableAdapter = Nothing
        Me.TableAdapterManager.T_WTJUTableAdapter = Nothing
        Me.TableAdapterManager.tzdContentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = wapJHB.JHBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1258, 749)
        Me.Controls.Add(Me.T_wtjuDataGridView)
        Me.Controls.Add(Me.T_wtjuBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "结合部管理"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.JHBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_wtjuBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.T_wtjuBindingNavigator.ResumeLayout(False)
        Me.T_wtjuBindingNavigator.PerformLayout()
        CType(Me.T_wtjuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_wtjuDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents 功能ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 问题录入ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 问题派发ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 问题销记ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 生成报表ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 信息浏览ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 总览问题库ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 需派发问题ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 销记信息ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 搜索ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 其他ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 严重程度ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 不需配合问题ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 后台ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JHBDataSet As wapJHB.JHBDataSet
    Friend WithEvents T_wtjuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_WTJUTableAdapter As wapJHB.JHBDataSetTableAdapters.T_WTJUTableAdapter
    Friend WithEvents TableAdapterManager As wapJHB.JHBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents T_wtjuBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents T_wtjuDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 登销ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 报表ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 快速销记入口ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 天窗需求 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 计划时间 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 录入时间 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 销记时间 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents 是否需要发通知单 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
