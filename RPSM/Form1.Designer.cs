namespace RPSM
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.InputData = new System.Windows.Forms.TabPage();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.Input_data = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.j = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tij = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculationParameters = new System.Windows.Forms.TabPage();
            this.CalculateGrid = new System.Windows.Forms.DataGridView();
            this.ResultNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result_i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result_j = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result_t_i_j = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result_i_j = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result_h_i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result_j_k = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result_ES_i_j = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result_EF_i_j = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result_LS_i_j = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result_LF_i_j = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result_R_i_j = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Graph = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.InputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Input_data)).BeginInit();
            this.CalculationParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CalculateGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.InputData);
            this.tabControl1.Controls.Add(this.CalculationParameters);
            this.tabControl1.Controls.Add(this.Graph);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(949, 559);
            this.tabControl1.TabIndex = 1;
            // 
            // InputData
            // 
            this.InputData.Controls.Add(this.CalculateButton);
            this.InputData.Controls.Add(this.Input_data);
            this.InputData.Location = new System.Drawing.Point(4, 22);
            this.InputData.Name = "InputData";
            this.InputData.Padding = new System.Windows.Forms.Padding(3);
            this.InputData.Size = new System.Drawing.Size(941, 533);
            this.InputData.TabIndex = 0;
            this.InputData.Text = "Ввід даних";
            this.InputData.UseVisualStyleBackColor = true;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(474, 17);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Input_data
            // 
            this.Input_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Input_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.i,
            this.j,
            this.tij});
            this.Input_data.Location = new System.Drawing.Point(3, 3);
            this.Input_data.Name = "Input_data";
            this.Input_data.Size = new System.Drawing.Size(938, 534);
            this.Input_data.TabIndex = 0;
            this.Input_data.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.Input_data_CellValidating);
            this.Input_data.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Input_data_RowsAdded);
            this.Input_data.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_data_KeyPress);
            // 
            // Number
            // 
            this.Number.HeaderText = "№";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // i
            // 
            this.i.HeaderText = "i";
            this.i.Name = "i";
            // 
            // j
            // 
            this.j.HeaderText = "j";
            this.j.Name = "j";
            // 
            // tij
            // 
            this.tij.HeaderText = "t(i-j)";
            this.tij.Name = "tij";
            // 
            // CalculationParameters
            // 
            this.CalculationParameters.Controls.Add(this.CalculateGrid);
            this.CalculationParameters.Location = new System.Drawing.Point(4, 22);
            this.CalculationParameters.Name = "CalculationParameters";
            this.CalculationParameters.Padding = new System.Windows.Forms.Padding(3);
            this.CalculationParameters.Size = new System.Drawing.Size(941, 533);
            this.CalculationParameters.TabIndex = 1;
            this.CalculationParameters.Text = "Розрахунок параметрів";
            this.CalculationParameters.UseVisualStyleBackColor = true;
            this.CalculationParameters.Click += new System.EventHandler(this.CalculationParameters_Click);
            // 
            // CalculateGrid
            // 
            this.CalculateGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CalculateGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResultNumber,
            this.result_i,
            this.result_j,
            this.result_t_i_j,
            this.result_i_j,
            this.result_h_i,
            this.result_j_k,
            this.result_ES_i_j,
            this.result_EF_i_j,
            this.result_LS_i_j,
            this.result_LF_i_j,
            this.result_R_i_j});
            this.CalculateGrid.Location = new System.Drawing.Point(3, 3);
            this.CalculateGrid.Name = "CalculateGrid";
            this.CalculateGrid.Size = new System.Drawing.Size(942, 530);
            this.CalculateGrid.TabIndex = 0;
            this.CalculateGrid.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // ResultNumber
            // 
            this.ResultNumber.HeaderText = "№";
            this.ResultNumber.Name = "ResultNumber";
            this.ResultNumber.ReadOnly = true;
            this.ResultNumber.Width = 20;
            // 
            // result_i
            // 
            this.result_i.HeaderText = "i";
            this.result_i.Name = "result_i";
            // 
            // result_j
            // 
            this.result_j.HeaderText = "j";
            this.result_j.Name = "result_j";
            // 
            // result_t_i_j
            // 
            this.result_t_i_j.HeaderText = "t(i-j)";
            this.result_t_i_j.Name = "result_t_i_j";
            // 
            // result_i_j
            // 
            this.result_i_j.HeaderText = "i-j";
            this.result_i_j.Name = "result_i_j";
            // 
            // result_h_i
            // 
            this.result_h_i.HeaderText = "h-i";
            this.result_h_i.Name = "result_h_i";
            // 
            // result_j_k
            // 
            this.result_j_k.HeaderText = "j-k";
            this.result_j_k.Name = "result_j_k";
            // 
            // result_ES_i_j
            // 
            this.result_ES_i_j.HeaderText = "ES(i-j)";
            this.result_ES_i_j.Name = "result_ES_i_j";
            // 
            // result_EF_i_j
            // 
            this.result_EF_i_j.HeaderText = "EF(i-j)";
            this.result_EF_i_j.Name = "result_EF_i_j";
            // 
            // result_LS_i_j
            // 
            this.result_LS_i_j.HeaderText = "LS(i-j)";
            this.result_LS_i_j.Name = "result_LS_i_j";
            // 
            // result_LF_i_j
            // 
            this.result_LF_i_j.HeaderText = "LF(i-j)";
            this.result_LF_i_j.Name = "result_LF_i_j";
            // 
            // result_R_i_j
            // 
            this.result_R_i_j.HeaderText = "R(i-j)";
            this.result_R_i_j.Name = "result_R_i_j";
            // 
            // Graph
            // 
            this.Graph.Location = new System.Drawing.Point(4, 22);
            this.Graph.Name = "Graph";
            this.Graph.Padding = new System.Windows.Forms.Padding(3);
            this.Graph.Size = new System.Drawing.Size(941, 533);
            this.Graph.TabIndex = 2;
            this.Graph.Text = "Граф";
            this.Graph.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 583);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.InputData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Input_data)).EndInit();
            this.CalculationParameters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CalculateGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage InputData;
        private System.Windows.Forms.TabPage CalculationParameters;
        private System.Windows.Forms.DataGridView Input_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn i;
        private System.Windows.Forms.DataGridViewTextBoxColumn j;
        private System.Windows.Forms.DataGridViewTextBoxColumn tij;
        private System.Windows.Forms.TabPage Graph;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.DataGridView CalculateGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn result_i;
        private System.Windows.Forms.DataGridViewTextBoxColumn result_j;
        private System.Windows.Forms.DataGridViewTextBoxColumn result_t_i_j;
        private System.Windows.Forms.DataGridViewTextBoxColumn result_i_j;
        private System.Windows.Forms.DataGridViewTextBoxColumn result_h_i;
        private System.Windows.Forms.DataGridViewTextBoxColumn result_j_k;
        private System.Windows.Forms.DataGridViewTextBoxColumn result_ES_i_j;
        private System.Windows.Forms.DataGridViewTextBoxColumn result_EF_i_j;
        private System.Windows.Forms.DataGridViewTextBoxColumn result_LS_i_j;
        private System.Windows.Forms.DataGridViewTextBoxColumn result_LF_i_j;
        private System.Windows.Forms.DataGridViewTextBoxColumn result_R_i_j;


    }
}

