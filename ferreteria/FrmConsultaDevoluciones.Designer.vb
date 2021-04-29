<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaDevoluciones
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDevF = New System.Windows.Forms.DataGridView()
        Me.IdDevolucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDevolucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrePersonal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotivoDevolucion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvDevF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 13.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.Image = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.Label1.Location = New System.Drawing.Point(10, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(457, 28)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Consulta Devoluciones por período:"
        '
        'dgvDevF
        '
        Me.dgvDevF.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDevF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDevF.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDevolucion, Me.FechaDevolucion, Me.NombrePersonal, Me.IdVenta, Me.MotivoDevolucion})
        Me.dgvDevF.Location = New System.Drawing.Point(33, 203)
        Me.dgvDevF.Name = "dgvDevF"
        Me.dgvDevF.RowHeadersWidth = 51
        Me.dgvDevF.RowTemplate.Height = 24
        Me.dgvDevF.Size = New System.Drawing.Size(755, 249)
        Me.dgvDevF.TabIndex = 40
        '
        'IdDevolucion
        '
        Me.IdDevolucion.HeaderText = "idDevolucion"
        Me.IdDevolucion.MinimumWidth = 6
        Me.IdDevolucion.Name = "IdDevolucion"
        '
        'FechaDevolucion
        '
        Me.FechaDevolucion.HeaderText = "Fecha Devolucion"
        Me.FechaDevolucion.MinimumWidth = 6
        Me.FechaDevolucion.Name = "FechaDevolucion"
        '
        'NombrePersonal
        '
        Me.NombrePersonal.HeaderText = "NombrePersonal"
        Me.NombrePersonal.MinimumWidth = 6
        Me.NombrePersonal.Name = "NombrePersonal"
        '
        'IdVenta
        '
        Me.IdVenta.HeaderText = "IdVenta"
        Me.IdVenta.MinimumWidth = 6
        Me.IdVenta.Name = "IdVenta"
        '
        'MotivoDevolucion
        '
        Me.MotivoDevolucion.HeaderText = "Motivo Devolucion"
        Me.MotivoDevolucion.MinimumWidth = 6
        Me.MotivoDevolucion.Name = "MotivoDevolucion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label4.Image = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.Label4.Location = New System.Drawing.Point(41, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 17)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Entre fecha inicial:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Label2.Image = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.Label2.Location = New System.Drawing.Point(41, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 17)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "a fecha final:"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Lucida Calligraphy", 7.5!, System.Drawing.FontStyle.Bold)
        Me.Button5.Location = New System.Drawing.Point(303, 153)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(104, 33)
        Me.Button5.TabIndex = 59
        Me.Button5.Text = "Buscar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.PictureBox3.Image = Global.ferreteria.My.Resources.Resources.LOGO
        Me.PictureBox3.Location = New System.Drawing.Point(473, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(315, 167)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 87
        Me.PictureBox3.TabStop = False
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(207, 113)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(200, 22)
        Me.dtpFechaFinal.TabIndex = 89
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(207, 72)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(200, 22)
        Me.dtpFechaInicial.TabIndex = 88
        '
        'FrmConsultaDevoluciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.ClientSize = New System.Drawing.Size(813, 476)
        Me.Controls.Add(Me.dtpFechaFinal)
        Me.Controls.Add(Me.dtpFechaInicial)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvDevF)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmConsultaDevoluciones"
        Me.Text = "Consulta por devoluciones"
        CType(Me.dgvDevF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDevF As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents dtpFechaInicial As DateTimePicker
    Friend WithEvents IdDevolucion As DataGridViewTextBoxColumn
    Friend WithEvents FechaDevolucion As DataGridViewTextBoxColumn
    Friend WithEvents NombrePersonal As DataGridViewTextBoxColumn
    Friend WithEvents IdVenta As DataGridViewTextBoxColumn
    Friend WithEvents MotivoDevolucion As DataGridViewTextBoxColumn
End Class
