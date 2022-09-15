namespace Euromillions_Generator_APP
{
    partial class GeneratorAPP
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratorAPP));
            this.gen_btn = new System.Windows.Forms.Button();
            this.genBox = new System.Windows.Forms.TextBox();
            this.genBox2 = new System.Windows.Forms.TextBox();
            this.Numbers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clr_button = new System.Windows.Forms.Button();
            this.expButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gen_btn
            // 
            this.gen_btn.BackColor = System.Drawing.Color.LightGray;
            this.gen_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gen_btn.Location = new System.Drawing.Point(12, 122);
            this.gen_btn.Name = "gen_btn";
            this.gen_btn.Size = new System.Drawing.Size(83, 32);
            this.gen_btn.TabIndex = 0;
            this.gen_btn.Text = "Generate";
            this.gen_btn.UseVisualStyleBackColor = false;
            this.gen_btn.Click += new System.EventHandler(this.gen_btn_Click);
            // 
            // genBox
            // 
            this.genBox.Enabled = false;
            this.genBox.Location = new System.Drawing.Point(30, 25);
            this.genBox.Name = "genBox";
            this.genBox.ReadOnly = true;
            this.genBox.ShortcutsEnabled = false;
            this.genBox.Size = new System.Drawing.Size(254, 23);
            this.genBox.TabIndex = 1;
            this.genBox.Tag = "";
            // 
            // genBox2
            // 
            this.genBox2.AcceptsTab = true;
            this.genBox2.Enabled = false;
            this.genBox2.Location = new System.Drawing.Point(30, 77);
            this.genBox2.Name = "genBox2";
            this.genBox2.ReadOnly = true;
            this.genBox2.ShortcutsEnabled = false;
            this.genBox2.Size = new System.Drawing.Size(254, 23);
            this.genBox2.TabIndex = 2;
            // 
            // Numbers
            // 
            this.Numbers.AutoSize = true;
            this.Numbers.Location = new System.Drawing.Point(30, 7);
            this.Numbers.Name = "Numbers";
            this.Numbers.Size = new System.Drawing.Size(56, 15);
            this.Numbers.TabIndex = 3;
            this.Numbers.Text = "Numbers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stars";
            // 
            // clr_button
            // 
            this.clr_button.BackColor = System.Drawing.Color.LightGray;
            this.clr_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clr_button.Location = new System.Drawing.Point(117, 122);
            this.clr_button.Name = "clr_button";
            this.clr_button.Size = new System.Drawing.Size(75, 32);
            this.clr_button.TabIndex = 5;
            this.clr_button.Text = "Clear All";
            this.clr_button.UseVisualStyleBackColor = false;
            this.clr_button.Click += new System.EventHandler(this.clr_button_Click);
            // 
            // expButton
            // 
            this.expButton.BackColor = System.Drawing.Color.LightGray;
            this.expButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.expButton.Location = new System.Drawing.Point(209, 122);
            this.expButton.Name = "expButton";
            this.expButton.Size = new System.Drawing.Size(75, 32);
            this.expButton.TabIndex = 6;
            this.expButton.Text = "Export";
            this.expButton.UseVisualStyleBackColor = false;
            this.expButton.Click += new System.EventHandler(this.expButton_Click);
            // 
            // GeneratorAPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 166);
            this.Controls.Add(this.expButton);
            this.Controls.Add(this.clr_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Numbers);
            this.Controls.Add(this.genBox2);
            this.Controls.Add(this.genBox);
            this.Controls.Add(this.gen_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeneratorAPP";
            this.Text = "Euromillions Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button gen_btn;
        private TextBox genBox;
        private TextBox genBox2;
        private Label Numbers;
        private Label label1;
        private Button clr_button;
        private Button expButton;
    }
}