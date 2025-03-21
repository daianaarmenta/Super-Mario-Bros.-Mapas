using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
public class MenuController : MonoBehaviour
{
    private UIDocument menu; //objeto en la escena

    private Button botonJugar; //Componente de la UI
    private Button botonAyuda;
    private Button botonCreditos;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;
        botonJugar = root.Q<Button>("Jugar"); //Tiene que coincidir con el nombre del botón en el archivo UXML
        botonAyuda = root.Q<Button>("Ayuda");
        botonCreditos = root.Q<Button>("Creditos");
        //Callbacks
        botonJugar.RegisterCallback<ClickEvent, String>(IniciarJuego, "NivelMario");
        botonAyuda.RegisterCallback<ClickEvent, String>(IniciarJuego, "Ayuda");
        botonCreditos.RegisterCallback<ClickEvent, String>(IniciarJuego, "Creditos");
    }

    private void IniciarJuego(ClickEvent evt, String scene)
    {
        SceneManager.LoadScene(scene);
    }


}
