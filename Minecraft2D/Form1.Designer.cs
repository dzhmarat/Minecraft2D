namespace Minecraft2D
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
            Create = new Button();
            CreateMenu = new Panel();
            TrueCreate = new Button();
            LableY = new Label();
            LabelX = new Label();
            TextY = new TextBox();
            TextX = new TextBox();
            LabelLocation = new Label();
            TextHeight = new TextBox();
            LabelHeight = new Label();
            LabelLength = new Label();
            TypeWater = new RadioButton();
            TypeGrass = new RadioButton();
            LabelType = new Label();
            TextLength = new TextBox();
            CreateMenu.SuspendLayout();
            SuspendLayout();
            // 
            // Create
            // 
            Create.BackColor = SystemColors.ButtonShadow;
            Create.Location = new Point(1119, 501);
            Create.Name = "Create";
            Create.Size = new Size(131, 41);
            Create.TabIndex = 0;
            Create.Text = "Create";
            Create.UseVisualStyleBackColor = false;
            Create.Click += Create_Click;
            // 
            // CreateMenu
            // 
            CreateMenu.BackColor = SystemColors.ControlLight;
            CreateMenu.Controls.Add(TrueCreate);
            CreateMenu.Controls.Add(LableY);
            CreateMenu.Controls.Add(LabelX);
            CreateMenu.Controls.Add(TextY);
            CreateMenu.Controls.Add(TextX);
            CreateMenu.Controls.Add(LabelLocation);
            CreateMenu.Controls.Add(TextHeight);
            CreateMenu.Controls.Add(LabelHeight);
            CreateMenu.Controls.Add(LabelLength);
            CreateMenu.Controls.Add(TypeWater);
            CreateMenu.Controls.Add(TypeGrass);
            CreateMenu.Controls.Add(LabelType);
            CreateMenu.Controls.Add(TextLength);
            CreateMenu.Location = new Point(1000, 35);
            CreateMenu.Name = "CreateMenu";
            CreateMenu.Size = new Size(250, 403);
            CreateMenu.TabIndex = 1;
            CreateMenu.Visible = false;
            // 
            // TrueCreate
            // 
            TrueCreate.BackColor = SystemColors.ButtonShadow;
            TrueCreate.Location = new Point(27, 345);
            TrueCreate.Name = "TrueCreate";
            TrueCreate.Size = new Size(131, 41);
            TrueCreate.TabIndex = 2;
            TrueCreate.Text = "Create";
            TrueCreate.UseVisualStyleBackColor = false;
            TrueCreate.Click += TrueCreate_Click;
            // 
            // LableY
            // 
            LableY.AutoSize = true;
            LableY.BackColor = SystemColors.ControlLight;
            LableY.Location = new Point(95, 263);
            LableY.Name = "LableY";
            LableY.Size = new Size(17, 20);
            LableY.TabIndex = 11;
            LableY.Text = "Y";
            // 
            // LabelX
            // 
            LabelX.AutoSize = true;
            LabelX.BackColor = SystemColors.ControlLight;
            LabelX.Location = new Point(36, 263);
            LabelX.Name = "LabelX";
            LabelX.Size = new Size(18, 20);
            LabelX.TabIndex = 10;
            LabelX.Text = "X";
            // 
            // TextY
            // 
            TextY.Location = new Point(90, 286);
            TextY.Name = "TextY";
            TextY.Size = new Size(36, 27);
            TextY.TabIndex = 9;
            // 
            // TextX
            // 
            TextX.Location = new Point(27, 286);
            TextX.Name = "TextX";
            TextX.Size = new Size(36, 27);
            TextX.TabIndex = 8;
            // 
            // LabelLocation
            // 
            LabelLocation.AutoSize = true;
            LabelLocation.BackColor = SystemColors.ControlLight;
            LabelLocation.Location = new Point(27, 234);
            LabelLocation.Name = "LabelLocation";
            LabelLocation.Size = new Size(86, 20);
            LabelLocation.TabIndex = 7;
            LabelLocation.Text = "Coordinate:";
            // 
            // TextHeight
            // 
            TextHeight.Location = new Point(90, 162);
            TextHeight.Name = "TextHeight";
            TextHeight.Size = new Size(91, 27);
            TextHeight.TabIndex = 6;
            // 
            // LabelHeight
            // 
            LabelHeight.AutoSize = true;
            LabelHeight.BackColor = SystemColors.ControlLight;
            LabelHeight.Location = new Point(27, 162);
            LabelHeight.Name = "LabelHeight";
            LabelHeight.Size = new Size(57, 20);
            LabelHeight.TabIndex = 5;
            LabelHeight.Text = "Height:";
            // 
            // LabelLength
            // 
            LabelLength.AutoSize = true;
            LabelLength.BackColor = SystemColors.ControlLight;
            LabelLength.Location = new Point(27, 116);
            LabelLength.Name = "LabelLength";
            LabelLength.Size = new Size(57, 20);
            LabelLength.TabIndex = 4;
            LabelLength.Text = "Length:";
            // 
            // TypeWater
            // 
            TypeWater.AutoSize = true;
            TypeWater.Checked = true;
            TypeWater.Location = new Point(27, 71);
            TypeWater.Name = "TypeWater";
            TypeWater.Size = new Size(69, 24);
            TypeWater.TabIndex = 3;
            TypeWater.TabStop = true;
            TypeWater.Text = "Water";
            TypeWater.UseVisualStyleBackColor = true;
            // 
            // TypeGrass
            // 
            TypeGrass.AutoSize = true;
            TypeGrass.Location = new Point(27, 41);
            TypeGrass.Name = "TypeGrass";
            TypeGrass.Size = new Size(65, 24);
            TypeGrass.TabIndex = 2;
            TypeGrass.Text = "Grass";
            TypeGrass.UseVisualStyleBackColor = true;
            // 
            // LabelType
            // 
            LabelType.AutoSize = true;
            LabelType.BackColor = SystemColors.ControlLight;
            LabelType.Location = new Point(27, 18);
            LabelType.Name = "LabelType";
            LabelType.Size = new Size(43, 20);
            LabelType.TabIndex = 1;
            LabelType.Text = "Type:";
            // 
            // TextLength
            // 
            TextLength.Location = new Point(90, 113);
            TextLength.Name = "TextLength";
            TextLength.Size = new Size(91, 27);
            TextLength.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 573);
            Controls.Add(CreateMenu);
            Controls.Add(Create);
            DoubleBuffered = true;
            MaximumSize = new Size(1280, 620);
            MinimumSize = new Size(1280, 620);
            Name = "Form1";
            Text = "Form1";
            CreateMenu.ResumeLayout(false);
            CreateMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Create;
        private Panel CreateMenu;
        private TextBox TextLength;
        private RadioButton TypeGrass;
        private Label LabelType;
        private RadioButton TypeWater;
        private Label LabelLength;
        private TextBox TextX;
        private Label LabelLocation;
        private TextBox TextHeight;
        private Label LabelHeight;
        private Label LableY;
        private Label LabelX;
        private TextBox TextY;
        private Button TrueCreate;
    }
}
