using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    // Start is called before the first frame update
    string candi;
    int candinum,check;
    public GameObject candiselect;
    void Start()
    {
        Screen.SetResolution(1920, 1200, true);
        PlayerPrefs.SetInt("playernum", 0);
        candi = PlayerPrefs.GetString("playername", "");
        candinum= PlayerPrefs.GetInt("playername", 0);
        //candiselect= GameObject.Find("charaselect");
        candiselect.SetActive(false);
        check = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onbtnplayer1()
    {
        PlayerPrefs.SetInt("playernum", 1);
        candiselect.SetActive(true);
       
    }
    public void onbtnplayer2()
    {
        PlayerPrefs.SetInt("playernum", 2);
        candiselect.SetActive(true);
        
    }
    public void onbtnplayer3()
    {
        PlayerPrefs.SetInt("playernum", 3);
        candiselect.SetActive(true);
        
    }
    public void onbtnplayer4()
    {
        PlayerPrefs.SetInt("playernum", 4);
        candiselect.SetActive(true);
        
    }
    public void onbtnplayer5()
    {
        PlayerPrefs.SetInt("playernum", 5);
        candiselect.SetActive(true);
       
    }
    public void onbtnplayer6()
    {
        PlayerPrefs.SetInt("playernum", 6);
        candiselect.SetActive(true);
       
    }
}
