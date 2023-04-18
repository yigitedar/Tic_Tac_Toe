namespace TicTacToeLast
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            gameToolStripMenuItem = new ToolStripMenuItem();
            newGameToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            ınfoToolStripMenuItem = new ToolStripMenuItem();
            whoStartsToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            A1 = new Button();
            A2 = new Button();
            A3 = new Button();
            B1 = new Button();
            B2 = new Button();
            B3 = new Button();
            C1 = new Button();
            C2 = new Button();
            C3 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gameToolStripMenuItem, ınfoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(408, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            gameToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newGameToolStripMenuItem, exitToolStripMenuItem });
            gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            gameToolStripMenuItem.Size = new Size(74, 29);
            gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            newGameToolStripMenuItem.Size = new Size(200, 34);
            newGameToolStripMenuItem.Text = "New Game";
            newGameToolStripMenuItem.Click += newGameToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(200, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // ınfoToolStripMenuItem
            // 
            ınfoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { whoStartsToolStripMenuItem, aboutToolStripMenuItem });
            ınfoToolStripMenuItem.Name = "ınfoToolStripMenuItem";
            ınfoToolStripMenuItem.Size = new Size(60, 29);
            ınfoToolStripMenuItem.Text = "Info";
            // 
            // whoStartsToolStripMenuItem
            // 
            whoStartsToolStripMenuItem.Name = "whoStartsToolStripMenuItem";
            whoStartsToolStripMenuItem.Size = new Size(209, 34);
            whoStartsToolStripMenuItem.Text = "Who Starts?";
            whoStartsToolStripMenuItem.Click += whoStartsToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(209, 34);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // A1
            // 
            A1.FlatAppearance.BorderColor = Color.Black;
            A1.FlatAppearance.BorderSize = 5;
            A1.FlatStyle = FlatStyle.Flat;
            A1.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Regular, GraphicsUnit.Point);
            A1.Location = new Point(78, 58);
            A1.Name = "A1";
            A1.Size = new Size(75, 75);
            A1.TabIndex = 1;
            A1.UseVisualStyleBackColor = true;
            A1.Click += button_click;
            // 
            // A2
            // 
            A2.FlatAppearance.BorderColor = Color.Black;
            A2.FlatAppearance.BorderSize = 5;
            A2.FlatStyle = FlatStyle.Flat;
            A2.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Regular, GraphicsUnit.Point);
            A2.Location = new Point(159, 58);
            A2.Name = "A2";
            A2.Size = new Size(75, 75);
            A2.TabIndex = 2;
            A2.UseVisualStyleBackColor = true;
            A2.Click += button_click;
            // 
            // A3
            // 
            A3.FlatAppearance.BorderColor = Color.Black;
            A3.FlatAppearance.BorderSize = 5;
            A3.FlatStyle = FlatStyle.Flat;
            A3.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Regular, GraphicsUnit.Point);
            A3.Location = new Point(240, 58);
            A3.Name = "A3";
            A3.Size = new Size(75, 75);
            A3.TabIndex = 3;
            A3.UseVisualStyleBackColor = true;
            A3.Click += button_click;
            // 
            // B1
            // 
            B1.FlatAppearance.BorderColor = Color.Black;
            B1.FlatAppearance.BorderSize = 5;
            B1.FlatStyle = FlatStyle.Flat;
            B1.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Regular, GraphicsUnit.Point);
            B1.Location = new Point(78, 139);
            B1.Name = "B1";
            B1.Size = new Size(75, 75);
            B1.TabIndex = 4;
            B1.UseVisualStyleBackColor = true;
            B1.Click += button_click;
            // 
            // B2
            // 
            B2.FlatAppearance.BorderColor = Color.Black;
            B2.FlatAppearance.BorderSize = 5;
            B2.FlatStyle = FlatStyle.Flat;
            B2.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Regular, GraphicsUnit.Point);
            B2.Location = new Point(159, 139);
            B2.Name = "B2";
            B2.Size = new Size(75, 75);
            B2.TabIndex = 5;
            B2.UseVisualStyleBackColor = true;
            B2.Click += button_click;
            // 
            // B3
            // 
            B3.FlatAppearance.BorderColor = Color.Black;
            B3.FlatAppearance.BorderSize = 5;
            B3.FlatStyle = FlatStyle.Flat;
            B3.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Regular, GraphicsUnit.Point);
            B3.Location = new Point(240, 139);
            B3.Name = "B3";
            B3.Size = new Size(75, 75);
            B3.TabIndex = 6;
            B3.UseVisualStyleBackColor = true;
            B3.Click += button_click;
            // 
            // C1
            // 
            C1.FlatAppearance.BorderColor = Color.Black;
            C1.FlatAppearance.BorderSize = 5;
            C1.FlatStyle = FlatStyle.Flat;
            C1.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Regular, GraphicsUnit.Point);
            C1.Location = new Point(78, 220);
            C1.Name = "C1";
            C1.Size = new Size(75, 75);
            C1.TabIndex = 7;
            C1.UseVisualStyleBackColor = true;
            C1.Click += button_click;
            // 
            // C2
            // 
            C2.FlatAppearance.BorderColor = Color.Black;
            C2.FlatAppearance.BorderSize = 5;
            C2.FlatStyle = FlatStyle.Flat;
            C2.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Regular, GraphicsUnit.Point);
            C2.Location = new Point(159, 220);
            C2.Name = "C2";
            C2.Size = new Size(75, 75);
            C2.TabIndex = 8;
            C2.UseVisualStyleBackColor = true;
            C2.Click += button_click;
            // 
            // C3
            // 
            C3.FlatAppearance.BorderColor = Color.Black;
            C3.FlatAppearance.BorderSize = 5;
            C3.FlatStyle = FlatStyle.Flat;
            C3.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Regular, GraphicsUnit.Point);
            C3.Location = new Point(240, 220);
            C3.Name = "C3";
            C3.Size = new Size(75, 75);
            C3.TabIndex = 9;
            C3.UseVisualStyleBackColor = true;
            C3.Click += button_click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOrange;
            ClientSize = new Size(408, 335);
            Controls.Add(C3);
            Controls.Add(C2);
            Controls.Add(C1);
            Controls.Add(B3);
            Controls.Add(B2);
            Controls.Add(B1);
            Controls.Add(A3);
            Controls.Add(A2);
            Controls.Add(A1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic Tac Toe";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gameToolStripMenuItem;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem ınfoToolStripMenuItem;
        private ToolStripMenuItem whoStartsToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button A1;
        private Button A2;
        private Button A3;
        private Button B1;
        private Button B2;
        private Button B3;
        private Button C1;
        private Button C2;
        private Button C3;
    }
}