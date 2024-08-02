using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoCheck : MonoBehaviour
{
    [SerializeField]
    VideoPlayer mysplash;
    // Start is called before the first frame update
    void Start()
    {
        mysplash.loopPointReached += splashfinish;
    }

    // Update is called once per frame
    void splashfinish(VideoPlayer vp)
    {
        SceneManager.LoadScene("IntoductionScene");
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("IntoductionScene");
        }
    }
}
