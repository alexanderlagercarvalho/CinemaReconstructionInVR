using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class WorldSpaceVideo : MonoBehaviour
{
    public VideoClip[] trailerClips;
    public VideoClip movie;

    private VideoPlayer videoPlayer;
    private int videoClipIndex;

    void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer> ();
        videoPlayer.loopPointReached += EndReached;
    }


    // Start is called before the first frame update
    void Start()
    {
        videoClipIndex = 0;
        videoPlayer.clip = trailerClips[0];
        videoPlayer.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void EndReached(VideoPlayer video)
    {
        videoClipIndex++;
        if (videoClipIndex >= trailerClips.Length)
        {
            PlayMovie();
        }
        else
        {
            videoPlayer.clip = trailerClips[videoClipIndex];
            videoPlayer.Play();
        }
    }

    void PlayMovie()
    {
        videoPlayer.clip = movie;
        videoPlayer.Play();
    }
}
