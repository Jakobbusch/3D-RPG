using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{

    public float coins = 0;
    public float Health = 100;

    public Slider healthBar;
    public Text coinText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = Health;
        coinText.text = coins.ToString() + "$";
    }
    
    
}
