<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim 计划时间Label As System.Windows.Forms.Label
        Dim 录入时间Label As System.Windows.Forms.Label
        Dim 发现问题时间Label As System.Windows.Forms.Label
        Dim 是否需要发通知单Label As System.Windows.Forms.Label
        Dim 问题等级Label As System.Windows.Forms.Label
        Dim 站名Label As System.Windows.Forms.Label
        Dim 天窗需求Label As System.Windows.Forms.Label
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.问题编号Label1 = New System.Windows.Forms.Label()
        Me.T_wtjuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JHBDataSet = New wapJHB.JHBDataSet()
        Me.设备名称TextBox = New System.Windows.Forms.TextBox()
        Me.存在问题TextBox = New System.Windows.Forms.TextBox()
        Me.整治方案TextBox = New System.Windows.Forms.TextBox()
        Me.计划时间DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.录入时间DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.发现问题时间DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.是否需要发通知单CheckBox = New System.Windows.Forms.CheckBox()
        Me.问题等级ComboBox = New System.Windows.Forms.ComboBox()
        Me.X_fzDataGridView = New System.Windows.Forms.DataGridView()
        Me.问题编号DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.设备名称DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.存在问题DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.录入时间DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.站名DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.XfzBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.X_fzDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.问题编号DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.设备名称DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.存在问题DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.录入时间DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.站名DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.站名ComboBox = New System.Windows.Forms.ComboBox()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.T_wtjuBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.T_wtjuBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.天窗需求ComboBox = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.T_WTJUTableAdapter = New wapJHB.JHBDataSetTableAdapters.T_WTJUTableAdapter()
        Me.TableAdapterManager = New wapJHB.JHBDataSetTableAdapters.TableAdapterManager()
        Me.X_fzTableAdapter = New wapJHB.JHBDataSetTableAdapters.x_fzTableAdapter()
        问题编号Label = New System.Windows.Forms.Label()
        设备名称Label = New System.Windows.Forms.Label()
        存在问题Label = New System.Windows.Forms.Label()
        整治方案Label = New System.Windows.Forms.Label()
        计划时间Label = New System.Windows.Forms.Label()
        录入时间Label = New System.Windows.Forms.Label()
        发现问题时间Label = New System.Windows.Forms.Label()
        是否需要发通知单Label = New System.Windows.Forms.Label()
        问题等级Label = New System.Windows.Forms.Label()
        站名Label = New System.Windows.Forms.Label()
        天窗需求Label = New System.Windows.Forms.Label()
        CType(Me.T_wtjuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JHBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X_fzDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XfzBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.X_fzDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_wtjuBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.T_wtjuBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        '问题编号Label
        '
        问题编号Label.AutoSize = True
        问题编号Label.Location = New System.Drawing.Point(59, 168)
        问题编号Label.Name = "问题编号Label"
        问题编号Label.Size = New System.Drawing.Size(75, 15)
        问题编号Label.TabIndex = 1
        问题编号Label.Text = "问题编号:"
        '
        '设备名称Label
        '
        设备名称Label.AutoSize = True
        设备名称Label.Location = New System.Drawing.Point(59, 213)
        设备名称Label.Name = "设备名称Label"
        设备名称Label.Size = New System.Drawing.Size(75, 15)
        设备名称Label.TabIndex = 3
        设备名称Label.Text = "设备名称:"
        '
        '存在问题Label
        '
        存在问题Label.AutoSize = True
        存在问题Label.Location = New System.Drawing.Point(59, 256)
        存在问题Label.Name = "存在问题Label"
        存在问题Label.Size = New System.Drawing.Size(75, 15)
        存在问题Label.TabIndex = 5
        存在问题Label.Text = "存在问题:"
        '
        '整治方案Label
        '
        整治方案Label.AutoSize = True
        整治方案Label.Location = New System.Drawing.Point(59, 335)
        整治方案Label.Name = "整治方案Label"
        整治方案Label.Size = New System.Drawing.Size(75, 15)
        整治方案Label.TabIndex = 7
        整治方案Label.Text = "整治方案:"
        '
        '计划时间Label
        '
        计划时间Label.AutoSize = True
        计划时间Label.Location = New System.Drawing.Point(59, 392)
        计划时间Label.Name = "计划时间Label"
        计划时间Label.Size = New System.Drawing.Size(75, 15)
        计划时间Label.TabIndex = 9
        计划时间Label.Text = "计划时间:"
        '
        '录入时间Label
        '
        录入时间Label.AutoSize = True
        录入时间Label.Location = New System.Drawing.Point(59, 448)
        录入时间Label.Name = "录入时间Label"
        录入时间Label.Size = New System.Drawing.Size(75, 15)
        录入时间Label.TabIndex = 11
        录入时间Label.Text = "录入时间:"
        '
        '发现问题时间Label
        '
        发现问题时间Label.AutoSize = True
        发现问题时间Label.Location = New System.Drawing.Point(59, 512)
        发现问题时间Label.Name = "发现问题时间Label"
        发现问题时间Label.Size = New System.Drawing.Size(105, 15)
        发现问题时间Label.TabIndex = 13
        发现问题时间Label.Text = "发现问题时间:"
        '
        '是否需要发通知单Label
        '
        是否需要发通知单Label.AutoSize = True
        是否需要发通知单Label.Location = New System.Drawing.Point(59, 568)
        是否需要发通知单Label.Name = "是否需要发通知单Label"
        是否需要发通知单Label.Size = New System.Drawing.Size(135, 15)
        是否需要发通知单Label.TabIndex = 15
        是否需要发通知单Label.Text = "是否需要发通知单:"
        '
        '问题等级Label
        '
        问题等级Label.AutoSize = True
        问题等级Label.Location = New System.Drawing.Point(59, 617)
        问题等级Label.Name = "问题等级Label"
        问题等级Label.Size = New System.Drawing.Size(75, 15)
        问题等级Label.TabIndex = 17
        问题等级Label.Text = "问题等级:"
        '
        '站名Label
        '
        站名Label.AutoSize = True
        站名Label.Location = New System.Drawing.Point(59, 127)
        站名Label.Name = "站名Label"
        站名Label.Size = New System.Drawing.Size(45, 15)
        站名Label.TabIndex = 36
        站名Label.Text = "站名:"
        '
        '天窗需求Label
        '
        天窗需求Label.AutoSize = True
        天窗需求Label.Location = New System.Drawing.Point(59, 663)
        天窗需求Label.Name = "天窗需求Label"
        天窗需求Label.Size = New System.Drawing.Size(75, 15)
        天窗需求Label.TabIndex = 37
        天窗需求Label.Text = "天窗需求:"
        '
        '问题编号Label1
        '
        Me.问题编号Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_wtjuBindingSource, "问题编号", True))
        Me.问题编号Label1.Location = New System.Drawing.Point(140, 168)
        Me.问题编号Label1.Name = "问题编号Label1"
        Me.问题编号Label1.Size = New System.Drawing.Size(185, 15)
        Me.问题编号Label1.TabIndex = 2
        Me.问题编号Label1.Text = "Label1"
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
        '设备名称TextBox
        '
        Me.设备名称TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_wtjuBindingSource, "设备名称", True))
        Me.设备名称TextBox.Location = New System.Drawing.Point(140, 209)
        Me.设备名称TextBox.Name = "设备名称TextBox"
        Me.设备名称TextBox.Size = New System.Drawing.Size(380, 25)
        Me.设备名称TextBox.TabIndex = 1
        '
        '存在问题TextBox
        '
        Me.存在问题TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_wtjuBindingSource, "存在问题", True))
        Me.存在问题TextBox.Location = New System.Drawing.Point(140, 254)
        Me.存在问题TextBox.Multiline = True
        Me.存在问题TextBox.Name = "存在问题TextBox"
        Me.存在问题TextBox.Size = New System.Drawing.Size(380, 65)
        Me.存在问题TextBox.TabIndex = 2
        '
        '整治方案TextBox
        '
        Me.整治方案TextBox.CausesValidation = False
        Me.整治方案TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_wtjuBindingSource, "整治方案", True))
        Me.整治方案TextBox.Location = New System.Drawing.Point(140, 334)
        Me.整治方案TextBox.Name = "整治方案TextBox"
        Me.整治方案TextBox.Size = New System.Drawing.Size(242, 25)
        Me.整治方案TextBox.TabIndex = 3
        '
        '计划时间DateTimePicker
        '
        Me.计划时间DateTimePicker.CustomFormat = ""
        Me.计划时间DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.计划时间DateTimePicker.Location = New System.Drawing.Point(142, 385)
        Me.计划时间DateTimePicker.MaxDate = New Date(2029, 12, 25, 0, 0, 0, 0)
        Me.计划时间DateTimePicker.MinDate = New Date(2011, 1, 1, 0, 0, 0, 0)
        Me.计划时间DateTimePicker.Name = "计划时间DateTimePicker"
        Me.计划时间DateTimePicker.Size = New System.Drawing.Size(240, 25)
        Me.计划时间DateTimePicker.TabIndex = 4
        Me.计划时间DateTimePicker.Value = New Date(2017, 3, 24, 0, 0, 0, 0)
        '
        '录入时间DateTimePicker
        '
        Me.录入时间DateTimePicker.CustomFormat = ""
        Me.录入时间DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.录入时间DateTimePicker.Location = New System.Drawing.Point(140, 445)
        Me.录入时间DateTimePicker.MaxDate = New Date(2029, 12, 1, 0, 0, 0, 0)
        Me.录入时间DateTimePicker.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.录入时间DateTimePicker.Name = "录入时间DateTimePicker"
        Me.录入时间DateTimePicker.Size = New System.Drawing.Size(242, 25)
        Me.录入时间DateTimePicker.TabIndex = 5
        Me.录入时间DateTimePicker.Value = New Date(2017, 3, 24, 0, 0, 0, 0)
        '
        '发现问题时间DateTimePicker
        '
        Me.发现问题时间DateTimePicker.CustomFormat = ""
        Me.发现问题时间DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.发现问题时间DateTimePicker.Location = New System.Drawing.Point(170, 508)
        Me.发现问题时间DateTimePicker.MaxDate = New Date(2029, 12, 31, 0, 0, 0, 0)
        Me.发现问题时间DateTimePicker.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.发现问题时间DateTimePicker.Name = "发现问题时间DateTimePicker"
        Me.发现问题时间DateTimePicker.Size = New System.Drawing.Size(260, 25)
        Me.发现问题时间DateTimePicker.TabIndex = 6
        Me.发现问题时间DateTimePicker.Value = New Date(2017, 3, 24, 0, 0, 0, 0)
        '
        '是否需要发通知单CheckBox
        '
        Me.是否需要发通知单CheckBox.Checked = True
        Me.是否需要发通知单CheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.是否需要发通知单CheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.T_wtjuBindingSource, "是否需要发通知单", True))
        Me.是否需要发通知单CheckBox.Location = New System.Drawing.Point(200, 564)
        Me.是否需要发通知单CheckBox.Name = "是否需要发通知单CheckBox"
        Me.是否需要发通知单CheckBox.Size = New System.Drawing.Size(164, 15)
        Me.是否需要发通知单CheckBox.TabIndex = 7
        Me.是否需要发通知单CheckBox.UseVisualStyleBackColor = True
        '
        '问题等级ComboBox
        '
        Me.问题等级ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_wtjuBindingSource, "问题等级", True))
        Me.问题等级ComboBox.FormattingEnabled = True
        Me.问题等级ComboBox.Items.AddRange(New Object() {"轻微", "一般", "严重"})
        Me.问题等级ComboBox.Location = New System.Drawing.Point(140, 614)
        Me.问题等级ComboBox.Name = "问题等级ComboBox"
        Me.问题等级ComboBox.Size = New System.Drawing.Size(133, 23)
        Me.问题等级ComboBox.TabIndex = 8
        '
        'X_fzDataGridView
        '
        Me.X_fzDataGridView.AllowUserToAddRows = False
        Me.X_fzDataGridView.AllowUserToDeleteRows = False
        Me.X_fzDataGridView.AutoGenerateColumns = False
        Me.X_fzDataGridView.CausesValidation = False
        Me.X_fzDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.X_fzDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.X_fzDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.问题编号DataGridViewTextBoxColumn, Me.设备名称DataGridViewTextBoxColumn, Me.存在问题DataGridViewTextBoxColumn, Me.录入时间DataGridViewTextBoxColumn, Me.站名DataGridViewTextBoxColumn})
        Me.X_fzDataGridView.DataSource = Me.XfzBindingSource
        Me.X_fzDataGridView.Location = New System.Drawing.Point(536, 127)
        Me.X_fzDataGridView.Name = "X_fzDataGridView"
        Me.X_fzDataGridView.ReadOnly = True
        Me.X_fzDataGridView.RowHeadersWidth = 20
        Me.X_fzDataGridView.RowTemplate.Height = 27
        Me.X_fzDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.X_fzDataGridView.Size = New System.Drawing.Size(694, 295)
        Me.X_fzDataGridView.TabIndex = 33
        Me.X_fzDataGridView.TabStop = False
        '
        '问题编号DataGridViewTextBoxColumn
        '
        Me.问题编号DataGridViewTextBoxColumn.DataPropertyName = "问题编号"
        Me.问题编号DataGridViewTextBoxColumn.HeaderText = "问题编号"
        Me.问题编号DataGridViewTextBoxColumn.Name = "问题编号DataGridViewTextBoxColumn"
        Me.问题编号DataGridViewTextBoxColumn.ReadOnly = True
        '
        '设备名称DataGridViewTextBoxColumn
        '
        Me.设备名称DataGridViewTextBoxColumn.DataPropertyName = "设备名称"
        Me.设备名称DataGridViewTextBoxColumn.HeaderText = "设备名称"
        Me.设备名称DataGridViewTextBoxColumn.Name = "设备名称DataGridViewTextBoxColumn"
        Me.设备名称DataGridViewTextBoxColumn.ReadOnly = True
        '
        '存在问题DataGridViewTextBoxColumn
        '
        Me.存在问题DataGridViewTextBoxColumn.DataPropertyName = "存在问题"
        Me.存在问题DataGridViewTextBoxColumn.HeaderText = "存在问题"
        Me.存在问题DataGridViewTextBoxColumn.Name = "存在问题DataGridViewTextBoxColumn"
        Me.存在问题DataGridViewTextBoxColumn.ReadOnly = True
        Me.存在问题DataGridViewTextBoxColumn.Width = 300
        '
        '录入时间DataGridViewTextBoxColumn
        '
        Me.录入时间DataGridViewTextBoxColumn.DataPropertyName = "录入时间"
        DataGridViewCellStyle5.Format = "M"
        Me.录入时间DataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.录入时间DataGridViewTextBoxColumn.HeaderText = "录入时间"
        Me.录入时间DataGridViewTextBoxColumn.Name = "录入时间DataGridViewTextBoxColumn"
        Me.录入时间DataGridViewTextBoxColumn.ReadOnly = True
        '
        '站名DataGridViewTextBoxColumn
        '
        Me.站名DataGridViewTextBoxColumn.DataPropertyName = "站名"
        Me.站名DataGridViewTextBoxColumn.HeaderText = "站名"
        Me.站名DataGridViewTextBoxColumn.Name = "站名DataGridViewTextBoxColumn"
        Me.站名DataGridViewTextBoxColumn.ReadOnly = True
        '
        'XfzBindingSource
        '
        Me.XfzBindingSource.DataMember = "x_fz"
        Me.XfzBindingSource.DataSource = Me.JHBDataSet
        '
        'X_fzDataGridView1
        '
        Me.X_fzDataGridView1.AllowUserToAddRows = False
        Me.X_fzDataGridView1.AllowUserToDeleteRows = False
        Me.X_fzDataGridView1.AutoGenerateColumns = False
        Me.X_fzDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.X_fzDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.问题编号DataGridViewTextBoxColumn1, Me.设备名称DataGridViewTextBoxColumn1, Me.存在问题DataGridViewTextBoxColumn1, Me.录入时间DataGridViewTextBoxColumn1, Me.站名DataGridViewTextBoxColumn1})
        Me.X_fzDataGridView1.DataSource = Me.XfzBindingSource
        Me.X_fzDataGridView1.Location = New System.Drawing.Point(536, 466)
        Me.X_fzDataGridView1.Name = "X_fzDataGridView1"
        Me.X_fzDataGridView1.ReadOnly = True
        Me.X_fzDataGridView1.RowHeadersWidth = 20
        Me.X_fzDataGridView1.RowTemplate.Height = 27
        Me.X_fzDataGridView1.Size = New System.Drawing.Size(694, 235)
        Me.X_fzDataGridView1.TabIndex = 20
        '
        '问题编号DataGridViewTextBoxColumn1
        '
        Me.问题编号DataGridViewTextBoxColumn1.DataPropertyName = "问题编号"
        Me.问题编号DataGridViewTextBoxColumn1.HeaderText = "问题编号"
        Me.问题编号DataGridViewTextBoxColumn1.Name = "问题编号DataGridViewTextBoxColumn1"
        Me.问题编号DataGridViewTextBoxColumn1.ReadOnly = True
        '
        '设备名称DataGridViewTextBoxColumn1
        '
        Me.设备名称DataGridViewTextBoxColumn1.DataPropertyName = "设备名称"
        Me.设备名称DataGridViewTextBoxColumn1.HeaderText = "设备名称"
        Me.设备名称DataGridViewTextBoxColumn1.Name = "设备名称DataGridViewTextBoxColumn1"
        Me.设备名称DataGridViewTextBoxColumn1.ReadOnly = True
        '
        '存在问题DataGridViewTextBoxColumn1
        '
        Me.存在问题DataGridViewTextBoxColumn1.DataPropertyName = "存在问题"
        Me.存在问题DataGridViewTextBoxColumn1.HeaderText = "存在问题"
        Me.存在问题DataGridViewTextBoxColumn1.Name = "存在问题DataGridViewTextBoxColumn1"
        Me.存在问题DataGridViewTextBoxColumn1.ReadOnly = True
        Me.存在问题DataGridViewTextBoxColumn1.Width = 300
        '
        '录入时间DataGridViewTextBoxColumn1
        '
        Me.录入时间DataGridViewTextBoxColumn1.DataPropertyName = "录入时间"
        DataGridViewCellStyle6.Format = "M"
        Me.录入时间DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle6
        Me.录入时间DataGridViewTextBoxColumn1.HeaderText = "录入时间"
        Me.录入时间DataGridViewTextBoxColumn1.Name = "录入时间DataGridViewTextBoxColumn1"
        Me.录入时间DataGridViewTextBoxColumn1.ReadOnly = True
        '
        '站名DataGridViewTextBoxColumn1
        '
        Me.站名DataGridViewTextBoxColumn1.DataPropertyName = "站名"
        Me.站名DataGridViewTextBoxColumn1.HeaderText = "站名"
        Me.站名DataGridViewTextBoxColumn1.Name = "站名DataGridViewTextBoxColumn1"
        Me.站名DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("宋体", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(440, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 30)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "结合部问题录入"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(532, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 23)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "设备名称参照:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(532, 432)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 23)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "设备问题参照:"
        '
        'TextBox1
        '
        Me.TextBox1.CausesValidation = False
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_wtjuBindingSource, "计划时间", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "D"))
        Me.TextBox1.Location = New System.Drawing.Point(142, 385)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(201, 25)
        Me.TextBox1.TabIndex = 34
        '
        'TextBox2
        '
        Me.TextBox2.CausesValidation = False
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_wtjuBindingSource, "录入时间", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "D"))
        Me.TextBox2.Location = New System.Drawing.Point(140, 445)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(203, 25)
        Me.TextBox2.TabIndex = 35
        '
        'TextBox3
        '
        Me.TextBox3.CausesValidation = False
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_wtjuBindingSource, "发现问题时间", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "D"))
        Me.TextBox3.Location = New System.Drawing.Point(170, 508)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(212, 25)
        Me.TextBox3.TabIndex = 36
        '
        '站名ComboBox
        '
        Me.站名ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.T_wtjuBindingSource, "站名", True))
        Me.站名ComboBox.FormattingEnabled = True
        Me.站名ComboBox.Items.AddRange(New Object() {"安康", "石庙沟"})
        Me.站名ComboBox.Location = New System.Drawing.Point(110, 124)
        Me.站名ComboBox.Name = "站名ComboBox"
        Me.站名ComboBox.Size = New System.Drawing.Size(181, 23)
        Me.站名ComboBox.TabIndex = 37
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "移到第一条记录"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 24)
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 24)
        Me.BindingNavigatorCountItem.Text = "/ {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "总项数"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 24)
        Me.BindingNavigatorMoveNextItem.Text = "移到下一条记录"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 24)
        Me.BindingNavigatorMoveLastItem.Text = "移到最后一条记录"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.AutoSize = False
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(10, 27)
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 24)
        Me.BindingNavigatorDeleteItem.Text = "删除"
        '
        'T_wtjuBindingNavigatorSaveItem
        '
        Me.T_wtjuBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.T_wtjuBindingNavigatorSaveItem.Enabled = False
        Me.T_wtjuBindingNavigatorSaveItem.Image = CType(resources.GetObject("T_wtjuBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.T_wtjuBindingNavigatorSaveItem.Name = "T_wtjuBindingNavigatorSaveItem"
        Me.T_wtjuBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 24)
        Me.T_wtjuBindingNavigatorSaveItem.Text = "保存数据"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.AutoSize = False
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(10, 27)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(48, 24)
        Me.ToolStripLabel1.Text = "提示:"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 24)
        Me.ToolStripButton1.ToolTipText = "提交"
        '
        'T_wtjuBindingNavigator
        '
        Me.T_wtjuBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.T_wtjuBindingNavigator.BindingSource = Me.T_wtjuBindingSource
        Me.T_wtjuBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.T_wtjuBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.T_wtjuBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.T_wtjuBindingNavigator.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.T_wtjuBindingNavigator.ImageScalingSize = New System.Drawing.Size(30, 20)
        Me.T_wtjuBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorAddNewItem, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.T_wtjuBindingNavigatorSaveItem, Me.ToolStripSeparator2, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSeparator2, Me.ToolStripLabel1})
        Me.T_wtjuBindingNavigator.Location = New System.Drawing.Point(0, 722)
        Me.T_wtjuBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.T_wtjuBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.T_wtjuBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.T_wtjuBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.T_wtjuBindingNavigator.Name = "T_wtjuBindingNavigator"
        Me.T_wtjuBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.T_wtjuBindingNavigator.Size = New System.Drawing.Size(1258, 27)
        Me.T_wtjuBindingNavigator.TabIndex = 0
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 24)
        Me.BindingNavigatorAddNewItem.Text = "新添"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(10, 27)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(20, 27)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(20, 27)
        '
        '天窗需求ComboBox
        '
        Me.天窗需求ComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_wtjuBindingSource, "天窗需求", True))
        Me.天窗需求ComboBox.FormattingEnabled = True
        Me.天窗需求ComboBox.Location = New System.Drawing.Point(140, 660)
        Me.天窗需求ComboBox.Name = "天窗需求ComboBox"
        Me.天窗需求ComboBox.Size = New System.Drawing.Size(133, 23)
        Me.天窗需求ComboBox.TabIndex = 38
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(431, 168)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(89, 19)
        Me.CheckBox1.TabIndex = 39
        Me.CheckBox1.Text = "不可修改"
        Me.CheckBox1.UseVisualStyleBackColor = True
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
        'X_fzTableAdapter
        '
        Me.X_fzTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1258, 749)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(天窗需求Label)
        Me.Controls.Add(Me.天窗需求ComboBox)
        Me.Controls.Add(站名Label)
        Me.Controls.Add(Me.站名ComboBox)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.X_fzDataGridView1)
        Me.Controls.Add(Me.X_fzDataGridView)
        Me.Controls.Add(问题等级Label)
        Me.Controls.Add(Me.问题等级ComboBox)
        Me.Controls.Add(是否需要发通知单Label)
        Me.Controls.Add(Me.是否需要发通知单CheckBox)
        Me.Controls.Add(发现问题时间Label)
        Me.Controls.Add(Me.发现问题时间DateTimePicker)
        Me.Controls.Add(录入时间Label)
        Me.Controls.Add(Me.录入时间DateTimePicker)
        Me.Controls.Add(计划时间Label)
        Me.Controls.Add(整治方案Label)
        Me.Controls.Add(Me.整治方案TextBox)
        Me.Controls.Add(存在问题Label)
        Me.Controls.Add(Me.存在问题TextBox)
        Me.Controls.Add(设备名称Label)
        Me.Controls.Add(Me.设备名称TextBox)
        Me.Controls.Add(问题编号Label)
        Me.Controls.Add(Me.问题编号Label1)
        Me.Controls.Add(Me.T_wtjuBindingNavigator)
        Me.Controls.Add(Me.计划时间DateTimePicker)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "录入"
        CType(Me.T_wtjuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JHBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X_fzDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XfzBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.X_fzDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_wtjuBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.T_wtjuBindingNavigator.ResumeLayout(False)
        Me.T_wtjuBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents JHBDataSet As wapJHB.JHBDataSet
    Friend WithEvents T_wtjuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents T_WTJUTableAdapter As wapJHB.JHBDataSetTableAdapters.T_WTJUTableAdapter
    Friend WithEvents TableAdapterManager As wapJHB.JHBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents 问题编号Label1 As System.Windows.Forms.Label
    Friend WithEvents 设备名称TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 存在问题TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 整治方案TextBox As System.Windows.Forms.TextBox
    Friend WithEvents 计划时间DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents 录入时间DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents 发现问题时间DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents 是否需要发通知单CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents 问题等级ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents X_fzDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents X_fzDataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents 站名ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents XfzBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents X_fzTableAdapter As wapJHB.JHBDataSetTableAdapters.x_fzTableAdapter
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents T_wtjuBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents T_wtjuBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 天窗需求ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents 问题编号DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 设备名称DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 存在问题DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 录入时间DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 站名DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 问题编号DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 设备名称DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 存在问题DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 录入时间DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents 站名DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
