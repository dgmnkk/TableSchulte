using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace TableSchulte.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class ViewModel
    {
        private int numberOfElements = 49;
        public ObservableCollection<Number> numbers;
        public ViewModel()
        {
            numbers = new ObservableCollection<Number>();
            Random random = new Random();
            for (int i = 1; i < 50; i++)
            {
                numbers.Add(new Number(i));
            }
            int emptyIndex = 24;

            for (int i = numbers.Count - 1; i > 0; i--)
            {
                if (i == emptyIndex)
                {
                    numbers[i] = null;
                }
                else
                {
                    int j = random.Next(i + 1);
                    Number temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }


    }

}
