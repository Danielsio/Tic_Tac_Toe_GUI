﻿namespace Tic_Tac_Toe_GUI
{
    partial class FormTicTacToeMisere
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelScorePlayer1 = new System.Windows.Forms.Label();
            this.labelScorePlayer2 = new System.Windows.Forms.Label();
            this.tableLayoutPanelGameBoard = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // labelScorePlayer1
            // 
            this.labelScorePlayer1.AutoSize = true;
            this.labelScorePlayer1.Location = new System.Drawing.Point(267, 406);
            this.labelScorePlayer1.Name = "labelScorePlayer1";
            this.labelScorePlayer1.Size = new System.Drawing.Size(82, 20);
            this.labelScorePlayer1.TabIndex = 0;
            this.labelScorePlayer1.Text = "Player 1: 0";
            // 
            // labelScorePlayer2
            // 
            this.labelScorePlayer2.AutoSize = true;
            this.labelScorePlayer2.Location = new System.Drawing.Point(481, 406);
            this.labelScorePlayer2.Name = "labelScorePlayer2";
            this.labelScorePlayer2.Size = new System.Drawing.Size(96, 20);
            this.labelScorePlayer2.TabIndex = 1;
            this.labelScorePlayer2.Text = "Computer: 0";
            // 
            // tableLayoutPanelGameBoard
            // 
            this.tableLayoutPanelGameBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelGameBoard.AutoSize = true;
            this.tableLayoutPanelGameBoard.ColumnCount = 2;
            this.tableLayoutPanelGameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGameBoard.Location = new System.Drawing.Point(301, 58);
            this.tableLayoutPanelGameBoard.Name = "tableLayoutPanelGameBoard";
            this.tableLayoutPanelGameBoard.RowCount = 2;
            this.tableLayoutPanelGameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGameBoard.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanelGameBoard.TabIndex = 2;
            // 
            // FormTicTacToeMisere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanelGameBoard);
            this.Controls.Add(this.labelScorePlayer2);
            this.Controls.Add(this.labelScorePlayer1);
            this.Name = "FormTicTacToeMisere";
            this.Text = "Tic Tac Toe Misere";
            this.Load += new System.EventHandler(this.FormTicTacToeMisere_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScorePlayer1;
        private System.Windows.Forms.Label labelScorePlayer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGameBoard;
    }
}