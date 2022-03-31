using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// { "status": true,   "race": { "registers": [{ pegaAttributes": "{\"}{}{}]
[System.Serializable]
public class Race
{
    public int version;
    public int id;
    public string roomId;
    public int length;
    public float weatherWindSpeed;
    public float weatherWindDirection;
    public float weatherHumidity;
    public float weatherLight;
    public float weatherFire;
    public int total_registers;
    public Pega[] registers;

    public Race(JObject _jSONObject)
    {
        if (_jSONObject == null) return;
        version = _jSONObject["race"]["version"].Value<int>();
        id = _jSONObject["race"]["id"].Value<int>();
        roomId = _jSONObject["race"]["roomId"].Value<string>();
        length = _jSONObject["race"]["length"].Value<int>();
        weatherWindSpeed = _jSONObject["race"]["weatherWindSpeed"].Value<float>();
        weatherWindDirection = _jSONObject["race"]["weatherWindDirection"].Value<float>();
        weatherHumidity = _jSONObject["race"]["weatherHumidity"].Value<float>();
        weatherLight = _jSONObject["race"]["weatherLight"].Value<float>();
        weatherFire = _jSONObject["race"]["weatherFire"].Value<float>();
        total_registers = _jSONObject["race"]["total_registers"].Value<int>();
        registers = new Pega[total_registers];
        for (int i = 0; i < registers.Length; i++)
        {
            registers[i] = new Pega();
            registers[i].id = _jSONObject["race"]["registers"][i]["id"].Value<int>();
            registers[i].raceId = _jSONObject["race"]["registers"][i]["raceId"].Value<int>();
            registers[i].pegaId = _jSONObject["race"]["registers"][i]["pegaId"].Value<int>();
            registers[i].gate = _jSONObject["race"]["registers"][i]["gate"].Value<int>();
            registers[i].pegaAttributes = new PegaAttributes();
            JObject pegaAtt = JObject.Parse(_jSONObject["race"]["registers"][i]["pegaAttributes"].Value<string>());
            registers[i].pegaAttributes.id = pegaAtt["id"].Value<int>();
            registers[i].pegaAttributes.name = pegaAtt["name"].Value<string>();
            registers[i].pegaAttributes.bloodLine = pegaAtt["bloodLine"].Value<string>();
            registers[i].pegaAttributes.position = pegaAtt["position"].Value<int>();
            registers[i].pegaAttributes.speed = pegaAtt["speed"].Value<float>();
            registers[i].pegaAttributes.strength = pegaAtt["strength"].Value<float>();
            registers[i].pegaAttributes.wind = pegaAtt["wind"].Value<float>();
            registers[i].pegaAttributes.water = pegaAtt["water"].Value<float>();
            registers[i].pegaAttributes.fire = pegaAtt["fire"].Value<float>();
            registers[i].pegaAttributes.lighting = pegaAtt["lighting"].Value<float>();
            registers[i].position = _jSONObject["race"]["registers"][i]["position"].Value<int>();
            registers[i].raceTime = _jSONObject["race"]["registers"][i]["raceTime"].Value<float>();
            //Debug.Log($"raceTime{i}:{registers[i].raceTime}");
        }
    }
}
