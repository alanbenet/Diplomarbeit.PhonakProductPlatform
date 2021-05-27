using System.Collections.Generic;

namespace PPP.Models
{
    public interface IAccessoryRepo
    {
        List<Accessory> GetAllAccessoires();
    }
}
