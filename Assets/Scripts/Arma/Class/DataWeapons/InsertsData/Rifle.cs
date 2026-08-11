using UnityEngine;

public class Rifle : MonoBehaviour
{
    public RiflesData ak47;
    public RiflesData m4a1;
    void Awake()
    {
        ak47 = new RiflesData(
            2,
            "AK47",
            35,
            100f,
            0.4f,
            1,
            50000,
            35
        );
        m4a1 = new RiflesData(
           2,
           "M4A1",
           30,
           100f,
           0.3f,
           1,
           30,
           30
       );
    }
}

public class RiflesData : LoadedWeaponsData
{
    public RiflesData(int id, string name, int damage, float range, float fireRate, int typeWeapon, int ammunition, int magSize)
   : base(id, name, damage, range, fireRate, typeWeapon, ammunition, magSize)
    {

    }
}