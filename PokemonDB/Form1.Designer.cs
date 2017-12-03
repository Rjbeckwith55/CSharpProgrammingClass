namespace PokemonDB
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
            this.Tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.cityGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CitiesLabel = new System.Windows.Forms.Label();
            this.AttackGridView1 = new System.Windows.Forms.DataGridView();
            this.AttacktextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.OwneshipGridView1 = new System.Windows.Forms.DataGridView();
            this.AttackButton = new System.Windows.Forms.Button();
            this.DefenseButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DefenseTextBox = new System.Windows.Forms.TextBox();
            this.NicknameSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PlayerNickTextbox = new System.Windows.Forms.TextBox();
            this.UnpaidGridView = new System.Windows.Forms.DataGridView();
            this.Tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttackGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OwneshipGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnpaidGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Controls.Add(this.tabPage2);
            this.Tabs.Controls.Add(this.tabPage3);
            this.Tabs.Location = new System.Drawing.Point(29, 23);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(695, 352);
            this.Tabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.UnpaidGridView);
            this.tabPage1.Controls.Add(this.CitiesLabel);
            this.tabPage1.Controls.Add(this.cityComboBox);
            this.tabPage1.Controls.Add(this.cityGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(687, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Player Cities";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cityComboBox
            // 
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(38, 67);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(121, 21);
            this.cityComboBox.TabIndex = 1;
            this.cityComboBox.SelectedIndexChanged += new System.EventHandler(this.cityComboBox_SelectedIndexChanged);
            // 
            // cityGridView
            // 
            this.cityGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cityGridView.Location = new System.Drawing.Point(286, 6);
            this.cityGridView.Name = "cityGridView";
            this.cityGridView.Size = new System.Drawing.Size(395, 127);
            this.cityGridView.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DefenseButton);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.DefenseTextBox);
            this.tabPage2.Controls.Add(this.AttackButton);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.AttacktextBox);
            this.tabPage2.Controls.Add(this.AttackGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(687, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pokemon Attack & Defense";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CitiesLabel
            // 
            this.CitiesLabel.AutoSize = true;
            this.CitiesLabel.Location = new System.Drawing.Point(35, 51);
            this.CitiesLabel.Name = "CitiesLabel";
            this.CitiesLabel.Size = new System.Drawing.Size(35, 13);
            this.CitiesLabel.TabIndex = 2;
            this.CitiesLabel.Text = "Cities:";
            // 
            // AttackGridView1
            // 
            this.AttackGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttackGridView1.Location = new System.Drawing.Point(280, 6);
            this.AttackGridView1.Name = "AttackGridView1";
            this.AttackGridView1.Size = new System.Drawing.Size(401, 314);
            this.AttackGridView1.TabIndex = 0;
            // 
            // AttacktextBox
            // 
            this.AttacktextBox.Location = new System.Drawing.Point(50, 92);
            this.AttacktextBox.Name = "AttacktextBox";
            this.AttacktextBox.Size = new System.Drawing.Size(100, 20);
            this.AttacktextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Attack value:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.NicknameSubmit);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.PlayerNickTextbox);
            this.tabPage3.Controls.Add(this.OwneshipGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(687, 326);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ownership";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // OwneshipGridView1
            // 
            this.OwneshipGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OwneshipGridView1.Location = new System.Drawing.Point(303, 22);
            this.OwneshipGridView1.Name = "OwneshipGridView1";
            this.OwneshipGridView1.Size = new System.Drawing.Size(369, 291);
            this.OwneshipGridView1.TabIndex = 0;
            // 
            // AttackButton
            // 
            this.AttackButton.Location = new System.Drawing.Point(156, 91);
            this.AttackButton.Name = "AttackButton";
            this.AttackButton.Size = new System.Drawing.Size(75, 23);
            this.AttackButton.TabIndex = 3;
            this.AttackButton.Text = "Submit ";
            this.AttackButton.UseVisualStyleBackColor = true;
            this.AttackButton.Click += new System.EventHandler(this.AttackButton_Click);
            // 
            // DefenseButton
            // 
            this.DefenseButton.Location = new System.Drawing.Point(156, 222);
            this.DefenseButton.Name = "DefenseButton";
            this.DefenseButton.Size = new System.Drawing.Size(75, 23);
            this.DefenseButton.TabIndex = 6;
            this.DefenseButton.Text = "Submit ";
            this.DefenseButton.UseVisualStyleBackColor = true;
            this.DefenseButton.Click += new System.EventHandler(this.DefenseButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Defense value:";
            // 
            // DefenseTextBox
            // 
            this.DefenseTextBox.Location = new System.Drawing.Point(50, 223);
            this.DefenseTextBox.Name = "DefenseTextBox";
            this.DefenseTextBox.Size = new System.Drawing.Size(100, 20);
            this.DefenseTextBox.TabIndex = 4;
            // 
            // NicknameSubmit
            // 
            this.NicknameSubmit.Location = new System.Drawing.Point(157, 104);
            this.NicknameSubmit.Name = "NicknameSubmit";
            this.NicknameSubmit.Size = new System.Drawing.Size(75, 23);
            this.NicknameSubmit.TabIndex = 6;
            this.NicknameSubmit.Text = "Submit ";
            this.NicknameSubmit.UseVisualStyleBackColor = true;
            this.NicknameSubmit.Click += new System.EventHandler(this.NicknameSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Player nickname:";
            // 
            // PlayerNickTextbox
            // 
            this.PlayerNickTextbox.Location = new System.Drawing.Point(51, 105);
            this.PlayerNickTextbox.Name = "PlayerNickTextbox";
            this.PlayerNickTextbox.Size = new System.Drawing.Size(100, 20);
            this.PlayerNickTextbox.TabIndex = 4;
            // 
            // UnpaidGridView
            // 
            this.UnpaidGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UnpaidGridView.Location = new System.Drawing.Point(286, 191);
            this.UnpaidGridView.Name = "UnpaidGridView";
            this.UnpaidGridView.Size = new System.Drawing.Size(395, 129);
            this.UnpaidGridView.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 416);
            this.Controls.Add(this.Tabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AttackGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OwneshipGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnpaidGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.DataGridView cityGridView;
        private System.Windows.Forms.Label CitiesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AttacktextBox;
        private System.Windows.Forms.DataGridView AttackGridView1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView OwneshipGridView1;
        private System.Windows.Forms.Button DefenseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DefenseTextBox;
        private System.Windows.Forms.Button AttackButton;
        private System.Windows.Forms.Button NicknameSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PlayerNickTextbox;
        private System.Windows.Forms.DataGridView UnpaidGridView;
    }
}

