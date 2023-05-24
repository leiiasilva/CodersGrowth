namespace CadastroDeLivros
{
    partial class TelaCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_Titulo = new TextBox();
            txt_Autor = new TextBox();
            txt_Editora = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 89);
            label1.Name = "label1";
            label1.Size = new Size(89, 35);
            label1.TabIndex = 0;
            label1.Text = "Titulo: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 137);
            label2.Name = "label2";
            label2.Size = new Size(82, 35);
            label2.TabIndex = 1;
            label2.Text = "Autor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 190);
            label3.Name = "label3";
            label3.Size = new Size(99, 35);
            label3.TabIndex = 2;
            label3.Text = "Editora:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(10, 239);
            label4.Name = "label4";
            label4.Size = new Size(140, 35);
            label4.TabIndex = 3;
            label4.Text = "Publicação:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(306, 22);
            label5.Name = "label5";
            label5.Size = new Size(153, 46);
            label5.TabIndex = 4;
            label5.Text = "Cadastro";
            // 
            // txt_Titulo
            // 
            txt_Titulo.Location = new Point(105, 98);
            txt_Titulo.Name = "txt_Titulo";
            txt_Titulo.Size = new Size(315, 27);
            txt_Titulo.TabIndex = 5;
            // 
            // txt_Autor
            // 
            txt_Autor.Location = new Point(105, 145);
            txt_Autor.Name = "txt_Autor";
            txt_Autor.Size = new Size(316, 27);
            txt_Autor.TabIndex = 6;
            // 
            // txt_Editora
            // 
            txt_Editora.Location = new Point(111, 198);
            txt_Editora.Name = "txt_Editora";
            txt_Editora.Size = new Size(310, 27);
            txt_Editora.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(156, 246);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(314, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(395, 313);
            button1.Name = "button1";
            button1.Size = new Size(137, 38);
            button1.TabIndex = 9;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(556, 313);
            button2.Name = "button2";
            button2.Size = new Size(137, 38);
            button2.TabIndex = 10;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(txt_Editora);
            Controls.Add(txt_Autor);
            Controls.Add(txt_Titulo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaCadastro";
            Text = "TelaCadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_Titulo;
        private TextBox txt_Autor;
        private TextBox txt_Editora;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
    }
}