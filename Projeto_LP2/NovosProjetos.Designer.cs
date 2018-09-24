namespace Projeto_LP2
{
    partial class Novos_Projetos
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selecionar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_NomeProjNovoProj = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Propriedade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.removerPropriedade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do Projeto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Propriedades";
            // 
            // selecionar
            // 
            this.selecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selecionar.Location = new System.Drawing.Point(338, 129);
            this.selecionar.Name = "selecionar";
            this.selecionar.Size = new System.Drawing.Size(97, 32);
            this.selecionar.TabIndex = 5;
            this.selecionar.Text = "Selecionar";
            this.selecionar.UseVisualStyleBackColor = true;
            this.selecionar.Click += new System.EventHandler(this.selecionar_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(338, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 29);
            this.button4.TabIndex = 6;
            this.button4.Text = "Exibir Relatorio";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txt_NomeProjNovoProj
            // 
            this.txt_NomeProjNovoProj.Location = new System.Drawing.Point(77, 63);
            this.txt_NomeProjNovoProj.Name = "txt_NomeProjNovoProj";
            this.txt_NomeProjNovoProj.Size = new System.Drawing.Size(235, 20);
            this.txt_NomeProjNovoProj.TabIndex = 7;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "GPS",
            "Threads",
            "Bando de dados"});
            this.comboBox.Location = new System.Drawing.Point(76, 137);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(235, 21);
            this.comboBox.TabIndex = 9;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Propriedade});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView1.Location = new System.Drawing.Point(76, 194);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(236, 205);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 36;
            // 
            // Propriedade
            // 
            this.Propriedade.Text = "Propriedade";
            this.Propriedade.Width = 196;
            // 
            // removerPropriedade
            // 
            this.removerPropriedade.Location = new System.Drawing.Point(338, 194);
            this.removerPropriedade.Name = "removerPropriedade";
            this.removerPropriedade.Size = new System.Drawing.Size(75, 23);
            this.removerPropriedade.TabIndex = 12;
            this.removerPropriedade.Text = "Remover";
            this.removerPropriedade.UseVisualStyleBackColor = true;
            this.removerPropriedade.Click += new System.EventHandler(this.remover_click);
            // 
            // Novos_Projetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 424);
            this.Controls.Add(this.removerPropriedade);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.txt_NomeProjNovoProj);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.selecionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Novos_Projetos";
            this.Text = "Novos_Projetos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selecionar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_NomeProjNovoProj;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Propriedade;
        private System.Windows.Forms.Button removerPropriedade;
    }
}