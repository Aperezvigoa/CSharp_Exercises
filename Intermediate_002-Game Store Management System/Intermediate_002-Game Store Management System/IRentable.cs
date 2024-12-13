public interface IRentable
{
    string Status { get; set; }

    void Rent();
    void Return();
}