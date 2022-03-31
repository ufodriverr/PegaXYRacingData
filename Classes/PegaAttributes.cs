using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//"{\"id\":186511,\"name\":\"Gianni Quitzon\",\"ownerId\":5577545,\"raceClass\":1,\"races\":12,\"win\":1,\"lose\":11,\"energy\":8,\"gender\":\"Male\",
//\"bloodLine\":\"Hoz\",\"breedType\":\"Pacer\",\"speed\":0.030481481481481484,\"strength\":0.9,\"wind\":0.5022222222222221,\"water\":15,\"fire\":1.1111111111111112,
//\"lighting\":6.4,\"position\":3500,\"finished\":true,\"raceTime\":31.098,\"result\":6,\"gate\":4,\"lastSpeed\":22.952589602194788,\"stage\":4,\"isTopSpeedReached\":false,
//\"bonusStage\":true,\"topSpeed\":22.952589602194788,\"s0\":0,\"j0\":-0.02,\"a0\":0.5072414814814815,\"v0\":21.677312350480133,\"t0\":153.20000000000002,\"gears\":{},\"pb\":0}"
[System.Serializable]
public class PegaAttributes
{
    public int id;
    public string name;
    public string bloodLine;
    public float speed;
    public float strength;
    public float wind;
    public float water;
    public float fire;
    public float lighting;
    public int position;
    public float originalSpeed;
    public float originalStrength;
    public float originalWind;
    public float originalWater;
    public float originalFire;
    public float originalLighting;
}
