using UnityEngine;

public class LoadedWeapons : MonoBehaviour
{
    public LoadedWeaponsData ak47;
    public LoadedWeaponsData m4a1;
    public LoadedWeaponsData desertEagle;

    public LoadedWeaponsData butterFly;
    void Awake()
    {
        ak47 = new LoadedWeaponsData(
            2,
            "AK47",
            35,
            100f,
            0.4f,
            1,
            350,
            35
        );
        m4a1 = new LoadedWeaponsData(
           2,
           "M4A1",
           30,
           100f,
           0.1f,
           1,
           350,
           35
       );
        desertEagle = new LoadedWeaponsData(
            3,
            "Desert eagle",
            35,
            100f,
            0.8f,
            2,
            100,
            8
        );

        butterFly = new LoadedWeaponsData(
            1,
            "Butterfly",
            20,
            10f,
            0.5f,
            3,
            0,
            0
        );



    }
}

public class LoadedWeaponsData : WeaponsData
{
    public int ammunition;

    public int magSize;

    public LoadedWeaponsData(int id, string name, int damage, float range, float fireRate, int typeWeapon, int ammunition, int magSize)
    : base(id, name, damage, range, fireRate, typeWeapon)
    {
        this.ammunition = ammunition;
        this.magSize = magSize;
    }








}