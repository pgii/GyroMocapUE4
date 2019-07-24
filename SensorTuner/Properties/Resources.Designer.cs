namespace SensorTuner.Properties {
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SensorTuner.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        internal static System.Drawing.Bitmap SilhouettesMan_300_400 {
            get {
                object obj = ResourceManager.GetObject("SilhouettesMan_300_400", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        internal static System.Drawing.Bitmap WiFiConnection {
            get {
                object obj = ResourceManager.GetObject("WiFiConnection", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        internal static System.Drawing.Bitmap WiFiNoConnection {
            get {
                object obj = ResourceManager.GetObject("WiFiNoConnection", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
