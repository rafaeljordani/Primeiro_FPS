using UnityEngine;

public class InimigoAtira : MonoBehaviour
{

    public GameObject enemayBullet, locationFire;
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
        Vector3 pontoFinal;
        RaycastHit hit;

        if (Physics.Raycast(locationFire.transform.position, locationFire.transform.forward, out hit, 10000))
        {
            pontoFinal = hit.point;
            colisionPlayer(hit);
        }
        else
        {
            pontoFinal = locationFire.transform.position + locationFire.transform.forward * 10000;
            //aqui ele pega o ponto final do tiro caso não acerte nenhum inimigo, para criar o rastro do tiro
        }

        // Corrigido: uso correto do método GetComponent<T>()
        GetComponent<AtirarCreater>().createRastroTiro(enemayBullet, locationFire.transform.position, pontoFinal);
        // aqui ele cria o rastro do tiro, passando o ponto inicial e final do tiro

        Invoke("Atirar", Random.Range(TempoMax, TempoMin));
    }


    public void colisionPlayer(RaycastHit hit)
    {
        if (hit.collider.CompareTag("Player"))
        {
            hit.collider.GetComponentInParent<HealfPlayer>().takeDamage(10);
        }
    }
}
