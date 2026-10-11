using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationService.Dtos.PersonDtos
{
    public class GetPersonDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
