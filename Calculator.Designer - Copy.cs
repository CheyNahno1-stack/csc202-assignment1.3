namespace Calculator_2
{
    partial class Calculator
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
            bttnAdd = new Button();
            Input1 = new TextBox();
            Input2 = new TextBox();
            InputResult = new TextBox();
            bttnEquals = new Button();
            bttnSub = new Button();
            bttnMult = new Button();
            bttnDiv = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // bttnAdd
            // 
            bttnAdd.BackColor = SystemColors.GradientActiveCaption;
            bttnAdd.Font = new Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnAdd.Location = new Point(109, 203);
            bttnAdd.Name = "bttnAdd";
            bttnAdd.Size = new Size(42, 35);
            bttnAdd.TabIndex = 0;
            bttnAdd.Text = "+";
            bttnAdd.UseVisualStyleBackColor = false;
            bttnAdd.Click += bttnAdd_Click;
            // 
            // Input1
            // 
            Input1.Font = new Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input1.Location = new Point(277, 136);
            Input1.Name = "Input1";
            Input1.Size = new Size(88, 34);
            Input1.TabIndex = 1;
            // 
            // Input2
            // 
            Input2.Font = new Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Input2.Location = new Point(277, 178);
            Input2.Name = "Input2";
            Input2.Size = new Size(88, 34);
            Input2.TabIndex = 2;
            // 
            // InputResult
            // 
            InputResult.Font = new Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputResult.Location = new Point(277, 226);
            InputResult.Name = "InputResult";
            InputResult.Size = new Size(88, 34);
            InputResult.TabIndex = 3;
            // 
            // bttnEquals
            // 
            bttnEquals.BackColor = SystemColors.GradientActiveCaption;
            bttnEquals.Font = new Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnEquals.Location = new Point(155, 265);
            bttnEquals.Name = "bttnEquals";
            bttnEquals.Size = new Size(42, 35);
            bttnEquals.TabIndex = 4;
            bttnEquals.Text = "=";
            bttnEquals.UseVisualStyleBackColor = false;
            bttnEquals.Click += bttnEquals_Click;
            // 
            // bttnSub
            // 
            bttnSub.BackColor = SystemColors.GradientActiveCaption;
            bttnSub.Font = new Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnSub.Location = new Point(170, 203);
            bttnSub.Name = "bttnSub";
            bttnSub.Size = new Size(42, 35);
            bttnSub.TabIndex = 5;
            bttnSub.Text = "-";
            bttnSub.UseVisualStyleBackColor = false;
            bttnSub.Click += bttnSub_Click;
            // 
            // bttnMult
            // 
            bttnMult.BackColor = SystemColors.GradientActiveCaption;
            bttnMult.Font = new Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnMult.Location = new Point(109, 162);
            bttnMult.Name = "bttnMult";
            bttnMult.Size = new Size(42, 35);
            bttnMult.TabIndex = 6;
            bttnMult.Text = "*";
            bttnMult.UseVisualStyleBackColor = false;
            bttnMult.Click += bttnMult_Click;
            // 
            // bttnDiv
            // 
            bttnDiv.BackColor = SystemColors.GradientActiveCaption;
            bttnDiv.Font = new Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnDiv.Location = new Point(170, 162);
            bttnDiv.Name = "bttnDiv";
            bttnDiv.Size = new Size(42, 35);
            bttnDiv.TabIndex = 7;
            bttnDiv.Text = "/";
            bttnDiv.UseVisualStyleBackColor = false;
            bttnDiv.Click += bttnDiv_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 58);
            label1.Name = "label1";
            label1.Size = new Size(267, 41);
            label1.TabIndex = 8;
            label1.Text = "Calculator";
            label1.Click += label1_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 450);
            Controls.Add(label1);
            Controls.Add(bttnDiv);
            Controls.Add(bttnMult);
            Controls.Add(bttnSub);
            Controls.Add(bttnEquals);
            Controls.Add(InputResult);
            Controls.Add(Input2);
            Controls.Add(Input1);
            Controls.Add(bttnAdd);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bttnAdd;
        private TextBox Input1;
        private TextBox Input2;
        private TextBox InputResult;
        private Button bttnEquals;
        private Button bttnSub;
        private Button bttnMult;
        private Button bttnDiv;
        private Label label1;
    }
}
