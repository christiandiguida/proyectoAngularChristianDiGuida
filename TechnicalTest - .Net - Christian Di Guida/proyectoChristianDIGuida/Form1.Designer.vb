<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdentifierDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodAlojamientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlojamientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALOJAMIENTOBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DDW04PdbDataSet1 = New protectoChristianDIGuida.DDW04PdbDataSet1()
        Me.ALOJAMIENTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DDW04PdbDataSet = New protectoChristianDIGuida.DDW04PdbDataSet()
        Me.ALOJAMIENTOTableAdapter = New protectoChristianDIGuida.DDW04PdbDataSetTableAdapters.ALOJAMIENTOTableAdapter()
        Me.CodAlojamientoTextBox = New System.Windows.Forms.TextBox()
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.AlojamientoTextBox = New System.Windows.Forms.TextBox()
        Me.CodAlojamientoLabel = New System.Windows.Forms.Label()
        Me.ObservacionesLabel = New System.Windows.Forms.Label()
        Me.DireccionLabel = New System.Windows.Forms.Label()
        Me.AlojamientoLabel = New System.Windows.Forms.Label()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.ALOJAMIENTOBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DDW04PdbDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALOJAMIENTOTableAdapter1 = New protectoChristianDIGuida.DDW04PdbDataSet1TableAdapters.ALOJAMIENTOTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALOJAMIENTOBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DDW04PdbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALOJAMIENTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DDW04PdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALOJAMIENTOBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DDW04PdbDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentifierDataGridViewTextBoxColumn, Me.CodAlojamientoDataGridViewTextBoxColumn, Me.AlojamientoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ALOJAMIENTOBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(0, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(545, 445)
        Me.DataGridView1.TabIndex = 0
        '
        'IdentifierDataGridViewTextBoxColumn
        '
        Me.IdentifierDataGridViewTextBoxColumn.DataPropertyName = "Identifier"
        Me.IdentifierDataGridViewTextBoxColumn.HeaderText = "Identifier"
        Me.IdentifierDataGridViewTextBoxColumn.Name = "IdentifierDataGridViewTextBoxColumn"
        Me.IdentifierDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodAlojamientoDataGridViewTextBoxColumn
        '
        Me.CodAlojamientoDataGridViewTextBoxColumn.DataPropertyName = "CodAlojamiento"
        Me.CodAlojamientoDataGridViewTextBoxColumn.HeaderText = "CodAlojamiento"
        Me.CodAlojamientoDataGridViewTextBoxColumn.Name = "CodAlojamientoDataGridViewTextBoxColumn"
        Me.CodAlojamientoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlojamientoDataGridViewTextBoxColumn
        '
        Me.AlojamientoDataGridViewTextBoxColumn.DataPropertyName = "Alojamiento"
        Me.AlojamientoDataGridViewTextBoxColumn.HeaderText = "Alojamiento"
        Me.AlojamientoDataGridViewTextBoxColumn.Name = "AlojamientoDataGridViewTextBoxColumn"
        Me.AlojamientoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ObservacionesDataGridViewTextBoxColumn
        '
        Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
        Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
        Me.ObservacionesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ALOJAMIENTOBindingSource2
        '
        Me.ALOJAMIENTOBindingSource2.DataMember = "ALOJAMIENTO"
        Me.ALOJAMIENTOBindingSource2.DataSource = Me.DDW04PdbDataSet1
        '
        'DDW04PdbDataSet1
        '
        Me.DDW04PdbDataSet1.DataSetName = "DDW04PdbDataSet1"
        Me.DDW04PdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ALOJAMIENTOBindingSource
        '
        Me.ALOJAMIENTOBindingSource.DataMember = "ALOJAMIENTO"
        Me.ALOJAMIENTOBindingSource.DataSource = Me.DDW04PdbDataSet
        '
        'DDW04PdbDataSet
        '
        Me.DDW04PdbDataSet.DataSetName = "DDW04PdbDataSet"
        Me.DDW04PdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ALOJAMIENTOTableAdapter
        '
        Me.ALOJAMIENTOTableAdapter.ClearBeforeFill = True
        '
        'CodAlojamientoTextBox
        '
        Me.CodAlojamientoTextBox.Location = New System.Drawing.Point(577, 125)
        Me.CodAlojamientoTextBox.Name = "CodAlojamientoTextBox"
        Me.CodAlojamientoTextBox.Size = New System.Drawing.Size(192, 20)
        Me.CodAlojamientoTextBox.TabIndex = 1
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(577, 318)
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(192, 20)
        Me.ObservacionesTextBox.TabIndex = 2
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.Location = New System.Drawing.Point(577, 255)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(192, 20)
        Me.DireccionTextBox.TabIndex = 3
        '
        'AlojamientoTextBox
        '
        Me.AlojamientoTextBox.Location = New System.Drawing.Point(577, 189)
        Me.AlojamientoTextBox.Name = "AlojamientoTextBox"
        Me.AlojamientoTextBox.Size = New System.Drawing.Size(192, 20)
        Me.AlojamientoTextBox.TabIndex = 4
        '
        'CodAlojamientoLabel
        '
        Me.CodAlojamientoLabel.AutoSize = True
        Me.CodAlojamientoLabel.Location = New System.Drawing.Point(574, 109)
        Me.CodAlojamientoLabel.Name = "CodAlojamientoLabel"
        Me.CodAlojamientoLabel.Size = New System.Drawing.Size(80, 13)
        Me.CodAlojamientoLabel.TabIndex = 5
        Me.CodAlojamientoLabel.Text = "CodAlojamiento"
        '
        'ObservacionesLabel
        '
        Me.ObservacionesLabel.AutoSize = True
        Me.ObservacionesLabel.Location = New System.Drawing.Point(574, 302)
        Me.ObservacionesLabel.Name = "ObservacionesLabel"
        Me.ObservacionesLabel.Size = New System.Drawing.Size(78, 13)
        Me.ObservacionesLabel.TabIndex = 6
        Me.ObservacionesLabel.Text = "Observaciones"
        '
        'DireccionLabel
        '
        Me.DireccionLabel.AutoSize = True
        Me.DireccionLabel.Location = New System.Drawing.Point(574, 239)
        Me.DireccionLabel.Name = "DireccionLabel"
        Me.DireccionLabel.Size = New System.Drawing.Size(52, 13)
        Me.DireccionLabel.TabIndex = 7
        Me.DireccionLabel.Text = "Direccion"
        '
        'AlojamientoLabel
        '
        Me.AlojamientoLabel.AutoSize = True
        Me.AlojamientoLabel.Location = New System.Drawing.Point(574, 173)
        Me.AlojamientoLabel.Name = "AlojamientoLabel"
        Me.AlojamientoLabel.Size = New System.Drawing.Size(61, 13)
        Me.AlojamientoLabel.TabIndex = 8
        Me.AlojamientoLabel.Text = "Alojamiento"
        '
        'EditButton
        '
        Me.EditButton.Location = New System.Drawing.Point(633, 362)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(75, 23)
        Me.EditButton.TabIndex = 9
        Me.EditButton.Text = "Edit"
        Me.EditButton.UseVisualStyleBackColor = True
        '
        'ALOJAMIENTOBindingSource1
        '
        Me.ALOJAMIENTOBindingSource1.DataMember = "ALOJAMIENTO"
        Me.ALOJAMIENTOBindingSource1.DataSource = Me.DDW04PdbDataSet
        '
        'DDW04PdbDataSet1BindingSource
        '
        Me.DDW04PdbDataSet1BindingSource.DataSource = Me.DDW04PdbDataSet1
        Me.DDW04PdbDataSet1BindingSource.Position = 0
        '
        'ALOJAMIENTOTableAdapter1
        '
        Me.ALOJAMIENTOTableAdapter1.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(560, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Select the element you want to edit"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.AlojamientoLabel)
        Me.Controls.Add(Me.DireccionLabel)
        Me.Controls.Add(Me.ObservacionesLabel)
        Me.Controls.Add(Me.CodAlojamientoLabel)
        Me.Controls.Add(Me.AlojamientoTextBox)
        Me.Controls.Add(Me.DireccionTextBox)
        Me.Controls.Add(Me.ObservacionesTextBox)
        Me.Controls.Add(Me.CodAlojamientoTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALOJAMIENTOBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DDW04PdbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALOJAMIENTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DDW04PdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALOJAMIENTOBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DDW04PdbDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DDW04PdbDataSet As DDW04PdbDataSet
    Friend WithEvents ALOJAMIENTOBindingSource As BindingSource
    Friend WithEvents ALOJAMIENTOTableAdapter As DDW04PdbDataSetTableAdapters.ALOJAMIENTOTableAdapter
    Friend WithEvents CodAlojamientoTextBox As TextBox
    Friend WithEvents ObservacionesTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents AlojamientoTextBox As TextBox
    Friend WithEvents CodAlojamientoLabel As Label
    Friend WithEvents ObservacionesLabel As Label
    Friend WithEvents DireccionLabel As Label
    Friend WithEvents AlojamientoLabel As Label
    Friend WithEvents EditButton As Button
    Friend WithEvents DDW04PdbDataSet1BindingSource As BindingSource
    Friend WithEvents DDW04PdbDataSet1 As DDW04PdbDataSet1
    Friend WithEvents ALOJAMIENTOBindingSource1 As BindingSource
    Friend WithEvents ALOJAMIENTOBindingSource2 As BindingSource
    Friend WithEvents ALOJAMIENTOTableAdapter1 As DDW04PdbDataSet1TableAdapters.ALOJAMIENTOTableAdapter
    Friend WithEvents IdentifierDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodAlojamientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlojamientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ObservacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
