﻿namespace Diplom
{
    partial class FormManagerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManagerMenu));
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.tableLayoutPanelBottom = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRepSell = new System.Windows.Forms.Button();
            this.buttonRepFilm = new System.Windows.Forms.Button();
            this.buttonRepUser = new System.Windows.Forms.Button();
            this.buttonRepHall = new System.Windows.Forms.Button();
            this.tableLayoutPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.ColumnCount = 3;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanelTop.Controls.Add(this.pictureBoxLogo, 0, 0);
            this.tableLayoutPanelTop.Controls.Add(this.labelTitle, 1, 0);
            this.tableLayoutPanelTop.Controls.Add(this.buttonReturn, 2, 0);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 1;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(379, 43);
            this.tableLayoutPanelTop.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(45, 43);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(93, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(48, 0, 3, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(193, 43);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Отчеты";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonReturn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReturn.Location = new System.Drawing.Point(289, 0);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(0);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(90, 43);
            this.buttonReturn.TabIndex = 2;
            this.buttonReturn.Text = "Назад";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // tableLayoutPanelBottom
            // 
            this.tableLayoutPanelBottom.ColumnCount = 1;
            this.tableLayoutPanelBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelBottom.Location = new System.Drawing.Point(0, 487);
            this.tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            this.tableLayoutPanelBottom.RowCount = 1;
            this.tableLayoutPanelBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBottom.Size = new System.Drawing.Size(379, 27);
            this.tableLayoutPanelBottom.TabIndex = 1;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.buttonRepSell, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.buttonRepFilm, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonRepUser, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonRepHall, 0, 2);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 43);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(379, 444);
            this.tableLayoutPanelMain.TabIndex = 2;
            // 
            // buttonRepSell
            // 
            this.buttonRepSell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRepSell.Location = new System.Drawing.Point(30, 353);
            this.buttonRepSell.Margin = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.buttonRepSell.Name = "buttonRepSell";
            this.buttonRepSell.Size = new System.Drawing.Size(319, 71);
            this.buttonRepSell.TabIndex = 3;
            this.buttonRepSell.Tag = "Sell";
            this.buttonRepSell.Text = "Отчет по продажам";
            this.buttonRepSell.UseVisualStyleBackColor = true;
            this.buttonRepSell.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonRepFilm
            // 
            this.buttonRepFilm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRepFilm.Location = new System.Drawing.Point(30, 20);
            this.buttonRepFilm.Margin = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.buttonRepFilm.Name = "buttonRepFilm";
            this.buttonRepFilm.Size = new System.Drawing.Size(319, 71);
            this.buttonRepFilm.TabIndex = 0;
            this.buttonRepFilm.Tag = "Film";
            this.buttonRepFilm.Text = "Отчет по фильмам";
            this.buttonRepFilm.UseVisualStyleBackColor = true;
            this.buttonRepFilm.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonRepUser
            // 
            this.buttonRepUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRepUser.Location = new System.Drawing.Point(30, 131);
            this.buttonRepUser.Margin = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.buttonRepUser.Name = "buttonRepUser";
            this.buttonRepUser.Size = new System.Drawing.Size(319, 71);
            this.buttonRepUser.TabIndex = 1;
            this.buttonRepUser.Tag = "User";
            this.buttonRepUser.Text = "Отчет по сотрудникам";
            this.buttonRepUser.UseVisualStyleBackColor = true;
            this.buttonRepUser.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonRepHall
            // 
            this.buttonRepHall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRepHall.Location = new System.Drawing.Point(30, 242);
            this.buttonRepHall.Margin = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.buttonRepHall.Name = "buttonRepHall";
            this.buttonRepHall.Size = new System.Drawing.Size(319, 71);
            this.buttonRepHall.TabIndex = 2;
            this.buttonRepHall.Tag = "Hall";
            this.buttonRepHall.Text = "Отчет по залам";
            this.buttonRepHall.UseVisualStyleBackColor = true;
            this.buttonRepHall.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // FormManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 514);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.tableLayoutPanelBottom);
            this.Controls.Add(this.tableLayoutPanelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(395, 553);
            this.Name = "FormManagerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню менеджера";
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableLayoutPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBottom;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonRepFilm;
        private System.Windows.Forms.Button buttonRepUser;
        private System.Windows.Forms.Button buttonRepHall;
        private System.Windows.Forms.Button buttonRepSell;
    }
}

