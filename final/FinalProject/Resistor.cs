using System;


public class Resistor : Part {
    private string _resistance;
    private string _powerWatts;
    
    public Resistor() {
        Console.Write("What is the resistance of the resistor? ");
        _resistance = Console.ReadLine();

        Console.Write("What is the power rating in Watts? ");
        _powerWatts = Console.ReadLine();
    }

    public Resistor(string maker, string package, string tolerance, string resistance, string powerWatts, int quantity): base(maker, package, tolerance, quantity) {
        _resistance = resistance;
        _powerWatts = powerWatts;
    }


    protected string GetResistance() {
        return _resistance;
    }

    protected string GetPowerWatts() {
        return _powerWatts;
    }    



    public override void AddPart() {
        
    }

    public override string GetInfo() {
        return $"{GetManufacturer()},{GetPackage()},{GetTolerance()}, {GetResistance()}, {GetPowerWatts()}";
    }

    public override string DisplayPart() {
        return $"Resistor : Manufacturer: {GetManufacturer()} Package: {GetPackage()} Tolerance: {GetTolerance()} Resistance: {GetResistance()} Power: {GetPowerWatts()}";
    }
}