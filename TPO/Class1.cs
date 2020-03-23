using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood {
    public class Blood {
        public static void Glukoza(int x) {
            if (x > 6.5) Console.WriteLine("Повышенный уровень глюкозы: Сахарный диабет");
            else if (x >= 3.5 && x <= 6.5) Console.WriteLine("Уровень глюкозы в норме");
            else if (x >= 0 && x <= 3.5) Console.WriteLine("Пониженный уровень глюкозы: Недостаточное и нерегулярное питание, гормональные заболевания");
            else Console.WriteLine("Введены некорректные данные");
        }

        public static void Gemoglobin(string gender, int x) {
            if (gender == "male") {
                if (x > 160) Console.WriteLine("Повышенный уровень гемоглобина: Обезвоживании организма, заболевание крови и некоторые виды сердечной недостаточности");
                else if (x >= 130 && x <= 160) Console.WriteLine("Уровень гемоглобина в норме");
                else if (x >= 0 && x <= 130) Console.WriteLine("Пониженный уровень гемоглобина: Анемия, кровопотеря, скрытое внутреннее кровотечение, поражение внутренних органов");
                else Console.WriteLine("Введены некорректные данные");
            }
            else if (gender == "female") {
                if (x > 140) Console.WriteLine("Повышенный уровень гемоглобина: Обезвоживании организма, заболевание крови и некоторые виды сердечной недостаточности");
                else if (x >= 120 && x <= 140) Console.WriteLine("Уровень гемоглобина в норме");
                else if (x >= 0 && x <= 120) Console.WriteLine("Пониженный уровень гемоглобина: Анемия, кровопотеря, скрытое внутреннее кровотечение, поражение внутренних органов");
                else Console.WriteLine("Введены некорректные данные");
            }
            else Console.WriteLine("Введен некорректный пол");
        }
    }
}
