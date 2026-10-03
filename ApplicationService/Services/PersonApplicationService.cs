using ApplicationService.Dtos;
using Model.DomainModel;
using Model.ServiceModel;

namespace ApplicationService.Services
{
    public class PersonApplicationService
    {
        private readonly PersonServiceModel _personServiceModel;
        public PersonApplicationService()
        {
            _personServiceModel = new PersonServiceModel();
        }

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
                };
                getPersonDtos.Add(getPersondto);
            }
            return getPersonDtos;
        }
        #endregion

        #region [- Post -]
        public void Post(PostPersonDto postPersonDto)
        {
            var person = new Person()
            {
                FirstName = postPersonDto.FirstName,
                LastName = postPersonDto.LastName,
            };
            _personServiceModel.Insert(person);
        }
        #endregion
    }
}
