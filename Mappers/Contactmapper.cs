using Apideneme.Dtos;
using Apideneme.Models;

namespace Apideneme.Mappers
{
    public static class Contactmapper
    {
        public static Contactdto ToContactdto(this Models.Contact contactModel)
        {
            return new Contactdto
            {
                Id = contactModel.Id,
                Name = contactModel.Name,   
                Surname = contactModel.Surname,
                Username = contactModel.Username
            };
        }

        public static Contact ToNewUserdto(this CreateUserDto createUserDto) {
            return new Contact
            {
                Name = createUserDto.Name,
                Surname = createUserDto.Surname,
                Username = createUserDto.Username,
                Password = createUserDto.Password,
            };
        }
    }
}
