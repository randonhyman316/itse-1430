namespace CharacterCreator.Winforms
{
    partial class CharacterForm
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
            this.components = new System.ComponentModel.Container();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.raceBox = new System.Windows.Forms.ComboBox();
            this.professionBox = new System.Windows.Forms.ComboBox();
            this.strengthBox = new System.Windows.Forms.TextBox();
            this.IntelBox = new System.Windows.Forms.TextBox();
            this.agilityBox = new System.Windows.Forms.TextBox();
            this.constBox = new System.Windows.Forms.TextBox();
            this.charismaBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(68, 46);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(132, 22);
            this.nameBox.TabIndex = 0;
            this.nameBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateName);
            // 
            // raceBox
            // 
            this.raceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.raceBox.FormattingEnabled = true;
            this.raceBox.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half Elf",
            "Human"});
            this.raceBox.Location = new System.Drawing.Point(272, 74);
            this.raceBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.raceBox.Name = "raceBox";
            this.raceBox.Size = new System.Drawing.Size(132, 24);
            this.raceBox.TabIndex = 1;
            this.raceBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateComboBox);
            // 
            // professionBox
            // 
            this.professionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.professionBox.FormattingEnabled = true;
            this.professionBox.Items.AddRange(new object[] {
            "Fighter",
            "Hunter",
            "Priest",
            "Rogue",
            "Wizard"});
            this.professionBox.Location = new System.Drawing.Point(55, 115);
            this.professionBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.professionBox.Name = "professionBox";
            this.professionBox.Size = new System.Drawing.Size(160, 24);
            this.professionBox.TabIndex = 2;
            this.professionBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateComboBox);
            // 
            // strengthBox
            // 
            this.strengthBox.Location = new System.Drawing.Point(359, 175);
            this.strengthBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.strengthBox.Name = "strengthBox";
            this.strengthBox.Size = new System.Drawing.Size(51, 22);
            this.strengthBox.TabIndex = 4;
            this.strengthBox.Text = "50";
            this.strengthBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.strengthBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateAttributes);
            // 
            // IntelBox
            // 
            this.IntelBox.Location = new System.Drawing.Point(359, 210);
            this.IntelBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IntelBox.Name = "IntelBox";
            this.IntelBox.Size = new System.Drawing.Size(51, 22);
            this.IntelBox.TabIndex = 5;
            this.IntelBox.Text = "50";
            this.IntelBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IntelBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateAttributes);
            // 
            // agilityBox
            // 
            this.agilityBox.Location = new System.Drawing.Point(359, 242);
            this.agilityBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.agilityBox.Name = "agilityBox";
            this.agilityBox.Size = new System.Drawing.Size(51, 22);
            this.agilityBox.TabIndex = 6;
            this.agilityBox.Text = "50";
            this.agilityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.agilityBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateAttributes);
            // 
            // constBox
            // 
            this.constBox.Location = new System.Drawing.Point(359, 274);
            this.constBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.constBox.Name = "constBox";
            this.constBox.Size = new System.Drawing.Size(51, 22);
            this.constBox.TabIndex = 7;
            this.constBox.Text = "50";
            this.constBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.constBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateAttributes);
            // 
            // charismaBox
            // 
            this.charismaBox.Location = new System.Drawing.Point(359, 306);
            this.charismaBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.charismaBox.Name = "charismaBox";
            this.charismaBox.Size = new System.Drawing.Size(51, 22);
            this.charismaBox.TabIndex = 8;
            this.charismaBox.Text = "50";
            this.charismaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.charismaBox.Validating += new System.ComponentModel.CancelEventHandler(this.OnValidateAttributes);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Race";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Profession";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Strength";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(272, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Intelligence";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 245);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Agility";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 277);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Constitution";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 309);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Charisma";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(246, 126);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Attributes (1-100)";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(37, 213);
            this.descriptionBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(193, 147);
            this.descriptionBox.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(78, 178);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Description";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 377);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnCancel);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 377);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnSave);
            // 
            // error
            // 
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.error.ContainerControl = this;
            // 
            // CharacterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(445, 420);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.charismaBox);
            this.Controls.Add(this.constBox);
            this.Controls.Add(this.agilityBox);
            this.Controls.Add(this.IntelBox);
            this.Controls.Add(this.strengthBox);
            this.Controls.Add(this.professionBox);
            this.Controls.Add(this.raceBox);
            this.Controls.Add(this.nameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CharacterForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New Character";
            this.Load += new System.EventHandler(this.CharacterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.ComboBox raceBox;
        private System.Windows.Forms.ComboBox professionBox;
        private System.Windows.Forms.TextBox strengthBox;
        private System.Windows.Forms.TextBox IntelBox;
        private System.Windows.Forms.TextBox agilityBox;
        private System.Windows.Forms.TextBox constBox;
        private System.Windows.Forms.TextBox charismaBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider error;
    }
}