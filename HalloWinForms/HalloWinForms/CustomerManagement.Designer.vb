<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerManagement
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
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.loadButton = New System.Windows.Forms.Button()
        Me.newButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.loadButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.newButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.deleteButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(876, 48)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'loadButton
        '
        Me.loadButton.AutoSize = True
        Me.loadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.loadButton.Location = New System.Drawing.Point(3, 3)
        Me.loadButton.Name = "loadButton"
        Me.loadButton.Size = New System.Drawing.Size(88, 42)
        Me.loadButton.TabIndex = 0
        Me.loadButton.Text = "Laden"
        Me.loadButton.UseVisualStyleBackColor = True
        '
        'newButton
        '
        Me.newButton.AutoSize = True
        Me.newButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.newButton.Location = New System.Drawing.Point(97, 3)
        Me.newButton.Name = "newButton"
        Me.newButton.Size = New System.Drawing.Size(69, 42)
        Me.newButton.TabIndex = 1
        Me.newButton.Text = "Neu"
        Me.newButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.AutoSize = True
        Me.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.deleteButton.Location = New System.Drawing.Point(172, 3)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(111, 42)
        Me.deleteButton.TabIndex = 2
        Me.deleteButton.Text = "Löschen"
        Me.deleteButton.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.Size = New System.Drawing.Size(876, 435)
        Me.DataGridView1.TabIndex = 1
        '
        'CustomerManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Name = "CustomerManagement"
        Me.Size = New System.Drawing.Size(876, 483)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents loadButton As Button
    Friend WithEvents newButton As Button
    Friend WithEvents deleteButton As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
