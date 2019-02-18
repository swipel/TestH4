using MikkelsPølsevogn.Items;

namespace MikkelsPølsevogn.Heaters
{
    public interface ICookingDevice
    {
        void StartCooking(Food food);
    }
}