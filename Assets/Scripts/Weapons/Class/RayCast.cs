using Unity.Cinemachine;
using UnityEngine;

public class RayCast : MonoBehaviour
{

    public void fireRaycast(AtirarCreater atirarCreater, GameObject prefbTiro, GameObject player, Transform creatPoint, MainPoints mainPoints, int damage, float range)
    {
        //Aqui ele pega o componete filho do player que é a camera
        Camera cam = player.GetComponentInChildren<Camera>();

        Vector3 pontoFinal;
        RaycastHit hit;

        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            pontoFinal = hit.point;


            coliderEnnemy(hit, mainPoints);
            // Verifica se o objeto atingido tem é um inimigo e destroi ele e adiciona pontos ao player  

            if (hit.collider.TryGetComponent<PlayerHelth>(out PlayerHelth emyLife))
            {
                serverRequestHitLife(emyLife, damage);
                // para quando for multPlayer , aqui é onde você chamaria a função de request para o servidor para aplicar o dano ao inimigo atingido
            }
        }
        else
        {
            pontoFinal = cam.transform.position + cam.transform.forward * range;
            //aqui ele pega o ponto final do tiro caso não acerte nenhum inimigo, para criar o rastro do tiro
        }

        atirarCreater.createRastroTiro(prefbTiro, creatPoint.position, pontoFinal);
        // aqui ele cria o rastro do tiro, passando o ponto inicial e final do tiro

    }


    public void serverRequestHitLife(PlayerHelth playerHelth, int damege)
    {
        playerHelth.emyLife -= damege;
    }


    public void coliderEnnemy(RaycastHit hit, MainPoints mainPoints)
    {
        if (hit.collider.CompareTag("Inimigo"))
        {
            Destroy(hit.collider.gameObject);
            mainPoints.AddPoints();
            //Adiciona os pontos ao jogador
        }
    }

}
