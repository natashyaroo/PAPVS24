<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Etalase
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.DataGridEtalase = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridEtalase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridEtalase
        '
        Me.DataGridEtalase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridEtalase.Location = New System.Drawing.Point(126, 114)
        Me.DataGridEtalase.Name = "DataGridEtalase"
        Me.DataGridEtalase.Size = New System.Drawing.Size(393, 325)
        Me.DataGridEtalase.TabIndex = 0
        '
        'Etalase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 659)
        Me.Controls.Add(Me.DataGridEtalase)
        Me.Name = "Etalase"
        Me.Text = "etalase_toko"
        CType(Me.DataGridEtalase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridEtalase As DataGridView
End Class
