/*
      =========================================================
      $Id: //SocietyObjects/Dev/NextMark/Concepts/Ring1/Places/Interface/IPlacementPackageTemplate.cs#1 $
      $DateTime: 2008/12/18 20:22:26 $
      $Change: 17692 $
      $Author: freblo $
      =========================================================
*/


namespace Concepts.Ring1
{
    /// <summary>
    /// TODO: Summary for class:  IPlacementTemplate
    /// </summary>
    /// <remarks>
    /// TODO: Remarks for class: IPlacementTemplate
    /// In this section, we can put a longer description
    /// <para>
    /// TODO: Paragraph for class: IPlacementTemplate
    /// This is a paragraph describing this class in more detail.
    /// </para>
    /// </remarks>
    /// 
    /// <example>
    /// TODO: Example for class: IPlacementTemplate
    /// This is an example of how to use this class.
    /// </example>
    public interface IPlacementPackageTemplate
    {
        PlacementPackageToBeMovedToExtension PlacementPackage { get; set; }
        bool IgnorePackage { get; set; }
        bool IsEqualTo(PlacementPackageToBeMovedToExtension placement);
    }
}
