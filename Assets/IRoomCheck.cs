using System;
using System.Collections.Generic;
public interface IRoomCheck
{
    void RemoveFromCurrent(Item item);
    void AddToCurrent(Item item);
    void InitiateCheck();
}