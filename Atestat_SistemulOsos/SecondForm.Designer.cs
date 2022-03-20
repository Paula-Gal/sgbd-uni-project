
namespace lab1sgbd
{
    partial class SecondForm
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
            this.labelPoz = new System.Windows.Forms.Label();
            this.buttonLast = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonFirst = new System.Windows.Forms.Button();
            this.buttonUpdateChild = new System.Windows.Forms.Button();
            this.buttonDeleteChild = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddCollection = new System.Windows.Forms.Button();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxTrCenterID = new System.Windows.Forms.TextBox();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.textBoxTrCenterName = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTrCenterID = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelTrCenter = new System.Windows.Forms.Label();
            this.dataGridViewCollections = new System.Windows.Forms.DataGridView();
            this.labelProgr = new System.Windows.Forms.Label();
            this.textBoxPr = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCollections)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPoz
            // 
            this.labelPoz.AutoSize = true;
            this.labelPoz.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoz.Location = new System.Drawing.Point(487, 524);
            this.labelPoz.Name = "labelPoz";
            this.labelPoz.Size = new System.Drawing.Size(57, 23);
            this.labelPoz.TabIndex = 38;
            this.labelPoz.Text = "Record";
            // 
            // buttonLast
            // 
            this.buttonLast.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLast.Location = new System.Drawing.Point(329, 525);
            this.buttonLast.Name = "buttonLast";
            this.buttonLast.Size = new System.Drawing.Size(75, 23);
            this.buttonLast.TabIndex = 37;
            this.buttonLast.Text = "Last";
            this.buttonLast.UseVisualStyleBackColor = true;
            this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click_1);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(220, 525);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 36;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrevious.Location = new System.Drawing.Point(120, 525);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 35;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonFirst
            // 
            this.buttonFirst.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFirst.Location = new System.Drawing.Point(12, 525);
            this.buttonFirst.Name = "buttonFirst";
            this.buttonFirst.Size = new System.Drawing.Size(75, 23);
            this.buttonFirst.TabIndex = 34;
            this.buttonFirst.Text = "First";
            this.buttonFirst.UseVisualStyleBackColor = true;
            this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click_1);
            // 
            // buttonUpdateChild
            // 
            this.buttonUpdateChild.CausesValidation = false;
            this.buttonUpdateChild.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateChild.Location = new System.Drawing.Point(719, 437);
            this.buttonUpdateChild.Name = "buttonUpdateChild";
            this.buttonUpdateChild.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateChild.TabIndex = 33;
            this.buttonUpdateChild.Text = "Update";
            this.buttonUpdateChild.UseVisualStyleBackColor = true;
            this.buttonUpdateChild.Click += new System.EventHandler(this.buttonUpdateChild_Click_1);
            // 
            // buttonDeleteChild
            // 
            this.buttonDeleteChild.CausesValidation = false;
            this.buttonDeleteChild.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteChild.Location = new System.Drawing.Point(719, 389);
            this.buttonDeleteChild.Name = "buttonDeleteChild";
            this.buttonDeleteChild.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteChild.TabIndex = 32;
            this.buttonDeleteChild.Text = "Delete";
            this.buttonDeleteChild.UseVisualStyleBackColor = true;
            this.buttonDeleteChild.Click += new System.EventHandler(this.buttonDeleteChild_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 31;
            this.label1.Text = "Collections";
            // 
            // buttonAddCollection
            // 
            this.buttonAddCollection.CausesValidation = false;
            this.buttonAddCollection.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCollection.Location = new System.Drawing.Point(719, 340);
            this.buttonAddCollection.Name = "buttonAddCollection";
            this.buttonAddCollection.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCollection.TabIndex = 30;
            this.buttonAddCollection.Text = "Add";
            this.buttonAddCollection.UseVisualStyleBackColor = true;
            this.buttonAddCollection.Click += new System.EventHandler(this.buttonAddCollection_Click_1);
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(769, 283);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxDate.TabIndex = 29;
            this.textBoxDate.TextChanged += new System.EventHandler(this.textBoxDate_TextChanged);
            // 
            // textBoxTrCenterID
            // 
            this.textBoxTrCenterID.Location = new System.Drawing.Point(832, 238);
            this.textBoxTrCenterID.Name = "textBoxTrCenterID";
            this.textBoxTrCenterID.Size = new System.Drawing.Size(100, 20);
            this.textBoxTrCenterID.TabIndex = 28;
            this.textBoxTrCenterID.TextChanged += new System.EventHandler(this.textBoxTrCenterID_TextChanged);
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Location = new System.Drawing.Point(793, 198);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.Size = new System.Drawing.Size(100, 20);
            this.textBoxLocation.TabIndex = 27;
            this.textBoxLocation.TextChanged += new System.EventHandler(this.textBoxLocation_TextChanged);
            // 
            // textBoxTrCenterName
            // 
            this.textBoxTrCenterName.Location = new System.Drawing.Point(878, 119);
            this.textBoxTrCenterName.Name = "textBoxTrCenterName";
            this.textBoxTrCenterName.Size = new System.Drawing.Size(100, 20);
            this.textBoxTrCenterName.TabIndex = 26;
            this.textBoxTrCenterName.TextChanged += new System.EventHandler(this.textBoxTrCenterName_TextChanged);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(716, 286);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 25;
            this.labelDate.Text = "Date";
            // 
            // labelTrCenterID
            // 
            this.labelTrCenterID.AutoSize = true;
            this.labelTrCenterID.Location = new System.Drawing.Point(716, 245);
            this.labelTrCenterID.Name = "labelTrCenterID";
            this.labelTrCenterID.Size = new System.Drawing.Size(110, 13);
            this.labelTrCenterID.TabIndex = 24;
            this.labelTrCenterID.Text = "Transfusion Center ID";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(716, 205);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(48, 13);
            this.labelLocation.TabIndex = 23;
            this.labelLocation.Text = "Location";
            // 
            // labelTrCenter
            // 
            this.labelTrCenter.AutoSize = true;
            this.labelTrCenter.Location = new System.Drawing.Point(716, 119);
            this.labelTrCenter.Name = "labelTrCenter";
            this.labelTrCenter.Size = new System.Drawing.Size(127, 13);
            this.labelTrCenter.TabIndex = 22;
            this.labelTrCenter.Text = "Transfusion Center Name";
            // 
            // dataGridViewCollections
            // 
            this.dataGridViewCollections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCollections.Location = new System.Drawing.Point(12, 83);
            this.dataGridViewCollections.Name = "dataGridViewCollections";
            this.dataGridViewCollections.Size = new System.Drawing.Size(658, 412);
            this.dataGridViewCollections.TabIndex = 21;
            this.dataGridViewCollections.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCollections_CellContentClick);
            // 
            // labelProgr
            // 
            this.labelProgr.AutoSize = true;
            this.labelProgr.Location = new System.Drawing.Point(718, 160);
            this.labelProgr.Name = "labelProgr";
            this.labelProgr.Size = new System.Drawing.Size(46, 13);
            this.labelProgr.TabIndex = 39;
            this.labelProgr.Text = "Program";
            // 
            // textBoxPr
            // 
            this.textBoxPr.Location = new System.Drawing.Point(793, 153);
            this.textBoxPr.Name = "textBoxPr";
            this.textBoxPr.Size = new System.Drawing.Size(100, 20);
            this.textBoxPr.TabIndex = 40;
            // 
            // SecondForm
            // 
            this.ClientSize = new System.Drawing.Size(997, 588);
            this.Controls.Add(this.textBoxPr);
            this.Controls.Add(this.labelProgr);
            this.Controls.Add(this.labelPoz);
            this.Controls.Add(this.buttonLast);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonFirst);
            this.Controls.Add(this.buttonUpdateChild);
            this.Controls.Add(this.buttonDeleteChild);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddCollection);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxTrCenterID);
            this.Controls.Add(this.textBoxLocation);
            this.Controls.Add(this.textBoxTrCenterName);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTrCenterID);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelTrCenter);
            this.Controls.Add(this.dataGridViewCollections);
            this.Name = "SecondForm";
            this.Load += new System.EventHandler(this.ThirdForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCollections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTransfuionCenters;
        private System.Windows.Forms.Label labelTrCenters;
        private System.Windows.Forms.Button addTrCenter;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelOras;
        private System.Windows.Forms.Label labelProgram;
        private System.Windows.Forms.Label labelManager;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxOras;
        private System.Windows.Forms.TextBox textBoxProgram;
        private System.Windows.Forms.TextBox textBoxManager;
        private System.Windows.Forms.Button buttonCollections;
        private System.Windows.Forms.Label labelPoz;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonUpdateChild;
        private System.Windows.Forms.Button buttonDeleteChild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddCollection;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxTrCenterID;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.TextBox textBoxTrCenterName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTrCenterID;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelTrCenter;
        private System.Windows.Forms.DataGridView dataGridViewCollections;
        private System.Windows.Forms.Label labelProgr;
        private System.Windows.Forms.TextBox textBoxPr;
    }
}

