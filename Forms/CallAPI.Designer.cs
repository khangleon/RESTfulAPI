namespace RestAPI.Forms
{
    partial class CallAPI
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
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnPut = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(16, 16);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(75, 59);
            this.btnGetAll.TabIndex = 0;
            this.btnGetAll.Text = "GET ALL";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(111, 52);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(100, 23);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "GET";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(401, 16);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(125, 56);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnPut
            // 
            this.btnPut.Location = new System.Drawing.Point(532, 16);
            this.btnPut.Name = "btnPut";
            this.btnPut.Size = new System.Drawing.Size(125, 56);
            this.btnPut.TabIndex = 3;
            this.btnPut.Text = "PUT";
            this.btnPut.UseVisualStyleBackColor = true;
            this.btnPut.Click += new System.EventHandler(this.btnPut_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(111, 16);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(248, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(16, 96);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(772, 342);
            this.rtbInfo.TabIndex = 6;
            this.rtbInfo.Text = "";
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(248, 52);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(100, 20);
            this.txtJob.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(663, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 56);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CallAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnPut);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnGetAll);
            this.Name = "CallAPI";
            this.Text = "CallAPI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnPut;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Button btnDelete;
    }
}