namespace SpellManager
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.physicalDmgBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.magicalDmgBox = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.hpCostBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.manaCostBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.levelBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ClassesLabel = new System.Windows.Forms.Label();
            this.Classes = new System.Windows.Forms.CheckedListBox();
            this.elementBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.spellName = new System.Windows.Forms.Label();
            this.spellNameBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.removeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.spells = new System.Windows.Forms.ListBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.physicalDmgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.magicalDmgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.hpCostBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.manaCostBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.levelBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.physicalDmgBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.magicalDmgBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.hpCostBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.manaCostBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.levelBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ClassesLabel);
            this.panel2.Controls.Add(this.Classes);
            this.panel2.Controls.Add(this.elementBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.spellName);
            this.panel2.Controls.Add(this.spellNameBox);
            this.panel2.Controls.Add(this.addButton);
            this.panel2.Location = new System.Drawing.Point(383, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 689);
            this.panel2.TabIndex = 1;
            // 
            // physicalDmgBox
            // 
            this.physicalDmgBox.Location = new System.Drawing.Point(3, 587);
            this.physicalDmgBox.Maximum = new decimal(new int[] {500, 0, 0, 0});
            this.physicalDmgBox.Name = "physicalDmgBox";
            this.physicalDmgBox.Size = new System.Drawing.Size(246, 22);
            this.physicalDmgBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 561);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dégats physiques";
            // 
            // magicalDmgBox
            // 
            this.magicalDmgBox.Location = new System.Drawing.Point(3, 516);
            this.magicalDmgBox.Maximum = new decimal(new int[] {500, 0, 0, 0});
            this.magicalDmgBox.Name = "magicalDmgBox";
            this.magicalDmgBox.Size = new System.Drawing.Size(246, 22);
            this.magicalDmgBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dégats magiques";
            // 
            // hpCostBox
            // 
            this.hpCostBox.Location = new System.Drawing.Point(3, 445);
            this.hpCostBox.Maximum = new decimal(new int[] {500, 0, 0, 0});
            this.hpCostBox.Name = "hpCostBox";
            this.hpCostBox.Size = new System.Drawing.Size(246, 22);
            this.hpCostBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Coûts en pv";
            // 
            // manaCostBox
            // 
            this.manaCostBox.Location = new System.Drawing.Point(3, 378);
            this.manaCostBox.Maximum = new decimal(new int[] {500, 0, 0, 0});
            this.manaCostBox.Name = "manaCostBox";
            this.manaCostBox.Size = new System.Drawing.Size(246, 22);
            this.manaCostBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Coûts en mana";
            // 
            // levelBox
            // 
            this.levelBox.Location = new System.Drawing.Point(3, 312);
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(246, 22);
            this.levelBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Level";
            // 
            // ClassesLabel
            // 
            this.ClassesLabel.Location = new System.Drawing.Point(3, 151);
            this.ClassesLabel.Name = "ClassesLabel";
            this.ClassesLabel.Size = new System.Drawing.Size(100, 23);
            this.ClassesLabel.TabIndex = 6;
            this.ClassesLabel.Text = "Classes";
            // 
            // Classes
            // 
            this.Classes.FormattingEnabled = true;
            this.Classes.Location = new System.Drawing.Point(3, 177);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(246, 89);
            this.Classes.TabIndex = 5;
            // 
            // elementBox
            // 
            this.elementBox.FormattingEnabled = true;
            this.elementBox.Location = new System.Drawing.Point(3, 112);
            this.elementBox.Name = "elementBox";
            this.elementBox.Size = new System.Drawing.Size(246, 24);
            this.elementBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Élément";
            // 
            // spellName
            // 
            this.spellName.Location = new System.Drawing.Point(3, 11);
            this.spellName.Name = "spellName";
            this.spellName.Size = new System.Drawing.Size(89, 23);
            this.spellName.TabIndex = 2;
            this.spellName.Text = "Nom";
            // 
            // spellNameBox
            // 
            this.spellNameBox.Location = new System.Drawing.Point(3, 37);
            this.spellNameBox.MaxLength = 25;
            this.spellNameBox.Name = "spellNameBox";
            this.spellNameBox.Size = new System.Drawing.Size(246, 22);
            this.spellNameBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(3, 653);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(117, 33);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add spell";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddSpell);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.removeButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.loadButton);
            this.panel1.Controls.Add(this.spells);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 689);
            this.panel1.TabIndex = 3;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(251, 653);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(98, 30);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove spell";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(131, 653);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(98, 30);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(14, 653);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(98, 30);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // spells
            // 
            this.spells.FormattingEnabled = true;
            this.spells.ItemHeight = 16;
            this.spells.Location = new System.Drawing.Point(3, 3);
            this.spells.Name = "spells";
            this.spells.Size = new System.Drawing.Size(359, 644);
            this.spells.TabIndex = 0;
            this.spells.SelectedIndexChanged += new System.EventHandler(this.spells_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 707);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Spell manager";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.physicalDmgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.magicalDmgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.hpCostBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.manaCostBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.levelBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.CheckedListBox Classes;
        private System.Windows.Forms.Label ClassesLabel;
        private System.Windows.Forms.ComboBox elementBox;
        private System.Windows.Forms.NumericUpDown hpCostBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown levelBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.NumericUpDown magicalDmgBox;
        private System.Windows.Forms.NumericUpDown manaCostBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown physicalDmgBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label spellName;
        private System.Windows.Forms.TextBox spellNameBox;
        private System.Windows.Forms.ListBox spells;

        #endregion
    }
}