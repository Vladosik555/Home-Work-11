
namespace Тумаков_14
{
    [Developer_("Владислав", "Шарашкина контора")]
    [Developer_("Даниил", "IT-контора")]
    [Developer_("Амир", "Юный программист")]
    internal class Creator_Build
    {
        private int number;//уникальный номер квартиры
        /// <summary>
        /// Свойство для уникального номера
        /// </summary>
        public int Number
        {
            get { return number; }
        }
        private static int number_1 = 0;
        /// <summary>
        /// Метод, который увеличивает номер на 1, для того чтобы создать уникальный номер
        /// </summary>
        private void PrintNumber()
        {
            number_1++;
        }
        private uint height;
        /// <summary>
        /// Свойство, которое возвращает высоту здания
        /// </summary>
        public uint Height
        {
            get { return height; }
        }
        private uint floor;//количество этажей
        /// <summary>
        /// Свойство, которое возвращяет количество этажей
        /// </summary>
        public uint Floor
        {
            get { return floor; }
        }
        private uint quantity_apart;//количество квартир
        /// <summary>
        /// Свойство, которое возвращает количество квартир
        /// </summary>
        public uint Quantity_apart
        {
            get { return quantity_apart; }
        }
        private uint quantity_entr;//количество подъездов
        /// <summary>
        /// Свойство, которое возвращает количество подъездов
        /// </summary>
        public uint Quantity_entr
        {
            get { return quantity_entr; }
        }
        /// <summary>
        /// Конструктор для заполнения полей банковского аккаунта
        /// </summary>
        /// <param name="height"></param>
        /// <param name="floor"></param>
        /// <param name="quantity_apart"></param>
        /// <param name="quantity_entr"></param>
        public Creator_Build(uint height, uint floor, uint quantity_apart, uint quantity_entr)
        {
            number = number_1;
            this.height = height;
            this.floor = floor;
            this.quantity_apart = quantity_apart;
            this.quantity_entr = quantity_entr;
            PrintNumber();
        }

        /// <summary>
        /// Метод, для нахождения высоты одного этажа
        /// </summary>
        /// <param name="heigth"></param>
        /// <param name="floor"></param>
        /// <returns></returns>
        public uint Heigth(uint heigth, uint floor)
        {
            uint result = (uint)(heigth / floor);
            return result;
        }
        /// <summary>
        /// Метод, который находить количество этажей на один подъезд
        /// </summary>
        /// <param name="floor"></param>
        /// <param name="quantity_entr"></param>
        /// <returns></returns>
        public uint Quantity_apart_inENTR(uint floor, uint quantity_entr)
        {
            uint result1 = (uint)(floor / quantity_entr);
            return result1;
        }
        /// <summary>
        /// Метод, который находит количество квартир на одном этаже
        /// </summary>
        /// <param name="quantity_apart"></param>
        /// <param name="floor"></param>
        /// <returns></returns>
        public uint Quantity_apart_infloor(uint quantity_apart, uint floor)
        {
            uint result3 = (uint)(quantity_apart / floor);
            return result3;
        }
    }
}
