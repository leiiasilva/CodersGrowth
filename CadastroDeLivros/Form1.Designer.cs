namespace CadastroDeLivros
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            btn_adicionar = new Button();
            btn_Editar = new Button();
            btn_Remover = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(656, 448);
            dataGridView1.TabIndex = 1;
            // 
            // btn_adicionar
            // 
            btn_adicionar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_adicionar.Location = new Point(734, 160);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(156, 52);
            btn_adicionar.TabIndex = 2;
            btn_adicionar.Text = "ADICIONAR";
            btn_adicionar.UseVisualStyleBackColor = true;
            // 
            // btn_Editar
            // 
            btn_Editar.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Editar.Location = new Point(734, 250);
            btn_Editar.Name = "btn_Editar";
            btn_Editar.Size = new Size(156, 50);
            btn_Editar.TabIndex = 3;
            btn_Editar.Text = "EDITAR";
            btn_Editar.UseVisualStyleBackColor = true;
            // 
            // btn_Remover
            // 
            btn_Remover.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Remover.Location = new Point(736, 341);
            btn_Remover.Name = "btn_Remover";
            btn_Remover.Size = new Size(154, 51);
            btn_Remover.TabIndex = 4;
            btn_Remover.Text = "REMOVER";
            btn_Remover.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 593);
            Controls.Add(btn_Remover);
            Controls.Add(btn_Editar);
            Controls.Add(btn_adicionar);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button btn_adicionar;
        private Button btn_Editar;
        private Button btn_Remover;
    }
}