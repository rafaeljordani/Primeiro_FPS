using UnityEngine;

public class LoadedWeapons : MonoBehaviour
{
    void Awake()
    {

    }
}

public class LoadedWeaponsData : WeaponsData
{
    public int ammunition;

    public int magSize;

    public LoadedWeaponsData(int id, string name, int damage, float range, float fireRate, int ammunition, int magSize)
    : base(id, name, damage, range, fireRate)
    {
        this.ammunition = ammunition;
        this.magSize = magSize;
    }

}