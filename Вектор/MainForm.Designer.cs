
namespace Вектор
{
    partial class Vectros
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
            this.VectorAX = new System.Windows.Forms.TextBox();
            this.VectorBX = new System.Windows.Forms.TextBox();
            this.VectorAZ = new System.Windows.Forms.TextBox();
            this.VectorAY = new System.Windows.Forms.TextBox();
            this.VectorBY = new System.Windows.Forms.TextBox();
            this.VectorBZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.operationChanger = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VectorAX
            // 
            this.VectorAX.Location = new System.Drawing.Point(15, 59);
            this.VectorAX.Name = "VectorAX";
            this.VectorAX.Size = new System.Drawing.Size(100, 20);
            this.VectorAX.TabIndex = 0;
            this.VectorAX.TextChanged += new System.EventHandler(this.VectorAX_TextChanged);
            // 
            // VectorBX
            // 
            this.VectorBX.Location = new System.Drawing.Point(212, 59);
            this.VectorBX.Name = "VectorBX";
            this.VectorBX.Size = new System.Drawing.Size(100, 20);
            this.VectorBX.TabIndex = 1;
            this.VectorBX.TextChanged += new System.EventHandler(this.VectorBX_TextChanged);
            // 
            // VectorAZ
            // 
            this.VectorAZ.Location = new System.Drawing.Point(15, 145);
            this.VectorAZ.Name = "VectorAZ";
            this.VectorAZ.Size = new System.Drawing.Size(100, 20);
            this.VectorAZ.TabIndex = 2;
            this.VectorAZ.TextChanged += new System.EventHandler(this.VectorAZ_TextChanged);
            // 
            // VectorAY
            // 
            this.VectorAY.Location = new System.Drawing.Point(15, 102);
            this.VectorAY.Name = "VectorAY";
            this.VectorAY.Size = new System.Drawing.Size(100, 20);
            this.VectorAY.TabIndex = 3;
            this.VectorAY.TextChanged += new System.EventHandler(this.VectorAY_TextChanged);
            // 
            // VectorBY
            // 
            this.VectorBY.Location = new System.Drawing.Point(212, 102);
            this.VectorBY.Name = "VectorBY";
            this.VectorBY.Size = new System.Drawing.Size(100, 20);
            this.VectorBY.TabIndex = 4;
            this.VectorBY.TextChanged += new System.EventHandler(this.VectorBY_TextChanged);
            // 
            // VectorBZ
            // 
            this.VectorBZ.Location = new System.Drawing.Point(212, 145);
            this.VectorBZ.Name = "VectorBZ";
            this.VectorBZ.Size = new System.Drawing.Size(100, 20);
            this.VectorBZ.TabIndex = 5;
            this.VectorBZ.TextChanged += new System.EventHandler(this.VectorBZ_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Вектор А";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(209, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Вектор В";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Введите координату х";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(209, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Введите координату х";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Введите координату y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(209, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Введите координату y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Введите координату z";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(208, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Введите координату z";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.Location = new System.Drawing.Point(12, 239);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(57, 20);
            this.result.TabIndex = 17;
            this.result.Text = "Ответ";
            // 
            // operationChanger
            // 
            this.operationChanger.FormattingEnabled = true;
            this.operationChanger.Items.AddRange(new object[] {
            "Сложение",
            "Вычитание",
            "Скалярное умножение",
            "Угол между",
            "Длина вектора А",
            "Длина вектора В"});
            this.operationChanger.Location = new System.Drawing.Point(15, 188);
            this.operationChanger.Name = "operationChanger";
            this.operationChanger.Size = new System.Drawing.Size(121, 21);
            this.operationChanger.TabIndex = 18;
            this.operationChanger.SelectedIndexChanged += new System.EventHandler(this.operationChanger_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Выберите операцию";
            // 
            // Vectros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.operationChanger);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VectorBZ);
            this.Controls.Add(this.VectorBY);
            this.Controls.Add(this.VectorAY);
            this.Controls.Add(this.VectorAZ);
            this.Controls.Add(this.VectorBX);
            this.Controls.Add(this.VectorAX);
            this.Name = "Vectros";
            this.Text = "Vectors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox VectorAX;
        private System.Windows.Forms.TextBox VectorBX;
        private System.Windows.Forms.TextBox VectorAZ;
        private System.Windows.Forms.TextBox VectorAY;
        private System.Windows.Forms.TextBox VectorBY;
        private System.Windows.Forms.TextBox VectorBZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.ComboBox operationChanger;
        private System.Windows.Forms.Label label9;
    }
}

