<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPRINCIPAL
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
        Me.components = New System.ComponentModel.Container()
        Me.ALUMNOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CENTRO_MEDICDataSet = New RegistrarMatricula.CENTRO_MEDICDataSet()
        Me.ALUMNOSTableAdapter = New RegistrarMatricula.CENTRO_MEDICDataSetTableAdapters.ALUMNOSTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.ALUMNOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CENTRO_MEDICDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ALUMNOSBindingSource
        '
        Me.ALUMNOSBindingSource.DataMember = "ALUMNOS"
        Me.ALUMNOSBindingSource.DataSource = Me.CENTRO_MEDICDataSet
        '
        'CENTRO_MEDICDataSet
        '
        Me.CENTRO_MEDICDataSet.DataSetName = "CENTRO_MEDICDataSet"
        Me.CENTRO_MEDICDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ALUMNOSTableAdapter
        '
        Me.ALUMNOSTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(82, 76)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(339, 88)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "CONSULTA GENERAL"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Enabled = False
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(132, 199)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(230, 40)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(486, 291)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Button3)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "FORMULARIO PRINCIPAL"
        CType(Me.ALUMNOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CENTRO_MEDICDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CENTRO_MEDICDataSet As RegistrarMatricula.CENTRO_MEDICDataSet
    Friend WithEvents ALUMNOSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ALUMNOSTableAdapter As RegistrarMatricula.CENTRO_MEDICDataSetTableAdapters.ALUMNOSTableAdapter
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button

End Class
