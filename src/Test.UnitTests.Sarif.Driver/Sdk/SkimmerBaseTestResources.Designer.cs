﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.CodeAnalysis.Test.UnitTests.Sarif.Driver.Sdk {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SkimmerBaseTestResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SkimmerBaseTestResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.CodeAnalysis.Test.UnitTests.Sarif.Driver.Sdk.SkimmerBaseTestResources", typeof(SkimmerBaseTestResources).Assembly);
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
        ///   Looks up a localized string similar to This test plainly failed for &apos;{0}&apos;..
        /// </summary>
        internal static string TEST1001_Failed {
            get {
                return ResourceManager.GetString("TEST1001_Failed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Here&apos;s a piece of information for you re: &apos;{0}&apos;..
        /// </summary>
        internal static string TEST1001_Information {
            get {
                return ResourceManager.GetString("TEST1001_Information", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This test  _failed_ for &apos;{0}&apos; resulting in a quality **markdown**..
        /// </summary>
        internal static string TEST1001_Markdown_Error {
            get {
                return ResourceManager.GetString("TEST1001_Markdown_Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This test  _passed_ for &apos;{0}&apos; resulting in a quality **markdown**..
        /// </summary>
        internal static string TEST1001_Markdown_Pass {
            get {
                return ResourceManager.GetString("TEST1001_Markdown_Pass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to We note that there may be a low priority issues to address in &apos;{0}&apos;..
        /// </summary>
        internal static string TEST1001_Note {
            get {
                return ResourceManager.GetString("TEST1001_Note", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The jury is still out on &apos;{0}&apos;; no verdict is returned..
        /// </summary>
        internal static string TEST1001_Open {
            get {
                return ResourceManager.GetString("TEST1001_Open", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This test plainly passed for &apos;{0}&apos;..
        /// </summary>
        internal static string TEST1001_Pass {
            get {
                return ResourceManager.GetString("TEST1001_Pass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; should be reviewed for possible issues..
        /// </summary>
        internal static string TEST1001_Review {
            get {
                return ResourceManager.GetString("TEST1001_Review", resourceCulture);
            }
        }
    }
}
