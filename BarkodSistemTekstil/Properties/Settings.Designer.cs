﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BarkodSistemTekstil.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-FANH6EM\\SQLEXPRESS;Initial Catalog=BarcodeSystem;Integrated S" +
            "ecurity=True")]
        public string BarcodeSystemConnectionString {
            get {
                return ((string)(this["BarcodeSystemConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-FANH6EM\\SQLEXPRESS;Initial Catalog=BarcodeSystem;Integrated S" +
            "ecurity=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False")]
        public string BarcodeSystemConnectionString1 {
            get {
                return ((string)(this["BarcodeSystemConnectionString1"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-FANH6EM\\SQLEXPRESS;Initial Catalog=BarcodeSystem;Integrated S" +
            "ecurity=True;Connect Timeout=30;TrustServerCertificate=False")]
        public string BarcodeSystemConnectionString2 {
            get {
                return ((string)(this["BarcodeSystemConnectionString2"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=HasanKorkmaz\\HASANKORKMAZ;Initial Catalog=BarcodeSystem;Integrated Se" +
            "curity=True")]
        public string BarcodeSystemConnectionString3 {
            get {
                return ((string)(this["BarcodeSystemConnectionString3"]));
            }
        }
    }
}
