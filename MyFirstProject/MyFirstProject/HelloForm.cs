/*
 * Project: Hello World
 * Programmer: Rania Maarba
 * Date: September 2022
 * Descrpition: The project will run a window that allows the user to display a "Hello World" Message in several languages.
 */


using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyFirstProject
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

      

        private void InitializeComponent()
        {
            this.displayButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.spanishButton = new System.Windows.Forms.Button();
            this.frenchButton = new System.Windows.Forms.Button();
            this.italianButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(290, 104);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(134, 49);
            this.displayButton.TabIndex = 0;
            this.displayButton.Text = "English";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click_1);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(290, 326);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(134, 51);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(352, 45);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 15);
            this.messageLabel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "By Rania Maaraba";
            // 
            // spanishButton
            // 
            this.spanishButton.Location = new System.Drawing.Point(290, 159);
            this.spanishButton.Name = "spanishButton";
            this.spanishButton.Size = new System.Drawing.Size(134, 49);
            this.spanishButton.TabIndex = 4;
            this.spanishButton.Text = "Spanish";
            this.spanishButton.UseVisualStyleBackColor = true;
            this.spanishButton.Click += new System.EventHandler(this.spanishButton_Click);
            // 
            // frenchButton
            // 
            this.frenchButton.Location = new System.Drawing.Point(290, 214);
            this.frenchButton.Name = "frenchButton";
            this.frenchButton.Size = new System.Drawing.Size(134, 49);
            this.frenchButton.TabIndex = 5;
            this.frenchButton.Text = "French";
            this.frenchButton.UseVisualStyleBackColor = true;
            this.frenchButton.Click += new System.EventHandler(this.frenchButton_Click);
            // 
            // italianButton
            // 
            this.italianButton.Location = new System.Drawing.Point(290, 269);
            this.italianButton.Name = "italianButton";
            this.italianButton.Size = new System.Drawing.Size(134, 49);
            this.italianButton.TabIndex = 6;
            this.italianButton.Text = "Italian";
            this.italianButton.UseVisualStyleBackColor = true;
            this.italianButton.Click += new System.EventHandler(this.italianButton_Click);
            // 
            // HelloForm
            // 
            this.ClientSize = new System.Drawing.Size(742, 403);
            this.Controls.Add(this.italianButton);
            this.Controls.Add(this.frenchButton);
            this.Controls.Add(this.spanishButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.displayButton);
            this.Name = "HelloForm";
            this.Text = "Hello World By Maaraba";
            this.Load += new System.EventHandler(this.HelloForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void HelloForm_Load(object sender, EventArgs e)
        {

        }

        private Button displayButton;
        private Button exitButton;
        private Label messageLabel;
        private Label label1;
        private Button spanishButton;

        private void spanishButton_Click(object sender, EventArgs e)
        {
            //Display the Hello World Message in Spanish

            messageLabel.Text = "Hola Mundo";
        }

        private void displayButton_Click_1(object sender, EventArgs e)
        {
            //Display the Hello World Message

            messageLabel.Text = "Hello World";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exit the project

            this.Close();
        }

        private Button frenchButton;

        private void frenchButton_Click(object sender, EventArgs e)
        {
            // Display the Hello World Messahe in French

            messageLabel.Text = "Bonjour tout le monde";
        }

        private Button italianButton;

        private void italianButton_Click(object sender, EventArgs e)
        {
            //Display the Hello World Message in Italian

            messageLabel.Text = "Ciao Mondo";
        }
    }
}