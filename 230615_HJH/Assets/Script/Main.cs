using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    List<Character> characterList;


     void Start()
    {
        characterList = new List<Character>();

        CreateCharacter(new Character("ashe" , "archer" , 100, 30));
        CreateCharacter(new Character("teemo", "thief", 80, 20));
        CreateCharacter(new Character("ezreal", "mage", 70, 100));

        RemoveCharater(2);
        CreateCharacter(new Character("ashe", "archer", 100, 30));
    }

    public void CreateCharacter(Character c) {
        characterList.Add(c);
    }
    public void RemoveCharater(int index) {
        characterList.RemoveAt(index);

        }

   public void PrintAllCharacter() {

        int i = 0;
        if(characterList.Count == 0)
        {
            Debug.Log("비어잇습니다");
        }


        while(i < characterList.Count){
            characterList[i].GetInfo();
            i++;
        }
    
    }

}