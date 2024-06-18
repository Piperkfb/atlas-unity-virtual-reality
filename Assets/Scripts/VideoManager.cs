using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    public VideoClip[] clips;
    private int i;
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.clip =  clips[0];
    }

    public void Play()
    {
        videoPlayer.Play();
    }
    public void Stop()
    {
        videoPlayer.Stop();
    }
    public void Pause()
    {
        videoPlayer.Pause();
    }
    public void Next()
    {
        i++;
        if (i >= clips.Length)
        {
            i = 0;
        }
        videoPlayer.clip = clips[i];
    }
    public void Previous()
    {
        i--;
        if (i < 0)
        {
            i = 0;
        }
        videoPlayer.clip = clips[i];
    }
}
