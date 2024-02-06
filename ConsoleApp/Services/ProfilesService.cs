using ConsoleApp.Repositories;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Services
{
    internal class ProfilesService
    {
        private readonly ProfilesRepository _profilesRepository;
        private readonly UserService _userService;

        public ProfilesService(ProfilesRepository profilesRepository, UserService userService)
        {
            _profilesRepository = profilesRepository;
            _userService = userService;
        }

        public ProfileEntity CreateProfile(string firstName, string lastName, string streetName, string city, string email, string password)
        {
           

            var userEntity = _userService.CreateUser(email);

            var profileEntity = new ProfileEntity
            {
                FirstName = firstName,
                LastName = lastName,
                StreetName = streetName,
                City = city,

               
               
                //UserId = userEntity.UserId,
            };

            profileEntity = _profilesRepository.Create(profileEntity);
            return profileEntity;
        }




        public ProfileEntity GetProfileById(int id)
        {
            var profileEntity = _profilesRepository.GetOne(x => x.Id == id);
            return profileEntity;
        }

        public IEnumerable<ProfileEntity> GetProfiles()
        {
            var profiles = _profilesRepository.GetAll();
            return profiles;
        }

        public ProfileEntity UpdateProfile(ProfileEntity profileEntity)
        {
            var updatedProfileEntity = _profilesRepository.Update(x => x.Id == profileEntity.Id, profileEntity);
            return updatedProfileEntity;
        }

        public void DeleteProfile(int id)
        {
            _profilesRepository.Delete(x => x.Id == id);
        }
    }
}
