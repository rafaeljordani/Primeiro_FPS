using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;

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
    public Dictionary<int, dynamic> weapons;

    public Rifle armaAtualTypRifle;
    public Rifle armaAtualTypPistol;
    public Rifle armaAtualTypKnive;

    public dynamic armaAtual;

    public bool weaponEquipped = true;

    void Awake()
    {

        weapons = new Dictionary<int, dynamic>
        {
            {1, rifle.ak47 },
            {2, pistol.desertEagle},
            {3,knive.butterFly},
            {4, rifle.m4a1}

        };

        armaAtual = weapons[1];

        // por conta de uso de class eu preciei na class pai fazer um tipo de arma para poder pegar o valor de quanto teria de municao e de magazine
        // rifle = 1
        // pistol = 2
        // knive = 3
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
