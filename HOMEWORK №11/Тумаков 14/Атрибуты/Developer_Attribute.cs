using System;

namespace Тумаков_14
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    internal class Developer_Attribute : Attribute
    {
        public string name {  get; set; }
        public string name_organization { get; set; }
        /// <summary>
        /// Конструктор, который позволяет принять имя и название организации
        /// </summary>
        /// <param name="name"></param>
        /// <param name="organization"></param>
        public Developer_Attribute(string name, string organization)
        {
            this.name = name;
            name_organization = organization;
        }
    }
}
