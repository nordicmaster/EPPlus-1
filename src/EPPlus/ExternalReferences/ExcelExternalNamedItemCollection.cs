﻿/*************************************************************************************************
  Required Notice: Copyright (C) EPPlus Software AB. 
  This software is licensed under PolyForm Noncommercial License 1.0.0 
  and may only be used for noncommercial purposes 
  https://polyformproject.org/licenses/noncommercial/1.0.0/

  A commercial license to use this software can be purchased at https://epplussoftware.com
 *************************************************************************************************
  Date               Author                       Change
 *************************************************************************************************
  04/16/2021         EPPlus Software AB       EPPlus 5.7
 *************************************************************************************************/
using OfficeOpenXml.Core;
using System;
using System.Collections.Generic;

namespace OfficeOpenXml.ExternalReferences
{
    /// <summary>
    /// A collection of cached defined names in an external workbook
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ExcelExternalNamedItemCollection<T> : EPPlusReadOnlyList<T> where T : IExcelExternalNamedItem
    {
        Dictionary<string, int> _names = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        /// <summary>
        /// Indexer for the collection
        /// </summary>
        /// <param name="name">The name if the defined name</param>
        /// <returns></returns>
        public T this[string name]
        {
            get
            {
                if (_names.ContainsKey(name))
                {
                    return _list[_names[name]];
                }
                return default(T);
            }
        }
        internal override void Add(T item)
        {
            _names.Add(item.Name, _list.Count);
            base.Add(item);
        }
        internal override void Clear()
        {
            base.Clear();
            _names.Clear();
        }
        /// <summary>
        /// If the name exists in the collection
        /// </summary>
        /// <param name="name">The name. Case insensitive</param>
        /// <returns>true if the name exists in the collection, otherwise false</returns>
        public bool ContainsKey(string name)
        {
            return _names.ContainsKey(name);
        }
    }
}
