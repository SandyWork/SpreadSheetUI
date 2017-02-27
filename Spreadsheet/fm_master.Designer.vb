<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fm_master
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fm_master))
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.col_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_attrib1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_attrib2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_attrib3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_attrib4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_uattrib4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_attrib5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_minVal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_normVal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_MaxVal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Menu1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Menu2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValidateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv1
        '
        Me.dgv1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgv1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgv1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_name, Me.col_sel, Me.col_attrib1, Me.col_attrib2, Me.col_attrib3, Me.col_attrib4, Me.col_uattrib4, Me.col_attrib5, Me.col_minVal, Me.col_normVal, Me.col_MaxVal})
        Me.dgv1.Location = New System.Drawing.Point(45, 58)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(854, 273)
        Me.dgv1.TabIndex = 0
        '
        'col_name
        '
        Me.col_name.HeaderText = "Name"
        Me.col_name.Name = "col_name"
        Me.col_name.Width = 60
        '
        'col_sel
        '
        Me.col_sel.HeaderText = "Selection"
        Me.col_sel.Name = "col_sel"
        Me.col_sel.Width = 76
        '
        'col_attrib1
        '
        Me.col_attrib1.HeaderText = "Attribute1"
        Me.col_attrib1.Name = "col_attrib1"
        Me.col_attrib1.Width = 77
        '
        'col_attrib2
        '
        Me.col_attrib2.HeaderText = "Attribute2"
        Me.col_attrib2.Name = "col_attrib2"
        Me.col_attrib2.Width = 77
        '
        'col_attrib3
        '
        Me.col_attrib3.HeaderText = "Attribute3"
        Me.col_attrib3.Name = "col_attrib3"
        Me.col_attrib3.Width = 77
        '
        'col_attrib4
        '
        Me.col_attrib4.HeaderText = "Attribute4"
        Me.col_attrib4.Name = "col_attrib4"
        Me.col_attrib4.Width = 77
        '
        'col_uattrib4
        '
        Me.col_uattrib4.HeaderText = "Unit_Attri4"
        Me.col_uattrib4.Name = "col_uattrib4"
        Me.col_uattrib4.Width = 81
        '
        'col_attrib5
        '
        Me.col_attrib5.HeaderText = "Attribute5"
        Me.col_attrib5.Name = "col_attrib5"
        Me.col_attrib5.Width = 77
        '
        'col_minVal
        '
        Me.col_minVal.HeaderText = "MininumVal"
        Me.col_minVal.Name = "col_minVal"
        Me.col_minVal.Width = 86
        '
        'col_normVal
        '
        Me.col_normVal.HeaderText = "NormalVal"
        Me.col_normVal.Name = "col_normVal"
        Me.col_normVal.Width = 80
        '
        'col_MaxVal
        '
        Me.col_MaxVal.HeaderText = "MaximumVal"
        Me.col_MaxVal.Name = "col_MaxVal"
        Me.col_MaxVal.Width = 91
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Menu1ToolStripMenuItem, Me.Menu2ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(947, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Menu1ToolStripMenuItem
        '
        Me.Menu1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportToolStripMenuItem, Me.ExportToolStripMenuItem})
        Me.Menu1ToolStripMenuItem.Name = "Menu1ToolStripMenuItem"
        Me.Menu1ToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.Menu1ToolStripMenuItem.Text = "Menu1"
        '
        'ImportToolStripMenuItem
        '
        Me.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        Me.ImportToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ImportToolStripMenuItem.Text = "Import"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'Menu2ToolStripMenuItem
        '
        Me.Menu2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ValidateToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.Menu2ToolStripMenuItem.Name = "Menu2ToolStripMenuItem"
        Me.Menu2ToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.Menu2ToolStripMenuItem.Text = "Menu2"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ValidateToolStripMenuItem
        '
        Me.ValidateToolStripMenuItem.Name = "ValidateToolStripMenuItem"
        Me.ValidateToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ValidateToolStripMenuItem.Text = "Validate"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'fm_master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(947, 380)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "fm_master"
        Me.Text = "SpreadSheet Base"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Menu1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Menu2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ValidateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents col_name As DataGridViewTextBoxColumn
    Friend WithEvents col_sel As DataGridViewTextBoxColumn
    Friend WithEvents col_attrib1 As DataGridViewTextBoxColumn
    Friend WithEvents col_attrib2 As DataGridViewTextBoxColumn
    Friend WithEvents col_attrib3 As DataGridViewTextBoxColumn
    Friend WithEvents col_attrib4 As DataGridViewTextBoxColumn
    Friend WithEvents col_uattrib4 As DataGridViewTextBoxColumn
    Friend WithEvents col_attrib5 As DataGridViewTextBoxColumn
    Friend WithEvents col_minVal As DataGridViewTextBoxColumn
    Friend WithEvents col_normVal As DataGridViewTextBoxColumn
    Friend WithEvents col_MaxVal As DataGridViewTextBoxColumn
End Class
