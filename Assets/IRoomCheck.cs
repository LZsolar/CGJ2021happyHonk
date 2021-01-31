using System;
using System.Collections.Generic;
public interface IRoomCheck
{
    bool isInside(Item item);
    void RemoveFromCurrent(Item item);
    void AddToCurrent(Item item);
}