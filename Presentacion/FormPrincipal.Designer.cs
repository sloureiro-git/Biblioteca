namespace Presentacion
{
    partial class FormPrincipal
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
            groupBox1 = new GroupBox();
            textBoxID = new TextBox();
            textBoxGenero = new TextBox();
            label1 = new Label();
            textBoxFechaDeLanzamiento = new TextBox();
            label2 = new Label();
            textBoxCantidadDePaginas = new TextBox();
            label3 = new Label();
            textBoxAutor = new TextBox();
            label4 = new Label();
            textBoxNombre = new TextBox();
            label5 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            buttonAÑADIR = new Button();
            buttonELIMINAR = new Button();
            buttonACTUALIZAR = new Button();
            groupBox3 = new GroupBox();
            listBoxLIBROS = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxID);
            groupBox1.Controls.Add(textBoxGenero);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxFechaDeLanzamiento);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxCantidadDePaginas);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxAutor);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxNombre);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(334, 244);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(194, 22);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(125, 27);
            textBoxID.TabIndex = 20;
            // 
            // textBoxGenero
            // 
            textBoxGenero.Location = new Point(194, 121);
            textBoxGenero.Name = "textBoxGenero";
            textBoxGenero.Size = new Size(125, 27);
            textBoxGenero.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 14;
            label1.Text = "ID";
            // 
            // textBoxFechaDeLanzamiento
            // 
            textBoxFechaDeLanzamiento.Location = new Point(194, 187);
            textBoxFechaDeLanzamiento.Name = "textBoxFechaDeLanzamiento";
            textBoxFechaDeLanzamiento.Size = new Size(125, 27);
            textBoxFechaDeLanzamiento.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 62);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 15;
            label2.Text = "Nombre ";
            // 
            // textBoxCantidadDePaginas
            // 
            textBoxCantidadDePaginas.Location = new Point(194, 154);
            textBoxCantidadDePaginas.Name = "textBoxCantidadDePaginas";
            textBoxCantidadDePaginas.Size = new Size(125, 27);
            textBoxCantidadDePaginas.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 95);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 16;
            label3.Text = "Autor";
            // 
            // textBoxAutor
            // 
            textBoxAutor.Location = new Point(194, 88);
            textBoxAutor.Name = "textBoxAutor";
            textBoxAutor.Size = new Size(125, 27);
            textBoxAutor.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 128);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 17;
            label4.Text = "Género";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(194, 55);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(125, 27);
            textBoxNombre.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 194);
            label5.Name = "label5";
            label5.Size = new Size(158, 20);
            label5.TabIndex = 18;
            label5.Text = "Fecha de lanzamiento ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 161);
            label6.Name = "label6";
            label6.Size = new Size(150, 20);
            label6.TabIndex = 19;
            label6.Text = "Cantidad de páginas ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonAÑADIR);
            groupBox2.Controls.Add(buttonELIMINAR);
            groupBox2.Controls.Add(buttonACTUALIZAR);
            groupBox2.Location = new Point(12, 262);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(334, 176);
            groupBox2.TabIndex = 32;
            groupBox2.TabStop = false;
            // 
            // buttonAÑADIR
            // 
            buttonAÑADIR.Location = new Point(6, 26);
            buttonAÑADIR.Name = "buttonAÑADIR";
            buttonAÑADIR.Size = new Size(313, 29);
            buttonAÑADIR.TabIndex = 27;
            buttonAÑADIR.Text = "AÑADIR LIBRO";
            buttonAÑADIR.UseVisualStyleBackColor = true;
            buttonAÑADIR.Click += buttonAÑADIR_Click;
            // 
            // buttonELIMINAR
            // 
            buttonELIMINAR.Location = new Point(6, 127);
            buttonELIMINAR.Name = "buttonELIMINAR";
            buttonELIMINAR.Size = new Size(313, 29);
            buttonELIMINAR.TabIndex = 30;
            buttonELIMINAR.Text = "ELIMINAR LIBRO";
            buttonELIMINAR.UseVisualStyleBackColor = true;
            buttonELIMINAR.Click += buttonELIMINAR_Click;
            // 
            // buttonACTUALIZAR
            // 
            buttonACTUALIZAR.Location = new Point(6, 78);
            buttonACTUALIZAR.Name = "buttonACTUALIZAR";
            buttonACTUALIZAR.Size = new Size(313, 29);
            buttonACTUALIZAR.TabIndex = 29;
            buttonACTUALIZAR.Text = "ACTUALIZAR LIBRO";
            buttonACTUALIZAR.UseVisualStyleBackColor = true;
            buttonACTUALIZAR.Click += buttonACTUALIZAR_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listBoxLIBROS);
            groupBox3.Location = new Point(352, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(445, 426);
            groupBox3.TabIndex = 33;
            groupBox3.TabStop = false;
            // 
            // listBoxLIBROS
            // 
            listBoxLIBROS.FormattingEnabled = true;
            listBoxLIBROS.Location = new Point(6, 22);
            listBoxLIBROS.Name = "listBoxLIBROS";
            listBoxLIBROS.Size = new Size(430, 384);
            listBoxLIBROS.TabIndex = 33;
            listBoxLIBROS.SelectedIndexChanged += listBoxLIBROS_SelectedIndexChanged;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormPrincipal";
            Text = "Biblioteca";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxID;
        private TextBox textBoxGenero;
        private Label label1;
        private TextBox textBoxFechaDeLanzamiento;
        private Label label2;
        private TextBox textBoxCantidadDePaginas;
        private Label label3;
        private TextBox textBoxAutor;
        private Label label4;
        private TextBox textBoxNombre;
        private Label label5;
        private Label label6;
        private GroupBox groupBox2;
        private Button buttonAÑADIR;
        private Button buttonELIMINAR;
        private Button buttonACTUALIZAR;
        private GroupBox groupBox3;
        private ListBox listBoxLIBROS;
    }
}
