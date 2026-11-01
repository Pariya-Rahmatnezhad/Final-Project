using Model.DomainModel;

namespace Model.ServiceModels
{
    public class ProductServiceModel
    {
        #region [- Insert() -]
        public void Insert(Product product)
        {
            using (var context = new ProjectDBContext())
            {
                try
                {
                    context.Add(product);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                }
            }
        }
        #endregion

        #region [- Update() -]
        public void Update(Product product)
        {
            using (var context = new ProjectDBContext())
            {
                try
                {
                    var editedProduct = context.Product.Find(product.Id);
                    if (editedProduct != null)
                    {
                        editedProduct.Code = product.Code;
                        editedProduct.Title = product.Title;
                        editedProduct.UnitPrice = product.UnitPrice;
                        editedProduct.Quantity = product.Quantity;
                        context.SaveChanges();
                    }
                }
                catch
                {
                    throw;
                }
                finally 
                {
                }
            }
        }
        #endregion

        #region [- Delete() -]
        public void Delete(Product product)
        {
            using (var context = new ProjectDBContext())
            {
                try
                {
                    var deletedProduct = context.Product.Find(product.Id);
                    if (deletedProduct != null)
                    {
                        context.Product.Remove(deletedProduct);
                        context.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                }
            }
        } 
        #endregion

        #region [- SellectAll() -]
        public List<Product> SellectAll()
        {
            using (var context = new ProjectDBContext())
            {
                try
                {
                    var products = context.Product.ToList();
                    return products;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                }
            }
        } 
        #endregion
    }
}
