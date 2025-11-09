# Diagrama de secuencia — Flujo de la aplicación

El siguiente bloque contiene el diagrama de secuencia en sintaxis Mermaid. Puedes previsualizarlo en VS Code (extensiones Mermaid) o en https://mermaid.live

```mermaid
sequenceDiagram
    participant User
    participant Application
    participant FileSystem
    
    rect rgb(230, 230, 255)
    note over Application: 🔲 Flujo de FormInicio.cs (Inicio)
    Application-->>Application: 1: Inicializar Componentes / PosicionarAleatoriamente
    end
    
    User->>Application: 2: Formulario 'Inicio' se Muestra

    alt Clic en 'Login' (btnLogin_Click)
        User->>Application: 3.1: Clic en Login
        Application->>Application: 3.2: Crear FormInicioSesion
        Application->>Application: 3.3: Mostrar FormInicioSesion
        Application->>User: 3.4: Ocultar FormInicio
        
        rect rgb(255, 240, 230)
        note over Application: 🔑 Flujo FormInicioSesion.cs (Login)
        Application-->>Application: 3.5: Constructor / PosicionarAleatoriamente
        Application->>Application: 3.6: PrepararArchivo()
        Application->>FileSystem: 3.7: Verificar/Crear usuarios.txt
        end
        
        User->>Application: 4.1: Ingresar Credenciales y Clic en Iniciar Sesión
        Application-->>Application: 4.2: Verificar Campos Vacíos
        
        alt Campos Vacíos
            Application->>User: 4.3: Mostrar MessageBox ("¿Vacío?...")
        else Credenciales Ingresadas
            Application->>FileSystem: 5.1: Leer todas las líneas de usuarios.txt
            loop por cada línea en el archivo
                Application-->>Application: 5.2: Buscar Usuario y Contraseña
                alt Usuario y Contraseña Correctos
                    Application-->>Application: 5.3: Setear 'contrasenaCorrecta = true'
                    break
                end
            end
            
            alt Login Exitoso
                Application->>User: 6.1: MessageBox ("Identidad confirmada...")
                Application->>Application: 6.2: Crear FormCaptcha(..., false)
                Application->>Application: 6.3: Mostrar FormCaptcha
                Application->>User: 6.4: Ocultar FormInicioSesion
            else Usuario NO Encontrado
                Application->>User: 7.1: MessageBox ("El usuario no existe. ¿Registrarse?")
                alt Respuesta = YES
                    Application->>Application: 7.2: Crear/Mostrar FormInicio
                    Application->>User: 7.3: Ocultar FormInicioSesion
                end
            else Contraseña Incorrecta
                Application->>User: 8.1: MessageBox ("Contraseña incorrecta...")
            end
        end
        
    else Clic en 'Registro' (btnRegistro_Click)
        User->>Application: 10.1: Clic en Registro
        Application->>Application: 10.2: Crear FormConfirmacion(paso=0)
        Application->>Application: 10.3: Deshabilitar FormInicio
        
        rect rgb(220, 255, 220)
        note over Application: ⚠️ Flujo FormConfirmacion.cs (Advertencias)
        loop Mientras el usuario confirma y hay más mensajes (pasoActual < N-1)
            User->>Application: 11.1: Clic en 'SI' (btnSi_Click)
            Application-->>Application: 11.2: pasoActual++
            Application->>Application: 11.3: Mostrar FormConfirmacion Siguiente
        end
        
        alt Clic en 'SI' (Último Mensaje)
            User->>Application: 12.1: Clic en SI
            Application->>Application: 12.2: Crear FormUsuario
            Application->>Application: 12.3: Mostrar FormUsuario
            
            rect rgb(255, 200, 200)
            note over Application: 🧑 Flujo FormUsuario.cs (Validación de Nombre)
            Application-->>Application: 12.4: Constructor / PosicionarAleatoriamente
            loop Mientras la validación de Nombre falla
                User->>Application: 13.1: Ingresar Nombre y Clic en Continuar
                Application-->>Application: 13.2: Validar Nombre (Largo, Símbolos, etc.)
                alt Validación Falla
                    Application->>User: 13.3: Mostrar Mensaje Aleatorio de Error
                end
            end
            
            User->>Application: 14.1: Ingresar Nombre Válido
            Application->>Application: 14.2: Crear FormContrasena(nombre)
            Application->>Application: 14.3: Mostrar FormContrasena
            
            rect rgb(200, 255, 200)
            note over Application: 🔒 Flujo FormContrasena.cs (Validación de Contraseña)
            Application-->>Application: 14.4: Constructor / PosicionarAleatoriamente
            loop Mientras la contraseña es Inválida
                User->>Application: 15.1: Ingresar Contraseña y Clic en Aceptar
                Application-->>Application: 15.2: Iniciar Validación de Contraseña
                alt Validación Falla (Vocal, Primo, Palíndroma, etc.)
                    Application->>User: 15.3: Mostrar Mensaje Específico de Error
                end
            end
            
            User->>Application: 16.1: Ingresar Contraseña Válida
            Application->>Application: 16.2: Crear FormNacimiento(nombre, contraseña)
            Application->>Application: 16.3: Mostrar FormNacimiento
            
            rect rgb(220, 255, 255)
            note over Application: 🎂 Flujo FormNacimiento.cs (Adivinar Fecha)
            Application-->>Application: 16.4: Constructor / Inicializar Rango
            Application->>Application: 16.5: GenerarNuevaFecha() (Load)
            Application->>User: 16.6: Mostrar Pregunta con Fecha Aleatoria
            
            loop Mientras el rango es > 1 día
                alt Clic en 'Antes' (btnAntes_Click)
                    Application-->>Application: 17.1: fechaMax = fechaActual
                else Clic en 'Después' (btnDespues_Click)
                    Application-->>Application: 17.2: fechaMin = fechaActual
                end
                Application->>Application: 17.3: VerificarRango()
                alt Rango > 1 Día
                    Application->>Application: 17.4: GenerarNuevaFecha()
                else Rango <= 1 Día
                    break
                end
            end
            
            User->>Application: 18.1: Clic en Continuar (o Rango Adivinado)
            Application->>Application: 18.2: Finalizar(fechaEstimada)
            Application-->>Application: 18.3: Iniciar Timer (2000ms)
            
            Timer->>Application: 19.1: Tick (Fin del Retraso)
            Application->>Application: 19.2: Crear FormCaptcha(nombre, contraseña, true)
            Application->>Application: 19.3: Mostrar FormCaptcha
            
            rect rgb(255, 255, 200)
            note over Application: 🤖 Flujo FormCaptcha.cs (Verificación Humana)
            Application-->>Application: 19.4: Constructor / InicializarPreguntas
            Application->>User: 19.5: Muestra Pregunta 1
            
            loop por cada Pregunta (i = 1 a 3)
                User->>Application: 20.1: Ingresar Respuesta y Clic en Enviar
                Application-->>Application: 20.2: Verificar Validación de Pregunta i
                
                alt Validación Exitosa
                    Application-->>Application: 20.3: Avanzar()
                    alt Ultima Pregunta (i == 3)
                        alt _esNuevoUsuario == true
                            Application->>Application: 20.4.1: GuardarUsuario()
                            Application->>FileSystem: 20.4.2: Añadir (nombre;contraseña) a usuarios.txt
                            Application->>User: 20.4.3: MessageBox ("Registrado exitosamente")
                        else Usuario SÍ Existe
                            Application->>User: 20.4.4: MessageBox ("Usuario ya registrado")
                        end
                        
                        Application->>Application: 20.5: Crear FormPanelUniverso
                        Application->>Application: 20.6: Mostrar FormPanelUniverso
                        break
                    end
                else Validación Falla
                    Application->>User: 20.7: Mostrar Resultado(MensajeError, false)
                end
            end
            
            rect rgb(200, 255, 200)
            note over Application: 🪐 Flujo FormPanelUniverso.cs (Panel de Control)
            Application-->>Application: 21.1: Constructor / PosicionarAleatoriamente
            Application-->>Application: 21.2: FormPanelUniverso_Load (Configurar Título/Estado)
            Application->>User: 21.3: Muestra Panel de Control
            
            User->>Application: 22.1: Clic en Botón de Acción
            alt cargando == false
                Application-->>Application: 22.2: EjecutarAccionConCarga(Inicial, Final)
                Application-->>Application: 22.3: Iniciar Timer y ProgressBar
                loop Timer.Tick
                    Timer->>Application: 23.1: Incrementar Barra.Value
                end
                Timer->>Application: 24.1: Timer Tick (Fin)
                Application-->>Application: 24.2: Detener Timer / Remover ProgressBar
                Application->>User: 24.3: Actualizar lblEstado (Mensaje Final, Verde)
            end
            end
            
        else Clic en 'NO' (Cancelación desde Confirmación)
            loop Mientras pasoActual > 0
                User->>Application: 25.1: Clic en NO (Retroceder)
                Application-->>Application: 25.2: Mostrar FormConfirmacion Anterior
            end
            alt Clic en 'NO' (Primer Mensaje)
                User->>Application: 26.1: Clic en NO
                Application->>Application: 26.2: Cerrar FormConfirmacion / Habilitar FormInicio
            end
        end
    end
```
