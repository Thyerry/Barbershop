namespace Barbershop.Entities.Entities;

public class BarberSchedule
{
    public long Id { get; set; }
    public long BarberId { get; set; }
    public string StartTime { get; set; }
    public string EndTime { get; set; }
    public string DayOfWeek { get; set; }
}