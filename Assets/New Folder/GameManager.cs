using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    void Start()
    {
          player number1 = new player();
        player number2 = new player();

        number1.InitializePlayer("Player One", 50);
        number2.InitializePlayer("Player Two", 75);

        number1.Health(20);
        number2.Health(true);

        player.ShowPlayerCount();
    }

}
