    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class UICharacterItem : MonoBehaviour
    {
        public GameObject characterImage;  // Hình ảnh của character
        public int id;

        public void Setup()
        {
            if (PlayerPrefs.GetInt("CharacterSelected") == id)
            {
                characterImage.SetActive(true);
            }
            else 
            {
                // Nếu không có character nào được chọn, hiển thị mặc định character có id -1
                characterImage.SetActive(false);
            }
        }
    }
