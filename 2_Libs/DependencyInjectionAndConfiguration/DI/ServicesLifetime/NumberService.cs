﻿using System.Threading;

public class NumberService : INumberService
{
    private int _number = 0;
    public int GetNumber() => Interlocked.Increment(ref _number);
}
