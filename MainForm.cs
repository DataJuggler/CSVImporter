

#region using statements

using System;
using DataJuggler.Win.Controls;
using DataJuggler.Core.UltimateHelper;
using DataJuggler.Core.UltimateHelper.Objects;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text;
using DataJuggler.Win.Controls.Interfaces;
using DataJuggler.Net;
using CSVImportManager;
using CSVImportManager.Delegates;

#endregion

namespace CSVImporter
{

    #region class MainForm
    /// <summary>
    /// This is the main form for this app.
    /// </summary>
    public partial class MainForm : Form, ITextChanged
    {
        
        #region Private Variables
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'Form1' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion
        
        #region Events
            
            #region CreateSQL_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'ImportButton' is clicked.
            /// </summary>
            private void CreateSQL_Click(object sender, EventArgs e)
            {
                // set the fileName                
                string fileName = SourceFileControl.Text;

                // locals
                TextLine firstRowContent = null;
                List<Word> words = null;
                char[] delimiters = { ',' };
                StringBuilder sb = new StringBuilder();
                string alterTableTemplate = "Alter Table RawImport";
                string alterTableTemplate2 = "Add [ColumnName] nvarchar(255) null";
                string alterTable = "";

                // if the fileName exists
                if ((TextHelper.Exists(fileName)) && (File.Exists(fileName)))
                {
                    // read the text of the file
                    string fileText = File.ReadAllText(fileName);

                    // set the textLines
                    List<TextLine> textLines = WordParser.GetTextLines(fileText);

                    // If the textLines collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(textLines))
                    {
                        // set the first row contents
                        firstRowContent = textLines[0];
                    }

                    // If the firstRowContent object exists
                    if (NullHelper.Exists(firstRowContent))
                    {
                        // parse the words from the first column
                        words = WordParser.GetWords(firstRowContent.Text, delimiters);
                    }

                    // If the words collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(words))
                    {  
                        // Iterate the collection of Word objects
                        foreach (Word word in words)  
                        { 
                            // remove any spaces and special characters from the column names. This may have to be modified as more files are tested.
                            word.Text = word.Text.Replace(" ", "").Replace("(", "").Replace(")", "").Replace(".", "").Replace("_", "").Replace("<", "").Replace(">", "");

                            // Start on a new line
                            sb.Append(Environment.NewLine);

                            // add this one
                            sb.Append(alterTableTemplate);

                             // Start on a new line
                            sb.Append(Environment.NewLine);

                            // replace out the text of the template
                            alterTable = alterTableTemplate2.Replace("[ColumnName]", TextHelper.CapitalizeFirstChar(word.Text));

                             // add this one
                            sb.Append(alterTable);

                            // Start on a new line
                            sb.Append(Environment.NewLine);

                            // Append Go
                            sb.Append("Go");
                        }

                        // set the sqlQuery and trim off the last line
                        string sqlQuery = sb.ToString().Trim();

                        // copy to clipboard
                        Clipboard.SetText(sqlQuery);

                        // Show finished message
                        MessageBoxHelper.ShowMessage("Finished", "Done");
                    }
                }
            }
            #endregion
            
            #region Button_MouseEnter(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Mouse Enter
            /// </summary>
            private void Button_MouseEnter(object sender, EventArgs e)
            {
                // Change the cursor to a hand
                Cursor = Cursors.Hand;
            }
            #endregion
            
            #region Button_MouseLeave(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Mouse Leave
            /// </summary>
            private void Button_MouseLeave(object sender, EventArgs e)
            {
                // Change the cursor back to the default pointer
                Cursor = Cursors.Default;
            }
        #endregion

            #region Button_EnabledChanged(object sender, EventArgs e)
            /// <summary>
            /// event is fired when a button becomes enabled or disabled.
            /// </summary>
            private void Button_EnabledChanged(object sender, EventArgs e)
            {
                // cast the sender as a button
                Button button = sender as Button;

                // if Enabled
                if (button.Enabled)
                {
                    // Use Enabled Image
                    button.BackgroundImage = Properties.Resources.WoodButtonWidth1280;
                }
                else
                {
                    // Use Disabled Image
                    button.BackgroundImage = Properties.Resources.WoodButtonWidth1280Disabled;
                }

                // Refresh everything
                this.Refresh();
            }
            #endregion
            
            #region DoneButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'DoneButton' is clicked.
            /// </summary>
            private void DoneButton_Click(object sender, EventArgs e)
            {
                // Close this app
                Application.Exit();
            }
            #endregion
            
            #region ImportDataButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'ImportDataButton' is clicked.
            /// </summary>
            private void ImportDataButton_Click(object sender, EventArgs e)
            {
                // set the fileName                
                string fileName = SourceFileControl.Text;

                // locals
                string tableName = "RawImport";                
                
                // ********************************************************
                // ******    Set The Expected Count Using The SQL Query **********
                // ******    Use DataTier.Net.Database For This                  **********
                // ********************************************************
                int expectedCount = 329;
                
                // if the fileName exists
                if ((TextHelper.Exists(fileName)) && (File.Exists(fileName)))
                {  
                    // save the records
                    int savedCount = CSVImportJob.ImportDataFromFile(fileName, tableName, expectedCount, ProgressCallback);

                    // Show a message as a test
                    MessageBoxHelper.ShowMessage("Successfully imported " + savedCount.ToString() + " records.", "Import Complete");
                }
            }
            #endregion

            #region OnTextChanged(Control sender, string text)
            /// <summary>
            /// event is fired when On Text Changed
            /// </summary>
            public void OnTextChanged(Control sender, string text)
            {
                // Enable or disable controls
                UIEnable();
            }
            #endregion
            
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Setup this control to listen for changes
                this.SourceFileControl.OnTextChangedListener = this;

                // disable buttons 
                this.CreateSQLColumnsButton.Enabled = false;
                this.ImportDataButton.Enabled = false;
            }
            #endregion
            
            #region ProgressCallback(int progress, string tableName)
            /// <summary>
            /// This method returns the Callback
            /// </summary>
            public void ProgressCallback(int progress, string tableName)
            {  
                // setup the Graph
                this.Graph.Value = progress;

                // Update the UI
                this.Refresh();
            }
            #endregion

            #region UIEnable()
            /// <summary>
            /// This method UI Enable
            /// </summary>
            public void UIEnable()
            {
                // is there text in the SourceFileControl
                bool hasText = SourceFileControl.HasText;

                // if the text exists and the FileExists
                bool enabled = ((hasText) && (File.Exists(SourceFileControl.Text)));
                
                // enable or disable the buttons
                CreateSQLColumnsButton.Enabled = enabled;
                ImportDataButton.Enabled = enabled;

                // refresh everything
                this.Refresh();
            }
            #endregion
            
        #endregion

        #region Properties

        #region CreateParams
        /// <summary>
        /// This property here is what did the trick to reduce the flickering.
        /// I also needed to make all of the controls Double Buffered, but
        /// this was the final touch. It is a little slow when you switch tabs
        /// but that is because the repainting is finishing before control is
        /// returned.
        /// </summary>
        protected override CreateParams CreateParams
            {
                get
                {
                    // initial value
                    CreateParams cp = base.CreateParams;

                    // Apparently this interrupts Paint to finish before showing
                    cp.ExStyle |= 0x02000000;

                    // return value
                    return cp;
                }
            }
        #endregion

        #endregion

    }
    #endregion

}
