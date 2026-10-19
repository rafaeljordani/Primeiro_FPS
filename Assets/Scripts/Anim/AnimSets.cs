using UnityEngine;

public class AnimSets : MonoBehaviour
{
    public Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetFalseFire()
    {
        anim.SetBool("Fire", false);
    }
    public void SetFalseReload()
    {
        anim.SetBool("Reload", false);
    }

}
