<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaVentaEmpleado
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
        Me.dgvConsultaDetVenta = New System.Windows.Forms.DataGridView()
        Me.nombreProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtIdPersonal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.txtCp = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvConsultaVenta = New System.Windows.Forms.DataGridView()
        Me.idVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iva = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numFctura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edoVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboNombrePersonal = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvConsultaDetVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvConsultaVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvConsultaDetVenta
        '
        Me.dgvConsultaDetVenta.AllowUserToAddRows = False
        Me.dgvConsultaDetVenta.AllowUserToDeleteRows = False
        Me.dgvConsultaDetVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvConsultaDetVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaDetVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombreProducto, Me.Cantidad, Me.Precio})
        Me.dgvConsultaDetVenta.Location = New System.Drawing.Point(78, 468)
        Me.dgvConsultaDetVenta.MultiSelect = False
        Me.dgvConsultaDetVenta.Name = "dgvConsultaDetVenta"
        Me.dgvConsultaDetVenta.ReadOnly = True
        Me.dgvConsultaDetVenta.RowHeadersWidth = 51
        Me.dgvConsultaDetVenta.RowTemplate.Height = 24
        Me.dgvConsultaDetVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConsultaDetVenta.Size = New System.Drawing.Size(850, 147)
        Me.dgvConsultaDetVenta.TabIndex = 74
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.txtIdPersonal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCelular)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.txtColonia)
        Me.GroupBox1.Controls.Add(Me.txtCp)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 194)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(928, 107)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        '
        'txtIdPersonal
        '
        Me.txtIdPersonal.AccessibleRole = System.Windows.Forms.AccessibleRole.Dial
        Me.txtIdPersonal.Enabled = False
        Me.txtIdPersonal.Font = New System.Drawing.Font("Lucida Console", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdPersonal.Location = New System.Drawing.Point(128, 21)
        Me.txtIdPersonal.Name = "txtIdPersonal"
        Me.txtIdPersonal.Size = New System.Drawing.Size(112, 24)
        Me.txtIdPersonal.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(22, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "IdPersonal:"
        '
        'txtCelular
        '
        Me.txtCelular.Enabled = False
        Me.txtCelular.Font = New System.Drawing.Font("Lucida Console", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.Location = New System.Drawing.Point(675, 59)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(229, 24)
        Me.txtCelular.TabIndex = 43
        '
        'txtTelefono
        '
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Font = New System.Drawing.Font("Lucida Console", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(398, 59)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(191, 24)
        Me.txtTelefono.TabIndex = 42
        '
        'txtColonia
        '
        Me.txtColonia.Enabled = False
        Me.txtColonia.Font = New System.Drawing.Font("Lucida Console", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColonia.Location = New System.Drawing.Point(93, 61)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(204, 24)
        Me.txtColonia.TabIndex = 41
        '
        'txtCp
        '
        Me.txtCp.Enabled = False
        Me.txtCp.Font = New System.Drawing.Font("Lucida Console", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCp.Location = New System.Drawing.Point(804, 20)
        Me.txtCp.Name = "txtCp"
        Me.txtCp.Size = New System.Drawing.Size(100, 24)
        Me.txtCp.TabIndex = 40
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Font = New System.Drawing.Font("Lucida Console", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(364, 20)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(372, 24)
        Me.txtDireccion.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(314, 63)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 17)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Teléfono:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(601, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 17)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Celular:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(752, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 17)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "C.P. :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(18, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 17)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Colonia:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(270, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Dirección:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(362, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 17)
        Me.Label7.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label11.Image = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.Label11.Location = New System.Drawing.Point(95, 147)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(170, 17)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Nombre de personal:"
        '
        'dgvConsultaVenta
        '
        Me.dgvConsultaVenta.AllowUserToAddRows = False
        Me.dgvConsultaVenta.AllowUserToDeleteRows = False
        Me.dgvConsultaVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvConsultaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsultaVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idVenta, Me.fecha, Me.subTotal, Me.iva, Me.descuento, Me.total, Me.numFctura, Me.edoVenta})
        Me.dgvConsultaVenta.Location = New System.Drawing.Point(78, 325)
        Me.dgvConsultaVenta.MultiSelect = False
        Me.dgvConsultaVenta.Name = "dgvConsultaVenta"
        Me.dgvConsultaVenta.ReadOnly = True
        Me.dgvConsultaVenta.RowHeadersWidth = 51
        Me.dgvConsultaVenta.RowTemplate.Height = 24
        Me.dgvConsultaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConsultaVenta.Size = New System.Drawing.Size(850, 117)
        Me.dgvConsultaVenta.TabIndex = 71
        '
        'idVenta
        '
        Me.idVenta.HeaderText = "idVenta"
        Me.idVenta.MinimumWidth = 6
        Me.idVenta.Name = "idVenta"
        Me.idVenta.ReadOnly = True
        '
        'fecha
        '
        Me.fecha.HeaderText = "fecha"
        Me.fecha.MinimumWidth = 6
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
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
        'descuento
        '
        Me.descuento.HeaderText = "descuento"
        Me.descuento.MinimumWidth = 6
        Me.descuento.Name = "descuento"
        Me.descuento.ReadOnly = True
        '
        'total
        '
        Me.total.HeaderText = "total"
        Me.total.MinimumWidth = 6
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'numFctura
        '
        Me.numFctura.HeaderText = "numero de factura"
        Me.numFctura.MinimumWidth = 6
        Me.numFctura.Name = "numFctura"
        Me.numFctura.ReadOnly = True
        '
        'edoVenta
        '
        Me.edoVenta.HeaderText = "Estado Venta"
        Me.edoVenta.MinimumWidth = 6
        Me.edoVenta.Name = "edoVenta"
        Me.edoVenta.ReadOnly = True
        '
        'cboNombrePersonal
        '
        Me.cboNombrePersonal.FormattingEnabled = True
        Me.cboNombrePersonal.Location = New System.Drawing.Point(276, 144)
        Me.cboNombrePersonal.Name = "cboNombrePersonal"
        Me.cboNombrePersonal.Size = New System.Drawing.Size(523, 24)
        Me.cboNombrePersonal.TabIndex = 70
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.Location = New System.Drawing.Point(823, 139)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(104, 33)
        Me.btnBuscar.TabIndex = 69
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 13.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.Image = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.Label1.Location = New System.Drawing.Point(162, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 28)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Consulta ventas por personal"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.PictureBox3.Image = Global.ferreteria.My.Resources.Resources.LOGO
        Me.PictureBox3.Location = New System.Drawing.Point(635, 16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(329, 107)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 87
        Me.PictureBox3.TabStop = False
        '
        'FrmConsultaVentaEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.ClientSize = New System.Drawing.Size(1000, 645)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvConsultaDetVenta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dgvConsultaVenta)
        Me.Controls.Add(Me.cboNombrePersonal)
        Me.Controls.Add(Me.btnBuscar)
        Me.Name = "FrmConsultaVentaEmpleado"
        Me.Text = "Consulta de ventas por empleado"
        CType(Me.dgvConsultaDetVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvConsultaVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvConsultaDetVenta As DataGridView
    Friend WithEvents nombreProducto As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dgvConsultaVenta As DataGridView
    Friend WithEvents cboNombrePersonal As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCelular As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtColonia As TextBox
    Friend WithEvents txtCp As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdPersonal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents idVenta As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents subTotal As DataGridViewTextBoxColumn
    Friend WithEvents iva As DataGridViewTextBoxColumn
    Friend WithEvents descuento As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents numFctura As DataGridViewTextBoxColumn
    Friend WithEvents edoVenta As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox3 As PictureBox
End Class
