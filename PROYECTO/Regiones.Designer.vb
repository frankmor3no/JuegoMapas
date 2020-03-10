<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Regiones
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
        Me.BtnNoroeste = New System.Windows.Forms.Button
        Me.BtnOccidente = New System.Windows.Forms.Button
        Me.BtnNoreste = New System.Windows.Forms.Button
        Me.BtnCentro = New System.Windows.Forms.Button
        Me.BtnSur = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'BtnNoroeste
        '
        Me.BtnNoroeste.Enabled = False
        Me.BtnNoroeste.Font = New System.Drawing.Font("Maiandra GD", 24.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNoroeste.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnNoroeste.Location = New System.Drawing.Point(23, 61)
        Me.BtnNoroeste.Name = "BtnNoroeste"
        Me.BtnNoroeste.Size = New System.Drawing.Size(208, 45)
        Me.BtnNoroeste.TabIndex = 2
        Me.BtnNoroeste.Text = "NOROESTE"
        Me.BtnNoroeste.UseVisualStyleBackColor = True
        '
        'BtnOccidente
        '
        Me.BtnOccidente.Enabled = False
        Me.BtnOccidente.Font = New System.Drawing.Font("Maiandra GD", 24.0!, System.Drawing.FontStyle.Bold)
        Me.BtnOccidente.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnOccidente.Location = New System.Drawing.Point(205, 146)
        Me.BtnOccidente.Name = "BtnOccidente"
        Me.BtnOccidente.Size = New System.Drawing.Size(215, 41)
        Me.BtnOccidente.TabIndex = 3
        Me.BtnOccidente.Text = "OCCIDENTE"
        Me.BtnOccidente.UseVisualStyleBackColor = True
        '
        'BtnNoreste
        '
        Me.BtnNoreste.Font = New System.Drawing.Font("Maiandra GD", 24.0!, System.Drawing.FontStyle.Bold)
        Me.BtnNoreste.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnNoreste.Location = New System.Drawing.Point(376, 61)
        Me.BtnNoreste.Name = "BtnNoreste"
        Me.BtnNoreste.Size = New System.Drawing.Size(208, 45)
        Me.BtnNoreste.TabIndex = 4
        Me.BtnNoreste.Text = "NORESTE"
        Me.BtnNoreste.UseVisualStyleBackColor = True
        '
        'BtnCentro
        '
        Me.BtnCentro.Enabled = False
        Me.BtnCentro.Font = New System.Drawing.Font("Maiandra GD", 24.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCentro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnCentro.Location = New System.Drawing.Point(49, 206)
        Me.BtnCentro.Name = "BtnCentro"
        Me.BtnCentro.Size = New System.Drawing.Size(165, 45)
        Me.BtnCentro.TabIndex = 5
        Me.BtnCentro.Text = "CENTRO"
        Me.BtnCentro.UseVisualStyleBackColor = True
        '
        'BtnSur
        '
        Me.BtnSur.Enabled = False
        Me.BtnSur.Font = New System.Drawing.Font("Maiandra GD", 24.0!, System.Drawing.FontStyle.Bold)
        Me.BtnSur.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSur.Location = New System.Drawing.Point(414, 206)
        Me.BtnSur.Name = "BtnSur"
        Me.BtnSur.Size = New System.Drawing.Size(195, 45)
        Me.BtnSur.TabIndex = 6
        Me.BtnSur.Text = "SUR"
        Me.BtnSur.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Font = New System.Drawing.Font("Maiandra GD", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Button5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Button5.Location = New System.Drawing.Point(229, 261)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(177, 43)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "SURESTE"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(23, 342)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "VOLVER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Regiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.PicRegion
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(620, 377)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.BtnSur)
        Me.Controls.Add(Me.BtnCentro)
        Me.Controls.Add(Me.BtnNoreste)
        Me.Controls.Add(Me.BtnOccidente)
        Me.Controls.Add(Me.BtnNoroeste)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Regiones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Regiones - Une y Aprende®"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnNoroeste As System.Windows.Forms.Button
    Friend WithEvents BtnOccidente As System.Windows.Forms.Button
    Friend WithEvents BtnNoreste As System.Windows.Forms.Button
    Friend WithEvents BtnCentro As System.Windows.Forms.Button
    Friend WithEvents BtnSur As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
