
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderManzanas : MonoBehaviour
{
    int contador = 3;

    public GameObject itemFinal;
    public GameObject PortonCerrado;


    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)){
            Application.Quit();
        }
    }


    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Item"){
            Destroy(other.gameObject);
            contador--;
            if (contador == 0){
                itemFinal.SetActive(true);
            }
        }

        if (other.gameObject.tag == "Finish"){
            Destroy(other.gameObject);
            SceneManager.LoadScene("Ciudad");
        }
        
    }




}