using Records;
using System.Numerics;

Car car = new Car(Plate: "44 NB 941",
    Kilometer: 15000,
    Model:new Model(2020,"Volvo s60"));

Model model = new Model(2021, "Porshe");

Car car1 = new Car("34 AS 941", 35000,model);


Console.WriteLine(car);
Console.WriteLine(car1);


Car[] cars = new Car[] {car,car1};

Console.WriteLine(cars);

foreach (Car item  in cars )
{
    Console.WriteLine(item.Plate);
}

Array.ForEach (cars, x =>
{
    Console.WriteLine(x);
});



