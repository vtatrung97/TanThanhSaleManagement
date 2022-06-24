using Xamarin.Forms.Internals;

namespace Delta.SaleProject.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}