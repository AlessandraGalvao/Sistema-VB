<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_login
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb_login = New System.Windows.Forms.Label()
        Me.tb_usuario = New System.Windows.Forms.TextBox()
        Me.tb_senha = New System.Windows.Forms.TextBox()
        Me.bnt_login = New System.Windows.Forms.Button()
        Me.bnt_sair = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(75, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(75, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Senha"
        '
        'lb_login
        '
        Me.lb_login.AutoSize = True
        Me.lb_login.BackColor = System.Drawing.Color.Transparent
        Me.lb_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lb_login.Location = New System.Drawing.Point(103, 206)
        Me.lb_login.Name = "lb_login"
        Me.lb_login.Size = New System.Drawing.Size(0, 18)
        Me.lb_login.TabIndex = 2
        '
        'tb_usuario
        '
        Me.tb_usuario.Location = New System.Drawing.Point(142, 49)
        Me.tb_usuario.Name = "tb_usuario"
        Me.tb_usuario.Size = New System.Drawing.Size(145, 20)
        Me.tb_usuario.TabIndex = 3
        '
        'tb_senha
        '
        Me.tb_senha.Location = New System.Drawing.Point(142, 99)
        Me.tb_senha.Name = "tb_senha"
        Me.tb_senha.Size = New System.Drawing.Size(145, 20)
        Me.tb_senha.TabIndex = 4
        '
        'bnt_login
        '
        Me.bnt_login.BackColor = System.Drawing.Color.Transparent
        Me.bnt_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnt_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.bnt_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.bnt_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnt_login.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_login.ForeColor = System.Drawing.Color.Snow
        Me.bnt_login.Location = New System.Drawing.Point(115, 152)
        Me.bnt_login.Name = "bnt_login"
        Me.bnt_login.Size = New System.Drawing.Size(81, 35)
        Me.bnt_login.TabIndex = 5
        Me.bnt_login.Text = "Logar"
        Me.bnt_login.UseVisualStyleBackColor = False
        '
        'bnt_sair
        '
        Me.bnt_sair.BackColor = System.Drawing.Color.Transparent
        Me.bnt_sair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bnt_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.bnt_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue
        Me.bnt_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bnt_sair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnt_sair.ForeColor = System.Drawing.Color.Snow
        Me.bnt_sair.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.bnt_sair.Location = New System.Drawing.Point(221, 152)
        Me.bnt_sair.Name = "bnt_sair"
        Me.bnt_sair.Size = New System.Drawing.Size(88, 35)
        Me.bnt_sair.TabIndex = 6
        Me.bnt_sair.Text = "Sair"
        Me.bnt_sair.UseVisualStyleBackColor = False
        '
        'F_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(414, 261)
        Me.Controls.Add(Me.bnt_sair)
        Me.Controls.Add(Me.bnt_login)
        Me.Controls.Add(Me.tb_senha)
        Me.Controls.Add(Me.tb_usuario)
        Me.Controls.Add(Me.lb_login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "F_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lb_login As Label
    Friend WithEvents tb_usuario As TextBox
    Friend WithEvents tb_senha As TextBox
    Friend WithEvents bnt_login As Button
    Friend WithEvents bnt_sair As Button
End Class
