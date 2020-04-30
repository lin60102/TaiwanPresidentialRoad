using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamemaneger : MonoBehaviour
{
    
    public Text plyertxt;
    public Text roundtxt;
    public Text testtxt;
    string text1 = "card";
    readonly Rect _rect1 = new Rect(0, 0, 0, 0);
    public Sprite Chen, Han, Ko, Lai, Lin, Ma, Tsai, Wang, Wu;
    public GameObject txt1, txt2, txt3, txt4, txt5, txt6;
    public Button btn1, btn2, btn3, btn4, btn5, btn6;

    string stracard;
    // Start is called before the first frame update
    void Start()
    {
        GameData.ysuprate[0] = Random.Range(20, 30);
        GameData.osuprate[0] = Random.Range(35, 45);
        changeimg();
        //Debug.Log(GameData.osups[0, 0] + " " + GameData.osups[0, 1] + " " + GameData.osups[0, 2] + " " + GameData.osups[0, 3] + " " + GameData.osups[0, 4] + " " + GameData.osups[0, 5]);
    }

    // Update is called once per frame
    void Update()
    {
        
        
        
        
    }

    void OnGUI()
    {
        GUI.SetNextControlName("tcard1");
        text1 = GUI.TextField(_rect1, text1);
        GUI.FocusControl("tcard1");
        changetxt();
        if (text1 != null && text1.Length == 8)
        {
            strategycard();
        }
        else
        {
            
        }
    }
    void changeimg()
    {
        txt1.GetComponent<TMPro.TextMeshProUGUI>().text = GameData.candiates[0];
        txt2.GetComponent<TMPro.TextMeshProUGUI>().text = GameData.candiates[1];
        txt3.GetComponent<TMPro.TextMeshProUGUI>().text = GameData.candiates[2];
        txt4.GetComponent<TMPro.TextMeshProUGUI>().text = GameData.candiates[3];
        txt5.GetComponent<TMPro.TextMeshProUGUI>().text = GameData.candiates[4];
        txt6.GetComponent<TMPro.TextMeshProUGUI>().text = GameData.candiates[5];
        //btn1
        switch (GameData.candiates[0])
        {
            case "Mr Ma":
                btn1.image.sprite = Ma;
                break;
            case "Mr Chen":
                btn1.image.sprite = Chen;
                break;
            case "Mr Han":
                btn1.image.sprite = Han;
                break;
            case "Mr Ko":
                btn1.image.sprite = Ko;
                break;
            case "Mr Lai":
                btn1.image.sprite = Lai;
                break;
            case "Mr Lin":
                btn1.image.sprite = Lin;
                break;
            case "Ms Tsai":
                btn1.image.sprite = Tsai;
                break;
            case "Mr Wang":
                btn1.image.sprite = Wang;
                break;
            case "Mr Wu":
                btn1.image.sprite = Wu;
                break;
        }
        //btn2
        switch (GameData.candiates[1])
        {
            case "Mr Ma":
                btn2.image.sprite = Ma;
                break;
            case "Mr Chen":
                btn2.image.sprite = Chen;
                break;
            case "Mr Han":
                btn2.image.sprite = Han;
                break;
            case "Mr Ko":
                btn2.image.sprite = Ko;
                break;
            case "Mr Lai":
                btn2.image.sprite = Lai;
                break;
            case "Mr Lin":
                btn2.image.sprite = Lin;
                break;
            case "Ms Tsai":
                btn2.image.sprite = Tsai;
                break;
            case "Mr Wang":
                btn2.image.sprite = Wang;
                break;
            case "Mr Wu":
                btn2.image.sprite = Wu;
                break;
        }
        //btn3
        switch (GameData.candiates[2])
        {
            case "Mr Ma":
                btn3.image.sprite = Ma;
                break;
            case "Mr Chen":
                btn3.image.sprite = Chen;
                break;
            case "Mr Han":
                btn3.image.sprite = Han;
                break;
            case "Mr Ko":
                btn3.image.sprite = Ko;
                break;
            case "Mr Lai":
                btn3.image.sprite = Lai;
                break;
            case "Mr Lin":
                btn3.image.sprite = Lin;
                break;
            case "Ms Tsai":
                btn3.image.sprite = Tsai;
                break;
            case "Mr Wang":
                btn3.image.sprite = Wang;
                break;
            case "Mr Wu":
                btn3.image.sprite = Wu;
                break;
        }
        //btn4
        switch (GameData.candiates[3])
        {
            case "Mr Ma":
                btn4.image.sprite = Ma;
                break;
            case "Mr Chen":
                btn4.image.sprite = Chen;
                break;
            case "Mr Han":
                btn4.image.sprite = Han;
                break;
            case "Mr Ko":
                btn4.image.sprite = Ko;
                break;
            case "Mr Lai":
                btn4.image.sprite = Lai;
                break;
            case "Mr Lin":
                btn4.image.sprite = Lin;
                break;
            case "Ms Tsai":
                btn4.image.sprite = Tsai;
                break;
            case "Mr Wang":
                btn4.image.sprite = Wang;
                break;
            case "Mr Wu":
                btn4.image.sprite = Wu;
                break;
        }
        //btn5
        switch (GameData.candiates[4])
        {
            case "Mr Ma":
                btn5.image.sprite = Ma;
                break;
            case "Mr Chen":
                btn5.image.sprite = Chen;
                break;
            case "Mr Han":
                btn5.image.sprite = Han;
                break;
            case "Mr Ko":
                btn5.image.sprite = Ko;
                break;
            case "Mr Lai":
                btn5.image.sprite = Lai;
                break;
            case "Mr Lin":
                btn5.image.sprite = Lin;
                break;
            case "Ms Tsai":
                btn5.image.sprite = Tsai;
                break;
            case "Mr Wang":
                btn5.image.sprite = Wang;
                break;
            case "Mr Wu":
                btn5.image.sprite = Wu;
                break;
        }
        //btn6
        switch (GameData.candiates[5])
        {
            case "Mr Ma":
                btn6.image.sprite = Ma;
                break;
            case "Mr Chen":
                btn6.image.sprite = Chen;
                break;
            case "Mr Han":
                btn6.image.sprite = Han;
                break;
            case "Mr Ko":
                btn6.image.sprite = Ko;
                break;
            case "Mr Lai":
                btn6.image.sprite = Lai;
                break;
            case "Mr Lin":
                btn6.image.sprite = Lin;
                break;
            case "Ms Tsai":
                btn6.image.sprite = Tsai;
                break;
            case "Mr Wang":
                btn6.image.sprite = Wang;
                break;
            case "Mr Wu":
                btn6.image.sprite = Wu;
                break;
        }

    }
    void strategycard()
    {
        if (GameData.rounds < 6)
        {
            switch (GameData.playerscheck)
            {
                case 0:
                    Checkcard(GameData.rounds, GameData.playerscheck);
                    
                    GameData.playerscheck++;
                    
                    break;
                case 1:
                    Checkcard(GameData.rounds, GameData.playerscheck);
                    
                    GameData.playerscheck++;

                    break;
                case 2:
                    Checkcard(GameData.rounds, GameData.playerscheck);
                   
                    GameData.playerscheck++;

                    break;
                case 3:
                    Checkcard(GameData.rounds, GameData.playerscheck);
                    
                    GameData.playerscheck++;

                    break;
                case 4:
                    Checkcard(GameData.rounds, GameData.playerscheck);
                   
                    GameData.playerscheck++;

                    break;
                case 5:
                    Checkcard(GameData.rounds, GameData.playerscheck);
                    
                    GameData.playerscheck++;
                    

                    break;
            }
            if (GameData.playerscheck > 5) {
                GameData.rounds++;
                GameData.playerscheck = 0;
                copyround();
                if (GameData.rounds >= 3)
                {
                    testtxt.text = "Player 1 " + GameData.candiates[0] + " : \n young supporters: " + GameData.ysups[(GameData.rounds - 2), 0] + " : \n old supporters: " + GameData.osups[(GameData.rounds - 2), 0]
                    + "\n Player 2 " + GameData.candiates[1] + " : \n young supporters: " + GameData.ysups[(GameData.rounds - 2), 1] + " : \n old supporters: " + GameData.osups[(GameData.rounds - 2), 1]
                    + "\n Player 3 " + GameData.candiates[2] + " : \n young supporters: " + GameData.ysups[(GameData.rounds - 2), 2] + " : \n old supporters: " + GameData.osups[(GameData.rounds - 2), 2]
                    + "\n Player 4 " + GameData.candiates[3] + " : \n young supporters: " + GameData.ysups[(GameData.rounds - 2), 3] + " : \n old supporters: " + GameData.osups[(GameData.rounds - 2), 3]
                    + "\n Player 5 " + GameData.candiates[4] + " : \n young supporters: " + GameData.ysups[(GameData.rounds - 2), 4] + " : \n old supporters: " + GameData.osups[(GameData.rounds - 2), 4]
                    + "\n Player 6 " + GameData.candiates[5] + " : \n young supporters: " + GameData.ysups[(GameData.rounds - 2), 5] + " : \n old supporters: " + GameData.osups[(GameData.rounds - 2), 5]
                    + "\n round " + (GameData.rounds - 2) + " young vote rate :" + GameData.ysuprate[(GameData.rounds - 2)]
                    + "\n round " + (GameData.rounds - 2) + " old vote rate :" + GameData.osuprate[(GameData.rounds - 2)];
                }
            }
            

        }
        else //end
        {


        }
        // testtxt.text = "Round: " + (GameData.rounds + 1) + "\n player: " + (GameData.playerscheck + 1) + "\n youngsups: " + GameData.ysups[(GameData.rounds - 1), (GameData.playerscheck - 1)] + "\n oldgsups: " + GameData.osups[(GameData.rounds - 1), (GameData.playerscheck - 1)] + "\n oldgsuprate: " + GameData.osuprate[GameData.rounds];
        


    }
    void copyround()
    {
        for(int i = 0; i < 6; i++)
        {
            GameData.ysups[(GameData.rounds), i] = GameData.ysups[(GameData.rounds - 1), i];
            GameData.osups[(GameData.rounds), i] = GameData.osups[(GameData.rounds - 1), i];
        }
        GameData.ysuprate[(GameData.rounds)] = GameData.ysuprate[(GameData.rounds - 1)];
        GameData.osuprate[(GameData.rounds)] = GameData.osuprate[(GameData.rounds - 1)];
    }
    void changetxt()
    {

        switch (GameData.playerscheck){
            case 0:
                plyertxt.text = "Player "+ (GameData.playerscheck+1).ToString("D1") + " \n" + GameData.candiates[GameData.playerscheck]+ " \n Your turn ";
            break;
            case 1:
                plyertxt.text = "Player " + (GameData.playerscheck + 1).ToString("D1") + " \n" + GameData.candiates[GameData.playerscheck] + " \n Your turn ";
                break;
            case 2:
                plyertxt.text = "Player " + (GameData.playerscheck + 1).ToString("D1") + " \n" + GameData.candiates[GameData.playerscheck] + " \n Your turn ";
                break;
            case 3:
                plyertxt.text = "Player " + (GameData.playerscheck + 1).ToString("D1") + " \n" + GameData.candiates[GameData.playerscheck] + " \n Your turn ";
                break;
            case 4:
                plyertxt.text = "Player " + (GameData.playerscheck + 1).ToString("D1") + " \n" + GameData.candiates[GameData.playerscheck] + " \n Your turn ";
                break;
            case 5:
                plyertxt.text = "Player " + (GameData.playerscheck + 1).ToString("D1") + " \n" + GameData.candiates[GameData.playerscheck] + " \n Your turn ";
                break;

        }
        switch (GameData.rounds)
        {
            case 0:
                roundtxt.text = "Round 1 : Northern Taiwan";
                break;
            case 1:
                roundtxt.text = "Round 2 : Central Taiwan";
                break;
            case 2:
                roundtxt.text = "Round 3 : Southern Taiwan";
                break;
            case 3:
                roundtxt.text = "Round 4 : Northern Taiwan";
                break;
            case 4:
                roundtxt.text = "Round 5 : Central Taiwan";
                break;
            case 5:
                roundtxt.text = "Round 6 : Southern Taiwan";
                break;

        }
    }
    int Checkcard(int r, int p)
    {
        int result=0;
        if (text1.Length == 8)
        {
            string cardnum = text1;
           
            text1 = "";
            if (System.Array.IndexOf(GameData.tradcampa, cardnum) >= 0) {
                if (r == 0 || r == 3)
                {
                    GameData.ysups[r, p] = GameData.ysups[r, p] + 40;
                }else if(r==1 || r==4)
                {
                    GameData.ysups[r, p] = GameData.ysups[r, p] + 40;
                    GameData.osups[r, p] = GameData.osups[r, p] + 40;
                }
                else if (r==2 || r==5)
                {
                    
                    GameData.osups[r, p] = GameData.osups[r, p] + 40;
                }
                result = 1; }
            else if(System.Array.IndexOf(GameData.flyercampa, cardnum) >= 0) {
                if (r == 0 || r == 3)
                {
                    GameData.ysups[r, p] = GameData.osups[r, p] + 40;
                }
                else if (r==1 || r==4)
                {
                    GameData.ysups[r, p] = GameData.ysups[r, p] + 40;                    
                }
                else if (r == 2 || r == 5)
                {
                    GameData.ysups[r, p] = GameData.ysups[r, p] + 40;
                    GameData.osups[r, p] = GameData.osups[r, p] + 40;
                }

                result = 2; }           
            else if (System.Array.IndexOf(GameData.digicampa, cardnum) >= 0) {
                if (r == 0 || r == 3)
                {
                    GameData.ysups[r, p] = GameData.ysups[r, p] + 120;
                }
                else if (r==1 || r==4)
                {
                    GameData.ysups[r, p] = GameData.ysups[r, p] + 40;
                    GameData.osups[r, p] = GameData.osups[r, p] + 40;
                }
                else if (r == 2 || r == 5)
                {
                    GameData.ysups[r, p] = GameData.ysups[r, p] + 40;                    
                }
                result = 3; }
            else if (System.Array.IndexOf(GameData.onlinesmear, cardnum) >= 0) {

                Debug.Log ("Select your target! (Swipe his/her tag)");

                string targetnum;
                while (cardnum!="")
                {
                    targetnum = text1;
                    if (targetnum != cardnum)
                    {
                        int pla;
                        pla=System.Array.IndexOf(GameData.candiatesnum, targetnum);
                        if (pla >= 0)
                        {
                            int incnum = Random.Range(1, 6)*10;
                            GameData.ysups[r, pla] = GameData.ysups[r, pla] - incnum;
                            if (GameData.ysups[r, pla] < 0) { GameData.ysups[r, pla] = 0; }
                            GameData.ysups[r, p]= GameData.ysups[r, pla] + incnum;
                            cardnum = "";
                            Debug.Log("succed online smear");
                        }
                    }
                    
                }

                result = 4; }
            else if (System.Array.IndexOf(GameData.tradsmear, cardnum) >= 0) {

                result = 5; }
            else if (System.Array.IndexOf(GameData.youtuber, cardnum) >= 0) {
                GameData.ysuprate[r] = GameData.ysuprate[r] + 5;
                result = 6; }
            else if (System.Array.IndexOf(GameData.oldclub, cardnum) >= 0) {
                GameData.osuprate[r] = GameData.osuprate[r] + 5;
                result = 7; }
            else if (System.Array.IndexOf(GameData.longdis, cardnum) >= 0) {
                GameData.ysuprate[r] = GameData.ysuprate[r] - 5;
                if (GameData.ysuprate[r] < 0)
                {
                    GameData.ysuprate[r] = 0;
                }
                result = 8; }
            else if (System.Array.IndexOf(GameData.olddisease, cardnum) >= 0) {
                GameData.osuprate[r] = GameData.osuprate[r] - 5;
                if (GameData.osuprate[r] < 0)
                {
                    GameData.osuprate[r] = 0;
                }
                result = 9; }
            else if (System.Array.IndexOf(GameData.onlinepoll, cardnum) >= 0) {

                result = 10; }
            else if (System.Array.IndexOf(GameData.tradpoll, cardnum) >= 0) {

                result = 11; }
            else if (System.Array.IndexOf(GameData.bribe, cardnum) >= 0) {
                int random = Random.Range(0, 100);
                if (random > GameData.bribechance[p]) //sucessful
                {
                    // find the max
                    int[] arr = new int[6];
                    for (int n = 0; n < 6; n++)
                    {
                        arr[n] = GameData.ysups[r, n] + GameData.osups[r, n];
                    }
                    int max = arr[0];
                    int index = 0;
                    for (int k = 1; k < arr.Length; k++)
                    {
                        if (arr[k] > max)
                        {
                            max = arr[k];
                            index = k;
                        }
                    }
                    GameData.ysups[r, p] = GameData.ysups[r, p] + 40;
                    GameData.ysups[r, index] = GameData.ysups[r, index] - 40;
                    if (GameData.ysups[r, index] < 0) { GameData.ysups[r, index] = 0; }
                    GameData.osups[r, p] = GameData.osups[r, p] + 20;
                    GameData.osups[r, index] = GameData.osups[r, index] - 20;
                    if (GameData.osups[r, index] < 0) { GameData.osups[r, index] = 0; }

                    //
                    GameData.bribechance[p] = GameData.bribechance[p] + 33;
                }
                else {
                    GameData.bribechance[p] = GameData.bribechance[p] + 33;
                }

                result = 12; }
        }
        else
        {
            text1 = "";
        }
        return result;
    }
}
