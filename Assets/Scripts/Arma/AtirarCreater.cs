using UnityEngine;

public class AtirarCreater : MonoBehaviour
{

    public GameObject BalaPrefab,localBala;
    public float VelBala;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { SpawnersBala(); }
    }

    public void SpawnersBala()
    {

        GameObject Bala = Instantiate(BalaPrefab, localBala.transform.position, Quaternion.Euler(0,0,0));
        Bala.GetComponent<Rigidbody>().AddForce(transform.forward * VelBala, ForceMode.Impulse);
        
    }
}
