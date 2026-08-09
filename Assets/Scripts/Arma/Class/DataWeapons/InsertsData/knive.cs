using UnityEngine;

public class knive : MonoBehaviour
{
    public KnivesData butterFly;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        butterFly = new KnivesData(1, "Butterfly", 20, 10f, 0.5f);
    }
}

public class KnivesData : WeaponsData
{
    public KnivesData(int id, string name, int damage, float range, float fireRate)
    : base(id, name, damage, range, fireRate)
    {

    }
}
