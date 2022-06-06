using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseClasses
{
    public class Converter
    {
        public readonly double _Usd;
        public readonly double _Rub;
        public readonly double _Eur;
        public Converter(double usd,double rub, double eur)
        {
            _Usd = usd;
            _Rub = rub;
            _Eur = eur;
        }
        public double ConvertToAMD(double amd, string valyut)
        {
            switch (valyut)
            {
                case "Usd":
                    return amd * _Usd;
                case "Rub":
                    return amd * _Rub;
                case "Eur":
                    return amd * _Eur;
                default:
                    return 0;
            }
        }
        public double ConvertToValyut(double amd, string valyut)
        {
            switch (valyut)
            {
                case "Usd":
                    return amd / _Usd + amd % _Usd;
                case "Rub":
                    return amd / _Rub + amd % _Rub;
                case "Eur":
                    return amd / _Eur + amd % _Eur;
                default:
                    return 0;
            }
        }
    }
}
