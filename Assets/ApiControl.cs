using UnityEngine;
using System.Net;
using System;
using System.IO;
using System.Threading.Tasks;
public class ApiControl : MonoBehaviour
{
    //private const float API_CHECK_MAXTIME = 0.1f;
    //private float apiCheckCountdown = API_CHECK_MAXTIME;
    //private void Start()
    //{
    //    GetInfo();
    //}
    //private void Update()
    //{
    //    apiCheckCountdown -= Time.deltaTime;
    //    if (apiCheckCountdown <= 0)
    //    {
    //        GetInfo();
    //        apiCheckCountdown = API_CHECK_MAXTIME;
    //    }
    //}
    //public async void GetInfo()
    //{
    //    string oracle = (await GetScryfall().oracle_text);
    //    Debug.Log(oracle);
    //}
    //private async Task<ScryfallInfo> GetScryfall()
    //{
    //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.scryfall.com/cards/random");
    //    HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
    //    StreamReader reader = new StreamReader(response.GetResponseStream());
    //    string jsonResponse = reader.ReadToEnd();
    //    ScryfallInfo info = JsonUtility.FromJson<ScryfallInfo>(jsonResponse);
    //    return info;
    //}
}