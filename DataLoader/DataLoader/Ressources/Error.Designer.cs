﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ogdi.Data.DataLoader.Ressources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Error {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Error() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Ogdi.Data.DataLoader.Ressources.Error", typeof(Error).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
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
        ///   Looks up a localized string similar to Are you want to continue saving ?.
        /// </summary>
        internal static string Continue {
            get {
                return ResourceManager.GetString("Continue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning - Headers can&apos;t contain space character.
        /// </summary>
        internal static string Headers {
            get {
                return ResourceManager.GetString("Headers", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning - Missed csv fields:.
        /// </summary>
        internal static string MissField {
            get {
                return ResourceManager.GetString("MissField", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning - Empty optional fields.
        /// </summary>
        internal static string Optional {
            get {
                return ResourceManager.GetString("Optional", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning - Empty required fields.
        /// </summary>
        internal static string Required {
            get {
                return ResourceManager.GetString("Required", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Warning - Unavailable Field Name :.
        /// </summary>
        internal static string Unavailable {
            get {
                return ResourceManager.GetString("Unavailable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is some warnings in the metadata!.
        /// </summary>
        internal static string Warning {
            get {
                return ResourceManager.GetString("Warning", resourceCulture);
            }
        }
    }
}
