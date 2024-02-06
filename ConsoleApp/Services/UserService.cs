using ConsoleApp.Repositories;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Services
{
    internal class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public UserEntity CreateUser(string email)
        {
            var userEntity = _userRepository.GetOne(x => x.Email == email);
           userEntity ??= _userRepository.Create( new UserEntity { Email = email });

            return userEntity;
        }

        public UserEntity GetUserById(int id)
        {
            var userEntity = _userRepository.GetOne(x => x.UserId == id);
            return userEntity;
        }

        public IEnumerable<UserEntity> GetUsers()
        {
            var users = _userRepository.GetAll();
            return users;
        }

        public UserEntity UpdateUser(UserEntity userEntity)
        {
            var updatedUserEntity = _userRepository.Update(x => x.UserId == userEntity.UserId, userEntity);
            return updatedUserEntity;
        }

        public void DeleteUser(int id)
        {
            _userRepository.Delete(x => x.UserId == id);
        }
    }
}
