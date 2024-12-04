<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion2
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
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.btnQuestion2_3 = New System.Windows.Forms.Button()
        Me.txtFuel = New System.Windows.Forms.TextBox()
        Me.txtDistance = New System.Windows.Forms.TextBox()
        Me.lblInfoFuelUsed = New System.Windows.Forms.Label()
        Me.lblInfoDistance = New System.Windows.Forms.Label()
        Me.grpAnalysis = New System.Windows.Forms.GroupBox()
        Me.lstAnalysis = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpInput.SuspendLayout()
        Me.grpAnalysis.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.btnQuestion2_3)
        Me.grpInput.Controls.Add(Me.txtFuel)
        Me.grpInput.Controls.Add(Me.txtDistance)
        Me.grpInput.Controls.Add(Me.lblInfoFuelUsed)
        Me.grpInput.Controls.Add(Me.lblInfoDistance)
        Me.grpInput.Location = New System.Drawing.Point(12, 12)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(348, 157)
        Me.grpInput.TabIndex = 0
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "Data Input"
        '
        'btnQuestion2_3
        '
        Me.btnQuestion2_3.Location = New System.Drawing.Point(81, 106)
        Me.btnQuestion2_3.Name = "btnQuestion2_3"
        Me.btnQuestion2_3.Size = New System.Drawing.Size(160, 38)
        Me.btnQuestion2_3.TabIndex = 4
        Me.btnQuestion2_3.Text = "Q2.3 - Enter"
        Me.btnQuestion2_3.UseVisualStyleBackColor = True
        '
        'txtFuel
        '
        Me.txtFuel.Location = New System.Drawing.Point(236, 69)
        Me.txtFuel.Name = "txtFuel"
        Me.txtFuel.Size = New System.Drawing.Size(68, 31)
        Me.txtFuel.TabIndex = 3
        '
        'txtDistance
        '
        Me.txtDistance.Location = New System.Drawing.Point(236, 30)
        Me.txtDistance.Name = "txtDistance"
        Me.txtDistance.Size = New System.Drawing.Size(68, 31)
        Me.txtDistance.TabIndex = 2
        '
        'lblInfoFuelUsed
        '
        Me.lblInfoFuelUsed.AutoSize = True
        Me.lblInfoFuelUsed.Location = New System.Drawing.Point(11, 69)
        Me.lblInfoFuelUsed.Name = "lblInfoFuelUsed"
        Me.lblInfoFuelUsed.Size = New System.Drawing.Size(230, 23)
        Me.lblInfoFuelUsed.TabIndex = 1
        Me.lblInfoFuelUsed.Text = "Litres of Fuel used:"
        '
        'lblInfoDistance
        '
        Me.lblInfoDistance.AutoSize = True
        Me.lblInfoDistance.Location = New System.Drawing.Point(22, 34)
        Me.lblInfoDistance.Name = "lblInfoDistance"
        Me.lblInfoDistance.Size = New System.Drawing.Size(219, 23)
        Me.lblInfoDistance.TabIndex = 0
        Me.lblInfoDistance.Text = "Distance Travelled:"
        '
        'grpAnalysis
        '
        Me.grpAnalysis.Controls.Add(Me.lstAnalysis)
        Me.grpAnalysis.Location = New System.Drawing.Point(14, 175)
        Me.grpAnalysis.Name = "grpAnalysis"
        Me.grpAnalysis.Size = New System.Drawing.Size(346, 280)
        Me.grpAnalysis.TabIndex = 1
        Me.grpAnalysis.TabStop = False
        Me.grpAnalysis.Text = "Analysis:"
        '
        'lstAnalysis
        '
        Me.lstAnalysis.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.lstAnalysis.FormattingEnabled = True
        Me.lstAnalysis.ItemHeight = 18
        Me.lstAnalysis.Location = New System.Drawing.Point(9, 29)
        Me.lstAnalysis.Name = "lstAnalysis"
        Me.lstAnalysis.Size = New System.Drawing.Size(331, 238)
        Me.lstAnalysis.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(15, 470)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(345, 37)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmQuestion2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(380, 524)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpAnalysis)
        Me.Controls.Add(Me.grpInput)
        Me.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQuestion2"
        Me.Text = "Question 2"
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.grpAnalysis.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpInput As GroupBox
    Friend WithEvents lblInfoFuelUsed As Label
    Friend WithEvents lblInfoDistance As Label
    Friend WithEvents btnQuestion2_3 As Button
    Friend WithEvents txtFuel As TextBox
    Friend WithEvents txtDistance As TextBox
    Friend WithEvents grpAnalysis As GroupBox
    Friend WithEvents lstAnalysis As ListBox
    Friend WithEvents btnExit As Button
End Class
