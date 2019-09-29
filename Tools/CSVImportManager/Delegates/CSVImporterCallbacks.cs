using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVImportManager.Delegates
{
    
    #region delegate void ImportProgressCallback(int progress, string tableName);
    /// <summary>
    /// This delegates to used to allow CSVImporter to call back to the client to update progress.
    /// </summary>
    /// <param name="progress">How many records have been saved so far.</param>
    /// <param name="tableName">May not be needed, but for situations were multiple import jobs are happening I added this.</param>
    public delegate void ImportProgressCallback(int progress, string tableName);
    #endregion

}
