using System;


public class ThroughHoleResistor : Resistor {
    private string _tempCoefficient;


    public ThroughHoleResistor() {
        Console.Write("What is the temperture coefficient value of the resistor? ");
        _tempCoefficient = Console.ReadLine();
    }
    
    public ThroughHoleResistor(string maker, string package, string tolerance, string resistance, string powerWatts, string tempCoefficient, int quantity): base(maker, package, tolerance, resistance, powerWatts, quantity) {
        _tempCoefficient = tempCoefficient;
    }


    public string GetTempCoefficient() {
        return _tempCoefficient;
    }


    public override void AddPart() {
        
    }

    public override string GetInfo() {
        return "";
    }

    public override string DisplayPart() {
        return "";
    }
}