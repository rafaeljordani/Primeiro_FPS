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
        Iswalk();
    }

    public void SetFalseFire()
    {
        anim.SetBool("Fire", false);
    }
    public void SetFalseReload()
    {
        anim.SetBool("Reload", false);
    }

    public void Iswalk()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("Walk", true);
        }
        else
        {
            anim.SetBool("Walk", false);
        }
    }

}
