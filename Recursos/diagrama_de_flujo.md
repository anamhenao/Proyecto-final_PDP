```mermaid
graph TD
    subgraph FormInicio.cs (C# Frontend)
        A[App Inicia / Constructor] --> B(Inicializar Componentes);
        B --> C[Llamar PosicionarAleatoriamente];
        C --> D{Formulario se Muestra en Posición Random};
        
        D --> E{Usuario Hace Clic};
        
        E -- Clic en 'Login' (btnLogin_Click) --> F[Crear FormInicioSesion];
        F --> G[Mostrar FormInicioSesion];
        G --> H[Ocultar FormInicio];
        
        E -- Clic en 'Registro' (btnRegistro_Click) --> I[Crear FormConfirmacion];
        I --> J[Deshabilitar FormInicio (this.Enabled = false)];
        J --> K[Mostrar FormConfirmacion];
        K --> L(FormConfirmacion Cerrado);
        L --> M[Habilitar FormInicio (this.Enabled = true)];
    end 
```