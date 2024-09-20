
namespace Miras;

public  sealed class Truck:Vecihle
{
    public string FuelType { get; set; }
    public int NumberOfDoor { get; set; }
    public double MotorVolume { get; set; }
    public bool Dorse { get; set; }

    public override string ToString()
    {
        return $" ID:{Id}, Teker Sayısı:{NumberOfWheels}," +
            $" Rengi:{ColorNames}, Yakıt Tipi: {FuelType}, " +
            $"Kapı Sayısı: {NumberOfDoor}, Motor Hacmi: {MotorVolume}, Dorse  Varmı:{Dorse}";



    }

}
