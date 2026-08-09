using UnityEngine;

public class Pistol : MonoBehaviour
{
    public PistolsData desertEagle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        desertEagle = new PistolsData(3, "Desert eagle", 35, 100f, 0.8f, 8, 8);
    }
}


public class PistolsData : LoadedWeaponsData
{
    public PistolsData(int id, string name, int damage, float range, float fireRate, int ammunition, int magSize)
   : base(id, name, damage, range, fireRate, ammunition, magSize)
    {

    }
}
