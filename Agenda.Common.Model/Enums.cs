using System;

namespace Agenda.Common.Model
{
    public enum EntityType
    {
        Unknown = 0,
        Person = 1,
        Contact = 2,
        ContactResource = 4,
        ToDoItem = 8
    }

    public enum Gender
    {
        Unknown = 0,
        Male = 1,
        Female = 2
    }

    [FlagsAttribute]
    public enum ContactResourceType
    {
        Unknown = 0,
        Telephone = 1,
        Location = 2,
        Messaging = 4,
        Home = 8,
        Work = 12,
        Mobile = 32,
        Assistant = 64,
        Fax = 128,
        Legal = 256,
        Business = 512,
        Shipping = 1024,
        Billing = 2048,
        Email = 4096,
        Viber = 8192,
        WhatsApp = 16384,
        Default = 32768
    }
}