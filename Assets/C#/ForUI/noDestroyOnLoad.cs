using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class noDestroyOnLoad : MonoBehaviour
{
    public AudioSource _audisource;
    public GameObject[] _audiopoints;
    public AudioClip[] _audioClips;
    public int _CurClip;
    bool _ClipReady = false;
    public bool _test = false;
    void Start()
    {
        _CurClip = Random.Range(0,_audioClips.Length);
        _audisource.clip = _audioClips[_CurClip];
        _audisource.Play();
        _audiopoints = GameObject.FindGameObjectsWithTag("soundPoint");
        if (_audiopoints.Length > 1)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (_test == true)
        {
            NewTrack();
        }
        if (!_audisource.isPlaying&&_ClipReady==false)
        {
            _ClipReady = true;
            Invoke("NewTrack",4);
        }
        if (SceneManager.GetActiveScene().buildIndex!=0&&SceneManager.GetActiveScene().buildIndex!=1)
        {
            //_audisource.volume = 0.2f;
            //Destroy(this.gameObject);
        }
        else
        {
            _audisource.volume = 0.3f;
        }
    }
    void NewTrack()
    {
        _test = false;
        if ((_CurClip+1)==_audioClips.Length)
        {
            _CurClip = 0;
            _audisource.clip = _audioClips[_CurClip];
        }
        else
        {
            _CurClip++;
            _audisource.clip = _audioClips[_CurClip];
        }
        _audisource.Play();
        _ClipReady = false;
    }
}
