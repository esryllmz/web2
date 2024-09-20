
namespace Miras;

public class Biycle: Vecihle
{

    public string CarpetType { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Teker Sayısı: {NumberOfWheels}, Rengi: {ColorNames}, Sepet Türü: {CarpetType}";
    }

}
