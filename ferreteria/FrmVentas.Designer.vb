<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentas
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
        Me.txtIdVenta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboNombreEmpleado = New System.Windows.Forms.ComboBox()
        Me.txtPersonal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboDescuento = New System.Windows.Forms.ComboBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtDetalleProducto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboNombreProducto = New System.Windows.Forms.ComboBox()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtEdoVenta = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNumFactura = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtdes = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dgvVenta = New System.Windows.Forms.DataGridView()
        Me.idProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIdVenta
        '
        Me.txtIdVenta.AccessibleRole = System.Windows.Forms.AccessibleRole.Dial
        Me.txtIdVenta.Enabled = False
        Me.txtIdVenta.Font = New System.Drawing.Font("Lucida Console", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdVenta.Location = New System.Drawing.Point(124, 29)
        Me.txtIdVenta.Name = "txtIdVenta"
        Me.txtIdVenta.Size = New System.Drawing.Size(112, 24)
        Me.txtIdVenta.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label3.Image = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.Label3.Location = New System.Drawing.Point(40, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "IdVenta:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.cboNombreEmpleado)
        Me.GroupBox1.Controls.Add(Me.txtPersonal)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(601, 125)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Personal"
        '
        'cboNombreEmpleado
        '
        Me.cboNombreEmpleado.FormattingEnabled = True
        Me.cboNombreEmpleado.Location = New System.Drawing.Point(212, 77)
        Me.cboNombreEmpleado.Name = "cboNombreEmpleado"
        Me.cboNombreEmpleado.Size = New System.Drawing.Size(362, 24)
        Me.cboNombreEmpleado.TabIndex = 27
        '
        'txtPersonal
        '
        Me.txtPersonal.AccessibleRole = System.Windows.Forms.AccessibleRole.Dial
        Me.txtPersonal.Enabled = False
        Me.txtPersonal.Font = New System.Drawing.Font("Lucida Console", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPersonal.Location = New System.Drawing.Point(134, 37)
        Me.txtPersonal.Name = "txtPersonal"
        Me.txtPersonal.Size = New System.Drawing.Size(112, 24)
        Me.txtPersonal.TabIndex = 26
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
        Me.Label11.Location = New System.Drawing.Point(29, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(177, 17)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Nombre de empleado:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(25, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 17)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "IdPersonal:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Controls.Add(Me.cboDescuento)
        Me.GroupBox2.Controls.Add(Me.txtCantidad)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnAgregar)
        Me.GroupBox2.Controls.Add(Me.txtPrecio)
        Me.GroupBox2.Controls.Add(Me.txtDetalleProducto)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cboNombreProducto)
        Me.GroupBox2.Controls.Add(Me.txtProducto)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(39, 216)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(929, 165)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Producto"
        '
        'cboDescuento
        '
        Me.cboDescuento.FormattingEnabled = True
        Me.cboDescuento.Items.AddRange(New Object() {"0", "5", "10", "15"})
        Me.cboDescuento.Location = New System.Drawing.Point(422, 121)
        Me.cboDescuento.Name = "cboDescuento"
        Me.cboDescuento.Size = New System.Drawing.Size(109, 24)
        Me.cboDescuento.TabIndex = 64
        '
        'txtCantidad
        '
        Me.txtCantidad.AccessibleRole = System.Windows.Forms.AccessibleRole.Dial
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Font = New System.Drawing.Font("Lucida Console", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(115, 122)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(191, 24)
        Me.txtCantidad.TabIndex = 63
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(23, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Cantidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(326, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "descuento:"
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.btnAgregar.Location = New System.Drawing.Point(791, 117)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(104, 33)
        Me.btnAgregar.TabIndex = 60
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtPrecio
        '
        Me.txtPrecio.AccessibleRole = System.Windows.Forms.AccessibleRole.Dial
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Font = New System.Drawing.Font("Lucida Console", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(704, 80)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(191, 24)
        Me.txtPrecio.TabIndex = 32
        '
        'txtDetalleProducto
        '
        Me.txtDetalleProducto.AccessibleRole = System.Windows.Forms.AccessibleRole.Dial
        Me.txtDetalleProducto.Enabled = False
        Me.txtDetalleProducto.Font = New System.Drawing.Font("Lucida Console", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalleProducto.Location = New System.Drawing.Point(196, 80)
        Me.txtDetalleProducto.Name = "txtDetalleProducto"
        Me.txtDetalleProducto.Size = New System.Drawing.Size(428, 24)
        Me.txtDetalleProducto.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(16, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 17)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Detalle del producto:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(635, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 17)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Precio:"
        '
        'cboNombreProducto
        '
        Me.cboNombreProducto.FormattingEnabled = True
        Me.cboNombreProducto.Location = New System.Drawing.Point(468, 38)
        Me.cboNombreProducto.Name = "cboNombreProducto"
        Me.cboNombreProducto.Size = New System.Drawing.Size(427, 24)
        Me.cboNombreProducto.TabIndex = 27
        '
        'txtProducto
        '
        Me.txtProducto.AccessibleRole = System.Windows.Forms.AccessibleRole.Dial
        Me.txtProducto.Enabled = False
        Me.txtProducto.Font = New System.Drawing.Font("Lucida Console", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducto.Location = New System.Drawing.Point(134, 37)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(112, 24)
        Me.txtProducto.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(362, 145)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 17)
        Me.Label10.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(285, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(174, 17)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Nombre de producto:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(25, 41)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 17)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "IdProducto:"
        '
        'txtFecha
        '
        Me.txtFecha.AccessibleRole = System.Windows.Forms.AccessibleRole.Dial
        Me.txtFecha.Enabled = False
        Me.txtFecha.Font = New System.Drawing.Font("Lucida Console", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(316, 28)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(158, 24)
        Me.txtFecha.TabIndex = 61
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label17.Image = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.Label17.Location = New System.Drawing.Point(248, 32)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 17)
        Me.Label17.TabIndex = 60
        Me.Label17.Text = "Fecha:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label20.Location = New System.Drawing.Point(27, 41)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(0, 17)
        Me.Label20.TabIndex = 18
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(362, 145)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 17)
        Me.Label18.TabIndex = 23
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Controls.Add(Me.txtEdoVenta)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.txtIva)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtNumFactura)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txtTotal)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtdes)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtSubtotal)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.dgvVenta)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(39, 395)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(929, 319)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de Compra"
        '
        'txtEdoVenta
        '
        Me.txtEdoVenta.AccessibleRole = System.Windows.Forms.AccessibleRole.Dial
        Me.txtEdoVenta.Enabled = False
        Me.txtEdoVenta.Font = New System.Drawing.Font("Lucida Console", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdoVenta.Location = New System.Drawing.Point(784, 30)
        Me.txtEdoVenta.Name = "txtEdoVenta"
        Me.txtEdoVenta.Size = New System.Drawing.Size(112, 24)
        Me.txtEdoVenta.TabIndex = 61
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label21.Location = New System.Drawing.Point(661, 30)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(117, 17)
        Me.Label21.TabIndex = 60
        Me.Label21.Text = "Estado venta:"
        '
        'txtIva
        '
        Me.txtIva.AccessibleRole = System.Windows.Forms.AccessibleRole.Dial
        Me.txtIva.Enabled = False
        Me.txtIva.Font = New System.Drawing.Font("Lucida Console", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIva.Location = New System.Drawing.Point(576, 271)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(112, 24)
        Me.txtIva.TabIndex = 59
        Me.txtIva.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(529, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 17)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "iva:"
        '
        'txtNumFactura
        '
        Me.txtNumFactura.AccessibleRole = System.Windows.Forms.AccessibleRole.Dial
        Me.txtNumFactura.Enabled = False
        Me.txtNumFactura.Font = New System.Drawing.Font("Lucida Console", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumFactura.Location = New System.Drawing.Point(184, 34)
        Me.txtNumFactura.Name = "txtNumFactura"
        Me.txtNumFactura.Size = New System.Drawing.Size(112, 24)
        Me.txtNumFactura.TabIndex = 57
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(30, 38)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(145, 17)
        Me.Label19.TabIndex = 56
        Me.Label19.Text = "Numero Factura:"
        '
        'txtTotal
        '
        Me.txtTotal.AccessibleRole = System.Windows.Forms.AccessibleRole.Dial
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Lucida Console", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(782, 266)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(112, 24)
        Me.txtTotal.TabIndex = 55
        Me.txtTotal.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(721, 271)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 17)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Total:"
        '
        'txtdes
        '
        Me.txtdes.AccessibleRole = System.Windows.Forms.AccessibleRole.Dial
        Me.txtdes.Font = New System.Drawing.Font("Lucida Console", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdes.Location = New System.Drawing.Point(381, 275)
        Me.txtdes.Name = "txtdes"
        Me.txtdes.Size = New System.Drawing.Size(112, 24)
        Me.txtdes.TabIndex = 53
        Me.txtdes.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(274, 279)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 17)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Descuento:"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.AccessibleRole = System.Windows.Forms.AccessibleRole.Dial
        Me.txtSubtotal.Enabled = False
        Me.txtSubtotal.Font = New System.Drawing.Font("Lucida Console", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubtotal.Location = New System.Drawing.Point(124, 272)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.Size = New System.Drawing.Size(112, 24)
        Me.txtSubtotal.TabIndex = 51
        Me.txtSubtotal.Text = "0"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(40, 276)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 17)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "Subtotal:"
        '
        'dgvVenta
        '
        Me.dgvVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idProducto, Me.NombreProducto, Me.Precio, Me.Cantidad, Me.Importe})
        Me.dgvVenta.Location = New System.Drawing.Point(30, 72)
        Me.dgvVenta.Name = "dgvVenta"
        Me.dgvVenta.ReadOnly = True
        Me.dgvVenta.RowHeadersWidth = 51
        Me.dgvVenta.RowTemplate.Height = 24
        Me.dgvVenta.Size = New System.Drawing.Size(865, 175)
        Me.dgvVenta.TabIndex = 49
        '
        'idProducto
        '
        Me.idProducto.HeaderText = "idProducto"
        Me.idProducto.MinimumWidth = 6
        Me.idProducto.Name = "idProducto"
        Me.idProducto.ReadOnly = True
        '
        'NombreProducto
        '
        Me.NombreProducto.HeaderText = "Nombre Producto"
        Me.NombreProducto.MinimumWidth = 6
        Me.NombreProducto.Name = "NombreProducto"
        Me.NombreProducto.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio "
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Importe
        '
        Me.Importe.HeaderText = "Importe"
        Me.Importe.MinimumWidth = 6
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.Location = New System.Drawing.Point(623, 726)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(104, 33)
        Me.btnNuevo.TabIndex = 64
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.Location = New System.Drawing.Point(744, 726)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(104, 33)
        Me.btnGuardar.TabIndex = 63
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.btnCancelar.Location = New System.Drawing.Point(864, 725)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(104, 33)
        Me.btnCancelar.TabIndex = 62
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.PictureBox3.Image = Global.ferreteria.My.Resources.Resources.LOGO
        Me.PictureBox3.Location = New System.Drawing.Point(660, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(329, 170)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 65
        Me.PictureBox3.TabStop = False
        '
        'FrmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.ClientSize = New System.Drawing.Size(1013, 767)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtIdVenta)
        Me.Controls.Add(Me.Label3)
        Me.KeyPreview = True
        Me.Name = "FrmVentas"
        Me.Text = "Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIdVenta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboNombreEmpleado As ComboBox
    Friend WithEvents txtPersonal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtDetalleProducto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cboNombreProducto As ComboBox
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents dgvVenta As DataGridView
    Friend WithEvents idProducto As DataGridViewTextBoxColumn
    Friend WithEvents NombreProducto As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtNumFactura As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboDescuento As ComboBox
    Friend WithEvents txtdes As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtIva As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEdoVenta As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
