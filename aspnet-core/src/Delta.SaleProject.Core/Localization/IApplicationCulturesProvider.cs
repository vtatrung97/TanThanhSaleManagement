using System.Globalization;

namespace Delta.SaleProject.Localization
{
    public interface IApplicationCulturesProvider
    {
        CultureInfo[] GetAllCultures();
    }
}