using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnpikeGate.Core.Interfaces
{
    public interface IService<TEntity>
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(String id);
        List<TEntity> GetAll();
        TEntity GetById(ObjectId id);
    }

    public class EmptyFieldsException : Exception
    {
        public EmptyFieldsException() : base("Sva polja moraju biti popunjena.")
        {

        }
    }

    public class BadCredentialsException : Exception
    {
        public BadCredentialsException() : base("Pogresno korisnicko ime i/ili lozinka.")
        {

        }
    }

    public class PasswordsNotMatchingException : Exception
    {
        public PasswordsNotMatchingException() : base("Unete sifre se ne poklapaju. Pokusajte ponovo.")
        {

        }
    }

    public class LoggedUserException : Exception
    {
        public LoggedUserException(String message) : base(message)
        {

        }
    }



}