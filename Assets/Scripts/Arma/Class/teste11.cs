using UnityEngine;

public class teste11 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is createdpublic class TesteWeaponData
    public TesteWeaponData AK47;

    void Awake()
    {
        // Criamos e populamos a arma assim que o jogo inicia
        AK47 = new TesteWeaponData("AK47 de Teste", 10, 100f, 1f);
    }
}


public class TesteWeaponData
{
    public string name;
    public int damage;
    public float range;
    public float fireRate;

    public TesteWeaponData(string name, int damage, float range, float fireRate)
    {
        this.name = name;
        this.damage = damage;
        this.range = range;
        this.fireRate = fireRate;

    }
}
