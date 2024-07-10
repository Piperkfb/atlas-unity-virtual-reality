using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHoverSound : MonoBehaviour, IPointerEnterHandler
{
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Pointer in Button
    public void OnPointerEnter(PointerEventData eventData)
    {
        if(audioSource != null)
            audioSource.Play();
    }
}
