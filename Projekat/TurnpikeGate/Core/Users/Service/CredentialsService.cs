using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnpikeGate.Core.Interfaces;
using TurnpikeGate.Core.Users.Model;
using TurnpikeGate.Core.Users.Repository;

namespace TurnpikeGate.Core.Users.Service
{
    internal class CredentialsService : ICredentialsService
    {

        ICredentialsRepository _credentialsRepository;

        public CredentialsService(ICredentialsRepository credentialsRepository)
        {
            _credentialsRepository = credentialsRepository;
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Credentials> GetAll()
        {
            return _credentialsRepository.GetAll();
        }

        public Credentials GetById(ObjectId id)
        {
            return _credentialsRepository.GetById(id);
        }

        public void Insert(Credentials entity)
        {
            _credentialsRepository.Insert(entity);
        }

        public void Update(Credentials entity)
        {
            _credentialsRepository.Update(entity);
        }

        public void ChangeInitialPassword(String newPassword, String repeatedNewPassword)
        {
            if (newPassword != repeatedNewPassword)
                throw new PasswordsNotMatchingException();

            Globals.LoggedUser.Password = newPassword;
            Globals.LoggedUser.IsActive = true;
            _credentialsRepository.Update(Globals.LoggedUser);
        }
    }
}
