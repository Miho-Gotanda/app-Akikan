using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AkikanController : MonoBehaviour
{
    private GameManager gameManager;
    private Color32 color;
    private GameObject Position;
    private float randomValue;
    public GameObject akikanPrefab;
    private EasyCount easyCount;
   
    // Start is called before the first frame update
    void Start()
    {
        easyCount = GameObject.Find("DastBox").GetComponent<EasyCount>();
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
            else if(gameManager.damage!=0&&easyCount.counter!=0)
            {
                Instantiate(akikanPrefab, Position.transform.position, Quaternion.identity);
                Destroy(this.gameObject);
            }
        }

    }

}
