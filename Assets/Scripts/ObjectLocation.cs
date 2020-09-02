using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class ObjectLocation : MonoBehaviour
{
    private GameObject[] allObjects;
    // Start is called before the first frame update
    void Start()
    {

        allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();

             string ruta = "C:/Users/alanh/Documents" + "/" + "nombrePosisionArchivo" + ".csv";
 
     //El archivo existe? lo BORRAMOS
     if (File.Exists(ruta))
     {
         File.Delete(ruta);
     }
 
     //Crear el archivo
     var sr = File.CreateText(ruta);
     
        foreach(GameObject gO in allObjects){
if (!(gO.CompareTag("stage"))){
string data = gO.name + ",";
data+=gO.transform.position.x + ",";
data+=gO.transform.position.y + ",";
data+=gO.transform.position.z + ",";

Vector3 q = gO.transform.rotation.eulerAngles;
data+=q.x + ",";
data+=q.y + ",";
data+=q.z + ",";

sr.WriteLine(data);
            }
        }
     
     

 
     //Cerrar
     sr.Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
