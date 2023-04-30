using demoLINQ.Models;

namespace demoLINQ.Stubs;

public class AnimalStub
{
    private List<AnimalModel> _animals = new List<AnimalModel>();

    public AnimalStub()
    {   
        InitializeAnimalData();
    }

    public IEnumerable<AnimalModel> GetAnimals()
    {
        return _animals;
    }
    private void InitializeAnimalData()
    {
        _animals.Add(new AnimalModel() { Name = "Hormiga", Color = "Rojo" });
        _animals.Add(new AnimalModel() { Name = "Lobo", Color = "Gris" });
        _animals.Add(new AnimalModel() { Name = "Elefante", Color = "Gris" });
        _animals.Add(new AnimalModel() { Name = "Pantegra", Color = "Negro" });
        _animals.Add(new AnimalModel() { Name = "Gato", Color = "Negro" });
        _animals.Add(new AnimalModel() { Name = "Iguana", Color = "Verde" });
        _animals.Add(new AnimalModel() { Name = "Sapo", Color = "Verde" });
        _animals.Add(new AnimalModel() { Name = "Camaleon", Color = "Verde" });
        _animals.Add(new AnimalModel() { Name = "Gallina", Color = "Blanco" });
    }

}