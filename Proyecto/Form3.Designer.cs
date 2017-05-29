namespace Proyecto
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.usertb = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.passtb = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.Bt_escuchar = new DevComponents.DotNetBar.ButtonX();
            this.bt_escuchar_contra = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(154, 228);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Usuario:";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(154, 265);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(84, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Contraseña:";
            // 
            // usertb
            // 
            // 
            // 
            // 
            this.usertb.Border.Class = "TextBoxBorder";
            this.usertb.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.usertb.Location = new System.Drawing.Point(236, 231);
            this.usertb.Name = "usertb";
            this.usertb.PreventEnterBeep = true;
            this.usertb.Size = new System.Drawing.Size(127, 20);
            this.usertb.TabIndex = 2;
            // 
            // passtb
            // 
            // 
            // 
            // 
            this.passtb.Border.Class = "TextBoxBorder";
            this.passtb.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.passtb.Location = new System.Drawing.Point(236, 267);
            this.passtb.Name = "passtb";
            this.passtb.PasswordChar = '*';
            this.passtb.PreventEnterBeep = true;
            this.passtb.Size = new System.Drawing.Size(127, 20);
            this.passtb.TabIndex = 3;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(265, 293);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 4;
            this.buttonX1.Text = "Ingresar";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerColorTint = System.Drawing.SystemColors.ControlDarkDark;
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // Bt_escuchar
            // 
            this.Bt_escuchar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Bt_escuchar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Bt_escuchar.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_escuchar.Location = new System.Drawing.Point(369, 228);
            this.Bt_escuchar.Name = "Bt_escuchar";
            this.Bt_escuchar.Size = new System.Drawing.Size(64, 23);
            this.Bt_escuchar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Bt_escuchar.TabIndex = 5;
            this.Bt_escuchar.Text = "Escuchar";
            this.Bt_escuchar.Click += new System.EventHandler(this.Bt_escuchar_Click);
            // 
            // bt_escuchar_contra
            // 
            this.bt_escuchar_contra.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bt_escuchar_contra.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bt_escuchar_contra.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_escuchar_contra.Location = new System.Drawing.Point(369, 267);
            this.bt_escuchar_contra.Name = "bt_escuchar_contra";
            this.bt_escuchar_contra.Size = new System.Drawing.Size(64, 23);
            this.bt_escuchar_contra.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bt_escuchar_contra.TabIndex = 6;
            this.bt_escuchar_contra.Text = "Escuchar";
            this.bt_escuchar_contra.Click += new System.EventHandler(this.bt_escuchar_contra_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(456, 333);
            this.Controls.Add(this.bt_escuchar_contra);
            this.Controls.Add(this.Bt_escuchar);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.passtb);
            this.Controls.Add(this.usertb);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(472, 372);
            this.MinimumSize = new System.Drawing.Size(472, 372);
            this.Name = "Form3";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX usertb;
        private DevComponents.DotNetBar.Controls.TextBoxX passtb;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonX Bt_escuchar;
        private DevComponents.DotNetBar.ButtonX bt_escuchar_contra;
    }
}