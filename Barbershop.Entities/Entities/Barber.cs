namespace Barbershop.Entities.Entities;

public class Barber
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Cpf { get; set; }

    public List<Appointment> Appointments { get; set; }
    public List<BarberSchedule> BarberSchedules { get; set; }
}