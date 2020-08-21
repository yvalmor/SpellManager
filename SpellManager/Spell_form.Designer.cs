namespace SpellManager
{
    partial class Spell_form
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
            this.errorLabel = new System.Windows.Forms.Label();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ressourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.élémentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.physicalDmgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.magicalDmgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.hpCostBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.manaCostBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.levelBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.errorLabel);
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
            this.panel2.Location = new System.Drawing.Point(504, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 689);
            this.panel2.TabIndex = 1;
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(3, 563);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(266, 73);
            this.errorLabel.TabIndex = 17;
            this.errorLabel.Text = "error";
            this.errorLabel.Visible = false;
            // 
            // physicalDmgBox
            // 
            this.physicalDmgBox.Location = new System.Drawing.Point(3, 516);
            this.physicalDmgBox.Maximum = new decimal(new int[] {500, 0, 0, 0});
            this.physicalDmgBox.Name = "physicalDmgBox";
            this.physicalDmgBox.Size = new System.Drawing.Size(246, 22);
            this.physicalDmgBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 490);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dégats physiques";
            // 
            // magicalDmgBox
            // 
            this.magicalDmgBox.Location = new System.Drawing.Point(3, 465);
            this.magicalDmgBox.Maximum = new decimal(new int[] {500, 0, 0, 0});
            this.magicalDmgBox.Name = "magicalDmgBox";
            this.magicalDmgBox.Size = new System.Drawing.Size(246, 22);
            this.magicalDmgBox.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dégats magiques";
            // 
            // hpCostBox
            // 
            this.hpCostBox.Location = new System.Drawing.Point(3, 414);
            this.hpCostBox.Maximum = new decimal(new int[] {500, 0, 0, 0});
            this.hpCostBox.Name = "hpCostBox";
            this.hpCostBox.Size = new System.Drawing.Size(246, 22);
            this.hpCostBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Coûts en pv";
            // 
            // manaCostBox
            // 
            this.manaCostBox.Location = new System.Drawing.Point(3, 363);
            this.manaCostBox.Maximum = new decimal(new int[] {500, 0, 0, 0});
            this.manaCostBox.Name = "manaCostBox";
            this.manaCostBox.Size = new System.Drawing.Size(246, 22);
            this.manaCostBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 337);
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
            this.Classes.CheckOnClick = true;
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
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 689);
            this.panel1.TabIndex = 3;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(334, 654);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(149, 30);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Retirer sort";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(169, 653);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(149, 30);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Sauvegarder liste";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(3, 654);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(149, 30);
            this.loadButton.TabIndex = 1;
            this.loadButton.Text = "Ouvrir liste";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // spells
            // 
            this.spells.FormattingEnabled = true;
            this.spells.ItemHeight = 16;
            this.spells.Location = new System.Drawing.Point(3, 3);
            this.spells.Name = "spells";
            this.spells.Size = new System.Drawing.Size(480, 644);
            this.spells.TabIndex = 0;
            this.spells.SelectedIndexChanged += new System.EventHandler(this.spells_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.listeToolStripMenuItem, this.ressourcesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(788, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ouvrirToolStripMenuItem, this.sauvegarderToolStripMenuItem});
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.listeToolStripMenuItem.Text = "Liste";
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // sauvegarderToolStripMenuItem
            // 
            this.sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            this.sauvegarderToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.sauvegarderToolStripMenuItem.Text = "Sauvegarder";
            this.sauvegarderToolStripMenuItem.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ressourcesToolStripMenuItem
            // 
            this.ressourcesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.élémentsToolStripMenuItem, this.classesToolStripMenuItem});
            this.ressourcesToolStripMenuItem.Name = "ressourcesToolStripMenuItem";
            this.ressourcesToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.ressourcesToolStripMenuItem.Text = "Ressources";
            // 
            // élémentsToolStripMenuItem
            // 
            this.élémentsToolStripMenuItem.Name = "élémentsToolStripMenuItem";
            this.élémentsToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.élémentsToolStripMenuItem.Text = "Éléments";
            this.élémentsToolStripMenuItem.Click += new System.EventHandler(this.élémentsToolStripMenuItem_Click);
            // 
            // classesToolStripMenuItem
            // 
            this.classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            this.classesToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.classesToolStripMenuItem.Text = "Classes";
            this.classesToolStripMenuItem.Click += new System.EventHandler(this.classesToolStripMenuItem_Click);
            // 
            // Spell_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 746);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Spell_form";
            this.Text = "Spell manager";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.physicalDmgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.magicalDmgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.hpCostBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.manaCostBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.levelBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.CheckedListBox Classes;
        private System.Windows.Forms.Label ClassesLabel;
        private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem;
        private System.Windows.Forms.ComboBox elementBox;
        private System.Windows.Forms.ToolStripMenuItem élémentsToolStripMenuItem;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.NumericUpDown hpCostBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown levelBox;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.NumericUpDown magicalDmgBox;
        private System.Windows.Forms.NumericUpDown manaCostBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown physicalDmgBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ToolStripMenuItem ressourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label spellName;
        private System.Windows.Forms.TextBox spellNameBox;
        private System.Windows.Forms.ListBox spells;

        #endregion
    }
}