using System;
using System.Collections.Generic;
using System.Text;

namespace MVPLight.Core
{
    public class Presenter<TView,TModel> where TView:class,IView where TModel:class,IModel, new()
    {
        public Presenter(TView view)
        {
            this.View = view;
            InitModel();
            OnViewSet();
        }

        public TView View { get; private set; }
        public TModel Model { get; set; }

        protected virtual void OnViewSet()
        {
            
        }

        protected virtual void InitModel()
        {
            Model = new TModel();
        }
    }
}
