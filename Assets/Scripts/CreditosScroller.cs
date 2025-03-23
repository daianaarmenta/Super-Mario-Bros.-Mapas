using UnityEngine;
using UnityEngine.UIElements;

public class CreditosScroller : MonoBehaviour
{
    public float velocidadScroll = 50f;

    private VisualElement creditos;
    private Label texto;
    private float startY;
    private float endY;
    private bool animacionIniciada = false;

    void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        creditos = root.Q<VisualElement>("creditos");
        texto = root.Q<Label>("texto");

        // Esperar a que se carguen los estilos y tamaños
        Invoke(nameof(InicializarAnimacion), 0.1f);
    }

    void InicializarAnimacion()
    {
        startY = creditos.resolvedStyle.height;
        texto.style.top = startY;

        endY = -texto.resolvedStyle.height;

        animacionIniciada = true;
    }

    void Update()
    {
        if (!animacionIniciada) return;

        float currentTop = texto.style.top.value.value;

        // Mover hacia arriba
        currentTop -= velocidadScroll * Time.deltaTime;
        texto.style.top = currentTop;

        // Reiniciar cuando llegue al final
        if (currentTop <= endY)
        {
            texto.style.top = startY;
        }
    }
}




