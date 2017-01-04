namespace BasicConcepts
{
    partial class Examples
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_DelegateExamples = new System.Windows.Forms.Button();
            this.Btn_ActionsExample = new System.Windows.Forms.Button();
            this.Btn_FuncExample = new System.Windows.Forms.Button();
            this.Btn_LambdaExample = new System.Windows.Forms.Button();
            this.LinkLbl_SeeDocumentation = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_DelegateExamples
            // 
            this.Btn_DelegateExamples.Location = new System.Drawing.Point(93, 12);
            this.Btn_DelegateExamples.Name = "Btn_DelegateExamples";
            this.Btn_DelegateExamples.Size = new System.Drawing.Size(75, 23);
            this.Btn_DelegateExamples.TabIndex = 0;
            this.Btn_DelegateExamples.Text = "Delegates!!";
            this.Btn_DelegateExamples.UseVisualStyleBackColor = true;
            this.Btn_DelegateExamples.Click += new System.EventHandler(this.Btn_DelegateExamples_Click);
            // 
            // Btn_ActionsExample
            // 
            this.Btn_ActionsExample.Location = new System.Drawing.Point(93, 57);
            this.Btn_ActionsExample.Name = "Btn_ActionsExample";
            this.Btn_ActionsExample.Size = new System.Drawing.Size(75, 25);
            this.Btn_ActionsExample.TabIndex = 1;
            this.Btn_ActionsExample.Text = "Actions !!";
            this.Btn_ActionsExample.UseVisualStyleBackColor = true;
            this.Btn_ActionsExample.Click += new System.EventHandler(this.Btn_ActionsExample_Click);
            // 
            // Btn_FuncExample
            // 
            this.Btn_FuncExample.Location = new System.Drawing.Point(53, 107);
            this.Btn_FuncExample.Name = "Btn_FuncExample";
            this.Btn_FuncExample.Size = new System.Drawing.Size(158, 25);
            this.Btn_FuncExample.TabIndex = 2;
            this.Btn_FuncExample.Text = "Functions <T , TResult>";
            this.Btn_FuncExample.UseVisualStyleBackColor = true;
            this.Btn_FuncExample.Click += new System.EventHandler(this.Btn_FuncExample_Click);
            // 
            // Btn_LambdaExample
            // 
            this.Btn_LambdaExample.Location = new System.Drawing.Point(93, 157);
            this.Btn_LambdaExample.Name = "Btn_LambdaExample";
            this.Btn_LambdaExample.Size = new System.Drawing.Size(75, 25);
            this.Btn_LambdaExample.TabIndex = 3;
            this.Btn_LambdaExample.Text = "Lambdas !!";
            this.Btn_LambdaExample.UseVisualStyleBackColor = true;
            this.Btn_LambdaExample.Click += new System.EventHandler(this.Btn_LambdaExample_Click);
            // 
            // LinkLbl_SeeDocumentation
            // 
            this.LinkLbl_SeeDocumentation.AutoSize = true;
            this.LinkLbl_SeeDocumentation.Location = new System.Drawing.Point(12, 199);
            this.LinkLbl_SeeDocumentation.Name = "LinkLbl_SeeDocumentation";
            this.LinkLbl_SeeDocumentation.Size = new System.Drawing.Size(176, 13);
            this.LinkLbl_SeeDocumentation.TabIndex = 9;
            this.LinkLbl_SeeDocumentation.TabStop = true;
            this.LinkLbl_SeeDocumentation.Text = "See Online Project Documentation!!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Developed by Gnomeus";
            // 
            // Examples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 261);
            this.Controls.Add(this.LinkLbl_SeeDocumentation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_LambdaExample);
            this.Controls.Add(this.Btn_FuncExample);
            this.Controls.Add(this.Btn_ActionsExample);
            this.Controls.Add(this.Btn_DelegateExamples);
            this.Name = "Examples";
            this.Text = "From Delegate to Lambdas  :-)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_DelegateExamples;
        private System.Windows.Forms.Button Btn_ActionsExample;
        private System.Windows.Forms.Button Btn_FuncExample;
        private System.Windows.Forms.Button Btn_LambdaExample;
        private System.Windows.Forms.LinkLabel LinkLbl_SeeDocumentation;
        private System.Windows.Forms.Label label1;
    }
}

