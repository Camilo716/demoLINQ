using demoLINQ.Models;
using demoLINQ.Mocks;
namespace demoLINQ.Data;

public class AnimalDataAccess
{
    private List<AnimalModel> _animals;
    
    public AnimalDataAccess()
    {
        var animalMock = new AnimalMock();

        _animals = animalMock.GetAnimals().ToList();
    }
}