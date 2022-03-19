namespace Le_Crêpier_psychorigide
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_nbCrêpe = new System.Windows.Forms.TextBox();
            this.label_info0 = new System.Windows.Forms.Label();
            this.button_generate = new System.Windows.Forms.Button();
            this.panel_crepe = new System.Windows.Forms.Panel();
            this.panel_step = new System.Windows.Forms.Panel();
            this.pictureBox_prev = new System.Windows.Forms.PictureBox();
            this.textBox_setState = new System.Windows.Forms.TextBox();
            this.label_info = new System.Windows.Forms.RichTextBox();
            this.pictureBox_next = new System.Windows.Forms.PictureBox();
            this.label_step = new System.Windows.Forms.Label();
            this.panel_ttols = new System.Windows.Forms.Panel();
            this.label_nbEssai = new System.Windows.Forms.Label();
            this.radioButton_alg2 = new System.Windows.Forms.RadioButton();
            this.radioButton_alg0 = new System.Windows.Forms.RadioButton();
            this.textBox_nbEtape = new System.Windows.Forms.TextBox();
            this.label_nbEtape = new System.Windows.Forms.Label();
            this.label_nbCrepeGénéré = new System.Windows.Forms.Label();
            this.panel_step.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_prev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_next)).BeginInit();
            this.panel_ttols.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_nbCrêpe
            // 
            this.textBox_nbCrêpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.textBox_nbCrêpe.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_nbCrêpe.Location = new System.Drawing.Point(32, 43);
            this.textBox_nbCrêpe.Name = "textBox_nbCrêpe";
            this.textBox_nbCrêpe.Size = new System.Drawing.Size(100, 31);
            this.textBox_nbCrêpe.TabIndex = 0;
            this.textBox_nbCrêpe.TextChanged += new System.EventHandler(this.textBox_nbCrêpe_TextChanged);
            this.textBox_nbCrêpe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nbCrêpe_KeyPress);
            // 
            // label_info0
            // 
            this.label_info0.AutoSize = true;
            this.label_info0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info0.Location = new System.Drawing.Point(29, 15);
            this.label_info0.Name = "label_info0";
            this.label_info0.Size = new System.Drawing.Size(345, 24);
            this.label_info0.TabIndex = 1;
            this.label_info0.Text = "Entrez le nombre de crêpes dans la pile";
            // 
            // button_generate
            // 
            this.button_generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button_generate.Location = new System.Drawing.Point(138, 43);
            this.button_generate.Name = "button_generate";
            this.button_generate.Size = new System.Drawing.Size(116, 30);
            this.button_generate.TabIndex = 2;
            this.button_generate.Text = "Générer";
            this.button_generate.UseVisualStyleBackColor = true;
            this.button_generate.Click += new System.EventHandler(this.button_generate_Click);
            // 
            // panel_crepe
            // 
            this.panel_crepe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_crepe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_crepe.Location = new System.Drawing.Point(33, 80);
            this.panel_crepe.Name = "panel_crepe";
            this.panel_crepe.Size = new System.Drawing.Size(732, 611);
            this.panel_crepe.TabIndex = 3;
            // 
            // panel_step
            // 
            this.panel_step.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_step.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_step.Controls.Add(this.pictureBox_prev);
            this.panel_step.Controls.Add(this.textBox_setState);
            this.panel_step.Controls.Add(this.label_info);
            this.panel_step.Controls.Add(this.pictureBox_next);
            this.panel_step.Controls.Add(this.label_step);
            this.panel_step.Location = new System.Drawing.Point(33, 697);
            this.panel_step.Name = "panel_step";
            this.panel_step.Size = new System.Drawing.Size(732, 99);
            this.panel_step.TabIndex = 4;
            this.panel_step.Visible = false;
            // 
            // pictureBox_prev
            // 
            this.pictureBox_prev.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox_prev.Image = global::Le_Crêpier_psychorigide.Properties.Resources.preview_step;
            this.pictureBox_prev.Location = new System.Drawing.Point(259, 38);
            this.pictureBox_prev.Name = "pictureBox_prev";
            this.pictureBox_prev.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_prev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_prev.TabIndex = 5;
            this.pictureBox_prev.TabStop = false;
            this.pictureBox_prev.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_prev_MouseDown);
            // 
            // textBox_setState
            // 
            this.textBox_setState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_setState.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.textBox_setState.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_setState.Location = new System.Drawing.Point(312, 43);
            this.textBox_setState.Name = "textBox_setState";
            this.textBox_setState.Size = new System.Drawing.Size(100, 31);
            this.textBox_setState.TabIndex = 4;
            this.textBox_setState.Visible = false;
            this.textBox_setState.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_setState_KeyDown);
            this.textBox_setState.Leave += new System.EventHandler(this.textBox_setState_Leave);
            // 
            // label_info
            // 
            this.label_info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_info.Location = new System.Drawing.Point(3, 3);
            this.label_info.Multiline = false;
            this.label_info.Name = "label_info";
            this.label_info.ReadOnly = true;
            this.label_info.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.label_info.Size = new System.Drawing.Size(724, 25);
            this.label_info.TabIndex = 3;
            this.label_info.Text = "";
            this.label_info.WordWrap = false;
            // 
            // pictureBox_next
            // 
            this.pictureBox_next.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox_next.Image = global::Le_Crêpier_psychorigide.Properties.Resources.next_step;
            this.pictureBox_next.Location = new System.Drawing.Point(424, 38);
            this.pictureBox_next.Name = "pictureBox_next";
            this.pictureBox_next.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_next.TabIndex = 2;
            this.pictureBox_next.TabStop = false;
            this.pictureBox_next.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_next_MouseDown);
            // 
            // label_step
            // 
            this.label_step.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_step.Font = new System.Drawing.Font("Yu Gothic UI", 20F, System.Drawing.FontStyle.Bold);
            this.label_step.Location = new System.Drawing.Point(305, 35);
            this.label_step.Name = "label_step";
            this.label_step.Size = new System.Drawing.Size(118, 38);
            this.label_step.TabIndex = 1;
            this.label_step.Text = "999/999";
            this.label_step.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_step.DoubleClick += new System.EventHandler(this.label_step_DoubleClick);
            // 
            // panel_ttols
            // 
            this.panel_ttols.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_ttols.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_ttols.Controls.Add(this.label_nbCrepeGénéré);
            this.panel_ttols.Controls.Add(this.label_nbEssai);
            this.panel_ttols.Controls.Add(this.radioButton_alg2);
            this.panel_ttols.Controls.Add(this.radioButton_alg0);
            this.panel_ttols.Location = new System.Drawing.Point(439, 15);
            this.panel_ttols.Name = "panel_ttols";
            this.panel_ttols.Size = new System.Drawing.Size(326, 59);
            this.panel_ttols.TabIndex = 5;
            // 
            // label_nbEssai
            // 
            this.label_nbEssai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_nbEssai.Location = new System.Drawing.Point(264, -1);
            this.label_nbEssai.Name = "label_nbEssai";
            this.label_nbEssai.Size = new System.Drawing.Size(57, 24);
            this.label_nbEssai.TabIndex = 0;
            this.label_nbEssai.Text = "0 essai(s)";
            this.label_nbEssai.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // radioButton_alg2
            // 
            this.radioButton_alg2.AutoSize = true;
            this.radioButton_alg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.radioButton_alg2.Location = new System.Drawing.Point(8, 34);
            this.radioButton_alg2.Name = "radioButton_alg2";
            this.radioButton_alg2.Size = new System.Drawing.Size(224, 24);
            this.radioButton_alg2.TabIndex = 1;
            this.radioButton_alg2.Text = "Ranger les crêpes brûlées";
            this.radioButton_alg2.UseVisualStyleBackColor = true;
            this.radioButton_alg2.CheckedChanged += new System.EventHandler(this.radioButton_alg2_CheckedChanged);
            // 
            // radioButton_alg0
            // 
            this.radioButton_alg0.AutoSize = true;
            this.radioButton_alg0.Checked = true;
            this.radioButton_alg0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.radioButton_alg0.Location = new System.Drawing.Point(8, 11);
            this.radioButton_alg0.Name = "radioButton_alg0";
            this.radioButton_alg0.Size = new System.Drawing.Size(164, 24);
            this.radioButton_alg0.TabIndex = 0;
            this.radioButton_alg0.TabStop = true;
            this.radioButton_alg0.Text = "Ranger les crêpes";
            this.radioButton_alg0.UseVisualStyleBackColor = true;
            // 
            // textBox_nbEtape
            // 
            this.textBox_nbEtape.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.textBox_nbEtape.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_nbEtape.Location = new System.Drawing.Point(350, 44);
            this.textBox_nbEtape.Name = "textBox_nbEtape";
            this.textBox_nbEtape.Size = new System.Drawing.Size(82, 31);
            this.textBox_nbEtape.TabIndex = 6;
            this.textBox_nbEtape.Visible = false;
            // 
            // label_nbEtape
            // 
            this.label_nbEtape.AutoSize = true;
            this.label_nbEtape.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nbEtape.Location = new System.Drawing.Point(260, 46);
            this.label_nbEtape.Name = "label_nbEtape";
            this.label_nbEtape.Size = new System.Drawing.Size(89, 24);
            this.label_nbEtape.TabIndex = 7;
            this.label_nbEtape.Text = "Nb Étape";
            this.label_nbEtape.Visible = false;
            // 
            // label_nbCrepeGénéré
            // 
            this.label_nbCrepeGénéré.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_nbCrepeGénéré.AutoSize = true;
            this.label_nbCrepeGénéré.Location = new System.Drawing.Point(142, -1);
            this.label_nbCrepeGénéré.Name = "label_nbCrepeGénéré";
            this.label_nbCrepeGénéré.Size = new System.Drawing.Size(104, 13);
            this.label_nbCrepeGénéré.TabIndex = 2;
            this.label_nbCrepeGénéré.Text = "0 générée(s) au total";
            this.label_nbCrepeGénéré.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 808);
            this.Controls.Add(this.label_nbEtape);
            this.Controls.Add(this.textBox_nbEtape);
            this.Controls.Add(this.panel_ttols);
            this.Controls.Add(this.panel_step);
            this.Controls.Add(this.panel_crepe);
            this.Controls.Add(this.button_generate);
            this.Controls.Add(this.label_info0);
            this.Controls.Add(this.textBox_nbCrêpe);
            this.KeyPreview = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Le Crêpier psychorigide";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown_1);
            this.panel_step.ResumeLayout(false);
            this.panel_step.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_prev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_next)).EndInit();
            this.panel_ttols.ResumeLayout(false);
            this.panel_ttols.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nbCrêpe;
        private System.Windows.Forms.Label label_info0;
        private System.Windows.Forms.Button button_generate;
        private System.Windows.Forms.Panel panel_crepe;
        private System.Windows.Forms.Panel panel_step;
        private System.Windows.Forms.PictureBox pictureBox_next;
        private System.Windows.Forms.Label label_step;
        private System.Windows.Forms.RichTextBox label_info;
        private System.Windows.Forms.Panel panel_ttols;
        private System.Windows.Forms.RadioButton radioButton_alg0;
        private System.Windows.Forms.TextBox textBox_setState;
        private System.Windows.Forms.RadioButton radioButton_alg2;
        private System.Windows.Forms.TextBox textBox_nbEtape;
        private System.Windows.Forms.Label label_nbEtape;
        private System.Windows.Forms.Label label_nbEssai;
        private System.Windows.Forms.PictureBox pictureBox_prev;
        private System.Windows.Forms.Label label_nbCrepeGénéré;
    }
}

