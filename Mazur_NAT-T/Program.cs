using Mazur_NAT_T.Controllers;
using Mazur_NAT_T.Views;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Mazur_NAT_T
{
    static class Program
    {
        /// <summary>
        /// Main entry point of app.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Form> views = new List<Form>();

            HolePunchingView hpView = new HolePunchingView();
            HolePunchingController hpc = new HolePunchingController(hpView);
            hpc.Init();

            PortMappingView pmView = new PortMappingView();
            PortMappingController pmc = new PortMappingController(pmView);
            _ = pmc.ListMappings();
            

            IntroView iView = new IntroView();

            AnimationsView aView = new AnimationsView();

            views.Add(hpView);
            views.Add(pmView);
            views.Add(iView);
            views.Add(aView);

            Application.EnableVisualStyles();
            
            Application.Run(new MainMenuView(views, hpc));
        }
    }
}
