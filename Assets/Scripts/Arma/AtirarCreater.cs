using Unity.Mathematics;
using UnityEngine;

public class AtirarCreater : MonoBehaviour
{

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }


    public void createRastroTiro(GameObject prefbTiro, Vector3 PontoIncial, Vector3 pontoFinal)
    {
        GameObject rastroObjeto = Instantiate(prefbTiro, PontoIncial, Quaternion.identity);
        Debug.Log("Entrou na funcao crateRastro");

        // Pega o componente de linha dele
        LineRenderer linha = FindAnyObjectByType<LineRenderer>();

        if (linha != null)
        {
            // Define as duas pontas da linha
            linha.SetPosition(0, PontoIncial);
            linha.SetPosition(1, pontoFinal);
        }

        // Destr�i o rastro ap�s 0.1 segundos para n�o encher o jogo de lixo
        Destroy(rastroObjeto, 0.1f);
    }
}

