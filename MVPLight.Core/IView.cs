using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MVPLight.Core
{
    public interface IView
    {
        void Close();
        void Load();
        Form GetInstance();      
    }
    public interface IView<IModel>:IView
    {
        void BindData(IModel model);
    }
}
