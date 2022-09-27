using System;

static class AssemblyLine
{
    private const int CARS_PER_HOUR = 221;
    private static int CarsBySpeed(int speed) => 
        CARS_PER_HOUR * speed;

    public static double SuccessRate(int speed) =>  
        speed switch
        {
            0 => 0,
            <= 4 => 1,
            <= 8 => 0.9,
            9 => 0.8,
            10 => 0.77,
            _ => 0
        };

    public static double ProductionRatePerHour(int speed) => 
        CarsBySpeed(speed) * SuccessRate(speed);

    public static int WorkingItemsPerMinute(int speed) => 
        (int) Math.Floor(ProductionRatePerHour(speed) / 60);
}
