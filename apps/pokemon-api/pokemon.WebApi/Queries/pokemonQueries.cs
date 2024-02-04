using _PokemonApi.PokemonData.Types;

namespace _PokemonApi.PokemonWebapi
{
  public class Query
  {
    public Pokemon GetAllPokemon()
    {
      return new Pokemon
      {
        Name = "Bulbi"
      };
    }
  }
}
