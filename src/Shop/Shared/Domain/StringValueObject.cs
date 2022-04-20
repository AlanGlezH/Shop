using System;
using System.Collections.Generic;

namespace Shop.Shared.Domain;

public class StringValueObject
{
    public string Value { get; }

    public StringValueObject(string value)
    {
        Value = value;
    }

    public override string ToString()
    {
        return Value;
    }

}
