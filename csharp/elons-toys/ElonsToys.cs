using System;

class RemoteControlCar
{
    private readonly int DRIVE_METERS = 20;
    private int Battery { get; set; }
    private int Distance { get; set; }

    public RemoteControlCar()
    {
        this.Battery = 100;
        this.Distance = 0;
    }
    public static RemoteControlCar Buy() => new();

    public string DistanceDisplay() => $"Driven {this.Distance} meters";

    public string BatteryDisplay() => this.Battery == 0 ? "Battery empty" : $"Battery at {this.Battery}%";

    public void Drive()
    {
        if (this.Battery == 0) return;
        this.Battery--;
        this.Distance += DRIVE_METERS;
    }
}
