using System;

namespace Тумаков_14
{
    [DeveloperInfo("Владислав", "2023, 11, 28")]
    [DeveloperInfo("Даниил" , "2023, 11, 29")]
    [DeveloperInfo("Амир", "2023, 11, 30")]
    internal class Rational_numbers
    {
        private double numerator { get; set; }
        private double denominator { get; set; }
        /// <summary>
        /// Конструктор, который принимает числитей и знаменатель
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        public Rational_numbers(double numerator, double denominator)
        {
            if (denominator == 0)
            {
                Console.WriteLine("На ноль делить нельзя");
            }
            else
            {
                this.numerator = numerator;
                this.denominator = denominator;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numerator"></param>
        public Rational_numbers(double numerator)
        {
            this.numerator = numerator;
            denominator = 1;
        }
        /// <summary>
        /// Переопределённый метод Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is Rational_numbers numb)
            {
                if (numerator == numb.numerator && denominator == numb.denominator)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        /// <summary>
        /// Переопределенные операторы
        /// </summary>
        /// <param name="number_1"></param>
        /// <param name="number_2"></param>
        /// <returns></returns>
        public static bool operator ==(Rational_numbers number_1, Rational_numbers number_2)
        {
            return number_1.Equals(number_2);
        }
        public static bool operator !=(Rational_numbers number_1, Rational_numbers number_2)
        {
            return !number_1.Equals(number_2);
        }


        public static bool operator <(Rational_numbers number_1, Rational_numbers number_2)
        {
            return (number_1.numerator / number_1.denominator < number_2.numerator / number_2.denominator);
        }
        public static bool operator >(Rational_numbers number_1, Rational_numbers number_2)
        {
            return (number_1.numerator / number_1.denominator > number_2.numerator / number_2.denominator);
        }


        public static bool operator <=(Rational_numbers number_1, Rational_numbers number_2)
        {
            return (number_1.numerator / number_1.denominator <= number_2.numerator / number_2.denominator);
        }
        public static bool operator >=(Rational_numbers number_1, Rational_numbers number_2)
        {
            return (number_1.numerator / number_1.denominator >= number_2.numerator / number_2.denominator);
        }


        public static Rational_numbers operator +(Rational_numbers number_1, Rational_numbers number_2)
        {
            return new Rational_numbers(number_1.numerator * number_2.denominator + number_2.numerator * number_1.denominator,
                number_1.denominator * number_2.denominator);
        }

        public static Rational_numbers operator -(Rational_numbers number_1, Rational_numbers number_2)
        {
            return new Rational_numbers(number_1.numerator * number_2.denominator - number_2.numerator * number_1.denominator,
                number_1.denominator * number_2.denominator);
        }

        public static Rational_numbers operator ++(Rational_numbers number)
        {
            return new Rational_numbers(number.numerator + number.denominator, number.denominator);
        }

        public static Rational_numbers operator --(Rational_numbers number)
        {
            return new Rational_numbers(number.numerator - number.denominator, number.denominator);
        }
        public static Rational_numbers operator *(Rational_numbers number_1, Rational_numbers number_2)
        {
            return new Rational_numbers(number_1.numerator * number_2.numerator, number_1.denominator * number_2.denominator);
        }

        public static Rational_numbers operator /(Rational_numbers number_1, Rational_numbers number_2)
        {
            if (number_1.denominator == 0 || number_2.denominator == 0)
            {
                return new Rational_numbers(0);
            }
            else
            {
                return new Rational_numbers(number_1.numerator * number_2.denominator, number_1.denominator * number_2.numerator);
            }
        }

        public static Rational_numbers operator %(Rational_numbers number_1, Rational_numbers number_2)
        {
            if (number_1.denominator == 0 || number_2.denominator == 0)
            {
                return new Rational_numbers(0);
            }
            else
            {
                return new Rational_numbers((number_1.numerator / number_1.denominator) % (number_2.numerator / number_2.denominator));
            }
        }

        public static implicit operator int(Rational_numbers number)
        {
            return (int)(number.numerator / number.denominator);
        }

        public static implicit operator float(Rational_numbers number)
        {
            return (float)(number.numerator / number.denominator);
        }

        public override string ToString()
        {
            return $"Дробь {numerator} / {denominator}";
        }
    }
}
