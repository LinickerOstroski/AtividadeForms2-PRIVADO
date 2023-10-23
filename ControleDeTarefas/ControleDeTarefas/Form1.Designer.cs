namespace ControleDeTarefas
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
            dgTarefas = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            txtTarefa = new TextBox();
            txtData = new TextBox();
            btnAdd = new Button();
            btnResolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgTarefas).BeginInit();
            SuspendLayout();
            // 
            // dgTarefas
            // 
            dgTarefas.BackgroundColor = SystemColors.ControlLightLight;
            dgTarefas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgTarefas.GridColor = SystemColors.Control;
            dgTarefas.Location = new Point(12, 94);
            dgTarefas.Name = "dgTarefas";
            dgTarefas.RowTemplate.Height = 25;
            dgTarefas.Size = new Size(441, 150);
            dgTarefas.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 1;
            label1.Text = "Tarefa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(190, 17);
            label2.Name = "label2";
            label2.Size = new Size(51, 25);
            label2.TabIndex = 2;
            label2.Text = "Data";
            // 
            // txtTarefa
            // 
            txtTarefa.BackColor = SystemColors.ControlLightLight;
            txtTarefa.Location = new Point(12, 45);
            txtTarefa.Name = "txtTarefa";
            txtTarefa.Size = new Size(170, 23);
            txtTarefa.TabIndex = 3;
            // 
            // txtData
            // 
            txtData.BackColor = SystemColors.ControlLightLight;
            txtData.Location = new Point(190, 45);
            txtData.Name = "txtData";
            txtData.Size = new Size(100, 23);
            txtData.TabIndex = 4;
            txtData.Text = "__/__/____";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(333, 37);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(50, 31);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnResolver
            // 
            btnResolver.BackColor = SystemColors.InactiveCaption;
            btnResolver.FlatStyle = FlatStyle.Flat;
            btnResolver.Location = new Point(389, 37);
            btnResolver.Name = "btnResolver";
            btnResolver.Size = new Size(64, 31);
            btnResolver.TabIndex = 6;
            btnResolver.Text = "Resolver";
            btnResolver.UseVisualStyleBackColor = false;
            btnResolver.Click += btnResolver_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(465, 256);
            Controls.Add(btnResolver);
            Controls.Add(btnAdd);
            Controls.Add(txtData);
            Controls.Add(txtTarefa);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgTarefas);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Controle de tarefas";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgTarefas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgTarefas;
        private Label label1;
        private Label label2;
        private TextBox txtTarefa;
        private TextBox txtData;
        private Button btnAdd;
        private Button btnResolver;
    }
}