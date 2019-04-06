using System;

namespace MoshchytskyiKMAPractice4.Exceptions
{
    class IllegalEmailFormatException : Exception
    {
        public override string Message => "Wrong email format !";
    }
}