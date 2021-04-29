<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenuCatalogos
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
        Me.pbProductos = New System.Windows.Forms.PictureBox()
        Me.pbProveedor = New System.Windows.Forms.PictureBox()
        Me.pbPersonal = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.pbProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbProductos
        '
        Me.pbProductos.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.pbProductos.Image = Global.ferreteria.My.Resources.Resources.productos
        Me.pbProductos.Location = New System.Drawing.Point(12, 355)
        Me.pbProductos.Name = "pbProductos"
        Me.pbProductos.Size = New System.Drawing.Size(200, 160)
        Me.pbProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProductos.TabIndex = 8
        Me.pbProductos.TabStop = False
        '
        'pbProveedor
        '
        Me.pbProveedor.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.pbProveedor.Image = Global.ferreteria.My.Resources.Resources.proveedores
        Me.pbProveedor.Location = New System.Drawing.Point(240, 170)
        Me.pbProveedor.Name = "pbProveedor"
        Me.pbProveedor.Size = New System.Drawing.Size(200, 160)
        Me.pbProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProveedor.TabIndex = 9
        Me.pbProveedor.TabStop = False
        '
        'pbPersonal
        '
        Me.pbPersonal.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.pbPersonal.Image = Global.ferreteria.My.Resources.Resources.personal
        Me.pbPersonal.Location = New System.Drawing.Point(12, 170)
        Me.pbPersonal.Name = "pbPersonal"
        Me.pbPersonal.Size = New System.Drawing.Size(200, 160)
        Me.pbPersonal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPersonal.TabIndex = 10
        Me.pbPersonal.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.PictureBox3.Image = Global.ferreteria.My.Resources.Resources.LOGO
        Me.PictureBox3.Location = New System.Drawing.Point(17, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(417, 138)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.PictureBox1.Image = Global.ferreteria.My.Resources.Resources.categorias
        Me.PictureBox1.Location = New System.Drawing.Point(240, 355)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'FrmMenuCatalogos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.ClientSize = New System.Drawing.Size(462, 537)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.pbPersonal)
        Me.Controls.Add(Me.pbProveedor)
        Me.Controls.Add(Me.pbProductos)
        Me.Name = "FrmMenuCatalogos"
        Me.Text = "Catálogos"
        CType(Me.pbProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbProductos As PictureBox
    Friend WithEvents pbProveedor As PictureBox
    Friend WithEvents pbPersonal As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
