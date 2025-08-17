# lista_horizontal_numeros_enteros

<img width="2556" height="1079" alt="image" src="https://github.com/user-attachments/assets/ba4d6af9-6289-4b01-a3c8-e422c5f32d15" />

# 🧮 Crear una Aplicación WinForms en .NET con una Lista Horizontal de Números

Esta guía paso a paso te mostrará cómo crear una aplicación en .NET (Windows Forms) que muestre una lista horizontal con números del 1 al 35, donde cada número aparece en su propia casilla (por ejemplo, un `Button`, `Label` o `TextBox`).

---

## ✅ Requisitos

- Visual Studio 2022  
- .NET Framework o .NET Core (puedes usar cualquiera en un proyecto WinForms)

---

## 🛠 Paso a Paso en Visual Studio

### 1. Crear un nuevo proyecto

1. Abre **Visual Studio 2022**.
2. Crea un **nuevo proyecto**.
3. Elige **Windows Forms App (.NET Framework)** o **Windows Forms App (.NET Core)**.
4. Asigna un nombre como: `ListaHorizontalNumeros`.
5. Haz clic en **"Crear"**.

---

### 2. Diseñar la interfaz

Puedes usar un `FlowLayoutPanel` para distribuir automáticamente los controles en una línea horizontal.

#### 🧩 Añadir los controles

1. Desde la caja de herramientas (**Toolbox**), arrastra un `FlowLayoutPanel` al formulario (`Form1`).
2. Cambia estas propiedades:

| Propiedad         | Valor            |
|-------------------|------------------|
| `Name`            | `flowLayoutPanelNumeros` |
| `FlowDirection`   | `LeftToRight`    |
| `WrapContents`    | `False`          |
| `AutoScroll`      | `True`           |

---

### 3. Código para llenar la lista

Haz doble clic en el formulario (en blanco) para abrir el evento `Form1_Load` y agrega este código:

```csharp
private void Form1_Load(object sender, EventArgs e)
{
    for (int i = 1; i <= 35; i++)
    {
        // Puedes usar Label, Button o TextBox. Aquí usamos Label.
        Label numeroLabel = new Label();
        numeroLabel.Text = i.ToString();
        numeroLabel.Width = 40;
        numeroLabel.Height = 40;
        numeroLabel.TextAlign = ContentAlignment.MiddleCenter;
        numeroLabel.BorderStyle = BorderStyle.FixedSingle;
        numeroLabel.Margin = new Padding(5);

        flowLayoutPanelNumeros.Controls.Add(numeroLabel);
    }
}
🎨 Resultado
Al ejecutar la aplicación:

Se mostrará una lista horizontal con 35 casillas individuales (Label) del 1 al 35.

Si el formulario no tiene espacio suficiente, aparecerá una barra de desplazamiento horizontal.

✅ Opcional: Mejoras Visuales
Puedes personalizar cada casilla:

numeroLabel.BackColor = Color.LightBlue;
numeroLabel.Font = new Font("Arial", 12, FontStyle.Bold);
O utilizar Button en lugar de Label si deseas interacción:

Button numeroButton = new Button();
numeroButton.Text = i.ToString();
// ... aplicar propiedades similares
