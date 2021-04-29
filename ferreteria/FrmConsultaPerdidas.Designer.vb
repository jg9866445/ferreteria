<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaPerdidas
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
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.dgvConsultaDet = New System.Windows.Forms.DataGridView()
        Me.nombreProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwConsultaPerdida = New System.Windows.Forms.DataGridView()
        Me.idVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombrePersonal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvConsultaDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwConsultaPerdida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.PictureBox3.Image = Global.ferreteria.My.Resources.Resources.LOGO
        Me.PictureBox3.Location = New System.Drawing.Point(527, 17)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(329, 107)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 95
        Me.PictureBox3.TabStop = False
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(511, 152)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(200, 22)
        Me.dtpFechaFinal.TabIndex = 94
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(149, 156)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(200, 22)
        Me.dtpFechaInicial.TabIndex = 93
        '
        'dgvConsultaDet
        '
        Me.dgvConsultaDet.AllowUserToAddRows = False
        Me.dgvConsultaDet.AllowUserToDeleteRows = False
        Me.dgvConsultaDet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvConsultaDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaDet.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombreProducto, Me.Cantidad, Me.Precio, Me.importe})
        Me.dgvConsultaDet.Location = New System.Drawing.Point(28, 343)
        Me.dgvConsultaDet.MultiSelect = False
        Me.dgvConsultaDet.Name = "dgvConsultaDet"
        Me.dgvConsultaDet.ReadOnly = True
        Me.dgvConsultaDet.RowHeadersWidth = 51
        Me.dgvConsultaDet.RowTemplate.Height = 24
        Me.dgvConsultaDet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConsultaDet.Size = New System.Drawing.Size(828, 147)
        Me.dgvConsultaDet.TabIndex = 92
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
        'importe
        '
        Me.importe.HeaderText = "importe"
        Me.importe.MinimumWidth = 6
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        '
        'dgwConsultaPerdida
        '
        Me.dgwConsultaPerdida.AllowUserToAddRows = False
        Me.dgwConsultaPerdida.AllowUserToDeleteRows = False
        Me.dgwConsultaPerdida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwConsultaPerdida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwConsultaPerdida.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idVenta, Me.nombrePersonal, Me.fecha})
        Me.dgwConsultaPerdida.Location = New System.Drawing.Point(28, 202)
        Me.dgwConsultaPerdida.MultiSelect = False
        Me.dgwConsultaPerdida.Name = "dgwConsultaPerdida"
        Me.dgwConsultaPerdida.ReadOnly = True
        Me.dgwConsultaPerdida.RowHeadersWidth = 51
        Me.dgwConsultaPerdida.RowTemplate.Height = 24
        Me.dgwConsultaPerdida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwConsultaPerdida.Size = New System.Drawing.Size(828, 117)
        Me.dgwConsultaPerdida.TabIndex = 91
        '
        'idVenta
        '
        Me.idVenta.HeaderText = "idPerdida"
        Me.idVenta.MinimumWidth = 6
        Me.idVenta.Name = "idVenta"
        Me.idVenta.ReadOnly = True
        '
        'nombrePersonal
        '
        Me.nombrePersonal.HeaderText = "concepto"
        Me.nombrePersonal.MinimumWidth = 6
        Me.nombrePersonal.Name = "nombrePersonal"
        Me.nombrePersonal.ReadOnly = True
        '
        'fecha
        '
        Me.fecha.HeaderText = "fecha"
        Me.fecha.MinimumWidth = 6
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Location = New System.Drawing.Point(752, 145)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(104, 33)
        Me.btnBuscar.TabIndex = 90
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label3.Image = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.Label3.Location = New System.Drawing.Point(397, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Fecha Final:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label2.Image = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.Label2.Location = New System.Drawing.Point(25, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Fecha Inicial:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 13.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.Image = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.Label1.Location = New System.Drawing.Point(89, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 28)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Consulta pérdidas por período"
        '
        'FrmConsultaPerdidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.ClientSize = New System.Drawing.Size(886, 517)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.dtpFechaFinal)
        Me.Controls.Add(Me.dtpFechaInicial)
        Me.Controls.Add(Me.dgvConsultaDet)
        Me.Controls.Add(Me.dgwConsultaPerdida)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmConsultaPerdidas"
        Me.Text = "FrmConsultaPerdidas"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvConsultaDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwConsultaPerdida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents dtpFechaInicial As DateTimePicker
    Friend WithEvents dgvConsultaDet As DataGridView
    Friend WithEvents nombreProducto As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents importe As DataGridViewTextBoxColumn
    Friend WithEvents dgwConsultaPerdida As DataGridView
    Friend WithEvents idVenta As DataGridViewTextBoxColumn
    Friend WithEvents nombrePersonal As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
