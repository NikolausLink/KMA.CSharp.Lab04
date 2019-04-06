using System;

namespace MoshchytskyiKMAPractice4.Exceptions
{
    public class NotExistingUserException : Exception
    {
        public override string Message => "User are not exists !";
    }
}