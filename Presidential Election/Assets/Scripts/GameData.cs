using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class GameData
{
    public static string[] candiates=new string[6];
    public static string[] candiatesnum = new string[6];
    public static int[,] ysups = new int[6,6];
    public static int[,] osups = new int[6,6];
    public static int[] ysuprate = new int[6];
    public static int[] osuprate = new int[6];
    public static int check = 0;
    public static bool makesure = false;
    public static int rounds = 0;
    public static int playerscheck = 0;
    public static int[] bribechance = new int[6] { 33, 33, 33, 33, 33, 33 };
    public static string[] characters = new string[9] { "003f87be", "0061df79", "0061df72", "000bae57", "000bae54", "000bae41", "000bae3e", "003f87a8", "003f87ad" };
                                                       //Ma, Chen, Han, Ko, Lai, Lin, Tsai, Wang, Wu
    public static string[] tradcampa = new string[5] {"004055b2","0040608d","00406086","00406077","00406070"};
    public static string[] flyercampa = new string[5] { "004055ad", "004054c3", "004054c8", "004054d9", "004054de" };
    public static string[] digicampa = new string[5] { "00617d35", "0061b187", "0061b19a", "0061b19d", "0061b1b0" };
    public static string[] onlinesmear = new string[5] { "000bad75", "003f61db", "00406121", "0061b1b3", "003f61d6" };
    public static string[] tradsmear = new string[5] { "000baff4", "003f61c0", "000bafe9", "000bafd3", "003f61c5" };
    public static string[] youtuber = new string[5] { "001efb61", "001efb72", "001efb77", "001efb8e", "001efb89" };
    public static string[] oldclub = new string[5] { "003f6229", "003f622a", "003f623f", "003f6240", "001efcbd" };
    public static string[] longdis = new string[5] { "00617d3a", "00617d4b", "001e7aa8", "001e7aa7", "001e7a92" };
    public static string[] olddisease = new string[5] { "001e7ae9", "001e7ad4", "001e7ad3", "001e7abe", "001e7abd" };
    public static string[] onlinepoll = new string[5] { "006184ae", "0061849b", "006184b1", "00618498", "00618485" };
    public static string[] tradpoll = new string[5] { "003f92dc", "00618459", "0061846c", "0061846f", "00618482" };
    public static string[] bribe = new string[5] { "003f6214", "000be18b", "000bb11a", "000bb127", "000bb130" };
}
