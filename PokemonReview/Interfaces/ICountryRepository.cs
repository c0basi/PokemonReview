using PokemonReview.Models;

namespace PokemonReview.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryByOwner(int ownerId);
        bool CountryExists(int id);
        ICollection<Owner> GetOwnersFromAcountry(int countryId);
    }
}
