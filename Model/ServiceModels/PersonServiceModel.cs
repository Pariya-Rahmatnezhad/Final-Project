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
                finally
                {
                }
            }
        }

        #endregion

        #region [- Update() -]
        public void Update(Person person)
        {
            using (var context = new ProjectDBContext())
            {
                try
                {
                    var editedPerson = context.Person.Find(person.Id);
                    if (editedPerson != null)
                    {
                        editedPerson.FirstName = person.FirstName;
                        editedPerson.LastName = person.LastName;
                        editedPerson.NationalId = person.NationalId;
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

        #region [- Delete() -]
        public void Delete(Person person)
        {
            using (var context = new ProjectDBContext())
            {
                try
                {   
                    var deletedPerson = context.Person.Find(person.Id);
                    if (deletedPerson != null) {
                        context.Person.Remove(deletedPerson);
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
                finally 
                {
                }
            }
        } 
        #endregion
    }
}
