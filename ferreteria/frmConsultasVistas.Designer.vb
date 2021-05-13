<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultasVistas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_ExportarExcel = New System.Windows.Forms.Button()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.DGVExcel = New System.Windows.Forms.DataGridView()
        Me.DGVADHOC = New System.Windows.Forms.DataGridView()
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Tabla = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Campo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAceptar = New System.Windows.Forms.Button()
        CType(Me.DGVExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVADHOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_ExportarExcel
        '
        Me.btn_ExportarExcel.Location = New System.Drawing.Point(924, 13)
        Me.btn_ExportarExcel.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_ExportarExcel.Name = "btn_ExportarExcel"
        Me.btn_ExportarExcel.Size = New System.Drawing.Size(220, 63)
        Me.btn_ExportarExcel.TabIndex = 48
        Me.btn_ExportarExcel.Text = "Exportar a Excel"
        Me.btn_ExportarExcel.UseVisualStyleBackColor = True
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(392, 27)
        Me.Label46.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(285, 31)
        Me.Label46.TabIndex = 47
        Me.Label46.Text = "Relación de productos"
        '
        'DGVExcel
        '
        Me.DGVExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVExcel.Location = New System.Drawing.Point(627, 86)
        Me.DGVExcel.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVExcel.Name = "DGVExcel"
        Me.DGVExcel.RowHeadersWidth = 51
        Me.DGVExcel.Size = New System.Drawing.Size(517, 395)
        Me.DGVExcel.TabIndex = 46
        '
        'DGVADHOC
        '
        Me.DGVADHOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVADHOC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar, Me.Tabla, Me.Campo, Me.Descripcion})
        Me.DGVADHOC.Location = New System.Drawing.Point(25, 86)
        Me.DGVADHOC.Margin = New System.Windows.Forms.Padding(4)
        Me.DGVADHOC.Name = "DGVADHOC"
        Me.DGVADHOC.RowHeadersWidth = 51
        Me.DGVADHOC.Size = New System.Drawing.Size(574, 395)
        Me.DGVADHOC.TabIndex = 45
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.MinimumWidth = 6
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.Width = 125
        '
        'Tabla
        '
        Me.Tabla.HeaderText = "Tabla"
        Me.Tabla.MinimumWidth = 6
        Me.Tabla.Name = "Tabla"
        Me.Tabla.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tabla.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Tabla.Width = 125
        '
        'Campo
        '
        Me.Campo.HeaderText = "Campo"
        Me.Campo.MinimumWidth = 6
        Me.Campo.Name = "Campo"
        Me.Campo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Campo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.Campo.Width = 125
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Width = 125
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(957, 503)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(187, 49)
        Me.btnAceptar.TabIndex = 44
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'frmConsultasVistas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1163, 575)
        Me.Controls.Add(Me.btn_ExportarExcel)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.DGVExcel)
        Me.Controls.Add(Me.DGVADHOC)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "frmConsultasVistas"
        Me.Text = "frmConsultasVistas"
        CType(Me.DGVExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVADHOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_ExportarExcel As Button
    Friend WithEvents Label46 As Label
    Friend WithEvents DGVExcel As DataGridView
    Friend WithEvents DGVADHOC As DataGridView
    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents Tabla As DataGridViewTextBoxColumn
    Friend WithEvents Campo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents btnAceptar As Button
End Class
