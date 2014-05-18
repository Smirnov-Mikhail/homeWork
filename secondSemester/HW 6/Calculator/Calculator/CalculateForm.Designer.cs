namespace CalculatorNamespace
{
    using System.Drawing;

    partial class CalculateForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.addition = new System.Windows.Forms.Button();
            this.subtraction = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.number1 = new System.Windows.Forms.Button();
            this.number2 = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.number3 = new System.Windows.Forms.Button();
            this.number4 = new System.Windows.Forms.Button();
            this.number5 = new System.Windows.Forms.Button();
            this.number6 = new System.Windows.Forms.Button();
            this.number7 = new System.Windows.Forms.Button();
            this.number8 = new System.Windows.Forms.Button();
            this.number9 = new System.Windows.Forms.Button();
            this.number0 = new System.Windows.Forms.Button();
            this.point = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.multiplication = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial", 15F);
            this.label.Location = new System.Drawing.Point(15, 17);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 23);
            this.label.TabIndex = 0;
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(3, 3);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(65, 44);
            this.addition.TabIndex = 1;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.OperatorClick);
            // 
            // subtraction
            // 
            this.subtraction.Location = new System.Drawing.Point(74, 3);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(65, 44);
            this.subtraction.TabIndex = 2;
            this.subtraction.Text = "-";
            this.subtraction.UseVisualStyleBackColor = true;
            this.subtraction.Click += new System.EventHandler(this.OperatorClick);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(231, 17);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(67, 40);
            this.delete.TabIndex = 3;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // number1
            // 
            this.number1.Location = new System.Drawing.Point(3, 3);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(77, 27);
            this.number1.TabIndex = 4;
            this.number1.Text = "1";
            this.number1.UseVisualStyleBackColor = true;
            this.number1.Click += new System.EventHandler(this.numberClick);
            // 
            // number2
            // 
            this.number2.Location = new System.Drawing.Point(86, 3);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(77, 27);
            this.number2.TabIndex = 5;
            this.number2.Text = "2";
            this.number2.UseVisualStyleBackColor = true;
            this.number2.Click += new System.EventHandler(this.numberClick);
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(169, 114);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(78, 33);
            this.equal.TabIndex = 6;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equalClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.number1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.number2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.equal, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.number3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.number4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.number5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.number6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.number7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.number8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.number9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.number0, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.point, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 116);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 150);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // number3
            // 
            this.number3.Location = new System.Drawing.Point(169, 3);
            this.number3.Name = "number3";
            this.number3.Size = new System.Drawing.Size(78, 27);
            this.number3.TabIndex = 6;
            this.number3.Text = "3";
            this.number3.UseVisualStyleBackColor = true;
            this.number3.Click += new System.EventHandler(this.numberClick);
            // 
            // number4
            // 
            this.number4.Location = new System.Drawing.Point(3, 40);
            this.number4.Name = "number4";
            this.number4.Size = new System.Drawing.Size(77, 27);
            this.number4.TabIndex = 7;
            this.number4.Text = "4";
            this.number4.UseVisualStyleBackColor = true;
            this.number4.Click += new System.EventHandler(this.numberClick);
            // 
            // number5
            // 
            this.number5.Location = new System.Drawing.Point(86, 40);
            this.number5.Name = "number5";
            this.number5.Size = new System.Drawing.Size(77, 27);
            this.number5.TabIndex = 8;
            this.number5.Text = "5";
            this.number5.UseVisualStyleBackColor = true;
            this.number5.Click += new System.EventHandler(this.numberClick);
            // 
            // number6
            // 
            this.number6.Location = new System.Drawing.Point(169, 40);
            this.number6.Name = "number6";
            this.number6.Size = new System.Drawing.Size(78, 27);
            this.number6.TabIndex = 9;
            this.number6.Text = "6";
            this.number6.UseVisualStyleBackColor = true;
            this.number6.Click += new System.EventHandler(this.numberClick);
            // 
            // number7
            // 
            this.number7.Location = new System.Drawing.Point(3, 77);
            this.number7.Name = "number7";
            this.number7.Size = new System.Drawing.Size(77, 27);
            this.number7.TabIndex = 10;
            this.number7.Text = "7";
            this.number7.UseVisualStyleBackColor = true;
            this.number7.Click += new System.EventHandler(this.numberClick);
            // 
            // number8
            // 
            this.number8.Location = new System.Drawing.Point(86, 77);
            this.number8.Name = "number8";
            this.number8.Size = new System.Drawing.Size(77, 27);
            this.number8.TabIndex = 11;
            this.number8.Text = "8";
            this.number8.UseVisualStyleBackColor = true;
            this.number8.Click += new System.EventHandler(this.numberClick);
            // 
            // number9
            // 
            this.number9.Location = new System.Drawing.Point(169, 77);
            this.number9.Name = "number9";
            this.number9.Size = new System.Drawing.Size(78, 27);
            this.number9.TabIndex = 12;
            this.number9.Text = "9";
            this.number9.UseVisualStyleBackColor = true;
            this.number9.Click += new System.EventHandler(this.numberClick);
            // 
            // number0
            // 
            this.number0.Location = new System.Drawing.Point(3, 114);
            this.number0.Name = "number0";
            this.number0.Size = new System.Drawing.Size(77, 33);
            this.number0.TabIndex = 13;
            this.number0.Text = "0";
            this.number0.UseVisualStyleBackColor = true;
            this.number0.Click += new System.EventHandler(this.numberClick);
            // 
            // point
            // 
            this.point.Location = new System.Drawing.Point(86, 114);
            this.point.Name = "point";
            this.point.Size = new System.Drawing.Size(77, 33);
            this.point.TabIndex = 14;
            this.point.Text = ".";
            this.point.UseVisualStyleBackColor = true;
            this.point.Click += new System.EventHandler(this.pointClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.addition, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.subtraction, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.multiplication, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.division, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 63);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(286, 50);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // multiplication
            // 
            this.multiplication.Location = new System.Drawing.Point(145, 3);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(65, 44);
            this.multiplication.TabIndex = 3;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.OperatorClick);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(216, 3);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(67, 44);
            this.division.TabIndex = 4;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.OperatorClick);
            // 
            // CalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 291);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label);
            this.MaximumSize = new System.Drawing.Size(330, 330);
            this.MinimumSize = new System.Drawing.Size(330, 330);
            this.Name = "CalculateForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button subtraction;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button number0;
        private System.Windows.Forms.Button number1;
        private System.Windows.Forms.Button number2;
        private System.Windows.Forms.Button number3;
        private System.Windows.Forms.Button number4;
        private System.Windows.Forms.Button number5;
        private System.Windows.Forms.Button number6;
        private System.Windows.Forms.Button number7;
        private System.Windows.Forms.Button number8;
        private System.Windows.Forms.Button number9;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button point;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;             
    }
}