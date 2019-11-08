using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private Color color;
    private float red=1.0f;
    private float green=1.0f;
    private float blue=1.0f;
    private SpriteRenderer sprite;
    public int damage=7;
    public AudioSource source;
    public AudioClip explotionclip;
    public GameObject explotion;
    public GameObject[] heart;

    // Start is called before the first frame update
    void Start()
    {
        sprite = this.GetComponent<SpriteRenderer>();
        color = sprite.material.color;
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Akikan")
        {

            source.PlayOneShot(explotionclip);
            Instantiate(explotion, collision.transform.localPosition, Quaternion.identity);
            

            red -= 30 / 255f;
            green -= 30 / 255f;
            blue -= 30 / 255f;
            color.r = red;
            color.g = green;
            color.b = blue;

            sprite.material.color = color;

            Destroy(heart[damage]);
            damage--;
       
        }
    }

  
}
