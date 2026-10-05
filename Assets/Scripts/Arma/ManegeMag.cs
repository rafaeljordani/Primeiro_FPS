using UnityEngine;

public class ManegeMag : MonoBehaviour
{

    //Referencias Raycast
    public GameObject player;
    public GameObject prefbTiro;
    public Transform creatPoint;
    public AtirarCreater atirarCreater;

    public LoadedWeaponsData weapon;

    public int ammunition;
    public int magSize;


    private float nextFireTime = 0f;

    void Start()
    {
        weapon = GetComponent<ManagerWeapons>().armaAtual;
        magSize = weapon.magSize;
        ammunition = weapon.magSize;
    }

    // Update is called once per frame
    void Update()
    {
        ammunitionManager();
        reloadMag();
    }

    public void ammunitionManager()
    {
        if (Input.GetMouseButton(0) && ammunition > 0 && Time.time >= nextFireTime ){
            weapon.fire(atirarCreater, player, prefbTiro, creatPoint);
            ammunition--;
            print("Ammunition: " + weapon.ammunition + " | MagSize: " + ammunition);

            //Para espaçar o tempo entre os tiros
            nextFireTime = Time.time + weapon.fireRate;
        }
    }

    public void reloadMag()
    {
        if (Input.GetKeyDown(KeyCode.R) && weapon.ammunition > 0)
        {
            Debug.Log("recaregou...");
            ammunition = magSize;
            weapon.ammunition -= magSize;
        }
    }
}
