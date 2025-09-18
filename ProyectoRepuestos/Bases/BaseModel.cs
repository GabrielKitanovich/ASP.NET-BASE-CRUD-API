namespace ProyectoRepuestos.Bases;

public class BaseModel
{

    public int Id { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
}
