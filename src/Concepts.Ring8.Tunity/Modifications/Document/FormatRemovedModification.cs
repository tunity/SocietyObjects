/*
      =========================================================
      $Id: //Tunity/Dev/MarkII/Main/Concepts/Ring8/Project/Accessible.cs#2 $
      $DateTime: 2008/12/12 07:46:28 $
      $Change: 17466 $
      $Author: davros $
      =========================================================
*/

using System;
using Starcounter;
using Concepts.Ring1;
using Concepts.Ring4;


namespace Concepts.Ring8.Tunity
{
    /// <summary>
    /// </summary>
    public class FormatRemovedModification: Modification
    {
        /// <summary>
        /// Add modification
        /// </summary>
        /// <param name="modifier"></param>
        /// <param name="doc"></param>
        public FormatRemovedModification(DateTime time, Person modifier, VersionDataFile file) :
            base(time, modifier, ModificationType.DOCUMENT)
        {
            DocumentName = "";
            VersionNumber = 0;
            if ((file != null) && (file.Owner != null))
            {
                VersionNumber = file.Owner.VersionNumber;
                Document doc = file.Owner.Owner;
                if (doc != null)
                {
                    DocumentName = doc.Name;
                    AddTarget(doc);
                }
            }
        }

        public int VersionNumber;

        [SynonymousTo("Description")]
        public String DocumentName;

        public override String LongDescription
        {
            get
            {
               return"";// String.Format(
                     // Yesugi.ResourceManager.GetString("Modification.FormatRemoved"),
                     // VersionNumber, DocumentName);
            }
        }

      
    }
}