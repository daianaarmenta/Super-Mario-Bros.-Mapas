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
    private Button botonSalir;

    void OnEnable()
    {
        menu = GetComponent<UIDocument>();
        var root = menu.rootVisualElement;
        botonJugar = root.Q<Button>("jugar"); //Tiene que coincidir con el nombre del botón en el archivo UXML
        botonAyuda = root.Q<Button>("ayuda");
        botonCreditos = root.Q<Button>("creditos");
        botonSalir = root.Q<Button>("botonSalir");
        //Callbacks
        botonJugar.RegisterCallback<ClickEvent, String>(IniciarJuego, "NivelMario");
        botonAyuda.RegisterCallback<ClickEvent, String>(IniciarJuego, "Ayuda");
        botonCreditos.RegisterCallback<ClickEvent, String>(IniciarJuego, "Creditos");

        botonSalir.clicked += SalirDelJuego;
    }

    private void IniciarJuego(ClickEvent evt, String scene)
    {
        SceneManager.LoadScene(scene);
    }
    private void SalirDelJuego()
    {
        Application.Quit();

        Debug.Log("Saliendo del juego");
    }


}
