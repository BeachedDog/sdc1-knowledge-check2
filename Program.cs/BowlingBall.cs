using System;

public class BowlingBall : Ball
{
    public string? Name { get; set; }
    public int Weight { get; set; }
    public bool IsAsymetric { get; set; }

     override public string ToString()
    {
        return $"Manufacturer: {this.Manufacturer}, Ball name: {this.Name}, Asymetrical: {this.IsAsymetric}, Weight: {this.Weight} ";
    }
}

