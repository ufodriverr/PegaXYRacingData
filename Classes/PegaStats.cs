using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//"name":"Pegasus", "ownerAddress":"0xdDfdcEeC83d6070D50C070010E3be702225da39E", "renterAddress":"0x506b00D8c236086855164bBa1826127EF2CcaaDb","energy":16,
//   "lastReduceEnergy":1648699604, "inService":"RENT_SERVICE", "inRace":"", "breedCount":4, "fatherId":null,
//   "motherId":null, "pegaTotalRaces":18, "win":2, "lose":16, "speed":4.06, "strength":5.19, "wind":4.79,
//   "fire":4.01, "water":8.42, "lightning":7.83, "gender":"Female", "bloodLine":"Zan", "breedType":"Founding",
//   "bornTime":1636272054, "winRate":0.11, "lastBreedTime":1644824651, "rentTimeEnd":99999999999, "isBanned":false,
//   "canRaceAt":1636617654
[System.Serializable]
public class PegaStats
{
    public int id;
    public string name;
    public float speed;
    public float strength;
    public float wind;
    public float water;
    public float fire;
    public float lightning;
    public string bloodLine;
    public float winRate;

    public PegaStats(JObject _jSONObject)
    {
        if (_jSONObject == null) return;
        id = _jSONObject["id"].Value<int>();
        name = _jSONObject["name"].Value<string>();
        speed = _jSONObject["speed"].Value<float>();
        strength = _jSONObject["strength"].Value<float>();
        wind = _jSONObject["wind"].Value<float>();
        water = _jSONObject["water"].Value<float>();
        fire = _jSONObject["fire"].Value<float>();
        lightning = _jSONObject["lightning"].Value<float>();
        bloodLine = _jSONObject["bloodLine"].Value<string>();
        winRate = _jSONObject["winRate"].Value<float>();
    }
}
