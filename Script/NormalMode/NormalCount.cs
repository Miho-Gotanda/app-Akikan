using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NormalCount : MonoBehaviour
{
    private Text countText;
    public int counter=10;
    public AudioSource source;
    public AudioClip seclip;
    // Start is called before the first frame update
    void Start()
    {
        countText = GameObject.Find("CountText").GetComponent<Text>();
        countText.text = counter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Akikan")
        {
            source.PlayOneShot(seclip);
            counter--;
            if (counter <= 0)
            {
                FadeManager.Instance.LoadScene("CreaScene",2.0f);
            }
            countText.text = counter.ToString();
        }
    }


}
