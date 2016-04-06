﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeText.Common.Events;

namespace WeText.Domain.Events
{
    public class UserCreatedEvent : DomainEvent
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public UserCreatedEvent() : base() { }

        public UserCreatedEvent(object aggregateRootKey) : base(aggregateRootKey) { }

        public UserCreatedEvent(object aggregateRootKey, string name, string email) : base(aggregateRootKey)
        {
            this.Name = name;
            this.Email = email;
        }
    }
}
