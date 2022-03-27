namespace Sort
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Menu_Panel = new System.Windows.Forms.Panel();
            this.choose_text = new System.Windows.Forms.Label();
            this.bubsort_text = new System.Windows.Forms.Label();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.effsort_text = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.simpsort_text = new System.Windows.Forms.Label();
            this.Next_Button = new Sort.RoundedButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Menu_Button = new Sort.RoundedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.stepbystep = new System.Windows.Forms.CheckBox();
            this.about_panel = new System.Windows.Forms.Panel();
            this.About_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Sort_Button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortingAlgorithmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleSortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertionSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.efficientSortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heapSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bubbleSortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bubbleSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shellSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.Menu_Panel.SuspendLayout();
            this.about_panel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Menu_Panel);
            this.panel1.Controls.Add(this.stepbystep);
            this.panel1.Controls.Add(this.about_panel);
            this.panel1.Controls.Add(this.Sort_Button);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1072, 453);
            this.panel1.TabIndex = 0;
            // 
            // Menu_Panel
            // 
            this.Menu_Panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Menu_Panel.Controls.Add(this.choose_text);
            this.Menu_Panel.Controls.Add(this.bubsort_text);
            this.Menu_Panel.Controls.Add(this.radioButton6);
            this.Menu_Panel.Controls.Add(this.radioButton5);
            this.Menu_Panel.Controls.Add(this.radioButton4);
            this.Menu_Panel.Controls.Add(this.effsort_text);
            this.Menu_Panel.Controls.Add(this.radioButton3);
            this.Menu_Panel.Controls.Add(this.simpsort_text);
            this.Menu_Panel.Controls.Add(this.Next_Button);
            this.Menu_Panel.Controls.Add(this.radioButton2);
            this.Menu_Panel.Controls.Add(this.radioButton1);
            this.Menu_Panel.Controls.Add(this.Menu_Button);
            this.Menu_Panel.Controls.Add(this.label2);
            this.Menu_Panel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Menu_Panel.Location = new System.Drawing.Point(3, 31);
            this.Menu_Panel.Name = "Menu_Panel";
            this.Menu_Panel.Size = new System.Drawing.Size(1069, 419);
            this.Menu_Panel.TabIndex = 4;
            // 
            // choose_text
            // 
            this.choose_text.AutoSize = true;
            this.choose_text.Font = new System.Drawing.Font("Microsoft YaHei", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose_text.Location = new System.Drawing.Point(8, 12);
            this.choose_text.Name = "choose_text";
            this.choose_text.Size = new System.Drawing.Size(437, 40);
            this.choose_text.TabIndex = 12;
            this.choose_text.Text = "Choose a sorting algorithm:";
            // 
            // bubsort_text
            // 
            this.bubsort_text.AutoSize = true;
            this.bubsort_text.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bubsort_text.Location = new System.Drawing.Point(643, 111);
            this.bubsort_text.Name = "bubsort_text";
            this.bubsort_text.Size = new System.Drawing.Size(316, 31);
            this.bubsort_text.TabIndex = 11;
            this.bubsort_text.Text = "Bubble Sorts and Variant";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(649, 202);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(88, 21);
            this.radioButton6.TabIndex = 10;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Shell sort";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(649, 166);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(101, 21);
            this.radioButton5.TabIndex = 9;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Bubble sort";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(381, 202);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(97, 21);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Merge sort";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // effsort_text
            // 
            this.effsort_text.AutoSize = true;
            this.effsort_text.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effsort_text.Location = new System.Drawing.Point(375, 111);
            this.effsort_text.Name = "effsort_text";
            this.effsort_text.Size = new System.Drawing.Size(183, 31);
            this.effsort_text.TabIndex = 7;
            this.effsort_text.Text = "Efficient Sorts";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(381, 166);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(91, 21);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Heap sort";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // simpsort_text
            // 
            this.simpsort_text.AutoSize = true;
            this.simpsort_text.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpsort_text.Location = new System.Drawing.Point(132, 111);
            this.simpsort_text.Name = "simpsort_text";
            this.simpsort_text.Size = new System.Drawing.Size(165, 31);
            this.simpsort_text.TabIndex = 5;
            this.simpsort_text.Text = "Simple Sorts";
            // 
            // Next_Button
            // 
            this.Next_Button.Location = new System.Drawing.Point(477, 284);
            this.Next_Button.Name = "Next_Button";
            this.Next_Button.Size = new System.Drawing.Size(105, 37);
            this.Next_Button.TabIndex = 4;
            this.Next_Button.Text = "Let\'s sort";
            this.Next_Button.UseVisualStyleBackColor = true;
            this.Next_Button.Click += new System.EventHandler(this.Next_Button_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(138, 202);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(111, 21);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Insertion sort";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(138, 166);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(122, 21);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Selecction sort";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Menu_Button
            // 
            this.Menu_Button.Location = new System.Drawing.Point(477, 241);
            this.Menu_Button.Name = "Menu_Button";
            this.Menu_Button.Size = new System.Drawing.Size(108, 39);
            this.Menu_Button.TabIndex = 1;
            this.Menu_Button.Text = "START";
            this.Menu_Button.UseVisualStyleBackColor = true;
            this.Menu_Button.Click += new System.EventHandler(this.Menu_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 54);
            this.label2.TabIndex = 0;
            this.label2.Text = "SORTBOT";
            // 
            // stepbystep
            // 
            this.stepbystep.AutoSize = true;
            this.stepbystep.Location = new System.Drawing.Point(871, 156);
            this.stepbystep.Name = "stepbystep";
            this.stepbystep.Size = new System.Drawing.Size(119, 21);
            this.stepbystep.TabIndex = 3;
            this.stepbystep.Text = "Instant sorting";
            this.stepbystep.UseVisualStyleBackColor = true;
            // 
            // about_panel
            // 
            this.about_panel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.about_panel.Controls.Add(this.About_Button);
            this.about_panel.Controls.Add(this.label1);
            this.about_panel.Location = new System.Drawing.Point(355, 111);
            this.about_panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.about_panel.Name = "about_panel";
            this.about_panel.Size = new System.Drawing.Size(363, 143);
            this.about_panel.TabIndex = 2;
            // 
            // About_Button
            // 
            this.About_Button.Location = new System.Drawing.Point(137, 98);
            this.About_Button.Margin = new System.Windows.Forms.Padding(4);
            this.About_Button.Name = "About_Button";
            this.About_Button.Size = new System.Drawing.Size(83, 25);
            this.About_Button.TabIndex = 1;
            this.About_Button.Text = "close";
            this.About_Button.UseVisualStyleBackColor = true;
            this.About_Button.Click += new System.EventHandler(this.Aboout_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Made by Dosa Csaba\r\n12th project, 2020";
            // 
            // Sort_Button
            // 
            this.Sort_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sort_Button.AutoSize = true;
            this.Sort_Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sort_Button.Location = new System.Drawing.Point(492, 315);
            this.Sort_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sort_Button.Name = "Sort_Button";
            this.Sort_Button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Sort_Button.Size = new System.Drawing.Size(93, 45);
            this.Sort_Button.TabIndex = 0;
            this.Sort_Button.Text = "Sort";
            this.Sort_Button.UseVisualStyleBackColor = true;
            this.Sort_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1072, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortingAlgorithmsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // sortingAlgorithmsToolStripMenuItem
            // 
            this.sortingAlgorithmsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleSortsToolStripMenuItem,
            this.efficientSortsToolStripMenuItem,
            this.bubbleSortsToolStripMenuItem});
            this.sortingAlgorithmsToolStripMenuItem.Name = "sortingAlgorithmsToolStripMenuItem";
            this.sortingAlgorithmsToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.sortingAlgorithmsToolStripMenuItem.Text = "Sorting algorithms";
            // 
            // simpleSortsToolStripMenuItem
            // 
            this.simpleSortsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectionSortToolStripMenuItem,
            this.insertionSortToolStripMenuItem});
            this.simpleSortsToolStripMenuItem.Name = "simpleSortsToolStripMenuItem";
            this.simpleSortsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.simpleSortsToolStripMenuItem.Text = "Simple sorts";
            // 
            // selectionSortToolStripMenuItem
            // 
            this.selectionSortToolStripMenuItem.Name = "selectionSortToolStripMenuItem";
            this.selectionSortToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.selectionSortToolStripMenuItem.Text = "Selection sort";
            this.selectionSortToolStripMenuItem.Click += new System.EventHandler(this.selectionSortToolStripMenuItem_Click_1);
            // 
            // insertionSortToolStripMenuItem
            // 
            this.insertionSortToolStripMenuItem.Name = "insertionSortToolStripMenuItem";
            this.insertionSortToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.insertionSortToolStripMenuItem.Text = "Insertion sort";
            this.insertionSortToolStripMenuItem.Click += new System.EventHandler(this.insertionSortToolStripMenuItem_Click);
            // 
            // efficientSortsToolStripMenuItem
            // 
            this.efficientSortsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heapSortToolStripMenuItem,
            this.mergeSortToolStripMenuItem});
            this.efficientSortsToolStripMenuItem.Name = "efficientSortsToolStripMenuItem";
            this.efficientSortsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.efficientSortsToolStripMenuItem.Text = "Efficient sorts";
            // 
            // heapSortToolStripMenuItem
            // 
            this.heapSortToolStripMenuItem.Name = "heapSortToolStripMenuItem";
            this.heapSortToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.heapSortToolStripMenuItem.Text = "Heap sort";
            this.heapSortToolStripMenuItem.Click += new System.EventHandler(this.heapSortToolStripMenuItem_Click);
            // 
            // mergeSortToolStripMenuItem
            // 
            this.mergeSortToolStripMenuItem.Name = "mergeSortToolStripMenuItem";
            this.mergeSortToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.mergeSortToolStripMenuItem.Text = "Merge Sort";
            this.mergeSortToolStripMenuItem.Click += new System.EventHandler(this.mergeSortToolStripMenuItem_Click);
            // 
            // bubbleSortsToolStripMenuItem
            // 
            this.bubbleSortsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bubbleSortToolStripMenuItem,
            this.shellSortToolStripMenuItem});
            this.bubbleSortsToolStripMenuItem.Name = "bubbleSortsToolStripMenuItem";
            this.bubbleSortsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.bubbleSortsToolStripMenuItem.Text = "Bubble Sorts";
            // 
            // bubbleSortToolStripMenuItem
            // 
            this.bubbleSortToolStripMenuItem.Name = "bubbleSortToolStripMenuItem";
            this.bubbleSortToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.bubbleSortToolStripMenuItem.Text = "Bubble sort";
            this.bubbleSortToolStripMenuItem.Click += new System.EventHandler(this.bubbleSortToolStripMenuItem_Click);
            // 
            // shellSortToolStripMenuItem
            // 
            this.shellSortToolStripMenuItem.Name = "shellSortToolStripMenuItem";
            this.shellSortToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.shellSortToolStripMenuItem.Text = "Shell sort";
            this.shellSortToolStripMenuItem.Click += new System.EventHandler(this.shellSortToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 452);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "SortBot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Menu_Panel.ResumeLayout(false);
            this.Menu_Panel.PerformLayout();
            this.about_panel.ResumeLayout(false);
            this.about_panel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Sort_Button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel about_panel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button About_Button;
        private System.Windows.Forms.CheckBox stepbystep;
        private System.Windows.Forms.Panel Menu_Panel;
        private RoundedButton Menu_Button;
        private System.Windows.Forms.Label label2;
        private RoundedButton Next_Button;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ToolStripMenuItem sortingAlgorithmsToolStripMenuItem;
        private System.Windows.Forms.Label simpsort_text;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ToolStripMenuItem simpleSortsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectionSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertionSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem efficientSortsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem heapSortToolStripMenuItem;
        private System.Windows.Forms.Label effsort_text;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.ToolStripMenuItem mergeSortToolStripMenuItem;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.ToolStripMenuItem bubbleSortsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bubbleSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shellSortToolStripMenuItem;
        private System.Windows.Forms.Label bubsort_text;
        private System.Windows.Forms.Label choose_text;
    }
}

