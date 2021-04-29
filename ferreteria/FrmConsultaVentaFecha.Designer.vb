<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConsultaVentaFecha
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Buscar = New System.Windows.Forms.Button()
        Me.dgvConsultaDet = New System.Windows.Forms.DataGridView()
        Me.nombreProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwConsultaVenta = New System.Windows.Forms.DataGridView()
        Me.idVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombrePersonal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edoVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvConsultaDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwConsultaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 13.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.Image = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.Label1.Location = New System.Drawing.Point(140, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 28)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Consulta ventas por período"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label2.Image = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.Label2.Location = New System.Drawing.Point(59, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Fecha Inicial:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label3.Image = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.Label3.Location = New System.Drawing.Point(431, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Fecha Final:"
        '
        'Buscar
        '
        Me.Buscar.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Buscar.Location = New System.Drawing.Point(786, 137)
        Me.Buscar.Name = "Buscar"
        Me.Buscar.Size = New System.Drawing.Size(104, 33)
        Me.Buscar.TabIndex = 81
        Me.Buscar.Text = "Buscar"
        Me.Buscar.UseVisualStyleBackColor = True
        '
        'dgvConsultaDet
        '
        Me.dgvConsultaDet.AllowUserToAddRows = False
        Me.dgvConsultaDet.AllowUserToDeleteRows = False
        Me.dgvConsultaDet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvConsultaDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaDet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombreProducto, Me.Cantidad, Me.Precio})
        Me.dgvConsultaDet.Location = New System.Drawing.Point(40, 353)
        Me.dgvConsultaDet.MultiSelect = False
        Me.dgvConsultaDet.Name = "dgvConsultaDet"
        Me.dgvConsultaDet.ReadOnly = True
        Me.dgvConsultaDet.RowHeadersWidth = 51
        Me.dgvConsultaDet.RowTemplate.Height = 24
        Me.dgvConsultaDet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConsultaDet.Size = New System.Drawing.Size(850, 147)
        Me.dgvConsultaDet.TabIndex = 83
        '
        'nombreProducto
        '
        Me.nombreProducto.HeaderText = "Nombre Producto"
        Me.nombreProducto.MinimumWidth = 6
        Me.nombreProducto.Name = "nombreProducto"
        Me.nombreProducto.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'dgwConsultaVenta
        '
        Me.dgwConsultaVenta.AllowUserToAddRows = False
        Me.dgwConsultaVenta.AllowUserToDeleteRows = False
        Me.dgwConsultaVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwConsultaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwConsultaVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idVenta, Me.nombrePersonal, Me.subTotal, Me.iva, Me.total, Me.fecha, Me.edoVenta})
        Me.dgwConsultaVenta.Location = New System.Drawing.Point(40, 204)
        Me.dgwConsultaVenta.MultiSelect = False
        Me.dgwConsultaVenta.Name = "dgwConsultaVenta"
        Me.dgwConsultaVenta.ReadOnly = True
        Me.dgwConsultaVenta.RowHeadersWidth = 51
        Me.dgwConsultaVenta.RowTemplate.Height = 24
        Me.dgwConsultaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwConsultaVenta.Size = New System.Drawing.Size(850, 117)
        Me.dgwConsultaVenta.TabIndex = 82
        '
        'idVenta
        '
        Me.idVenta.HeaderText = "idVenta"
        Me.idVenta.MinimumWidth = 6
        Me.idVenta.Name = "idVenta"
        Me.idVenta.ReadOnly = True
        '
        'nombrePersonal
        '
        Me.nombrePersonal.HeaderText = "Nombre de empleado"
        Me.nombrePersonal.MinimumWidth = 6
        Me.nombrePersonal.Name = "nombrePersonal"
        Me.nombrePersonal.ReadOnly = True
        '
        'subTotal
        '
        Me.subTotal.HeaderText = "subTotal"
        Me.subTotal.MinimumWidth = 6
        Me.subTotal.Name = "subTotal"
        Me.subTotal.ReadOnly = True
        '
        'iva
        '
        Me.iva.HeaderText = "iva"
        Me.iva.MinimumWidth = 6
        Me.iva.Name = "iva"
        Me.iva.ReadOnly = True
        '
        'total
        '
        Me.total.HeaderText = "total"
        Me.total.MinimumWidth = 6
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'fecha
        '
        Me.fecha.HeaderText = "fecha"
        Me.fecha.MinimumWidth = 6
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'edoVenta
        '
        Me.edoVenta.HeaderText = "Estado Venta"
        Me.edoVenta.MinimumWidth = 6
        Me.edoVenta.Name = "edoVenta"
        Me.edoVenta.ReadOnly = True
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(183, 152)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(200, 22)
        Me.dtpFechaInicial.TabIndex = 84
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(545, 148)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(200, 22)
        Me.dtpFechaFinal.TabIndex = 85
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.PictureBox3.Image = Global.ferreteria.My.Resources.Resources.LOGO
        Me.PictureBox3.Location = New System.Drawing.Point(561, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(329, 107)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 86
        Me.PictureBox3.TabStop = False
        '
        'FrmConsultaVentaFecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.ClientSize = New System.Drawing.Size(938, 529)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.dtpFechaFinal)
        Me.Controls.Add(Me.dtpFechaInicial)
        Me.Controls.Add(Me.dgvConsultaDet)
        Me.Controls.Add(Me.dgwConsultaVenta)
        Me.Controls.Add(Me.Buscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmConsultaVentaFecha"
        Me.Text = "Consulta de venta por período"
        CType(Me.dgvConsultaDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwConsultaVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Buscar As Button
    Friend WithEvents dgvConsultaDet As DataGridView
    Friend WithEvents nombreProducto As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents dgwConsultaVenta As DataGridView
    Friend WithEvents idVenta As DataGridViewTextBoxColumn
    Friend WithEvents nombrePersonal As DataGridViewTextBoxColumn
    Friend WithEvents subTotal As DataGridViewTextBoxColumn
    Friend WithEvents iva As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents edoVenta As DataGridViewTextBoxColumn
    Friend WithEvents dtpFechaInicial As DateTimePicker
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents PictureBox3 As PictureBox
End Class
