using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAS_PR_GAZ
{
    class ModelDP
    {
        #region---Надо
        /// <summary>
        /// Расход природного газа в базовом периоде, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DP;    // закрытая переменная класса 
        public double Rashod_PG_base_DP
        {
            get { return _Rashod_PG_base_DP; }
            set { _Rashod_PG_base_DP = value; }
        }

        /// <summary>
        /// Минимально допустимый расход природного газа, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DPmin;    // закрытая переменная класса 
        public double Rashod_PG_base_DPmin
        {
            get { return _Rashod_PG_base_DPmin; }
            set { _Rashod_PG_base_DPmin = value; }
        }

        /// <summary>
        /// Максимально допустимый расход природного газа, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DPmax;    // закрытая переменная класса 
        public double Rashod_PG_base_DPmax
        {
            get { return _Rashod_PG_base_DPmax; }
            set { _Rashod_PG_base_DPmax = value; }
        }

        /// <summary>
        /// Расход кокса в базовом периоде, т/час
        /// </summary> 
        private double _Rashod_K_base_DP;    // закрытая переменная класса 
        public double Rashod_K_base_DP
        {
            get { return _Rashod_K_base_DP; }
            set { _Rashod_K_base_DP = value; }
        }

        /// <summary>
        /// Эквивалент замены кокса в базовом периоде, кг кокса /(м3 ПГ)
        /// </summary> 
        private double _Rashod_K_base_DP_E;    // закрытая переменная класса 
        public double Rashod_K_base_DP_E
        {
            get { return _Rashod_K_base_DP_E; }
            set { _Rashod_K_base_DP_E = value; }
        }

        /// <summary>
        /// Производительность по чугуну в базовом периоде, т /ч
        /// </summary> 
        private double _Proizvoditelnost_chug_base_DP;    // закрытая переменная класса 
        public double Proizvoditelnost_chug_base_DP
        {
            get { return _Proizvoditelnost_chug_base_DP; }
            set { _Proizvoditelnost_chug_base_DP = value; }
        }

        /// <summary>
        /// Теоретическая температура горения в базовом периоде, °С
        /// </summary> 
        private double _Teor_t_base_DP;    // закрытая переменная класса 
        public double Teor_t_base_DP
        {
            get { return _Teor_t_base_DP; }
            set { _Teor_t_base_DP = value; }
        }

        /// <summary>
        /// Минимально допустимая теоретическая температура горения, °С
        /// </summary> 
        private double _Teor_t_base_DPmin;    // закрытая переменная класса 
        public double Teor_t_base_DPmin
        {
            get { return _Teor_t_base_DPmin; }
            set { _Teor_t_base_DPmin = value; }
        }

        /// <summary>
        /// Максимально допустимая теоретическая температура горения, °С
        /// </summary> 
        private double _Teor_t_base_DPmax;    // закрытая переменная класса 
        public double Teor_t_base_DPmax
        {
            get { return _Teor_t_base_DPmax; }
            set { _Teor_t_base_DPmax = value; }
        }


        /// <summary>
        /// Изменение производства чугуна при изменении ПГ, т чуг/(м3 ПГ)
        /// </summary> 
        private double _Proiz_chug_iz_PG_DP;    // закрытая переменная класса 
        public double Proiz_chug_iz_PG_DP
        {
            get { return _Proiz_chug_iz_PG_DP; }
            set { _Proiz_chug_iz_PG_DP = value; }
        }

        /// <summary>
        /// Изменение производства чугуна при увеличении расхода кокса, т чуг/(кг кокса)
        /// </summary> 
        private double _Proiz_chug_uvel_K_DP;    // закрытая переменная класса 
        public double Proiz_chug_uvel_K_DP
        {
            get { return _Proiz_chug_uvel_K_DP; }
            set { _Proiz_chug_uvel_K_DP = value; }
        }

        /// <summary>
        /// Изменение температуры горения при увеличении расхода ПГ на 1 м3/ч
        /// </summary> 
        private double _Iz_t_uvel_pg_DP;    // закрытая переменная класса 
        public double Iz_t_uvel_pg_DP
        {
            get { return _Iz_t_uvel_pg_DP; }
            set { _Iz_t_uvel_pg_DP = value; }
        }
        #endregion---Для ДП1
        
        #region--- Технологические параметры

        #region---Для ДП1
        /// <summary>
        /// Расход природного газа в базовом периоде, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DP_1;    // закрытая переменная класса 
        public double Rashod_PG_base_DP_1
        {
            get { return _Rashod_PG_base_DP_1; }
            set { _Rashod_PG_base_DP_1 = value; }
        }

        /// <summary>
        /// Минимально допустимый расход природного газа, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DPmin_1;    // закрытая переменная класса 
        public double Rashod_PG_base_DPmin_1
        {
            get { return _Rashod_PG_base_DPmin_1; }
            set { _Rashod_PG_base_DPmin_1 = value; }
        }

        /// <summary>
        /// Максимально допустимый расход природного газа, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DPmax_1;    // закрытая переменная класса 
        public double Rashod_PG_base_DPmax_1
        {
            get { return _Rashod_PG_base_DPmax_1; }
            set { _Rashod_PG_base_DPmax_1 = value; }
        }

        /// <summary>
        /// Расход кокса в базовом периоде, т/час
        /// </summary> 
        private double _Rashod_K_base_DP_1;    // закрытая переменная класса 
        public double Rashod_K_base_DP_1
        {
            get { return _Rashod_K_base_DP_1; }
            set { _Rashod_K_base_DP_1 = value; }
        }

        /// <summary>
        /// Эквивалент замены кокса в базовом периоде, кг кокса /(м3 ПГ)
        /// </summary> 
        private double _Rashod_K_base_DP_E_1;    // закрытая переменная класса 
        public double Rashod_K_base_DP_E_1
        {
            get { return _Rashod_K_base_DP_E_1; }
            set { _Rashod_K_base_DP_E_1 = value; }
        }

        /// <summary>
        /// Производительность по чугуну в базовом периоде, т /ч
        /// </summary> 
        private double _Proizvoditelnost_chug_base_DP_1;    // закрытая переменная класса 
        public double Proizvoditelnost_chug_base_DP_1
        {
            get { return _Proizvoditelnost_chug_base_DP_1; }
            set { _Proizvoditelnost_chug_base_DP_1 = value; }
        }

        /// <summary>
        /// Теоретическая температура горения в базовом периоде, °С
        /// </summary> 
        private double _Teor_t_base_DP_1;    // закрытая переменная класса 
        public double Teor_t_base_DP_1
        {
            get { return _Teor_t_base_DP_1; }
            set { _Teor_t_base_DP_1 = value; }
        }

        /// <summary>
        /// Минимально допустимая теоретическая температура горения, °С
        /// </summary> 
        private double _Teor_t_base_DPmin_1;    // закрытая переменная класса 
        public double Teor_t_base_DPmin_1
        {
            get { return _Teor_t_base_DPmin_1; }
            set { _Teor_t_base_DPmin_1 = value; }
        }

        /// <summary>
        /// Максимально допустимая теоретическая температура горения, °С
        /// </summary> 
        private double _Teor_t_base_DPmax_1;    // закрытая переменная класса 
        public double Teor_t_base_DPmax_1
        {
            get { return _Teor_t_base_DPmax_1; }
            set { _Teor_t_base_DPmax_1 = value; }
        }


        /// <summary>
        /// Изменение производства чугуна при изменении ПГ, т чуг/(м3 ПГ)
        /// </summary> 
        private double _Proiz_chug_iz_PG_DP_1;    // закрытая переменная класса 
        public double Proiz_chug_iz_PG_DP_1
        {
            get { return _Proiz_chug_iz_PG_DP_1; }
            set { _Proiz_chug_iz_PG_DP_1 = value; }
        }

        /// <summary>
        /// Изменение производства чугуна при увеличении расхода кокса, т чуг/(кг кокса)
        /// </summary> 
        private double _Proiz_chug_uvel_K_DP_1;    // закрытая переменная класса 
        public double Proiz_chug_uvel_K_DP_1
        {
            get { return _Proiz_chug_uvel_K_DP_1; }
            set { _Proiz_chug_uvel_K_DP_1 = value; }
        }

        /// <summary>
        /// Изменение температуры горения при увеличении расхода ПГ на 1 м3/ч
        /// </summary> 
        private double _Iz_t_uvel_pg_DP_1;    // закрытая переменная класса 
        public double Iz_t_uvel_pg_DP_1
        {
            get { return _Iz_t_uvel_pg_DP_1; }
            set { _Iz_t_uvel_pg_DP_1 = value; }
        }
        #endregion---Для ДП1

        #region---Для ДП2
        /// <summary>
        /// Расход природного газа в базовом периоде, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DP_2;    // закрытая переменная класса 
        public double Rashod_PG_base_DP_2
        {
            get { return _Rashod_PG_base_DP_2; }
            set { _Rashod_PG_base_DP_2 = value; }
        }

        /// <summary>
        /// Минимально допустимый расход природного газа, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DPmin_2;    // закрытая переменная класса 
        public double Rashod_PG_base_DPmin_2
        {
            get { return _Rashod_PG_base_DPmin_2; }
            set { _Rashod_PG_base_DPmin_2 = value; }
        }

        /// <summary>
        /// Максимально допустимый расход природного газа, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DPmax_2;    // закрытая переменная класса 
        public double Rashod_PG_base_DPmax_2
        {
            get { return _Rashod_PG_base_DPmax_2; }
            set { _Rashod_PG_base_DPmax_2 = value; }
        }

        /// <summary>
        /// Расход кокса в базовом периоде, т/час
        /// </summary> 
        private double _Rashod_K_base_DP_2;    // закрытая переменная класса 
        public double Rashod_K_base_DP_2
        {
            get { return _Rashod_K_base_DP_2; }
            set { _Rashod_K_base_DP_2 = value; }
        }

        /// <summary>
        /// Эквивалент замены кокса в базовом периоде, кг кокса /(м3 ПГ)
        /// </summary> 
        private double _Rashod_K_base_DP_E_2;    // закрытая переменная класса 
        public double Rashod_K_base_DP_E_2
        {
            get { return _Rashod_K_base_DP_E_2; }
            set { _Rashod_K_base_DP_E_2 = value; }
        }

        /// <summary>
        /// Производительность по чугуну в базовом периоде, т /ч
        /// </summary> 
        private double _Proizvoditelnost_chug_base_DP_2;    // закрытая переменная класса 
        public double Proizvoditelnost_chug_base_DP_2
        {
            get { return _Proizvoditelnost_chug_base_DP_2; }
            set { _Proizvoditelnost_chug_base_DP_2 = value; }
        }

        /// <summary>
        /// Теоретическая температура горения в базовом периоде, °С
        /// </summary> 
        private double _Teor_t_base_DP_2;    // закрытая переменная класса 
        public double Teor_t_base_DP_2
        {
            get { return _Teor_t_base_DP_2; }
            set { _Teor_t_base_DP_2 = value; }
        }

        /// <summary>
        /// Минимально допустимая теоретическая температура горения, °С
        /// </summary> 
        private double _Teor_t_base_DPmin_2;    // закрытая переменная класса 
        public double Teor_t_base_DPmin_2
        {
            get { return _Teor_t_base_DPmin_2; }
            set { _Teor_t_base_DPmin_2 = value; }
        }

        /// <summary>
        /// Максимально допустимая теоретическая температура горения, °С
        /// </summary> 
        private double _Teor_t_base_DPmax_2;    // закрытая переменная класса 
        public double Teor_t_base_DPmax_2
        {
            get { return _Teor_t_base_DPmax_2; }
            set { _Teor_t_base_DPmax_2 = value; }
        }


        /// <summary>
        /// Изменение производства чугуна при изменении ПГ, т чуг/(м3 ПГ)
        /// </summary> 
        private double _Proiz_chug_iz_PG_DP_2;    // закрытая переменная класса 
        public double Proiz_chug_iz_PG_DP_2
        {
            get { return _Proiz_chug_iz_PG_DP_2; }
            set { _Proiz_chug_iz_PG_DP_2 = value; }
        }

        /// <summary>
        /// Изменение производства чугуна при увеличении расхода кокса, т чуг/(кг кокса)
        /// </summary> 
        private double _Proiz_chug_uvel_K_DP_2;    // закрытая переменная класса 
        public double Proiz_chug_uvel_K_DP_2
        {
            get { return _Proiz_chug_uvel_K_DP_2; }
            set { _Proiz_chug_uvel_K_DP_2 = value; }
        }

        /// <summary>
        /// Изменение температуры горения при увеличении расхода ПГ на 2 м3/ч
        /// </summary> 
        private double _Iz_t_uvel_pg_DP_2;    // закрытая переменная класса 
        public double Iz_t_uvel_pg_DP_2
        {
            get { return _Iz_t_uvel_pg_DP_2; }
            set { _Iz_t_uvel_pg_DP_2 = value; }
        }
        #endregion---Для ДП2

        #region---Для ДП3
        /// <summary>
        /// Расход природного газа в базовом периоде, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DP_3;    // закрытая переменная класса 
        public double Rashod_PG_base_DP_3
        {
            get { return _Rashod_PG_base_DP_3; }
            set { _Rashod_PG_base_DP_3 = value; }
        }

        /// <summary>
        /// Минимально допустимый расход природного газа, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DPmin_3;    // закрытая переменная класса 
        public double Rashod_PG_base_DPmin_3
        {
            get { return _Rashod_PG_base_DPmin_3; }
            set { _Rashod_PG_base_DPmin_3 = value; }
        }

        /// <summary>
        /// Максимально допустимый расход природного газа, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DPmax_3;    // закрытая переменная класса 
        public double Rashod_PG_base_DPmax_3
        {
            get { return _Rashod_PG_base_DPmax_3; }
            set { _Rashod_PG_base_DPmax_3 = value; }
        }

        /// <summary>
        /// Расход кокса в базовом периоде, т/час
        /// </summary> 
        private double _Rashod_K_base_DP_3;    // закрытая переменная класса 
        public double Rashod_K_base_DP_3
        {
            get { return _Rashod_K_base_DP_3; }
            set { _Rashod_K_base_DP_3 = value; }
        }

        /// <summary>
        /// Эквивалент замены кокса в базовом периоде, кг кокса /(м3 ПГ)
        /// </summary> 
        private double _Rashod_K_base_DP_E_3;    // закрытая переменная класса 
        public double Rashod_K_base_DP_E_3
        {
            get { return _Rashod_K_base_DP_E_3; }
            set { _Rashod_K_base_DP_E_3 = value; }
        }

        /// <summary>
        /// Производительность по чугуну в базовом периоде, т /ч
        /// </summary> 
        private double _Proizvoditelnost_chug_base_DP_3;    // закрытая переменная класса 
        public double Proizvoditelnost_chug_base_DP_3
        {
            get { return _Proizvoditelnost_chug_base_DP_3; }
            set { _Proizvoditelnost_chug_base_DP_3 = value; }
        }

        /// <summary>
        /// Теоретическая температура горения в базовом периоде, °С
        /// </summary> 
        private double _Teor_t_base_DP_3;    // закрытая переменная класса 
        public double Teor_t_base_DP_3
        {
            get { return _Teor_t_base_DP_3; }
            set { _Teor_t_base_DP_3 = value; }
        }

        /// <summary>
        /// Минимально допустимая теоретическая температура горения, °С
        /// </summary> 
        private double _Teor_t_base_DPmin_3;    // закрытая переменная класса 
        public double Teor_t_base_DPmin_3
        {
            get { return _Teor_t_base_DPmin_3; }
            set { _Teor_t_base_DPmin_3 = value; }
        }

        /// <summary>
        /// Максимально допустимая теоретическая температура горения, °С
        /// </summary> 
        private double _Teor_t_base_DPmax_3;    // закрытая переменная класса 
        public double Teor_t_base_DPmax_3
        {
            get { return _Teor_t_base_DPmax_3; }
            set { _Teor_t_base_DPmax_3 = value; }
        }


        /// <summary>
        /// Изменение производства чугуна при изменении ПГ, т чуг/(м3 ПГ)
        /// </summary> 
        private double _Proiz_chug_iz_PG_DP_3;    // закрытая переменная класса 
        public double Proiz_chug_iz_PG_DP_3
        {
            get { return _Proiz_chug_iz_PG_DP_3; }
            set { _Proiz_chug_iz_PG_DP_3 = value; }
        }

        /// <summary>
        /// Изменение производства чугуна при увеличении расхода кокса, т чуг/(кг кокса)
        /// </summary> 
        private double _Proiz_chug_uvel_K_DP_3;    // закрытая переменная класса 
        public double Proiz_chug_uvel_K_DP_3
        {
            get { return _Proiz_chug_uvel_K_DP_3; }
            set { _Proiz_chug_uvel_K_DP_3 = value; }
        }

        /// <summary>
        /// Изменение температуры горения при увеличении расхода ПГ на 3 м3/ч
        /// </summary> 
        private double _Iz_t_uvel_pg_DP_3;    // закрытая переменная класса 
        public double Iz_t_uvel_pg_DP_3
        {
            get { return _Iz_t_uvel_pg_DP_3; }
            set { _Iz_t_uvel_pg_DP_3 = value; }
        }
        #endregion---Для ДП3

        #region---Для ДП4
        /// <summary>
        /// Расход природного газа в базовом периоде, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DP_4;    // закрытая переменная класса 
        public double Rashod_PG_base_DP_4
        {
            get { return _Rashod_PG_base_DP_4; }
            set { _Rashod_PG_base_DP_4 = value; }
        }

        /// <summary>
        /// Минимально допустимый расход природного газа, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DPmin_4;    // закрытая переменная класса 
        public double Rashod_PG_base_DPmin_4
        {
            get { return _Rashod_PG_base_DPmin_4; }
            set { _Rashod_PG_base_DPmin_4 = value; }
        }

        /// <summary>
        /// Максимально допустимый расход природного газа, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DPmax_4;    // закрытая переменная класса 
        public double Rashod_PG_base_DPmax_4
        {
            get { return _Rashod_PG_base_DPmax_4; }
            set { _Rashod_PG_base_DPmax_4 = value; }
        }

        /// <summary>
        /// Расход кокса в базовом периоде, т/час
        /// </summary> 
        private double _Rashod_K_base_DP_4;    // закрытая переменная класса 
        public double Rashod_K_base_DP_4
        {
            get { return _Rashod_K_base_DP_4; }
            set { _Rashod_K_base_DP_4 = value; }
        }

        /// <summary>
        /// Эквивалент замены кокса в базовом периоде, кг кокса /(м3 ПГ)
        /// </summary> 
        private double _Rashod_K_base_DP_E_4;    // закрытая переменная класса 
        public double Rashod_K_base_DP_E_4
        {
            get { return _Rashod_K_base_DP_E_4; }
            set { _Rashod_K_base_DP_E_4 = value; }
        }

        /// <summary>
        /// Производительность по чугуну в базовом периоде, т /ч
        /// </summary> 
        private double _Proizvoditelnost_chug_base_DP_4;    // закрытая переменная класса 
        public double Proizvoditelnost_chug_base_DP_4
        {
            get { return _Proizvoditelnost_chug_base_DP_4; }
            set { _Proizvoditelnost_chug_base_DP_4 = value; }
        }

        /// <summary>
        /// Теоретическая температура горения в базовом периоде, °С
        /// </summary> 
        private double _Teor_t_base_DP_4;    // закрытая переменная класса 
        public double Teor_t_base_DP_4
        {
            get { return _Teor_t_base_DP_4; }
            set { _Teor_t_base_DP_4 = value; }
        }

        /// <summary>
        /// Минимально допустимая теоретическая температура горения, °С
        /// </summary> 
        private double _Teor_t_base_DPmin_4;    // закрытая переменная класса 
        public double Teor_t_base_DPmin_4
        {
            get { return _Teor_t_base_DPmin_4; }
            set { _Teor_t_base_DPmin_4 = value; }
        }

        /// <summary>
        /// Максимально допустимая теоретическая температура горения, °С
        /// </summary> 
        private double _Teor_t_base_DPmax_4;    // закрытая переменная класса 
        public double Teor_t_base_DPmax_4
        {
            get { return _Teor_t_base_DPmax_4; }
            set { _Teor_t_base_DPmax_4 = value; }
        }


        /// <summary>
        /// Изменение производства чугуна при изменении ПГ, т чуг/(м3 ПГ)
        /// </summary> 
        private double _Proiz_chug_iz_PG_DP_4;    // закрытая переменная класса 
        public double Proiz_chug_iz_PG_DP_4
        {
            get { return _Proiz_chug_iz_PG_DP_4; }
            set { _Proiz_chug_iz_PG_DP_4 = value; }
        }

        /// <summary>
        /// Изменение производства чугуна при увеличении расхода кокса, т чуг/(кг кокса)
        /// </summary> 
        private double _Proiz_chug_uvel_K_DP_4;    // закрытая переменная класса 
        public double Proiz_chug_uvel_K_DP_4
        {
            get { return _Proiz_chug_uvel_K_DP_4; }
            set { _Proiz_chug_uvel_K_DP_4 = value; }
        }

        /// <summary>
        /// Изменение температуры горения при увеличении расхода ПГ на 4 м3/ч
        /// </summary> 
        private double _Iz_t_uvel_pg_DP_4;    // закрытая переменная класса 
        public double Iz_t_uvel_pg_DP_4
        {
            get { return _Iz_t_uvel_pg_DP_4; }
            set { _Iz_t_uvel_pg_DP_4 = value; }
        }
        #endregion---Для ДП4

        #region---Для ДП5
        /// <summary>
        /// Расход природного газа в базовом периоде, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DP_5;    // закрытая переменная класса 
        public double Rashod_PG_base_DP_5
        {
            get { return _Rashod_PG_base_DP_5; }
            set { _Rashod_PG_base_DP_5 = value; }
        }

        /// <summary>
        /// Минимально допустимый расход природного газа, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DPmin_5;    // закрытая переменная класса 
        public double Rashod_PG_base_DPmin_5
        {
            get { return _Rashod_PG_base_DPmin_5; }
            set { _Rashod_PG_base_DPmin_5 = value; }
        }

        /// <summary>
        /// Максимально допустимый расход природного газа, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DPmax_5;    // закрытая переменная класса 
        public double Rashod_PG_base_DPmax_5
        {
            get { return _Rashod_PG_base_DPmax_5; }
            set { _Rashod_PG_base_DPmax_5 = value; }
        }

        /// <summary>
        /// Расход кокса в базовом периоде, т/час
        /// </summary> 
        private double _Rashod_K_base_DP_5;    // закрытая переменная класса 
        public double Rashod_K_base_DP_5
        {
            get { return _Rashod_K_base_DP_5; }
            set { _Rashod_K_base_DP_5 = value; }
        }

        /// <summary>
        /// Эквивалент замены кокса в базовом периоде, кг кокса /(м3 ПГ)
        /// </summary> 
        private double _Rashod_K_base_DP_E_5;    // закрытая переменная класса 
        public double Rashod_K_base_DP_E_5
        {
            get { return _Rashod_K_base_DP_E_5; }
            set { _Rashod_K_base_DP_E_5 = value; }
        }

        /// <summary>
        /// Производительность по чугуну в базовом периоде, т /ч
        /// </summary> 
        private double _Proizvoditelnost_chug_base_DP_5;    // закрытая переменная класса 
        public double Proizvoditelnost_chug_base_DP_5
        {
            get { return _Proizvoditelnost_chug_base_DP_5; }
            set { _Proizvoditelnost_chug_base_DP_5 = value; }
        }

        /// <summary>
        /// Теоретическая температура горения в базовом периоде, °С
        /// </summary> 
        private double _Teor_t_base_DP_5;    // закрытая переменная класса 
        public double Teor_t_base_DP_5
        {
            get { return _Teor_t_base_DP_5; }
            set { _Teor_t_base_DP_5 = value; }
        }

        /// <summary>
        /// Минимально допустимая теоретическая температура горения, °С
        /// </summary> 
        private double _Teor_t_base_DPmin_5;    // закрытая переменная класса 
        public double Teor_t_base_DPmin_5
        {
            get { return _Teor_t_base_DPmin_5; }
            set { _Teor_t_base_DPmin_5 = value; }
        }

        /// <summary>
        /// Максимально допустимая теоретическая температура горения, °С
        /// </summary> 
        private double _Teor_t_base_DPmax_5;    // закрытая переменная класса 
        public double Teor_t_base_DPmax_5
        {
            get { return _Teor_t_base_DPmax_5; }
            set { _Teor_t_base_DPmax_5 = value; }
        }


        /// <summary>
        /// Изменение производства чугуна при изменении ПГ, т чуг/(м3 ПГ)
        /// </summary> 
        private double _Proiz_chug_iz_PG_DP_5;    // закрытая переменная класса 
        public double Proiz_chug_iz_PG_DP_5
        {
            get { return _Proiz_chug_iz_PG_DP_5; }
            set { _Proiz_chug_iz_PG_DP_5 = value; }
        }

        /// <summary>
        /// Изменение производства чугуна при увеличении расхода кокса, т чуг/(кг кокса)
        /// </summary> 
        private double _Proiz_chug_uvel_K_DP_5;    // закрытая переменная класса 
        public double Proiz_chug_uvel_K_DP_5
        {
            get { return _Proiz_chug_uvel_K_DP_5; }
            set { _Proiz_chug_uvel_K_DP_5 = value; }
        }

        /// <summary>
        /// Изменение температуры горения при увеличении расхода ПГ на 5 м3/ч
        /// </summary> 
        private double _Iz_t_uvel_pg_DP_5;    // закрытая переменная класса 
        public double Iz_t_uvel_pg_DP_5
        {
            get { return _Iz_t_uvel_pg_DP_5; }
            set { _Iz_t_uvel_pg_DP_5 = value; }
        }
        #endregion---Для ДП5

        #region---Для ДП6
        /// <summary>
        /// Расход природного газа в базовом периоде, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DP_6;    // закрытая переменная класса 
        public double Rashod_PG_base_DP_6
        {
            get { return _Rashod_PG_base_DP_6; }
            set { _Rashod_PG_base_DP_6 = value; }
        }

        /// <summary>
        /// Минимально допустимый расход природного газа, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DPmin_6;    // закрытая переменная класса 
        public double Rashod_PG_base_DPmin_6
        {
            get { return _Rashod_PG_base_DPmin_6; }
            set { _Rashod_PG_base_DPmin_6 = value; }
        }

        /// <summary>
        /// Максимально допустимый расход природного газа, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DPmax_6;    // закрытая переменная класса 
        public double Rashod_PG_base_DPmax_6
        {
            get { return _Rashod_PG_base_DPmax_6; }
            set { _Rashod_PG_base_DPmax_6 = value; }
        }

        /// <summary>
        /// Расход кокса в базовом периоде, т/час
        /// </summary> 
        private double _Rashod_K_base_DP_6;    // закрытая переменная класса 
        public double Rashod_K_base_DP_6
        {
            get { return _Rashod_K_base_DP_6; }
            set { _Rashod_K_base_DP_6 = value; }
        }

        /// <summary>
        /// Эквивалент замены кокса в базовом периоде, кг кокса /(м3 ПГ)
        /// </summary> 
        private double _Rashod_K_base_DP_E_6;    // закрытая переменная класса 
        public double Rashod_K_base_DP_E_6
        {
            get { return _Rashod_K_base_DP_E_6; }
            set { _Rashod_K_base_DP_E_6 = value; }
        }

        /// <summary>
        /// Производительность по чугуну в базовом периоде, т /ч
        /// </summary> 
        private double _Proizvoditelnost_chug_base_DP_6;    // закрытая переменная класса 
        public double Proizvoditelnost_chug_base_DP_6
        {
            get { return _Proizvoditelnost_chug_base_DP_6; }
            set { _Proizvoditelnost_chug_base_DP_6 = value; }
        }

        /// <summary>
        /// Теоретическая температура горения в базовом периоде, °С
        /// </summary> 
        private double _Teor_t_base_DP_6;    // закрытая переменная класса 
        public double Teor_t_base_DP_6
        {
            get { return _Teor_t_base_DP_6; }
            set { _Teor_t_base_DP_6 = value; }
        }

        /// <summary>
        /// Минимально допустимая теоретическая температура горения, °С
        /// </summary> 
        private double _Teor_t_base_DPmin_6;    // закрытая переменная класса 
        public double Teor_t_base_DPmin_6
        {
            get { return _Teor_t_base_DPmin_6; }
            set { _Teor_t_base_DPmin_6 = value; }
        }

        /// <summary>
        /// Максимально допустимая теоретическая температура горения, °С
        /// </summary> 
        private double _Teor_t_base_DPmax_6;    // закрытая переменная класса 
        public double Teor_t_base_DPmax_6
        {
            get { return _Teor_t_base_DPmax_6; }
            set { _Teor_t_base_DPmax_6 = value; }
        }


        /// <summary>
        /// Изменение производства чугуна при изменении ПГ, т чуг/(м3 ПГ)
        /// </summary> 
        private double _Proiz_chug_iz_PG_DP_6;    // закрытая переменная класса 
        public double Proiz_chug_iz_PG_DP_6
        {
            get { return _Proiz_chug_iz_PG_DP_6; }
            set { _Proiz_chug_iz_PG_DP_6 = value; }
        }

        /// <summary>
        /// Изменение производства чугуна при увеличении расхода кокса, т чуг/(кг кокса)
        /// </summary> 
        private double _Proiz_chug_uvel_K_DP_6;    // закрытая переменная класса 
        public double Proiz_chug_uvel_K_DP_6
        {
            get { return _Proiz_chug_uvel_K_DP_6; }
            set { _Proiz_chug_uvel_K_DP_6 = value; }
        }

        /// <summary>
        /// Изменение температуры горения при увеличении расхода ПГ на 6 м3/ч
        /// </summary> 
        private double _Iz_t_uvel_pg_DP_6;    // закрытая переменная класса 
        public double Iz_t_uvel_pg_DP_6
        {
            get { return _Iz_t_uvel_pg_DP_6; }
            set { _Iz_t_uvel_pg_DP_6 = value; }
        }
        #endregion---Для ДП6

        #region---Для ДП7
        /// <summary>
        /// Расход природного газа в базовом периоде, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DP_7;    // закрытая переменная класса 
        public double Rashod_PG_base_DP_7
        {
            get { return _Rashod_PG_base_DP_7; }
            set { _Rashod_PG_base_DP_7 = value; }
        }

        /// <summary>
        /// Минимально допустимый расход природного газа, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DPmin_7;    // закрытая переменная класса 
        public double Rashod_PG_base_DPmin_7
        {
            get { return _Rashod_PG_base_DPmin_7; }
            set { _Rashod_PG_base_DPmin_7 = value; }
        }

        /// <summary>
        /// Максимально допустимый расход природного газа, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DPmax_7;    // закрытая переменная класса 
        public double Rashod_PG_base_DPmax_7
        {
            get { return _Rashod_PG_base_DPmax_7; }
            set { _Rashod_PG_base_DPmax_7 = value; }
        }

        /// <summary>
        /// Расход кокса в базовом периоде, т/час
        /// </summary> 
        private double _Rashod_K_base_DP_7;    // закрытая переменная класса 
        public double Rashod_K_base_DP_7
        {
            get { return _Rashod_K_base_DP_7; }
            set { _Rashod_K_base_DP_7 = value; }
        }

        /// <summary>
        /// Эквивалент замены кокса в базовом периоде, кг кокса /(м3 ПГ)
        /// </summary> 
        private double _Rashod_K_base_DP_E_7;    // закрытая переменная класса 
        public double Rashod_K_base_DP_E_7
        {
            get { return _Rashod_K_base_DP_E_7; }
            set { _Rashod_K_base_DP_E_7 = value; }
        }

        /// <summary>
        /// Производительность по чугуну в базовом периоде, т /ч
        /// </summary> 
        private double _Proizvoditelnost_chug_base_DP_7;    // закрытая переменная класса 
        public double Proizvoditelnost_chug_base_DP_7
        {
            get { return _Proizvoditelnost_chug_base_DP_7; }
            set { _Proizvoditelnost_chug_base_DP_7 = value; }
        }

        /// <summary>
        /// Теоретическая температура горения в базовом периоде, °С
        /// </summary> 
        private double _Teor_t_base_DP_7;    // закрытая переменная класса 
        public double Teor_t_base_DP_7
        {
            get { return _Teor_t_base_DP_7; }
            set { _Teor_t_base_DP_7 = value; }
        }

        /// <summary>
        /// Минимально допустимая теоретическая температура горения, °С
        /// </summary> 
        private double _Teor_t_base_DPmin_7;    // закрытая переменная класса 
        public double Teor_t_base_DPmin_7
        {
            get { return _Teor_t_base_DPmin_7; }
            set { _Teor_t_base_DPmin_7 = value; }
        }

        /// <summary>
        /// Максимально допустимая теоретическая температура горения, °С
        /// </summary> 
        private double _Teor_t_base_DPmax_7;    // закрытая переменная класса 
        public double Teor_t_base_DPmax_7
        {
            get { return _Teor_t_base_DPmax_7; }
            set { _Teor_t_base_DPmax_7 = value; }
        }


        /// <summary>
        /// Изменение производства чугуна при изменении ПГ, т чуг/(м3 ПГ)
        /// </summary> 
        private double _Proiz_chug_iz_PG_DP_7;    // закрытая переменная класса 
        public double Proiz_chug_iz_PG_DP_7
        {
            get { return _Proiz_chug_iz_PG_DP_7; }
            set { _Proiz_chug_iz_PG_DP_7 = value; }
        }

        /// <summary>
        /// Изменение производства чугуна при увеличении расхода кокса, т чуг/(кг кокса)
        /// </summary> 
        private double _Proiz_chug_uvel_K_DP_7;    // закрытая переменная класса 
        public double Proiz_chug_uvel_K_DP_7
        {
            get { return _Proiz_chug_uvel_K_DP_7; }
            set { _Proiz_chug_uvel_K_DP_7 = value; }
        }

        /// <summary>
        /// Изменение температуры горения при увеличении расхода ПГ на 7 м3/ч
        /// </summary> 
        private double _Iz_t_uvel_pg_DP_7;    // закрытая переменная класса 
        public double Iz_t_uvel_pg_DP_7
        {
            get { return _Iz_t_uvel_pg_DP_7; }
            set { _Iz_t_uvel_pg_DP_7 = value; }
        }
        #endregion---Для ДП7

        #region---Для ДП8
        /// <summary>
        /// Расход природного газа в базовом периоде, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DP_8;    // закрытая переменная класса 
        public double Rashod_PG_base_DP_8
        {
            get { return _Rashod_PG_base_DP_8; }
            set { _Rashod_PG_base_DP_8 = value; }
        }

        /// <summary>
        /// Минимально допустимый расход природного газа, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DPmin_8;    // закрытая переменная класса 
        public double Rashod_PG_base_DPmin_8
        {
            get { return _Rashod_PG_base_DPmin_8; }
            set { _Rashod_PG_base_DPmin_8 = value; }
        }

        /// <summary>
        /// Максимально допустимый расход природного газа, м3/ч
        /// </summary> 
        private double _Rashod_PG_base_DPmax_8;    // закрытая переменная класса 
        public double Rashod_PG_base_DPmax_8
        {
            get { return _Rashod_PG_base_DPmax_8; }
            set { _Rashod_PG_base_DPmax_8 = value; }
        }

        /// <summary>
        /// Расход кокса в базовом периоде, т/час
        /// </summary> 
        private double _Rashod_K_base_DP_8;    // закрытая переменная класса 
        public double Rashod_K_base_DP_8
        {
            get { return _Rashod_K_base_DP_8; }
            set { _Rashod_K_base_DP_8 = value; }
        }

        /// <summary>
        /// Эквивалент замены кокса в базовом периоде, кг кокса /(м3 ПГ)
        /// </summary> 
        private double _Rashod_K_base_DP_E_8;    // закрытая переменная класса 
        public double Rashod_K_base_DP_E_8
        {
            get { return _Rashod_K_base_DP_E_8; }
            set { _Rashod_K_base_DP_E_8 = value; }
        }

        /// <summary>
        /// Производительность по чугуну в базовом периоде, т /ч
        /// </summary> 
        private double _Proizvoditelnost_chug_base_DP_8;    // закрытая переменная класса 
        public double Proizvoditelnost_chug_base_DP_8
        {
            get { return _Proizvoditelnost_chug_base_DP_8; }
            set { _Proizvoditelnost_chug_base_DP_8 = value; }
        }

        /// <summary>
        /// Теоретическая температура горения в базовом периоде, °С
        /// </summary> 
        private double _Teor_t_base_DP_8;    // закрытая переменная класса 
        public double Teor_t_base_DP_8
        {
            get { return _Teor_t_base_DP_8; }
            set { _Teor_t_base_DP_8 = value; }
        }

        /// <summary>
        /// Минимально допустимая теоретическая температура горения, °С
        /// </summary> 
        private double _Teor_t_base_DPmin_8;    // закрытая переменная класса 
        public double Teor_t_base_DPmin_8
        {
            get { return _Teor_t_base_DPmin_8; }
            set { _Teor_t_base_DPmin_8 = value; }
        }

        /// <summary>
        /// Максимально допустимая теоретическая температура горения, °С
        /// </summary> 
        private double _Teor_t_base_DPmax_8;    // закрытая переменная класса 
        public double Teor_t_base_DPmax_8
        {
            get { return _Teor_t_base_DPmax_8; }
            set { _Teor_t_base_DPmax_8 = value; }
        }


        /// <summary>
        /// Изменение производства чугуна при изменении ПГ, т чуг/(м3 ПГ)
        /// </summary> 
        private double _Proiz_chug_iz_PG_DP_8;    // закрытая переменная класса 
        public double Proiz_chug_iz_PG_DP_8
        {
            get { return _Proiz_chug_iz_PG_DP_8; }
            set { _Proiz_chug_iz_PG_DP_8 = value; }
        }

        /// <summary>
        /// Изменение производства чугуна при увеличении расхода кокса, т чуг/(кг кокса)
        /// </summary> 
        private double _Proiz_chug_uvel_K_DP_8;    // закрытая переменная класса 
        public double Proiz_chug_uvel_K_DP_8
        {
            get { return _Proiz_chug_uvel_K_DP_8; }
            set { _Proiz_chug_uvel_K_DP_8 = value; }
        }

        /// <summary>
        /// Изменение температуры горения при увеличении расхода ПГ на 8 м3/ч
        /// </summary> 
        private double _Iz_t_uvel_pg_DP_8;    // закрытая переменная класса 
        public double Iz_t_uvel_pg_DP_8
        {
            get { return _Iz_t_uvel_pg_DP_8; }
            set { _Iz_t_uvel_pg_DP_8 = value; }
        }
        #endregion---Для ДП8

        #region---Показатели

        /// <summary>
        /// Стоимость кокса, руб/(кг кокса)
        /// </summary> 
        private double _Stoimoct_k;    // закрытая переменная класса 
        public double Stoimoct_k
        {
            get { return _Stoimoct_k; }
            set { _Stoimoct_k = value; }
        }

        /// <summary>
        /// Стоимость природного газа, руб/(м3 ПГ)
        /// </summary> 
        private double _Stoimoct_pg;    // закрытая переменная класса 
        public double Stoimoct_pg
        {
            get { return _Stoimoct_pg; }
            set { _Stoimoct_pg = value; }
        }

        /// <summary>
        /// Резерв по расходу природного газа в целом по цеху, м3/ч 
        /// </summary> 
        private double _Rezerf_rashod_pg;    // закрытая переменная класса 
        public double Rezerf_rashod_pg
        {
            get { return _Rezerf_rashod_pg; }
            set { _Rezerf_rashod_pg = value; }
        }

        /// <summary>
        /// Запасы кокса по цеху, т/ч
        /// </summary> 
        private double _Zapas_k;    // закрытая переменная класса 
        public double Zapas_k
        {
            get { return _Zapas_k; }
            set { _Zapas_k = value; }
        }

        /// <summary>
        /// Требуемое производство чугуна в цехе, т/ч
        /// </summary> 
        private double _Treb_proiz_chug;    // закрытая переменная класса 
        public double Treb_proiz_chug
        {
            get { return _Treb_proiz_chug; }
            set { _Treb_proiz_chug = value; }
        }
        #endregion--- Показатели

        #endregion---Технологические параметры

        #region---

        public double xId { get; set; }

        public double Koef { get; set; }
        
        public double KoefNerav1 { get; set; }

        public double KoefNerav11 { get; set; }

        public double KoefNerav2 { get; set; }

        public double KoefNerav22 { get; set; }

        public double KoefNerav3 { get; set; }

        public double KoefNerav33 { get; set; }
        #endregion---

        #region---
        public double DP1 { get; set; }
        public double DP2 { get; set; }
        public double DP3 { get; set; }
        public double DP4 { get; set; }
        public double DP5 { get; set; }
        public double DP6 { get; set; }
        public double DP7 { get; set; }
        public double DP8 { get; set; }
        #endregion---


    }
}
