using System.Linq;
using SFML.Graphics;

namespace NetGore.IO.PropertySync
{
    /// <summary>
    /// Implementation of a <see cref="PropertySyncBase{T}"/> that handles synchronizing a <see cref="Vector2"/>.
    /// </summary>
    [PropertySyncHandler(typeof(Vector2))]
    public sealed class PropertySyncVector2 : PropertySyncBase<Vector2>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertySyncVector2"/> class.
        /// </summary>
        /// <param name="syncValueAttributeInfo">The <see cref="SyncValueAttributeInfo"/>.</param>
        public PropertySyncVector2(SyncValueAttributeInfo syncValueAttributeInfo) : base(syncValueAttributeInfo)
        {
        }

        /// <summary>
        /// When overridden in the derived class, reads a value with the specified name from an IValueReader.
        /// </summary>
        /// <param name="name">Name of the value.</param>
        /// <param name="reader">IValueReader to read from.</param>
        /// <returns>Value read from the IValueReader.</returns>
        protected override Vector2 Read(string name, IValueReader reader)
        {
            return reader.ReadVector2(name);
        }

        /// <summary>
        /// When overridden in the derived class, writes a value to an IValueWriter with the specified name.
        /// </summary>
        /// <param name="name">Name of the value.</param>
        /// <param name="writer">IValueWriter to write to.</param>
        /// <param name="value">Value to write.</param>
        protected override void Write(string name, IValueWriter writer, Vector2 value)
        {
            writer.Write(name, value);
        }
    }
}