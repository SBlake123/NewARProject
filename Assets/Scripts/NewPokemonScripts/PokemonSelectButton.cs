using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PokemonSelectButton : MonoBehaviour
{
    public List<NewPokemon> newPokemons;
    public List<Button> buttons;
    public List<Text> texts;
    public List<Image> images;

    public CaptureManager captureManager;

    private void Start()
    {
        PokemonLoad();
    }

    public void PokemonLoad()
    {
        //리소스와 같은 친구들을 비교하고 소환하기
        foreach (var item in captureManager.playerImageList)
        {
            GameObject loadingObj = (Resources.Load<GameObject>(item.name));
            newPokemons.Add(loadingObj.GetComponent<NewPokemon>());
        }

        for(int i = 0; i < newPokemons.Count; i++)
        {
            if (newPokemons[i] is NewMewtwo)
            {
                texts[i].text = ((NewMewtwo)newPokemons[i]).pokeName;
                images[i].sprite = Resources.Load<Sprite>(($"Images.{((NewMewtwo)newPokemons[i]).pokeName.ToUpper()}"));
            }
            else if (newPokemons[i] is NewPikachu)
            {
                texts[i].text = ((NewPikachu)newPokemons[i]).pokeName;
                images[i].sprite = Resources.Load<Sprite>(($"Images.{((NewPikachu)newPokemons[i]).pokeName.ToUpper()}"));
            }

            if (newPokemons == null)
            {
                texts[0].text = "null";
            }
        }
    }

    public void ButtonSelect(int i)
    {
        switch (i)
        {
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
        }
    }
}
