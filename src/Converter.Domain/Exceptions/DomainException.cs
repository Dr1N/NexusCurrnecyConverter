﻿using System;
using System.Runtime.Serialization;

namespace Converter.Domain.Exceptions;

/// <summary>
/// Domain level exception
/// </summary>
[Serializable]
public class DomainException : Exception
{
    public DomainException()
    {
    }

    public DomainException(string message)
        : base(message)
    {
    }

    public DomainException(string message, Exception innerException)
        : base(message, innerException)
    {
    }

    protected DomainException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}