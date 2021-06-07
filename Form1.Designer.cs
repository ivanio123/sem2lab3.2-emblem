namespace sem2lab3_2
{
    partial class Form1
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
            this.Main = new System.Windows.Forms.Panel();
            this.Tools = new System.Windows.Forms.Panel();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btn2Left = new System.Windows.Forms.Button();
            this.btn2Right = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btn2Up = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btn2Down = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRotate = new System.Windows.Forms.Button();
            this.Tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.Color.White;
            this.Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(1135, 523);
            this.Main.TabIndex = 16;
            // 
            // Tools
            // 
            this.Tools.Controls.Add(this.buttonRotate);
            this.Tools.Controls.Add(this.btnLeft);
            this.Tools.Controls.Add(this.btn2Left);
            this.Tools.Controls.Add(this.btn2Right);
            this.Tools.Controls.Add(this.btnRight);
            this.Tools.Controls.Add(this.btn2Up);
            this.Tools.Controls.Add(this.btnUp);
            this.Tools.Controls.Add(this.btn2Down);
            this.Tools.Controls.Add(this.btnDown);
            this.Tools.Controls.Add(this.btnCollapse);
            this.Tools.Controls.Add(this.btnExp);
            this.Tools.Controls.Add(this.comboBox1);
            this.Tools.Controls.Add(this.btnShow);
            this.Tools.Controls.Add(this.btnHide);
            this.Tools.Controls.Add(this.btnCreate);
            this.Tools.Controls.Add(this.label1);
            this.Tools.Dock = System.Windows.Forms.DockStyle.Right;
            this.Tools.Location = new System.Drawing.Point(774, 0);
            this.Tools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tools.Name = "Tools";
            this.Tools.Size = new System.Drawing.Size(361, 523);
            this.Tools.TabIndex = 17;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(91, 331);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(33, 64);
            this.btnLeft.TabIndex = 14;
            this.btnLeft.Text = "←";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btn2Left
            // 
            this.btn2Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2Left.Location = new System.Drawing.Point(49, 331);
            this.btn2Left.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn2Left.Name = "btn2Left";
            this.btn2Left.Size = new System.Drawing.Size(33, 64);
            this.btn2Left.TabIndex = 13;
            this.btn2Left.Text = "↞";
            this.btn2Left.UseVisualStyleBackColor = true;
            this.btn2Left.Click += new System.EventHandler(this.btn2Left_Click);
            // 
            // btn2Right
            // 
            this.btn2Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2Right.Location = new System.Drawing.Point(281, 331);
            this.btn2Right.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn2Right.Name = "btn2Right";
            this.btn2Right.Size = new System.Drawing.Size(33, 64);
            this.btn2Right.TabIndex = 12;
            this.btn2Right.Text = "↠";
            this.btn2Right.UseVisualStyleBackColor = true;
            this.btn2Right.Click += new System.EventHandler(this.btn2Right_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(240, 331);
            this.btnRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(33, 64);
            this.btnRight.TabIndex = 11;
            this.btnRight.Text = "→";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btn2Up
            // 
            this.btn2Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2Up.Location = new System.Drawing.Point(132, 244);
            this.btn2Up.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn2Up.Name = "btn2Up";
            this.btn2Up.Size = new System.Drawing.Size(100, 44);
            this.btn2Up.TabIndex = 10;
            this.btn2Up.Text = "↟";
            this.btn2Up.UseVisualStyleBackColor = true;
            this.btn2Up.Click += new System.EventHandler(this.btn2Up_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(132, 295);
            this.btnUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(100, 28);
            this.btnUp.TabIndex = 9;
            this.btnUp.Text = "↑";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btn2Down
            // 
            this.btn2Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn2Down.Location = new System.Drawing.Point(132, 438);
            this.btn2Down.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn2Down.Name = "btn2Down";
            this.btn2Down.Size = new System.Drawing.Size(100, 43);
            this.btn2Down.TabIndex = 8;
            this.btn2Down.Text = "↡";
            this.btn2Down.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn2Down.UseVisualStyleBackColor = true;
            this.btn2Down.Click += new System.EventHandler(this.btn2Down_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(132, 402);
            this.btnDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(100, 28);
            this.btnDown.TabIndex = 7;
            this.btnDown.Text = "↓";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.Location = new System.Drawing.Point(132, 367);
            this.btnCollapse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(100, 28);
            this.btnCollapse.TabIndex = 6;
            this.btnCollapse.Text = "-";
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnExp
            // 
            this.btnExp.Location = new System.Drawing.Point(132, 331);
            this.btnExp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(100, 28);
            this.btnExp.TabIndex = 5;
            this.btnExp.Text = "+";
            this.btnExp.UseVisualStyleBackColor = true;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(33, 55);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(33, 181);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(301, 28);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show object";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(33, 145);
            this.btnHide.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(301, 28);
            this.btnHide.TabIndex = 2;
            this.btnHide.Text = "Hide object";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(33, 110);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(301, 28);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create a new object";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Object list";
            // 
            // buttonRotate
            // 
            this.buttonRotate.Location = new System.Drawing.Point(279, 272);
            this.buttonRotate.Name = "buttonRotate";
            this.buttonRotate.Size = new System.Drawing.Size(34, 50);
            this.buttonRotate.TabIndex = 15;
            this.buttonRotate.Text = "button1";
            this.buttonRotate.UseVisualStyleBackColor = true;
            this.buttonRotate.Click += new System.EventHandler(this.buttonRotate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 523);
            this.Controls.Add(this.Tools);
            this.Controls.Add(this.Main);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Tools.ResumeLayout(false);
            this.Tools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Panel Tools;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btn2Left;
        private System.Windows.Forms.Button btn2Right;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btn2Up;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btn2Down;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRotate;
    }
}

