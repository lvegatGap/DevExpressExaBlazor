# LabelControl Blazor

Versión Blazor WebAssembly equivalente al proyecto Windows Forms con DevExpress LabelControl.

## 📋 Descripción

Este proyecto demuestra cómo implementar un componente **LabelControl** en Blazor que replica la funcionalidad del control LabelControl de DevExpress, incluyendo el **SuperTip** (tooltips complejos con títulos, contenido, separadores e iconos).

## 🎯 Características Principales

### LabelControl Component

- ✅ **BorderStyle**: None, Simple, Flat, Office2003
- ✅ **AutoSizeMode**: Default, Horizontal, Vertical, None
- ✅ **AutoEllipsis**: Recorte automático de texto con puntos suspensivos
- ✅ **TextAlignment**: Left, Center, Right
- ✅ **TextTrimming**: None, Character, EllipsisCharacter, EllipsisWord
- ✅ **Image Support**: Imágenes con alineación configurable
- ✅ **SuperTip**: Tooltips complejos con múltiples elementos

### SuperTip Component

El SuperTip es equivalente al `DevExpress.Utils.SuperToolTip` y soporta:

- 📌 **SuperTipTitleItem**: Títulos en negrita
- 📝 **SuperTipContentItem**: Contenido con texto e iconos
- ➖ **SuperTipSeparatorItem**: Separadores visuales
- 🎨 Estilos personalizables
- 📏 Ancho máximo configurable

## 🏗️ Estructura del Proyecto

```
LabelControlBlazor/
├── Components/
│   ├── LabelControl.razor          # Componente principal
│   └── LabelControlEnums.cs        # Enumeraciones
├── Models/
│   ├── SuperTip.cs                 # Modelo del SuperTip
│   └── SuperTipItem.cs             # Items del SuperTip
├── Pages/
│   └── Index.razor                 # Página de demostración
├── wwwroot/
│   ├── css/
│   │   ├── app.css                 # Estilos generales
│   │   └── labelcontrol.css        # Estilos del componente
│   └── index.html
├── App.razor
├── Program.cs
└── _Imports.razor
```

## 🚀 Uso del Componente

### Ejemplo Básico

```razor
<LabelControl Text="Hello World!" />
```

### Con BorderStyle

```razor
<LabelControl
    Text="BorderStyle = Flat"
    BorderStyle="BorderStyle.Flat" />
```

### Con SuperTip Simple

```razor
@code {
    private SuperTip simpleTip = new SuperTip("Este es un tooltip simple");
}

<LabelControl
    Text="Hover para ver SuperTip"
    SuperTip="@simpleTip" />
```

### Con SuperTip Complejo

```razor
@code {
    private SuperTip complexTip = new SuperTip()
        .AddTitle("Título del Tooltip")
        .AddContent("Primera línea de contenido", "icon.svg")
        .AddSeparator()
        .AddContent("Segunda línea de contenido");
}

<LabelControl
    Text="Complex SuperTip"
    SuperTip="@complexTip" />
```

### Con Imagen

```razor
<LabelControl
    Text="Label con imagen"
    ImagePath="icon.svg"
    ImageAlignToText="ImageAlignToText.LeftCenter"
    Underline="true" />
```

### Aplicar SuperTip Dinámicamente

```razor
@code {
    private SuperTip? dynamicTip;

    private void ApplySuperTip()
    {
        dynamicTip = new SuperTip("Tooltip aplicado dinámicamente");
    }
}

<LabelControl
    Text="SuperTip Dinámico"
    SuperTip="@dynamicTip" />

<button @onclick="ApplySuperTip">Aplicar SuperTip</button>
```

## 🎨 Modelo del SuperTip

### Clase SuperTip

```csharp
public class SuperTip
{
    public List<SuperTipItem> Items { get; set; }
    public bool AllowHtmlText { get; set; }
    public int MaxWidth { get; set; } = 300;
    public string? CssClass { get; set; }

    // Métodos fluent para construcción
    public SuperTip AddTitle(string text);
    public SuperTip AddContent(string text, string? iconPath = null);
    public SuperTip AddSeparator();
}
```

### Tipos de Items

```csharp
// Título
public class SuperTipTitleItem : SuperTipItem
{
    public SuperTipTitleItem(string text);
}

// Contenido con icono opcional
public class SuperTipContentItem : SuperTipItem
{
    public SuperTipContentItem(string text, string? iconPath = null);
}

// Separador
public class SuperTipSeparatorItem : SuperTipItem
{
    public SuperTipSeparatorItem();
}
```

