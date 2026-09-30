using Unity.Mathematics;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    public float walkSpeed;
    public float runSpeed;
    public float jumpforce;
    public Rigidbody rb;
    public bool ChaoTa;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        movPlayer();
    }


    public void movPlayer()
    {
        walk();
    }


    public void walk()
    {
        //Aqui um ternario para setar a velocidade que sera usada, se sera a de correr ou a de andar normal 
        float setSpeed = Input.GetKey(KeyCode.LeftShift) ? runSpeed : walkSpeed;

        //Pega o input de andar do player 
        Vector3 MovDirection = new Vector3(Input.GetAxisRaw("Horizontal"), rb.linearVelocity.y, Input.GetAxisRaw("Vertical"));
        //adiciona esse input direciado a onde o player esta olhando
        MovDirection = transform.TransformDirection(MovDirection);
        //adiciona o speed na mov
        MovDirection = MovDirection * setSpeed;
        //aqui ele anda sem alterar o eixo Y 
        rb.linearVelocity = new Vector3(MovDirection.x, rb.linearVelocity.y, MovDirection.z);

    }

   

   public void squat()
    {

    }

    

}
