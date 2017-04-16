<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim 问题编号Label As System.Windows.Forms.Label
        Dim 设备名称Label As System.Windows.Forms.Label
        Dim 存在问题Label As System.Windows.Forms.Label
        Dim 整治方案Label As System.Windows.Forms.Label
        Dim 整治情况Label As System.Windows.Forms.Label
        Dim 完成情况Label As System.Windows.Forms.Label
        Dim 参加整治人签字Label As System.Windows.Forms.Label
        Dim 销记时间Label As System.Windows.Forms.Label
        Dim 站名Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.T_wtjuXJ = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.T_wtjuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JHBDataSet = New wapJHB.JHBDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.T_wtjuBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripLabel()
        Me.问题编号Label1 = New System.Windows.Forms.Label()
        Me.设备名称Label1 = New System.Windows.Forms.Label()
        Me.存在问题TextBox = New System.Windows.Forms.TextBox()
        Me.整治方案TextBox = New System.Windows.Forms.TextBox()
        Me.整治情况TextBox = New System.Windows.Forms.TextBox()
        Me.完成情况TextBox = New System.Windows.Forms.TextBox()
        Me.参加整治负责人签字TextBox = New System.Windows.Forms.TextBox()
        Me.T_pfjuDataGridView = New System.Windows.Forms.DataGridView()
        Me.派发日期DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.问题编号DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.设备名称 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.存在问题 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.本次派发销记状态 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.天窗需求 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.计划整治时间DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.站名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.派发记录IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T_pfjuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.销记时间TextBox = New System.Windows.Forms.TextBox()
        Me.xjDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.销记CheckBox = New System.Windows.Forms.CheckBox()
        Me.站名ComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TpfjuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T_WTJUTableAdapter = New wapJHB.JHBDataSetTableAdapters.T_WTJUTableAdapter()
        Me.TableAdapterManager = New wapJHB.JHBDataSetTableAdapters.TableAdapterManager()
        Me.T_pfjuTableAdapter = New wapJHB.JHBDataSetTableAdapters.t_pfjuTableAdapter()
        问题编号Label = New System.Windows.Forms.Label()
        设备名称Label = New System.Windows.Forms.Label()
        存在问题Label = New System.Windows.Forms.Label()
        整治方案Label = New System.Windows.Forms.Label()
        整治情况Label = New System.Windows.Forms.Label()
        完成情况Label = New System.Windows.Forms.Label()
        参加整治人签字Label = New System.Windows.Forms.Label()
        销记时间Label = New System.Windows.Forms.Label()
        站名Label = New System.Windows.Forms.Label()
        CType(Me.T_wtjuXJ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.T_wtjuXJ.SuspendLayout()
        CType(Me.T_wtjuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JHBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_pfjuDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_pfjuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TpfjuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '问题编号Label
        '
        问题编号Label.AutoSize = True
        问题编号Label.Location = New System.Drawing.Point(122, 155)
        问题编号Label.Name = "问题编号Label"
        问题编号Label.Size = New System.Drawing.Size(75, 15)
        问题编号Label.TabIndex = 1
        问题编号Label.Text = "问题编号:"
        '
        '设备名称Label
        '
        设备名称Label.AutoSize = True
        设备名称Label.Location = New System.Drawing.Point(122, 195)
        设备名称Label.Name = "设备名称Label"
        设备名称Label.Size = New System.Drawing.Size(75, 15)
        设备名称Label.TabIndex = 3
        设备名称Label.Text = "设备名称:"
        '
        '存在问题Label
        '
        存在问题Label.AutoSize = True
        存在问题Label.Location = New System.Drawing.Point(122, 236)
        存在问题Label.Name = "存在问题Label"
        存在问题Label.Size = New System.Drawing.Size(75, 15)
        存在问题Label.TabIndex = 5
        存在问题Label.Text = "存在问题:"
        '
        '整治方案Label
        '
        整治方案Label.AutoSize = True
        整治方案Label.Location = New System.Drawing.Point(122, 350)
        整治方案Label.Name = "整治方案Label"
        整治方案Label.Size = New System.Drawing.Size(75, 15)
        整治方案Label.TabIndex = 7
        整治方案Label.Text = "整治方案:"
        '
        '整治情况Label
        '
        整治情况Label.AutoSize = True
        整治情况Label.Location = New System.Drawing.Point(122, 409)
        整治情况Label.Name = "整治情况Label"
        整治情况Label.Size = New System.Drawing.Size(75, 15)
        整治情况Label.TabIndex = 9
        整治情况Label.Text = "整治情况:"
        '
        '完成情况Label
        '
        完成情况Label.AutoSize = True
        完成情况Label.Location = New System.Drawing.Point(122, 463)
        完成情况Label.Name = "完成情况Label"
        完成情况Label.Size = New System.Drawing.Size(75, 15)
        完成情况Label.TabIndex = 11
        完成情况Label.Text = "完成情况:"
        '
        '参加整治人签字Label
        '
        参加整治人签字Label.AutoSize = True
        参加整治人签字Label.Location = New System.Drawing.Point(122, 507)
        参加整治人签字Label.Name = "参加整治人签字Label"
        参加整治人签字Label.Size = New System.Drawing.Size(90, 15)
        参加整治人签字Label.TabIndex = 13
        参加整治人签字Label.Text = "整治负责人:"
        '
        '销记时间Label
        '
        销记时间Label.AutoSize = True
        销记时间Label.Location = New System.Drawing.Point(122, 559)
        销记时间Label.Name = "销记时间Label"
        销记时间Label.Size = New System.Drawing.Size(75, 15)
        销记时间Label.TabIndex = 19
        销记时间Label.Text = "销记时间:"
        '
        '站名Label
        '
        站名Label.AutoSize = True
        站名Label.Location = New System.Drawing.Point(122, 106)
        站名Label.Name = "站名Label"
        站名Label.Size = New System.Drawing.Size(45, 15)
        站名Label.TabIndex = 22
        站名Label.Text = "站名:"
        '
        'T_wtjuXJ
        '
        Me.T_wtjuXJ.AddNewItem = Nothing
        Me.T_wtjuXJ.BindingSource = Me.T_wtjuBindingSource
        Me.T_wtjuXJ.CountItem = Me.BindingNavigatorCountItem
        Me.T_wtjuXJ.DeleteItem = Nothing
        Me.T_wtjuXJ.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.T_wtjuXJ.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.T_wtjuXJ.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripSeparator1, Me.T_wtjuBindingNavigatorSaveItem, Me.ToolStripSeparator2, Me.ToolStripLabel1, Me.ToolStripTextBox1})
        Me.T_wtjuXJ.Location = New System.Drawing.Point(0, 722)
        Me.T_wtjuXJ.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.T_wtjuXJ.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.T_wtjuXJ.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.T_wtjuXJ.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.T_wtjuXJ.Name = "T_wtjuXJ"
        Me.T_wtjuXJ.PositionItem = Me.BindingNavigatorPositionItem
        Me.T_wtjuXJ.Size = New System.Drawing.Size(1258, 27)
        Me.T_wtjuXJ.TabIndex = 0
        Me.T_wtjuXJ.Text = "BindingNavigator1"
        '
        'T_wtjuBindingSource
        '
        Me.T_wtjuBindingSource.DataMember = "t_wtju"
        Me.T_wtjuBindingSource.DataSource = Me.JHBDataSet
        '
        'JHBDataSet
        '
        Me.JHBDataSet.DataSetName = "JHBDataSet"
        Me.JHBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(20, 27)
        '
        'T_wtjuBindingNavigatorSaveItem
        '
        Me.T_wtjuBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.T_wtjuBindingNavigatorSaveItem.Enabled = False
        Me.T_wtjuBindingNavigatorSaveItem.Image = CType(resources.GetObject("T_wtjuBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.T_wtjuBindingNavigatorSaveItem.Name = "T_wtjuBindingNavigatorSaveItem"
        Me.T_wtjuBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.T_wtjuBindingNavigatorSaveItem.Text = "保存数据"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(30, 27)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(73, 24)
        Me.ToolStripLabel1.Text = "信息提示:"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(0, 24)
        '
        '问题编号Label1
        '
        Me.问题编号Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_wtjuBindingSource, "问题编号", True))
        Me.问题编号Label1.Location = New System.Drawing.Point(218, 156)
        Me.问题编号Label1.Name = "问题编号Label1"
        Me.问题编号Label1.Size = New System.Drawing.Size(153, 23)
        Me.问题编号Label1.TabIndex = 2
        Me.问题编号Label1.Text = "Label1"
        '
        '设备名称Label1
        '
        Me.设备名称Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_wtjuBindingSource, "设备名称", True))
        Me.设备名称Label1.Location = New System.Drawing.Point(218, 194)
        Me.设备名称Label1.Name = "设备名称Label1"
        Me.设备名称Label1.Size = New System.Drawing.Size(310, 23)
        Me.设备名称Label1.TabIndex = 4
        Me.设备名称Label1.Text = "Label1"
        '
        '存在问题TextBox
        '
        Me.存在问题TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.存在问题TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_wtjuBindingSource, "存在问题", True))
        Me.存在问题TextBox.Location = New System.Drawing.Point(218, 240)
        Me.存在问题TextBox.Multiline = True
        Me.存在问题TextBox.Name = "存在问题TextBox"
        Me.存在问题TextBox.ReadOnly = True
        Me.存在问题TextBox.Size = New System.Drawing.Size(310, 77)
        Me.存在问题TextBox.TabIndex = 6
        '
        '整治方案TextBox
        '
        Me.整治方案TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_wtjuBindingSource, "整治方案", True))
        Me.整治方案TextBox.Location = New System.Drawing.Point(218, 348)
        Me.整治方案TextBox.Name = "整治方案TextBox"
        Me.整治方案TextBox.Size = New System.Drawing.Size(310, 25)
        Me.整治方案TextBox.TabIndex = 8
        '
        '整治情况TextBox
        '
        Me.整治情况TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_wtjuBindingSource, "整治情况", True))
        Me.整治情况TextBox.Location = New System.Drawing.Point(218, 409)
        Me.整治情况TextBox.Name = "整治情况TextBox"
        Me.整治情况TextBox.Size = New System.Drawing.Size(310, 25)
        Me.整治情况TextBox.TabIndex = 10
        '
        '完成情况TextBox
        '
        Me.完成情况TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_wtjuBindingSource, "完成情况", True))
        Me.完成情况TextBox.Location = New System.Drawing.Point(218, 463)
        Me.完成情况TextBox.Name = "完成情况TextBox"
        Me.完成情况TextBox.Size = New System.Drawing.Size(310, 25)
        Me.完成情况TextBox.TabIndex = 12
        '
        '参加整治负责人签字TextBox
        '
        Me.参加整治负责人签字TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_wtjuBindingSource, "参加整治负责人签字", True))
        Me.参加整治负责人签字TextBox.Location = New System.Drawing.Point(218, 507)
        Me.参加整治负责人签字TextBox.Name = "参加整治负责人签字TextBox"
        Me.参加整治负责人签字TextBox.Size = New System.Drawing.Size(310, 25)
        Me.参加整治负责人签字TextBox.TabIndex = 14
        '
        'T_pfjuDataGridView
        '
        Me.T_pfjuDataGridView.AllowUserToAddRows = False
        Me.T_pfjuDataGridView.AllowUserToDeleteRows = False
        Me.T_pfjuDataGridView.AutoGenerateColumns = False
        Me.T_pfjuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.T_pfjuDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.派发日期DataGridViewTextBoxColumn, Me.问题编号DataGridViewTextBoxColumn, Me.设备名称, Me.存在问题, Me.本次派发销记状态, Me.天窗需求, Me.计划整治时间DataGridViewTextBoxColumn, Me.站名, Me.派发记录IDDataGridViewTextBoxColumn})
        Me.T_pfjuDataGridView.DataSource = Me.T_pfjuBindingSource
        Me.T_pfjuDataGridView.Location = New System.Drawing.Point(548, 127)
        Me.T_pfjuDataGridView.Name = "T_pfjuDataGridView"
        Me.T_pfjuDataGridView.ReadOnly = True
        Me.T_pfjuDataGridView.RowHeadersWidth = 20
        Me.T_pfjuDataGridView.RowTemplate.Height = 27
        Me.T_pfjuDataGridView.Size = New System.Drawing.Size(679, 524)
        Me.T_pfjuDataGridView.TabIndex = 17
        '
        '派发日期DataGridViewTextBoxColumn
        '
        Me.派发日期DataGridViewTextBoxColumn.DataPropertyName = "派发日期"
        DataGridViewCellStyle1.Format = "M"
        Me.派发日期DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.派发日期DataGridViewTextBoxColumn.HeaderText = "派发日期"
        Me.派发日期DataGridViewTextBoxColumn.Name = "派发日期DataGridViewTextBoxColumn"
        Me.派发日期DataGridViewTextBoxColumn.ReadOnly = True
        '
        '问题编号DataGridViewTextBoxColumn
        '
        Me.问题编号DataGridViewTextBoxColumn.DataPropertyName = "问题编号"
        Me.问题编号DataGridViewTextBoxColumn.HeaderText = "问题编号"
        Me.问题编号DataGridViewTextBoxColumn.Name = "问题编号DataGridViewTextBoxColumn"
        Me.问题编号DataGridViewTextBoxColumn.ReadOnly = True
        '
        '设备名称
        '
        Me.设备名称.DataPropertyName = "设备名称"
        Me.设备名称.HeaderText = "设备名称"
        Me.设备名称.Name = "设备名称"
        Me.设备名称.ReadOnly = True
        '
        '存在问题
        '
        Me.存在问题.DataPropertyName = "存在问题"
        Me.存在问题.HeaderText = "存在问题"
        Me.存在问题.Name = "存在问题"
        Me.存在问题.ReadOnly = True
        '
        '本次派发销记状态
        '
        Me.本次派发销记状态.DataPropertyName = "本次派发销记状态"
        Me.本次派发销记状态.HeaderText = "本次派发销记状态"
        Me.本次派发销记状态.Name = "本次派发销记状态"
        Me.本次派发销记状态.ReadOnly = True
        '
        '天窗需求
        '
        Me.天窗需求.DataPropertyName = "天窗需求"
        Me.天窗需求.HeaderText = "天窗需求"
        Me.天窗需求.Name = "天窗需求"
        Me.天窗需求.ReadOnly = True
        '
        '计划整治时间DataGridViewTextBoxColumn
        '
        Me.计划整治时间DataGridViewTextBoxColumn.DataPropertyName = "计划整治时间"
        Me.计划整治时间DataGridViewTextBoxColumn.HeaderText = "计划整治时间"
        Me.计划整治时间DataGridViewTextBoxColumn.Name = "计划整治时间DataGridViewTextBoxColumn"
        Me.计划整治时间DataGridViewTextBoxColumn.ReadOnly = True
        '
        '站名
        '
        Me.站名.DataPropertyName = "站名"
        Me.站名.HeaderText = "站名"
        Me.站名.Name = "站名"
        Me.站名.ReadOnly = True
        '
        '派发记录IDDataGridViewTextBoxColumn
        '
        Me.派发记录IDDataGridViewTextBoxColumn.DataPropertyName = "派发记录ID"
        Me.派发记录IDDataGridViewTextBoxColumn.HeaderText = "派发记录ID"
        Me.派发记录IDDataGridViewTextBoxColumn.Name = "派发记录IDDataGridViewTextBoxColumn"
        Me.派发记录IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'T_pfjuBindingSource
        '
        Me.T_pfjuBindingSource.DataMember = "t_pfju"
        Me.T_pfjuBindingSource.DataSource = Me.JHBDataSet
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(218, 601)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 37)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "销记"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(545, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "问题派发详情"
        '
        '销记时间TextBox
        '
        Me.销记时间TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_wtjuBindingSource, "销记时间", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "M"))
        Me.销记时间TextBox.Location = New System.Drawing.Point(218, 556)
        Me.销记时间TextBox.Name = "销记时间TextBox"
        Me.销记时间TextBox.Size = New System.Drawing.Size(163, 25)
        Me.销记时间TextBox.TabIndex = 20
        '
        'xjDateTimePicker
        '
        Me.xjDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.xjDateTimePicker.Location = New System.Drawing.Point(218, 556)
        Me.xjDateTimePicker.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.xjDateTimePicker.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.xjDateTimePicker.Name = "xjDateTimePicker"
        Me.xjDateTimePicker.Size = New System.Drawing.Size(207, 25)
        Me.xjDateTimePicker.TabIndex = 21
        Me.xjDateTimePicker.Value = New Date(2016, 12, 15, 0, 0, 0, 0)
        '
        '销记CheckBox
        '
        Me.销记CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.T_wtjuBindingSource, "销记", True))
        Me.销记CheckBox.Enabled = False
        Me.销记CheckBox.Location = New System.Drawing.Point(173, 601)
        Me.销记CheckBox.Name = "销记CheckBox"
        Me.销记CheckBox.Size = New System.Drawing.Size(17, 24)
        Me.销记CheckBox.TabIndex = 22
        Me.销记CheckBox.UseVisualStyleBackColor = True
        '
        '站名ComboBox
        '
        Me.站名ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.T_wtjuBindingSource, "站名", True))
        Me.站名ComboBox.FormattingEnabled = True
        Me.站名ComboBox.Items.AddRange(New Object() {"安康", "石庙沟"})
        Me.站名ComboBox.Location = New System.Drawing.Point(218, 106)
        Me.站名ComboBox.Name = "站名ComboBox"
        Me.站名ComboBox.Size = New System.Drawing.Size(207, 23)
        Me.站名ComboBox.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(461, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 37)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "已派发问题销记"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TpfjuBindingSource, "本次派发销记状态", True))
        Me.CheckBox1.Location = New System.Drawing.Point(417, 604)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(18, 17)
        Me.CheckBox1.TabIndex = 25
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'TpfjuBindingSource
        '
        Me.TpfjuBindingSource.DataMember = "t_pfju"
        Me.TpfjuBindingSource.DataSource = Me.JHBDataSet
        '
        'T_WTJUTableAdapter
        '
        Me.T_WTJUTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.t_pfjuTableAdapter = Nothing
        Me.TableAdapterManager.T_WTJUTableAdapter = Me.T_WTJUTableAdapter
        Me.TableAdapterManager.tzdContentTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = wapJHB.JHBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'T_pfjuTableAdapter
        '
        Me.T_pfjuTableAdapter.ClearBeforeFill = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1258, 749)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(站名Label)
        Me.Controls.Add(Me.站名ComboBox)
        Me.Controls.Add(Me.销记CheckBox)
        Me.Controls.Add(销记时间Label)
        Me.Controls.Add(Me.销记时间TextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.T_pfjuDataGridView)
        Me.Controls.Add(参加整治人签字Label)
        Me.Controls.Add(Me.参加整治负责人签字TextBox)
        Me.Controls.Add(完成情况Label)
        Me.Controls.Add(Me.完成情况TextBox)
        Me.Controls.Add(整治情况Label)
        Me.Controls.Add(Me.整治情况TextBox)
        Me.Controls.Add(整治方案Label)
        Me.Controls.Add(Me.整治方案TextBox)
        Me.Controls.Add(存在问题Label)
        Me.Controls.Add(Me.存在问题TextBox)
        Me.Controls.Add(设备名称Label)
        Me.Controls.Add(Me.设备名称Label1)
        Me.Controls.Add(问题编号Label)
        Me.Controls.Add(Me.问题编号Label1)
        Me.Controls.Add(Me.T_wtjuXJ)
        Me.Controls.Add(Me.xjDateTimePicker)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "销记"
        CType(Me.T_wtjuXJ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.T_wtjuXJ.ResumeLayout(False)
        Me.T_wtjuXJ.PerformLayout()
        CType(Me.T_wtjuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JHBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_pfjuDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_pfjuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TpfjuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JHBDataSet As wapJHB.JHBDataSet
    Friend WithEvents T_wtjuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_WTJUTableAdapter As wapJHB.JHBDataSetTableAdapters.T_WTJUTableAdapter
    Friend WithEvents TableAdapterManager As wapJHB.JHBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents T_wtjuXJ As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents T_wtjuBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents T_pfjuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_pfjuTableAdapter As wapJHB.JHBDataSetTableAdapters.t_pfjuTableAdapter
    Friend WithEvents 问题编号Label1 As System.Windows.Forms.Label
    Friend WithEvents 设备名称Label1 As System.Windows.Forms.Label
    Friend WithEvents 存在问题TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 整治方案TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 整治情况TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 完成情况TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 参加整治负责人签字TextBox As System.Windows.Forms.TextBox
    Friend WithEvents T_pfjuDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents 销记时间TextBox As System.Windows.Forms.TextBox
    Friend WithEvents xjDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents 销记CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents 站名ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents 派发日期DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 问题编号DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 设备名称 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 存在问题 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 本次派发销记状态 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents 天窗需求 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 计划整治时间DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 站名 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 派发记录IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TpfjuBindingSource As System.Windows.Forms.BindingSource
End Class
