using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemon", menuName = "Pokemon/Create new Pokemon")]

public class PokemonBase : ScriptableObject
{
    // name/desc managment

    [SerializeField] new string name;
    [SerializeField] string description;
    // sprite managment
    [SerializeField] Object frontSprite;
    [SerializeField] Object backSprite;
    [SerializeField] Object shinyfrontSprite;
    [SerializeField] Object shinybackSprite;
    // type managment
    [SerializeField] PokemonType type1;
    [SerializeField] PokemonType type2;
    // base stats
    [SerializeField] int maxHp;
    [SerializeField] int attack;
    [SerializeField] int defense;
    [SerializeField] int sAttack;
    [SerializeField] int sDefense;
    [SerializeField] int speed;
    // move stufffffff
    [SerializeField] List<LearnableMove> learnableMoves;

    public string GetName()
    {
        return name;
    }

    public string Name
    {
        get { return name; }
    }
    public string Description
    {
        get { return description; }
    }
    public Object FrontSprite
    {
        get { return frontSprite; }
    }
    public Object BackSprite
    {
        get { return backSprite; }
    }
    public Object ShinyFrontSprite
    {
        get { return shinyfrontSprite; }
    }
    public Object ShinyBackSprite
    {
        get { return shinybackSprite; }
    }
    public int MaxHP
    {
        get { return maxHp; }
    }
    public int Attack
    {
        get { return attack; }
    }
    public int Defense
    {
        get { return defense; }
    }
    public int SAttack
    {
        get { return sAttack; }
    }
    public int SDefense
    {
        get { return sDefense; }
    }
    public int Speed
    {
        get { return speed; }
    }
    public List<LearnableMove> LearnableMoves
    {
        get { return learnableMoves; }
    }
}

[System.Serializable]

public class LearnableMove
{
    [SerializeField] MoveBase moveBase;
    [SerializeField] int level;

    public MoveBase Base
    {
        get { return moveBase; }
    }

    public int Level
    {
        get { return level; }
    }
}

public enum PokemonType
{
    // type managment
    None,
    Normal,
    Fire,
    Water,
    Grass,
    Flying,
    Electric,
    Rock,
    Ground,
    Psychic,
    Ghost,
    Dark,
    Steel,
    Ice,
    Poison,
    Fighting,
    Bug,
    Dragon,
    Fairy,
}