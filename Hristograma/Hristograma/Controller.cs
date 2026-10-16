using System;
using System.Collections.Generic;
using System.Text;

namespace Hristograma
{
    public class Controller
    {
        Model currentModel = new Model();
        View currentView = new View();
        public void Start()
        {
            currentView.InputInfo();
            currentModel.Num = currentView.Num;
            currentModel.Calculate();
            currentView.P1 = currentModel.P1;
            currentView.P2 = currentModel.P2;
            currentView.P3 = currentModel.P3;
            currentView.P4 = currentModel.P4;
            currentView.P5 = currentModel.P5;
            currentView.OutputInfo();
        }
    }
}
