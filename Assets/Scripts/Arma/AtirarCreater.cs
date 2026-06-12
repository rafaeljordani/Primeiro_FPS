using UnityEngine;

public class AtirarCreater : MonoBehaviour
{

    public GameObject BalaPrefab,localBala;
    public float VelBala;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnersBala", 5f, 5f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { SpawnersBala(); }
    }

    public void SpawnersBala()
    {
        
        GameObject Bala = Instantiate(BalaPrefab, localBala.transform.position, Camera.main.transform.rotation);
        Bala.GetComponent<Rigidbody>().AddForce(transform.forward * VelBala, ForceMode.Impulse);
        Destroy(Bala,5f);
        
    }
}
