// muratONUR murat ONUR karadeniz
// Tuba DataObjects  DaoFactories.cs
// 201312146:29 PM
// 201312146:29 PM
namespace DataObjects
{
    class DaoFactories
    {
        public static IDaoFactory GetFactory(string dataProvider)
        {


            return new EntityFramework.Implementation.EntityDaoFactory();
        }

    }
}



