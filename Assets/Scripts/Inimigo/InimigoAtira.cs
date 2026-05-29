using UnityEngine;

public class InimigoAtira : MonoBehaviour
{

    public GameObject BalaPrefab, localBala;
    public float VelBala, TempoMax, TempoMin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("Atirar", Random.Range(TempoMax, TempoMin));
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void Atirar()
    {
        GameObject Bala = Instantiate(BalaPrefab, localBala.transform.position, Quaternion.Euler(0, 0, 0));
        Bala.GetComponent<Rigidbody>().AddForce(transform.forward * VelBala, ForceMode.Impulse);
        Invoke("Atirar", Random.Range(TempoMax, TempoMin));
    }
}
