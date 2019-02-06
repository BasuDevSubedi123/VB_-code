<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.grpBands = New System.Windows.Forms.GroupBox()
        Me.radFooFighters = New System.Windows.Forms.RadioButton()
        Me.radNirvana = New System.Windows.Forms.RadioButton()
        Me.radRedHotPeppers = New System.Windows.Forms.RadioButton()
        Me.radMetallica = New System.Windows.Forms.RadioButton()
        Me.radBeatles = New System.Windows.Forms.RadioButton()
        Me.lblMember1 = New System.Windows.Forms.Label()
        Me.lblMember2 = New System.Windows.Forms.Label()
        Me.lblMember3 = New System.Windows.Forms.Label()
        Me.lblMember4 = New System.Windows.Forms.Label()
        Me.lblMember5 = New System.Windows.Forms.Label()
        Me.grpBands.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpBands
        '
        Me.grpBands.Controls.Add(Me.radFooFighters)
        Me.grpBands.Controls.Add(Me.radNirvana)
        Me.grpBands.Controls.Add(Me.radRedHotPeppers)
        Me.grpBands.Controls.Add(Me.radMetallica)
        Me.grpBands.Controls.Add(Me.radBeatles)
        Me.grpBands.Location = New System.Drawing.Point(51, 82)
        Me.grpBands.Name = "grpBands"
        Me.grpBands.Size = New System.Drawing.Size(156, 313)
        Me.grpBands.TabIndex = 0
        Me.grpBands.TabStop = False
        Me.grpBands.Text = "Select a Band"
        '
        'radFooFighters
        '
        Me.radFooFighters.AutoSize = True
        Me.radFooFighters.Location = New System.Drawing.Point(18, 268)
        Me.radFooFighters.Name = "radFooFighters"
        Me.radFooFighters.Size = New System.Drawing.Size(83, 17)
        Me.radFooFighters.TabIndex = 4
        Me.radFooFighters.TabStop = True
        Me.radFooFighters.Text = "Foo Fighters"
        Me.radFooFighters.UseVisualStyleBackColor = True
        '
        'radNirvana
        '
        Me.radNirvana.AutoSize = True
        Me.radNirvana.Location = New System.Drawing.Point(18, 216)
        Me.radNirvana.Name = "radNirvana"
        Me.radNirvana.Size = New System.Drawing.Size(62, 17)
        Me.radNirvana.TabIndex = 3
        Me.radNirvana.TabStop = True
        Me.radNirvana.Text = "Nirvana"
        Me.radNirvana.UseVisualStyleBackColor = True
        '
        'radRedHotPeppers
        '
        Me.radRedHotPeppers.AutoSize = True
        Me.radRedHotPeppers.Location = New System.Drawing.Point(18, 171)
        Me.radRedHotPeppers.Name = "radRedHotPeppers"
        Me.radRedHotPeppers.Size = New System.Drawing.Size(129, 17)
        Me.radRedHotPeppers.TabIndex = 2
        Me.radRedHotPeppers.TabStop = True
        Me.radRedHotPeppers.Text = "Red Hot Chili Peppers"
        Me.radRedHotPeppers.UseVisualStyleBackColor = True
        '
        'radMetallica
        '
        Me.radMetallica.AutoSize = True
        Me.radMetallica.Location = New System.Drawing.Point(18, 114)
        Me.radMetallica.Name = "radMetallica"
        Me.radMetallica.Size = New System.Drawing.Size(67, 17)
        Me.radMetallica.TabIndex = 1
        Me.radMetallica.TabStop = True
        Me.radMetallica.Text = "Metallica"
        Me.radMetallica.UseVisualStyleBackColor = True
        '
        'radBeatles
        '
        Me.radBeatles.AutoSize = True
        Me.radBeatles.Location = New System.Drawing.Point(18, 46)
        Me.radBeatles.Name = "radBeatles"
        Me.radBeatles.Size = New System.Drawing.Size(63, 17)
        Me.radBeatles.TabIndex = 0
        Me.radBeatles.TabStop = True
        Me.radBeatles.Text = " Beatles"
        Me.radBeatles.UseVisualStyleBackColor = True
        '
        'lblMember1
        '
        Me.lblMember1.Location = New System.Drawing.Point(237, 130)
        Me.lblMember1.Name = "lblMember1"
        Me.lblMember1.Size = New System.Drawing.Size(168, 24)
        Me.lblMember1.TabIndex = 1
        '
        'lblMember2
        '
        Me.lblMember2.Location = New System.Drawing.Point(237, 198)
        Me.lblMember2.Name = "lblMember2"
        Me.lblMember2.Size = New System.Drawing.Size(168, 26)
        Me.lblMember2.TabIndex = 2
        '
        'lblMember3
        '
        Me.lblMember3.Location = New System.Drawing.Point(237, 247)
        Me.lblMember3.Name = "lblMember3"
        Me.lblMember3.Size = New System.Drawing.Size(168, 23)
        Me.lblMember3.TabIndex = 3
        '
        'lblMember4
        '
        Me.lblMember4.Location = New System.Drawing.Point(240, 300)
        Me.lblMember4.Name = "lblMember4"
        Me.lblMember4.Size = New System.Drawing.Size(168, 21)
        Me.lblMember4.TabIndex = 4
        '
        'lblMember5
        '
        Me.lblMember5.Location = New System.Drawing.Point(237, 352)
        Me.lblMember5.Name = "lblMember5"
        Me.lblMember5.Size = New System.Drawing.Size(168, 26)
        Me.lblMember5.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 503)
        Me.Controls.Add(Me.lblMember5)
        Me.Controls.Add(Me.lblMember4)
        Me.Controls.Add(Me.lblMember3)
        Me.Controls.Add(Me.lblMember2)
        Me.Controls.Add(Me.lblMember1)
        Me.Controls.Add(Me.grpBands)
        Me.Name = "Form1"
        Me.Text = "Band information "
        Me.grpBands.ResumeLayout(False)
        Me.grpBands.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpBands As System.Windows.Forms.GroupBox
    Friend WithEvents radMetallica As System.Windows.Forms.RadioButton
    Friend WithEvents radBeatles As System.Windows.Forms.RadioButton
    Friend WithEvents radFooFighters As System.Windows.Forms.RadioButton
    Friend WithEvents radNirvana As System.Windows.Forms.RadioButton
    Friend WithEvents radRedHotPeppers As System.Windows.Forms.RadioButton
    Friend WithEvents lblMember1 As System.Windows.Forms.Label
    Friend WithEvents lblMember2 As System.Windows.Forms.Label
    Friend WithEvents lblMember3 As System.Windows.Forms.Label
    Friend WithEvents lblMember4 As System.Windows.Forms.Label
    Friend WithEvents lblMember5 As System.Windows.Forms.Label

End Class
