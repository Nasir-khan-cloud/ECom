using BeratenECommerceDomain.Models;

namespace BeratenECommerceDataAccess.Ifaces
{
    public interface IItem
    {
        Item GetItem(int id);
        IList<Item> GetIAlltems(string filter);
    }
}
