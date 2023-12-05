using System;

namespace Тумаков_14
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    internal class DeveloperInfoAttribute : Attribute
    {
        public string name { get; set; }
        public DateTime time { get; set; }
        public DeveloperInfoAttribute(string name, string input_time)
        {
            this.name = name;
            if(DateTime.TryParse(input_time, out var result))
            {
                time = result;
            }
            else
            {
                throw new ArgumentException("Ошибка");
            }
        }
    }
}
