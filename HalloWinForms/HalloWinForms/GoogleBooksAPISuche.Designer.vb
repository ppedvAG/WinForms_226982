<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GoogleBooksAPISuche
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.suchButton = New System.Windows.Forms.Button()
        Me.suchTextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.nurDECheckBox = New System.Windows.Forms.CheckBox()
        Me.ladenButton = New System.Windows.Forms.Button()
        Me.speichernButton = New System.Windows.Forms.Button()
        Me.booksDataGridView = New System.Windows.Forms.DataGridView()
        Me.titleColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.authorsColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.langColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pagesFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.booksDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.suchButton, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.suchTextBox, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1244, 56)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'suchButton
        '
        Me.suchButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.suchButton.AutoSize = True
        Me.suchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.suchButton.Location = New System.Drawing.Point(1135, 7)
        Me.suchButton.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.suchButton.Name = "suchButton"
        Me.suchButton.Size = New System.Drawing.Size(103, 42)
        Me.suchButton.TabIndex = 0
        Me.suchButton.Text = "Suchen"
        Me.suchButton.UseVisualStyleBackColor = True
        '
        'suchTextBox
        '
        Me.suchTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.suchTextBox.Location = New System.Drawing.Point(6, 8)
        Me.suchTextBox.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.suchTextBox.Name = "suchTextBox"
        Me.suchTextBox.Size = New System.Drawing.Size(1117, 39)
        Me.suchTextBox.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.nurDECheckBox, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ladenButton, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.speichernButton, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 56)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1244, 56)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'nurDECheckBox
        '
        Me.nurDECheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.nurDECheckBox.AutoSize = True
        Me.nurDECheckBox.Location = New System.Drawing.Point(939, 10)
        Me.nurDECheckBox.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.nurDECheckBox.Name = "nurDECheckBox"
        Me.nurDECheckBox.Size = New System.Drawing.Size(299, 36)
        Me.nurDECheckBox.TabIndex = 0
        Me.nurDECheckBox.Text = "Nur Bücher auf deutsch"
        Me.nurDECheckBox.UseVisualStyleBackColor = True
        '
        'ladenButton
        '
        Me.ladenButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ladenButton.AutoSize = True
        Me.ladenButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ladenButton.Location = New System.Drawing.Point(6, 7)
        Me.ladenButton.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.ladenButton.Name = "ladenButton"
        Me.ladenButton.Size = New System.Drawing.Size(103, 42)
        Me.ladenButton.TabIndex = 1
        Me.ladenButton.Text = "Laden..."
        Me.ladenButton.UseVisualStyleBackColor = True
        '
        'speichernButton
        '
        Me.speichernButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.speichernButton.AutoSize = True
        Me.speichernButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.speichernButton.Location = New System.Drawing.Point(121, 7)
        Me.speichernButton.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.speichernButton.Name = "speichernButton"
        Me.speichernButton.Size = New System.Drawing.Size(145, 42)
        Me.speichernButton.TabIndex = 2
        Me.speichernButton.Text = "Speichern..."
        Me.speichernButton.UseVisualStyleBackColor = True
        '
        'booksDataGridView
        '
        Me.booksDataGridView.AllowUserToAddRows = False
        Me.booksDataGridView.AllowUserToDeleteRows = False
        Me.booksDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.booksDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.booksDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.booksDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.titleColumn, Me.authorsColumn, Me.langColumn})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.booksDataGridView.DefaultCellStyle = DataGridViewCellStyle10
        Me.booksDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.booksDataGridView.Location = New System.Drawing.Point(0, 112)
        Me.booksDataGridView.MultiSelect = False
        Me.booksDataGridView.Name = "booksDataGridView"
        Me.booksDataGridView.RowHeadersVisible = False
        Me.booksDataGridView.RowHeadersWidth = 82
        Me.booksDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.booksDataGridView.Size = New System.Drawing.Size(1244, 405)
        Me.booksDataGridView.TabIndex = 2
        '
        'titleColumn
        '
        Me.titleColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.titleColumn.DataPropertyName = "title"
        Me.titleColumn.HeaderText = "Titel"
        Me.titleColumn.MinimumWidth = 10
        Me.titleColumn.Name = "titleColumn"
        '
        'authorsColumn
        '
        Me.authorsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.authorsColumn.DataPropertyName = "authors"
        Me.authorsColumn.HeaderText = "Authoren"
        Me.authorsColumn.MinimumWidth = 10
        Me.authorsColumn.Name = "authorsColumn"
        Me.authorsColumn.Width = 159
        '
        'langColumn
        '
        Me.langColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.langColumn.DataPropertyName = "language"
        Me.langColumn.HeaderText = "Sprache"
        Me.langColumn.MinimumWidth = 10
        Me.langColumn.Name = "langColumn"
        Me.langColumn.Width = 144
        '
        'pagesFlowLayoutPanel
        '
        Me.pagesFlowLayoutPanel.AutoSize = True
        Me.pagesFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pagesFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pagesFlowLayoutPanel.Location = New System.Drawing.Point(0, 517)
        Me.pagesFlowLayoutPanel.Name = "pagesFlowLayoutPanel"
        Me.pagesFlowLayoutPanel.Size = New System.Drawing.Size(1244, 0)
        Me.pagesFlowLayoutPanel.TabIndex = 3
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Json-Datei|*.json"
        Me.SaveFileDialog1.Title = "JSON File"
        '
        'GoogleBooksAPISuche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.booksDataGridView)
        Me.Controls.Add(Me.pagesFlowLayoutPanel)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "GoogleBooksAPISuche"
        Me.Size = New System.Drawing.Size(1244, 517)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.booksDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents suchButton As Button
    Friend WithEvents suchTextBox As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents nurDECheckBox As CheckBox
    Friend WithEvents ladenButton As Button
    Friend WithEvents speichernButton As Button
    Friend WithEvents booksDataGridView As DataGridView
    Friend WithEvents titleColumn As DataGridViewTextBoxColumn
    Friend WithEvents authorsColumn As DataGridViewTextBoxColumn
    Friend WithEvents langColumn As DataGridViewTextBoxColumn
    Friend WithEvents pagesFlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
