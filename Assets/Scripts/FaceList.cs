using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceList : MonoBehaviour {

    public List<GameObject> list_Face;

    private int n_Index;


    private void Awake()
    {
        n_Index = 0;
      
    }


    public void NextFace()
    {
        if(list_Face.Count - 1 == n_Index)
        {

            return;
        }

        ++n_Index;

    }

    public void PrevFace()
    {

    }



}
