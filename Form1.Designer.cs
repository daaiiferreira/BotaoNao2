namespace BotaoNao2
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
            btn_sim = new Button();
            btnNao = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_sim
            // 
            btn_sim.BackColor = Color.FromArgb(192, 255, 192);
            btn_sim.Cursor = Cursors.Hand;
            btn_sim.FlatStyle = FlatStyle.Popup;
            btn_sim.Font = new Font("Stencil", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_sim.ForeColor = Color.Green;
            btn_sim.Location = new Point(28, 218);
            btn_sim.Name = "btn_sim";
            btn_sim.Size = new Size(348, 178);
            btn_sim.TabIndex = 0;
            btn_sim.Text = "SIM";
            btn_sim.UseVisualStyleBackColor = false;
            btn_sim.Click += btn_sim_Click;
            // 
            // btnNao
            // 
            btnNao.BackColor = Color.FromArgb(255, 192, 192);
            btnNao.FlatStyle = FlatStyle.Popup;
            btnNao.Font = new Font("Stencil", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnNao.ForeColor = Color.FromArgb(192, 0, 0);
            btnNao.Location = new Point(403, 298);
            btnNao.Name = "btnNao";
            btnNao.Size = new Size(74, 36);
            btnNao.TabIndex = 5;
            btnNao.Text = "NAO";
            btnNao.UseVisualStyleBackColor = false;
            btnNao.MouseEnter += btnNao_MouseEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 116);
            label1.Name = "label1";
            label1.Size = new Size(180, 20);
            label1.TabIndex = 2;
            label1.Text = "Deseja mesmo continuar?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 450);
            Controls.Add(label1);
            Controls.Add(btnNao);
            Controls.Add(btn_sim);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_sim;
        private Label label1;
        private Button btnNao;
    }
}
