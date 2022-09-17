namespace CharListMaker
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_openTextFile = new System.Windows.Forms.Button();
            this.button_convert = new System.Windows.Forms.Button();
            this.richTextBox_logs = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button_openTextFile
            // 
            this.button_openTextFile.Location = new System.Drawing.Point(12, 12);
            this.button_openTextFile.Name = "button_openTextFile";
            this.button_openTextFile.Size = new System.Drawing.Size(148, 63);
            this.button_openTextFile.TabIndex = 0;
            this.button_openTextFile.Text = "打开文件";
            this.button_openTextFile.UseVisualStyleBackColor = true;
            this.button_openTextFile.Click += new System.EventHandler(this.button_openTextFile_Click);
            // 
            // button_convert
            // 
            this.button_convert.Location = new System.Drawing.Point(166, 12);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(148, 63);
            this.button_convert.TabIndex = 1;
            this.button_convert.Text = "生成Charlist";
            this.button_convert.UseVisualStyleBackColor = true;
            this.button_convert.Click += new System.EventHandler(this.button_convert_Click);
            // 
            // richTextBox_logs
            // 
            this.richTextBox_logs.Location = new System.Drawing.Point(14, 90);
            this.richTextBox_logs.Name = "richTextBox_logs";
            this.richTextBox_logs.ReadOnly = true;
            this.richTextBox_logs.Size = new System.Drawing.Size(933, 222);
            this.richTextBox_logs.TabIndex = 2;
            this.richTextBox_logs.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(958, 324);
            this.Controls.Add(this.richTextBox_logs);
            this.Controls.Add(this.button_convert);
            this.Controls.Add(this.button_openTextFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Charlist Maker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_openTextFile;
        private System.Windows.Forms.Button button_convert;
        private System.Windows.Forms.RichTextBox richTextBox_logs;
    }
}

