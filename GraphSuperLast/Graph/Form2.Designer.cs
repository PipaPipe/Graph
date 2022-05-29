
namespace Graph
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuWaysOfInput = new System.Windows.Forms.ToolStripMenuItem();
            this.matrixSmej = new System.Windows.Forms.ToolStripMenuItem();
            this.NotWeightGraph = new System.Windows.Forms.ToolStripMenuItem();
            this.WeightGraph = new System.Windows.Forms.ToolStripMenuItem();
            this.matrixInc = new System.Windows.Forms.ToolStripMenuItem();
            this.listSmej = new System.Windows.Forms.ToolStripMenuItem();
            this.listRebra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlgorithms = new System.Windows.Forms.ToolStripMenuItem();
            this.algGoWide = new System.Windows.Forms.ToolStripMenuItem();
            this.algGoDeep = new System.Windows.Forms.ToolStripMenuItem();
            this.algDijkstra = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.resultOfAlgButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.printGraph = new System.Windows.Forms.Button();
            this.algorithmInput = new System.Windows.Forms.TextBox();
            this.enterAlgorithm = new System.Windows.Forms.Label();
            this.enterInput = new System.Windows.Forms.Label();
            this.matrixInput = new System.Windows.Forms.TextBox();
            this.headerOfInput = new System.Windows.Forms.Label();
            this.chooseMethod = new System.Windows.Forms.Label();
            this.resultOfAlgorithm = new System.Windows.Forms.Label();
            this.logoAbout = new System.Windows.Forms.PictureBox();
            this.textAbout = new System.Windows.Forms.Label();
            this.pictureOfGraph = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoAbout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOfGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuWaysOfInput,
            this.menuAlgorithms,
            this.exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(958, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuWaysOfInput
            // 
            this.menuWaysOfInput.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matrixSmej,
            this.matrixInc,
            this.listSmej,
            this.listRebra});
            this.menuWaysOfInput.Name = "menuWaysOfInput";
            this.menuWaysOfInput.Size = new System.Drawing.Size(194, 25);
            this.menuWaysOfInput.Text = "Способы задания графа";
            // 
            // matrixSmej
            // 
            this.matrixSmej.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NotWeightGraph,
            this.WeightGraph});
            this.matrixSmej.Name = "matrixSmej";
            this.matrixSmej.Size = new System.Drawing.Size(249, 26);
            this.matrixSmej.Text = "Матрицей смежности";
            // 
            // NotWeightGraph
            // 
            this.NotWeightGraph.Name = "NotWeightGraph";
            this.NotWeightGraph.Size = new System.Drawing.Size(227, 26);
            this.NotWeightGraph.Text = "Невзвешенный граф";
            this.NotWeightGraph.Click += new System.EventHandler(this.NotWeightGraph_Click);
            // 
            // WeightGraph
            // 
            this.WeightGraph.Name = "WeightGraph";
            this.WeightGraph.Size = new System.Drawing.Size(227, 26);
            this.WeightGraph.Text = "Взвешенный граф";
            this.WeightGraph.Click += new System.EventHandler(this.WeightGraph_Click);
            // 
            // matrixInc
            // 
            this.matrixInc.Name = "matrixInc";
            this.matrixInc.Size = new System.Drawing.Size(249, 26);
            this.matrixInc.Text = "Матрицей инциденции";
            this.matrixInc.Click += new System.EventHandler(this.matrixInc_Click);
            // 
            // listSmej
            // 
            this.listSmej.Name = "listSmej";
            this.listSmej.Size = new System.Drawing.Size(249, 26);
            this.listSmej.Text = "Список смежности";
            this.listSmej.Click += new System.EventHandler(this.listSmej_Click);
            // 
            // listRebra
            // 
            this.listRebra.Name = "listRebra";
            this.listRebra.Size = new System.Drawing.Size(249, 26);
            this.listRebra.Text = "Список ребер";
            this.listRebra.Click += new System.EventHandler(this.listRebra_Click);
            // 
            // menuAlgorithms
            // 
            this.menuAlgorithms.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algGoWide,
            this.algGoDeep,
            this.algDijkstra});
            this.menuAlgorithms.Name = "menuAlgorithms";
            this.menuAlgorithms.Size = new System.Drawing.Size(102, 25);
            this.menuAlgorithms.Text = "Алгоритмы";
            this.menuAlgorithms.Click += new System.EventHandler(this.menuAlgorithms_Click);
            // 
            // algGoWide
            // 
            this.algGoWide.Enabled = false;
            this.algGoWide.Name = "algGoWide";
            this.algGoWide.Size = new System.Drawing.Size(397, 26);
            this.algGoWide.Text = "Обход графа в ширину";
            this.algGoWide.Click += new System.EventHandler(this.algGoWide_Click);
            // 
            // algGoDeep
            // 
            this.algGoDeep.Enabled = false;
            this.algGoDeep.Name = "algGoDeep";
            this.algGoDeep.Size = new System.Drawing.Size(397, 26);
            this.algGoDeep.Text = "Обход графа в глубину";
            this.algGoDeep.Click += new System.EventHandler(this.algGoDeep_Click);
            // 
            // algDijkstra
            // 
            this.algDijkstra.Enabled = false;
            this.algDijkstra.Name = "algDijkstra";
            this.algDijkstra.Size = new System.Drawing.Size(397, 26);
            this.algDijkstra.Text = "Поиск кратчайшего пути(взвешенный граф)";
            this.algDijkstra.Click += new System.EventHandler(this.algDijkstra_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(168, 25);
            this.exit.Text = "Завершение работы";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.resultOfAlgButton);
            this.panel.Controls.Add(this.clearButton);
            this.panel.Controls.Add(this.printGraph);
            this.panel.Controls.Add(this.algorithmInput);
            this.panel.Controls.Add(this.enterAlgorithm);
            this.panel.Controls.Add(this.enterInput);
            this.panel.Controls.Add(this.matrixInput);
            this.panel.Controls.Add(this.headerOfInput);
            this.panel.Controls.Add(this.chooseMethod);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 29);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(246, 628);
            this.panel.TabIndex = 1;
            // 
            // resultOfAlgButton
            // 
            this.resultOfAlgButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resultOfAlgButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultOfAlgButton.Location = new System.Drawing.Point(17, 420);
            this.resultOfAlgButton.Name = "resultOfAlgButton";
            this.resultOfAlgButton.Size = new System.Drawing.Size(211, 46);
            this.resultOfAlgButton.TabIndex = 8;
            this.resultOfAlgButton.Text = "Результат алгоритма";
            this.resultOfAlgButton.UseVisualStyleBackColor = true;
            this.resultOfAlgButton.Visible = false;
            this.resultOfAlgButton.Click += new System.EventHandler(this.resultOfAlgButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(17, 563);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(211, 46);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Visible = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // printGraph
            // 
            this.printGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printGraph.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printGraph.Location = new System.Drawing.Point(17, 508);
            this.printGraph.Name = "printGraph";
            this.printGraph.Size = new System.Drawing.Size(211, 46);
            this.printGraph.TabIndex = 6;
            this.printGraph.Text = "Построить граф";
            this.printGraph.UseVisualStyleBackColor = true;
            this.printGraph.Visible = false;
            this.printGraph.Click += new System.EventHandler(this.printGraph_Click);
            // 
            // algorithmInput
            // 
            this.algorithmInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.algorithmInput.Location = new System.Drawing.Point(17, 380);
            this.algorithmInput.Name = "algorithmInput";
            this.algorithmInput.Size = new System.Drawing.Size(211, 29);
            this.algorithmInput.TabIndex = 5;
            this.algorithmInput.Visible = false;
            // 
            // enterAlgorithm
            // 
            this.enterAlgorithm.AutoSize = true;
            this.enterAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterAlgorithm.Location = new System.Drawing.Point(13, 327);
            this.enterAlgorithm.Name = "enterAlgorithm";
            this.enterAlgorithm.Size = new System.Drawing.Size(162, 20);
            this.enterAlgorithm.TabIndex = 4;
            this.enterAlgorithm.Text = "Выберите алгоритм";
            this.enterAlgorithm.Visible = false;
            // 
            // enterInput
            // 
            this.enterInput.AutoSize = true;
            this.enterInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterInput.Location = new System.Drawing.Point(12, 59);
            this.enterInput.Name = "enterInput";
            this.enterInput.Size = new System.Drawing.Size(53, 20);
            this.enterInput.TabIndex = 3;
            this.enterInput.Text = "Ввод:";
            this.enterInput.Visible = false;
            // 
            // matrixInput
            // 
            this.matrixInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.matrixInput.Location = new System.Drawing.Point(17, 82);
            this.matrixInput.Multiline = true;
            this.matrixInput.Name = "matrixInput";
            this.matrixInput.Size = new System.Drawing.Size(150, 150);
            this.matrixInput.TabIndex = 2;
            this.matrixInput.Visible = false;
            // 
            // headerOfInput
            // 
            this.headerOfInput.AutoSize = true;
            this.headerOfInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.headerOfInput.Location = new System.Drawing.Point(12, 14);
            this.headerOfInput.Name = "headerOfInput";
            this.headerOfInput.Size = new System.Drawing.Size(178, 26);
            this.headerOfInput.TabIndex = 1;
            this.headerOfInput.Text = "Способ задания";
            this.headerOfInput.Visible = false;
            // 
            // chooseMethod
            // 
            this.chooseMethod.AutoSize = true;
            this.chooseMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseMethod.Location = new System.Drawing.Point(3, 226);
            this.chooseMethod.Name = "chooseMethod";
            this.chooseMethod.Size = new System.Drawing.Size(240, 62);
            this.chooseMethod.TabIndex = 0;
            this.chooseMethod.Text = "Выберите способ \r\nзадания графа";
            // 
            // resultOfAlgorithm
            // 
            this.resultOfAlgorithm.AutoSize = true;
            this.resultOfAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultOfAlgorithm.Location = new System.Drawing.Point(262, 592);
            this.resultOfAlgorithm.Name = "resultOfAlgorithm";
            this.resultOfAlgorithm.Size = new System.Drawing.Size(159, 26);
            this.resultOfAlgorithm.TabIndex = 8;
            this.resultOfAlgorithm.Text = "Обход графа: ";
            this.resultOfAlgorithm.Visible = false;
            // 
            // logoAbout
            // 
            this.logoAbout.Image = ((System.Drawing.Image)(resources.GetObject("logoAbout.Image")));
            this.logoAbout.Location = new System.Drawing.Point(372, 67);
            this.logoAbout.Name = "logoAbout";
            this.logoAbout.Size = new System.Drawing.Size(459, 455);
            this.logoAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoAbout.TabIndex = 9;
            this.logoAbout.TabStop = false;
            // 
            // textAbout
            // 
            this.textAbout.AutoSize = true;
            this.textAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(198)))), ((int)(((byte)(216)))));
            this.textAbout.Location = new System.Drawing.Point(356, 590);
            this.textAbout.Name = "textAbout";
            this.textAbout.Size = new System.Drawing.Size(489, 25);
            this.textAbout.TabIndex = 10;
            this.textAbout.Text = "Графоман - приложение для работы с графами";
            // 
            // pictureOfGraph
            // 
            this.pictureOfGraph.Location = new System.Drawing.Point(323, 67);
            this.pictureOfGraph.Name = "pictureOfGraph";
            this.pictureOfGraph.Size = new System.Drawing.Size(555, 495);
            this.pictureOfGraph.TabIndex = 11;
            this.pictureOfGraph.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(958, 657);
            this.Controls.Add(this.textAbout);
            this.Controls.Add(this.logoAbout);
            this.Controls.Add(this.resultOfAlgorithm);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureOfGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(974, 696);
            this.MinimumSize = new System.Drawing.Size(974, 696);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Графоман";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoAbout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOfGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuWaysOfInput;
        private System.Windows.Forms.ToolStripMenuItem matrixSmej;
        private System.Windows.Forms.ToolStripMenuItem matrixInc;
        private System.Windows.Forms.ToolStripMenuItem listSmej;
        private System.Windows.Forms.ToolStripMenuItem menuAlgorithms;
        private System.Windows.Forms.ToolStripMenuItem algGoWide;
        private System.Windows.Forms.ToolStripMenuItem algGoDeep;
        private System.Windows.Forms.ToolStripMenuItem algDijkstra;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label chooseMethod;
        private System.Windows.Forms.TextBox matrixInput;
        private System.Windows.Forms.Label headerOfInput;
        private System.Windows.Forms.Label enterInput;
        private System.Windows.Forms.TextBox algorithmInput;
        private System.Windows.Forms.Label enterAlgorithm;
        private System.Windows.Forms.Button printGraph;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label resultOfAlgorithm;
        private System.Windows.Forms.ToolStripMenuItem exit;
        private System.Windows.Forms.Button resultOfAlgButton;
        private System.Windows.Forms.PictureBox logoAbout;
        private System.Windows.Forms.Label textAbout;
        private System.Windows.Forms.ToolStripMenuItem listRebra;
        private System.Windows.Forms.PictureBox pictureOfGraph;
        private System.Windows.Forms.ToolStripMenuItem NotWeightGraph;
        private System.Windows.Forms.ToolStripMenuItem WeightGraph;
    }
}