namespace _3ui {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            groupBoxOrderBy = new GroupBox();
            rbCompany = new RadioButton();
            rbLanguage = new RadioButton();
            rbLastName = new RadioButton();
            lblLanguage = new Label();
            dataGridViewMain = new DataGridView();
            cbLanguage = new ComboBox();
            peopleDataBindingSource = new BindingSource(components);
            lblName = new Label();
            tbLastName = new TextBox();
            groupBoxOrderBy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)peopleDataBindingSource).BeginInit();
            SuspendLayout();
            // 
            // groupBoxOrderBy
            // 
            groupBoxOrderBy.Controls.Add(rbCompany);
            groupBoxOrderBy.Controls.Add(rbLanguage);
            groupBoxOrderBy.Controls.Add(rbLastName);
            groupBoxOrderBy.Location = new Point(12, 12);
            groupBoxOrderBy.Name = "groupBoxOrderBy";
            groupBoxOrderBy.Size = new Size(261, 55);
            groupBoxOrderBy.TabIndex = 0;
            groupBoxOrderBy.TabStop = false;
            groupBoxOrderBy.Text = "Order by";
            // 
            // rbCompany
            // 
            rbCompany.AutoSize = true;
            rbCompany.Location = new Point(177, 25);
            rbCompany.Name = "rbCompany";
            rbCompany.Size = new Size(77, 19);
            rbCompany.TabIndex = 2;
            rbCompany.TabStop = true;
            rbCompany.Text = "Company";
            rbCompany.UseVisualStyleBackColor = true;
            rbCompany.CheckedChanged += rbCompany_CheckedChanged;
            // 
            // rbLanguage
            // 
            rbLanguage.AutoSize = true;
            rbLanguage.Location = new Point(94, 25);
            rbLanguage.Name = "rbLanguage";
            rbLanguage.Size = new Size(77, 19);
            rbLanguage.TabIndex = 1;
            rbLanguage.TabStop = true;
            rbLanguage.Text = "Language";
            rbLanguage.UseVisualStyleBackColor = true;
            rbLanguage.CheckedChanged += rbLanguage_CheckedChanged;
            // 
            // rbLastName
            // 
            rbLastName.AutoSize = true;
            rbLastName.Location = new Point(7, 25);
            rbLastName.Name = "rbLastName";
            rbLastName.Size = new Size(81, 19);
            rbLastName.TabIndex = 0;
            rbLastName.TabStop = true;
            rbLastName.Text = "Last Name";
            rbLastName.UseVisualStyleBackColor = true;
            rbLastName.CheckedChanged += rbLastName_CheckedChanged;
            // 
            // lblLanguage
            // 
            lblLanguage.AutoSize = true;
            lblLanguage.Location = new Point(623, 98);
            lblLanguage.Name = "lblLanguage";
            lblLanguage.Size = new Size(62, 15);
            lblLanguage.TabIndex = 1;
            lblLanguage.Text = "Language:";
            // 
            // dataGridViewMain
            // 
            dataGridViewMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMain.Location = new Point(12, 82);
            dataGridViewMain.Name = "dataGridViewMain";
            dataGridViewMain.RowTemplate.Height = 25;
            dataGridViewMain.Size = new Size(605, 356);
            dataGridViewMain.TabIndex = 3;
            // 
            // cbLanguage
            // 
            cbLanguage.FormattingEnabled = true;
            cbLanguage.Location = new Point(691, 95);
            cbLanguage.Name = "cbLanguage";
            cbLanguage.Size = new Size(135, 23);
            cbLanguage.TabIndex = 4;
            cbLanguage.SelectedIndexChanged += cbLanguage_SelectedIndexChanged;
            cbLanguage.TextUpdate += cbLanguage_TextUpdate;
            // 
            // peopleDataBindingSource
            // 
            peopleDataBindingSource.DataSource = typeof(_2library.PeopleData);
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(623, 130);
            lblName.Name = "lblName";
            lblName.Size = new Size(121, 15);
            lblName.TabIndex = 5;
            lblName.Text = "Last name starts with:";
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(750, 127);
            tbLastName.Name = "tbLastName";
            tbLastName.PlaceholderText = "Last Name";
            tbLastName.Size = new Size(76, 23);
            tbLastName.TabIndex = 6;
            tbLastName.TextChanged += tbLastName_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 450);
            Controls.Add(tbLastName);
            Controls.Add(lblName);
            Controls.Add(cbLanguage);
            Controls.Add(dataGridViewMain);
            Controls.Add(lblLanguage);
            Controls.Add(groupBoxOrderBy);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBoxOrderBy.ResumeLayout(false);
            groupBoxOrderBy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)peopleDataBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxOrderBy;
        private RadioButton rbCompany;
        private RadioButton rbLanguage;
        private RadioButton rbLastName;
        private Label lblLanguage;
        private DataGridView dataGridViewMain;
        private ComboBox cbLanguage;
        private Label lblName;
        private TextBox tbLastName;
        private BindingSource peopleDataBindingSource;
    }
}