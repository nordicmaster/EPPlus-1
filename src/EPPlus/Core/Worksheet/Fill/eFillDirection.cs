﻿/*************************************************************************************************
  Required Notice: Copyright (C) EPPlus Software AB. 
  This software is licensed under PolyForm Noncommercial License 1.0.0 
  and may only be used for noncommercial purposes 
  https://polyformproject.org/licenses/noncommercial/1.0.0/

  A commercial license to use this software can be purchased at https://epplussoftware.com
 *************************************************************************************************
  Date               Author                       Change
 *************************************************************************************************
    08/11/2021         EPPlus Software AB       EPPlus 5.8
 *************************************************************************************************/
namespace OfficeOpenXml
{
    /// <summary>
    /// If the fill is performed Down/Up (Column) or Left/Right (Row).
    /// Also see <see cref="eFillStartPosition"/>
    /// </summary>
    public enum eFillDirection
    {
        /// <summary>
        /// The fill is performed row-wise
        /// </summary>
        Row,
        /// <summary>
        /// The fill is performed column-wise
        /// </summary>
        Column
    }
}