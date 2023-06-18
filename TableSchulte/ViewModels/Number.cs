using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableSchulte.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class Number
    {
        public int? number { get; set; }
        public ColorCell color { get; set; }
        private static Random rnd = new();
        public Number() { }
        public Number(int? value)
        {
            number = value;
            color = number != null ? GetRandom() : ColorCell.White;
        }

        private static ColorCell GetRandom()
        {
            return (ColorCell)rnd.Next(Enum.GetValues(typeof(ColorCell)).Length);
        }
    }

    public enum ColorCell
    {
        White, Yellow, Green, Blue, Red, Purple
    }
}
