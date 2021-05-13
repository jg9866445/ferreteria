<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmmenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmmenu))
        Me.pbPerdidas = New System.Windows.Forms.PictureBox()
        Me.pbDevoluciones = New System.Windows.Forms.PictureBox()
        Me.pbCompras = New System.Windows.Forms.PictureBox()
        Me.pbVentas = New System.Windows.Forms.PictureBox()
        Me.pbCatalogos = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarUsuarioNuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarUsuarioActualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.pbPerdidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDevoluciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCatalogos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbPerdidas
        '
        Me.pbPerdidas.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.pbPerdidas.Image = Global.ferreteria.My.Resources.Resources.perdidas
        Me.pbPerdidas.Location = New System.Drawing.Point(467, 498)
        Me.pbPerdidas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbPerdidas.Name = "pbPerdidas"
        Me.pbPerdidas.Size = New System.Drawing.Size(200, 160)
        Me.pbPerdidas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPerdidas.TabIndex = 9
        Me.pbPerdidas.TabStop = False
        '
        'pbDevoluciones
        '
        Me.pbDevoluciones.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.pbDevoluciones.Image = Global.ferreteria.My.Resources.Resources.devoluciones
        Me.pbDevoluciones.Location = New System.Drawing.Point(467, 308)
        Me.pbDevoluciones.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbDevoluciones.Name = "pbDevoluciones"
        Me.pbDevoluciones.Size = New System.Drawing.Size(200, 160)
        Me.pbDevoluciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbDevoluciones.TabIndex = 8
        Me.pbDevoluciones.TabStop = False
        '
        'pbCompras
        '
        Me.pbCompras.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.pbCompras.Image = Global.ferreteria.My.Resources.Resources.compras
        Me.pbCompras.Location = New System.Drawing.Point(37, 107)
        Me.pbCompras.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbCompras.Name = "pbCompras"
        Me.pbCompras.Size = New System.Drawing.Size(200, 160)
        Me.pbCompras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCompras.TabIndex = 7
        Me.pbCompras.TabStop = False
        '
        'pbVentas
        '
        Me.pbVentas.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.pbVentas.Image = Global.ferreteria.My.Resources.Resources.ventas
        Me.pbVentas.Location = New System.Drawing.Point(37, 308)
        Me.pbVentas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbVentas.Name = "pbVentas"
        Me.pbVentas.Size = New System.Drawing.Size(200, 160)
        Me.pbVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbVentas.TabIndex = 6
        Me.pbVentas.TabStop = False
        '
        'pbCatalogos
        '
        Me.pbCatalogos.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.pbCatalogos.Image = CType(resources.GetObject("pbCatalogos.Image"), System.Drawing.Image)
        Me.pbCatalogos.Location = New System.Drawing.Point(251, 501)
        Me.pbCatalogos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbCatalogos.Name = "pbCatalogos"
        Me.pbCatalogos.Size = New System.Drawing.Size(200, 160)
        Me.pbCatalogos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCatalogos.TabIndex = 5
        Me.pbCatalogos.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.PictureBox1.Image = Global.ferreteria.My.Resources.Resources.consultas
        Me.PictureBox1.Location = New System.Drawing.Point(251, 308)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 160)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.PictureBox2.Image = Global.ferreteria.My.Resources.Resources.reportes
        Me.PictureBox2.Location = New System.Drawing.Point(37, 498)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(200, 160)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.PictureBox3.Image = Global.ferreteria.My.Resources.Resources.LOGO
        Me.PictureBox3.Location = New System.Drawing.Point(251, 74)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(417, 213)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.PictureBox4.Image = Global.ferreteria.My.Resources.Resources.bitacora
        Me.PictureBox4.Location = New System.Drawing.Point(684, 107)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(200, 160)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 16
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.PictureBox5.Image = Global.ferreteria.My.Resources.Resources.respaldo
        Me.PictureBox5.Location = New System.Drawing.Point(684, 498)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(200, 160)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 17
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.PictureBox6.Image = Global.ferreteria.My.Resources.Resources.historicos
        Me.PictureBox6.Location = New System.Drawing.Point(684, 308)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(200, 160)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 19
        Me.PictureBox6.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(915, 49)
        Me.Panel1.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(416, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 25)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox7
        '
        Me.PictureBox7.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.PictureBox7.Image = Global.ferreteria.My.Resources.Resources.LOGO
        Me.PictureBox7.Location = New System.Drawing.Point(3, 1)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(105, 47)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 13
        Me.PictureBox7.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuarioToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(741, 5)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(83, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarUsuarioNuevoToolStripMenuItem, Me.AdministrarUsuarioActualToolStripMenuItem, Me.CerrarSesionToolStripMenuItem})
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(73, 24)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'AgregarUsuarioNuevoToolStripMenuItem
        '
        Me.AgregarUsuarioNuevoToolStripMenuItem.Name = "AgregarUsuarioNuevoToolStripMenuItem"
        Me.AgregarUsuarioNuevoToolStripMenuItem.Size = New System.Drawing.Size(269, 26)
        Me.AgregarUsuarioNuevoToolStripMenuItem.Text = "Agregar Usuario Nuevo"
        '
        'AdministrarUsuarioActualToolStripMenuItem
        '
        Me.AdministrarUsuarioActualToolStripMenuItem.Name = "AdministrarUsuarioActualToolStripMenuItem"
        Me.AdministrarUsuarioActualToolStripMenuItem.Size = New System.Drawing.Size(269, 26)
        Me.AdministrarUsuarioActualToolStripMenuItem.Text = "Administrar Usuario Actual"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(269, 26)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar Sesion"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.ClientSize = New System.Drawing.Size(915, 683)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pbPerdidas)
        Me.Controls.Add(Me.pbDevoluciones)
        Me.Controls.Add(Me.pbCompras)
        Me.Controls.Add(Me.pbVentas)
        Me.Controls.Add(Me.pbCatalogos)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Frmmenu"
        Me.Text = "menú"
        CType(Me.pbPerdidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDevoluciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCatalogos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbPerdidas As PictureBox
    Friend WithEvents pbDevoluciones As PictureBox
    Friend WithEvents pbCompras As PictureBox
    Friend WithEvents pbVentas As PictureBox
    Friend WithEvents pbCatalogos As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents UsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarUsuarioNuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministrarUsuarioActualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
