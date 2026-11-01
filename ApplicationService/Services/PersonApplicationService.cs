using ApplicationService.Dtos.PersonDtos;
using Model.DomainModel;
using Model.ServiceModel;

namespace ApplicationService.Services
{
    public class PersonApplicationService
    {
        #region [- PrivateFields -]
        private readonly PersonServiceModel _personServiceModel;
        #endregion

        #region [- Ctor -]
        public PersonApplicationService()
        {
            _personServiceModel = new PersonServiceModel();
        } 
        #endregion

        #region [- Post() -]
        public void Post(PostPersonDto postPersonDto)
        {
            var person = new Person()
            {
                FirstName = postPersonDto.FirstName,
                LastName = postPersonDto.LastName,
                NationalId = postPersonDto.NId,
            };
            _personServiceModel.Insert(person);
        }
        #endregion

        #region [- Put() -]
        public void Put(PutPersonDto putPersonDto)
        {
            var person = new Person()
            {   Id = putPersonDto.Id,
                FirstName = putPersonDto.FirstName,
                LastName = putPersonDto.LastName,
                NationalId = putPersonDto.NId,
            };
            _personServiceModel.Update(person);
        }
        #endregion

        #region [- Delete() -]
        public void Delete(DeletePersonDto deletePersonDto)
        {
            var person = new Person()
            {
                Id = deletePersonDto.Id,
            };
            _personServiceModel.Delete(person);
        }
        #endregion

        #region [- GetAll() -]
        public List<GetPersonDto> GetAll()
        {
            var persons = _personServiceModel.SelectAll();
            var getPersonDtos = new List<GetPersonDto>();
            foreach (var item in persons)
            {
                var getPersondto = new GetPersonDto()
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    NId = item.NationalId
                };
                getPersonDtos.Add(getPersondto);
            }
            return getPersonDtos;
        }
        #endregion
    }
}
