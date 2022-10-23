namespace Mc2.CrudTest.Shared.Consts
{
    public class RegularExpressionConsts
    {
        public const string PhoneNumber = @"^(\+98|0)?9\d{9}$";

        public const string Email = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
    }
}
