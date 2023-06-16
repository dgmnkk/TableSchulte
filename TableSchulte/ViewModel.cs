using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace TableSchulte
{
    [AddINotifyPropertyChangedInterface]
    public class ViewModel
    {
        private int numberOfElements = 49;
        public ObservableCollection<Number> numbers;
        public ObservableCollection<SolidColorBrush> colors;
        private List<SolidColorBrush> tmpColors = new List<SolidColorBrush>()
        {
            new SolidColorBrush(Color.FromArgb(255, 249, 248, 249)),
            new SolidColorBrush(Color.FromArgb(255, 199, 85, 111)),
            new SolidColorBrush(Color.FromArgb(255, 174, 128, 246)),
            new SolidColorBrush(Color.FromArgb(255, 121, 152, 203)),
            new SolidColorBrush(Color.FromArgb(255, 231, 193, 65)),
            new SolidColorBrush(Color.FromArgb(255, 170, 212, 88))
        };

        public ViewModel()
        {
            numbers = new ObservableCollection<Number>();
            Random random = new Random();
            for (int i = 1; i <= numberOfElements; i++)
            {
                numbers.Add(new Number { number = random.Next(1, numberOfElements) });
            }

            colors = new ObservableCollection<SolidColorBrush>();
            for (int i = 0; i < numberOfElements; i++)
            {
                colors.Add(tmpColors[i % 5]);
            }
            for (int i = 0; i < numberOfElements; i++)
            {
                int randIndex = random.Next(colors.Count);
                SolidColorBrush temp = colors[i];
                colors[i] = colors[randIndex];
                colors[randIndex] = temp;

            }
        }

        
    }
}
