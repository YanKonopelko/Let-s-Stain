using UnityEngine;

public class MusicManager : MonoBehaviour
{
    static public bool isPlaying;
     [SerializeField] private GameObject _musicPlayer;
    void Awake()
    {
        if (GameObject.Find("MusicPlayer") == null)
        {
           var obj =  Instantiate(_musicPlayer);
            obj.name = "MusicPlayer";
        }
        isPlaying = PlayerPrefs.GetInt("isPlaying") == 1 ? true : false;
    }


    static public void PressButton()
    {
        isPlaying = !isPlaying;
        PlayerPrefs.SetInt("isPlaying", isPlaying ? 1 : 0);
        if (isPlaying)
            MusicPlayer.PlayMusic();
        else
            MusicPlayer.StopMusic();
    }

    
    
}
