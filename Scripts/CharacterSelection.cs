using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    [SerializeField] private ChooseCharacter transportScript;
    [SerializeField] private GameObject[] characterList;
    [SerializeField] public GameObject[] actualcharacterList;
    [SerializeField] private int index;
    public int World;
	
	private void Start ()
    {
        World = 1;
        index = PlayerPrefs.GetInt("CharacterSelected");

        characterList = new GameObject[transform.childCount];

        // Fill the array with out models
        for (int i = 0; i < transform.childCount; i++)
            characterList[i] = transform.GetChild(i).gameObject;

        // We toggle off their renderer
        foreach (GameObject go in characterList)
            go.SetActive(false);

        // We toggle on the selected character
        if (characterList[index])
            characterList[index].SetActive(true);
        
	}
	
	public void ToggleLeft()
    {
        //Toggle off the current model
        characterList[index].SetActive(false);

        index--;//index -= 1; index = index - 1;
        if (index < 0)
            index = characterList.Length - 1;

        // Toggle on the new model
        characterList[index].SetActive(true);
        if (World > 1)
        {
            World = World - 1;
        }


    }

    public void ToggleRight()
    {   
        //Toggle off the current model
        characterList[index].SetActive(false);

        index++;//index -= 1; index = index - 1;
        if (index == characterList.Length)
            index = 0;

        // Toggle on the new model
        characterList[index].SetActive(true);
        if (World < 3)
        {
            World = World + 1;
        }


    }

    public void ConfirmButton()
    {
        PlayerPrefs.SetInt("CharacterSelected", index);
        if (World == 1)
        {
            SceneManager.LoadScene("World1");
        }
        if (World == 2)
        {
            SceneManager.LoadScene("World2");
        }
        if (World == 3)
        {
            SceneManager.LoadScene("World3 (undone)");
        }
    }
}
