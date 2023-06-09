namespace Wordgame
{
    partial class frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            this.btn_Beginner = new System.Windows.Forms.Button();
            this.btn_intermediate = new System.Windows.Forms.Button();
            this.btn_Expert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Beginner
            // 
            this.btn_Beginner.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Beginner.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Beginner.Location = new System.Drawing.Point(487, 76);
            this.btn_Beginner.Name = "btn_Beginner";
            this.btn_Beginner.Size = new System.Drawing.Size(130, 51);
            this.btn_Beginner.TabIndex = 0;
            this.btn_Beginner.Text = "Beginner";
            this.btn_Beginner.UseVisualStyleBackColor = true;
            this.btn_Beginner.Click += new System.EventHandler(this.btn_Beginner_Click);
            // 
            // btn_intermediate
            // 
            this.btn_intermediate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_intermediate.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_intermediate.Location = new System.Drawing.Point(487, 195);
            this.btn_intermediate.Name = "btn_intermediate";
            this.btn_intermediate.Size = new System.Drawing.Size(130, 60);
            this.btn_intermediate.TabIndex = 1;
            this.btn_intermediate.Text = "Intermediate";
            this.btn_intermediate.UseVisualStyleBackColor = true;
            this.btn_intermediate.Click += new System.EventHandler(this.btn_intermediate_Click);
            // 
            // btn_Expert
            // 
            this.btn_Expert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Expert.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Expert.Location = new System.Drawing.Point(487, 323);
            this.btn_Expert.Name = "btn_Expert";
            this.btn_Expert.Size = new System.Drawing.Size(130, 60);
            this.btn_Expert.TabIndex = 2;
            this.btn_Expert.Text = "Expert";
            this.btn_Expert.UseVisualStyleBackColor = true;
            this.btn_Expert.Click += new System.EventHandler(this.btn_Expert_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(701, 408);
            this.Controls.Add(this.btn_Expert);
            this.Controls.Add(this.btn_intermediate);
            this.Controls.Add(this.btn_Beginner);
            this.Name = "frm_Menu";
            this.Text = "MenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Beginner;
        private Button btn_intermediate;
        private Button btn_Expert;
    }
}