﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Intersect.Properties
{
    using System;


    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute( "System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0" )]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ExceptionMessages
    {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute( "Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode" )]
        internal ExceptionMessages()
        {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute( global::System.ComponentModel.EditorBrowsableState.Advanced )]
        internal static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if( object.ReferenceEquals( resourceMan, null ) )
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager( "Intersect.Properties.ExceptionMessages", typeof( ExceptionMessages ).Assembly );
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute( global::System.ComponentModel.EditorBrowsableState.Advanced )]
        internal static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Plugin entry type found in the assembly does not have a generic constructor..
        /// </summary>
        internal static string FoundPluginEntryTypeMissingDefaultConstructor
        {
            get
            {
                return ResourceManager.GetString( "FoundPluginEntryTypeMissingDefaultConstructor", resourceCulture );
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to No plugin assembly was found for the provided path..
        /// </summary>
        internal static string MissingPluginAssembly
        {
            get
            {
                return ResourceManager.GetString( "MissingPluginAssembly", resourceCulture );
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unable to find a plugin entry type in:.
        /// </summary>
        internal static string MissingPluginEntryExceptionAssemblyName
        {
            get
            {
                return ResourceManager.GetString( "MissingPluginEntryExceptionAssemblyName", resourceCulture );
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unable to find a plugin entry type in the assembly..
        /// </summary>
        internal static string MissingPluginEntryExceptionDefault
        {
            get
            {
                return ResourceManager.GetString( "MissingPluginEntryExceptionDefault", resourceCulture );
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to PluginBootstrap factory needs at lease one non-null argument of type &apos;{0}&apos;..
        /// </summary>
        internal static string PluginBootstrapContextMissingPluginArgument
        {
            get
            {
                return ResourceManager.GetString( "PluginBootstrapContextMissingPluginArgument", resourceCulture );
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Swallowing unexpected exception from {0}..
        /// </summary>
        internal static string SwallowingExceptionFrom
        {
            get
            {
                return ResourceManager.GetString( "SwallowingExceptionFrom", resourceCulture );
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Swallowing unexpected exception from {0}.{1}..
        /// </summary>
        internal static string SwallowingExceptionFromWithQualifiedName
        {
            get
            {
                return ResourceManager.GetString( "SwallowingExceptionFromWithQualifiedName", resourceCulture );
            }
        }
    }
}
