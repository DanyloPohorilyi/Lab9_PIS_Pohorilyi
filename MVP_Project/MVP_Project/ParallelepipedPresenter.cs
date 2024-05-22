using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Project
{
    class ParallelepipedPresenter
    {
        private readonly IParallelepipedView view;
        private readonly IParallelepipedModel model;

        public ParallelepipedPresenter(IParallelepipedView view, IParallelepipedModel model)
        {
            this.model = model;
            this.view = view;
        }

        public void LoadParallelepiped(double a, double b, double h)
        {
            var parallelepiped = new Parallelepiped(a, b, h);
            view.SetS(parallelepiped.S());
            view.SetV(parallelepiped.V());
        }
    }
}
