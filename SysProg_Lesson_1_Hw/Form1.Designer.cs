namespace SysProg_Lesson_1_Hw
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
            this.listView = new System.Windows.Forms.ListView();
            this.txt_proc = new System.Windows.Forms.TextBox();
            this.btn_createProc = new System.Windows.Forms.Button();
            this.btn_endProc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(12, 12);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(776, 347);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // txt_proc
            // 
            this.txt_proc.Location = new System.Drawing.Point(12, 376);
            this.txt_proc.Name = "txt_proc";
            this.txt_proc.Size = new System.Drawing.Size(492, 23);
            this.txt_proc.TabIndex = 1;
            // 
            // btn_createProc
            // 
            this.btn_createProc.Location = new System.Drawing.Point(510, 375);
            this.btn_createProc.Name = "btn_createProc";
            this.btn_createProc.Size = new System.Drawing.Size(136, 23);
            this.btn_createProc.TabIndex = 2;
            this.btn_createProc.Text = "Create Process";
            this.btn_createProc.UseVisualStyleBackColor = true;
            // 
            // btn_endProc
            // 
            this.btn_endProc.Location = new System.Drawing.Point(652, 375);
            this.btn_endProc.Name = "btn_endProc";
            this.btn_endProc.Size = new System.Drawing.Size(136, 23);
            this.btn_endProc.TabIndex = 3;
            this.btn_endProc.Text = "End Process";
            this.btn_endProc.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.btn_endProc);
            this.Controls.Add(this.btn_createProc);
            this.Controls.Add(this.txt_proc);
            this.Controls.Add(this.listView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView;
        private TextBox txt_proc;
        private Button btn_createProc;
        private Button btn_endProc;
    }
}