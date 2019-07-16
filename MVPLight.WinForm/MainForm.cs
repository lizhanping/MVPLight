using MVPLight.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MVPLight.WinForm
{
    public partial class MainForm:Form,IMainFormView
    {
        public MainForm()
        {
            InitializeComponent();
            MainFormPresenter p = new MainFormPresenter(this);
        }


        public void BindData(MainFormModel model)
        {
            this.textBox1.DataBindings.Add("Text",model,"FirstName",false,DataSourceUpdateMode.OnPropertyChanged);
            this.textBox2.DataBindings.Add("Text", model, "LastName",false,DataSourceUpdateMode.OnPropertyChanged);
            this.label1.DataBindings.Add("Text", model, "Name");
        }

        public Form GetInstance()
        {
            return this;
        }

        void IView.Load()
        {
            throw new NotImplementedException();
        }
    }
}
