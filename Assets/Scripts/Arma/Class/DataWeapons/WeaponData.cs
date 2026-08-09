using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Interactions;

public class WeaponData : MonoBehaviour
{
}

public class WeaponsData
{
    public int id;
    public string name;
    public int damage;
    public float range;
    public float fireRate;


    public WeaponsData(int id, string name, int damage, float range, float fireRate)
    {
        this.id = id;
        this.name = name;
        this.damage = damage;
        this.range = range;
        this.fireRate = fireRate;

    }

    public virtual void fire(AtirarCreater atirarCreater, GameObject player, GameObject prefbTiro, Transform creatPoint)
    {
        player.GetComponent<RayCast>().fireRaycast(atirarCreater, prefbTiro, player, creatPoint, damage, range);
    }


}
