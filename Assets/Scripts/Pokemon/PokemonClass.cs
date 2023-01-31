using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonClass
{
    public PokemonBase Base { get; set; }
    public int Level { get; set; }
    public int HP { get; set; }

    public List<Move> Moves { get; set; }

    public PokemonClass(PokemonBase pBase, int pLevel)
    {
        Base = pBase;
        Level = pLevel;
        HP = MaxHP;

        // Generate the moves
        Moves = new List<Move>();
        foreach (var move in Base.LearnableMoves)
        {
            if (move.Level <= Level)
                Moves.Add(new Move(move.Base));

            if (Moves.Count >= 4)
                break;
        }
    }

    public int Attack
    {
        get
        {
            return Mathf.FloorToInt((Base.Attack * Level) / 100f) + 5;
        }
    }

    public int Defense
    {
        get
        {
            return Mathf.FloorToInt((Base.Defense * Level) / 100f) + 5;
        }
    }

    public int SAttack
    {
        get
        {
            return Mathf.FloorToInt((Base.SAttack * Level) / 100f) + 5;
        }
    }

    public int SDefense
    {
        get
        {
            return Mathf.FloorToInt((Base.SDefense * Level) / 100f) + 5;
        }
    }

    public int Speed
    {
        get
        {
            return Mathf.FloorToInt((Base.Speed * Level) / 100f) + 5;
        }
    }

    public int MaxHP
    {
        get
        {
            return Mathf.FloorToInt((Base.MaxHP * Level) / 100f) + 10;
        }
    }
}
