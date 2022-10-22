using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PokemonSelectButton : MonoBehaviour
{
    public List<NewPokemon> newPokemons;
    public CaptureManager captureManager;
    public List<Button> buttons;

    public void PokemonLoad()
    {
        //리소스와 같은 친구들을 비교하고 소환하기
        foreach (var item in captureManager.playerImageList)
        {
            GameObject loadingObj = (GameObject)Resources.Load(item.name);
            newPokemons.Add(loadingObj.GetComponent<NewPokemon>());
        }

        for(int i = 0; i < newPokemons.Count; i++)
        {
            if (newPokemons[i] is NewMewtwo)
            {
                buttons[i].GetComponentInChildren<Text>().text = ((NewMewtwo)newPokemons[i]).pokeName;
                buttons[i].GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>(($"Images.{((NewMewtwo)newPokemons[i]).pokeName.ToUpper()}"));
            }
            else if (newPokemons[i] is NewPikachu)
            {
                buttons[i].GetComponentInChildren<Text>().text = ((NewPikachu)newPokemons[i]).pokeName;
                buttons[i].GetComponentInChildren<Image>().sprite = Resources.Load<Sprite>(($"Images.{((NewPikachu)newPokemons[i]).pokeName.ToUpper()}"));
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
