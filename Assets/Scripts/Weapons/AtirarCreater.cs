using JetBrains.Annotations;
using Unity.Mathematics;
using UnityEngine;

public class AtirarCreater : MonoBehaviour
{
   
    public Animator anim;

    public void createRastroTiro(GameObject prefbTiro, Vector3 PontoIncial, Vector3 pontoFinal)
    {
        GameObject CameraPlayer = Camera.main.gameObject;
        GameObject rastroObjeto = Instantiate(prefbTiro, PontoIncial, CameraPlayer.transform.rotation);

        // Pega o componente de linha dele
        LineRenderer linha = FindAnyObjectByType<LineRenderer>();

        if (linha != null)
        {
            // Define as duas pontas da linha
            linha.SetPosition(0, PontoIncial);
            linha.SetPosition(1, pontoFinal);
        }
        anim.SetBool("Fire", true);
        // Destr�i o rastro ap�s 0.1 segundos para n�o encher o jogo de lixo
        Destroy(rastroObjeto, 0.03f);

    }


    
}

