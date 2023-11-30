using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.Http;
using TMPro;
public class controller : MonoBehaviour
{
    public TMP_InputField input;
    private static readonly HttpClient client = new HttpClient();
    // Start is called before the first frame update
    void Start()
    {
      
    }
    public async void onChange(){
         Debug.Log(input.text); 
         var responseString = await client.GetStringAsync("https://rishipannala.pythonanywhere.com/example?input=place%20a%20cube");
         Debug.Log(responseString);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
