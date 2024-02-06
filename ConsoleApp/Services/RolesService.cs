using ConsoleApp.Repositories;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Services
{
    internal class RolesService
    {
        private readonly RolesRepository _rolesRepository;

        public RolesService(RolesRepository rolesRepository)
        {
            _rolesRepository = rolesRepository;
        }

        public RoleEntity CreateRole(string roleName)
        {
            var userEntity = _rolesRepository.GetOne(x => x.RoleName == roleName);
            userEntity ??= _rolesRepository.Create(new RoleEntity { RoleName = roleName });

            return userEntity;
        }

        public RoleEntity GetRoleById(int id)
        {
            var roleEntity = _rolesRepository.GetOne(x => x.RoleId == id);
            return roleEntity;
        }

        public IEnumerable<RoleEntity> GetRoles()
        {
            var roles = _rolesRepository.GetAll();
            return roles; 
        }

        public RoleEntity UpdateRole(RoleEntity roleEntity)
        {
            var updatedRoleEntity = _rolesRepository.Update(x => x.RoleId == roleEntity.RoleId, roleEntity);
            return updatedRoleEntity;
        }

        public void DeleteRole(int id)
        {
            _rolesRepository.Delete(x => x.RoleId == id);
        }
    }
}
