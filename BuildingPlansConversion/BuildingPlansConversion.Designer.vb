<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuildingPlans
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblAmountPrompt = New System.Windows.Forms.Label()
        Me.txtInchMeter = New System.Windows.Forms.TextBox()
        Me.grpConversion = New System.Windows.Forms.GroupBox()
        Me.radInchToMeter = New System.Windows.Forms.RadioButton()
        Me.radMetersToInches = New System.Windows.Forms.RadioButton()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.grpConversion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblHeading.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Cyan
        Me.lblHeading.Location = New System.Drawing.Point(265, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(380, 34)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Metric/Imperial Converter"
        '
        'lblAmountPrompt
        '
        Me.lblAmountPrompt.AutoSize = True
        Me.lblAmountPrompt.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountPrompt.ForeColor = System.Drawing.Color.Cyan
        Me.lblAmountPrompt.Location = New System.Drawing.Point(112, 57)
        Me.lblAmountPrompt.Name = "lblAmountPrompt"
        Me.lblAmountPrompt.Size = New System.Drawing.Size(556, 29)
        Me.lblAmountPrompt.TabIndex = 1
        Me.lblAmountPrompt.Text = "Enter amount to be converted (inches/meters)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtInchMeter
        '
        Me.txtInchMeter.AcceptsReturn = True
        Me.txtInchMeter.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInchMeter.Location = New System.Drawing.Point(711, 50)
        Me.txtInchMeter.Name = "txtInchMeter"
        Me.txtInchMeter.Size = New System.Drawing.Size(87, 36)
        Me.txtInchMeter.TabIndex = 2
        Me.txtInchMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpConversion
        '
        Me.grpConversion.Controls.Add(Me.radMetersToInches)
        Me.grpConversion.Controls.Add(Me.radInchToMeter)
        Me.grpConversion.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpConversion.ForeColor = System.Drawing.Color.Cyan
        Me.grpConversion.Location = New System.Drawing.Point(12, 127)
        Me.grpConversion.Name = "grpConversion"
        Me.grpConversion.Size = New System.Drawing.Size(887, 198)
        Me.grpConversion.TabIndex = 3
        Me.grpConversion.TabStop = False
        Me.grpConversion.Text = "Conversion"
        '
        'radInchToMeter
        '
        Me.radInchToMeter.AutoSize = True
        Me.radInchToMeter.Location = New System.Drawing.Point(209, 35)
        Me.radInchToMeter.Name = "radInchToMeter"
        Me.radInchToMeter.Size = New System.Drawing.Size(478, 33)
        Me.radInchToMeter.TabIndex = 0
        Me.radInchToMeter.TabStop = True
        Me.radInchToMeter.Text = "Imperial to Metric (inches to meters)"
        Me.radInchToMeter.UseVisualStyleBackColor = True
        '
        'radMetersToInches
        '
        Me.radMetersToInches.AutoSize = True
        Me.radMetersToInches.Location = New System.Drawing.Point(209, 97)
        Me.radMetersToInches.Name = "radMetersToInches"
        Me.radMetersToInches.Size = New System.Drawing.Size(478, 33)
        Me.radMetersToInches.TabIndex = 1
        Me.radMetersToInches.TabStop = True
        Me.radMetersToInches.Text = "Metric to Imperial (meters to inches)"
        Me.radMetersToInches.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.Color.DimGray
        Me.btnCalc.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.ForeColor = System.Drawing.Color.Cyan
        Me.btnCalc.Location = New System.Drawing.Point(229, 397)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(139, 34)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DimGray
        Me.btnClear.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Cyan
        Me.btnClear.Location = New System.Drawing.Point(543, 397)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(139, 34)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.ForeColor = System.Drawing.Color.Cyan
        Me.lblOutput.Location = New System.Drawing.Point(234, 343)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(171, 29)
        Me.lblOutput.TabIndex = 6
        Me.lblOutput.Text = "Output Label"
        '
        'frmBuildingPlans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(911, 490)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.grpConversion)
        Me.Controls.Add(Me.txtInchMeter)
        Me.Controls.Add(Me.lblAmountPrompt)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmBuildingPlans"
        Me.Text = "Building Plans Conversion"
        Me.grpConversion.ResumeLayout(False)
        Me.grpConversion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblAmountPrompt As Label
    Friend WithEvents txtInchMeter As TextBox
    Friend WithEvents grpConversion As GroupBox
    Friend WithEvents radMetersToInches As RadioButton
    Friend WithEvents radInchToMeter As RadioButton
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblOutput As Label
End Class
