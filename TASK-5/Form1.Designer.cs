
namespace WindowsFormsApp2
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
      this.Строки = new System.Windows.Forms.ListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // Строки
      // 
      this.Строки.FormattingEnabled = true;
      this.Строки.ItemHeight = 16;
      this.Строки.Items.AddRange(new object[] {
            "Ты меня не любишь, не жалеешь, разве я немного не красив? Не смотря в лицо, от ст" +
                "расти млеешь, мне на плечи руки опустив.",
            "Молодая, с чувственным оскалом, я с тобой не нежен и не груб. Расскажи мне, сколь" +
                "ких ты ласкала? Сколько рук ты помнишь? Сколько губ?",
            "Знаю я — они прошли, как тени, не коснувшись твоего огня, многим ты садилась на к" +
                "олени, а теперь сидишь вот у меня."});
      this.Строки.Location = new System.Drawing.Point(53, 81);
      this.Строки.Name = "Строки";
      this.Строки.Size = new System.Drawing.Size(1012, 148);
      this.Строки.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(50, 364);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(179, 17);
      this.label1.TabIndex = 1;
      this.label1.Text = "Количество предложений";
      // 
      // button1
      // 
      this.button1.AutoEllipsis = true;
      this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.button1.Location = new System.Drawing.Point(278, 284);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(195, 53);
      this.button1.TabIndex = 2;
      this.button1.Text = "Посчитать количество предложений в строке";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(53, 287);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(176, 46);
      this.textBox1.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(50, 257);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(157, 17);
      this.label2.TabIndex = 4;
      this.label2.Text = "Введите номер строки";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1122, 450);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.Строки);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox Строки;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label2;
  }
}

