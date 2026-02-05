# Guía de Inicio Rápido

## 🚀 Cómo Ejecutar el Proyecto

### Prerrequisitos

- **.NET 8.0 SDK** o superior instalado
- Un editor de código (Visual Studio, VS Code, Rider, etc.)
- Navegador web moderno (Chrome, Edge, Firefox, Safari)

### Verificar .NET SDK

```bash
dotnet --version
```

Debe mostrar 8.0.0 o superior.

---

## Opción 1: Ejecutar desde la Terminal

### 1. Navegar al directorio del proyecto

```bash
cd LabelControlBlazor
```

### 2. Restaurar paquetes

```bash
dotnet restore
```

### 3. Ejecutar el proyecto

```bash
dotnet run
```

### 4. Abrir en el navegador

El proyecto se ejecutará en:

- **HTTPS**: https://localhost:5001
- **HTTP**: http://localhost:5000

Abre cualquiera de estas URLs en tu navegador.

---

## Opción 2: Ejecutar desde Visual Studio

### 1. Abrir el proyecto

- Hacer doble clic en `LabelControlBlazor.csproj`
- O abrir Visual Studio → Abrir un proyecto → Seleccionar `LabelControlBlazor.csproj`

### 2. Ejecutar

- Presionar **F5** (con depuración)
- O presionar **Ctrl+F5** (sin depuración)
- O hacer clic en el botón ▶️ "LabelControlBlazor"

Visual Studio abrirá automáticamente el navegador.

---

## Opción 3: Ejecutar desde VS Code

### 1. Abrir el proyecto

```bash
code .
```

### 2. Instalar extensiones recomendadas

- C# Dev Kit
- C# (Microsoft)

### 3. Ejecutar

- Presionar **F5**
- O en la terminal integrada:
  ```bash
  dotnet run
  ```

---

## 🔥 Hot Reload

El proyecto soporta **Hot Reload**, lo que significa que puedes hacer cambios en el código y ver los resultados sin reiniciar:

```bash
dotnet watch run
```

Ahora cualquier cambio en `.razor`, `.cs` o `.css` se reflejará automáticamente en el navegador.

---

## 📁 Estructura de Archivos Importante

```
LabelControlBlazor/
├── Components/           ← Componente LabelControl
├── Models/              ← Modelos SuperTip
├── Pages/               ← Página de demostración
├── wwwroot/
│   └── css/             ← Estilos CSS
├── Program.cs           ← Punto de entrada
└── App.razor            ← Componente raíz
```

---

## 🧪 Probar el Proyecto

Una vez ejecutado, verás la página demo con **9 ejemplos** diferentes:

1. **BorderStyle = Flat**: Label con borde plano
2. **Load from Resources**: Label simple
3. **TextAlignment = Center**: Texto centrado con borde Office2003
4. **AutoEllipsis**: Texto recortado con puntos suspensivos
5. **AutoSizeMode = Horizontal**: Auto-ajuste horizontal
6. **SuperTip**: SuperTip simple aplicado con botón
7. **Complex SuperTip**: SuperTip con título, contenido, separador e icono
8. **AutoSizeMode = Vertical**: Auto-ajuste vertical
9. **Label con Imagen**: Label con icono y texto subrayado

### Interactuar con SuperTip

- **Pasar el mouse (hover)** sobre los labels con SuperTip para ver los tooltips complejos

---

## 🛠️ Personalización

### Cambiar estilos

Edita: `wwwroot/css/labelcontrol.css`

### Agregar nuevos ejemplos

Edita: `Pages/Index.razor`

### Modificar el componente

Edita: `Components/LabelControl.razor`

### Extender el modelo SuperTip

Edita: `Models/SuperTip.cs`

---

## 🐛 Solución de Problemas

### Error: "No se encuentra el SDK de .NET"

```bash
# Instala .NET 8.0 SDK desde:
https://dotnet.microsoft.com/download/dotnet/8.0
```

### Error: "Puerto ya en uso"

```bash
# Cambia el puerto en Properties/launchSettings.json
# O usa un puerto diferente:
dotnet run --urls="https://localhost:5002;http://localhost:5003"
```

### La página no se actualiza con cambios

```bash
# Usa Hot Reload:
dotnet watch run

# O limpia y reconstruye:
dotnet clean
dotnet build
dotnet run
```

### Los estilos no se aplican

- Asegúrate que `labelcontrol.css` está referenciado en `index.html`
- Limpia la caché del navegador (Ctrl+Shift+R)

---

## 📦 Publicar para Producción

### Build de producción

```bash
dotnet publish -c Release
```

Los archivos compilados estarán en:

```
bin/Release/net8.0/publish/wwwroot/
```

### Desplegar en servidor web

Puedes servir estos archivos desde:

- **IIS** (Windows)
- **Nginx** (Linux)
- **Apache**
- **Azure Static Web Apps**
- **GitHub Pages**
- Cualquier hosting de archivos estáticos

---

## 📚 Recursos Adicionales

- [Documentación Blazor](https://learn.microsoft.com/aspnet/core/blazor)
- [README.md](README.md) - Documentación completa del proyecto
- [ADVANCED_EXAMPLES.md](ADVANCED_EXAMPLES.md) - Ejemplos avanzados
- [COMPARISON.md](COMPARISON.md) - Comparación con Windows Forms

---

## ✅ Checklist de Inicio

- [ ] .NET 8.0 SDK instalado
- [ ] Proyecto clonado/descargado
- [ ] `dotnet restore` ejecutado
- [ ] `dotnet run` ejecutado
- [ ] Navegador abierto en https://localhost:5001
- [ ] Probado hover sobre labels con SuperTip

---

**¡Listo! El proyecto debería estar ejecutándose correctamente.**

Si tienes problemas, revisa la sección de **Solución de Problemas** o consulta la documentación de Blazor.
