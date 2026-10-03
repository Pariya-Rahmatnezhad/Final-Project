using Model.DomainModel;

namespace Model.ServiceModel
{
    public class PersonServiceModel
    {
        #region [- Insert() -]
        public void Insert(Person person)
        {
            using (var context = new ProjectDBContext())
            {
                try
                {
                    //context.Person.Add(person);
                    context.Add(person);
                    context.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
                finally { }
            }
        }

        #endregion
        #region [- SelectAll() -]
        public List<Person> SelectAll()
        {
            using (var context = new ProjectDBContext())
            {
                try
                {
                    var persons = context.Person.ToList();
                    return persons;
                }
                catch (Exception)
                {

                    throw;
                }
                finally { }
            }
        } 
        #endregion
    }
}
