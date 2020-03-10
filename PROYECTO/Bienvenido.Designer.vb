<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUyA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUyA))
        Me.btnStrt = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnStrt
        '
        Me.btnStrt.BackColor = System.Drawing.Color.SeaGreen
        Me.btnStrt.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStrt.ForeColor = System.Drawing.SystemColors.Control
        Me.btnStrt.Location = New System.Drawing.Point(484, 399)
        Me.btnStrt.Name = "btnStrt"
        Me.btnStrt.Size = New System.Drawing.Size(119, 34)
        Me.btnStrt.TabIndex = 0
        Me.btnStrt.Text = "INICIO"
        Me.btnStrt.UseVisualStyleBackColor = False
        '
        'FrmUyA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Bienvenido
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(629, 454)
        Me.Controls.Add(Me.btnStrt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmUyA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Une y Aprende®"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStrt As System.Windows.Forms.Button

End Class
