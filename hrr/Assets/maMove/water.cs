using System.Collections;
using System.Collections.Generic;

using UnityEngine;


public interface SOLIDBois
{
	void AAAA();
	
}
public class RERERe : SOLIDBois
{
    public void AAAA()
    {
        throw new System.NotImplementedException();
    }
}
public class water : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		SOLIDBois __thisdude = new RERERe();
		__thisdude.AAAA();
	}
}
