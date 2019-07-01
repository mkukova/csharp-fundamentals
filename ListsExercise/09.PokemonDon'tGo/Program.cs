using System;
using System.Linq;
using System.Collections.Generic;

namespace _09.PokemonDon_tGo
{
	class Program
	{
		static List<int> ChangePokemonsValue(List<int> pokemons, int removedPokemon)
		{
			for (int i = 0; i < pokemons.Count; i++)
			{
				if (pokemons[i] <= removedPokemon)
				{
					pokemons[i] += removedPokemon;
				}
				else
				{
					pokemons[i] -= removedPokemon;
				}
			}

			return pokemons;
		}

		static void Main(string[] args)
		{
			List<int> pokemons = Console.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToList();

			int sumOfRemovedPokemons = 0;

			while (pokemons.Count > 0)
			{
				int index = int.Parse(Console.ReadLine());

				if (index < 0)
				{
					int pokemonToRemove = pokemons[0];
					sumOfRemovedPokemons += pokemonToRemove;
					pokemons[0] = pokemons[pokemons.Count - 1];
					ChangePokemonsValue(pokemons, pokemonToRemove);
				}
				else if (index >= pokemons.Count)
				{
					int pokemonToRemove = pokemons[pokemons.Count - 1];
					sumOfRemovedPokemons += pokemonToRemove;
					pokemons[pokemons.Count - 1] = pokemons[0];
					ChangePokemonsValue(pokemons, pokemonToRemove);
				}
				else
				{
					int pokemonToRemove = pokemons[index];
					sumOfRemovedPokemons += pokemonToRemove;
					pokemons.RemoveAt(index);
					ChangePokemonsValue(pokemons, pokemonToRemove);
				}
			}

			Console.WriteLine(sumOfRemovedPokemons);
		}
	}
}
