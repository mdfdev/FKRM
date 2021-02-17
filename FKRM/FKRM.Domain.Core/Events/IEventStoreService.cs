using System;
using System.Collections.Generic;
using System.Text;

namespace FKRM.Domain.Core.Events
{
    public interface IEventStoreService
    {
        void Save<T>(T theEvent) where T : Event;
    }
}
