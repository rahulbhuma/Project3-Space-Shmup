using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Utils : MonoBehaviour {

static public Material[] GetAllMaterials( GameObject go ) { // a
Renderer[] rends = go.GetComponentsInChildren<Renderer>(); // b
List<Material> mats = new List<Material>();
foreach (Renderer rend in rends) { // c
mats.Add( rend.material );
}
return( mats.ToArray() ); // d
}
}
