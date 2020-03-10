<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSelect))
        Me.BtnPuzzle = New System.Windows.Forms.Button
        Me.btnLearn = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'BtnPuzzle
        '
        resources.ApplyResources(Me.BtnPuzzle, "BtnPuzzle")
        Me.BtnPuzzle.Name = "BtnPuzzle"
        Me.BtnPuzzle.UseVisualStyleBackColor = True
        '
        'btnLearn
        '
        resources.ApplyResources(Me.btnLearn, "btnLearn")
        Me.btnLearn.Name = "btnLearn"
        Me.btnLearn.UseVisualStyleBackColor = True
        '
        'FrmSelect
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.SELECCION
        Me.Controls.Add(Me.btnLearn)
        Me.Controls.Add(Me.BtnPuzzle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSelect"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnPuzzle As System.Windows.Forms.Button
    Friend WithEvents btnLearn As System.Windows.Forms.Button
End Class
