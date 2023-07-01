using System.Collections.Generic;


namespace Mazur_NAT_T.Controllers
{
    public interface IPortMappingView
    {
        void SetController(PortMappingController pmc);
        void ShowMessageBox(string message);
        void AddToCheckBox(string item);

        void ClearCheckBox();
        List<string> CheckedItems();

    }
}
