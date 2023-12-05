using System;

namespace Тумаков_13
{
    internal class Build
    {
        private Creator_Build[] builds = new Creator_Build[10];
        /// <summary>
        /// Свойство для возвращение зданий
        /// </summary>
        public Creator_Build[] Builds
        {
            get { return builds; }
        }
        /// <summary>
        /// Индексатор, который проверяет индекс здания по его уникальному номеру
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public Creator_Build this[int index]
        {
            get
            {
                if (index >= 0 && index < builds.Length)
                {
                    return builds[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Ошибка");
                }
            }
            set
            {
                if (index >= 0 && index < builds.Length)
                {
                    builds[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Ошибка");
                }
            }
        }
        /// <summary>
        /// Метод, который создает здание по его уникальному номеру
        /// </summary>
        /// <param name="buildss"></param>
        public void Collection(Creator_Build buildss)
        {
            builds[buildss.Number] = buildss;
        }
    }
}
