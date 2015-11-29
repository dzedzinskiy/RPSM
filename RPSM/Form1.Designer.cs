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
            this.CriticalLabel = new System.Windows.Forms.Label();
            this.Critical = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.Input_data = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.j = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tij = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CalculationParameters = new System.Windows.Forms.TabPage();
            this.CalculateGrid = new System.Windows.Forms.DataGridView();
            this.Graph = new System.Windows.Forms.TabPage();
            this.ResultGraph = new System.Windows.Forms.PictureBox();
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
            this.WorkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.InputData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Input_data)).BeginInit();
            this.CalculationParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CalculateGrid)).BeginInit();
            this.Graph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGraph)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(1379, 559);
            this.tabControl1.TabIndex = 1;
            // 
            // InputData
            // 
            this.InputData.Controls.Add(this.CriticalLabel);
            this.InputData.Controls.Add(this.Critical);
            this.InputData.Controls.Add(this.CalculateButton);
            this.InputData.Controls.Add(this.Input_data);
            this.InputData.Location = new System.Drawing.Point(4, 22);
            this.InputData.Name = "InputData";
            this.InputData.Padding = new System.Windows.Forms.Padding(3);
            this.InputData.Size = new System.Drawing.Size(1371, 533);
            this.InputData.TabIndex = 0;
            this.InputData.Text = "Ввід даних";
            this.InputData.UseVisualStyleBackColor = true;
            // 
            // CriticalLabel
            // 
            this.CriticalLabel.AutoSize = true;
            this.CriticalLabel.Location = new System.Drawing.Point(471, 56);
            this.CriticalLabel.Name = "CriticalLabel";
            this.CriticalLabel.Size = new System.Drawing.Size(91, 13);
            this.CriticalLabel.TabIndex = 3;
            this.CriticalLabel.Text = "Критичний шлях:";
            // 
            // Critical
            // 
            this.Critical.Location = new System.Drawing.Point(568, 53);
            this.Critical.Name = "Critical";
            this.Critical.Size = new System.Drawing.Size(228, 20);
            this.Critical.TabIndex = 2;
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
            this.Input_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Input_data.Location = new System.Drawing.Point(3, 3);
            this.Input_data.Name = "Input_data";
            this.Input_data.Size = new System.Drawing.Size(1365, 527);
            this.Input_data.TabIndex = 0;
            this.Input_data.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.Input_data_RowsAdded);
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
            this.CalculationParameters.Size = new System.Drawing.Size(1371, 533);
            this.CalculationParameters.TabIndex = 1;
            this.CalculationParameters.Text = "Розрахунок параметрів";
            this.CalculationParameters.UseVisualStyleBackColor = true;
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
            this.result_R_i_j,
            this.WorkName});
            this.CalculateGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CalculateGrid.Location = new System.Drawing.Point(3, 3);
            this.CalculateGrid.Name = "CalculateGrid";
            this.CalculateGrid.Size = new System.Drawing.Size(1365, 527);
            this.CalculateGrid.TabIndex = 0;
            // 
            // Graph
            // 
            this.Graph.Controls.Add(this.ResultGraph);
            this.Graph.Location = new System.Drawing.Point(4, 22);
            this.Graph.Name = "Graph";
            this.Graph.Padding = new System.Windows.Forms.Padding(3);
            this.Graph.Size = new System.Drawing.Size(1371, 533);
            this.Graph.TabIndex = 2;
            this.Graph.Text = "Граф";
            this.Graph.UseVisualStyleBackColor = true;
            // 
            // ResultGraph
            // 
            this.ResultGraph.Location = new System.Drawing.Point(0, 0);
            this.ResultGraph.Name = "ResultGraph";
            this.ResultGraph.Size = new System.Drawing.Size(1350, 860);
            this.ResultGraph.TabIndex = 0;
            this.ResultGraph.TabStop = false;
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
            // WorkName
            // 
            this.WorkName.HeaderText = "Назва Роботи";
            this.WorkName.Name = "WorkName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 583);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Обчислення параметрів сіткового графа";
            this.tabControl1.ResumeLayout(false);
            this.InputData.ResumeLayout(false);
            this.InputData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Input_data)).EndInit();
            this.CalculationParameters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CalculateGrid)).EndInit();
            this.Graph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultGraph)).EndInit();
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
        private System.Windows.Forms.Label CriticalLabel;
        private System.Windows.Forms.TextBox Critical;
        private System.Windows.Forms.PictureBox ResultGraph;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkName;


    }
}

