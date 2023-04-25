namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label1 = new Label();
            tabla = new DataGridView();
            lista = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            label2 = new Label();
            tiempolbl = new Label();
            ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(87, 176);
            button1.Name = "button1";
            button1.Size = new Size(82, 35);
            button1.TabIndex = 0;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 108);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 1;
            label1.Text = "Pon algo en la lista:";
            label1.Click += label1_Click;
            // 
            // tabla
            // 
            tabla.BackgroundColor = SystemColors.ActiveCaptionText;
            tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla.Columns.AddRange(new DataGridViewColumn[] { lista });
            tabla.Location = new Point(322, 79);
            tabla.Name = "tabla";
            tabla.RowTemplate.Height = 25;
            tabla.Size = new Size(145, 208);
            tabla.TabIndex = 2;
            // 
            // lista
            // 
            lista.HeaderText = "Lista:";
            lista.Name = "lista";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 23);
            textBox1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Liberation Mono", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(87, 79);
            label2.Name = "label2";
            label2.Size = new Size(199, 15);
            label2.TabIndex = 4;
            label2.Text = "Añadir Texto a la lista:";
            label2.Click += label2_Click;
            // 
            // tiempolbl
            // 
            tiempolbl.AutoSize = true;
            tiempolbl.ForeColor = SystemColors.Control;
            tiempolbl.Location = new Point(322, 326);
            tiempolbl.Name = "tiempolbl";
            tiempolbl.Size = new Size(47, 15);
            tiempolbl.TabIndex = 5;
            tiempolbl.Text = "Tiempo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(512, 450);
            Controls.Add(tiempolbl);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(tabla);
            Controls.Add(label1);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Lista ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private DataGridView tabla;
        private TextBox textBox1;
        private Label label2;
        private DataGridViewTextBoxColumn lista;
        private Label tiempolbl;
    }
}