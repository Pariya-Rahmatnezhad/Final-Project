using Model.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ServiceModel
{
    public class PersonServiceModel
    {
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
