using System;
using System.Collections.Generic;


namespace GoFootball
{
    /// <summary>
    /// Заявка на просмотр в футбольный клуб
    /// <summary>
    public class RideApplicationDto
    {
        /// <summary>
        /// Дата заполнения 
        /// <summary> 
        public DateTime Filled { get; set; }

        /// <summary>
        /// ФИО футболиста
        /// <summary>
        public string FullName { get; set; }

        /// <summary>
        /// Гражданство футболиста
        /// <summary>
        public string Citizenship { get; set; }

        /// <summary>
        /// Возраст футболиста  
        /// <summary>
        public double Age { get; set; }

        /// <summary>
        /// Рост футболиста
        /// <summary>
        public int Height { get; set; }

        /// <summary>
        /// Вес футболиста
        /// <summary>
        public int Weight { get; set; }

        /// <summary>
        /// Возраст футболиста, когда он начал карьеру
        /// <summary>
        public int AgeStartCareer { get; set; }

        /// <summary>
        /// Опыт игры в футбол у футболиста (полных лет)
        /// <summary>
        public int ExperienceInFootball { get; set; }

        /// <summary>
        /// Позиция футболиста 
        /// <summary>
        public Position Position { get; set; }

        /// <summary>
        /// Сильные стороны футболиста
        /// <summary>
        public Strengths Strengths { get; set; }

        /// <summary>
        /// Слабые стороны футболиста 
        /// <summary>
        public WeakSides WeakSides { get; set; }

        /// <summary>
        /// Рабочая нога футболиста
        /// <summary>
        public WorkingLeg WorkingLeg { get; set; }

        /// <summary>
        /// Информация о травмах футболиста
        /// <summary>
        public List<Trauma>Traums { get; set; }
    }

    public class Trauma
    {
        /// <summary>
        /// Количество травм у футболиста за всю карьеру
        /// <summary>
        public int CountTraums { get; set; }

        /// <summary>
        /// Количество полных лет, пропущенных футолистом из-за травм за всю карьеру
        /// <summary>
        public int TimeTraums { get; set; }

        /// <summary>
        /// Есть ли у футболиста трамва прямо сейчас
        /// <summary>
        public bool TraumаNow { get; set; }

        /// <summary>
        /// Прошлые травмы футболиста
        /// <summary>
        public TraumaTypes Type { get; set; }
    }

    public enum TraumaTypes
    {  
        Ankle, // Голеностоп
        head, // Голова
        Arm, // Рука
        Body, // Тело
        Knee, // Колено
        Foot, // Стопа
        Groin, // Паховые мышцы
        Femur, // Бедренная кость
        CalfMuscles, // Икроножные мышцы
        CruciformLigaments, // Крестообразые связки
        None, // Не было
    }

    public enum WorkingLeg
    {
        Left,
        Right,
        BothLeg,
    }

    public enum WeakSides
    {
        Concentration,
        Speed,
        Shoot,
        Endurance,
        Force,
        HeadGame,
        Dribbling,
        Reaction,
        Jump,
    }

    public enum Strengths
    {
        Shoot,
        Pass,
        Dribbling,
        MasterOfStandards,
        HeadGame,
        Speed,
        Physics,
        Reaction,
        Jump,
    }

    public enum Position
    {
        Goalkeeper,
        Defender,
        Midfielder,
        Forward,
    }
}
