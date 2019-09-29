

#region using statements

using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class RawImport
    [Serializable]
    public partial class RawImport
    {

        #region Private Variables
        #endregion

        #region Constructor
        public RawImport()
        {

        }
        #endregion

        #region Methods

            #region Clone()
            public RawImport Clone()
            {
                // Create New Object
                RawImport newRawImport = (RawImport) this.MemberwiseClone();

                // Return Cloned Object
                return newRawImport;
            }
            #endregion

        #endregion

        #region Properties
        #endregion

    }
    #endregion

}
