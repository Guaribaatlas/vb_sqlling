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
        Me.Search_label = New System.Windows.Forms.Label()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.add_user_group = New System.Windows.Forms.GroupBox()
        Me.Insert_button = New System.Windows.Forms.Button()
        Me.Country_box = New System.Windows.Forms.TextBox()
        Me.Nom_box = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.add_user_group.SuspendLayout()
        Me.SuspendLayout()
        '
        'Search_label
        '
        Me.Search_label.AutoSize = True
        Me.Search_label.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Search_label.Location = New System.Drawing.Point(54, 46)
        Me.Search_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Search_label.Name = "Search_label"
        Me.Search_label.Size = New System.Drawing.Size(74, 23)
        Me.Search_label.TabIndex = 1
        Me.Search_label.Text = "Search"
        '
        'SearchBox
        '
        Me.SearchBox.Location = New System.Drawing.Point(136, 42)
        Me.SearchBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(377, 27)
        Me.SearchBox.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Crimson
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(54, 99)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(851, 294)
        Me.DataGridView1.TabIndex = 3
        '
        'add_user_group
        '
        Me.add_user_group.BackColor = System.Drawing.Color.LavenderBlush
        Me.add_user_group.Controls.Add(Me.Insert_button)
        Me.add_user_group.Controls.Add(Me.Country_box)
        Me.add_user_group.Controls.Add(Me.Nom_box)
        Me.add_user_group.Controls.Add(Me.Label3)
        Me.add_user_group.Controls.Add(Me.Label2)
        Me.add_user_group.Location = New System.Drawing.Point(54, 416)
        Me.add_user_group.Name = "add_user_group"
        Me.add_user_group.Size = New System.Drawing.Size(851, 118)
        Me.add_user_group.TabIndex = 4
        Me.add_user_group.TabStop = False
        Me.add_user_group.Text = "add user"
        '
        'Insert_button
        '
        Me.Insert_button.Location = New System.Drawing.Point(674, 32)
        Me.Insert_button.Name = "Insert_button"
        Me.Insert_button.Size = New System.Drawing.Size(149, 62)
        Me.Insert_button.TabIndex = 7
        Me.Insert_button.Text = "Insert"
        Me.Insert_button.UseVisualStyleBackColor = True
        '
        'Country_box
        '
        Me.Country_box.Location = New System.Drawing.Point(303, 60)
        Me.Country_box.Name = "Country_box"
        Me.Country_box.Size = New System.Drawing.Size(240, 27)
        Me.Country_box.TabIndex = 6
        '
        'Nom_box
        '
        Me.Nom_box.Location = New System.Drawing.Point(6, 60)
        Me.Nom_box.Name = "Nom_box"
        Me.Nom_box.Size = New System.Drawing.Size(242, 27)
        Me.Nom_box.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(303, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Country"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(6, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nom"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Crimson
        Me.ClientSize = New System.Drawing.Size(1029, 570)
        Me.Controls.Add(Me.add_user_group)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.Search_label)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.add_user_group.ResumeLayout(False)
        Me.add_user_group.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Search_label As Label
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents add_user_group As GroupBox
    Friend WithEvents Insert_button As Button
    Friend WithEvents Country_box As TextBox
    Friend WithEvents Nom_box As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
