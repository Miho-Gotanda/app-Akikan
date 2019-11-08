using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NormalAkikanController : MonoBehaviour
{
    private GameManager gameManager;
    private GameObject Position;
    private float randomValue;
    public GameObject akikanPrefab;
    private NormalCount normalCount;
   
    // Start is called before the first frame update
    void Start()
    {
        normalCount = GameObject.Find("DastBox").GetComponent<NormalCount>();
        Position = GameObject.Find("Position");
        gameManager = GameObject.Find("Earth").GetComponent<GameManager>();
        randomValue = Random.Range(-8.5f, 8.5f);
    }

    // Update is called once per frame
    void Update()
    {
       
     
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Position.transform.position = new Vector3(randomValue, 3.97f, 0);

        if (collision.gameObject.tag == "DastBox")
        {
            Instantiate(akikanPrefab, Position.transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            
        }
        else if(collision.gameObject.tag == "Earth")
        {
            if (gameManager.damage == 0)
            {

                SceneManager.LoadScene("GameOverScene");
            }
            else if(gameManager.damage!=0&&normalCount.counter!=0)
            {
               
                    Instantiate(akikanPrefab, Position.transform.position, Quaternion.identity);
                    Destroy(this.gameObject);
                
            }
        }

    }

}
