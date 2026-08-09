using Unity.Cinemachine;
using UnityEngine;

public class RayCast : MonoBehaviour
{

    public void fireRaycast(GameObject prefbTiro, GameObject player, Transform creatPoint, int damage, float range)
    {
        Camera cam = player.GetComponentInChildren<Camera>();
        Vector3 pontoFinal;
        RaycastHit hit;
        Debug.Log("Entrou na funcao firecast");
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            pontoFinal = hit.point;
            if (hit.collider.TryGetComponent<PlayerHelth>(out PlayerHelth emyLife))
            {
                serverRequestHitLife(emyLife, damage);
            }
        }
        else
        {
            pontoFinal = cam.transform.position + cam.transform.forward * range;
        }

        GetComponent<AtirarCreater>().createRastroTiro(prefbTiro, creatPoint.position, pontoFinal);

    }


    public void serverRequestHitLife(PlayerHelth playerHelth, int damege)
    {
        playerHelth.emyLife -= damege;
    }

}
