using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizBlood {
    public class AnalizBlood {
        public static string Glukoza(double x) {
            if (x >= 6.5) return "Повышенный уровень глюкозы: Сахарный диабет";
            else if (x >= 3.5 && x < 6.5) return "Уровень глюкозы в норме";
            else if (x > 0 && x < 3.5) return "Пониженный уровень глюкозы: Недостаточное и нерегулярное питание, гормональные заболевания";
            else return "Введены некорректные данные";
        }

        public static string Gemoglobin(double x, string gender) {
            if (gender == "male") {
                if (x >= 160) return "Повышенный уровень гемоглобина: Обезвоживании организма, заболевание крови и некоторые виды сердечной недостаточности";
                else if (x >= 130 && x < 160) return "Уровень гемоглобина в норме";
                else if (x > 0 && x < 130) return "Пониженный уровень гемоглобина: Анемия, кровопотеря, скрытое внутреннее кровотечение, поражение внутренних органов";
                else return "Введены некорректные данные";
            }
            else if (gender == "female") {
                if (x >= 140) return "Повышенный уровень гемоглобина: Обезвоживании организма, заболевание крови и некоторые виды сердечной недостаточности";
                else if (x >= 120 && x < 140) return "Уровень гемоглобина в норме";
                else if (x > 0 && x < 120) return "Пониженный уровень гемоглобина: Анемия, кровопотеря, скрытое внутреннее кровотечение, поражение внутренних органов";
                else return "Введены некорректные данные";
            }
            else return "Введен некорректный пол";
        }
    }
}