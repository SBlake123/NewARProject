using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPokemonList : MonoBehaviour
{
    public static NewPokemonList instance;
    private void Awake()
    {
        instance = this;
    }
    public List<NewPokemon> newPokemonList;
}
