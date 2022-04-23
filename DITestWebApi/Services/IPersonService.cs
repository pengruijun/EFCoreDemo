namespace DITestWebApi.Services;

public interface IPersonService
{
    void ChangeName(Person person);
}

public class PersonService : IPersonService
{
    public void ChangeName(Person person)
    {
        person.Firstname = "oscar";
    }
}