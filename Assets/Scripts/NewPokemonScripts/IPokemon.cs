using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IPokemon
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

    public void PokemonStatusSetting(string pokeName, int level, int hp, int phyDamage, int phyDefence, int specDamage, int specDefence);
    public void PokeMonStatusVariableSetting(double hpV, double phyDamageV, double phyDefenceV, double specDamageV, double specDefenceV);
    public void PokeMonStatusCalc();
}
