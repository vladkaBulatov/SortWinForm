namespace SortWinForm
{
    partial class SortWinForm
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
            this.displaySort = new System.Windows.Forms.TextBox();
            this.bubbleSort = new System.Windows.Forms.CheckBox();
            this.SortByChoice = new System.Windows.Forms.CheckBox();
            this.MergeSort = new System.Windows.Forms.CheckBox();
            this.introducedNumbers = new System.Windows.Forms.TextBox();
            this.labelFirst = new System.Windows.Forms.Label();
            this.InsertionSorting = new System.Windows.Forms.CheckBox();
            this.QuickSort = new System.Windows.Forms.CheckBox();
            this.buttonSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // displaySort
            // 
            this.displaySort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displaySort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.displaySort.Location = new System.Drawing.Point(12, 218);
            this.displaySort.Name = "displaySort";
            this.displaySort.Size = new System.Drawing.Size(726, 29);
            this.displaySort.TabIndex = 0;
            this.displaySort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bubbleSort
            // 
            this.bubbleSort.AutoSize = true;
            this.bubbleSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bubbleSort.Location = new System.Drawing.Point(12, 71);
            this.bubbleSort.Name = "bubbleSort";
            this.bubbleSort.Size = new System.Drawing.Size(240, 28);
            this.bubbleSort.TabIndex = 1;
            this.bubbleSort.Text = "Сортировка пузырьком";
            this.bubbleSort.UseVisualStyleBackColor = true;
            // 
            // SortByChoice
            // 
            this.SortByChoice.AutoSize = true;
            this.SortByChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortByChoice.Location = new System.Drawing.Point(12, 100);
            this.SortByChoice.Name = "SortByChoice";
            this.SortByChoice.Size = new System.Drawing.Size(223, 28);
            this.SortByChoice.TabIndex = 2;
            this.SortByChoice.Text = "Сортировка выбором";
            this.SortByChoice.UseVisualStyleBackColor = true;
            // 
            // MergeSort
            // 
            this.MergeSort.AutoSize = true;
            this.MergeSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MergeSort.Location = new System.Drawing.Point(270, 71);
            this.MergeSort.Name = "MergeSort";
            this.MergeSort.Size = new System.Drawing.Size(229, 28);
            this.MergeSort.TabIndex = 3;
            this.MergeSort.Text = "Сортировка слиянием";
            this.MergeSort.UseVisualStyleBackColor = true;
            // 
            // introducedNumbers
            // 
            this.introducedNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.introducedNumbers.Location = new System.Drawing.Point(12, 36);
            this.introducedNumbers.Name = "introducedNumbers";
            this.introducedNumbers.Size = new System.Drawing.Size(726, 29);
            this.introducedNumbers.TabIndex = 4;
            this.introducedNumbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelFirst
            // 
            this.labelFirst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFirst.AutoSize = true;
            this.labelFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirst.Location = new System.Drawing.Point(335, 9);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(60, 24);
            this.labelFirst.TabIndex = 5;
            this.labelFirst.Text = "00000";
            // 
            // InsertionSorting
            // 
            this.InsertionSorting.AutoSize = true;
            this.InsertionSorting.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertionSorting.Location = new System.Drawing.Point(270, 105);
            this.InsertionSorting.Name = "InsertionSorting";
            this.InsertionSorting.Size = new System.Drawing.Size(237, 28);
            this.InsertionSorting.TabIndex = 6;
            this.InsertionSorting.Text = "Сортировка вставками";
            this.InsertionSorting.UseVisualStyleBackColor = true;
            // 
            // QuickSort
            // 
            this.QuickSort.AutoSize = true;
            this.QuickSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuickSort.Location = new System.Drawing.Point(505, 71);
            this.QuickSort.Name = "QuickSort";
            this.QuickSort.Size = new System.Drawing.Size(216, 28);
            this.QuickSort.TabIndex = 7;
            this.QuickSort.Text = "Быстрая сортировка";
            this.QuickSort.UseVisualStyleBackColor = true;
            // 
            // buttonSort
            // 
            this.buttonSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSort.Location = new System.Drawing.Point(211, 150);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(288, 50);
            this.buttonSort.TabIndex = 8;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // SortWinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 273);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.QuickSort);
            this.Controls.Add(this.InsertionSorting);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.introducedNumbers);
            this.Controls.Add(this.MergeSort);
            this.Controls.Add(this.SortByChoice);
            this.Controls.Add(this.bubbleSort);
            this.Controls.Add(this.displaySort);
            this.Name = "SortWinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сортировки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displaySort;
        private System.Windows.Forms.CheckBox bubbleSort;
        private System.Windows.Forms.CheckBox SortByChoice;
        private System.Windows.Forms.CheckBox MergeSort;
        private System.Windows.Forms.TextBox introducedNumbers;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.CheckBox InsertionSorting;
        private System.Windows.Forms.CheckBox QuickSort;
        private System.Windows.Forms.Button buttonSort;
    }
}

