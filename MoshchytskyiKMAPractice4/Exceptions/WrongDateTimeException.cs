using System;

namespace MoshchytskyiKMAPcractice4.Exceptions
{
    class WrongDateTimeException : Exception
    {
        public override string Message => "You not born, or you already die !";
    }
}