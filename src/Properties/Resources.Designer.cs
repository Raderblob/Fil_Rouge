﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FilRouge.Properties {
    using System;
    
    
    /// <summary>
    ///   Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    /// </summary>
    // Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    // à l'aide d'un outil, tel que ResGen ou Visual Studio.
    // Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    // avec l'option /str ou régénérez votre projet VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FilRouge.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Remplace la propriété CurrentUICulture du thread actuel pour toutes
        ///   les recherches de ressources à l'aide de cette classe de ressource fortement typée.
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
        ///   Recherche une ressource localisée de type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap chefdeuvre {
            get {
                object obj = ResourceManager.GetObject("chefdeuvre", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à CodeRGB  Name | Type(0=D馗or/1=SpecialFloor | id | Forme (0=Rectangle/1=Cercle/2=Ellipse) | longueur | largeur | Franchissabilit・| (ChangePV) | (ChangeV) 
        ///243 25 145  Exemple | 0 | 0 | 0 | 10 | 10 | 0 
        ///.
        /// </summary>
        internal static string Format_Objet {
            get {
                return ResourceManager.GetString("Format_Objet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à 15 19 119 mur | 0 | 0 | 0 | 1 | 1 | 0 
        ///2 2 2 poubelle | 0 | 1 | 1 | 1 | 0 
        ///208 204 215 gobelin non-binaire | 0 | 0 | 0 | 0 | 0 | 0
        ///100 100 100 salle beacon
        ///150 150 150 corner
        ///22 22 22 vide de gimp
        ///255 105 51 Objet de test | 0 | 0 | 0 | 10 | 10 | 1 
        ///128 64 0 porte.
        /// </summary>
        internal static string index_test_format {
            get {
                return ResourceManager.GetString("index_test_format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une chaîne localisée semblable à 15 19 119 mur 
        ///2 2 2 poubelle
        ///208 204 215 gobelin non-binaire
        ///100 100 100 salle beacon
        ///150 150 150 corner
        ///0 0 0 noir
        ///22 22 22 vide de gimp
        ///255 105 51 Objet de test
        ///128 64 0 porte.
        /// </summary>
        internal static string index2 {
            get {
                return ResourceManager.GetString("index2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap salle {
            get {
                object obj = ResourceManager.GetObject("salle", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap salle_objet {
            get {
                object obj = ResourceManager.GetObject("salle_objet", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap salle_objet_porte {
            get {
                object obj = ResourceManager.GetObject("salle_objet_porte", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Recherche une ressource localisée de type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap salle2 {
            get {
                object obj = ResourceManager.GetObject("salle2", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
