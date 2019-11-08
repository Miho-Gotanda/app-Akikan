using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void EasyTouch()
    {
        SceneManager.LoadScene("EasyScene");
    }

    public void NormalTouch()
    {
        SceneManager.LoadScene("NormalScene");
    }

    public void HardTouch()
    {
        SceneManager.LoadScene("HardScene");
    }
}
