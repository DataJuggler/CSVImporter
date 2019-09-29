namespace CSVImporter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Graph = new System.Windows.Forms.ProgressBar();
            this.ImportDataButton = new System.Windows.Forms.Button();
            this.CreateSQLColumnsButton = new System.Windows.Forms.Button();
            this.SourceFileControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.DoneButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Graph
            // 
            this.Graph.Location = new System.Drawing.Point(42, 151);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(690, 23);
            this.Graph.TabIndex = 3;
            this.Graph.Visible = false;
            // 
            // ImportDataButton
            // 
            this.ImportDataButton.BackgroundImage = global::CSVImporter.Properties.Resources.WoodButtonWidth1280Disabled;
            this.ImportDataButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImportDataButton.FlatAppearance.BorderSize = 0;
            this.ImportDataButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ImportDataButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ImportDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportDataButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportDataButton.Location = new System.Drawing.Point(258, 82);
            this.ImportDataButton.Name = "ImportDataButton";
            this.ImportDataButton.Size = new System.Drawing.Size(144, 40);
            this.ImportDataButton.TabIndex = 2;
            this.ImportDataButton.Text = "Import Data";
            this.ImportDataButton.UseVisualStyleBackColor = true;
            this.ImportDataButton.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.ImportDataButton.Click += new System.EventHandler(this.ImportDataButton_Click);
            this.ImportDataButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.ImportDataButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // CreateSQLColumnsButton
            // 
            this.CreateSQLColumnsButton.BackgroundImage = global::CSVImporter.Properties.Resources.WoodButtonWidth1280Disabled;
            this.CreateSQLColumnsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreateSQLColumnsButton.FlatAppearance.BorderSize = 0;
            this.CreateSQLColumnsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CreateSQLColumnsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CreateSQLColumnsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateSQLColumnsButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateSQLColumnsButton.Location = new System.Drawing.Point(42, 82);
            this.CreateSQLColumnsButton.Name = "CreateSQLColumnsButton";
            this.CreateSQLColumnsButton.Size = new System.Drawing.Size(210, 40);
            this.CreateSQLColumnsButton.TabIndex = 1;
            this.CreateSQLColumnsButton.Text = "Create SQL Columns";
            this.CreateSQLColumnsButton.UseVisualStyleBackColor = true;
            this.CreateSQLColumnsButton.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
            this.CreateSQLColumnsButton.Click += new System.EventHandler(this.CreateSQL_Click);
            this.CreateSQLColumnsButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.CreateSQLColumnsButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // SourceFileControl
            // 
            this.SourceFileControl.BackColor = System.Drawing.Color.Transparent;
            this.SourceFileControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            this.SourceFileControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("SourceFileControl.ButtonImage")));
            this.SourceFileControl.ButtonWidth = 48;
            this.SourceFileControl.DisabledLabelColor = System.Drawing.Color.LightGray;
            this.SourceFileControl.Editable = false;
            this.SourceFileControl.EnabledLabelColor = System.Drawing.Color.LemonChiffon;
            this.SourceFileControl.Filter = null;
            this.SourceFileControl.Font = new System.Drawing.Font("Verdana", 12F);
            this.SourceFileControl.HideBrowseButton = false;
            this.SourceFileControl.LabelBottomMargin = 0;
            this.SourceFileControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.SourceFileControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.SourceFileControl.LabelText = "Source File:";
            this.SourceFileControl.LabelTopMargin = 0;
            this.SourceFileControl.LabelWidth = 120;
            this.SourceFileControl.Location = new System.Drawing.Point(32, 34);
            this.SourceFileControl.Name = "SourceFileControl";
            this.SourceFileControl.OnTextChangedListener = null;
            this.SourceFileControl.OpenCallback = null;
            this.SourceFileControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SourceFileControl.SelectedPath = null;
            this.SourceFileControl.Size = new System.Drawing.Size(700, 32);
            this.SourceFileControl.StartPath = null;
            this.SourceFileControl.TabIndex = 0;
            this.SourceFileControl.TextBoxBottomMargin = 0;
            this.SourceFileControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.SourceFileControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.SourceFileControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F);
            this.SourceFileControl.TextBoxTopMargin = 0;
            this.SourceFileControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // DoneButton
            // 
            this.DoneButton.BackgroundImage = global::CSVImporter.Properties.Resources.WoodButtonWidth1280;
            this.DoneButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoneButton.FlatAppearance.BorderSize = 0;
            this.DoneButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.DoneButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.DoneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoneButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneButton.Location = new System.Drawing.Point(664, 216);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(100, 40);
            this.DoneButton.TabIndex = 4;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            this.DoneButton.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.DoneButton.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 270);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.ImportDataButton);
            this.Controls.Add(this.CreateSQLColumnsButton);
            this.Controls.Add(this.SourceFileControl);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSV Importer";
            this.ResumeLayout(false);

        }

        #endregion

        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl SourceFileControl;
        private System.Windows.Forms.Button CreateSQLColumnsButton;
        private System.Windows.Forms.Button ImportDataButton;
        private System.Windows.Forms.ProgressBar Graph;
        private System.Windows.Forms.Button DoneButton;
    }
}

