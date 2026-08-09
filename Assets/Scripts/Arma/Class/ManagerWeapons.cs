using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;

public class ManagerWeapons : MonoBehaviour
{
    //Referencias armas
    public Rifle rifle;
    public Pistol pistol;
    public knive knive;

    //Referencias Raycast
    public GameObject player;
    public GameObject prefbTiro;
    public Transform creatPoint;
    public AtirarCreater atirarCreater;


    //Referencia dicioario
    public Dictionary<int, WeaponsData> weapons;

    public WeaponsData armaAtual;

    void Awake()
    {

        weapons = new Dictionary<int, WeaponsData>
        {
            {1, rifle.ak47 },
            {2, pistol.desertEagle},
            {3,knive.butterFly},
            {4, rifle.m4a1}

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
        armaAtual.fire(atirarCreater, player, prefbTiro, creatPoint);
    }
}
