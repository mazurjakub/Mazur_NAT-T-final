

namespace Mazur_NAT_T.Controllers
{
    public interface IHolePunchingView
    {
        void SetController(HolePunchingController hpc);
        void WriteToTextBox(string message);
        void ClearTextBox();
        void ShowMessageBox(string message);
    }
}
