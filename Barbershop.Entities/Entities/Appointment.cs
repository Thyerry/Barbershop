namespace Barbershop.Entities.Entities;

public class Appointment
{
    public long Id { get; set; }
    public long ClientId { get; set; }
    public long BarberId { get; set; }
    public long BarberScheduleId { get; set; }

    public Client Client { get; set; }
    public Barber Barber { get; set; }
    public BarberSchedule BarberSchedule { get; set; }
}