## 📦 Propiedades del LabelControl

| Propiedad        | Tipo                | Descripción                                       |
| ---------------- | ------------------- | ------------------------------------------------- |
| Text             | string              | Texto del label                                   |
| BorderStyle      | BorderStyle         | Estilo del borde (None, Simple, Flat, Office2003) |
| AutoSizeMode     | LabelAutoSizeMode   | Modo de auto-ajuste de tamaño                     |
| AutoEllipsis     | bool                | Recorte con puntos suspensivos                    |
| TextAlignment    | HorizontalAlignment | Alineación del texto                              |
| Trimming         | TextTrimming        | Tipo de recorte de texto                          |
| Width            | string              | Ancho del label (ej: "200px")                     |
| Height           | string              | Alto del label (ej: "50px")                       |
| ImagePath        | string              | Ruta de la imagen                                 |
| ImageAlignToText | ImageAlignToText    | Alineación de la imagen                           |
| SuperTip         | SuperTip            | Configuración del tooltip complejo                |
| Underline        | bool                | Subrayar el texto                                 |
| FontFamily       | string              | Familia de fuente                                 |
| FontSize         | string              | Tamaño de fuente                                  |
| ForeColor        | string              | Color del texto                                   |
| BackColor        | string              | Color de fondo                                    |

## 🔧 Instalación y Ejecución

1. **Requisitos previos**:
   - .NET 8.0 SDK o superior

2. **Ejecutar el proyecto**:

   ```bash
   cd LabelControlBlazor
   dotnet run
   ```

3. **Abrir en el navegador**:
   - Por defecto: `https://localhost:5001` o `http://localhost:5000`

## 📊 Comparación con Windows Forms

| Característica       | Windows Forms (DevExpress)               | Blazor (Este proyecto)        |
| -------------------- | ---------------------------------------- | ----------------------------- |
| LabelControl         | ✅ `DevExpress.XtraEditors.LabelControl` | ✅ `LabelControl.razor`       |
| SuperToolTip         | ✅ `DevExpress.Utils.SuperToolTip`       | ✅ `SuperTip` model           |
| ToolTipTitleItem     | ✅                                       | ✅ `SuperTipTitleItem`        |
| ToolTipItem          | ✅                                       | ✅ `SuperTipContentItem`      |
| ToolTipSeparatorItem | ✅                                       | ✅ `SuperTipSeparatorItem`    |
| BorderStyles         | ✅                                       | ✅ `BorderStyle` enum         |
| AutoSizeMode         | ✅                                       | ✅ `LabelAutoSizeMode` enum   |
| TextAlignment        | ✅                                       | ✅ `HorizontalAlignment` enum |
| Image Support        | ✅                                       | ✅ Con SVG/Base64 support     |

## 🌟 Características Destacadas

### 1. **API Fluent para SuperTip**

```csharp
var tip = new SuperTip()
    .AddTitle("Título")
    .AddContent("Contenido 1")
    .AddSeparator()
    .AddContent("Contenido 2", "icon.svg");
```

### 2. **Soporte para Iconos**

- Rutas de archivos (SVG, PNG, etc.)
- Data URIs (inline SVG)
- Base64 encoded images

### 3. **CSS Personalizable**

Todos los elementos soportan clases CSS personalizadas para estilos adicionales.

### 4. **Responsive & Accesible**

El tooltip se ajusta automáticamente en dispositivos móviles.

## 📝 Notas de Implementación

- El SuperTip se muestra al hacer **hover** sobre el label
- Los iconos soportan SVG inline, rutas de archivos o Base64
- El componente es completamente reactivo y soporta actualizaciones dinámicas
- Los estilos están separados para facilitar la personalización

## 🔮 Futuras Mejoras

- [ ] Soporte para HTML en el contenido del SuperTip
- [ ] Animaciones personalizables
- [ ] Posicionamiento inteligente del tooltip (evitar salirse de la pantalla)
- [ ] Temas preconfigurados (Light, Dark, DevExpress-like)
- [ ] Accesibilidad mejorada (ARIA labels)

## 📄 Licencia

Este proyecto es de ejemplo educativo.

---

**Desarrollado como equivalente Blazor del proyecto Windows Forms con DevExpress**
