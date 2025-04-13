using System;
using System.Data.Entity;

namespace Yagnov
{
    internal class AddEditProductWindow
    {
        private Product selectedProduct;
        private DbContext dbContext;

        public AddEditProductWindow(Product selectedProduct, DbContext dbContext)
        {
            this.selectedProduct = selectedProduct;
            this.dbContext = dbContext;
        }

        internal bool ShowDialog()
        {
            throw new NotImplementedException();
        }
    }
}