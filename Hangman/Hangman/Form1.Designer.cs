
namespace Hangman
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RNG = new System.Windows.Forms.Button();
            this.submitLetter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.letterInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imagebase = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.WordLength = new System.Windows.Forms.Label();
            this.Lives = new System.Windows.Forms.Label();
            this.images = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagebase)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // RNG
            // 
            this.RNG.Location = new System.Drawing.Point(78, 22);
            this.RNG.Name = "RNG";
            this.RNG.Size = new System.Drawing.Size(131, 40);
            this.RNG.TabIndex = 0;
            this.RNG.Text = "Generate New Word";
            this.RNG.UseVisualStyleBackColor = true;
            this.RNG.Click += new System.EventHandler(this.GenerateNewWord_Click);
            // 
            // submitLetter
            // 
            this.submitLetter.Location = new System.Drawing.Point(249, 22);
            this.submitLetter.Name = "submitLetter";
            this.submitLetter.Size = new System.Drawing.Size(130, 40);
            this.submitLetter.TabIndex = 1;
            this.submitLetter.Text = "Submit Letter";
            this.submitLetter.UseVisualStyleBackColor = true;
            this.submitLetter.Click += new System.EventHandler(this.SubmitLetterButton_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.letterInput);
            this.groupBox2.Controls.Add(this.submitLetter);
            this.groupBox2.Controls.Add(this.RNG);
            this.groupBox2.Location = new System.Drawing.Point(274, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 72);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // letterInput
            // 
            this.letterInput.Location = new System.Drawing.Point(215, 32);
            this.letterInput.MaxLength = 1;
            this.letterInput.Name = "letterInput";
            this.letterInput.Size = new System.Drawing.Size(28, 23);
            this.letterInput.TabIndex = 2;
            this.letterInput.TextChanged += new System.EventHandler(this.LetterInput_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imagebase);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // imagebase
            // 
            this.imagebase.BackColor = System.Drawing.SystemColors.Control;
            this.imagebase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagebase.Location = new System.Drawing.Point(3, 19);
            this.imagebase.Name = "imagebase";
            this.imagebase.Size = new System.Drawing.Size(250, 234);
            this.imagebase.TabIndex = 0;
            this.imagebase.TabStop = false;
            this.imagebase.Click += new System.EventHandler(this.imagebase_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.WordLength);
            this.groupBox3.Controls.Add(this.Lives);
            this.groupBox3.Location = new System.Drawing.Point(274, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(471, 187);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // WordLength
            // 
            this.WordLength.AutoSize = true;
            this.WordLength.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WordLength.Location = new System.Drawing.Point(16, 19);
            this.WordLength.Name = "WordLength";
            this.WordLength.Size = new System.Drawing.Size(82, 15);
            this.WordLength.TabIndex = 0;
            this.WordLength.Text = "Word Length: ";
            this.WordLength.Click += new System.EventHandler(this.WordLength_Click);
            // 
            // Lives
            // 
            this.Lives.AutoSize = true;
            this.Lives.BackColor = System.Drawing.SystemColors.Control;
            this.Lives.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lives.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Lives.Location = new System.Drawing.Point(16, 43);
            this.Lives.Name = "Lives";
            this.Lives.Size = new System.Drawing.Size(39, 15);
            this.Lives.TabIndex = 1;
            this.Lives.Text = "Lives: ";
            this.Lives.Click += new System.EventHandler(this.lives_Click);
            // 
            // images
            // 
            this.images.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("images.ImageStream")));
            this.images.TransparentColor = System.Drawing.SystemColors.Control;
            this.images.Images.SetKeyName(0, "(1)Stand.png");
            this.images.Images.SetKeyName(1, "(2)Head.png");
            this.images.Images.SetKeyName(2, "(3)Body.png");
            this.images.Images.SetKeyName(3, "(4)Leg(R).png");
            this.images.Images.SetKeyName(4, "(5)Leg(L).png");
            this.images.Images.SetKeyName(5, "(6)Arm(R).png");
            this.images.Images.SetKeyName(6, "(7)Arm(L).png");
            this.images.Images.SetKeyName(7, "(8)Eye(R).png");
            this.images.Images.SetKeyName(8, "(9)Eye(L).png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(750, 277);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagebase)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RNG;
        private System.Windows.Forms.Button submitLetter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox letterInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label WordLength;
        private System.Windows.Forms.Label Lives;
        public System.Windows.Forms.ImageList images;
        public System.Windows.Forms.PictureBox imagebase;
    }
}

