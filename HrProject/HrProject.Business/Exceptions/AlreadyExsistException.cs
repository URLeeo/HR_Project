﻿namespace HrProject.Business.Exceptions;

public class AlreadyExsistException : Exception
{
    public AlreadyExsistException(string message) : base(message)
    {
        
    }
}
