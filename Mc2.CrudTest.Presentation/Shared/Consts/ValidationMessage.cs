namespace Mc2.CrudTest.Shared.Consts
{
    public class ValidationMessage
    {
        public const string NotEmpty = "{PropertyName} Can't Be Empty";
        public const string MaximumLength = "{PropertyName} Can't Be More Than {MaxLength} Characters";
        public const string MinimumLength = "{PropertyName} Can't Be Less Than {MinLength} Characters";
        public const string NotEqual = "{PropertyName} Can't Be Equal To {NotEqual}";
        public const string BeUnique = "{PropertyName} Is Not Unique";
        public const string NotExists = "{PropertyName} Doesn't Exist";
        public const string RegexIsInvalid = "{PropertyName} Is Not Valid";
    }
}
