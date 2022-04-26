<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ventana
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ventana))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.C = New System.Windows.Forms.Button()
        Me.Sqrt = New System.Windows.Forms.Button()
        Me.Borrar = New System.Windows.Forms.Button()
        Me.dividir = New System.Windows.Forms.Button()
        Me.multiplicacion = New System.Windows.Forms.Button()
        Me.suma = New System.Windows.Forms.Button()
        Me.resta = New System.Windows.Forms.Button()
        Me.uno = New System.Windows.Forms.Button()
        Me.seis = New System.Windows.Forms.Button()
        Me.cinco = New System.Windows.Forms.Button()
        Me.cuatro = New System.Windows.Forms.Button()
        Me.nueve = New System.Windows.Forms.Button()
        Me.ocho = New System.Windows.Forms.Button()
        Me.siete = New System.Windows.Forms.Button()
        Me.dos = New System.Windows.Forms.Button()
        Me.tres = New System.Windows.Forms.Button()
        Me.cero = New System.Windows.Forms.Button()
        Me.punto = New System.Windows.Forms.Button()
        Me.igual = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(29, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(242, 40)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'C
        '
        Me.C.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C.Location = New System.Drawing.Point(29, 73)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(56, 45)
        Me.C.TabIndex = 1
        Me.C.Text = "C"
        Me.C.UseVisualStyleBackColor = True
        '
        'Sqrt
        '
        Me.Sqrt.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sqrt.Location = New System.Drawing.Point(91, 73)
        Me.Sqrt.Name = "Sqrt"
        Me.Sqrt.Size = New System.Drawing.Size(56, 45)
        Me.Sqrt.TabIndex = 2
        Me.Sqrt.Text = "Sqrt"
        Me.Sqrt.UseVisualStyleBackColor = True
        '
        'Borrar
        '
        Me.Borrar.Font = New System.Drawing.Font("News706 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrar.ForeColor = System.Drawing.Color.Black
        Me.Borrar.Location = New System.Drawing.Point(153, 73)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(56, 45)
        Me.Borrar.TabIndex = 3
        Me.Borrar.Text = "+-"
        Me.Borrar.UseVisualStyleBackColor = True
        '
        'dividir
        '
        Me.dividir.Font = New System.Drawing.Font("News706 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dividir.Location = New System.Drawing.Point(215, 73)
        Me.dividir.Name = "dividir"
        Me.dividir.Size = New System.Drawing.Size(56, 45)
        Me.dividir.TabIndex = 4
        Me.dividir.Text = "/"
        Me.dividir.UseVisualStyleBackColor = True
        '
        'multiplicacion
        '
        Me.multiplicacion.Font = New System.Drawing.Font("News706 BT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.multiplicacion.Location = New System.Drawing.Point(215, 124)
        Me.multiplicacion.Name = "multiplicacion"
        Me.multiplicacion.Size = New System.Drawing.Size(56, 45)
        Me.multiplicacion.TabIndex = 5
        Me.multiplicacion.Text = "*"
        Me.multiplicacion.UseVisualStyleBackColor = True
        '
        'suma
        '
        Me.suma.Font = New System.Drawing.Font("News706 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.suma.Location = New System.Drawing.Point(215, 175)
        Me.suma.Name = "suma"
        Me.suma.Size = New System.Drawing.Size(56, 45)
        Me.suma.TabIndex = 6
        Me.suma.Text = "+"
        Me.suma.UseVisualStyleBackColor = True
        '
        'resta
        '
        Me.resta.Font = New System.Drawing.Font("News706 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resta.Location = New System.Drawing.Point(215, 226)
        Me.resta.Name = "resta"
        Me.resta.Size = New System.Drawing.Size(56, 45)
        Me.resta.TabIndex = 7
        Me.resta.Text = "-"
        Me.resta.UseVisualStyleBackColor = True
        '
        'uno
        '
        Me.uno.Font = New System.Drawing.Font("News706 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uno.Location = New System.Drawing.Point(29, 226)
        Me.uno.Name = "uno"
        Me.uno.Size = New System.Drawing.Size(56, 45)
        Me.uno.TabIndex = 8
        Me.uno.Text = "1"
        Me.uno.UseVisualStyleBackColor = True
        '
        'seis
        '
        Me.seis.Font = New System.Drawing.Font("News706 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seis.Location = New System.Drawing.Point(153, 175)
        Me.seis.Name = "seis"
        Me.seis.Size = New System.Drawing.Size(56, 45)
        Me.seis.TabIndex = 9
        Me.seis.Text = "6"
        Me.seis.UseVisualStyleBackColor = True
        '
        'cinco
        '
        Me.cinco.Font = New System.Drawing.Font("News706 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cinco.Location = New System.Drawing.Point(91, 175)
        Me.cinco.Name = "cinco"
        Me.cinco.Size = New System.Drawing.Size(56, 45)
        Me.cinco.TabIndex = 10
        Me.cinco.Text = "5"
        Me.cinco.UseVisualStyleBackColor = True
        '
        'cuatro
        '
        Me.cuatro.Font = New System.Drawing.Font("News706 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cuatro.Location = New System.Drawing.Point(29, 175)
        Me.cuatro.Name = "cuatro"
        Me.cuatro.Size = New System.Drawing.Size(56, 45)
        Me.cuatro.TabIndex = 11
        Me.cuatro.Text = "4"
        Me.cuatro.UseVisualStyleBackColor = True
        '
        'nueve
        '
        Me.nueve.Font = New System.Drawing.Font("News706 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nueve.Location = New System.Drawing.Point(153, 124)
        Me.nueve.Name = "nueve"
        Me.nueve.Size = New System.Drawing.Size(56, 45)
        Me.nueve.TabIndex = 12
        Me.nueve.Text = "9"
        Me.nueve.UseVisualStyleBackColor = True
        '
        'ocho
        '
        Me.ocho.Font = New System.Drawing.Font("News706 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ocho.Location = New System.Drawing.Point(91, 124)
        Me.ocho.Name = "ocho"
        Me.ocho.Size = New System.Drawing.Size(56, 45)
        Me.ocho.TabIndex = 13
        Me.ocho.Text = "8"
        Me.ocho.UseVisualStyleBackColor = True
        '
        'siete
        '
        Me.siete.Font = New System.Drawing.Font("News706 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.siete.Location = New System.Drawing.Point(29, 124)
        Me.siete.Name = "siete"
        Me.siete.Size = New System.Drawing.Size(56, 45)
        Me.siete.TabIndex = 14
        Me.siete.Text = "7"
        Me.siete.UseVisualStyleBackColor = True
        '
        'dos
        '
        Me.dos.Font = New System.Drawing.Font("News706 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dos.Location = New System.Drawing.Point(91, 226)
        Me.dos.Name = "dos"
        Me.dos.Size = New System.Drawing.Size(56, 45)
        Me.dos.TabIndex = 15
        Me.dos.Text = "2"
        Me.dos.UseVisualStyleBackColor = True
        '
        'tres
        '
        Me.tres.Font = New System.Drawing.Font("News706 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tres.Location = New System.Drawing.Point(153, 226)
        Me.tres.Name = "tres"
        Me.tres.Size = New System.Drawing.Size(56, 45)
        Me.tres.TabIndex = 16
        Me.tres.Text = "3"
        Me.tres.UseVisualStyleBackColor = True
        '
        'cero
        '
        Me.cero.Font = New System.Drawing.Font("News706 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cero.Location = New System.Drawing.Point(29, 277)
        Me.cero.Name = "cero"
        Me.cero.Size = New System.Drawing.Size(56, 45)
        Me.cero.TabIndex = 17
        Me.cero.Text = "0"
        Me.cero.UseVisualStyleBackColor = True
        '
        'punto
        '
        Me.punto.Font = New System.Drawing.Font("News706 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.punto.Location = New System.Drawing.Point(91, 277)
        Me.punto.Name = "punto"
        Me.punto.Size = New System.Drawing.Size(56, 45)
        Me.punto.TabIndex = 18
        Me.punto.Text = "."
        Me.punto.UseVisualStyleBackColor = True
        '
        'igual
        '
        Me.igual.Font = New System.Drawing.Font("News706 BT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.igual.Location = New System.Drawing.Point(153, 277)
        Me.igual.Name = "igual"
        Me.igual.Size = New System.Drawing.Size(118, 45)
        Me.igual.TabIndex = 19
        Me.igual.Text = "="
        Me.igual.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 319)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 22)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 319)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 22)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(109, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 22)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Label3"
        Me.Label3.Visible = False
        '
        'ventana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(297, 344)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.igual)
        Me.Controls.Add(Me.punto)
        Me.Controls.Add(Me.cero)
        Me.Controls.Add(Me.tres)
        Me.Controls.Add(Me.dos)
        Me.Controls.Add(Me.siete)
        Me.Controls.Add(Me.ocho)
        Me.Controls.Add(Me.nueve)
        Me.Controls.Add(Me.cuatro)
        Me.Controls.Add(Me.cinco)
        Me.Controls.Add(Me.seis)
        Me.Controls.Add(Me.uno)
        Me.Controls.Add(Me.resta)
        Me.Controls.Add(Me.suma)
        Me.Controls.Add(Me.multiplicacion)
        Me.Controls.Add(Me.dividir)
        Me.Controls.Add(Me.Borrar)
        Me.Controls.Add(Me.Sqrt)
        Me.Controls.Add(Me.C)
        Me.Controls.Add(Me.TextBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Microsoft Uighur", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.Name = "ventana"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Calculadora Practica #2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents C As System.Windows.Forms.Button
    Friend WithEvents Sqrt As System.Windows.Forms.Button
    Friend WithEvents Borrar As System.Windows.Forms.Button
    Friend WithEvents dividir As System.Windows.Forms.Button
    Friend WithEvents multiplicacion As System.Windows.Forms.Button
    Friend WithEvents suma As System.Windows.Forms.Button
    Friend WithEvents resta As System.Windows.Forms.Button
    Friend WithEvents uno As System.Windows.Forms.Button
    Friend WithEvents seis As System.Windows.Forms.Button
    Friend WithEvents cinco As System.Windows.Forms.Button
    Friend WithEvents cuatro As System.Windows.Forms.Button
    Friend WithEvents nueve As System.Windows.Forms.Button
    Friend WithEvents ocho As System.Windows.Forms.Button
    Friend WithEvents siete As System.Windows.Forms.Button
    Friend WithEvents dos As System.Windows.Forms.Button
    Friend WithEvents tres As System.Windows.Forms.Button
    Friend WithEvents cero As System.Windows.Forms.Button
    Friend WithEvents punto As System.Windows.Forms.Button
    Friend WithEvents igual As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
