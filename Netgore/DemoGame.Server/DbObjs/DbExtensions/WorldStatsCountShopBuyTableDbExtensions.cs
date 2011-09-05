/********************************************************************
                   DO NOT MANUALLY EDIT THIS FILE!

This file was automatically generated using the DbClassCreator
program. The only time you should ever alter this file is if you are
using an automated code formatter. The DbClassCreator will overwrite
this file every time it is run, so all manual changes will be lost.
If there is something in this file that you wish to change, you should
be able to do it through the DbClassCreator arguments.

Make sure that you re-run the DbClassCreator every time you alter your
game's database.

For more information on the DbClassCreator, please see:
    http://www.netgore.com/wiki/dbclasscreator.html
********************************************************************/

using System;
using System.Data;
using System.Linq;
using DemoGame.DbObjs;
using NetGore.Db;
using NetGore.Features.Shops;

namespace DemoGame.Server.DbObjs
{
    /// <summary>
    /// Contains extension methods for class WorldStatsCountShopBuyTable that assist in performing
    /// reads and writes to and from a database.
    /// </summary>
    public static class WorldStatsCountShopBuyTableDbExtensions
    {
        /// <summary>
        /// Copies the column values into the given DbParameterValues using the database column name
        /// with a prefixed @ as the key. The keys must already exist in the DbParameterValues;
        ///  this method will not create them if they are missing.
        /// </summary>
        /// <param name="source">The object to copy the values from.</param>
        /// <param name="paramValues">The DbParameterValues to copy the values into.</param>
        public static void CopyValues(this IWorldStatsCountShopBuyTable source, DbParameterValues paramValues)
        {
            paramValues["count"] = source.Count;
            paramValues["last_update"] = source.LastUpdate;
            paramValues["shop_id"] = (UInt16)source.ShopID;
        }

        /// <summary>
        /// Checks if this <see cref="IWorldStatsCountShopBuyTable"/> contains the same values as another <see cref="IWorldStatsCountShopBuyTable"/>.
        /// </summary>
        /// <param name="source">The source <see cref="IWorldStatsCountShopBuyTable"/>.</param>
        /// <param name="otherItem">The <see cref="IWorldStatsCountShopBuyTable"/> to compare the values to.</param>
        /// <returns>
        /// True if this <see cref="IWorldStatsCountShopBuyTable"/> contains the same values as the <paramref name="otherItem"/>; otherwise false.
        /// </returns>
        public static Boolean HasSameValues(this IWorldStatsCountShopBuyTable source, IWorldStatsCountShopBuyTable otherItem)
        {
            return Equals(source.Count, otherItem.Count) && Equals(source.LastUpdate, otherItem.LastUpdate) &&
                   Equals(source.ShopID, otherItem.ShopID);
        }

        /// <summary>
        /// Reads the values from an <see cref="IDataRecord"/> and assigns the read values to this
        /// object's properties. The database column's name is used to as the key, so the value
        /// will not be found if any aliases are used or not all columns were selected.
        /// </summary>
        /// <param name="source">The object to add the extension method to.</param>
        /// <param name="dataRecord">The <see cref="IDataRecord"/> to read the values from. Must already be ready to be read from.</param>
        public static void ReadValues(this WorldStatsCountShopBuyTable source, IDataRecord dataRecord)
        {
            Int32 i;

            i = dataRecord.GetOrdinal("count");

            source.Count = dataRecord.GetInt32(i);

            i = dataRecord.GetOrdinal("last_update");

            source.LastUpdate = dataRecord.GetDateTime(i);

            i = dataRecord.GetOrdinal("shop_id");

            source.ShopID = (ShopID)dataRecord.GetUInt16(i);
        }

        /// <summary>
        /// Copies the column values into the given DbParameterValues using the database column name
        /// with a prefixed @ as the key. The key must already exist in the DbParameterValues
        /// for the value to be copied over. If any of the keys in the DbParameterValues do not
        /// match one of the column names, or if there is no field for a key, then it will be
        /// ignored. Because of this, it is important to be careful when using this method
        /// since columns or keys can be skipped without any indication.
        /// </summary>
        /// <param name="source">The object to copy the values from.</param>
        /// <param name="paramValues">The DbParameterValues to copy the values into.</param>
        public static void TryCopyValues(this IWorldStatsCountShopBuyTable source, DbParameterValues paramValues)
        {
            for (var i = 0; i < paramValues.Count; i++)
            {
                switch (paramValues.GetParameterName(i))
                {
                    case "count":
                        paramValues[i] = source.Count;
                        break;

                    case "last_update":
                        paramValues[i] = source.LastUpdate;
                        break;

                    case "shop_id":
                        paramValues[i] = (UInt16)source.ShopID;
                        break;
                }
            }
        }

        /// <summary>
        /// Reads the values from an <see cref="IDataReader"/> and assigns the read values to this
        /// object's properties. Unlike ReadValues(), this method not only doesn't require
        /// all values to be in the <see cref="IDataReader"/>, but also does not require the values in
        /// the <see cref="IDataReader"/> to be a defined field for the table this class represents.
        /// Because of this, you need to be careful when using this method because values
        /// can easily be skipped without any indication.
        /// </summary>
        /// <param name="source">The object to add the extension method to.</param>
        /// <param name="dataRecord">The <see cref="IDataReader"/> to read the values from. Must already be ready to be read from.</param>
        public static void TryReadValues(this WorldStatsCountShopBuyTable source, IDataRecord dataRecord)
        {
            for (var i = 0; i < dataRecord.FieldCount; i++)
            {
                switch (dataRecord.GetName(i))
                {
                    case "count":
                        source.Count = dataRecord.GetInt32(i);
                        break;

                    case "last_update":
                        source.LastUpdate = dataRecord.GetDateTime(i);
                        break;

                    case "shop_id":
                        source.ShopID = (ShopID)dataRecord.GetUInt16(i);
                        break;
                }
            }
        }
    }
}