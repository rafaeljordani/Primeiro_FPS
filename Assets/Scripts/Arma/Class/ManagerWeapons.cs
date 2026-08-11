using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;

public class ManagerWeapons : MonoBehaviour
{
    //Referencias armas
    public LoadedWeapons sla;

    //Referencias Raycast
    public GameObject player;
    public GameObject prefbTiro;
    public Transform creatPoint;
    public AtirarCreater atirarCreater;


    //Referencia dicioario
    public Dictionary<int, LoadedWeaponsData> weapons;

    public LoadedWeaponsData armaAtual;

    public bool weaponEquipped = true;

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
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Atirar();
        }
    }
    public void Atirar()
    {
        int idArmaAtual = armaAtual.magSize;
        Debug.Log(idArmaAtual);
        armaAtual.fire(atirarCreater, player, prefbTiro, creatPoint);
    }
}
