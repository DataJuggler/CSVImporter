

#region using statements

using System;

#endregion


namespace ObjectLibrary.BusinessObjects
{

    #region class RawImport
    public partial class RawImport
    {

        #region Private Variables
        private string close;
        private string date;
        private string high;
        private int id;
        private string low;
        private string open;
        private string per;
        private string ticker;
        private string vol;
        #endregion

        #region Methods

            #region UpdateIdentity(int id)
            // <summary>
            // This method provides a 'setter'
            // functionality for the Identity field.
            // </summary>
            public void UpdateIdentity(int id)
            {
                // Update The Identity field
                this.id = id;
            }
            #endregion

        #endregion

        #region Properties

            #region string Close
            public string Close
            {
                get
                {
                    return close;
                }
                set
                {
                    close = value;
                }
            }
            #endregion

            #region string Date
            public string Date
            {
                get
                {
                    return date;
                }
                set
                {
                    date = value;
                }
            }
            #endregion

            #region string High
            public string High
            {
                get
                {
                    return high;
                }
                set
                {
                    high = value;
                }
            }
            #endregion

            #region int Id
            public int Id
            {
                get
                {
                    return id;
                }
            }
            #endregion

            #region string Low
            public string Low
            {
                get
                {
                    return low;
                }
                set
                {
                    low = value;
                }
            }
            #endregion

            #region string Open
            public string Open
            {
                get
                {
                    return open;
                }
                set
                {
                    open = value;
                }
            }
            #endregion

            #region string Per
            public string Per
            {
                get
                {
                    return per;
                }
                set
                {
                    per = value;
                }
            }
            #endregion

            #region string Ticker
            public string Ticker
            {
                get
                {
                    return ticker;
                }
                set
                {
                    ticker = value;
                }
            }
            #endregion

            #region string Vol
            public string Vol
            {
                get
                {
                    return vol;
                }
                set
                {
                    vol = value;
                }
            }
            #endregion

            #region bool IsNew
            public bool IsNew
            {
                get
                {
                    // Initial Value
                    bool isNew = (this.Id < 1);

                    // return value
                    return isNew;
                }
            }
            #endregion

        #endregion

    }
    #endregion

}
