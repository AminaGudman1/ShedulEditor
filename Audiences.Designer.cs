
namespace SheduleEditor_Amina
{
    partial class Audiences
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridEditor = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AComputer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Board = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountOfSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountOfTables = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Projector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEditor
            // 
            this.dataGridEditor.AllowUserToAddRows = false;
            this.dataGridEditor.AllowUserToDeleteRows = false;
            this.dataGridEditor.AllowUserToResizeColumns = false;
            this.dataGridEditor.AllowUserToResizeRows = false;
            this.dataGridEditor.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEditor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridEditor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEditor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.AComputer,
            this.Board,
            this.CountOfSeats,
            this.CountOfTables,
            this.Projector});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridEditor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridEditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridEditor.Location = new System.Drawing.Point(0, 0);
            this.dataGridEditor.MultiSelect = false;
            this.dataGridEditor.Name = "dataGridEditor";
            this.dataGridEditor.ReadOnly = true;
            this.dataGridEditor.RowHeadersVisible = false;
            this.dataGridEditor.RowHeadersWidth = 52;
            this.dataGridEditor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridEditor.RowTemplate.Height = 24;
            this.dataGridEditor.ShowCellToolTips = false;
            this.dataGridEditor.Size = new System.Drawing.Size(1063, 519);
            this.dataGridEditor.TabIndex = 0;
            this.dataGridEditor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEditor_CellClick);
            // 
            // Number
            // 
            this.Number.HeaderText = "Номер кабинета";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 120;
            // 
            // AComputer
            // 
            this.AComputer.HeaderText = "Кол-во компьютер ов";
            this.AComputer.MinimumWidth = 6;
            this.AComputer.Name = "AComputer";
            this.AComputer.ReadOnly = true;
            this.AComputer.Width = 135;
            // 
            // Board
            // 
            this.Board.HeaderText = "Наличие доски";
            this.Board.MinimumWidth = 6;
            this.Board.Name = "Board";
            this.Board.ReadOnly = true;
            this.Board.Width = 130;
            // 
            // CountOfSeats
            // 
            this.CountOfSeats.HeaderText = "Кол-во посадочных мест";
            this.CountOfSeats.MinimumWidth = 6;
            this.CountOfSeats.Name = "CountOfSeats";
            this.CountOfSeats.ReadOnly = true;
            this.CountOfSeats.Width = 130;
            // 
            // CountOfTables
            // 
            this.CountOfTables.HeaderText = "Кол-во парт";
            this.CountOfTables.MinimumWidth = 6;
            this.CountOfTables.Name = "CountOfTables";
            this.CountOfTables.ReadOnly = true;
            this.CountOfTables.Width = 130;
            // 
            // Projector
            // 
            this.Projector.HeaderText = "Проектор";
            this.Projector.MinimumWidth = 6;
            this.Projector.Name = "Projector";
            this.Projector.ReadOnly = true;
            this.Projector.Width = 130;
            // 
            // Audiences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 504);
            this.Controls.Add(this.dataGridEditor);
            this.Name = "Audiences";
            this.Text = "Аудиторный фонд";
            this.Load += new System.EventHandler(this.Audiences_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn AComputer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Board;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountOfSeats;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountOfTables;
        private System.Windows.Forms.DataGridViewTextBoxColumn Projector;
    }
}