namespace ThreadingExamples
{
    partial class FifoExample
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
            this.BtnStartLoop = new System.Windows.Forms.Button();
            this.Btn_AddItems = new System.Windows.Forms.Button();
            this.Btn_GenException = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_StopLoop = new System.Windows.Forms.Button();
            this.LinkLbl_SeeDocumentation = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // BtnStartLoop
            // 
            this.BtnStartLoop.Location = new System.Drawing.Point(56, 12);
            this.BtnStartLoop.Name = "BtnStartLoop";
            this.BtnStartLoop.Size = new System.Drawing.Size(120, 23);
            this.BtnStartLoop.TabIndex = 0;
            this.BtnStartLoop.Text = "Start Loop";
            this.BtnStartLoop.UseVisualStyleBackColor = true;
            this.BtnStartLoop.Click += new System.EventHandler(this.Btn_FIFO_Click);
            // 
            // Btn_AddItems
            // 
            this.Btn_AddItems.Location = new System.Drawing.Point(56, 52);
            this.Btn_AddItems.Name = "Btn_AddItems";
            this.Btn_AddItems.Size = new System.Drawing.Size(120, 23);
            this.Btn_AddItems.TabIndex = 1;
            this.Btn_AddItems.Text = "Add Items to Queue";
            this.Btn_AddItems.UseVisualStyleBackColor = true;
            this.Btn_AddItems.Click += new System.EventHandler(this.Btn_AddItems_Click);
            // 
            // Btn_GenException
            // 
            this.Btn_GenException.Location = new System.Drawing.Point(58, 92);
            this.Btn_GenException.Name = "Btn_GenException";
            this.Btn_GenException.Size = new System.Drawing.Size(120, 23);
            this.Btn_GenException.TabIndex = 2;
            this.Btn_GenException.Text = "Generate Exception";
            this.Btn_GenException.UseVisualStyleBackColor = true;
            this.Btn_GenException.Click += new System.EventHandler(this.Btn_GenException_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Developed by Gnomeus";
            // 
            // Btn_StopLoop
            // 
            this.Btn_StopLoop.Location = new System.Drawing.Point(56, 130);
            this.Btn_StopLoop.Name = "Btn_StopLoop";
            this.Btn_StopLoop.Size = new System.Drawing.Size(120, 23);
            this.Btn_StopLoop.TabIndex = 8;
            this.Btn_StopLoop.Text = "Stop Loop";
            this.Btn_StopLoop.UseVisualStyleBackColor = true;
            this.Btn_StopLoop.Click += new System.EventHandler(this.Btn_StopLoop_Click);
            // 
            // LinkLbl_SeeDocumentation
            // 
            this.LinkLbl_SeeDocumentation.AutoSize = true;
            this.LinkLbl_SeeDocumentation.Location = new System.Drawing.Point(55, 165);
            this.LinkLbl_SeeDocumentation.Name = "LinkLbl_SeeDocumentation";
            this.LinkLbl_SeeDocumentation.Size = new System.Drawing.Size(176, 13);
            this.LinkLbl_SeeDocumentation.TabIndex = 9;
            this.LinkLbl_SeeDocumentation.TabStop = true;
            this.LinkLbl_SeeDocumentation.Text = "See Online Project Documentation!!";
            this.LinkLbl_SeeDocumentation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLbl_SeeDocumentation_LinkClicked);
            // 
            // FifoExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 234);
            this.Controls.Add(this.LinkLbl_SeeDocumentation);
            this.Controls.Add(this.Btn_StopLoop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_GenException);
            this.Controls.Add(this.Btn_AddItems);
            this.Controls.Add(this.BtnStartLoop);
            this.Name = "FifoExample";
            this.Text = "FIFOExample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStartLoop;
        private System.Windows.Forms.Button Btn_AddItems;
        private System.Windows.Forms.Button Btn_GenException;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_StopLoop;
        private System.Windows.Forms.LinkLabel LinkLbl_SeeDocumentation;
    }
}