<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPickMap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPickMap))
        Me.BtnMapCoah = New System.Windows.Forms.Button
        Me.BtnZac = New System.Windows.Forms.Button
        Me.BtnTamps = New System.Windows.Forms.Button
        Me.BtnNL = New System.Windows.Forms.Button
        Me.BtnDgo = New System.Windows.Forms.Button
        Me.BtnSLP = New System.Windows.Forms.Button
        Me.BtnChih = New System.Windows.Forms.Button
        Me.BtnVolver = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'BtnMapCoah
        '
        Me.BtnMapCoah.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMapCoah.Location = New System.Drawing.Point(100, 114)
        Me.BtnMapCoah.Name = "BtnMapCoah"
        Me.BtnMapCoah.Size = New System.Drawing.Size(158, 55)
        Me.BtnMapCoah.TabIndex = 0
        Me.BtnMapCoah.Text = "COAHUILA"
        Me.BtnMapCoah.UseVisualStyleBackColor = True
        '
        'BtnZac
        '
        Me.BtnZac.Enabled = False
        Me.BtnZac.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnZac.Location = New System.Drawing.Point(272, 284)
        Me.BtnZac.Name = "BtnZac"
        Me.BtnZac.Size = New System.Drawing.Size(158, 55)
        Me.BtnZac.TabIndex = 1
        Me.BtnZac.Text = "ZACATECAS"
        Me.BtnZac.UseVisualStyleBackColor = True
        '
        'BtnTamps
        '
        Me.BtnTamps.Enabled = False
        Me.BtnTamps.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTamps.Location = New System.Drawing.Point(447, 114)
        Me.BtnTamps.Name = "BtnTamps"
        Me.BtnTamps.Size = New System.Drawing.Size(158, 55)
        Me.BtnTamps.TabIndex = 2
        Me.BtnTamps.Text = "TAMAULIPAS"
        Me.BtnTamps.UseVisualStyleBackColor = True
        '
        'BtnNL
        '
        Me.BtnNL.Enabled = False
        Me.BtnNL.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNL.Location = New System.Drawing.Point(272, 114)
        Me.BtnNL.Name = "BtnNL"
        Me.BtnNL.Size = New System.Drawing.Size(158, 55)
        Me.BtnNL.TabIndex = 3
        Me.BtnNL.Text = "NUEVO LEÓN"
        Me.BtnNL.UseVisualStyleBackColor = True
        '
        'BtnDgo
        '
        Me.BtnDgo.Enabled = False
        Me.BtnDgo.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDgo.Location = New System.Drawing.Point(100, 284)
        Me.BtnDgo.Name = "BtnDgo"
        Me.BtnDgo.Size = New System.Drawing.Size(158, 55)
        Me.BtnDgo.TabIndex = 4
        Me.BtnDgo.Text = "DURANGO"
        Me.BtnDgo.UseVisualStyleBackColor = True
        '
        'BtnSLP
        '
        Me.BtnSLP.Enabled = False
        Me.BtnSLP.Font = New System.Drawing.Font("Maiandra GD", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSLP.Location = New System.Drawing.Point(447, 284)
        Me.BtnSLP.Name = "BtnSLP"
        Me.BtnSLP.Size = New System.Drawing.Size(158, 55)
        Me.BtnSLP.TabIndex = 5
        Me.BtnSLP.Text = "SAN LUIS POTOSI"
        Me.BtnSLP.UseVisualStyleBackColor = True
        '
        'BtnChih
        '
        Me.BtnChih.Enabled = False
        Me.BtnChih.Font = New System.Drawing.Font("Maiandra GD", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChih.Location = New System.Drawing.Point(272, 198)
        Me.BtnChih.Name = "BtnChih"
        Me.BtnChih.Size = New System.Drawing.Size(158, 55)
        Me.BtnChih.TabIndex = 6
        Me.BtnChih.Text = "CHIHUAHUA"
        Me.BtnChih.UseVisualStyleBackColor = True
        '
        'BtnVolver
        '
        Me.BtnVolver.Location = New System.Drawing.Point(605, 382)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(75, 23)
        Me.BtnVolver.TabIndex = 7
        Me.BtnVolver.Text = "VOLVER"
        Me.BtnVolver.UseVisualStyleBackColor = True
        '
        'FrmPickMap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.PickMap
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(692, 417)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.BtnChih)
        Me.Controls.Add(Me.BtnSLP)
        Me.Controls.Add(Me.BtnDgo)
        Me.Controls.Add(Me.BtnNL)
        Me.Controls.Add(Me.BtnTamps)
        Me.Controls.Add(Me.BtnZac)
        Me.Controls.Add(Me.BtnMapCoah)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmPickMap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elige un Mapa - Une y Aprende®"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnMapCoah As System.Windows.Forms.Button
    Friend WithEvents BtnZac As System.Windows.Forms.Button
    Friend WithEvents BtnTamps As System.Windows.Forms.Button
    Friend WithEvents BtnNL As System.Windows.Forms.Button
    Friend WithEvents BtnDgo As System.Windows.Forms.Button
    Friend WithEvents BtnSLP As System.Windows.Forms.Button
    Friend WithEvents BtnChih As System.Windows.Forms.Button
    Friend WithEvents BtnVolver As System.Windows.Forms.Button
End Class
