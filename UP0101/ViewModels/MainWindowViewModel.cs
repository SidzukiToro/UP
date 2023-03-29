using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UP0101.ViewModels.Base;

namespace UP0101.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовко окна
        private string _Title = "Анализ статистики UP0101";

        /// <summary>Заголовок окна</summary>
        public string Title
        {
            get => _Title;
            //set
            //{
                //if (Equals(_Title, value)) return;
                //_Title = value;
                //OnPropertyChanged();

                //Set(ref _Title, value); 

            //}
            set => Set(ref _Title, value);
        }
        #endregion
    }
}
