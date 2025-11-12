namespace Networking_Labeling
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label7 = new System.Windows.Forms.Label();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.cBoxPrinter = new System.Windows.Forms.ComboBox();
            this.lblMachine = new System.Windows.Forms.Label();
            this.cBoxWorkOrder = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxPartNum = new System.Windows.Forms.ComboBox();
            this.lblOpcode = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReset = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gBoxValidation = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tLayoutMessage = new System.Windows.Forms.TableLayoutPanel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tBoxSerial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.gBoxGeneration = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cBoxQuantity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.gBoxValidation.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tLayoutMessage.SuspendLayout();
            this.gBoxGeneration.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1623, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 38);
            this.label7.TabIndex = 6;
            this.label7.Text = "1.0.0.0";
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 6000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1732, 160);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(475, 6);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(781, 147);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Net Labeling";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label8, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.cBoxPrinter, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblMachine, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cBoxWorkOrder, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cBoxPartNum, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblOpcode, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnChange, 4, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 160);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1732, 112);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(987, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 51);
            this.label8.TabIndex = 13;
            this.label8.Text = "Impresora:";
            // 
            // cBoxPrinter
            // 
            this.cBoxPrinter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cBoxPrinter.BackColor = System.Drawing.Color.White;
            this.cBoxPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPrinter.Enabled = false;
            this.cBoxPrinter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxPrinter.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.cBoxPrinter.FormattingEnabled = true;
            this.cBoxPrinter.Location = new System.Drawing.Point(991, 59);
            this.cBoxPrinter.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxPrinter.Name = "cBoxPrinter";
            this.cBoxPrinter.Size = new System.Drawing.Size(315, 42);
            this.cBoxPrinter.Sorted = true;
            this.cBoxPrinter.TabIndex = 12;
            this.cBoxPrinter.TabStop = false;
            this.cBoxPrinter.SelectedValueChanged += new System.EventHandler(this.cBoxPrinter_SelectedValueChanged);
            // 
            // lblMachine
            // 
            this.lblMachine.AutoSize = true;
            this.lblMachine.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.lblMachine.ForeColor = System.Drawing.Color.White;
            this.lblMachine.Location = new System.Drawing.Point(0, 51);
            this.lblMachine.Margin = new System.Windows.Forms.Padding(0);
            this.lblMachine.Name = "lblMachine";
            this.lblMachine.Size = new System.Drawing.Size(181, 36);
            this.lblMachine.TabIndex = 8;
            this.lblMachine.Text = "Machine Id";
            // 
            // cBoxWorkOrder
            // 
            this.cBoxWorkOrder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cBoxWorkOrder.BackColor = System.Drawing.Color.White;
            this.cBoxWorkOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxWorkOrder.Enabled = false;
            this.cBoxWorkOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxWorkOrder.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.cBoxWorkOrder.FormattingEnabled = true;
            this.cBoxWorkOrder.Location = new System.Drawing.Point(620, 59);
            this.cBoxWorkOrder.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxWorkOrder.Name = "cBoxWorkOrder";
            this.cBoxWorkOrder.Size = new System.Drawing.Size(363, 42);
            this.cBoxWorkOrder.Sorted = true;
            this.cBoxWorkOrder.TabIndex = 5;
            this.cBoxWorkOrder.TabStop = false;
            this.cBoxWorkOrder.SelectedValueChanged += new System.EventHandler(this.cBoxWorkOrder_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(245, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Número de Parte:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(616, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 51);
            this.label2.TabIndex = 5;
            this.label2.Text = "Work Order:";
            // 
            // cBoxPartNum
            // 
            this.cBoxPartNum.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cBoxPartNum.BackColor = System.Drawing.Color.White;
            this.cBoxPartNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxPartNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxPartNum.Font = new System.Drawing.Font("Century Gothic", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.cBoxPartNum.FormattingEnabled = true;
            this.cBoxPartNum.Location = new System.Drawing.Point(249, 59);
            this.cBoxPartNum.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxPartNum.Name = "cBoxPartNum";
            this.cBoxPartNum.Size = new System.Drawing.Size(363, 42);
            this.cBoxPartNum.Sorted = true;
            this.cBoxPartNum.TabIndex = 4;
            this.cBoxPartNum.SelectedValueChanged += new System.EventHandler(this.cBoxPartNum_SelectedValueChanged);
            // 
            // lblOpcode
            // 
            this.lblOpcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOpcode.AutoSize = true;
            this.lblOpcode.Font = new System.Drawing.Font("Ebrima", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.lblOpcode.ForeColor = System.Drawing.Color.White;
            this.lblOpcode.Location = new System.Drawing.Point(0, 5);
            this.lblOpcode.Margin = new System.Windows.Forms.Padding(0);
            this.lblOpcode.Name = "lblOpcode";
            this.lblOpcode.Size = new System.Drawing.Size(143, 46);
            this.lblOpcode.TabIndex = 7;
            this.lblOpcode.Text = "Opcode";
            // 
            // btnChange
            // 
            this.btnChange.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChange.BackColor = System.Drawing.Color.Crimson;
            this.btnChange.Enabled = false;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Ebrima", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.Location = new System.Drawing.Point(1314, 58);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(169, 46);
            this.btnChange.TabIndex = 6;
            this.btnChange.TabStop = false;
            this.btnChange.Text = "Cambiar";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 1120);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1732, 38);
            this.tableLayoutPanel9.TabIndex = 7;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.btnReset, 0, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(1677, 272);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(55, 848);
            this.tableLayoutPanel6.TabIndex = 13;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnReset.BackgroundImage = global::Networking_Labeling.Properties.Resources.icons8_actualizar_241;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.Enabled = false;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(4, 4);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(47, 43);
            this.btnReset.TabIndex = 14;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.EnabledChanged += new System.EventHandler(this.btnReset_EnabledChanged);
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.gBoxValidation, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.gBoxGeneration, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(55, 272);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1622, 848);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // gBoxValidation
            // 
            this.gBoxValidation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gBoxValidation.Controls.Add(this.tableLayoutPanel5);
            this.gBoxValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.gBoxValidation.ForeColor = System.Drawing.Color.White;
            this.gBoxValidation.Location = new System.Drawing.Point(177, 261);
            this.gBoxValidation.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxValidation.Name = "gBoxValidation";
            this.gBoxValidation.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxValidation.Size = new System.Drawing.Size(1268, 444);
            this.gBoxValidation.TabIndex = 11;
            this.gBoxValidation.TabStop = false;
            this.gBoxValidation.Text = "Validación de Seriales";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.tLayoutMessage, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.tBoxSerial, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.label5, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblQty, 2, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 42);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1260, 398);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tLayoutMessage
            // 
            this.tLayoutMessage.BackColor = System.Drawing.Color.White;
            this.tLayoutMessage.ColumnCount = 1;
            this.tableLayoutPanel5.SetColumnSpan(this.tLayoutMessage, 4);
            this.tLayoutMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLayoutMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tLayoutMessage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tLayoutMessage.Controls.Add(this.lblMessage, 0, 0);
            this.tLayoutMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLayoutMessage.Location = new System.Drawing.Point(0, 96);
            this.tLayoutMessage.Margin = new System.Windows.Forms.Padding(0);
            this.tLayoutMessage.Name = "tLayoutMessage";
            this.tLayoutMessage.RowCount = 1;
            this.tLayoutMessage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLayoutMessage.Size = new System.Drawing.Size(1260, 303);
            this.tLayoutMessage.TabIndex = 9;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(552, 126);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(155, 51);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Text = "Default";
            // 
            // tBoxSerial
            // 
            this.tBoxSerial.BackColor = System.Drawing.Color.White;
            this.tBoxSerial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tableLayoutPanel5.SetColumnSpan(this.tBoxSerial, 2);
            this.tBoxSerial.Enabled = false;
            this.tBoxSerial.Font = new System.Drawing.Font("Century Gothic", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.tBoxSerial.Location = new System.Drawing.Point(426, 56);
            this.tBoxSerial.Margin = new System.Windows.Forms.Padding(4);
            this.tBoxSerial.MaxLength = 50;
            this.tBoxSerial.Name = "tBoxSerial";
            this.tBoxSerial.Size = new System.Drawing.Size(407, 36);
            this.tBoxSerial.TabIndex = 10;
            this.tBoxSerial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBoxSerial_KeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Ebrima", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(422, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 40);
            this.label5.TabIndex = 11;
            this.label5.Text = "Serial:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 4.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.tableLayoutPanel5.SetRowSpan(this.label6, 2);
            this.label6.Size = new System.Drawing.Size(383, 50);
            this.label6.TabIndex = 12;
            this.label6.Text = "2) Escanee cada etiqueta impresa\r\npara dar el pase.";
            // 
            // lblQty
            // 
            this.lblQty.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblQty.AutoSize = true;
            this.lblQty.BackColor = System.Drawing.Color.Transparent;
            this.lblQty.Font = new System.Drawing.Font("Ebrima", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.lblQty.ForeColor = System.Drawing.Color.White;
            this.lblQty.Location = new System.Drawing.Point(777, 12);
            this.lblQty.Margin = new System.Windows.Forms.Padding(0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(60, 40);
            this.lblQty.TabIndex = 13;
            this.lblQty.Text = "0/0";
            // 
            // gBoxGeneration
            // 
            this.gBoxGeneration.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gBoxGeneration.Controls.Add(this.tableLayoutPanel4);
            this.gBoxGeneration.Font = new System.Drawing.Font("Ebrima", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.gBoxGeneration.ForeColor = System.Drawing.Color.White;
            this.gBoxGeneration.Location = new System.Drawing.Point(177, 29);
            this.gBoxGeneration.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxGeneration.Name = "gBoxGeneration";
            this.gBoxGeneration.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxGeneration.Size = new System.Drawing.Size(1268, 224);
            this.gBoxGeneration.TabIndex = 10;
            this.gBoxGeneration.TabStop = false;
            this.gBoxGeneration.Text = "Generación de Seriales";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.Controls.Add(this.cBoxQuantity, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.pBar, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.btnGenerate, 2, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 53);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1260, 167);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // cBoxQuantity
            // 
            this.cBoxQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cBoxQuantity.BackColor = System.Drawing.Color.White;
            this.cBoxQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxQuantity.Enabled = false;
            this.cBoxQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cBoxQuantity.Font = new System.Drawing.Font("Century Gothic", 5.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.cBoxQuantity.FormattingEnabled = true;
            this.cBoxQuantity.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "25"});
            this.cBoxQuantity.Location = new System.Drawing.Point(422, 57);
            this.cBoxQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxQuantity.Name = "cBoxQuantity";
            this.cBoxQuantity.Size = new System.Drawing.Size(149, 40);
            this.cBoxQuantity.TabIndex = 6;
            this.cBoxQuantity.TabStop = false;
            this.cBoxQuantity.SelectedValueChanged += new System.EventHandler(this.cBoxQuantity_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Ebrima", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(418, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 4.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Millimeter);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.tableLayoutPanel4.SetRowSpan(this.label4, 2);
            this.label4.Size = new System.Drawing.Size(377, 50);
            this.label4.TabIndex = 10;
            this.label4.Text = "1) Seleccione la cantidad del lote\r\ny presione el botón imprimir.";
            // 
            // pBar
            // 
            this.pBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.SetColumnSpan(this.pBar, 2);
            this.pBar.Location = new System.Drawing.Point(422, 127);
            this.pBar.Margin = new System.Windows.Forms.Padding(4);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(415, 14);
            this.pBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBar.TabIndex = 12;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGenerate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerate.Enabled = false;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Ebrima", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Millimeter);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(579, 56);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(259, 42);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.TabStop = false;
            this.btnGenerate.Text = "Imprimir";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(0, 272);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 4;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(55, 848);
            this.tableLayoutPanel10.TabIndex = 15;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1732, 1158);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel10);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.tableLayoutPanel9);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Networking Labeling";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.gBoxValidation.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tLayoutMessage.ResumeLayout(false);
            this.tLayoutMessage.PerformLayout();
            this.gBoxGeneration.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cBoxPrinter;
        private System.Windows.Forms.Label lblMachine;
        private System.Windows.Forms.ComboBox cBoxWorkOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxPartNum;
        private System.Windows.Forms.Label lblOpcode;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox gBoxValidation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tLayoutMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox tBoxSerial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.GroupBox gBoxGeneration;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ComboBox cBoxQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}