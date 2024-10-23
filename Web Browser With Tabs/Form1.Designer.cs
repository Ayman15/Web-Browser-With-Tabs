namespace Web_Browser_With_Tabs
{
    partial class Form1
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
            panel1 = new Panel();
            add_tab = new Button();
            select_url = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(add_tab);
            panel1.Controls.Add(select_url);
            panel1.Location = new Point(-1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1235, 119);
            panel1.TabIndex = 0;
            // 
            // add_tab
            // 
            add_tab.Location = new Point(503, 40);
            add_tab.Name = "add_tab";
            add_tab.Size = new Size(243, 48);
            add_tab.TabIndex = 1;
            add_tab.Text = "Add Tab";
            add_tab.UseVisualStyleBackColor = true;
            add_tab.Click += add_tab_Click;
            // 
            // select_url
            // 
            select_url.Location = new Point(88, 37);
            select_url.Name = "select_url";
            select_url.Size = new Size(203, 51);
            select_url.TabIndex = 0;
            select_url.Text = "Select URL";
            select_url.UseVisualStyleBackColor = true;
            select_url.Click += select_url_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(1, 134);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1233, 793);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1225, 760);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 940);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button add_tab;
        private Button select_url;
        private TabControl tabControl1;
        private TabPage tabPage1;
    }
}
