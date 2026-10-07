using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;

public class ManagerWeapons : MonoBehaviour
{
    //Referencias armas
    public LoadedWeapons sla;

    //Referencia dicioario
    public Dictionary<int, LoadedWeaponsData> weapons;

    public LoadedWeaponsData armaAtual;

    void Awake()
    {

        weapons = new Dictionary<int, LoadedWeaponsData>
        {
            {1, sla.ak47},
            {2, sla.desertEagle},
            {3, sla.butterFly},
            {4, sla.m4a1}
        };

        armaAtual = weapons[4];

    }
}
