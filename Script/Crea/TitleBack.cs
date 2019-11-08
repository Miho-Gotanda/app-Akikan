using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TitleBack : MonoBehaviour
{
    [SerializeField]
    private GameObject text;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("TextTrue", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TextTrue()
    {
        text.SetActive(true);
    }
    public void TitleBackButton()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
