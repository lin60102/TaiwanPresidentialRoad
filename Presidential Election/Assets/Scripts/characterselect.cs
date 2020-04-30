using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;
using UI.Dialogs;


public class characterselect : MonoBehaviour
{
    public GameObject name;
    public GameObject candiselect;
    public string[] candiates;
    public Button btn1, btn2, btn3, btn4, btn5, btn6;
    public GameObject txt1, txt2, txt3, txt4, txt5, txt6;
    public Sprite Chen, Han, Ko, Lai, Lin, Ma, Tsai, Wang, Wu;
    string _text1 = "name";
    readonly Rect _rect1 = new Rect(10, 10, 1, 1);
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1920, 1200, true);
        //name = GameObject.Find("selecttextbox");
       // candiselect = GameObject.Find("charaselect");
    }
  

    void OnGUI()
    {
        candiates = GameData.candiates;
        GUI.SetNextControlName("tf1");
        _text1 = GUI.TextField(_rect1, _text1);
        GUI.FocusControl("tf1");
        Debug.Log(PlayerPrefs.GetInt("playernum"));
        Debug.Log(System.Array.IndexOf(GameData.candiates, "Mr Ma"));
        if (PlayerPrefs.GetInt("playernum") != 0)
        {
            if (_text1.Length == 8 && (_text1 == "003f87be" || _text1 == "0061df79" || _text1 == "0061df72" || _text1 == "000bae57" || _text1 == "000bae54" || _text1 == "000bae41" || _text1 == "000bae3e" || _text1 == "003f87a8" || _text1 == "003f87ad"))
            {
                switch (_text1)
                {
                    case "003f87be":
                        _text1 = "Mr Ma";
                        // name.GetComponent<Text>().text = _text1;

                        PlayerPrefs.SetString("playername", "Mr Ma");
                        if (PlayerPrefs.GetInt("playernum") == 1 && System.Array.IndexOf(GameData.candiates, "Mr Ma") < 0 && GameData.candiates[0]!=null)
                        {
                            candiselect.SetActive(false);
                            btn1.interactable = false;
                            btn1.image.sprite = Ma;
                            Debug.Log("txt1= " + _text1);
                            txt1.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[0] = "Mr Ma";
                            GameData.candiatesnum[0] = "003f87be";
                            GameData.check++;
                            GameData.osups[0, 0]=35;
                            GameData.ysups[0, 0]=15;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 2 && System.Array.IndexOf(GameData.candiates, "Mr Ma") < 0 && GameData.candiates[1] == null)
                        {
                            candiselect.SetActive(false);
                            btn2.interactable = false;
                            btn2.image.sprite = Ma;
                            txt2.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[1] = "Mr Ma";
                            GameData.candiatesnum[1] = "003f87be";
                            GameData.check++;
                            GameData.osups[0, 1] = 35;
                            GameData.ysups[0, 1] = 15;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }

                        }
                        else if (PlayerPrefs.GetInt("playernum") == 3 && System.Array.IndexOf(GameData.candiates, "Mr Ma") < 0 && GameData.candiates[2] == null)
                        {
                            candiselect.SetActive(false);
                            btn3.interactable = false;
                            btn3.image.sprite = Ma;
                            txt3.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[2] = "Mr Ma";
                            GameData.candiatesnum[2] = "003f87be";
                            GameData.check++;
                            GameData.osups[0, 2] = 35;
                            GameData.ysups[0, 2] = 15;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 4 && System.Array.IndexOf(GameData.candiates, "Mr Ma") < 0 && GameData.candiates[3] == null)
                        {
                            candiselect.SetActive(false);
                            btn4.interactable = false;
                            btn4.image.sprite = Ma;
                            txt4.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[3] = "Mr Ma";
                            GameData.candiatesnum[3] = "003f87be";
                            GameData.check++;
                            GameData.osups[0, 3] = 35;
                            GameData.ysups[0, 3] = 15;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 5 && System.Array.IndexOf(GameData.candiates, "Mr Ma") < 0 && GameData.candiates[4] == null)
                        {
                            candiselect.SetActive(false);
                            btn5.interactable = false;
                            btn5.image.sprite = Ma;
                            txt5.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[4] = "Mr Ma";
                            GameData.candiatesnum[4] = "003f87be";
                            GameData.osups[0, 4] = 35;
                            GameData.ysups[0, 4] = 15;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 6 && System.Array.IndexOf(GameData.candiates, "Mr Ma") < 0 && GameData.candiates[5] == null)
                        {
                            candiselect.SetActive(false);
                            btn6.interactable = false;
                            btn6.image.sprite = Ma;
                            txt6.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[5] = "Mr Ma";
                            GameData.candiatesnum[5] = "003f87be";
                            GameData.osups[0, 5] = 35;
                            GameData.ysups[0, 5] = 15;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else
                        {
                            candiselect.SetActive(false);
                            _text1 = "";
                        }
                        break;
                        

                    case "0061df79":
                        _text1 = "Mr Chen";
                        // name.GetComponent<Text>().text = _text1;

                        PlayerPrefs.SetString("playername", "Mr Chen");
                        if (PlayerPrefs.GetInt("playernum") == 1 && System.Array.IndexOf(GameData.candiates, "Mr Chen") < 0 && GameData.candiates[0] == null)
                        {
                            candiselect.SetActive(false);
                            btn1.interactable = false;
                            btn1.image.sprite = Chen;
                            txt1.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[0] = "Mr Chen";
                            GameData.candiatesnum[0] = "0061df79";
                            GameData.osups[0, 0] = 40;
                            GameData.ysups[0, 0] = 10;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 2 && System.Array.IndexOf(GameData.candiates, "Mr Chen") < 0 && GameData.candiates[1] == null)
                        {
                            candiselect.SetActive(false);
                            btn2.interactable = false;
                            btn2.image.sprite = Chen;
                            txt2.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[1] = "Mr Chen";
                            GameData.candiatesnum[1] = "0061df79";
                            GameData.osups[0, 1] = 40;
                            GameData.ysups[0, 1] = 10;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }

                        }
                        else if (PlayerPrefs.GetInt("playernum") == 3 && System.Array.IndexOf(GameData.candiates, "Mr Chen") < 0 && GameData.candiates[2] == null)
                        {
                            candiselect.SetActive(false);
                            btn3.interactable = false;
                            btn3.image.sprite = Chen;
                            txt3.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[2] = "Mr Chen";
                            GameData.candiatesnum[2] = "0061df79";
                            GameData.osups[0, 2] = 40;
                            GameData.ysups[0, 2] = 10;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 4 && System.Array.IndexOf(GameData.candiates, "Mr Chen") < 0 && GameData.candiates[3] == null)
                        {
                            candiselect.SetActive(false);
                            btn4.interactable = false;
                            btn4.image.sprite = Chen;
                            txt4.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[3] = "Mr Chen";
                            GameData.candiatesnum[3] = "0061df79";
                            GameData.osups[0, 3] = 40;
                            GameData.ysups[0, 3] = 10;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 5 && System.Array.IndexOf(GameData.candiates, "Mr Chen") < 0 && GameData.candiates[4] == null)
                        {
                            candiselect.SetActive(false);
                            btn5.interactable = false;
                            btn5.image.sprite = Chen;
                            txt5.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[4] = "Mr Chen";
                            GameData.candiatesnum[4] = "0061df79";
                            GameData.osups[0, 4] = 40;
                            GameData.ysups[0, 4] = 10;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 6 && System.Array.IndexOf(GameData.candiates, "Mr Chen") < 0 && GameData.candiates[5] == null)
                        {
                            candiselect.SetActive(false);
                            btn6.interactable = false;
                            btn6.image.sprite = Chen;
                            txt6.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[5] = "Mr Chen";
                            GameData.candiatesnum[5] = "0061df79";
                            GameData.osups[0, 5] = 40;
                            GameData.ysups[0, 5] = 10;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else
                        {
                            candiselect.SetActive(false);
                            _text1 = "";
                        }
                        break;
                    case "0061df72":
                        _text1 = "Mr Han";
                        // name.GetComponent<Text>().text = _text1;

                        PlayerPrefs.SetString("playername", "Mr Han");
                        if (PlayerPrefs.GetInt("playernum") == 1 && System.Array.IndexOf(GameData.candiates, "Mr Han") < 0 && GameData.candiates[0] == null)
                        {
                            candiselect.SetActive(false);
                            btn1.interactable = false;
                            btn1.image.sprite = Han;
                            txt1.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[0] = "Mr Han";
                            GameData.candiatesnum[0] = "0061df72";
                            GameData.osups[0, 0] = 45;
                            GameData.ysups[0, 0] = 5;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 2 && System.Array.IndexOf(GameData.candiates, "Mr Han") < 0 && GameData.candiates[1] == null)
                        {
                            candiselect.SetActive(false);
                            btn2.interactable = false;
                            btn2.image.sprite = Han;
                            txt2.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[1] = "Mr Han";
                            GameData.candiatesnum[1] = "0061df72";
                            GameData.osups[0, 1] = 45;
                            GameData.ysups[0, 1] = 5;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }

                        }
                        else if (PlayerPrefs.GetInt("playernum") == 3 && System.Array.IndexOf(GameData.candiates, "Mr Han") < 0 && GameData.candiates[2] == null)
                        {
                            candiselect.SetActive(false);
                            btn3.interactable = false;
                            btn3.image.sprite = Han;
                            txt3.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[2] = "Mr Han";
                            GameData.candiatesnum[2] = "0061df72";
                            GameData.osups[0, 2] = 45;
                            GameData.ysups[0, 2] = 5;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 4 && System.Array.IndexOf(GameData.candiates, "Mr Han") < 0 && GameData.candiates[3] == null)
                        {
                            candiselect.SetActive(false);
                            btn4.interactable = false;
                            btn4.image.sprite = Han;
                            txt4.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[3] = "Mr Han";
                            GameData.candiatesnum[3] = "0061df72";
                            GameData.osups[0, 3] = 45;
                            GameData.ysups[0, 3] = 5;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 5 && System.Array.IndexOf(GameData.candiates, "Mr Han") < 0 && GameData.candiates[4] == null)
                        {
                            candiselect.SetActive(false);
                            btn5.interactable = false;
                            btn5.image.sprite = Han;
                            txt5.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[4] = "Mr Han";
                            GameData.candiatesnum[4] = "0061df72";
                            GameData.osups[0, 4] = 45;
                            GameData.ysups[0, 4] = 5;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 6 && System.Array.IndexOf(GameData.candiates, "Mr Han") < 0 && GameData.candiates[5] == null)
                        {
                            candiselect.SetActive(false);
                            btn6.interactable = false;
                            btn6.image.sprite = Han;
                            txt6.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[5] = "Mr Han";
                            GameData.candiatesnum[5] = "0061df72";
                            GameData.osups[0, 5] = 45;
                            GameData.ysups[0, 5] = 5;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else
                        {
                            candiselect.SetActive(false);
                            _text1 = "";
                        }
                        break;
                    case "000bae57":
                        _text1 = "Mr Ko";
                        // name.GetComponent<Text>().text = _text1;

                        PlayerPrefs.SetString("playername", "Mr Ko");
                        if (PlayerPrefs.GetInt("playernum") == 1 && System.Array.IndexOf(GameData.candiates, "Mr Ko") < 0 && GameData.candiates[0] == null)
                        {
                            candiselect.SetActive(false);
                            btn1.interactable = false;
                            btn1.image.sprite = Ko;
                            txt1.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[0] = "Mr Ko";
                            GameData.candiatesnum[0] = "000bae57";
                            GameData.osups[0, 0] = 5;
                            GameData.ysups[0, 0] = 45;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 2 && System.Array.IndexOf(GameData.candiates, "Mr Ko") < 0 && GameData.candiates[1] == null)
                        {
                            candiselect.SetActive(false);
                            btn2.interactable = false;
                            btn2.image.sprite = Ko;
                            txt2.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[1] = "Mr Ko";
                            GameData.candiatesnum[1] = "000bae57";
                            GameData.osups[0, 1] = 5;
                            GameData.ysups[0, 1] = 45;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }

                        }
                        else if (PlayerPrefs.GetInt("playernum") == 3 && System.Array.IndexOf(GameData.candiates, "Mr Ko") < 0 && GameData.candiates[2] == null)
                        {
                            candiselect.SetActive(false);
                            btn3.interactable = false;
                            btn3.image.sprite = Ko;
                            txt3.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[2] = "Mr Ko";
                            GameData.candiatesnum[2] = "000bae57";
                            GameData.osups[0, 2] = 5;
                            GameData.ysups[0, 2] = 45;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 4 && System.Array.IndexOf(GameData.candiates, "Mr Ko") < 0 && GameData.candiates[3] == null)
                        {
                            candiselect.SetActive(false);
                            btn4.interactable = false;
                            btn4.image.sprite = Ko;
                            txt4.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[3] = "Mr Ko";
                            GameData.candiatesnum[3] = "000bae57";
                            GameData.osups[0, 3] = 5;
                            GameData.ysups[0, 3] = 45;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 5 && System.Array.IndexOf(GameData.candiates, "Mr Ko") < 0 && GameData.candiates[4] == null)
                        {
                            candiselect.SetActive(false);
                            btn5.interactable = false;
                            btn5.image.sprite = Ko;
                            txt5.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[4] = "Mr Ko";
                            GameData.candiatesnum[4] = "000bae57";
                            GameData.osups[0, 4] = 5;
                            GameData.ysups[0, 4] = 45;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 6 && System.Array.IndexOf(GameData.candiates, "Mr Ko") < 0 && GameData.candiates[5] == null)
                        {
                            candiselect.SetActive(false);
                            btn6.interactable = false;
                            btn6.image.sprite = Ko;
                            txt6.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[5] = "Mr Ko";
                            GameData.candiatesnum[5] = "000bae57";
                            GameData.osups[0, 5] = 5;
                            GameData.ysups[0, 5] = 45;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else
                        {
                            candiselect.SetActive(false);
                            _text1 = "";
                        }
                        break;
                    case "000bae54":
                        _text1 = "Mr Lai";
                        // name.GetComponent<Text>().text = _text1;

                        PlayerPrefs.SetString("playername", "Mr Lai");
                        if (PlayerPrefs.GetInt("playernum") == 1 && System.Array.IndexOf(GameData.candiates, "Mr Lai") < 0 && GameData.candiates[0] == null)
                        {
                            candiselect.SetActive(false);
                            btn1.interactable = false;
                            btn1.image.sprite = Lai;
                            txt1.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[0] = "Mr Lai";
                            GameData.candiatesnum[0] = "000bae54";
                            GameData.osups[0, 0] = 20;
                            GameData.ysups[0, 0] = 30;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 2 && System.Array.IndexOf(GameData.candiates, "Mr Lai") < 0 && GameData.candiates[1] == null)
                        {
                            candiselect.SetActive(false);
                            btn2.interactable = false;
                            btn2.image.sprite = Lai;
                            txt2.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[1] = "Mr Lai";
                            GameData.candiatesnum[1] = "000bae54";
                            GameData.osups[0, 1] = 20;
                            GameData.ysups[0, 1] = 30;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }

                        }
                        else if (PlayerPrefs.GetInt("playernum") == 3 && System.Array.IndexOf(GameData.candiates, "Mr Lai") < 0 && GameData.candiates[2] == null)
                        {
                            candiselect.SetActive(false);
                            btn3.interactable = false;
                            btn3.image.sprite = Lai;
                            txt3.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[2] = "Mr Lai";
                            GameData.candiatesnum[2] = "000bae54";
                            GameData.osups[0, 2] = 20;
                            GameData.ysups[0, 2] = 30;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 4 && System.Array.IndexOf(GameData.candiates, "Mr Lai") < 0 && GameData.candiates[3] == null)
                        {
                            candiselect.SetActive(false);
                            btn4.interactable = false;
                            btn4.image.sprite = Lai;
                            txt4.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[3] = "Mr Lai";
                            GameData.candiatesnum[3] = "000bae54";
                            GameData.osups[0, 3] = 20;
                            GameData.ysups[0, 3] = 30;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 5 && System.Array.IndexOf(GameData.candiates, "Mr Lai") < 0 && GameData.candiates[4] == null)
                        {
                            candiselect.SetActive(false);
                            btn5.interactable = false;
                            btn5.image.sprite = Lai;
                            txt5.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[4] = "Mr Lai";
                            GameData.candiatesnum[4] = "000bae54";
                            GameData.osups[0, 4] = 20;
                            GameData.ysups[0, 4] = 30;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 6 && System.Array.IndexOf(GameData.candiates, "Mr Lai") < 0 && GameData.candiates[5] == null)
                        {
                            candiselect.SetActive(false);
                            btn6.interactable = false;
                            btn6.image.sprite = Lai;
                            txt6.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[5] = "Mr Lai";
                            GameData.candiatesnum[5] = "000bae54";
                            GameData.osups[0, 5] = 20;
                            GameData.ysups[0, 5] = 30;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else
                        {
                            candiselect.SetActive(false);
                            _text1 = "";
                        }
                        break;
                    case "000bae41":
                        _text1 = "Mr Lin";
                        // name.GetComponent<Text>().text = _text1;

                        PlayerPrefs.SetString("playername", "Mr Lin");
                        if (PlayerPrefs.GetInt("playernum") == 1 && System.Array.IndexOf(GameData.candiates, "Mr Lin") < 0 && GameData.candiates[0] == null)
                        {
                            candiselect.SetActive(false);
                            btn1.interactable = false;
                            btn1.image.sprite = Lin;
                            txt1.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[0] = "Mr Lin";
                            GameData.candiatesnum[0] = "000bae41";
                            GameData.osups[0, 0] = 15;
                            GameData.ysups[0, 0] = 35;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 2 && System.Array.IndexOf(GameData.candiates, "Mr Lin") < 0 && GameData.candiates[1] == null)
                        {
                            candiselect.SetActive(false);
                            btn2.interactable = false;
                            btn2.image.sprite = Lin;
                            txt2.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[1] = "Mr Lin";
                            GameData.candiatesnum[1] = "000bae41";
                            GameData.osups[0, 1] = 15;
                            GameData.ysups[0, 1] = 35;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }

                        }
                        else if (PlayerPrefs.GetInt("playernum") == 3 && System.Array.IndexOf(GameData.candiates, "Mr Lin") < 0 && GameData.candiates[2] == null)
                        {
                            candiselect.SetActive(false);
                            btn3.interactable = false;
                            btn3.image.sprite = Lin;
                            txt3.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[2] = "Mr Lin";
                            GameData.candiatesnum[2] = "000bae41";
                            GameData.osups[0, 2] = 15;
                            GameData.ysups[0, 2] = 35;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 4 && System.Array.IndexOf(GameData.candiates, "Mr Lin") < 0 && GameData.candiates[3] == null)
                        {
                            candiselect.SetActive(false);
                            btn4.interactable = false;
                            btn4.image.sprite = Lin;
                            txt4.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[3] = "Mr Lin";
                            GameData.candiatesnum[3] = "000bae41";
                            GameData.osups[0, 3] = 15;
                            GameData.ysups[0, 3] = 35;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 5 && System.Array.IndexOf(GameData.candiates, "Mr Lin") < 0 && GameData.candiates[4] == null)
                        {
                            candiselect.SetActive(false);
                            btn5.interactable = false;
                            btn5.image.sprite = Lin;
                            txt5.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[4] = "Mr Lin";
                            GameData.candiatesnum[4] = "000bae41";
                            GameData.osups[0, 4] = 15;
                            GameData.ysups[0, 4] = 35;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 6 && System.Array.IndexOf(GameData.candiates, "Mr Lin") < 0 && GameData.candiates[5] == null)
                        {
                            candiselect.SetActive(false);
                            btn6.interactable = false;
                            btn6.image.sprite = Lin;
                            txt6.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[5] = "Mr Lin";
                            GameData.candiatesnum[5] = "000bae41";
                            GameData.osups[0, 5] = 15;
                            GameData.ysups[0, 5] = 35;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else
                        {
                            candiselect.SetActive(false);
                            _text1 = "";
                        }
                        break;
                    case "000bae3e":
                        _text1 = "Ms Tsai";
                        // name.GetComponent<Text>().text = _text1;

                        PlayerPrefs.SetString("playername", "Ms Tsai");
                        if (PlayerPrefs.GetInt("playernum") == 1 && System.Array.IndexOf(GameData.candiates, "Ms Tsai") < 0 && GameData.candiates[0] == null)
                        {
                            candiselect.SetActive(false);
                            btn1.interactable = false;
                            btn1.image.sprite = Tsai;
                            txt1.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[0] = "Ms Tsai";
                            GameData.candiatesnum[0] = "000bae3e";
                            GameData.osups[0, 0] = 10;
                            GameData.ysups[0, 0] = 40;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 2 && System.Array.IndexOf(GameData.candiates, "Ms Tsai") < 0 && GameData.candiates[1] == null)
                        {
                            candiselect.SetActive(false);
                            btn2.interactable = false;
                            btn2.image.sprite = Tsai;
                            txt2.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[1] = "Ms Tsai";
                            GameData.candiatesnum[1] = "000bae3e";
                            GameData.osups[0, 1] = 10;
                            GameData.ysups[0, 1] = 40;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }

                        }
                        else if (PlayerPrefs.GetInt("playernum") == 3 && System.Array.IndexOf(GameData.candiates, "Ms Tsai") < 0 && GameData.candiates[2] == null)
                        {
                            candiselect.SetActive(false);
                            btn3.interactable = false;
                            btn3.image.sprite = Tsai;
                            txt3.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[2] = "Ms Tsai";
                            GameData.candiatesnum[2] = "000bae3e";
                            GameData.osups[0, 2] = 10;
                            GameData.ysups[0, 2] = 40;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 4 && System.Array.IndexOf(GameData.candiates, "Ms Tsai") < 0 && GameData.candiates[3] == null)
                        {
                            candiselect.SetActive(false);
                            btn4.interactable = false;
                            btn4.image.sprite = Tsai;
                            txt4.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[3] = "Ms Tsai";
                            GameData.candiatesnum[3] = "000bae3e";
                            GameData.osups[0, 3] = 10;
                            GameData.ysups[0, 3] = 40;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 5 && System.Array.IndexOf(GameData.candiates, "Ms Tsai") < 0 && GameData.candiates[4] == null)
                        {
                            candiselect.SetActive(false);
                            btn5.interactable = false;
                            btn5.image.sprite = Tsai;
                            txt5.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[4] = "Ms Tsai";
                            GameData.candiatesnum[4] = "000bae3e";
                            GameData.osups[0, 4] = 10;
                            GameData.ysups[0, 4] = 40;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 6 && System.Array.IndexOf(GameData.candiates, "Ms Tsai") < 0 && GameData.candiates[5] == null)
                        {
                            candiselect.SetActive(false);
                            btn6.interactable = false;
                            btn6.image.sprite = Tsai;
                            txt6.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[5] = "Ms Tsai";
                            GameData.candiatesnum[5] = "000bae3e";
                            GameData.osups[0, 5] = 10;
                            GameData.ysups[0, 5] = 40;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else
                        {
                            candiselect.SetActive(false);
                            _text1 = "";
                        }
                        break;
                    case "003f87a8":
                        _text1 = "Mr Wang";
                        // name.GetComponent<Text>().text = _text1;

                        PlayerPrefs.SetString("playername", "Mr Wang");
                        if (PlayerPrefs.GetInt("playernum") == 1 && System.Array.IndexOf(GameData.candiates, "Mr Wang") < 0 && GameData.candiates[0] == null)
                        {
                            candiselect.SetActive(false);
                            btn1.interactable = false;
                            btn1.image.sprite = Wang;
                            txt1.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[0] = "Mr Wang";
                            GameData.candiatesnum[0] = "003f87a8";
                            GameData.osups[0, 0] = 25;
                            GameData.ysups[0, 0] = 25;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 2 && System.Array.IndexOf(GameData.candiates, "Mr Wang") < 0 && GameData.candiates[1] == null)
                        {
                            candiselect.SetActive(false);
                            btn2.interactable = false;
                            btn2.image.sprite = Wang;
                            txt2.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[1] = "Mr Wang";
                            GameData.candiatesnum[1] = "003f87a8";
                            GameData.osups[0, 1] = 25;
                            GameData.ysups[0, 1] = 25;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }

                        }
                        else if (PlayerPrefs.GetInt("playernum") == 3 && System.Array.IndexOf(GameData.candiates, "Mr Wang") < 0 && GameData.candiates[2] == null)
                        {
                            candiselect.SetActive(false);
                            btn3.interactable = false;
                            btn3.image.sprite = Wang;
                            txt3.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[2] = "Mr Wang";
                            GameData.candiatesnum[2] = "003f87a8";
                            GameData.osups[0, 2] = 25;
                            GameData.ysups[0, 2] = 25;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 4 && System.Array.IndexOf(GameData.candiates, "Mr Wang") < 0 && GameData.candiates[3] == null)
                        {
                            candiselect.SetActive(false);
                            btn4.interactable = false;
                            btn4.image.sprite = Wang;
                            txt4.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[3] = "Mr Wang";
                            GameData.candiatesnum[3] = "003f87a8";
                            GameData.osups[0, 3] = 25;
                            GameData.ysups[0, 3] = 25;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 5 && System.Array.IndexOf(GameData.candiates, "Mr Wang") < 0 && GameData.candiates[4] == null)
                        {
                            candiselect.SetActive(false);
                            btn5.interactable = false;
                            btn5.image.sprite = Wang;
                            txt5.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[4] = "Mr Wang";
                            GameData.candiatesnum[4] = "003f87a8";
                            GameData.osups[0, 4] = 25;
                            GameData.ysups[0, 4] = 25;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 6 && System.Array.IndexOf(GameData.candiates, "Mr Wang") < 0 && GameData.candiates[5] == null)
                        {
                            candiselect.SetActive(false);
                            btn6.interactable = false;
                            btn6.image.sprite = Wang;
                            txt6.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[5] = "Mr Wang";
                            GameData.candiatesnum[5] = "003f87a8";
                            GameData.osups[0, 5] = 25;
                            GameData.ysups[0, 5] = 25;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else
                        {
                            candiselect.SetActive(false);
                            _text1 = "";
                        }
                        break;
                    case "003f87ad":
                        _text1 = "Mr Wu";
                        // name.GetComponent<Text>().text = _text1;

                        PlayerPrefs.SetString("playername", "Mr Wu");
                        if (PlayerPrefs.GetInt("playernum") == 1 && System.Array.IndexOf(GameData.candiates, "Mr Wu") < 0 && GameData.candiates[0] == null)
                        {
                            candiselect.SetActive(false);
                            btn1.interactable = false;
                            btn1.image.sprite = Wu;
                            txt1.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[0] = "Mr Wu";
                            GameData.candiatesnum[0] = "003f87ad";
                            GameData.osups[0, 0] = 30;
                            GameData.ysups[0, 0] = 20;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 2 && System.Array.IndexOf(GameData.candiates, "Mr Wu") < 0 && GameData.candiates[1] == null)
                        {
                            candiselect.SetActive(false);
                            btn2.interactable = false;
                            btn2.image.sprite = Wu;
                            txt2.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[1] = "Mr Wu";
                            GameData.candiatesnum[1] = "003f87ad";
                            GameData.osups[0, 1] = 30;
                            GameData.ysups[0, 1] = 20;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }

                        }
                        else if (PlayerPrefs.GetInt("playernum") == 3 && System.Array.IndexOf(GameData.candiates, "Mr Wu") < 0 && GameData.candiates[2] == null)
                        {
                            candiselect.SetActive(false);
                            btn3.interactable = false;
                            btn3.image.sprite = Wu;
                            txt3.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[2] = "Mr Wu";
                            GameData.candiatesnum[2] = "003f87ad";
                            GameData.osups[0, 2] = 30;
                            GameData.ysups[0, 2] = 20;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 4 && System.Array.IndexOf(GameData.candiates, "Mr Wu") < 0 && GameData.candiates[3] == null)
                        {
                            candiselect.SetActive(false);
                            btn4.interactable = false;
                            btn4.image.sprite = Wu;
                            txt4.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[3] = "Mr Wu";
                            GameData.candiatesnum[3] = "003f87ad";
                            GameData.osups[0, 3] = 30;
                            GameData.ysups[0, 3] = 20;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 5 && System.Array.IndexOf(GameData.candiates, "Mr Wu") < 0 && GameData.candiates[4] == null)
                        {
                            candiselect.SetActive(false);
                            btn5.interactable = false;
                            btn5.image.sprite = Wu;
                            txt5.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[4] = "Mr Wu";
                            GameData.candiatesnum[4] = "003f87ad";
                            GameData.osups[0, 4] = 30;
                            GameData.ysups[0, 4] = 20;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else if (PlayerPrefs.GetInt("playernum") == 6 && System.Array.IndexOf(GameData.candiates, "Mr Wu") < 0 && GameData.candiates[5] == null)
                        {
                            candiselect.SetActive(false);
                            btn6.interactable = false;
                            btn6.image.sprite = Wu;
                            txt6.GetComponent<TMPro.TextMeshProUGUI>().text = _text1;
                            GameData.candiates[5] = "Mr Wu";
                            GameData.candiatesnum[5] = "003f87ad";
                            GameData.osups[0, 5] = 30;
                            GameData.ysups[0, 5] = 20;
                            GameData.check++;
                            _text1 = "";
                            if (GameData.check >= 6)
                            {
                                SceneManager.LoadScene("election");
                                Destroy(candiselect);

                            }
                        }
                        else
                        {
                            //candiselect.SetActive(false);
                            _text1 = "";
                        }
                        break;

                }

            }
            else if(_text1.Length == 8)
            {
                _text1 = "";
            }            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}