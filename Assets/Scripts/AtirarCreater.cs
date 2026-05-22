using UnityEngine;

public class AtirarCreater : MonoBehaviour
{

    public GameObject BalaPrefab,localBala;


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

        GameObject Bala = Instantiate(BalaPrefab, localBala.transform.position,Quaternion.identity);

        //Bala.GetComponent<Rigidbody>().position// eu nao sei KRLLLLLLLLLLLL
    }
}
