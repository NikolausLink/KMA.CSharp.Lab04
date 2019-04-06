using System;

namespace MoshchytskyiKMAPractice4.Exceptions
{
    public class ExistingUserException : Exception
    {
        public override string Message => "User are already exist !";
    }
}