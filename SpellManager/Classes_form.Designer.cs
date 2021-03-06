﻿using System.ComponentModel;

namespace SpellManager
{
    partial class Classes_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addElement = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.removeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.classes = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.listeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(696, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.sauvegarderToolStripMenuItem});
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.listeToolStripMenuItem.Text = "Liste";
            // 
            // sauvegarderToolStripMenuItem
            // 
            this.sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            this.sauvegarderToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.sauvegarderToolStripMenuItem.Text = "Sauvegarder";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.addElement);
            this.panel2.Controls.Add(this.nameBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(307, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 550);
            this.panel2.TabIndex = 3;
            // 
            // addElement
            // 
            this.addElement.Location = new System.Drawing.Point(3, 79);
            this.addElement.Name = "addElement";
            this.addElement.Size = new System.Drawing.Size(178, 26);
            this.addElement.TabIndex = 2;
            this.addElement.Text = "Ajouter élément";
            this.addElement.UseVisualStyleBackColor = true;
            this.addElement.Click += new System.EventHandler(this.addElement_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(3, 29);
            this.nameBox.MaxLength = 35;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(178, 22);
            this.nameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.removeButton);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.classes);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 550);
            this.panel1.TabIndex = 4;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(155, 524);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(131, 23);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Retirer élément";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(3, 524);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(134, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Sauvegarder liste";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // classes
            // 
            this.classes.FormattingEnabled = true;
            this.classes.ItemHeight = 16;
            this.classes.Location = new System.Drawing.Point(3, 3);
            this.classes.Name = "classes";
            this.classes.Size = new System.Drawing.Size(283, 516);
            this.classes.Sorted = true;
            this.classes.TabIndex = 0;
            this.classes.SelectedIndexChanged += new System.EventHandler(this.classes_SelectedIndexChanged);
            // 
            // Classes_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Classes_form";
            this.Text = "Classes_form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button addElement;
        private System.Windows.Forms.ListBox classes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem;
        private System.Windows.Forms.Button saveButton;

        #endregion
    }
}