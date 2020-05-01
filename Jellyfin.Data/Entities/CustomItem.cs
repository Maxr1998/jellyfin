//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor
//     https://github.com/msawczyn/EFDesigner
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Jellyfin.Data.Entities
{
   public partial class CustomItem: global::Jellyfin.Data.Entities.LibraryItem
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected CustomItem(): base()
      {
         CustomItemMetadata = new System.Collections.Generic.HashSet<global::Jellyfin.Data.Entities.CustomItemMetadata>();
         Releases = new System.Collections.Generic.HashSet<global::Jellyfin.Data.Entities.Release>();

         Init();
      }

      /// <summary>
      /// Replaces default constructor, since it's protected. Caller assumes responsibility for setting all required values before saving.
      /// </summary>
      public static CustomItem CreateCustomItemUnsafe()
      {
         return new CustomItem();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="urlid">This is whats gets displayed in the Urls and API requests. This could also be a string.</param>
      public CustomItem(Guid urlid, DateTime dateadded)
      {
         this.UrlId = urlid;

         this.CustomItemMetadata = new System.Collections.Generic.HashSet<global::Jellyfin.Data.Entities.CustomItemMetadata>();
         this.Releases = new System.Collections.Generic.HashSet<global::Jellyfin.Data.Entities.Release>();

         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="urlid">This is whats gets displayed in the Urls and API requests. This could also be a string.</param>
      public static CustomItem Create(Guid urlid, DateTime dateadded)
      {
         return new CustomItem(urlid, dateadded);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

      public virtual ICollection<global::Jellyfin.Data.Entities.CustomItemMetadata> CustomItemMetadata { get; protected set; }

      public virtual ICollection<global::Jellyfin.Data.Entities.Release> Releases { get; protected set; }

   }
}

