using System;

public class AmountException : Exception
{
    public string PersonName { get; }

    public AmountException(string personName, string message) : base(message)
    {
        PersonName = personName;
    }
}
