# Simulacro de Segundo Parcial – Programación II

Aplicación de consola desarrollada en C# como simulacro del segundo parcial de la materia
**Programación II**.

El objetivo del proyecto es gestionar pedidos aplicando distintos patrones de diseño,
arquitectura desacoplada y persistencia en JSON.

## 📄 Consigna
La consigna original del parcial se encuentra disponible en:
📁 `docs/consigna.pdf`

Resumen de lo solicitado:
- Aplicación de consola en C#
- Uso de patrones:
  - Builder (construcción del pedido)
  - Strategy (tipos de envío)
  - Observer (notificaciones al confirmar pedido)
- Inyección de dependencias
- Patrón Repository
- Persistencia en archivo `pedidos.json`

## 🧱 Arquitectura
El proyecto está organizado siguiendo una arquitectura desacoplada, separando:
- Lógica de negocio
- Controladores / fachada
- Persistencia
- Presentación por consola

Toda la lógica se encuentra fuera de `Program.cs`.

## 🛠️ Tecnologías
- C#
- .NET
- System.Text.Json
- Patrones de diseño (Builder, Strategy, Observer)
- Inyección de Dependencias

## ▶️ Ejecución
Ejecutar el proyecto desde `Program.cs`.  
La aplicación permite:
- Agregar productos al pedido
- Seleccionar tipo de envío
- Confirmar el pedido
- Guardar pedidos confirmados en `pedidos.json`

