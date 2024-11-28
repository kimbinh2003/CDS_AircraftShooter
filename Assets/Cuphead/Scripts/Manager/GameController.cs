using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject character00, character01, character02,
        character03, character04, character05;

    public int TestCharacter = -1;

    private void Start()
    {
        // Lúc vào game -=> xuất hiện nhân vật mà mình chọn lúc đầu
        // Spawn => mình cần biết mình spawn ra prefab nào
        int characterSelected = PlayerPrefs.GetInt("CharacterSelected", 0);

        if (TestCharacter != -1)
        {
            characterSelected = TestCharacter;
        }

        if (characterSelected == 0)
        {
            // Sinh ra cupHead
            Instantiate(character00);
        }
        else if (characterSelected == 1)
        {
            // Chalice
            Instantiate(character01);
        }
        else if (characterSelected == 2)
        {
            // Chalice
            Instantiate(character02);
        }
        else if (characterSelected == 3)
        {
            Instantiate(character03);
        }
        else if (characterSelected == 4)
        {
            Instantiate(character04);
        }
        else if (characterSelected == 5)
        {
            Instantiate(character05);
        }

    }
}
