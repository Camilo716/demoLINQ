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


    public IEnumerable<AnimalModel> GetGreenAnimalsWhichNameStartWithVowel()
    {
        List<char> vowels = new List<char>(){'a','e','i','o','u'};

        Func<AnimalModel, bool> filterStartsWithVocal = animals => {
           for (int i = 0; i < vowels.Count(); i++)
           {
                if (animals.Name.ToLower().StartsWith(vowels[i]))
                {
                    return true;
                }
           }
           return false;
        };

        return _animals.Where(a => a.Color.ToLower() == "verde" && filterStartsWithVocal(a));      
    }
}
