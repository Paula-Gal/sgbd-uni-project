
namespace lab1sgbd
{
    partial class MainForm
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
            this.dataGridViewTransfuionCenters = new System.Windows.Forms.DataGridView();
            this.labelTrCenters = new System.Windows.Forms.Label();
            this.buttonCollections = new System.Windows.Forms.Button();
            this.firstBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.lastBtn = new System.Windows.Forms.Button();
            this.labelPoz = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransfuionCenters)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTransfuionCenters
            // 
            this.dataGridViewTransfuionCenters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransfuionCenters.Location = new System.Drawing.Point(16, 80);
            this.dataGridViewTransfuionCenters.Name = "dataGridViewTransfuionCenters";
            this.dataGridViewTransfuionCenters.Size = new System.Drawing.Size(644, 351);
            this.dataGridViewTransfuionCenters.TabIndex = 0;
            this.dataGridViewTransfuionCenters.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelTrCenters
            // 
            this.labelTrCenters.AutoSize = true;
            this.labelTrCenters.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrCenters.Location = new System.Drawing.Point(12, 22);
            this.labelTrCenters.Name = "labelTrCenters";
            this.labelTrCenters.Size = new System.Drawing.Size(147, 23);
            this.labelTrCenters.TabIndex = 1;
            this.labelTrCenters.Text = "Transfusion Centers";
            this.labelTrCenters.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonCollections
            // 
            this.buttonCollections.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCollections.Location = new System.Drawing.Point(16, 477);
            this.buttonCollections.Name = "buttonCollections";
            this.buttonCollections.Size = new System.Drawing.Size(146, 31);
            this.buttonCollections.TabIndex = 15;
            this.buttonCollections.Text = "Collections";
            this.buttonCollections.UseVisualStyleBackColor = true;
            this.buttonCollections.Click += new System.EventHandler(this.buttonCollections_Click);
            // 
            // firstBtn
            // 
            this.firstBtn.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstBtn.Location = new System.Drawing.Point(245, 446);
            this.firstBtn.Name = "firstBtn";
            this.firstBtn.Size = new System.Drawing.Size(98, 23);
            this.firstBtn.TabIndex = 16;
            this.firstBtn.Text = "First";
            this.firstBtn.UseVisualStyleBackColor = true;
            this.firstBtn.Click += new System.EventHandler(this.firstBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousBtn.Location = new System.Drawing.Point(349, 446);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(98, 23);
            this.previousBtn.TabIndex = 17;
            this.previousBtn.Text = "Previous";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.Location = new System.Drawing.Point(453, 446);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(98, 23);
            this.nextBtn.TabIndex = 18;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // lastBtn
            // 
            this.lastBtn.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastBtn.Location = new System.Drawing.Point(562, 446);
            this.lastBtn.Name = "lastBtn";
            this.lastBtn.Size = new System.Drawing.Size(98, 23);
            this.lastBtn.TabIndex = 19;
            this.lastBtn.Text = "Last";
            this.lastBtn.UseVisualStyleBackColor = true;
            this.lastBtn.Click += new System.EventHandler(this.lastBtn_Click);
            // 
            // labelPoz
            // 
            this.labelPoz.AutoSize = true;
            this.labelPoz.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoz.Location = new System.Drawing.Point(429, 485);
            this.labelPoz.Name = "labelPoz";
            this.labelPoz.Size = new System.Drawing.Size(57, 23);
            this.labelPoz.TabIndex = 20;
            this.labelPoz.Text = "Record";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 557);
            this.Controls.Add(this.labelPoz);
            this.Controls.Add(this.lastBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.firstBtn);
            this.Controls.Add(this.buttonCollections);
            this.Controls.Add(this.labelTrCenters);
            this.Controls.Add(this.dataGridViewTransfuionCenters);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransfuionCenters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTransfuionCenters;
        private System.Windows.Forms.Label labelTrCenters;
        private System.Windows.Forms.Button buttonCollections;
        private System.Windows.Forms.Button firstBtn;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button lastBtn;
        private System.Windows.Forms.Label labelPoz;
    }
}

