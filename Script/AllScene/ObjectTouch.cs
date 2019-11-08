using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTouch : MonoBehaviour
{
    
    private Rigidbody2D rigid;
    private Animator ani;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid = GetComponent<Rigidbody2D>();
        this.ani = GetComponent<Animator>();
        ani.SetBool("RightBool", false);
        ani.SetBool("LeftBool", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Touch()
    {
        float rightValue = Random.Range(-5f, 5f);
        this.rigid.AddForce(transform.up * 5.5f, ForceMode2D.Impulse);
        this.rigid.AddForce(transform.right * rightValue,ForceMode2D.Impulse);
        if (rightValue <= 0)
        {
            ani.SetBool("RightBool", false);
            ani.SetBool("LeftBool", true);
            
        }
        else if (rightValue >= 0)
        {
            ani.SetBool("RightBool", true);
            ani.SetBool("LeftBool", false);
            
        }


    
    }
}
