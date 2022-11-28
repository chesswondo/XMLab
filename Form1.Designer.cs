
namespace XMLab
{
    partial class XMLab
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchResultsViewer = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.linqBtn = new System.Windows.Forms.RadioButton();
            this.domBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.saxBtn = new System.Windows.Forms.RadioButton();
            this.dlFaculty = new System.Windows.Forms.ComboBox();
            this.dlYear = new System.Windows.Forms.ComboBox();
            this.dlAuthor = new System.Windows.Forms.ComboBox();
            this.dlTitle = new System.Windows.Forms.ComboBox();
            this.SearchFaculty = new System.Windows.Forms.CheckBox();
            this.SearchYear = new System.Windows.Forms.CheckBox();
            this.SearchAuthor = new System.Windows.Forms.CheckBox();
            this.SearchTitle = new System.Windows.Forms.CheckBox();
            this.htmlBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchResultsViewer
            // 
            this.searchResultsViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchResultsViewer.Location = new System.Drawing.Point(464, 12);
            this.searchResultsViewer.Name = "searchResultsViewer";
            this.searchResultsViewer.ReadOnly = true;
            this.searchResultsViewer.Size = new System.Drawing.Size(324, 273);
            this.searchResultsViewer.TabIndex = 0;
            this.searchResultsViewer.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Controls.Add(this.linqBtn);
            this.groupBox1.Controls.Add(this.domBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.saxBtn);
            this.groupBox1.Controls.Add(this.dlFaculty);
            this.groupBox1.Controls.Add(this.dlYear);
            this.groupBox1.Controls.Add(this.dlAuthor);
            this.groupBox1.Controls.Add(this.dlTitle);
            this.groupBox1.Controls.Add(this.SearchFaculty);
            this.groupBox1.Controls.Add(this.SearchYear);
            this.groupBox1.Controls.Add(this.SearchAuthor);
            this.groupBox1.Controls.Add(this.SearchTitle);
            this.groupBox1.Location = new System.Drawing.Point(20, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 231);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Критерії пошуку";
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBtn.Location = new System.Drawing.Point(335, 169);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 46);
            this.searchBtn.TabIndex = 14;
            this.searchBtn.Text = "Пошук";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtnClick);
            // 
            // linqBtn
            // 
            this.linqBtn.AutoSize = true;
            this.linqBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linqBtn.Location = new System.Drawing.Point(170, 183);
            this.linqBtn.Margin = new System.Windows.Forms.Padding(2);
            this.linqBtn.Name = "linqBtn";
            this.linqBtn.Size = new System.Drawing.Size(99, 20);
            this.linqBtn.TabIndex = 13;
            this.linqBtn.Text = "LINQ to XML";
            this.linqBtn.UseVisualStyleBackColor = true;
            // 
            // domBtn
            // 
            this.domBtn.AutoSize = true;
            this.domBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.domBtn.Location = new System.Drawing.Point(95, 183);
            this.domBtn.Margin = new System.Windows.Forms.Padding(2);
            this.domBtn.Name = "domBtn";
            this.domBtn.Size = new System.Drawing.Size(57, 20);
            this.domBtn.TabIndex = 12;
            this.domBtn.Text = "DOM";
            this.domBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Використаний метод";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // saxBtn
            // 
            this.saxBtn.AutoSize = true;
            this.saxBtn.Checked = true;
            this.saxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saxBtn.Location = new System.Drawing.Point(25, 183);
            this.saxBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saxBtn.Name = "saxBtn";
            this.saxBtn.Size = new System.Drawing.Size(52, 20);
            this.saxBtn.TabIndex = 10;
            this.saxBtn.TabStop = true;
            this.saxBtn.Text = "SAX";
            this.saxBtn.UseVisualStyleBackColor = true;
            // 
            // dlFaculty
            // 
            this.dlFaculty.Enabled = false;
            this.dlFaculty.FormattingEnabled = true;
            this.dlFaculty.Location = new System.Drawing.Point(213, 111);
            this.dlFaculty.Name = "dlFaculty";
            this.dlFaculty.Size = new System.Drawing.Size(197, 21);
            this.dlFaculty.TabIndex = 7;
            // 
            // dlYear
            // 
            this.dlYear.Enabled = false;
            this.dlYear.FormattingEnabled = true;
            this.dlYear.Location = new System.Drawing.Point(213, 84);
            this.dlYear.Name = "dlYear";
            this.dlYear.Size = new System.Drawing.Size(197, 21);
            this.dlYear.TabIndex = 6;
            // 
            // dlAuthor
            // 
            this.dlAuthor.Enabled = false;
            this.dlAuthor.FormattingEnabled = true;
            this.dlAuthor.Location = new System.Drawing.Point(213, 57);
            this.dlAuthor.Name = "dlAuthor";
            this.dlAuthor.Size = new System.Drawing.Size(197, 21);
            this.dlAuthor.TabIndex = 5;
            // 
            // dlTitle
            // 
            this.dlTitle.Enabled = false;
            this.dlTitle.FormattingEnabled = true;
            this.dlTitle.Location = new System.Drawing.Point(213, 30);
            this.dlTitle.Name = "dlTitle";
            this.dlTitle.Size = new System.Drawing.Size(197, 21);
            this.dlTitle.TabIndex = 4;
            // 
            // SearchFaculty
            // 
            this.SearchFaculty.AutoSize = true;
            this.SearchFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchFaculty.Location = new System.Drawing.Point(6, 108);
            this.SearchFaculty.Name = "SearchFaculty";
            this.SearchFaculty.Size = new System.Drawing.Size(179, 20);
            this.SearchFaculty.TabIndex = 3;
            this.SearchFaculty.Text = "Пошук за факультетом";
            this.SearchFaculty.UseVisualStyleBackColor = true;
            this.SearchFaculty.CheckedChanged += new System.EventHandler(this.SearchFacultyChanged);
            // 
            // SearchYear
            // 
            this.SearchYear.AutoSize = true;
            this.SearchYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchYear.Location = new System.Drawing.Point(6, 82);
            this.SearchYear.Name = "SearchYear";
            this.SearchYear.Size = new System.Drawing.Size(189, 20);
            this.SearchYear.TabIndex = 2;
            this.SearchYear.Text = "Пошук за роком видання";
            this.SearchYear.UseVisualStyleBackColor = true;
            this.SearchYear.CheckedChanged += new System.EventHandler(this.SearchYearChanged);
            // 
            // SearchAuthor
            // 
            this.SearchAuthor.AutoSize = true;
            this.SearchAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchAuthor.Location = new System.Drawing.Point(6, 56);
            this.SearchAuthor.Name = "SearchAuthor";
            this.SearchAuthor.Size = new System.Drawing.Size(147, 20);
            this.SearchAuthor.TabIndex = 1;
            this.SearchAuthor.Text = "Пошук за автором";
            this.SearchAuthor.UseVisualStyleBackColor = true;
            this.SearchAuthor.CheckedChanged += new System.EventHandler(this.SearchAuthorChanged);
            // 
            // SearchTitle
            // 
            this.SearchTitle.AutoSize = true;
            this.SearchTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchTitle.Location = new System.Drawing.Point(6, 30);
            this.SearchTitle.Name = "SearchTitle";
            this.SearchTitle.Size = new System.Drawing.Size(141, 20);
            this.SearchTitle.TabIndex = 0;
            this.SearchTitle.Text = "Пошук за назвою";
            this.SearchTitle.UseVisualStyleBackColor = true;
            this.SearchTitle.CheckedChanged += new System.EventHandler(this.SearchTitleChanged);
            // 
            // htmlBtn
            // 
            this.htmlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.htmlBtn.Location = new System.Drawing.Point(20, 262);
            this.htmlBtn.Name = "htmlBtn";
            this.htmlBtn.Size = new System.Drawing.Size(433, 23);
            this.htmlBtn.TabIndex = 2;
            this.htmlBtn.Text = "Конвертувати в HTML";
            this.htmlBtn.UseVisualStyleBackColor = true;
            this.htmlBtn.Click += new System.EventHandler(this.htmlBtn_Click);
            // 
            // XMLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 302);
            this.Controls.Add(this.htmlBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.searchResultsViewer);
            this.Name = "XMLab";
            this.Text = "XMLab";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox searchResultsViewer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox SearchTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton saxBtn;
        private System.Windows.Forms.ComboBox dlFaculty;
        private System.Windows.Forms.ComboBox dlYear;
        private System.Windows.Forms.ComboBox dlAuthor;
        private System.Windows.Forms.ComboBox dlTitle;
        private System.Windows.Forms.CheckBox SearchFaculty;
        private System.Windows.Forms.CheckBox SearchYear;
        private System.Windows.Forms.CheckBox SearchAuthor;
        private System.Windows.Forms.RadioButton linqBtn;
        private System.Windows.Forms.RadioButton domBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button htmlBtn;
    }
}

