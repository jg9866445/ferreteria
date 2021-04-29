<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTraspaso
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
        Me.btnTraspaso = New System.Windows.Forms.Button()
        Me.cboPeriodoTraspaso = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTraspaso
        '
        Me.btnTraspaso.Location = New System.Drawing.Point(164, 311)
        Me.btnTraspaso.Name = "btnTraspaso"
        Me.btnTraspaso.Size = New System.Drawing.Size(188, 47)
        Me.btnTraspaso.TabIndex = 1
        Me.btnTraspaso.Text = "Traspaso a historicos"
        Me.btnTraspaso.UseVisualStyleBackColor = True
        '
        'cboPeriodoTraspaso
        '
        Me.cboPeriodoTraspaso.FormattingEnabled = True
        Me.cboPeriodoTraspaso.Location = New System.Drawing.Point(199, 263)
        Me.cboPeriodoTraspaso.Name = "cboPeriodoTraspaso"
        Me.cboPeriodoTraspaso.Size = New System.Drawing.Size(121, 24)
        Me.cboPeriodoTraspaso.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Lucida Calligraphy", 13.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.Image = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.Label1.Location = New System.Drawing.Point(105, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(371, 33)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Traspaso a historicos"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(253, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Lucida Calligraphy", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.Label2.Location = New System.Drawing.Point(27, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(485, 33)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Por favor ingrese el año a enviar a historicos"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.PictureBox3.Image = Global.ferreteria.My.Resources.Resources.LOGO
        Me.PictureBox3.Location = New System.Drawing.Point(110, 23)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(293, 117)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 69
        Me.PictureBox3.TabStop = False
        '
        'FrmTraspaso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ferreteria.My.Resources.Resources.fed11c516d402c77c569d4856e521056
        Me.ClientSize = New System.Drawing.Size(524, 390)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboPeriodoTraspaso)
        Me.Controls.Add(Me.btnTraspaso)
        Me.Name = "FrmTraspaso"
        Me.Text = "FrmTraspaso"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTraspaso As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboPeriodoTraspaso As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
