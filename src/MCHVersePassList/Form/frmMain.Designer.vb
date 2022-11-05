<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.dgvHolder = New System.Windows.Forms.DataGridView()
        Me.tspBar = New System.Windows.Forms.ToolStrip()
        Me.btnHolder = New System.Windows.Forms.ToolStripButton()
        Me.btnEns = New System.Windows.Forms.ToolStripButton()
        Me.btnLand = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnLoadHistory = New System.Windows.Forms.ToolStripButton()
        Me.dgvLand = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tspHolder = New System.Windows.Forms.ToolStrip()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnUpd = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgvHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tspBar.SuspendLayout()
        CType(Me.dgvLand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tspHolder.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvHolder
        '
        Me.dgvHolder.AllowUserToAddRows = False
        Me.dgvHolder.AllowUserToDeleteRows = False
        Me.dgvHolder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHolder.Location = New System.Drawing.Point(0, 0)
        Me.dgvHolder.Name = "dgvHolder"
        Me.dgvHolder.RowTemplate.Height = 21
        Me.dgvHolder.Size = New System.Drawing.Size(687, 376)
        Me.dgvHolder.TabIndex = 0
        '
        'tspBar
        '
        Me.tspBar.AutoSize = False
        Me.tspBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnHolder, Me.btnEns, Me.btnLand, Me.btnSave, Me.btnLoadHistory})
        Me.tspBar.Location = New System.Drawing.Point(0, 0)
        Me.tspBar.Name = "tspBar"
        Me.tspBar.Size = New System.Drawing.Size(984, 40)
        Me.tspBar.TabIndex = 2
        Me.tspBar.Text = "ToolStrip1"
        '
        'btnHolder
        '
        Me.btnHolder.AutoSize = False
        Me.btnHolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnHolder.Name = "btnHolder"
        Me.btnHolder.Size = New System.Drawing.Size(80, 37)
        Me.btnHolder.Text = "ホルダー更新"
        Me.btnHolder.ToolTipText = "ホルダー更新(Polygon)"
        '
        'btnEns
        '
        Me.btnEns.AutoSize = False
        Me.btnEns.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnEns.Name = "btnEns"
        Me.btnEns.Size = New System.Drawing.Size(60, 37)
        Me.btnEns.Text = "ENS取得"
        Me.btnEns.ToolTipText = "ENS取得(Mainnet)"
        '
        'btnLand
        '
        Me.btnLand.AutoSize = False
        Me.btnLand.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnLand.Name = "btnLand"
        Me.btnLand.Size = New System.Drawing.Size(60, 37)
        Me.btnLand.Text = "ランド更新"
        '
        'btnSave
        '
        Me.btnSave.AutoSize = False
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(60, 37)
        Me.btnSave.Text = "保存"
        '
        'btnLoadHistory
        '
        Me.btnLoadHistory.AutoSize = False
        Me.btnLoadHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnLoadHistory.Name = "btnLoadHistory"
        Me.btnLoadHistory.Size = New System.Drawing.Size(60, 37)
        Me.btnLoadHistory.Text = "履歴読込"
        '
        'dgvLand
        '
        Me.dgvLand.AllowUserToAddRows = False
        Me.dgvLand.AllowUserToDeleteRows = False
        Me.dgvLand.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvLand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLand.Location = New System.Drawing.Point(705, 43)
        Me.dgvLand.Name = "dgvLand"
        Me.dgvLand.RowTemplate.Height = 21
        Me.dgvLand.Size = New System.Drawing.Size(267, 336)
        Me.dgvLand.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.dgvHolder)
        Me.Panel1.Controls.Add(Me.tspHolder)
        Me.Panel1.Location = New System.Drawing.Point(12, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(687, 406)
        Me.Panel1.TabIndex = 4
        '
        'tspHolder
        '
        Me.tspHolder.AutoSize = False
        Me.tspHolder.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tspHolder.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.btnUpd})
        Me.tspHolder.Location = New System.Drawing.Point(0, 376)
        Me.tspHolder.Name = "tspHolder"
        Me.tspHolder.Size = New System.Drawing.Size(687, 30)
        Me.tspHolder.TabIndex = 1
        Me.tspHolder.Text = "ToolStrip1"
        '
        'btnAdd
        '
        Me.btnAdd.AutoSize = False
        Me.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(40, 27)
        Me.btnAdd.Text = "追加"
        '
        'btnUpd
        '
        Me.btnUpd.AutoSize = False
        Me.btnUpd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnUpd.Name = "btnUpd"
        Me.btnUpd.Size = New System.Drawing.Size(40, 27)
        Me.btnUpd.Text = "更新"
        Me.btnUpd.ToolTipText = "更新"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvLand)
        Me.Controls.Add(Me.tspBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "MCHVersePassList"
        CType(Me.dgvHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tspBar.ResumeLayout(False)
        Me.tspBar.PerformLayout()
        CType(Me.dgvLand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.tspHolder.ResumeLayout(False)
        Me.tspHolder.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvHolder As DataGridView
    Friend WithEvents tspBar As ToolStrip
    Friend WithEvents btnHolder As ToolStripButton
    Friend WithEvents btnLoadHistory As ToolStripButton
    Friend WithEvents btnLand As ToolStripButton
    Friend WithEvents btnEns As ToolStripButton
    Friend WithEvents btnSave As ToolStripButton
    Friend WithEvents dgvLand As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tspHolder As ToolStrip
    Friend WithEvents btnAdd As ToolStripButton
    Friend WithEvents btnUpd As ToolStripButton
End Class
