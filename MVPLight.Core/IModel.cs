using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;

namespace MVPLight.Core
{
    public interface IModel:INotifyPropertyChanged
    {
    }

    public class ModelBase : IModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ModelBase()
        {

        }

        public ModelBase(Action<Action<object>> action)
        {
            this._synInvoker = action;
        }

        private readonly Action<Action<object>> _synInvoker;

        public void SynInvoker(string propertyName)
        {
            if (_synInvoker != null)
                _synInvoker.Invoke((x) => OnPropertyChanged(propertyName));
            else
                OnPropertyChanged(propertyName);
        }
    }
}
