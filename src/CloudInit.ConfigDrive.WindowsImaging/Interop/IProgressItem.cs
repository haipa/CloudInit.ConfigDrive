using System.Runtime.InteropServices;

// ReSharper disable UnusedMember.Global

namespace Haipa.CloudInit.ConfigDrive.Interop
{
    [TypeLibType(TypeLibTypeFlags.FDual |
                 TypeLibTypeFlags.FDispatchable |
                 TypeLibTypeFlags.FNonExtensible)]
    [Guid("2C941FD5-975B-59BE-A960-9A2A262853A5")]
    public interface IProgressItem
    {
        /// <summary>
        /// Progress item description
        /// </summary>
        [DispId(1)]
        string Description { [return: MarshalAs(UnmanagedType.BStr)] get; }

        /// <summary>
        /// First block in the range of blocks used by the progress item
        /// </summary>
        [DispId(2)]
        uint FirstBlock { get; }

        /// <summary>
        /// Last block in the range of blocks used by the progress item
        /// </summary>
        [DispId(3)]
        uint LastBlock { get; }

        /// <summary>
        /// Number of blocks used by the progress item
        /// </summary>
        [DispId(4)]
        uint BlockCount { get; }
    }
}