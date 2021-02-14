using System.Collections.Generic;

namespace WeContractLib
{
    public  interface IDisplayable
    {
        /// <summary>
        /// Returns the data from the inhertied class to be used in UI controls such as DataGridViews and ListViews.
        /// </summary>
        /// <returns>List of data.</returns>
        public List<object> GetColumnIndexes();
    }
}
