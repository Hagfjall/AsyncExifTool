namespace CoenM.ExifToolLib
{
    using System;
    using System.Runtime.Serialization;
    using System.Security.Permissions;

    /// <summary>
    /// AsyncExifTool Initialisation Exception.
    /// </summary>
    [Serializable]
    public sealed class AsyncExifToolInitialisationException : Exception
    {
        internal AsyncExifToolInitialisationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        // Required because AsyncExifToolInitialisationException implements ISerializable interface.
        private AsyncExifToolInitialisationException(SerializationInfo info, StreamingContext context)
#pragma warning disable SYSLIB0051
            : base(info, context)
        {
        }

        /// <inheritdoc/>
#pragma warning disable CS0672 // Member overrides obsolete member
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
#pragma warning restore CS0672 // Member overrides obsolete member
        {
            base.GetObjectData(info, context);
        }
    }
}