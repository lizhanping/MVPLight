using MVPLight.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVPLight.WinForm
{
    public class MainFormPresenter : Presenter<IMainFormView,MainFormModel>
    {
        public MainFormPresenter(IMainFormView view) : base(view)
        {
            this.View.BindData(this.Model);
        }

        protected override void OnViewSet()
        {
            //base.OnViewSet();
        }

        protected override void InitModel()
        {
            base.InitModel();
            this.Model.FirstName = "zhanping";
            this.Model.LastName = "li";
        }
    }
}
