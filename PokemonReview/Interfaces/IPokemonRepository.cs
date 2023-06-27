using PokemonReview.Dto;
using PokemonReview.Models;

namespace PokemonReview.Interfaces
{
    public interface IPokemonRepository
    {
        ICollection<Pokemon> GetPokemons();
        Pokemon GetPokemon(int id);
        Pokemon GetPokemon(string name);
        bool PokemonExists(int pokeId);
        decimal GetPokemonRating(int pokeId);
        Pokemon GetPokemonTrimToUpper(PokemonDto pokemonCreate);

        bool CreatePokemon(int ownerId, int categoryId, Pokemon pokemon);

    }
}
