﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema_POS.Properties {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Sistema_POS.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a &lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///&lt;head&gt;&lt;meta http-equiv=&quot;cache-control&quot; content=&quot;no-cache&quot;&gt;&lt;meta http-equiv=&quot;Pragma&quot; content=&quot;no-cache&quot;&gt;&lt;meta http-equiv=&quot;Expires&quot; content=&quot;-1&quot;&gt;
        ///
        ///&lt;style type=&quot;text/css&quot;&gt;
        ///.header { border-style: solid; font-size: 100%; line-height: 50%; padding: 2em;}
        ///.client { margin-top: 1em; margin-bottom:}
        ///
        ///&lt;/style&gt;
        ///
        ///&lt;title&gt;@Title&lt;/title&gt;
        ///&lt;/head&gt;
        ///&lt;body&gt;
        ///&lt;!-- Start your code here --&gt;
        ///
        ///&lt;table class=&quot;header&quot; width=&quot;100%&quot;&gt;
        ///  &lt;tbody&gt;&lt;tr&gt;
        ///    &lt;td width=&quot;60%&quot;&gt;&lt;h1&gt;@BusinessName&lt;/h1&gt;&lt;/td&gt;
        ///  [resto de la cadena truncado]&quot;;.
        /// </summary>
        internal static string Plantilla {
            get {
                return ResourceManager.GetString("Plantilla", resourceCulture);
            }
        }
    }
}
