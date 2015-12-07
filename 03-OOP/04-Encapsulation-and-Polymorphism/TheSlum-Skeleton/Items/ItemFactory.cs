using System;

namespace TheSlum.Items
{
    public static class ItemFactory
    {
        public static Item Create(string type, string id)
        {
            switch (type.ToLower())
            {
                case "axe":
                    return new Axe(id);
                case "pill":
                    return new Pill(id);
                case "injection":
                    return new Injection(id);
                case "shield":
                    return new Shield(id);
                default:
                    throw new InvalidOperationException("Invalid item");
            }
        }
    }
}
