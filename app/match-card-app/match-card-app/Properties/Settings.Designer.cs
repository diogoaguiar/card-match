﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dino.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"[{""theme"":""animais"",""cards"":[{""id"":1,""name"":""gato"",""image"":""gato.jpg"",""tag"":{""label"":""Card 1"",""id"":""123456789ABC""}},{""id"":2,""name"":""elefante"",""image"":""elefante.jpg"",""tag"":{""label"":""Card 2"",""id"":""123456789DEF""}},{""id"":3,""name"":""carneiro"",""image"":""carneiro.jpg"",""tag"":{""label"":""Card 2"",""id"":""123456789GHI""}}]},{""theme"":""animais2"",""cards"":[{""id"":1,""name"":""gato"",""image"":""gato.jpg"",""tag"":{""label"":""Card 1"",""id"":""123456789ABC""}},{""id"":2,""name"":""elefante"",""image"":""elefante.jpg"",""tag"":{""label"":""Card 2"",""id"":""123456789DEF""}},{""id"":3,""name"":""carneiro"",""image"":""carneiro.jpg"",""tag"":{""label"":""Card 2"",""id"":""123456789GHI""}}]}]")]
        public string themes {
            get {
                return ((string)(this["themes"]));
            }
            set {
                this["themes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("[{\"label\":\"Card 1\",\"id\":\"123456789ABC\"},{\"label\":\"Card 2\",\"id\":\"123456789DEF\"},{\"" +
            "label\":\"Card 3\",\"id\":\"123456789GHI\"}]")]
        public string tags {
            get {
                return ((string)(this["tags"]));
            }
            set {
                this["tags"] = value;
            }
        }
    }
}
