using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject cupHeadCharacterPrefab;
    public GameObject chaliceCharacterPrefab;
    public GameObject mugmanCharacterPrefab;

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
            Instantiate(cupHeadCharacterPrefab);
        }
        else if (characterSelected == 1)
        {
            // Chalice
            Instantiate(chaliceCharacterPrefab);
        }
        else if (characterSelected == 1)
        {
            // Chalice
            Instantiate(mugmanCharacterPrefab);
        }
    }
}
