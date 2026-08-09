using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;

public class TesteDeTiro : MonoBehaviour
{
    public TesteWeaponData arma;
    public GameObject player, prefbTiro;
    public Transform spawnar;

    public float fireRateTeste, nextFireTime;
    void Start()
    {

        teste11 ScriptArma = FindAnyObjectByType<teste11>();

        arma = ScriptArma.AK47;

        fireRateTeste = arma.fireRate;
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (Time.time >= nextFireTime)
            {
                atirar();
                Debug.Log("Entrou na funcao atirar");
            }
        }

    }


    public void atirar()
    {
        string name = arma.name;
        int damage = arma.damage;
        float range = arma.range;
        float fireRate = arma.fireRate;

        nextFireTime = Time.time + fireRate;

        fire(player, spawnar, damage, range);
    }

    public void fire(GameObject player, Transform creatPoint, int damage, float range)
    {
        FindAnyObjectByType<RayCast>().fireRaycast(prefbTiro, player, creatPoint, damage, range);
        Debug.Log("Entrou na funcao Fire");
    }
}
