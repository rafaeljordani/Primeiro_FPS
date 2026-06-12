using UnityEngine;

public class InteracaoFilho : InteracaoPai 
{
    public bool estaAberta = false;
    public GameObject porta;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (estaAberta)
        {
            porta.transform.rotation = Quaternion.Lerp(porta.transform.rotation,Quaternion.Euler(0,90,0),Time.deltaTime * 2);
        }
        else
        {
            porta.transform.rotation = Quaternion.Lerp(porta.transform.rotation, Quaternion.Euler(0, 0, 0), Time.deltaTime * 2);
        }
    }

    public override void interact()
    {
        if(estaAberta == true)
        {
            //this.transform.Rotate(0, -90, 0);
            estaAberta = false;
        }
        else
        {
            //this.transform.Rotate(0, 90, 0);
            estaAberta = true;
        }
        
    }
    
}
