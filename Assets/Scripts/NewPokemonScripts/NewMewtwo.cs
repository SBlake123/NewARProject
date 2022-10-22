using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMewtwo : NewPokemon, IPokemon
{ 
    public string pokeName { get; set; }
    public int level { get; set; }
    public int hp { get; set; }
    public int phyDamage { get; set; }
    public int phyDefence { get; set; }
    public int specDamage { get; set; }
    public int specDefence { get; set; }

    public double hpV { get; set; }
    public double phyDamageV { get; set; }
    public double phyDefenceV { get; set; }
    public double specDamageV { get; set; }
    public double specDefenceV { get; set; }

    void Start()
    {
        PokemonStatusSetting("NewMewtwo", 60, 57, 50, 50, 100, 100);
        PokeMonStatusVariableSetting(3.7, 0.3, 0.3, 1.5, 1.4);
        PokeMonStatusCalc();
    }

    public void PokemonStatusSetting(string pokeName, int level, int hp, int phyDamage, int phyDefence, int specDamage, int specDefence)
    {
        this.pokeName = pokeName;
        this.hp = hp;
        this.phyDamage = phyDamage;
        this.phyDefence = phyDefence;
        this.specDamage = specDamage;
        this.specDefence = specDefence;
    }

    public void PokeMonStatusVariableSetting(double hpV, double phyDamageV, double phyDefenceV, double specDamageV, double specDefenceV)
    {
        this.hpV = hpV;
        this.phyDamageV = phyDamageV;
        this.phyDefenceV = phyDefenceV;
        this.specDamageV = specDamageV;
        this.specDefenceV = specDefenceV;
    }

    public void PokeMonStatusCalc()
    {
        this.hp = (int)(hp + hpV * level);
        this.phyDamage = (int)(phyDamage + phyDamageV * level);
        this.phyDefence = (int)(phyDefence + phyDefenceV * level);
        this.specDamage = (int)(specDamage + specDamageV * level);
        this.specDefence = (int)(specDefence + specDefenceV * level);
    }

}
