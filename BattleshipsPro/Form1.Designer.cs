namespace BattleshipsPro
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.VisualBoard1 = new System.Windows.Forms.DataGridView();
            this.VisualBoard2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.turnLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.VisualBoard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisualBoard2)).BeginInit();
            this.SuspendLayout();
            // 
            // VisualBoard1
            // 
            this.VisualBoard1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VisualBoard1.DefaultCellStyle = dataGridViewCellStyle3;
            this.VisualBoard1.Location = new System.Drawing.Point(0, 0);
            this.VisualBoard1.Name = "VisualBoard1";
            this.VisualBoard1.Size = new System.Drawing.Size(500, 500);
            this.VisualBoard1.TabIndex = 0;
            this.VisualBoard1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VisualBoard1_CellClick);
            this.VisualBoard1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VisualBoard1_CellClick);
            // 
            // VisualBoard2
            // 
            this.VisualBoard2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.VisualBoard2.DefaultCellStyle = dataGridViewCellStyle4;
            this.VisualBoard2.Location = new System.Drawing.Point(1000, 0);
            this.VisualBoard2.Name = "VisualBoard2";
            this.VisualBoard2.Size = new System.Drawing.Size(500, 500);
            this.VisualBoard2.TabIndex = 1;
            this.VisualBoard2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VisualBoard2_CellContentClick);
            this.VisualBoard2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VisualBoard2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(674, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "100+ active players";
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.White;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartButton.Location = new System.Drawing.Point(671, 105);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(150, 46);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "StartGame";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(509, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Battleship";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(690, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 55);
            this.label3.TabIndex = 5;
            this.label3.Text = "PRO";
            // 
            // turnLabel
            // 
            this.turnLabel.AutoSize = true;
            this.turnLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.turnLabel.Location = new System.Drawing.Point(656, 247);
            this.turnLabel.Name = "turnLabel";
            this.turnLabel.Size = new System.Drawing.Size(181, 31);
            this.turnLabel.TabIndex = 6;
            this.turnLabel.Text = "Player1 Turn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1501, 501);
            this.Controls.Add(this.turnLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VisualBoard2);
            this.Controls.Add(this.VisualBoard1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VisualBoard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisualBoard2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView VisualBoard1;
        private System.Windows.Forms.DataGridView VisualBoard2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label turnLabel;
    }
}

