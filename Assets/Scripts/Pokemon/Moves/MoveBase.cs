using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Pokemon/Create new Move")]

public class MoveBase : ScriptableObject
{
    [SerializeField] new string name;
    [SerializeField] string description;
    [SerializeField] PokemonType type;
    [SerializeField] public int pp;
    [SerializeField] public int power;
    [SerializeField] public int accuracy;
    [SerializeField] MoveType moveType;
}

public enum MoveType
{
    // move type managment
    Physical,
    Special,
    Status,
}
