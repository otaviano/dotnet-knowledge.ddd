

using Knowledge.Ddd.Domain.Core.Events;
using System;

namespace Knowledge.Ddd.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
