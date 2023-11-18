namespace Assignment_7
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.makeupCheckBox = new System.Windows.Forms.RadioButton();
            this.skincareCheckBox = new System.Windows.Forms.RadioButton();
            this.productTypeLabel = new System.Windows.Forms.Label();
            this.nameAndDateGroupBox = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.expirationDateLabel = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.ingrediensGroupBox = new System.Windows.Forms.GroupBox();
            this.ingrediensListBox = new System.Windows.Forms.ListBox();
            this.ingrediensLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.productListBox = new System.Windows.Forms.ListBox();
            this.gentleGroupBox = new System.Windows.Forms.GroupBox();
            this.gentleIngrediensListbox = new System.Windows.Forms.ListBox();
            this.gentleLabel = new System.Windows.Forms.Label();
            this.productTypeListLabel = new System.Windows.Forms.Label();
            this.productNameListLabel = new System.Windows.Forms.Label();
            this.expirationDateListLabel = new System.Windows.Forms.Label();
            this.irritationGroupBox = new System.Windows.Forms.GroupBox();
            this.badIngrediensListbox = new System.Windows.Forms.ListBox();
            this.irritationLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.productIngrediensGroupbox = new System.Windows.Forms.GroupBox();
            this.productIngrediensListbox = new System.Windows.Forms.ListBox();
            this.productIngrediensLabel = new System.Windows.Forms.Label();
            this.neutralLabel = new System.Windows.Forms.Label();
            this.neautralIngrediensListBox = new System.Windows.Forms.ListBox();
            this.neutralGroupBox = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.productTypeGroupBox.SuspendLayout();
            this.nameAndDateGroupBox.SuspendLayout();
            this.ingrediensGroupBox.SuspendLayout();
            this.gentleGroupBox.SuspendLayout();
            this.irritationGroupBox.SuspendLayout();
            this.productIngrediensGroupbox.SuspendLayout();
            this.neutralGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Bisque;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1440, 43);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openDataFileToolStripMenuItem,
            this.saveDataFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Sylfaen", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(81, 39);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.newToolStripMenuItem.Font = new System.Drawing.Font("Sylfaen", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(371, 44);
            this.newToolStripMenuItem.Text = "New         Ctrl+N";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openDataFileToolStripMenuItem
            // 
            this.openDataFileToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.openDataFileToolStripMenuItem.Font = new System.Drawing.Font("Sylfaen", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openDataFileToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.openDataFileToolStripMenuItem.Name = "openDataFileToolStripMenuItem";
            this.openDataFileToolStripMenuItem.Size = new System.Drawing.Size(371, 44);
            this.openDataFileToolStripMenuItem.Text = "Open data file";
            this.openDataFileToolStripMenuItem.Click += new System.EventHandler(this.openDataFileToolStripMenuItem_Click);
            // 
            // saveDataFileToolStripMenuItem
            // 
            this.saveDataFileToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.saveDataFileToolStripMenuItem.Font = new System.Drawing.Font("Sylfaen", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveDataFileToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.saveDataFileToolStripMenuItem.Name = "saveDataFileToolStripMenuItem";
            this.saveDataFileToolStripMenuItem.Size = new System.Drawing.Size(371, 44);
            this.saveDataFileToolStripMenuItem.Text = "Save data file";
            this.saveDataFileToolStripMenuItem.Click += new System.EventHandler(this.saveDataFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Sylfaen", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.exitToolStripMenuItem.Image = global::Assignment_7.Properties.Resources._3094700;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(371, 44);
            this.exitToolStripMenuItem.Text = "Exit         Alt + F4";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Sylfaen", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(94, 39);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.Coral;
            this.aboutToolStripMenuItem.Image = global::Assignment_7.Properties.Resources._1010301_200;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(248, 44);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // productTypeGroupBox
            // 
            this.productTypeGroupBox.Controls.Add(this.makeupCheckBox);
            this.productTypeGroupBox.Controls.Add(this.skincareCheckBox);
            this.productTypeGroupBox.Controls.Add(this.productTypeLabel);
            this.productTypeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.productTypeGroupBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productTypeGroupBox.Location = new System.Drawing.Point(30, 46);
            this.productTypeGroupBox.Name = "productTypeGroupBox";
            this.productTypeGroupBox.Size = new System.Drawing.Size(178, 127);
            this.productTypeGroupBox.TabIndex = 1;
            this.productTypeGroupBox.TabStop = false;
            // 
            // makeupCheckBox
            // 
            this.makeupCheckBox.AutoSize = true;
            this.makeupCheckBox.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeupCheckBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.makeupCheckBox.Location = new System.Drawing.Point(6, 81);
            this.makeupCheckBox.Name = "makeupCheckBox";
            this.makeupCheckBox.Size = new System.Drawing.Size(159, 46);
            this.makeupCheckBox.TabIndex = 15;
            this.makeupCheckBox.TabStop = true;
            this.makeupCheckBox.Text = "Makeup";
            this.makeupCheckBox.UseVisualStyleBackColor = true;
            this.makeupCheckBox.CheckedChanged += new System.EventHandler(this.makeupCheckBox_CheckedChanged);
            // 
            // skincareCheckBox
            // 
            this.skincareCheckBox.AutoSize = true;
            this.skincareCheckBox.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skincareCheckBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.skincareCheckBox.Location = new System.Drawing.Point(6, 54);
            this.skincareCheckBox.Name = "skincareCheckBox";
            this.skincareCheckBox.Size = new System.Drawing.Size(163, 46);
            this.skincareCheckBox.TabIndex = 3;
            this.skincareCheckBox.TabStop = true;
            this.skincareCheckBox.Text = "Skincare";
            this.skincareCheckBox.UseVisualStyleBackColor = true;
            this.skincareCheckBox.CheckedChanged += new System.EventHandler(this.skincareCheckBox_CheckedChanged);
            // 
            // productTypeLabel
            // 
            this.productTypeLabel.AutoSize = true;
            this.productTypeLabel.Font = new System.Drawing.Font("Sylfaen", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productTypeLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.productTypeLabel.Location = new System.Drawing.Point(6, 16);
            this.productTypeLabel.Name = "productTypeLabel";
            this.productTypeLabel.Size = new System.Drawing.Size(269, 57);
            this.productTypeLabel.TabIndex = 0;
            this.productTypeLabel.Text = "Product Type";
            // 
            // nameAndDateGroupBox
            // 
            this.nameAndDateGroupBox.Controls.Add(this.dateTimePicker1);
            this.nameAndDateGroupBox.Controls.Add(this.expirationDateLabel);
            this.nameAndDateGroupBox.Controls.Add(this.productNameTextBox);
            this.nameAndDateGroupBox.Controls.Add(this.productNameLabel);
            this.nameAndDateGroupBox.Location = new System.Drawing.Point(213, 46);
            this.nameAndDateGroupBox.Name = "nameAndDateGroupBox";
            this.nameAndDateGroupBox.Size = new System.Drawing.Size(541, 142);
            this.nameAndDateGroupBox.TabIndex = 2;
            this.nameAndDateGroupBox.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.RosyBrown;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.RosyBrown;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.RosyBrown;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.RosyBrown;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.RosyBrown;
            this.dateTimePicker1.Location = new System.Drawing.Point(192, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(345, 46);
            this.dateTimePicker1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.dateTimePicker1, "Click to open calender for date");
            // 
            // expirationDateLabel
            // 
            this.expirationDateLabel.AutoSize = true;
            this.expirationDateLabel.Font = new System.Drawing.Font("Sylfaen", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirationDateLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.expirationDateLabel.Location = new System.Drawing.Point(5, 90);
            this.expirationDateLabel.Name = "expirationDateLabel";
            this.expirationDateLabel.Size = new System.Drawing.Size(299, 57);
            this.expirationDateLabel.TabIndex = 3;
            this.expirationDateLabel.Text = "Expiration date";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.BackColor = System.Drawing.Color.Bisque;
            this.productNameTextBox.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameTextBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.productNameTextBox.Location = new System.Drawing.Point(189, 18);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(345, 50);
            this.productNameTextBox.TabIndex = 1;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Sylfaen", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.productNameLabel.Location = new System.Drawing.Point(5, 15);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(277, 57);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "Product name";
            // 
            // ingrediensGroupBox
            // 
            this.ingrediensGroupBox.Controls.Add(this.ingrediensListBox);
            this.ingrediensGroupBox.Controls.Add(this.ingrediensLabel);
            this.ingrediensGroupBox.Location = new System.Drawing.Point(2129, 94);
            this.ingrediensGroupBox.Name = "ingrediensGroupBox";
            this.ingrediensGroupBox.Size = new System.Drawing.Size(407, 190);
            this.ingrediensGroupBox.TabIndex = 5;
            this.ingrediensGroupBox.TabStop = false;
            // 
            // ingrediensListBox
            // 
            this.ingrediensListBox.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingrediensListBox.ForeColor = System.Drawing.Color.IndianRed;
            this.ingrediensListBox.FormattingEnabled = true;
            this.ingrediensListBox.ItemHeight = 31;
            this.ingrediensListBox.Location = new System.Drawing.Point(6, 33);
            this.ingrediensListBox.MultiColumn = true;
            this.ingrediensListBox.Name = "ingrediensListBox";
            this.ingrediensListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ingrediensListBox.ScrollAlwaysVisible = true;
            this.ingrediensListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ingrediensListBox.Size = new System.Drawing.Size(5460, 314);
            this.ingrediensListBox.Sorted = true;
            this.ingrediensListBox.TabIndex = 1;
            // 
            // ingrediensLabel
            // 
            this.ingrediensLabel.AutoSize = true;
            this.ingrediensLabel.Font = new System.Drawing.Font("Sylfaen", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingrediensLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.ingrediensLabel.Location = new System.Drawing.Point(95, 14);
            this.ingrediensLabel.Name = "ingrediensLabel";
            this.ingrediensLabel.Size = new System.Drawing.Size(365, 57);
            this.ingrediensLabel.TabIndex = 0;
            this.ingrediensLabel.Text = "Product ingrediens";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Bisque;
            this.addButton.Font = new System.Drawing.Font("Sylfaen", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.addButton.Location = new System.Drawing.Point(1276, 73);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(164, 57);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // productListBox
            // 
            this.productListBox.BackColor = System.Drawing.Color.Bisque;
            this.productListBox.Enabled = false;
            this.productListBox.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productListBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.productListBox.FormattingEnabled = true;
            this.productListBox.ItemHeight = 42;
            this.productListBox.Location = new System.Drawing.Point(8, 221);
            this.productListBox.Name = "productListBox";
            this.productListBox.Size = new System.Drawing.Size(830, 382);
            this.productListBox.TabIndex = 6;
            this.productListBox.SelectedIndexChanged += new System.EventHandler(this.productListBox_SelectedIndexChanged);
            // 
            // gentleGroupBox
            // 
            this.gentleGroupBox.Controls.Add(this.gentleIngrediensListbox);
            this.gentleGroupBox.Controls.Add(this.gentleLabel);
            this.gentleGroupBox.Location = new System.Drawing.Point(838, 199);
            this.gentleGroupBox.Name = "gentleGroupBox";
            this.gentleGroupBox.Size = new System.Drawing.Size(196, 404);
            this.gentleGroupBox.TabIndex = 7;
            this.gentleGroupBox.TabStop = false;
            // 
            // gentleIngrediensListbox
            // 
            this.gentleIngrediensListbox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gentleIngrediensListbox.Enabled = false;
            this.gentleIngrediensListbox.FormattingEnabled = true;
            this.gentleIngrediensListbox.ItemHeight = 32;
            this.gentleIngrediensListbox.Location = new System.Drawing.Point(10, 46);
            this.gentleIngrediensListbox.Name = "gentleIngrediensListbox";
            this.gentleIngrediensListbox.Size = new System.Drawing.Size(179, 356);
            this.gentleIngrediensListbox.Sorted = true;
            this.gentleIngrediensListbox.TabIndex = 2;
            // 
            // gentleLabel
            // 
            this.gentleLabel.AutoSize = true;
            this.gentleLabel.Font = new System.Drawing.Font("Sylfaen", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gentleLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.gentleLabel.Location = new System.Drawing.Point(10, 12);
            this.gentleLabel.Name = "gentleLabel";
            this.gentleLabel.Size = new System.Drawing.Size(313, 48);
            this.gentleLabel.TabIndex = 1;
            this.gentleLabel.Text = "Gentle ingrediens";
            // 
            // productTypeListLabel
            // 
            this.productTypeListLabel.AutoSize = true;
            this.productTypeListLabel.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productTypeListLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.productTypeListLabel.Location = new System.Drawing.Point(9, 198);
            this.productTypeListLabel.Name = "productTypeListLabel";
            this.productTypeListLabel.Size = new System.Drawing.Size(205, 42);
            this.productTypeListLabel.TabIndex = 8;
            this.productTypeListLabel.Text = "Product type";
            // 
            // productNameListLabel
            // 
            this.productNameListLabel.AutoSize = true;
            this.productNameListLabel.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameListLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.productNameListLabel.Location = new System.Drawing.Point(341, 199);
            this.productNameListLabel.Name = "productNameListLabel";
            this.productNameListLabel.Size = new System.Drawing.Size(219, 42);
            this.productNameListLabel.TabIndex = 9;
            this.productNameListLabel.Text = "Product name";
            // 
            // expirationDateListLabel
            // 
            this.expirationDateListLabel.AutoSize = true;
            this.expirationDateListLabel.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirationDateListLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.expirationDateListLabel.Location = new System.Drawing.Point(675, 199);
            this.expirationDateListLabel.Name = "expirationDateListLabel";
            this.expirationDateListLabel.Size = new System.Drawing.Size(239, 42);
            this.expirationDateListLabel.TabIndex = 10;
            this.expirationDateListLabel.Text = "Expiration date";
            // 
            // irritationGroupBox
            // 
            this.irritationGroupBox.Controls.Add(this.badIngrediensListbox);
            this.irritationGroupBox.Controls.Add(this.irritationLabel);
            this.irritationGroupBox.Location = new System.Drawing.Point(1243, 171);
            this.irritationGroupBox.Name = "irritationGroupBox";
            this.irritationGroupBox.Size = new System.Drawing.Size(197, 433);
            this.irritationGroupBox.TabIndex = 8;
            this.irritationGroupBox.TabStop = false;
            // 
            // badIngrediensListbox
            // 
            this.badIngrediensListbox.BackColor = System.Drawing.Color.IndianRed;
            this.badIngrediensListbox.Enabled = false;
            this.badIngrediensListbox.FormattingEnabled = true;
            this.badIngrediensListbox.ItemHeight = 32;
            this.badIngrediensListbox.Location = new System.Drawing.Point(6, 76);
            this.badIngrediensListbox.Name = "badIngrediensListbox";
            this.badIngrediensListbox.Size = new System.Drawing.Size(180, 356);
            this.badIngrediensListbox.Sorted = true;
            this.badIngrediensListbox.TabIndex = 16;
            // 
            // irritationLabel
            // 
            this.irritationLabel.AutoSize = true;
            this.irritationLabel.Font = new System.Drawing.Font("Sylfaen", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.irritationLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.irritationLabel.Location = new System.Drawing.Point(9, 42);
            this.irritationLabel.Name = "irritationLabel";
            this.irritationLabel.Size = new System.Drawing.Size(276, 48);
            this.irritationLabel.TabIndex = 15;
            this.irritationLabel.Text = "Cause irritation";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Bisque;
            this.deleteButton.Enabled = false;
            this.deleteButton.Font = new System.Drawing.Font("Sylfaen", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.deleteButton.Location = new System.Drawing.Point(150, 611);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(124, 49);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.Bisque;
            this.editButton.Enabled = false;
            this.editButton.Font = new System.Drawing.Font("Sylfaen", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.Color.OrangeRed;
            this.editButton.Location = new System.Drawing.Point(514, 609);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(127, 51);
            this.editButton.TabIndex = 14;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // productIngrediensGroupbox
            // 
            this.productIngrediensGroupbox.Controls.Add(this.productIngrediensListbox);
            this.productIngrediensGroupbox.Controls.Add(this.productIngrediensLabel);
            this.productIngrediensGroupbox.Location = new System.Drawing.Point(760, 33);
            this.productIngrediensGroupbox.Name = "productIngrediensGroupbox";
            this.productIngrediensGroupbox.Size = new System.Drawing.Size(510, 155);
            this.productIngrediensGroupbox.TabIndex = 15;
            this.productIngrediensGroupbox.TabStop = false;
            // 
            // productIngrediensListbox
            // 
            this.productIngrediensListbox.Font = new System.Drawing.Font("Sylfaen", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIngrediensListbox.ForeColor = System.Drawing.Color.IndianRed;
            this.productIngrediensListbox.FormattingEnabled = true;
            this.productIngrediensListbox.ItemHeight = 35;
            this.productIngrediensListbox.Location = new System.Drawing.Point(6, 35);
            this.productIngrediensListbox.Name = "productIngrediensListbox";
            this.productIngrediensListbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.productIngrediensListbox.Size = new System.Drawing.Size(498, 109);
            this.productIngrediensListbox.Sorted = true;
            this.productIngrediensListbox.TabIndex = 2;
            // 
            // productIngrediensLabel
            // 
            this.productIngrediensLabel.AutoSize = true;
            this.productIngrediensLabel.Font = new System.Drawing.Font("Sylfaen", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIngrediensLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.productIngrediensLabel.Location = new System.Drawing.Point(106, 2);
            this.productIngrediensLabel.Name = "productIngrediensLabel";
            this.productIngrediensLabel.Size = new System.Drawing.Size(365, 57);
            this.productIngrediensLabel.TabIndex = 1;
            this.productIngrediensLabel.Text = "Product ingrediens";
            // 
            // neutralLabel
            // 
            this.neutralLabel.AutoSize = true;
            this.neutralLabel.Font = new System.Drawing.Font("Sylfaen", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.neutralLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.neutralLabel.Location = new System.Drawing.Point(-7, 39);
            this.neutralLabel.Name = "neutralLabel";
            this.neutralLabel.Size = new System.Drawing.Size(327, 48);
            this.neutralLabel.TabIndex = 2;
            this.neutralLabel.Text = "Neutral ingrediens";
            // 
            // neautralIngrediensListBox
            // 
            this.neautralIngrediensListBox.BackColor = System.Drawing.Color.Khaki;
            this.neautralIngrediensListBox.Enabled = false;
            this.neautralIngrediensListBox.FormattingEnabled = true;
            this.neautralIngrediensListBox.ItemHeight = 32;
            this.neautralIngrediensListBox.Location = new System.Drawing.Point(6, 68);
            this.neautralIngrediensListBox.Name = "neautralIngrediensListBox";
            this.neautralIngrediensListBox.Size = new System.Drawing.Size(181, 356);
            this.neautralIngrediensListBox.Sorted = true;
            this.neautralIngrediensListBox.TabIndex = 3;
            // 
            // neutralGroupBox
            // 
            this.neutralGroupBox.Controls.Add(this.neautralIngrediensListBox);
            this.neutralGroupBox.Controls.Add(this.neutralLabel);
            this.neutralGroupBox.Location = new System.Drawing.Point(1042, 180);
            this.neutralGroupBox.Name = "neutralGroupBox";
            this.neutralGroupBox.Size = new System.Drawing.Size(198, 424);
            this.neutralGroupBox.TabIndex = 11;
            this.neutralGroupBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1440, 665);
            this.Controls.Add(this.productIngrediensGroupbox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.irritationGroupBox);
            this.Controls.Add(this.neutralGroupBox);
            this.Controls.Add(this.expirationDateListLabel);
            this.Controls.Add(this.productNameListLabel);
            this.Controls.Add(this.productTypeListLabel);
            this.Controls.Add(this.gentleGroupBox);
            this.Controls.Add(this.productListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.ingrediensGroupBox);
            this.Controls.Add(this.nameAndDateGroupBox);
            this.Controls.Add(this.productTypeGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("MingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Healthy Beauty By Ploypailin Junker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.productTypeGroupBox.ResumeLayout(false);
            this.productTypeGroupBox.PerformLayout();
            this.nameAndDateGroupBox.ResumeLayout(false);
            this.nameAndDateGroupBox.PerformLayout();
            this.ingrediensGroupBox.ResumeLayout(false);
            this.ingrediensGroupBox.PerformLayout();
            this.gentleGroupBox.ResumeLayout(false);
            this.gentleGroupBox.PerformLayout();
            this.irritationGroupBox.ResumeLayout(false);
            this.irritationGroupBox.PerformLayout();
            this.productIngrediensGroupbox.ResumeLayout(false);
            this.productIngrediensGroupbox.PerformLayout();
            this.neutralGroupBox.ResumeLayout(false);
            this.neutralGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDataFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox productTypeGroupBox;
        private System.Windows.Forms.Label productTypeLabel;
        private System.Windows.Forms.GroupBox nameAndDateGroupBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label expirationDateLabel;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.GroupBox ingrediensGroupBox;
        private System.Windows.Forms.Label ingrediensLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox productListBox;
        private System.Windows.Forms.GroupBox gentleGroupBox;
        private System.Windows.Forms.Label productTypeListLabel;
        private System.Windows.Forms.Label productNameListLabel;
        private System.Windows.Forms.Label expirationDateListLabel;
        private System.Windows.Forms.GroupBox irritationGroupBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ListBox gentleIngrediensListbox;
        private System.Windows.Forms.Label gentleLabel;
        private System.Windows.Forms.ListBox badIngrediensListbox;
        private System.Windows.Forms.Label irritationLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton makeupCheckBox;
        private System.Windows.Forms.RadioButton skincareCheckBox;
        private System.Windows.Forms.ListBox ingrediensListBox;
        private System.Windows.Forms.GroupBox productIngrediensGroupbox;
        private System.Windows.Forms.ListBox productIngrediensListbox;
        private System.Windows.Forms.Label productIngrediensLabel;
        private System.Windows.Forms.Label neutralLabel;
        private System.Windows.Forms.ListBox neautralIngrediensListBox;
        private System.Windows.Forms.GroupBox neutralGroupBox;
    }
}

