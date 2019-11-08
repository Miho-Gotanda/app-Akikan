using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;
    [SerializeField]
    private AudioClip audioClip;
    [SerializeField]
    private int kindPartical;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (kindPartical == 0)
        {
            StartCoroutine("Test");
        }
        else if (kindPartical == 1)
        {
            StartCoroutine("Test1");
        }
    }

    IEnumerator Test()
    {
        while (true)
        {
            audioSource.PlayOneShot(audioClip);
            yield return new WaitForSeconds(3f);
        }
    }

    IEnumerator Test1()
    {
        while (true)
        {
            yield return new WaitForSeconds(2.5f);
            audioSource.PlayOneShot(audioClip);
            yield return new WaitForSeconds(3f);
        }
    }

}
