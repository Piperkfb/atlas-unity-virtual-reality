using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        GetComponent<Button>().onClick.AddListener(PlaySound);
    }

    void PlaySound()
    {
        audioSource.Play();
    }
}
