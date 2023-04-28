using demoLINQ.Models;
using demoLINQ.Mocks;
namespace demoLINQ.Data;

public class AnimalDataAccess
{
    private List<AnimalModel> _animals;
    
    public AnimalDataAccess()
    {
        var AnimalStub = new AnimalStub();

        _animals = AnimalStub.GetAnimals().ToList();
    }
}