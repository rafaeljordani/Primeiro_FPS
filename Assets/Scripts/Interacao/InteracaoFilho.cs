using UnityEngine;

public class InteracaoFilho : InteracaoPai 
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void interact()
    {
        this.transform.Rotate(0,90,0);
    }
    
}
