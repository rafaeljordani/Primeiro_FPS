using UnityEngine;

public class AtirarCreater : MonoBehaviour
{
    public float alcance = 100f;
    public Camera cam;
    public Transform pontaDaArma;

    public GameObject PrefabsRatroTiro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) { AtirarRaycast(); }
    }

    public void AtirarRaycast()
    {
        Vector3 pontoFinal;
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, alcance))
        {
            pontoFinal = hit.point;
            Debug.Log("Acertou o objeto: " + hit.collider.name);
        }
        else
        {
            pontoFinal = cam.transform.position + cam.transform.forward * alcance;
            Debug.Log("Não acertou nenhum objeto");
        }

        createRastroTiro(pontaDaArma.position, pontoFinal);
    }


    public void createRastroTiro( Vector3 PontoIncial, Vector3 pontoFinal)
    {
        GameObject rastroObjeto = Instantiate(PrefabsRatroTiro, PontoIncial, Quaternion.identity);

        // Pega o componente de linha dele
        LineRenderer linha = rastroObjeto.GetComponent<LineRenderer>();

        if (linha != null)
        {
            // Define as duas pontas da linha
            linha.SetPosition(0, PontoIncial);
            linha.SetPosition(1, pontoFinal);
        }

        // Destrói o rastro após 0.1 segundos para não encher o jogo de lixo
        Destroy(rastroObjeto, 0.1f);
    }
}

